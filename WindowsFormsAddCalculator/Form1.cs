using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAddCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Number1.Text);
            int num2 = Convert.ToInt32(Number2.Text);

            int sum = num1 + num2;
            int diff = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;

            SumNum.Text = sum.ToString();
            DiffNum.Text = diff.ToString();
            MulNum.Text = mul.ToString();
            DivNum.Text = div.ToString();
        }
    }
}
