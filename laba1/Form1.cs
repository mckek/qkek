using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };
        string[] skill = { "новичoк", "любитель", "профессионал" };
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(skill);
         
            comboBox2.Items.AddRange(Days);
            
            
          
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text += kids.Name;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text += kids.age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                textBox3.Text = qwerty.GetInfo(comboBox2.SelectedItem.ToString());
            }
        }
    }
}
