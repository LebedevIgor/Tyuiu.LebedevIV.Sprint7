
namespace Tyuiu.LebedevIV.Sprint7.Project.V6
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            this.TextBoxGuide_LIV = new System.Windows.Forms.TextBox();
            this.ButtonOkGuide_LIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxGuide_LIV
            // 
            this.TextBoxGuide_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxGuide_LIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxGuide_LIV.Location = new System.Drawing.Point(12, 12);
            this.TextBoxGuide_LIV.Multiline = true;
            this.TextBoxGuide_LIV.Name = "TextBoxGuide_LIV";
            this.TextBoxGuide_LIV.ReadOnly = true;
            this.TextBoxGuide_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxGuide_LIV.Size = new System.Drawing.Size(748, 502);
            this.TextBoxGuide_LIV.TabIndex = 3;
            this.TextBoxGuide_LIV.TabStop = false;
            this.TextBoxGuide_LIV.Text = resources.GetString("TextBoxGuide_LIV.Text");
            // 
            // ButtonOkGuide_LIV
            // 
            this.ButtonOkGuide_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOkGuide_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOkGuide_LIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOkGuide_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOkGuide_LIV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOkGuide_LIV.Location = new System.Drawing.Point(634, 530);
            this.ButtonOkGuide_LIV.Name = "ButtonOkGuide_LIV";
            this.ButtonOkGuide_LIV.Size = new System.Drawing.Size(96, 36);
            this.ButtonOkGuide_LIV.TabIndex = 4;
            this.ButtonOkGuide_LIV.Text = "Ок";
            this.ButtonOkGuide_LIV.UseVisualStyleBackColor = false;
            this.ButtonOkGuide_LIV.Click += new System.EventHandler(this.ButtonOkGuide_LIV_Click);
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 578);
            this.Controls.Add(this.ButtonOkGuide_LIV);
            this.Controls.Add(this.TextBoxGuide_LIV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мануал пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxGuide_LIV;
        private System.Windows.Forms.Button ButtonOkGuide_LIV;
    }
}