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
                label2.Visible = true;
                numericUpDown.Maximum = Nums.TextLength;
                label_answer.Text = Logic.Solution(Nums.Text, (uint)numericUpDown.Value);
                label_answer.Visible = true;
            }
            else if (Nums.TextLength == 0)
            {
                numericUpDown.Visible = false;
                label2.Visible = false;
            }
        }

        private void Nums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
            MessageBox.Show("Вводите только цифры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            label_answer.Text = Logic.Solution(Nums.Text, (uint)numericUpDown.Value);
            label_answer.Visible = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Nums.Text = Nums.Text.Remove(0);
            numericUpDown.Visible = false;
            label2.Visible = false;
        }
    }
}
