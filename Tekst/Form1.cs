using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tekst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FontStyle _fontStyle = FontStyle.Regular;
        private float _fontSize = 9f;
        private Color _color = Color.Black;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, _fontSize, _fontStyle);
            textBox1.ForeColor = _color;
        }

        private void chxBold_CheckedChanged(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Bold;
        }

        private void chxItalic_CheckedChanged(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Italic;
        }

        private void chxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Underline;
        }

        private void rdomala_CheckedChanged(object sender, EventArgs e)
        {
            _fontSize = 8;
        }

        private void rdoduza_CheckedChanged(object sender, EventArgs e)
        {
            _fontSize = 12;
        }

        private void rdobduza_CheckedChanged(object sender, EventArgs e)
        {
            _fontSize = 18;
        }

        private void rdoczerwony_CheckedChanged(object sender, EventArgs e)
        {
            _color = Color.Red;
        }

        private void rdoniebieski_CheckedChanged(object sender, EventArgs e)
        {
            _color = Color.Blue;
        }

        private void rdopom_CheckedChanged(object sender, EventArgs e)
        {
            _color = Color.Orange;
        }
    }
}
