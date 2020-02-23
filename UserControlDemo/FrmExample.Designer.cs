namespace UserControlDemo
{
    partial class FrmExample
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
            this.wordControl1 = new UserControlDemo.WordControl();
            this.SuspendLayout();
            // 
            // wordControl1
            // 
            this.wordControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.wordControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordControl1.Location = new System.Drawing.Point(0, 0);
            this.wordControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wordControl1.Name = "wordControl1";
            this.wordControl1.RichText = "{\\rtf1\\ansi\\ansicpg1254\\deff0\\deflang1055{\\fonttbl{\\f0\\fnil\\fcharset162 Segoe UI;" +
    "}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.wordControl1.ShowFontTest = true;
            this.wordControl1.ShowScale = true;
            this.wordControl1.ShowTitle = true;
            this.wordControl1.Size = new System.Drawing.Size(754, 401);
            this.wordControl1.TabIndex = 0;
            this.wordControl1.TitleText = "";
            this.wordControl1.ZoomFactor = 1F;
            // 
            // FrmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 401);
            this.Controls.Add(this.wordControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmExample";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WordControl wordControl1;
    }
}

