using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_LIST
{
    public partial class Form3 : Form
    {
        private Controller _controller;
        private Controller test = new Controller();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Name = this.textBox1.Text;
            task.Description = textBox2.Text;
            task.DateCreated = dateTimePicker1.Value;
            task.Status = "TODO";
            test.createTask(task);
        }
    }
}
