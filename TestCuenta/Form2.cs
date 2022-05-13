using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace TestCuenta
{
    public partial class Form2 : Form
    {
        CapaEntidades.cEntidades objE = new CapaEntidades.cEntidades();
        CapaNegocio.cNegocio objN = new CapaNegocio.cNegocio();

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            objE.usu1 = textBox1.Text;
            objE.pas1 = textBox2.Text;

            dt = objN.N_Login(objE);

            if (dt.Rows.Count > 0)
            {
                objE.usu1 = dt.Rows[0][0].ToString();
                objE.pas1 = dt.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido cliente: " + objE.pas1, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 appTransacciones = new Form2();
                appTransacciones.Show();
            }
            else
            {
                MessageBox.Show("Error, usuario invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
