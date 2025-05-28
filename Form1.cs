using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VentasAPP
{
    public partial class Form1 : Form
    {
        private SQLHelper sqlHelper;

        public Form1()
        {
            InitializeComponent();
            sqlHelper = new SQLHelper();
        }
    

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                int stock = int.Parse(txtStock.Text.Trim());

                sqlHelper.InsertarVenta(codigo, descripcion, stock);
                MessageBox.Show("Venta insertada correctamente. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la venta:" + ex.Message);
            }
        }
    } }
