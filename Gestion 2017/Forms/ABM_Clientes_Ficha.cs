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


namespace Gestion_2017.Forms {
    public partial class ABM_Clientes_Ficha : Form {
        public ABM_Clientes_Ficha() {
            InitializeComponent();
        }

        public DataSet ClientesDS = new DataSet();
        //Se encarga de la transferencia de datos entre el dataset y la tabla real
        public SqlDataAdapter DA = new SqlDataAdapter();
        public int Npuntero = 0; // puntero del registro del dataset
        public SqlConnection oCo = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=P:\Visual Studio\Franco\Gestion\Data\Gestion.mdf;Integrated Security = True");

        private void ABM_Clientes_Ficha_Load(object sender, EventArgs e) {
            //oCo.Open();
            //DA = new SqlDataAdapter("SELECT * FROM clientes ORDER BY numclie ASC", oCo);
            //SqlCommandBuilder aux = new SqlCommandBuilder(DA);
            //DA.Fill(ClientesDS, "cliente");

            //oCo.Close();
        }




        private void tB_Base3_Leave(object sender, EventArgs e) {
            tB_Base1.MTB.Focus();
        }

        private void tB_Base3_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Tab)
                button1.Focus();
        }


    }
}
