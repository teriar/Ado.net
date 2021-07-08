using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace MiPrimera_AplicacionConSqlServer
{
    public partial class frmConsultaMedicamento : Form
    {
        public frmConsultaMedicamento()
        {
            InitializeComponent();
        }

        private void frmConsultaMedicamento_Load(object sender, EventArgs e)
        {


            SQL.relenarCombobox(cboFarmaceutica);


        }
    }
}
