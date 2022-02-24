using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForm
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

        private void EID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                    {
                        e.Handled = true;
                    }
        }

        private void Sal_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Allowance_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Hra_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        } 
        private void E_Name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float  b_sal = 0, Allowance = 0, Hra_val = 0, Pf_allowance = 0, Gross_pay = 0;
            
            b_sal = float.Parse(Sal_textBox.Text);
           
            Allowance = float.Parse(Allowance_textBox.Text);
            Hra_val = float.Parse(Hra_textBox.Text);
            Pf_allowance = Allowance + Hra_val * 10 / 100;
            Gross_pay = b_sal + Allowance + Hra_val - Pf_allowance;
            PF_result_label.Text = Pf_allowance.ToString();
            GrossPay_result_label.Text = Gross_pay.ToString();




        }

       
    }
}
