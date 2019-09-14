using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_impares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, impar = 0;
            for (i=0; i <= Convert.ToInt16(txtsumar.Text);i++)
            {
                if (i%2 !=0)
                {
                    impar += i;
                    listBox1.Items.Add(i.ToString());

                }
            }

            MessageBox.Show("El Resultado es: " +impar);


        }

    }
}
