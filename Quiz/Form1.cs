using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private String daco { set; get; }
        public Form1()
        {
            InitializeComponent();
            daco = "daco";
        }

        private void Confirm(object sender, EventArgs e)
        {
            if(isFirst() & isSecond() & isThird() & isFourth() & isFifth() & isSixth())
            {
                label7.Text = "Spravne";
            }
            else
            {
                label7.Text = "Nespravne";
            }
        }

        private Boolean isFirst()
        {
            if (textBox1.Text.ToLower().Trim() != "vieden")
            {
                label1.BackColor = Color.Red;
                return false;
            }
            label1.BackColor = Color.LightGreen;
            return true;
        }

        private Boolean isSecond()
        {
            if (!radioButton1.Checked)
            {
                label2.BackColor = Color.Red;
                return false;
            }
            label2.BackColor = Color.LightGreen;
            return true;
        }
        private Boolean isThird()
        {
            if (!checkBox2.Checked || !checkBox3.Checked || checkBox1.Checked || checkBox4.Checked)
            {
                label3.BackColor = Color.Red;
                return false;
            }
            label3.BackColor = Color.LightGreen;
            return true;
        }
        private Boolean isFourth()
        {
            if (!radioButton5.Checked)
            {
                label4.BackColor = Color.Red;
                return false;
            }
            label4.BackColor = Color.LightGreen;
            return true;
        }
        private Boolean isFifth()
        {
            if(comboBox1.SelectedIndex != 1)
            {
                label5.BackColor = Color.Red;
                return false;
            }
            label5.BackColor = Color.LightGreen;
            return true;
        }
        private Boolean isSixth()
        {
            
            if("1970-01-01" != dateTimePicker1.Value.ToString("yyyy-MM-dd"))
            {
                label6.BackColor = Color.Red;
                return false;
            }
            label6.BackColor = Color.LightGreen;
            return true;
        }
    }
}
