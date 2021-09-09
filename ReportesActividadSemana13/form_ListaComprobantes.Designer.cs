
namespace ReportesActividadSemana13
{
    partial class form_ListaComprobantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ListaComprobantes));
            this.SP_ListaComprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbNortwind = new ReportesActividadSemana13.DbNortwind();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_ListaComprobantesTableAdapter = new ReportesActividadSemana13.DbNortwindTableAdapters.SP_ListaComprobantesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ListaComprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbNortwind)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SP_ListaComprobantesBindingSource
            // 
            this.SP_ListaComprobantesBindingSource.DataMember = "SP_ListaComprobantes";
            this.SP_ListaComprobantesBindingSource.DataSource = this.DbNortwind;
            // 
            // DbNortwind
            // 
            this.DbNortwind.DataSetName = "DbNortwind";
            this.DbNortwind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txbEmpleado);
            this.panel1.Controls.Add(this.txbCliente);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.dtpDe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::ReportesActividadSemana13.Properties.Resources.salida_Exist_Opcional;
            this.btnSalir.Location = new System.Drawing.Point(1101, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.Location = new System.Drawing.Point(853, 57);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.Size = new System.Drawing.Size(133, 24);
            this.txbEmpleado.TabIndex = 13;
            this.txbEmpleado.TextChanged += new System.EventHandler(this.txbEmpleado_TextChanged);
            // 
            // txbCliente
            // 
            this.txbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(585, 57);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(133, 24);
            this.txbCliente.TabIndex = 12;
            this.txbCliente.TextChanged += new System.EventHandler(this.txbCliente_TextChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(355, 57);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(117, 24);
            this.dtpHasta.TabIndex = 11;
            this.dtpHasta.CloseUp += new System.EventHandler(this.dtpHasta_CloseUp);
            // 
            // dtpDe
            // 
            this.dtpDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(168, 57);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(117, 24);
            this.dtpDe.TabIndex = 10;
            this.dtpDe.CloseUp += new System.EventHandler(this.dtpDe_CloseUp);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(155)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(747, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empleado :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(155)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(515, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(155)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(291, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(155)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(115, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "De :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "REPORTE DE COMPROBANTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "listComprobantes";
            reportDataSource1.Value = this.SP_ListaComprobantesBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ReportesActividadSemana13.ListaComprobante.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 100);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1150, 550);
            this.reportViewer2.TabIndex = 1;
            // 
            // SP_ListaComprobantesTableAdapter
            // 
            this.SP_ListaComprobantesTableAdapter.ClearBeforeFill = true;
            // 
            // form_ListaComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ListaComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ListaComprobantes";
            this.Load += new System.EventHandler(this.form_ListaComprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ListaComprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbNortwind)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmpleado;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource SP_ListaComprobantesBindingSource;
        private DbNortwind DbNortwind;
        private DbNortwindTableAdapters.SP_ListaComprobantesTableAdapter SP_ListaComprobantesTableAdapter;
    }
}