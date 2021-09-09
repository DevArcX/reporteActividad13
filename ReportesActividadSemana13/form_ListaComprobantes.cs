using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesActividadSemana13
{
    public partial class form_ListaComprobantes : Form
    {
        public form_ListaComprobantes()
        {
            InitializeComponent();
            Controles(false);
        }
        private void Controles(bool stado)
        {
            dtpHasta.Enabled = stado;
            txbCliente.Enabled = stado;
            txbEmpleado.Enabled = stado;
        }

        private void form_ListaComprobantes_Load(object sender, EventArgs e)
        {
            dtpDe.MinDate= Convert.ToDateTime("1996-01-01");
            dtpDe.MaxDate = Convert.ToDateTime("1999-01-01");
        }
        private void cargarReporte(DateTime fechaDe, DateTime fechaHasta, string cliente, string empleado)
        {
            // TODO: esta línea de código carga datos en la tabla 'DbNortwind.SP_ListaComprobantes' Puede moverla o quitarla según sea necesario.
            this.SP_ListaComprobantesTableAdapter.Fill(this.DbNortwind.SP_ListaComprobantes, fechaDe, fechaHasta, cliente, empleado);

            this.reportViewer2.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            form_Inicio abrir = new form_Inicio();
            abrir.Show();
            this.Dispose();
        }

        private void txbCliente_TextChanged(object sender, EventArgs e)
        {
            if (txbCliente.Text != "")
            {
                cargarReporte(Convert.ToDateTime(dtpDe.Value.ToString("yyyy-MM-dd")),
                 Convert.ToDateTime(dtpHasta.Value.ToString("yyyy-MM-dd")), txbCliente.Text, txbEmpleado.Text);
            }
        }

        private void txbEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txbEmpleado.Text != "")
            {
                cargarReporte(Convert.ToDateTime(dtpDe.Value.ToString("yyyy-MM-dd")),
                Convert.ToDateTime(dtpHasta.Value.ToString("yyyy-MM-dd")), txbCliente.Text, txbEmpleado.Text);
            }
        }

        private void dtpDe_CloseUp(object sender, EventArgs e)
        {
            dtpHasta.MinDate = dtpDe.Value;
            dtpHasta.MaxDate = Convert.ToDateTime("1999-01-01");
            Controles(true);
        }

        private void dtpHasta_CloseUp(object sender, EventArgs e)
        {
            cargarReporte(Convert.ToDateTime(dtpDe.Value.ToString("yyyy-MM-dd")),
                Convert.ToDateTime(dtpHasta.Value.ToString("yyyy-MM-dd")), txbCliente.Text,txbEmpleado.Text);
        }
    }
}
