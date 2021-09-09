using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ReportesActividadSemana13
{
    public class Conexion
    {
        public SqlConnection conexion;

        //comentario de pau-edit
        //comentario de Cris-Edit
        public void CadenaConexion()
        {
            conexion = new SqlConnection(@"
                Data Source=mssql-46601-0.cloudclusters.net,19839;
                Initial Catalog=northwind;
                User ID=Cris;
                Password=DBSistem2020");
        }
        public void Abrir()
        {
            try
            {
                CadenaConexion();
                conexion.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public void Cerrar()
        {
            conexion.Close();
        }
        public DataSet ListarPedidos()
        {
            DataSet dts = new DataSet();
            Abrir();
            SqlCommand cm = new SqlCommand("SP_ListaPedido", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dts);
            Cerrar();
            return dts;
        }
    }
}
