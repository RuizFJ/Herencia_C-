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
            btnCredito = new Button();
            btnContado = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCredito
            // 
            btnCredito.BackColor = Color.DodgerBlue;
            btnCredito.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCredito.ForeColor = SystemColors.ButtonFace;
            btnCredito.Location = new Point(76, 168);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(137, 40);
            btnCredito.TabIndex = 0;
            btnCredito.Text = "Venta al Credito";
            btnCredito.UseVisualStyleBackColor = false;
            btnCredito.Click += btnCredito_Click;
            // 
            // btnContado
            // 
            btnContado.BackColor = Color.DodgerBlue;
            btnContado.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContado.ForeColor = SystemColors.ButtonHighlight;
            btnContado.Location = new Point(302, 168);
            btnContado.Name = "btnContado";
            btnContado.Size = new Size(137, 40);
            btnContado.TabIndex = 1;
            btnContado.Text = "Venta al Contado";
            btnContado.UseVisualStyleBackColor = false;
            btnContado.Click += btnContado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 23);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 2;
            label1.Text = "Venta de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(171, 115);
            label2.Name = "label2";
            label2.Size = new Size(185, 21);
            label2.TabIndex = 3;
            label2.Text = "Seleccione una Opción";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(535, 331);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnContado);
            Controls.Add(btnCredito);
            Name = "FrmPrincipal";
            Text = "Formulario Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCredito;
        private Button btnContado;
        private Label label1;
        private Label label2;
    }
}