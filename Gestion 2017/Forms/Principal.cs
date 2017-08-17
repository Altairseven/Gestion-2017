using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_2017.Forms;

namespace Gestion_2017 {
    public partial class Principal : Form {

        public Principal() {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

        }

        private void aBMClientesFichaToolStripMenuItem_Click(object sender, EventArgs e) {
            ABM_Clientes_Ficha form = new ABM_Clientes_Ficha();
            form.Show(); //Abre el formulario sin lockear la ventana
            //form.ShowDialog(); // Abre el formulario como dialogo, lockeando la ventana.
        }
    }
}
