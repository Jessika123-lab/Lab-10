using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10_1
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
            int a1 = (int)numericUpDown1.Value;
            int d = (int)numericUpDown2.Value;
            int n = (int)numericUpDown3.Value;

            int sum = 0;

            for (int i = 0; i < numericUpDown3.Value; i++)
            {
                sum = ((2*a1) + d*(n-1))/2 * n;
            }

            MessageBox.Show("" + sum);
        }
    }
}
