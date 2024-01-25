using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr11._1
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
        public class Student
        {
            public string name;
            public double rost;
            private double ves=35;
            public double vs;
            public int eda;
            public double GetEat ()
            {
                ves = vs;
                return ves;
            }
            public double SetEat()
            {
               
                if (eda > 5 && eda < 10)
                {
                    vs += vs*0.7;
                }
                else if (eda > 10)
                {
                    vs += vs*0.5;
                }
                else
                    vs = vs + eda - 2800 / 1000;
                return vs;
            }
            public double SetRost ()
            {
                if (eda > 5 && eda < 10)
                    rost -= 1;
                else if (eda > 10)
                    rost -= 2;
                return rost;
            }
        }
        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = textBox1.Text;
            student1.rost = (double) (numericUpDown1.Value);
            student1.vs = (double) (numericUpDown2.Value);
            student1.eda = (int) (numericUpDown3.Value);
            MessageBox.Show(string.Format("Студент: {0}\nРост: {1}\nВес: {2}\nКоличество съеденной еды: {3}\nИзмененный вес: {4}\nИзмененный рост: {5}", student1.name, student1.rost, student1.GetEat(),student1.eda, student1.SetEat(),student1.SetRost()));
            
        }

        private void label3_Click (object sender, EventArgs e)
        {

        }
    }
}
