using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_ED_SEMA3_02
{ 
    public partial class Form2 : Form
    {
        List<ClsLista> OtraLista = new List<ClsLista>();   
        public Form2()
        {
            InitializeComponent();
            tsmConsultar.Enabled = false;
            tsmEliminar.Enabled = false;
        }

        private void limpiarControles()
        {
            TxtEdad.Clear();
            txtNombre.Clear();
            cbnRaza.SelectedIndex = 0;
        }

        private bool Existe(string Nombre)
        {
            foreach(ClsLista miMacota in OtraLista)
            {
                if(miMacota.Nombre == Nombre)
                {
                    return true;
                }
            }
            return false;   
        }

        private bool ValidarEdad()
        {
            int Edad;
            if(!int.TryParse(TxtEdad.Text, out Edad) || TxtEdad.Text == "")
            {
                erpError.SetError(TxtEdad, "DEBE SELECCIONAR UNA RAZA");
                 TxtEdad.Clear();
                TxtEdad.Focus();
                return false;
            }
            else{
                erpError.SetError(TxtEdad , "");
                return true;
            }
        }


        private bool ValidarRaza()
        {
            if (string.IsNullOrEmpty(cbnRaza.Text))
            {
                erpError.SetError(cbnRaza, "DEBE SELECCIONAR UNA RAZA");
                return false;
            }
            else
            {
                erpError.SetError(cbnRaza, "");
                return true;
            }
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "DEBE SELECCIONAR UNA RAZA");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    cabeceras.Add(col.HeaderText);
                }
                string SEP = txtSep.Text;
                filas.Add(string.Join(SEP, cabeceras));

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    try
                    {
                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell c in fila.Cells)
                            celdas.Add(c.Value.ToString());
                        filas.Add(string.Join(SEP, celdas));
                    }
                    catch (Exception ex)
                    { }
                }
                File.WriteAllLines(sfd.FileName, filas);
            }*/
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmConsultar_Click(object sender, EventArgs e)
        {
            if(ValidarNombre () ==false)
            {
                return;
            }
            ClsLista miMascota = GetMascota(txtNombre.Text);
            if(miMascota == null)
            {
                erpError.SetError(txtNombre, "La mascota no esta registrada en la lista");
                limpiarControles();
                txtNombre.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                txtNombre.Text = miMascota.Nombre;
                cbnRaza.SelectedItem = miMascota.Raza;
                TxtEdad.Text = miMascota.Edad.ToString();
                tsmEliminar.Enabled = true;
            }
        }

        private ClsLista GetMascota(string nombre)
        {
            return OtraLista.Find(mascota => mascota.Nombre.Contains(nombre));
        }

        

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
           if(txtNombre.Text == "")
           {
               erpError.SetError(txtNombre, "Debe primero consultar la mascota a eliminar");
               limpiarControles();
               txtNombre.Focus();
               tsmEliminar.Enabled = false;
               return;
           }
            else
           {
               erpError.SetError(txtNombre, "");
               DialogResult Respuesta = MessageBox.Show("Estas seguro de querer eliminar la lista", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
               if (Respuesta == DialogResult.Yes)
               {
                   foreach(ClsLista miMascota in OtraLista)
                   {
                       if(miMascota.Nombre == txtNombre.Text)
                       {
                           OtraLista.Remove(miMascota);
                           break;
                       }
                   }
                       limpiarControles();
                       dataGridView1.DataSource = null;
                       dataGridView1.DataSource = OtraLista;
               }
           }
        }

        private void tsmRegistrar_Click(object sender, EventArgs e)
        {
           if(ValidarNombre() == false)
           {
               return;
           }
           if (ValidarRaza() == false)
           {
               return;
           }
           if (ValidarEdad() == false)
           {
               return;
           }
            if(Existe(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "La mascota con ese nombre ya esta registrado");
                limpiarControles();
                txtNombre.Focus();
                return;
            }
            erpError.SetError(txtNombre, "");

            ClsLista miMascota = new ClsLista();

            miMascota.Nombre = txtNombre.Text;
            miMascota.Raza = cbnRaza.Text;
            miMascota.Edad = int.Parse(TxtEdad.Text);
            OtraLista.Add(miMascota);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OtraLista;
            limpiarControles();
            txtNombre.Focus();
            tsmConsultar.Enabled = true;
        }
    }
}
