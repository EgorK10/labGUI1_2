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

        //Ввод строки,выбор количества соседних букв и вывод ответа
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
                label_answer.Visible = false;
            }
        }

        //Проверка ввода на корректность
        private void Nums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
            MessageBox.Show("Вводите только цифры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Выбор количества соседних цифр 
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            label_answer.Text = Logic.Solution(Nums.Text, (uint)numericUpDown.Value);
            label_answer.Visible = true;
        }

        //Очитска полей при нажатии на кнопку 
        private void button_clear_Click(object sender, EventArgs e)
        {
            Nums.Text = Nums.Text.Remove(0);
            numericUpDown.Visible = false;
            label2.Visible = false;
        }

        //Загрузка данных в поля при открытии
        private void Form1_Load(object sender, EventArgs e)
        {
            Nums.Text = Properties.Settings.Default.nums;
            if (Properties.Settings.Default.numericUpDown < 1)
                numericUpDown.Value = 1;
            else
                numericUpDown.Value = Properties.Settings.Default.numericUpDown;
        }

        //Сохранение данных при закритии
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.nums = Nums.Text;
            Properties.Settings.Default.numericUpDown = numericUpDown.Value;
            Properties.Settings.Default.Save();
        }
    }
}
