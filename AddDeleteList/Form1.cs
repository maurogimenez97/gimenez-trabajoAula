using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDeleteList
{
    public partial class Form1 : Form
    {

        List<string> listanombres = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = text_nombres.Text;
            listanombres.Add(nombre);

            list_nombres.DataSource = null;
            list_nombres.DataSource = listanombres;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listanombres.Remove(text_nombres.Text);

            list_nombres.DataSource = null;
            list_nombres.DataSource = listanombres;
        }
    }
}
