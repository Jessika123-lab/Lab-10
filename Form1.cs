using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math = 3;
            int Englisg = 4;
            int History = 4;
            int biologi = 5;

            float sum = (math + Englisg + History + biologi) / 4;
            if (math < sum || Englisg < sum || History < sum || biologi < sum) 
            {
                MessageBox.Show("Seredniy bal = " + sum + "\nMath =" + math);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year - dateTimePicker1.Value.Year;

            MessageBox.Show("" + year);

        }
    }
}
