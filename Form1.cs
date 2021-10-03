using System;
using System.Windows.Forms;

namespace labGUI1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nums_TextChanged(object sender, EventArgs e)
        {
            if (Nums.TextLength > 0)
            {
                numericUpDown.Visible = true;
                numericUpDown.Maximum = Nums.TextLength;
            }
        }

        private void Nums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
            MessageBox.Show("Вводите только цифры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
