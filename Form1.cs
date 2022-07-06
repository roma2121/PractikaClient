using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ActiveControl = button1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Username";
            richTextBox1.ForeColor = Color.Gray;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            richTextBox1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Username" || richTextBox1.Text == "" || richTextBox1.Text == null)
                return;

            Client ClientForm = new Client(richTextBox1.Text);
            ClientForm.Show();
        }
    }
}
