using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ReportesActividadSemana13
{
    public partial class form_Comprobante : Form
    {
        Conexion oConexion = new Conexion();
        public form_Comprobante()
        {
            InitializeComponent();
        }

        private void form_Comprobante_Load(object sender, EventArgs e)
        {
            DataSet dts = new DataSet();
            dts = oConexion.ListarPedidos();
            if (dts.Tables[0].Rows.Count > 0)
            {
                dgvPedidos.DataSource = dts.Tables[0];
                dgvPedidos.ClearSelection();
            }
        }
        private void CargarReporte(int IdOrden)
        {
            // TODO: esta línea de código carga datos en la tabla 'DbNortwind.SP_ComprobantePago' Puede moverla o quitarla según sea necesario.
            this.SP_ComprobantePagoTableAdapter.Fill(this.DbNortwind.SP_ComprobantePago, IdOrden);

            this.reportViewer1.RefreshReport();
        }

        private void dgvPedidos_Click(object sender, EventArgs e)
        {
            int IdOrden = Convert.ToInt32(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value);
            CargarReporte(IdOrden);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            form_Inicio abrir = new form_Inicio();
            abrir.Show();
            this.Dispose();
        }
    }
}
