
namespace Tyuiu.LebedevIV.Sprint7.Project.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.TextBoxInfo_LIV = new System.Windows.Forms.TextBox();
            this.ButtonOk_LIV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxInfo_LIV
            // 
            this.TextBoxInfo_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInfo_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxInfo_LIV.Location = new System.Drawing.Point(120, 12);
            this.TextBoxInfo_LIV.Multiline = true;
            this.TextBoxInfo_LIV.Name = "TextBoxInfo_LIV";
            this.TextBoxInfo_LIV.ReadOnly = true;
            this.TextBoxInfo_LIV.Size = new System.Drawing.Size(450, 203);
            this.TextBoxInfo_LIV.TabIndex = 2;
            this.TextBoxInfo_LIV.TabStop = false;
            this.TextBoxInfo_LIV.Text = resources.GetString("TextBoxInfo_LIV.Text");
            // 
            // ButtonOk_LIV
            // 
            this.ButtonOk_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOk_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOk_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk_LIV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOk_LIV.Location = new System.Drawing.Point(430, 214);
            this.ButtonOk_LIV.Name = "ButtonOk_LIV";
            this.ButtonOk_LIV.Size = new System.Drawing.Size(96, 36);
            this.ButtonOk_LIV.TabIndex = 3;
            this.ButtonOk_LIV.Text = "Ок";
            this.ButtonOk_LIV.UseVisualStyleBackColor = false;
            this.ButtonOk_LIV.Click += new System.EventHandler(this.ButtonOk_LIV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonOk_LIV);
            this.Controls.Add(this.TextBoxInfo_LIV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInfo_LIV;
        private System.Windows.Forms.Button ButtonOk_LIV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}