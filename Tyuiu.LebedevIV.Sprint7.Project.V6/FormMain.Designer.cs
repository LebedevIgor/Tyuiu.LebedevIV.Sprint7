
namespace Tyuiu.LebedevIV.Sprint7.Project.V6
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonChart_LIV = new System.Windows.Forms.Button();
            this.DataGridViewMain_LIV = new System.Windows.Forms.DataGridView();
            this.GroupBoxSort_LIV = new System.Windows.Forms.GroupBox();
            this.ComboBoxSort_LIV = new System.Windows.Forms.ComboBox();
            this.GroupBoxFilt_LIV = new System.Windows.Forms.GroupBox();
            this.ComboBoxFilt_LIV = new System.Windows.Forms.ComboBox();
            this.LabelSearch_LIV = new System.Windows.Forms.Label();
            this.TextBoxSearch_LIV = new System.Windows.Forms.TextBox();
            this.ButtonOpen_LIV = new System.Windows.Forms.Button();
            this.ButtonSave_LIV = new System.Windows.Forms.Button();
            this.PanelTop_LIV = new System.Windows.Forms.Panel();
            this.LabelName_LIV = new System.Windows.Forms.Label();
            this.ButtonInfo_LIV = new System.Windows.Forms.Button();
            this.ButtonHelp_LIV = new System.Windows.Forms.Button();
            this.ToolTip_LIV = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonAdd_LIV = new System.Windows.Forms.Button();
            this.ButtonSum_LIV = new System.Windows.Forms.Button();
            this.ButtonAverage_LIV = new System.Windows.Forms.Button();
            this.ButtonDelete_LIV = new System.Windows.Forms.Button();
            this.ButtonMax_LIV = new System.Windows.Forms.Button();
            this.ButtonMin_LIV = new System.Windows.Forms.Button();
            this.OpenFileDialogMain_LIV = new System.Windows.Forms.OpenFileDialog();
            this.PanelLeft_LIV = new System.Windows.Forms.Panel();
            this.TextBoxSum_LIV = new System.Windows.Forms.TextBox();
            this.TextBoxAverage_LIV = new System.Windows.Forms.TextBox();
            this.SaveFileDialogMain_LIV = new System.Windows.Forms.SaveFileDialog();
            this.TextBoxMax_LIV = new System.Windows.Forms.TextBox();
            this.TextBoxMin_LIV = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain_LIV)).BeginInit();
            this.GroupBoxSort_LIV.SuspendLayout();
            this.GroupBoxFilt_LIV.SuspendLayout();
            this.PanelTop_LIV.SuspendLayout();
            this.PanelLeft_LIV.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonChart_LIV
            // 
            this.ButtonChart_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonChart_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChart_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChart_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonChart_LIV.Location = new System.Drawing.Point(1016, 106);
            this.ButtonChart_LIV.Name = "ButtonChart_LIV";
            this.ButtonChart_LIV.Size = new System.Drawing.Size(83, 56);
            this.ButtonChart_LIV.TabIndex = 0;
            this.ButtonChart_LIV.Text = "Построить график пациентов";
            this.ToolTip_LIV.SetToolTip(this.ButtonChart_LIV, "Перейти и построить график");
            this.ButtonChart_LIV.UseVisualStyleBackColor = false;
            this.ButtonChart_LIV.Click += new System.EventHandler(this.ButtonChart_LIV_Click);
            // 
            // DataGridViewMain_LIV
            // 
            this.DataGridViewMain_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain_LIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.FIO,
            this.Category,
            this.Quantity,
            this.Duration,
            this.FIO_Doctor});
            this.DataGridViewMain_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridViewMain_LIV.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewMain_LIV.Name = "DataGridViewMain_LIV";
            this.DataGridViewMain_LIV.RowHeadersVisible = false;
            this.DataGridViewMain_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridViewMain_LIV.Size = new System.Drawing.Size(647, 510);
            this.DataGridViewMain_LIV.TabIndex = 2;
            this.DataGridViewMain_LIV.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGridViewMain_LIV_CellParsing);
            // 
            // GroupBoxSort_LIV
            // 
            this.GroupBoxSort_LIV.Controls.Add(this.ComboBoxSort_LIV);
            this.GroupBoxSort_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxSort_LIV.Location = new System.Drawing.Point(889, 216);
            this.GroupBoxSort_LIV.Name = "GroupBoxSort_LIV";
            this.GroupBoxSort_LIV.Size = new System.Drawing.Size(210, 77);
            this.GroupBoxSort_LIV.TabIndex = 3;
            this.GroupBoxSort_LIV.TabStop = false;
            this.GroupBoxSort_LIV.Text = "Сортировка по кол. общих дней бол.";
            // 
            // ComboBoxSort_LIV
            // 
            this.ComboBoxSort_LIV.FormattingEnabled = true;
            this.ComboBoxSort_LIV.Items.AddRange(new object[] {
            "Максимум",
            "Минимум",
            "All"});
            this.ComboBoxSort_LIV.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxSort_LIV.Name = "ComboBoxSort_LIV";
            this.ComboBoxSort_LIV.Size = new System.Drawing.Size(198, 28);
            this.ComboBoxSort_LIV.TabIndex = 0;
            this.ToolTip_LIV.SetToolTip(this.ComboBoxSort_LIV, "Пожалуйста, перед использованием удалите все пустые строки, кроме последней");
            this.ComboBoxSort_LIV.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_LIV_SelectedIndexChanged);
            // 
            // GroupBoxFilt_LIV
            // 
            this.GroupBoxFilt_LIV.Controls.Add(this.ComboBoxFilt_LIV);
            this.GroupBoxFilt_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxFilt_LIV.Location = new System.Drawing.Point(658, 216);
            this.GroupBoxFilt_LIV.Name = "GroupBoxFilt_LIV";
            this.GroupBoxFilt_LIV.Size = new System.Drawing.Size(225, 77);
            this.GroupBoxFilt_LIV.TabIndex = 4;
            this.GroupBoxFilt_LIV.TabStop = false;
            this.GroupBoxFilt_LIV.Text = "Выбор категории";
            // 
            // ComboBoxFilt_LIV
            // 
            this.ComboBoxFilt_LIV.FormattingEnabled = true;
            this.ComboBoxFilt_LIV.Items.AddRange(new object[] {
            "Заболевания сердца",
            "Простуда",
            "Заболевание ЖКТ",
            "Травмы",
            "Онкология",
            "Заболевания МИП",
            "Все"});
            this.ComboBoxFilt_LIV.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxFilt_LIV.Name = "ComboBoxFilt_LIV";
            this.ComboBoxFilt_LIV.Size = new System.Drawing.Size(213, 28);
            this.ComboBoxFilt_LIV.TabIndex = 0;
            this.ComboBoxFilt_LIV.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilt_LIV_SelectedIndexChanged_1);
            // 
            // LabelSearch_LIV
            // 
            this.LabelSearch_LIV.AutoSize = true;
            this.LabelSearch_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.LabelSearch_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearch_LIV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelSearch_LIV.Location = new System.Drawing.Point(652, 168);
            this.LabelSearch_LIV.Name = "LabelSearch_LIV";
            this.LabelSearch_LIV.Size = new System.Drawing.Size(100, 31);
            this.LabelSearch_LIV.TabIndex = 5;
            this.LabelSearch_LIV.Text = "Поиск:";
            // 
            // TextBoxSearch_LIV
            // 
            this.TextBoxSearch_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch_LIV.Location = new System.Drawing.Point(749, 168);
            this.TextBoxSearch_LIV.Multiline = true;
            this.TextBoxSearch_LIV.Name = "TextBoxSearch_LIV";
            this.TextBoxSearch_LIV.Size = new System.Drawing.Size(250, 31);
            this.TextBoxSearch_LIV.TabIndex = 6;
            this.TextBoxSearch_LIV.TextChanged += new System.EventHandler(this.TextBoxSearch_LIV_TextChanged);
            // 
            // ButtonOpen_LIV
            // 
            this.ButtonOpen_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_LIV.BackgroundImage")));
            this.ButtonOpen_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpen_LIV.Location = new System.Drawing.Point(658, 106);
            this.ButtonOpen_LIV.Name = "ButtonOpen_LIV";
            this.ButtonOpen_LIV.Size = new System.Drawing.Size(83, 56);
            this.ButtonOpen_LIV.TabIndex = 7;
            this.ToolTip_LIV.SetToolTip(this.ButtonOpen_LIV, "Загрузить данные");
            this.ButtonOpen_LIV.UseVisualStyleBackColor = true;
            this.ButtonOpen_LIV.Click += new System.EventHandler(this.ButtonOpen_LIV_Click);
            // 
            // ButtonSave_LIV
            // 
            this.ButtonSave_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave_LIV.BackgroundImage")));
            this.ButtonSave_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave_LIV.Location = new System.Drawing.Point(749, 106);
            this.ButtonSave_LIV.Name = "ButtonSave_LIV";
            this.ButtonSave_LIV.Size = new System.Drawing.Size(83, 56);
            this.ButtonSave_LIV.TabIndex = 8;
            this.ToolTip_LIV.SetToolTip(this.ButtonSave_LIV, "Сохранить данные");
            this.ButtonSave_LIV.UseVisualStyleBackColor = true;
            this.ButtonSave_LIV.Click += new System.EventHandler(this.ButtonSave_LIV_Click);
            // 
            // PanelTop_LIV
            // 
            this.PanelTop_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTop_LIV.Controls.Add(this.LabelName_LIV);
            this.PanelTop_LIV.Controls.Add(this.ButtonInfo_LIV);
            this.PanelTop_LIV.Controls.Add(this.ButtonHelp_LIV);
            this.PanelTop_LIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_LIV.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_LIV.Name = "PanelTop_LIV";
            this.PanelTop_LIV.Size = new System.Drawing.Size(1108, 100);
            this.PanelTop_LIV.TabIndex = 11;
            // 
            // LabelName_LIV
            // 
            this.LabelName_LIV.AutoSize = true;
            this.LabelName_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName_LIV.ForeColor = System.Drawing.Color.White;
            this.LabelName_LIV.Location = new System.Drawing.Point(434, 12);
            this.LabelName_LIV.Name = "LabelName_LIV";
            this.LabelName_LIV.Size = new System.Drawing.Size(362, 55);
            this.LabelName_LIV.TabIndex = 13;
            this.LabelName_LIV.Text = "Поликлинника";
            // 
            // ButtonInfo_LIV
            // 
            this.ButtonInfo_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_LIV.BackgroundImage")));
            this.ButtonInfo_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInfo_LIV.Location = new System.Drawing.Point(1041, 12);
            this.ButtonInfo_LIV.Name = "ButtonInfo_LIV";
            this.ButtonInfo_LIV.Size = new System.Drawing.Size(55, 52);
            this.ButtonInfo_LIV.TabIndex = 12;
            this.ToolTip_LIV.SetToolTip(this.ButtonInfo_LIV, "Информация о разработчике");
            this.ButtonInfo_LIV.UseVisualStyleBackColor = true;
            this.ButtonInfo_LIV.Click += new System.EventHandler(this.ButtonInfo_LIV_Click);
            // 
            // ButtonHelp_LIV
            // 
            this.ButtonHelp_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonHelp_LIV.BackgroundImage")));
            this.ButtonHelp_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonHelp_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHelp_LIV.Location = new System.Drawing.Point(974, 12);
            this.ButtonHelp_LIV.Name = "ButtonHelp_LIV";
            this.ButtonHelp_LIV.Size = new System.Drawing.Size(55, 52);
            this.ButtonHelp_LIV.TabIndex = 11;
            this.ToolTip_LIV.SetToolTip(this.ButtonHelp_LIV, "Руководство пользователя");
            this.ButtonHelp_LIV.UseVisualStyleBackColor = true;
            this.ButtonHelp_LIV.Click += new System.EventHandler(this.ButtonHelp_LIV_Click);
            // 
            // ToolTip_LIV
            // 
            this.ToolTip_LIV.IsBalloon = true;
            this.ToolTip_LIV.ToolTipTitle = "Подсказка";
            // 
            // ButtonAdd_LIV
            // 
            this.ButtonAdd_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAdd_LIV.BackgroundImage")));
            this.ButtonAdd_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonAdd_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd_LIV.Location = new System.Drawing.Point(838, 106);
            this.ButtonAdd_LIV.Name = "ButtonAdd_LIV";
            this.ButtonAdd_LIV.Size = new System.Drawing.Size(83, 56);
            this.ButtonAdd_LIV.TabIndex = 12;
            this.ToolTip_LIV.SetToolTip(this.ButtonAdd_LIV, "Добавить строку");
            this.ButtonAdd_LIV.UseVisualStyleBackColor = true;
            this.ButtonAdd_LIV.Click += new System.EventHandler(this.ButtonAdd_LIV_Click);
            // 
            // ButtonSum_LIV
            // 
            this.ButtonSum_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSum_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSum_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSum_LIV.Location = new System.Drawing.Point(658, 302);
            this.ButtonSum_LIV.Name = "ButtonSum_LIV";
            this.ButtonSum_LIV.Size = new System.Drawing.Size(171, 59);
            this.ButtonSum_LIV.TabIndex = 14;
            this.ButtonSum_LIV.Text = "Общее количество дней больничного";
            this.ToolTip_LIV.SetToolTip(this.ButtonSum_LIV, "Посчитать количество всех дней больничного");
            this.ButtonSum_LIV.UseVisualStyleBackColor = false;
            this.ButtonSum_LIV.Click += new System.EventHandler(this.ButtonSum_LIV_Click);
            // 
            // ButtonAverage_LIV
            // 
            this.ButtonAverage_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAverage_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAverage_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAverage_LIV.Location = new System.Drawing.Point(658, 367);
            this.ButtonAverage_LIV.Name = "ButtonAverage_LIV";
            this.ButtonAverage_LIV.Size = new System.Drawing.Size(171, 71);
            this.ButtonAverage_LIV.TabIndex = 16;
            this.ButtonAverage_LIV.Text = "Среднее количество больничных дней";
            this.ToolTip_LIV.SetToolTip(this.ButtonAverage_LIV, "Посчитать среднее количество больничных дней");
            this.ButtonAverage_LIV.UseVisualStyleBackColor = false;
            this.ButtonAverage_LIV.Click += new System.EventHandler(this.ButtonAverage_LIV_Click);
            // 
            // ButtonDelete_LIV
            // 
            this.ButtonDelete_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete_LIV.BackgroundImage")));
            this.ButtonDelete_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDelete_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete_LIV.Location = new System.Drawing.Point(927, 106);
            this.ButtonDelete_LIV.Name = "ButtonDelete_LIV";
            this.ButtonDelete_LIV.Size = new System.Drawing.Size(83, 56);
            this.ButtonDelete_LIV.TabIndex = 18;
            this.ToolTip_LIV.SetToolTip(this.ButtonDelete_LIV, "Удалить строку");
            this.ButtonDelete_LIV.UseVisualStyleBackColor = true;
            this.ButtonDelete_LIV.Click += new System.EventHandler(this.ButtonDelete_LIV_Click);
            // 
            // ButtonMax_LIV
            // 
            this.ButtonMax_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonMax_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMax_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMax_LIV.Location = new System.Drawing.Point(658, 524);
            this.ButtonMax_LIV.Name = "ButtonMax_LIV";
            this.ButtonMax_LIV.Size = new System.Drawing.Size(171, 77);
            this.ButtonMax_LIV.TabIndex = 19;
            this.ButtonMax_LIV.Text = "Максимальное количество дней больничного";
            this.ToolTip_LIV.SetToolTip(this.ButtonMax_LIV, "Посчитать максимальное количество больничных дней");
            this.ButtonMax_LIV.UseVisualStyleBackColor = false;
            this.ButtonMax_LIV.Click += new System.EventHandler(this.ButtonMax_LIV_Click);
            // 
            // ButtonMin_LIV
            // 
            this.ButtonMin_LIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonMin_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMin_LIV.Location = new System.Drawing.Point(658, 444);
            this.ButtonMin_LIV.Name = "ButtonMin_LIV";
            this.ButtonMin_LIV.Size = new System.Drawing.Size(171, 74);
            this.ButtonMin_LIV.TabIndex = 20;
            this.ButtonMin_LIV.Text = "Минимальноя количество дней больничного";
            this.ToolTip_LIV.SetToolTip(this.ButtonMin_LIV, "Посчитать минимальное количество больничных дней");
            this.ButtonMin_LIV.UseVisualStyleBackColor = false;
            this.ButtonMin_LIV.Click += new System.EventHandler(this.ButtonMin_LIV_Click);
            // 
            // OpenFileDialogMain_LIV
            // 
            this.OpenFileDialogMain_LIV.FileName = "openFileDialog1";
            // 
            // PanelLeft_LIV
            // 
            this.PanelLeft_LIV.Controls.Add(this.DataGridViewMain_LIV);
            this.PanelLeft_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_LIV.Location = new System.Drawing.Point(0, 100);
            this.PanelLeft_LIV.Name = "PanelLeft_LIV";
            this.PanelLeft_LIV.Size = new System.Drawing.Size(647, 510);
            this.PanelLeft_LIV.TabIndex = 13;
            // 
            // TextBoxSum_LIV
            // 
            this.TextBoxSum_LIV.BackColor = System.Drawing.Color.White;
            this.TextBoxSum_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSum_LIV.Location = new System.Drawing.Point(835, 311);
            this.TextBoxSum_LIV.Multiline = true;
            this.TextBoxSum_LIV.Name = "TextBoxSum_LIV";
            this.TextBoxSum_LIV.ReadOnly = true;
            this.TextBoxSum_LIV.Size = new System.Drawing.Size(264, 35);
            this.TextBoxSum_LIV.TabIndex = 15;
            // 
            // TextBoxAverage_LIV
            // 
            this.TextBoxAverage_LIV.BackColor = System.Drawing.Color.White;
            this.TextBoxAverage_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAverage_LIV.Location = new System.Drawing.Point(835, 382);
            this.TextBoxAverage_LIV.Multiline = true;
            this.TextBoxAverage_LIV.Name = "TextBoxAverage_LIV";
            this.TextBoxAverage_LIV.ReadOnly = true;
            this.TextBoxAverage_LIV.Size = new System.Drawing.Size(264, 35);
            this.TextBoxAverage_LIV.TabIndex = 17;
            // 
            // TextBoxMax_LIV
            // 
            this.TextBoxMax_LIV.BackColor = System.Drawing.Color.White;
            this.TextBoxMax_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMax_LIV.Location = new System.Drawing.Point(835, 542);
            this.TextBoxMax_LIV.Multiline = true;
            this.TextBoxMax_LIV.Name = "TextBoxMax_LIV";
            this.TextBoxMax_LIV.ReadOnly = true;
            this.TextBoxMax_LIV.Size = new System.Drawing.Size(264, 35);
            this.TextBoxMax_LIV.TabIndex = 21;
            // 
            // TextBoxMin_LIV
            // 
            this.TextBoxMin_LIV.BackColor = System.Drawing.Color.White;
            this.TextBoxMin_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMin_LIV.Location = new System.Drawing.Point(835, 461);
            this.TextBoxMin_LIV.Multiline = true;
            this.TextBoxMin_LIV.Name = "TextBoxMin_LIV";
            this.TextBoxMin_LIV.ReadOnly = true;
            this.TextBoxMin_LIV.Size = new System.Drawing.Size(264, 35);
            this.TextBoxMin_LIV.TabIndex = 22;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // Category
            // 
            this.Category.HeaderText = "Диагноз";
            this.Category.Name = "Category";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Общее срок потери трудоспособности";
            this.Quantity.Name = "Quantity";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность последней потери трудоспособности ";
            this.Duration.Name = "Duration";
            // 
            // FIO_Doctor
            // 
            this.FIO_Doctor.HeaderText = "ФИО Врача";
            this.FIO_Doctor.Name = "FIO_Doctor";
            this.FIO_Doctor.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 610);
            this.Controls.Add(this.TextBoxMin_LIV);
            this.Controls.Add(this.TextBoxMax_LIV);
            this.Controls.Add(this.ButtonMin_LIV);
            this.Controls.Add(this.ButtonMax_LIV);
            this.Controls.Add(this.ButtonDelete_LIV);
            this.Controls.Add(this.TextBoxAverage_LIV);
            this.Controls.Add(this.ButtonAverage_LIV);
            this.Controls.Add(this.TextBoxSum_LIV);
            this.Controls.Add(this.ButtonSum_LIV);
            this.Controls.Add(this.PanelLeft_LIV);
            this.Controls.Add(this.ButtonAdd_LIV);
            this.Controls.Add(this.PanelTop_LIV);
            this.Controls.Add(this.ButtonSave_LIV);
            this.Controls.Add(this.ButtonOpen_LIV);
            this.Controls.Add(this.TextBoxSearch_LIV);
            this.Controls.Add(this.LabelSearch_LIV);
            this.Controls.Add(this.GroupBoxFilt_LIV);
            this.Controls.Add(this.GroupBoxSort_LIV);
            this.Controls.Add(this.ButtonChart_LIV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain_LIV)).EndInit();
            this.GroupBoxSort_LIV.ResumeLayout(false);
            this.GroupBoxFilt_LIV.ResumeLayout(false);
            this.PanelTop_LIV.ResumeLayout(false);
            this.PanelTop_LIV.PerformLayout();
            this.PanelLeft_LIV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonChart_LIV;
        private System.Windows.Forms.DataGridView DataGridViewMain_LIV;
        private System.Windows.Forms.GroupBox GroupBoxSort_LIV;
        private System.Windows.Forms.ComboBox ComboBoxSort_LIV;
        private System.Windows.Forms.GroupBox GroupBoxFilt_LIV;
        private System.Windows.Forms.ComboBox ComboBoxFilt_LIV;
        private System.Windows.Forms.Label LabelSearch_LIV;
        private System.Windows.Forms.TextBox TextBoxSearch_LIV;
        private System.Windows.Forms.Button ButtonOpen_LIV;
        private System.Windows.Forms.Button ButtonSave_LIV;
        private System.Windows.Forms.Panel PanelTop_LIV;
        private System.Windows.Forms.Label LabelName_LIV;
        private System.Windows.Forms.Button ButtonInfo_LIV;
        private System.Windows.Forms.Button ButtonHelp_LIV;
        private System.Windows.Forms.ToolTip ToolTip_LIV;
        private System.Windows.Forms.Button ButtonAdd_LIV;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogMain_LIV;
        private System.Windows.Forms.Panel PanelLeft_LIV;
        private System.Windows.Forms.Button ButtonSum_LIV;
        private System.Windows.Forms.TextBox TextBoxSum_LIV;
        private System.Windows.Forms.Button ButtonAverage_LIV;
        private System.Windows.Forms.TextBox TextBoxAverage_LIV;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogMain_LIV;
        private System.Windows.Forms.Button ButtonDelete_LIV;
        private System.Windows.Forms.Button ButtonMax_LIV;
        private System.Windows.Forms.Button ButtonMin_LIV;
        private System.Windows.Forms.TextBox TextBoxMax_LIV;
        private System.Windows.Forms.TextBox TextBoxMin_LIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_Doctor;
    }
}



