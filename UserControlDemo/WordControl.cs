using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class WordControl : UserControl
    {
        private readonly ColorDialog _colorDialog = new ColorDialog();

        private readonly FontDialog _fontDialog = new FontDialog { ShowColor = true };

        private bool _showFontTest = true;
        [Description("Show font test area"), Category("Data")]
        public bool ShowFontTest
        {
            get => _showFontTest;
            set
            {
                _showFontTest = value;
                txtFontTest.Visible = value;
            }
        }

        private bool _showTitle = true;
        [Description("Show title textbox"), Category("Data")]
        public bool ShowTitle
        {
            get => _showTitle;
            set
            {
                _showTitle = value;
                if (value)
                {
                    pnlTitle.Show();
                }
                else
                {
                    pnlTitle.Hide();
                }
            }
        }

        private bool _showScale = true;
        [Description("Show scale options"), Category("Data")]
        public bool ShowScale
        {
            get => _showScale;
            set => _showScale = btnZoomIn.Visible = btnZoomOut.Visible = btnZoomNormal.Visible = value;
        }

        public float ZoomFactor { get; set; } = 1;

        public WordControl()
        {
            InitializeComponent();
            BackColor = Color.FromKnownColor(KnownColor.WhiteSmoke);
        }

        public WordControl(string text, bool wordText = false)
        {
            InitializeComponent();
            if (wordText)
                RichText = text;
            else
                Text = text;
        }

        public string RichText
        {
            get => txtText.Rtf;
            set => txtText.Rtf = value;
        }

        public string TitleText
        {
            get => txtTitle.Text;
            set => txtTitle.Text = value;
        }

        public override string Text
        {
            get => txtText.Text;
            set => txtText.Text = value;
        }

        private void btnFontSelector_Click(object sender, EventArgs e)
        {
            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtText.SelectionFont = _fontDialog.Font;
                txtText.SelectionColor = _fontDialog.Color;
                picColorSelector.BackColor = _fontDialog.Color;

                txtFontTest.Font = _fontDialog.Font;
                txtFontTest.ForeColor = _fontDialog.Color;
            }

            txtText.Focus();
        }

        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            txtText.SelectionAlignment = HorizontalAlignment.Left;
            txtFontTest.SelectAll();
            txtFontTest.SelectionAlignment = HorizontalAlignment.Left;
            txtText.Focus();
        }

        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            txtText.SelectionAlignment = HorizontalAlignment.Center;
            txtFontTest.SelectAll();
            txtFontTest.SelectionAlignment = HorizontalAlignment.Center;
            txtText.Focus();
        }

        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            txtText.SelectionAlignment = HorizontalAlignment.Right;
            txtFontTest.SelectAll();
            txtFontTest.SelectionAlignment = HorizontalAlignment.Right;
            txtText.Focus();
        }

        private void btnBiggerFontSize_Click(object sender, EventArgs e)
        {
            var currentFont = txtText.SelectionFont;
            var emSize = currentFont.Size * 1.1f + 1;

            if (emSize > 1000) return;

            txtText.SelectionFont =
                new Font(currentFont.FontFamily,
                    emSize,
                    currentFont.Style);

            txtFontTest.SelectAll();
            txtFontTest.SelectionFont = txtText.SelectionFont;
            txtText.Focus();
        }

        private void btnLowerFontSize_Click(object sender, EventArgs e)
        {
            var currentFont = txtText.SelectionFont;
            var emSize = currentFont.Size * 0.9f - 1;

            if (emSize < 1) return;

            txtText.SelectionFont =
                new Font(currentFont.FontFamily,
                    emSize,
                    currentFont.Style);

            txtFontTest.SelectAll();
            txtFontTest.SelectionFont = txtText.SelectionFont;
            txtText.Focus();
        }

        private void picColorSelector_Click(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() != DialogResult.OK) return;

            txtText.SelectionColor = _colorDialog.Color;
            picColorSelector.BackColor = _colorDialog.Color;
            txtFontTest.ForeColor = _colorDialog.Color;
            txtText.Focus();
        }

        private void txtText_SelectionChanged(object sender, EventArgs e)
        {
            txtFontTest.Font = txtText.SelectionFont;
            txtFontTest.ForeColor = txtText.SelectionColor;
            picColorSelector.BackColor = txtText.SelectionColor;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            var zoom = txtText.ZoomFactor * 1.1f;
            if (zoom >= 64)
                zoom = 63.99f;
            else if (zoom <= 0.015625f) zoom = 0.015626f;

            txtText.ZoomFactor = zoom;
            btnZoomNormal.Text = (txtText.ZoomFactor * 100).ToString("n2") + @" %";
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            var zoom = txtText.ZoomFactor / 1.1f;
            if (zoom >= 64)
                zoom = 63.99f;
            else if (zoom <= 0.015625f) zoom = 0.015626f;
            txtText.ZoomFactor = zoom;
            btnZoomNormal.Text = (txtText.ZoomFactor * 100).ToString("n2") + @" %";
        }

        private void btnZoomNormal_Click(object sender, EventArgs e)
        {
            txtText.ZoomFactor = 1;
            btnZoomNormal.Text = (txtText.ZoomFactor * 100).ToString("n2") + @" %";
        }
    }
}