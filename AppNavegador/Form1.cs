using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNavegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnMenor_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void BtnMayor_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/webhp?hl=es-419&sa=X&ved=0ahUKEwiXx6fL0O36AhXvL0QIHd1fAgkQPAgI");
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            string direccion = comboBox1.Text;
            if (comboBox1.Items.Contains(direccion) == false)
            {
                comboBox1.Items.Add(direccion);
            }
            webBrowser1.Navigate(direccion);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/webhp?hl=es-419&sa=X&ved=0ahUKEwiXx6fL0O36AhXvL0QIHd1fAgkQPAgI");
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string direccion = comboBox1.Text;
                if (comboBox1.Items.Contains(direccion) == false)
                {
                    comboBox1.Items.Add(direccion);
                }
                webBrowser1.Navigate(direccion);
            }
        }
    }
}
