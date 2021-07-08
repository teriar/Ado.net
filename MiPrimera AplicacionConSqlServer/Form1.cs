using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MiPrimera_AplicacionConSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            listar();

            
        }
        private void listar()
        {
                     SQL.ListarConsultasql("Select IIDCLINICA,NOMBRE,DIRECCION from clinica where BHABILITADO=1", dgbClinica);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String idclinica = txtIdClinica.Text;
            //SQL.ListarPorIDyNombre(dgbClinica, idclinica);
            SQL.ListarPorNombreconsulta(dgbClinica, idclinica);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            listar();
            txtIdClinica.Clear();
        }
    }
}
