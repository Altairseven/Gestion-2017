using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_2017.UserComponents {
    public partial class TB_Base : UserControl {
        public TB_Base() {
            InitializeComponent();
        }

        private void MTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
        }

        private void MTB_Enter(object sender, EventArgs e) {
            this.MTB.SelectAll();
        }
    }
}
