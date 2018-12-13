using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.ServiceReference1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConversionServiceClient client = new ConversionServiceClient();
            double celsiusDegree = double.Parse(label1.Text);
            label2.Text = client.CelsiusToFahrenheit(celsiusDegree).ToString();
          
        }
    }
}
