using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppNumeroALetra
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
            Numalet let = new Numalet();
            //al uso en México (creo):
            let.MascaraSalidaDecimal = "00/100 M.N.";
            let.SeparadorDecimalSalida = "pesos";
            //observar que sin esta propiedad queda "veintiuno pesos" en vez de "veintiún pesos":
            let.ApocoparUnoParteEntera = true;
            var cantidadLetra = let.ToCustomCardinal(textBox1.Text);
            label1.Text = cantidadLetra;
            MessageBox.Show(cantidadLetra);
        }
    }
}
