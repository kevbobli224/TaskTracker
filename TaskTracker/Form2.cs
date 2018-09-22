using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class Form2 : Form
    {
        public int id;
        public Form1 currentform;
        public Task currentTask;
        public Form2()
        {
            InitializeComponent();
        }

        private void aesButtonClass1_Click(object sender, EventArgs e)
        {
            currentTask.description = richTextBox1.Text;
            //currentform.TaskSet(id, richTextBox1.Text);
            if (textBox1.Text == string.Empty)
                textBox1.Text = "0";
            var hours = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text == string.Empty)
                textBox2.Text = "0";
            var minutes = Convert.ToInt32(textBox2.Text);
            var seconds = hours * 60 * 60 + minutes * 60;
            if (seconds == 0)
                seconds = 60;
            currentTask.seconds = seconds;
            //currentform.TimeSet(id, seconds);
            //Console.WriteLine(currentTask.id);
            currentform.AddTask(currentTask);
            this.Close();

        }
        private void textchanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
