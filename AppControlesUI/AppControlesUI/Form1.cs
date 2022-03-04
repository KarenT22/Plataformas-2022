using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlesUI
{
    public partial class FrmControles : Form
    {
        public FrmControles()
        {
            InitializeComponent();
        }

        private void FrmControles_Load(object sender, EventArgs e)
        {
            for(int contador = 0; contador <= 255; contador++)
            {
                cmbRojo.Items.Add(contador.ToString());
                cmbVerde.Items.Add(contador.ToString());
                cmbAzul.Items.Add(contador.ToString());
            }
            cmbRojo.SelectedIndex = 0;
            cmbVerde.SelectedIndex = 0;
            cmbAzul.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre, biografia="";
            string navegador="";

            biografia = rtbBiografia.Text;

            nombre = txtNombre.Text;

            if (chkGoogle.Checked==true)
            {
                navegador = navegador + chkGoogle.Text + "\n";
            }

            if (chkOpera.Checked==true)
            {
                navegador = navegador + chkOpera.Text + "\n";
            }
            if (chkMicrosoft.Checked == true)
            {
                navegador = navegador + chkMicrosoft.Text + "\n";
            }

           

            MessageBox.Show("Nombre: " + nombre + "\n" + "\n" + "Navegador Favorito: " + 
                            navegador +"\n" + "\n" + "Biografía: " + biografia, "Datos Registrados: ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (rd800.Checked == true)
            {
                Width = 800;
                Height = 600;
            }
            else if (rd1024.Checked == true)
            {
                Width = 1024;
                Height = 768;
            }
            else if (rd1280.Checked == true)
            {
                Width = 1280;
                Height = 720;
            }
        }

        private void lblResolucion_Click(object sender, EventArgs e)
        {

        }

        private void cmbRojo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbVerde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAzul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = int.Parse(cmbRojo.Text);
            verde = int.Parse(cmbVerde.Text);
            azul = int.Parse(cmbAzul.Text);

            BackColor = Color.FromArgb(rojo, verde, azul);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechanac;
            fechanac = dtpFechaNac.Value;
            MessageBox.Show(fechanac.ToString(), "Fecha de Nacimiento: ");
        }
    }
}
