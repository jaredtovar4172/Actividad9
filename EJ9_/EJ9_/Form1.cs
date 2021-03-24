using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace EJ9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dias = textBox2.Text;
            string año = textBox3.Text;
            string fecha = textBox1.Text;
            switch (fecha)
            {
                case "enero":
                    fecha = "01";
                    break;
                case "febrero":
                    fecha = "02";
                    break;
                case "marzo":
                    fecha = "03";
                    break;
                case "abril":
                    fecha = "04";
                    break;
                case "mayo":
                    fecha = "05";
                    break;
                case "junio":
                    fecha = "06";
                    break;
                case "julio":
                    fecha = "07";
                    break;
                case "agosto":
                    fecha = "08";
                    break;
                case "septiembre":
                    fecha = "09";
                    break;
                case "noviembre":
                    fecha = "10";
                    break;
                case "diciembre":
                    fecha = "12";
                    break;
                 
            }
           string resultado = dias + "/" + fecha + "/" + año + "";
            this.label4.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Focus();
            label4.Text = "Resultado";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
        }
    
