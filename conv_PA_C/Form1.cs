using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conv_PA_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

       

        private void btnfar_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(tbcel.Text);
            float Farenheint = (Celsius * 9f / 5f) + 32;
            tbfar.Text = Farenheint.ToString();
            tbfar.Enabled = false;
            tbcel.Enabled = false;
        }

        private void btncel_Click(object sender, EventArgs e)
        {
            float Farenheint = float.Parse(tbfar.Text);
            float Celsius = (Farenheint - 32) * 5.0f / 9.0f;
            tbcel.Text = Celsius.ToString();
            tbfar.Enabled = false;
            tbcel.Enabled = false;
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            tbcel.Text = "0.0";
            tbfar.Text = "0.0";
            MessageBox.Show("SE HAN BORRADO LOS DATOS INGRESADOS");
            tbfar.Enabled = true;
            tbcel.Enabled = true;
        }
    }
}
