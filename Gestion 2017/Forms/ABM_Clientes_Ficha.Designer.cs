namespace Gestion_2017.Forms {
    partial class ABM_Clientes_Ficha {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tB_Base1 = new Gestion_2017.UserComponents.TB_Base();
            this.tB_Base2 = new Gestion_2017.UserComponents.TB_Base();
            this.tB_Base3 = new Gestion_2017.UserComponents.TB_Base();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Base1
            // 
            this.tB_Base1.Location = new System.Drawing.Point(64, 72);
            this.tB_Base1.Name = "tB_Base1";
            this.tB_Base1.Size = new System.Drawing.Size(168, 22);
            this.tB_Base1.TabIndex = 0;
            // 
            // tB_Base2
            // 
            this.tB_Base2.Location = new System.Drawing.Point(64, 120);
            this.tB_Base2.Name = "tB_Base2";
            this.tB_Base2.Size = new System.Drawing.Size(168, 22);
            this.tB_Base2.TabIndex = 1;
            // 
            // tB_Base3
            // 
            this.tB_Base3.Location = new System.Drawing.Point(64, 160);
            this.tB_Base3.Name = "tB_Base3";
            this.tB_Base3.Size = new System.Drawing.Size(168, 22);
            this.tB_Base3.TabIndex = 2;
            this.tB_Base3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_Base3_KeyDown);
            this.tB_Base3.Leave += new System.EventHandler(this.tB_Base3_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ABM_Clientes_Ficha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_Base3);
            this.Controls.Add(this.tB_Base2);
            this.Controls.Add(this.tB_Base1);
            this.Name = "ABM_Clientes_Ficha";
            this.Text = "ABM_Clientes_Ficha";
            this.Load += new System.EventHandler(this.ABM_Clientes_Ficha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserComponents.TB_Base tB_Base1;
        private UserComponents.TB_Base tB_Base2;
        private UserComponents.TB_Base tB_Base3;
        private System.Windows.Forms.Button button1;
    }
}