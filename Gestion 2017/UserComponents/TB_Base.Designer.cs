namespace Gestion_2017.UserComponents {
    partial class TB_Base {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // MTB
            // 
            this.MTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MTB.Location = new System.Drawing.Point(0, 0);
            this.MTB.Name = "MTB";
            this.MTB.Size = new System.Drawing.Size(168, 22);
            this.MTB.TabIndex = 0;
            this.MTB.Enter += new System.EventHandler(this.MTB_Enter);
            this.MTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MTB_KeyDown);
            // 
            // TB_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MTB);
            this.Name = "TB_Base";
            this.Size = new System.Drawing.Size(168, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox MTB;
    }
}
