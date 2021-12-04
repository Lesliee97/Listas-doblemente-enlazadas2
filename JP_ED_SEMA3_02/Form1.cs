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
    public partial class Form1 : Form
    {
        Lista_Circular milista = new Lista_Circular();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Nodo n;
            int d = Int32.Parse(txtnumero.Text);
            n = new Nodo();
            n.Dato = d;
            n.Siguiente = null;
            n.Atras = null;
            milista.Agregar(n);
            txtdatos.Clear();
            txtdatos.Focus();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            lblContar.Text = milista.MostrarDatos();
            lblContarDes.Text = milista.MostrarDatosAnt();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(milista.Buscar(int.Parse(txtnumero.Text)))
            {
                buscando.Text = "Si esta";
            }
            else
            {
                buscando.Text = "NO esta";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            milista.Eliminar(int.Parse(txtnumero.Text));
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            label4.Text = milista.ContarNodos() + "";
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dgvLista.Columns)
                {
                    cabeceras.Add(col.HeaderText);
                }
                string SEP = txtnumero.Text;
                filas.Add(string.Join(SEP, cabeceras));

                foreach (DataGridViewRow fila in dgvLista.Rows)
                {
                    try
                    {
                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell c in fila.Cells)
                            celdas.Add(c.Value.ToString());
                        filas.Add(string.Join(SEP, celdas));
                    }
                    catch(Exception)
                    {
                    }
                }
                File.WriteAllLines(sfd.FileName, filas);
            }*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int m = dgvLista.Rows.Add();
            dgvLista.Rows[m].Cells[0].Value = lblContar.Text;
        }
    }
}
