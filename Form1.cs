using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstaTDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Celular> celulares = new List<Celular>();
        Celular celular = new Celular();

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            if (ValidarCampo() == true)
            {
                Celular elemento = new Celular(TxtMarca.Text, TxtColor.Text, float.Parse(MaskedTxtTamaño.Text), Convert.ToInt32(NUDTxtCamaras.Text), TxtMaterial.Text, TxtModelo.Text);
                celulares.Add(elemento);

                LstCelulares.Items.Clear();
                LstCelulares.Items.AddRange(celulares.ToArray());
                Limpiar();
            }
            else
            {
                ValidarCampo();
            }
           
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La lista tiene " + celulares.Count.ToString() + " elementos");
        }

        private void Limpiar()
        {
            TxtMarca.Clear(); TxtColor.Clear(); MaskedTxtTamaño.Clear(); NUDTxtCamaras.Text = "0"; TxtMaterial.Clear(); TxtModelo.Clear();
        }

        private bool ValidarCampo()
        {
            if (TxtMarca.Text == "")
            {
                MessageBox.Show("Debe ingresar la marca del celular","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TxtColor.Text == "")
            {
                MessageBox.Show("Debe ingresar el color del celular", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (MaskedTxtTamaño.Text == "")
            {
                MessageBox.Show("Debe ingresar el tamaño del celular","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (NUDTxtCamaras.Text == "")
            {
                MessageBox.Show("Debe ingresar el numero de camaras del celular","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TxtMaterial.Text == "")
            {
                MessageBox.Show("Debe ingresar el material del celular","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TxtModelo.Text == "")
            {
                MessageBox.Show("Debe ingresar el modelo del celular" + MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
