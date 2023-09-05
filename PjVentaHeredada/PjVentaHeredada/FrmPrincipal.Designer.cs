namespace PjVentaHeredada
{
    partial class FrmPrincipal
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
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnContado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCredito
            // 
            this.btnCredito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCredito.Location = new System.Drawing.Point(76, 168);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(137, 40);
            this.btnCredito.TabIndex = 0;
            this.btnCredito.Text = "Venta al Credito";
            this.btnCredito.UseVisualStyleBackColor = true;
            // 
            // btnContado
            // 
            this.btnContado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContado.Location = new System.Drawing.Point(302, 168);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(137, 40);
            this.btnContado.TabIndex = 1;
            this.btnContado.Text = "Venta al Contado";
            this.btnContado.UseVisualStyleBackColor = true;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Venta de Productos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(535, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContado);
            this.Controls.Add(this.btnCredito);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCredito;
        private Button btnContado;
        private Label label1;
    }
}