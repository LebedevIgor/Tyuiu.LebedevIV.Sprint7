using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.LebedevIV.Sprint7.Project.V6.Lib;


namespace Tyuiu.LebedevIV.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        private string[,] gridData;

        private void ButtonChart_LIV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChart formChart = new FormChart();
            formChart.Show();
        }

        private void ButtonInfo_LIV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void ButtonHelp_LIV_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.ShowDialog();
        }

        private void ButtonOpen_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialogMain_LIV.ShowDialog();
                openFilePath = OpenFileDialogMain_LIV.FileName;

                gridData = ds.LoadFromDataFile(openFilePath);

                rows = gridData.GetLength(0);
                columns = gridData.GetLength(1);

                DataGridViewMain_LIV.RowCount = rows + 1;
                DataGridViewMain_LIV.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataGridViewMain_LIV.Rows[i].Cells[j].Value = gridData[i, j];
                    }
                }
                DataGridViewMain_LIV.AutoResizeColumns();
                DataGridViewMain_LIV.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialogMain_LIV.FileName = ".csv";
                SaveFileDialogMain_LIV.InitialDirectory = @":L";
                if (SaveFileDialogMain_LIV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = SaveFileDialogMain_LIV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);
                    int rows = gridData.GetLength(0);
                    int columns = gridData.GetLength(1);

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(gridData[i, j]);

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

        private void TextBoxSearch_LIV_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxSearch_LIV.Text.ToLower();
            for (int i = 0; i < DataGridViewMain_LIV.Rows.Count; i++)
            {
                if (gridData.GetLength(0) > i && gridData.GetLength(1) >= 3)
                {
                    if (DataGridViewMain_LIV.Rows[i].Visible)
                    {
                        string column1Text = gridData[i, 0].ToLower();
                        string column2Text = gridData[i, 1].ToLower();
                        string column3Text = gridData[i, 2].ToLower();

                        if (column1Text.Contains(searchText) || column2Text.Contains(searchText) || column3Text.Contains(searchText))
                        {
                            DataGridViewMain_LIV.Rows[i].Visible = true;
                        }
                        else
                        {
                            DataGridViewMain_LIV.Rows[i].Visible = false;
                        }
                    }
                }
            }
        }

        private void ButtonSum_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = 0;
                double[] values = new double[rows];

                for (int i = 0; i < rows; i++)
                {
                    if (DataGridViewMain_LIV.Rows[i].Visible)
                    {
                        double cellValue;
                        if (double.TryParse(gridData[i, 3], out cellValue))
                        {
                            values[visibleRowCount] = cellValue;
                            visibleRowCount++;
                        }
                    }
                }

                if (visibleRowCount > 0)
                {
                    double res = ds.CalculateSum(values);
                    TextBoxSum_LIV.Text = Math.Round(res, 2).ToString();
                }
                else
                {
                    TextBoxSum_LIV.Text = "Нет данных для подсчета";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAverage_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = 0;
                double sumVisibleValues = 0;
                double[] valuesAv = new double[rows];

                for (int i = 0; i < rows; i++)
                {
                    if (DataGridViewMain_LIV.Rows[i].Visible)
                    {
                        double valuesAverage;
                        if (double.TryParse(gridData[i, 4], out valuesAverage))
                        {
                            valuesAv[visibleRowCount] = valuesAverage;
                            sumVisibleValues += valuesAverage;
                            visibleRowCount++;
                        }
                    }
                }

                if (visibleRowCount > 0)
                {
                    double average = ds.CalculateAverage(valuesAv, visibleRowCount);
                    TextBoxAverage_LIV.Text = Math.Round(average, 2).ToString();
                }
                else
                {
                    TextBoxAverage_LIV.Text = "Нет данных для подсчета";
                }

            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDelete_LIV_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain_LIV.RowCount != 0)
            {
                if (DataGridViewMain_LIV.RowCount != 0)
                {
                    int valueDel = 0;
                    var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes) valueDel = 1;
                    if (valueDel == 1)
                    {
                        int del = DataGridViewMain_LIV.CurrentCell.RowIndex;
                        DataGridViewMain_LIV.Rows.Remove(DataGridViewMain_LIV.Rows[del]);
                    }
                }
                else
                {
                    MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewMain_LIV.Rows.Add();

            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxFilt_LIV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string valueFilt = ComboBoxFilt_LIV.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in DataGridViewMain_LIV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells["Category"].Value != null && row.Cells["Category"].Value.ToString() == valueFilt)
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
        }

        private void ComboBoxSort_LIV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort_LIV.SelectedItem != null)
            {
                int columnIndex = 3;
                string selectedItem = ComboBoxSort_LIV.SelectedItem.ToString();
                bool empty = false;

                for (int i = 0; i < DataGridViewMain_LIV.Rows.Count - 1; i++)
                {
                    if (DataGridViewMain_LIV.Rows[i].Cells[columnIndex].Value == null ||
                        string.IsNullOrWhiteSpace(DataGridViewMain_LIV.Rows[i].Cells[columnIndex].Value.ToString()))
                    {
                        empty = true;
                        break;
                    }
                }

                if (empty)
                {
                    MessageBox.Show("Удалите пустые строки (кроме последней)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (DataGridViewRow row in DataGridViewMain_LIV.Rows)
                {
                    double cellValue;
                    if (row.Cells[columnIndex].Value != null && double.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                }
                try
                {
                    DataGridViewColumn column = DataGridViewMain_LIV.Columns[3];

                    if (selectedItem == "All")
                    {
                        int rows = gridData.GetLength(0);
                        int columns = gridData.GetLength(1);
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                DataGridViewMain_LIV.Rows[i].Cells[j].Value = gridData[i, j];
                            }
                            DataGridViewMain_LIV.Rows[i].Visible = true;
                        }
                        return; 
                    }

                    if (selectedItem == "Минимум")
                    {
                        DataGridViewMain_LIV.Sort(column, ListSortDirection.Ascending);
                    }
                    if (selectedItem == "Максимум")
                    {
                        DataGridViewMain_LIV.Sort(column, ListSortDirection.Descending);
                    }

                }
                catch
                {
                    MessageBox.Show("Невозможно выполнить сортировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridViewMain_LIV_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    double cellValue = 0.0;
                    if (double.TryParse(e.Value.ToString(), out cellValue))
                    {
                        e.ParsingApplied = true;
                        e.Value = cellValue;
                    }
                }
            }
        }

        private void ButtonMin_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 4;
                bool foundValue = false;
                double minValue = double.MaxValue; 

                for (int i = 0; i < rows; i++) 
                {
                    if (DataGridViewMain_LIV.Rows[i].Visible)
                    {
                        if (!string.IsNullOrWhiteSpace(gridData[i, columnIndex])) 
                        {
                            double currentValue;
                            if (double.TryParse(gridData[i, columnIndex], out currentValue)) 
                            {
                                foundValue = true; 
                                if (currentValue < minValue)
                                {
                                    minValue = currentValue;
                                }
                            }
                        }
                    }
                }

                if (foundValue)
                {
                    TextBoxMin_LIV.Text = minValue.ToString();
                }
                else
                {
                    TextBoxMin_LIV.Text = "Нет данных для нахождения минимума";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMax_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                double[] values = new double[gridData.GetLength(0)];

                for (int i = 0; i < gridData.GetLength(0); i++)
                {
                    if (DataGridViewMain_LIV.Rows[i].Visible)
                    {
                        double valuesMax;
                        if (double.TryParse(gridData[i, 4], out valuesMax))
                        {
                            values[i] = valuesMax;
                        }
                    }
                }
                double max = ds.FindMaximumValue(values);
                TextBoxMax_LIV.Text = max.ToString();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
