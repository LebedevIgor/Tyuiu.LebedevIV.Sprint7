
namespace Tyuiu.LebedevIV.Sprint7.Project.V6
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PanelTopChart_LIV = new System.Windows.Forms.Panel();
            this.LabelNameChart_LIV = new System.Windows.Forms.Label();
            this.ButtonBackChart_LIV = new System.Windows.Forms.Button();
            this.GroupBoxChart_LIV = new System.Windows.Forms.GroupBox();
            this.ComboBoxChart_LIV = new System.Windows.Forms.ComboBox();
            this.ToolTipChart_LIV = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonOpenChart_LIV = new System.Windows.Forms.Button();
            this.ButtonDoneChart_LIV = new System.Windows.Forms.Button();
            this.ButtonChartAdd_LIV = new System.Windows.Forms.Button();
            this.ButtonDelete_LIV = new System.Windows.Forms.Button();
            this.ButtonSave_LIV = new System.Windows.Forms.Button();
            this.DataGridViewChart_LIV = new System.Windows.Forms.DataGridView();
            this.CodeCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNameCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileDialogChart_LIV = new System.Windows.Forms.OpenFileDialog();
            this.PanelLeftChart_LIV = new System.Windows.Forms.Panel();
            this.Chart_LIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SaveFileDialogChart_LIV = new System.Windows.Forms.SaveFileDialog();
            this.PanelTopChart_LIV.SuspendLayout();
            this.GroupBoxChart_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChart_LIV)).BeginInit();
            this.PanelLeftChart_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopChart_LIV
            // 
            this.PanelTopChart_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTopChart_LIV.Controls.Add(this.LabelNameChart_LIV);
            this.PanelTopChart_LIV.Controls.Add(this.ButtonBackChart_LIV);
            this.PanelTopChart_LIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopChart_LIV.Location = new System.Drawing.Point(0, 0);
            this.PanelTopChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelTopChart_LIV.Name = "PanelTopChart_LIV";
            this.PanelTopChart_LIV.Size = new System.Drawing.Size(1595, 123);
            this.PanelTopChart_LIV.TabIndex = 0;
            // 
            // LabelNameChart_LIV
            // 
            this.LabelNameChart_LIV.AutoSize = true;
            this.LabelNameChart_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameChart_LIV.ForeColor = System.Drawing.Color.White;
            this.LabelNameChart_LIV.Location = new System.Drawing.Point(588, 30);
            this.LabelNameChart_LIV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNameChart_LIV.Name = "LabelNameChart_LIV";
            this.LabelNameChart_LIV.Size = new System.Drawing.Size(501, 52);
            this.LabelNameChart_LIV.TabIndex = 14;
            this.LabelNameChart_LIV.Text = "Диаграмма пациентов";
            // 
            // ButtonBackChart_LIV
            // 
            this.ButtonBackChart_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBackChart_LIV.BackgroundImage")));
            this.ButtonBackChart_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonBackChart_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackChart_LIV.Location = new System.Drawing.Point(17, 16);
            this.ButtonBackChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonBackChart_LIV.Name = "ButtonBackChart_LIV";
            this.ButtonBackChart_LIV.Size = new System.Drawing.Size(104, 58);
            this.ButtonBackChart_LIV.TabIndex = 0;
            this.ToolTipChart_LIV.SetToolTip(this.ButtonBackChart_LIV, "Вернуться на главную страницу");
            this.ButtonBackChart_LIV.UseVisualStyleBackColor = true;
            this.ButtonBackChart_LIV.Click += new System.EventHandler(this.ButtonBackChart_LIV_Click);
            // 
            // GroupBoxChart_LIV
            // 
            this.GroupBoxChart_LIV.Controls.Add(this.ComboBoxChart_LIV);
            this.GroupBoxChart_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GroupBoxChart_LIV.Location = new System.Drawing.Point(1151, 130);
            this.GroupBoxChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxChart_LIV.Name = "GroupBoxChart_LIV";
            this.GroupBoxChart_LIV.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxChart_LIV.Size = new System.Drawing.Size(222, 72);
            this.GroupBoxChart_LIV.TabIndex = 3;
            this.GroupBoxChart_LIV.TabStop = false;
            this.GroupBoxChart_LIV.Text = "Выбор категории";
            // 
            // ComboBoxChart_LIV
            // 
            this.ComboBoxChart_LIV.FormattingEnabled = true;
            this.ComboBoxChart_LIV.Items.AddRange(new object[] {
            "Заболевания сердца",
            "Простуда",
            "Заболевание ЖКТ",
            "Травмы",
            "Онкология",
            "Заболевания МИП",
            "Все"});
            this.ComboBoxChart_LIV.Location = new System.Drawing.Point(8, 28);
            this.ComboBoxChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxChart_LIV.Name = "ComboBoxChart_LIV";
            this.ComboBoxChart_LIV.Size = new System.Drawing.Size(195, 33);
            this.ComboBoxChart_LIV.TabIndex = 0;
            this.ComboBoxChart_LIV.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChart_LIV_SelectedIndexChanged);
            // 
            // ToolTipChart_LIV
            // 
            this.ToolTipChart_LIV.IsBalloon = true;
            this.ToolTipChart_LIV.ToolTipTitle = "Подсказка";
            // 
            // ButtonOpenChart_LIV
            // 
            this.ButtonOpenChart_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpenChart_LIV.BackgroundImage")));
            this.ButtonOpenChart_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpenChart_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenChart_LIV.Location = new System.Drawing.Point(684, 130);
            this.ButtonOpenChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonOpenChart_LIV.Name = "ButtonOpenChart_LIV";
            this.ButtonOpenChart_LIV.Size = new System.Drawing.Size(105, 78);
            this.ButtonOpenChart_LIV.TabIndex = 8;
            this.ToolTipChart_LIV.SetToolTip(this.ButtonOpenChart_LIV, "Загрузить данные");
            this.ButtonOpenChart_LIV.UseVisualStyleBackColor = true;
            this.ButtonOpenChart_LIV.Click += new System.EventHandler(this.ButtonOpenChart_LIV_Click);
            // 
            // ButtonDoneChart_LIV
            // 
            this.ButtonDoneChart_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonDoneChart_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDoneChart_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonDoneChart_LIV.Location = new System.Drawing.Point(1381, 143);
            this.ButtonDoneChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDoneChart_LIV.Name = "ButtonDoneChart_LIV";
            this.ButtonDoneChart_LIV.Size = new System.Drawing.Size(178, 59);
            this.ButtonDoneChart_LIV.TabIndex = 10;
            this.ButtonDoneChart_LIV.Text = "Выполнить";
            this.ToolTipChart_LIV.SetToolTip(this.ButtonDoneChart_LIV, "Построить диаграму срока потери трудоспсобности");
            this.ButtonDoneChart_LIV.UseVisualStyleBackColor = false;
            this.ButtonDoneChart_LIV.Click += new System.EventHandler(this.ButtonDoneChart_LIV_Click);
            // 
            // ButtonChartAdd_LIV
            // 
            this.ButtonChartAdd_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonChartAdd_LIV.BackgroundImage")));
            this.ButtonChartAdd_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonChartAdd_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChartAdd_LIV.Location = new System.Drawing.Point(911, 130);
            this.ButtonChartAdd_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonChartAdd_LIV.Name = "ButtonChartAdd_LIV";
            this.ButtonChartAdd_LIV.Size = new System.Drawing.Size(105, 78);
            this.ButtonChartAdd_LIV.TabIndex = 13;
            this.ToolTipChart_LIV.SetToolTip(this.ButtonChartAdd_LIV, "Добавить строку");
            this.ButtonChartAdd_LIV.UseVisualStyleBackColor = true;
            this.ButtonChartAdd_LIV.Click += new System.EventHandler(this.ButtonChartAdd_LIV_Click);
            // 
            // ButtonDelete_LIV
            // 
            this.ButtonDelete_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete_LIV.BackgroundImage")));
            this.ButtonDelete_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDelete_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete_LIV.Location = new System.Drawing.Point(1024, 130);
            this.ButtonDelete_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDelete_LIV.Name = "ButtonDelete_LIV";
            this.ButtonDelete_LIV.Size = new System.Drawing.Size(105, 78);
            this.ButtonDelete_LIV.TabIndex = 19;
            this.ToolTipChart_LIV.SetToolTip(this.ButtonDelete_LIV, "Удалить строку");
            this.ButtonDelete_LIV.UseVisualStyleBackColor = true;
            this.ButtonDelete_LIV.Click += new System.EventHandler(this.ButtonDelete_LIV_Click);
            // 
            // ButtonSave_LIV
            // 
            this.ButtonSave_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave_LIV.BackgroundImage")));
            this.ButtonSave_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave_LIV.Location = new System.Drawing.Point(797, 130);
            this.ButtonSave_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSave_LIV.Name = "ButtonSave_LIV";
            this.ButtonSave_LIV.Size = new System.Drawing.Size(105, 78);
            this.ButtonSave_LIV.TabIndex = 20;
            this.ToolTipChart_LIV.SetToolTip(this.ButtonSave_LIV, "Сохранить данные");
            this.ButtonSave_LIV.UseVisualStyleBackColor = true;
            this.ButtonSave_LIV.Click += new System.EventHandler(this.ButtonSave_LIV_Click);
            // 
            // DataGridViewChart_LIV
            // 
            this.DataGridViewChart_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChart_LIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeCh,
            this.DataNameCh,
            this.CategoryCh,
            this.QuantityCh,
            this.PriceCh});
            this.DataGridViewChart_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridViewChart_LIV.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewChart_LIV.Name = "DataGridViewChart_LIV";
            this.DataGridViewChart_LIV.RowHeadersVisible = false;
            this.DataGridViewChart_LIV.RowHeadersWidth = 51;
            this.DataGridViewChart_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewChart_LIV.Size = new System.Drawing.Size(672, 715);
            this.DataGridViewChart_LIV.TabIndex = 4;
            // 
            // CodeCh
            // 
            this.CodeCh.HeaderText = "Код";
            this.CodeCh.MinimumWidth = 6;
            this.CodeCh.Name = "CodeCh";
            this.CodeCh.Width = 125;
            // 
            // DataNameCh
            // 
            this.DataNameCh.HeaderText = "ФИО";
            this.DataNameCh.MinimumWidth = 6;
            this.DataNameCh.Name = "DataNameCh";
            this.DataNameCh.Width = 125;
            // 
            // CategoryCh
            // 
            this.CategoryCh.HeaderText = "Диагноз";
            this.CategoryCh.MinimumWidth = 6;
            this.CategoryCh.Name = "CategoryCh";
            this.CategoryCh.Width = 125;
            // 
            // QuantityCh
            // 
            this.QuantityCh.HeaderText = "Общий срок потери трудоспособности";
            this.QuantityCh.MinimumWidth = 6;
            this.QuantityCh.Name = "QuantityCh";
            this.QuantityCh.Width = 125;
            // 
            // PriceCh
            // 
            this.PriceCh.HeaderText = "Длительность последней потери трудоспособности";
            this.PriceCh.MinimumWidth = 6;
            this.PriceCh.Name = "PriceCh";
            this.PriceCh.Width = 125;
            // 
            // OpenFileDialogChart_LIV
            // 
            this.OpenFileDialogChart_LIV.FileName = "OpenFileDialogChart_LIV";
            // 
            // PanelLeftChart_LIV
            // 
            this.PanelLeftChart_LIV.Controls.Add(this.DataGridViewChart_LIV);
            this.PanelLeftChart_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftChart_LIV.Location = new System.Drawing.Point(0, 123);
            this.PanelLeftChart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelLeftChart_LIV.Name = "PanelLeftChart_LIV";
            this.PanelLeftChart_LIV.Size = new System.Drawing.Size(676, 715);
            this.PanelLeftChart_LIV.TabIndex = 9;
            // 
            // Chart_LIV
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_LIV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Chart_LIV.Legends.Add(legend1);
            this.Chart_LIV.Location = new System.Drawing.Point(684, 216);
            this.Chart_LIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chart_LIV.Name = "Chart_LIV";
            this.Chart_LIV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_LIV.Series.Add(series1);
            this.Chart_LIV.Size = new System.Drawing.Size(875, 474);
            this.Chart_LIV.TabIndex = 1;
            this.Chart_LIV.Text = "chart1";
            title1.Name = "Title";
            title1.Text = "Обший срок потери трудоспособности";
            this.Chart_LIV.Titles.Add(title1);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 838);
            this.Controls.Add(this.ButtonSave_LIV);
            this.Controls.Add(this.ButtonDelete_LIV);
            this.Controls.Add(this.Chart_LIV);
            this.Controls.Add(this.ButtonChartAdd_LIV);
            this.Controls.Add(this.ButtonDoneChart_LIV);
            this.Controls.Add(this.ButtonOpenChart_LIV);
            this.Controls.Add(this.GroupBoxChart_LIV);
            this.Controls.Add(this.PanelLeftChart_LIV);
            this.Controls.Add(this.PanelTopChart_LIV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTopChart_LIV.ResumeLayout(false);
            this.PanelTopChart_LIV.PerformLayout();
            this.GroupBoxChart_LIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChart_LIV)).EndInit();
            this.PanelLeftChart_LIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_LIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopChart_LIV;
        private System.Windows.Forms.Button ButtonBackChart_LIV;
        private System.Windows.Forms.GroupBox GroupBoxChart_LIV;
        private System.Windows.Forms.ComboBox ComboBoxChart_LIV;
        private System.Windows.Forms.ToolTip ToolTipChart_LIV;
        private System.Windows.Forms.Label LabelNameChart_LIV;
        private System.Windows.Forms.DataGridView DataGridViewChart_LIV;
        private System.Windows.Forms.Button ButtonOpenChart_LIV;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogChart_LIV;
        private System.Windows.Forms.Panel PanelLeftChart_LIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_LIV;
        private System.Windows.Forms.Button ButtonDoneChart_LIV;
        private System.Windows.Forms.Button ButtonChartAdd_LIV;
        private System.Windows.Forms.Button ButtonDelete_LIV;
        private System.Windows.Forms.Button ButtonSave_LIV;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogChart_LIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNameCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCh;
    }
}