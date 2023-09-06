namespace PjVentaHeredada
{
    partial class FrmCredito
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
            lblMonto = new Label();
            label13 = new Label();
            lvDetalles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAdquirir = new Button();
            txtCantidad = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cboProducto = new ComboBox();
            label9 = new Label();
            txtRuc = new TextBox();
            txtCliente = new TextBox();
            lblHora = new Label();
            lblFecha = new Label();
            label6 = new Label();
            label5 = new Label();
            RUC = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            cboLetras = new ComboBox();
            lvResumen = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnResumen = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblMonto.Location = new Point(530, 429);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(24, 19);
            lblMonto.TabIndex = 40;
            lblMonto.Text = "---";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(497, 392);
            label13.Name = "label13";
            label13.Size = new Size(109, 19);
            label13.TabIndex = 39;
            label13.Text = "Monto a Pagar";
            // 
            // lvDetalles
            // 
            lvDetalles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvDetalles.GridLines = true;
            lvDetalles.Location = new Point(48, 278);
            lvDetalles.Name = "lvDetalles";
            lvDetalles.Size = new Size(506, 97);
            lvDetalles.TabIndex = 36;
            lvDetalles.UseCompatibleStateImageBehavior = false;
            lvDetalles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ITEM";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripción del Producto";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cantidad";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SubTotal";
            columnHeader5.Width = 100;
            // 
            // btnAdquirir
            // 
            btnAdquirir.BackColor = SystemColors.ButtonHighlight;
            btnAdquirir.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdquirir.Location = new Point(443, 233);
            btnAdquirir.Name = "btnAdquirir";
            btnAdquirir.Size = new Size(91, 23);
            btnAdquirir.TabIndex = 35;
            btnAdquirir.Text = "Adquirir";
            btnAdquirir.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.LavenderBlush;
            txtCantidad.Location = new Point(228, 234);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(159, 23);
            txtCantidad.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(228, 212);
            label11.Name = "label11";
            label11.Size = new Size(138, 19);
            label11.TabIndex = 33;
            label11.Text = "Cantidad Solicitada";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(35, 212);
            label10.Name = "label10";
            label10.Size = new Size(163, 19);
            label10.TabIndex = 32;
            label10.Text = "Seleccione un Producto";
            // 
            // cboProducto
            // 
            cboProducto.BackColor = Color.LavenderBlush;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(40, 234);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(158, 23);
            cboProducto.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(75, 179);
            label9.Name = "label9";
            label9.Size = new Size(122, 19);
            label9.TabIndex = 30;
            label9.Text = "Datos de la Venta";
            // 
            // txtRuc
            // 
            txtRuc.BackColor = Color.LavenderBlush;
            txtRuc.Location = new Point(228, 138);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(159, 23);
            txtRuc.TabIndex = 29;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.LavenderBlush;
            txtCliente.Location = new Point(36, 139);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(159, 23);
            txtCliente.TabIndex = 28;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblHora.Location = new Point(510, 138);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(24, 19);
            lblHora.TabIndex = 27;
            lblHora.Text = "---";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.Location = new Point(426, 138);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(24, 19);
            lblFecha.TabIndex = 26;
            lblFecha.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(504, 101);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 25;
            label6.Text = "Hora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(414, 101);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 24;
            label5.Text = "Fecha";
            // 
            // RUC
            // 
            RUC.AutoSize = true;
            RUC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RUC.Location = new Point(228, 101);
            RUC.Name = "RUC";
            RUC.Size = new Size(43, 19);
            RUC.TabIndex = 23;
            RUC.Text = "RUC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 101);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 22;
            label3.Text = "Cliente o Razón Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(75, 60);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 21;
            label2.Text = "Datos del Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(83, 378);
            label1.Name = "label1";
            label1.Size = new Size(140, 19);
            label1.TabIndex = 41;
            label1.Text = "Opciones de Crédito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 409);
            label4.Name = "label4";
            label4.Size = new Size(128, 19);
            label4.TabIndex = 42;
            label4.Text = "Seleccione Letras";
            // 
            // cboLetras
            // 
            cboLetras.BackColor = Color.LavenderBlush;
            cboLetras.FormattingEnabled = true;
            cboLetras.Location = new Point(47, 431);
            cboLetras.Name = "cboLetras";
            cboLetras.Size = new Size(158, 23);
            cboLetras.TabIndex = 43;
            // 
            // lvResumen
            // 
            lvResumen.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
            lvResumen.GridLines = true;
            lvResumen.Location = new Point(228, 409);
            lvResumen.Name = "lvResumen";
            lvResumen.Size = new Size(263, 97);
            lvResumen.TabIndex = 45;
            lvResumen.UseCompatibleStateImageBehavior = false;
            lvResumen.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "N°Letras";
            columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Monto";
            columnHeader7.Width = 130;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = SystemColors.ButtonHighlight;
            btnResumen.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResumen.Location = new Point(47, 472);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(156, 23);
            btnResumen.TabIndex = 46;
            btnResumen.Text = "Mostrar Resumen";
            btnResumen.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(122, 18);
            label7.Name = "label7";
            label7.Size = new Size(369, 30);
            label7.TabIndex = 47;
            label7.Text = "VENTA DE PRODUCTOS AL CRÉDITO";
            // 
            // FrmCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(636, 520);
            Controls.Add(label7);
            Controls.Add(btnResumen);
            Controls.Add(lvResumen);
            Controls.Add(cboLetras);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lblMonto);
            Controls.Add(label13);
            Controls.Add(lvDetalles);
            Controls.Add(btnAdquirir);
            Controls.Add(txtCantidad);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboProducto);
            Controls.Add(label9);
            Controls.Add(txtRuc);
            Controls.Add(txtCliente);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(RUC);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmCredito";
            Text = "FrmCredito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label label13;
        private ListView lvDetalles;
        private Button btnAdquirir;
        private TextBox txtCantidad;
        private Label label11;
        private Label label10;
        private ComboBox cboProducto;
        private Label label9;
        private TextBox txtRuc;
        private TextBox txtCliente;
        private Label lblHora;
        private Label lblFecha;
        private Label label6;
        private Label label5;
        private Label RUC;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cboLetras;
        private TextBox txtResumen;
        private ListView lvResumen;
        private Button btnResumen;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label7;
    }
}