﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1_CDJ2324, num2, num3_CDJ2324, suma, producto;
            string tSuma, tProducto;

            num1_CDJ2324 = double.Parse(tNum1.Text);
            num2 = double.Parse(tNum2_CDJ2324.Text);
            num3_CDJ2324 = double.Parse(tNum3.Text);

            suma = (double)num1_CDJ2324 + (double)num2 + (double)num3_CDJ2324;
            producto = (double)num1_CDJ2324 * (double)num2 * (double)num3_CDJ2324;

            tSuma = suma.ToString();
            tProducto = producto.ToString();

            MessageBox.Show("La suma de los números ingresados es: " + suma + " el producto es: " + producto);
        }
    }
}
