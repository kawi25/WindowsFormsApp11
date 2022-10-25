using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        private object txtCapital;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ItemSelect = comboOption.Text;
            double capital = Convert.ToDouble(txtCapital.Text);
            int interes = Convert.ToInt32(txtInteres.Text);
            int tiempo = Convert.ToInt32(txtTiempo.Text);
            double resultado;
            switch (ItemSelect)
            {
                case "Anual":
                    resultado = capital * interes * tiempo;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;
                case "Mensual":
                    resultado = capital * interes * tiempo / 12;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;
                case "Diario":
                    resultado = capital * interes * tiempo / 360;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;
            }
        }
    }

    internal class txtInteres
    {
        internal static readonly object Text;
    }

    internal class txtresultado
    {
        internal static string Text;
    }

    class txtTiempo
    {
        internal static readonly object Text;
    }

    class comboOption
    {
        internal static readonly string Text;
    }
}
        
    
