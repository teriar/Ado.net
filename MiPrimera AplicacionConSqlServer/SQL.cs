using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
namespace MiPrimera_AplicacionConSqlServer
{
   public class SQL
    {
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);


        public static void ListarConsultasql(String consulta, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            grilla.DataSource= tabla;
            cn.Close();
        }


        public static void ListarPorIDyNombre(DataGridView grilla, string texto)
        {
            SqlCommand cmd = new SqlCommand("FiltrarClinicaPorIdyNombre", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parametro", texto);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            grilla.DataSource = tabla;
            cn.Close();
        }

        public static void ListarPorNombreconsulta(DataGridView grilla, string Texto) {
           
            string consulta = "select * from Clinica where NOMBRE like "  + "'" + Texto + "%" +  "'"  + " and BHABILITADO = 1";
            MessageBox.Show(consulta);
            SqlCommand cmd = new SqlCommand(consulta,cn);
            cmd.CommandType = CommandType.Text;

            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            grilla.DataSource = tabla;
            cn.Close();
        }
        
        public static void filtroDinamico(string texto, DataGridView grilla) 
        {
            
            string consulta = " select * from Especialidad where Nombre like " + "'" + texto +  "%'";
           
            SqlCommand cmd = new SqlCommand(consulta,cn);
            cmd.CommandType = CommandType.Text;
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            grilla.DataSource = tabla;
            cn.Close();

        } 
        public static void relenarCombobox(ComboBox combo, string displaymember="Nombre",string valuemember= "IIDFORMAFARMACEUTICA") {
            string consulta = "Select IIDFORMAFARMACEUTICA,NOMBRE  from FormaFarmaceutica WHERE BHABILITADO = 1";
            SqlCommand cmd = new SqlCommand(consulta, cn);
            cmd.CommandType = CommandType.Text;
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            combo.DataSource = tabla;
            combo.DisplayMember = displaymember;
            combo.ValueMember = valuemember;
        }
    }
}
