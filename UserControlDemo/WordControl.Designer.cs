namespace UserControlDemo
{
    sealed partial class WordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopBorder = new System.Windows.Forms.Panel();
            this.txtFontTest = new System.Windows.Forms.RichTextBox();
            this.btnFontSelector = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.picColorSelector = new System.Windows.Forms.PictureBox();
            this.btnAlignCenter = new System.Windows.Forms.Button();
            this.btnLowerFontSize = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.btnBiggerFontSize = new System.Windows.Forms.Button();
            this.pnlLeftBorder = new System.Windows.Forms.Panel();
            this.pnlRightBorder = new System.Windows.Forms.Panel();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.pnlBottomZoomButtons = new System.Windows.Forms.Panel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomNormal = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.flypnlMenuButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSelector)).BeginInit();
            this.pnlBottomBorder.SuspendLayout();
            this.pnlBottomZoomButtons.SuspendLayout();
            this.flypnlMenuButtons.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBorder
            // 
            this.pnlTopBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBorder.Location = new System.Drawing.Point(10, 0);
            this.pnlTopBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTopBorder.Name = "pnlTopBorder";
            this.pnlTopBorder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlTopBorder.Size = new System.Drawing.Size(630, 10);
            this.pnlTopBorder.TabIndex = 0;
            // 
            // txtFontTest
            // 
            this.txtFontTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFontTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFontTest.Location = new System.Drawing.Point(350, 0);
            this.txtFontTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFontTest.Name = "txtFontTest";
            this.txtFontTest.ReadOnly = true;
            this.txtFontTest.Size = new System.Drawing.Size(280, 34);
            this.txtFontTest.TabIndex = 7;
            this.txtFontTest.TabStop = false;
            this.txtFontTest.Text = "Pijamalı hasta yağız şoföre çabucak güvendi\nThe quick brown fox jumps over the la" +
    "zy dog";
            // 
            // btnFontSelector
            // 
            this.btnFontSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontSelector.Location = new System.Drawing.Point(0, 0);
            this.btnFontSelector.Margin = new System.Windows.Forms.Padding(0);
            this.btnFontSelector.Name = "btnFontSelector";
            this.btnFontSelector.Size = new System.Drawing.Size(85, 30);
            this.btnFontSelector.TabIndex = 1;
            this.btnFontSelector.TabStop = false;
            this.btnFontSelector.Text = "Font";
            this.btnFontSelector.UseVisualStyleBackColor = true;
            this.btnFontSelector.Click += new System.EventHandler(this.btnFontSelector_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignLeft.Location = new System.Drawing.Point(165, 0);
            this.btnAlignLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(45, 30);
            this.btnAlignLeft.TabIndex = 1;
            this.btnAlignLeft.TabStop = false;
            this.btnAlignLeft.Text = "<-";
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // picColorSelector
            // 
            this.picColorSelector.BackColor = System.Drawing.Color.Black;
            this.picColorSelector.Location = new System.Drawing.Point(306, 0);
            this.picColorSelector.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.picColorSelector.Name = "picColorSelector";
            this.picColorSelector.Size = new System.Drawing.Size(29, 30);
            this.picColorSelector.TabIndex = 6;
            this.picColorSelector.TabStop = false;
            this.picColorSelector.Click += new System.EventHandler(this.picColorSelector_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignCenter.Location = new System.Drawing.Point(210, 0);
            this.btnAlignCenter.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(45, 30);
            this.btnAlignCenter.TabIndex = 2;
            this.btnAlignCenter.TabStop = false;
            this.btnAlignCenter.Text = "<->";
            this.btnAlignCenter.UseVisualStyleBackColor = true;
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click);
            // 
            // btnLowerFontSize
            // 
            this.btnLowerFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowerFontSize.Location = new System.Drawing.Point(125, 0);
            this.btnLowerFontSize.Margin = new System.Windows.Forms.Padding(0);
            this.btnLowerFontSize.Name = "btnLowerFontSize";
            this.btnLowerFontSize.Size = new System.Drawing.Size(40, 30);
            this.btnLowerFontSize.TabIndex = 5;
            this.btnLowerFontSize.TabStop = false;
            this.btnLowerFontSize.Text = "\\/";
            this.btnLowerFontSize.UseVisualStyleBackColor = true;
            this.btnLowerFontSize.Click += new System.EventHandler(this.btnLowerFontSize_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignRight.Location = new System.Drawing.Point(255, 0);
            this.btnAlignRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(45, 30);
            this.btnAlignRight.TabIndex = 3;
            this.btnAlignRight.TabStop = false;
            this.btnAlignRight.Text = "->";
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // btnBiggerFontSize
            // 
            this.btnBiggerFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiggerFontSize.Location = new System.Drawing.Point(85, 0);
            this.btnBiggerFontSize.Margin = new System.Windows.Forms.Padding(0);
            this.btnBiggerFontSize.Name = "btnBiggerFontSize";
            this.btnBiggerFontSize.Size = new System.Drawing.Size(40, 30);
            this.btnBiggerFontSize.TabIndex = 4;
            this.btnBiggerFontSize.TabStop = false;
            this.btnBiggerFontSize.Text = "/\\";
            this.btnBiggerFontSize.UseVisualStyleBackColor = true;
            this.btnBiggerFontSize.Click += new System.EventHandler(this.btnBiggerFontSize_Click);
            // 
            // pnlLeftBorder
            // 
            this.pnlLeftBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeftBorder.Name = "pnlLeftBorder";
            this.pnlLeftBorder.Size = new System.Drawing.Size(10, 350);
            this.pnlLeftBorder.TabIndex = 2;
            // 
            // pnlRightBorder
            // 
            this.pnlRightBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightBorder.Location = new System.Drawing.Point(640, 0);
            this.pnlRightBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRightBorder.Name = "pnlRightBorder";
            this.pnlRightBorder.Size = new System.Drawing.Size(10, 350);
            this.pnlRightBorder.TabIndex = 3;
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottomBorder.Controls.Add(this.pnlBottomZoomButtons);
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(10, 323);
            this.pnlBottomBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(630, 27);
            this.pnlBottomBorder.TabIndex = 0;
            // 
            // pnlBottomZoomButtons
            // 
            this.pnlBottomZoomButtons.Controls.Add(this.btnZoomIn);
            this.pnlBottomZoomButtons.Controls.Add(this.btnZoomNormal);
            this.pnlBottomZoomButtons.Controls.Add(this.btnZoomOut);
            this.pnlBottomZoomButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottomZoomButtons.Location = new System.Drawing.Point(452, 0);
            this.pnlBottomZoomButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottomZoomButtons.Name = "pnlBottomZoomButtons";
            this.pnlBottomZoomButtons.Size = new System.Drawing.Size(178, 27);
            this.pnlBottomZoomButtons.TabIndex = 3;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Location = new System.Drawing.Point(122, 1);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(55, 25);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomNormal
            // 
            this.btnZoomNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomNormal.Location = new System.Drawing.Point(0, 1);
            this.btnZoomNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoomNormal.Name = "btnZoomNormal";
            this.btnZoomNormal.Size = new System.Drawing.Size(69, 25);
            this.btnZoomNormal.TabIndex = 2;
            this.btnZoomNormal.TabStop = false;
            this.btnZoomNormal.Text = "100 %";
            this.btnZoomNormal.UseVisualStyleBackColor = true;
            this.btnZoomNormal.Click += new System.EventHandler(this.btnZoomNormal_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Location = new System.Drawing.Point(68, 1);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(55, 25);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // flypnlMenuButtons
            // 
            this.flypnlMenuButtons.AutoScroll = true;
            this.flypnlMenuButtons.Controls.Add(this.btnFontSelector);
            this.flypnlMenuButtons.Controls.Add(this.btnBiggerFontSize);
            this.flypnlMenuButtons.Controls.Add(this.btnLowerFontSize);
            this.flypnlMenuButtons.Controls.Add(this.btnAlignLeft);
            this.flypnlMenuButtons.Controls.Add(this.btnAlignCenter);
            this.flypnlMenuButtons.Controls.Add(this.btnAlignRight);
            this.flypnlMenuButtons.Controls.Add(this.picColorSelector);
            this.flypnlMenuButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.flypnlMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.flypnlMenuButtons.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.flypnlMenuButtons.MinimumSize = new System.Drawing.Size(350, 0);
            this.flypnlMenuButtons.Name = "flypnlMenuButtons";
            this.flypnlMenuButtons.Size = new System.Drawing.Size(350, 38);
            this.flypnlMenuButtons.TabIndex = 0;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.Controls.Add(this.txtText);
            this.pnlCenter.Controls.Add(this.pnlTitle);
            this.pnlCenter.Controls.Add(this.pnlTopMenu);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(10, 10);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(630, 313);
            this.pnlCenter.TabIndex = 5;
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(0, 68);
            this.txtText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(630, 245);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "";
            this.txtText.SelectionChanged += new System.EventHandler(this.txtText_SelectionChanged);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.txtTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 38);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(630, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(630, 25);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Controls.Add(this.txtFontTest);
            this.pnlTopMenu.Controls.Add(this.flypnlMenuButtons);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(630, 38);
            this.pnlTopMenu.TabIndex = 9;
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTopBorder);
            this.Controls.Add(this.pnlBottomBorder);
            this.Controls.Add(this.pnlRightBorder);
            this.Controls.Add(this.pnlLeftBorder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WordControl";
            this.Size = new System.Drawing.Size(650, 350);
            ((System.ComponentModel.ISupportInitialize)(this.picColorSelector)).EndInit();
            this.pnlBottomBorder.ResumeLayout(false);
            this.pnlBottomZoomButtons.ResumeLayout(false);
            this.flypnlMenuButtons.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlTopMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBorder;
        private System.Windows.Forms.Button btnFontSelector;
        private System.Windows.Forms.Button btnLowerFontSize;
        private System.Windows.Forms.Button btnBiggerFontSize;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.Button btnAlignCenter;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.PictureBox picColorSelector;
        private System.Windows.Forms.Panel pnlLeftBorder;
        private System.Windows.Forms.Panel pnlRightBorder;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private System.Windows.Forms.RichTextBox txtFontTest;
        private System.Windows.Forms.Button btnZoomNormal;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Panel pnlBottomZoomButtons;
        private System.Windows.Forms.FlowLayoutPanel flypnlMenuButtons;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTopMenu;
    }
}
