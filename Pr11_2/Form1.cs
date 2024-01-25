using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr11_2
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
        public class Time
        {
            public int chas;
            public int minut;
            public int second;

        }
        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Time time = new Time();
            time.chas = (int) (numericUpDown1.Value);
            time.minut = (int) (numericUpDown2.Value);
            time.second = (int) (numericUpDown3.Value);
            MessageBox.Show(String.Format("Время: {0}:{1}:{2}", time.chas,time.minut,time.minut));
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
           
        }
    }
}
