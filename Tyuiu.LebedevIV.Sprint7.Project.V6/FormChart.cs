using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint7.Project.V6.Lib;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint7.Project.V6
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void ButtonBackChart_LIV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void ButtonOpenChart_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialogChart_LIV.ShowDialog();
                openFilePath = OpenFileDialogChart_LIV.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                DataGridViewChart_LIV.RowCount = rows + 1;
                DataGridViewChart_LIV.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataGridViewChart_LIV.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                DataGridViewChart_LIV.AutoResizeColumns();
                DataGridViewChart_LIV.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxChart_LIV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = ComboBoxChart_LIV.SelectedItem.ToString();

            foreach (DataGridViewRow row in DataGridViewChart_LIV.Rows)
            {
                if (!row.IsNewRow) // проверка новая ли строка
                {
                    if (row.Cells["CategoryCh"].Value != null && row.Cells["CategoryCh"].Value.ToString() == valueFilt)
                    {
                        row.Visible = true;

                    }
                    else
                    {
                        row.Visible = false;
                    }
                    if (valueFilt == "Все")
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void ButtonDoneChart_LIV_Click(object sender, EventArgs e)
        {
            try
            {

                Chart_LIV.Series.Clear();

                Chart_LIV.Series.Add("DataSeries");
                Chart_LIV.Series["DataSeries"].ChartType = SeriesChartType.Column;


                foreach (DataGridViewRow row in DataGridViewChart_LIV.Rows)
                {
                    if (row.Cells[3].Value != null)
                    {
                        if (row.Visible)
                        {
                            string labelOne = row.Cells[1].Value.ToString();
                            double valueFour = Convert.ToDouble(row.Cells[3].Value);

                            Chart_LIV.Series["DataSeries"].Points.AddXY(labelOne, valueFour);
                        }
                    }
                }

                Chart_LIV.Update();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonChartAdd_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewChart_LIV.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialogChart_LIV.FileName = ".csv";
                SaveFileDialogChart_LIV.InitialDirectory = @":L";
                if (SaveFileDialogChart_LIV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = SaveFileDialogChart_LIV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = DataGridViewChart_LIV.RowCount;
                    int columns = DataGridViewChart_LIV.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewChart_LIV.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDelete_LIV_Click(object sender, EventArgs e)
        {
            if (DataGridViewChart_LIV.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = DataGridViewChart_LIV.CurrentCell.RowIndex;
                    DataGridViewChart_LIV.Rows.Remove(DataGridViewChart_LIV.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
