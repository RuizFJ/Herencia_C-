namespace PjVentaHeredada
{
    partial class FrmContado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RUC = new Label();
            label5 = new Label();
            label6 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            txtCliente = new TextBox();
            txtRuc = new TextBox();
            label9 = new Label();
            cboProducto = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtCantidad = new TextBox();
            btnAdquirir = new Button();
            lstResumen = new ListBox();
            label12 = new Label();
            label13 = new Label();
            lblNeto = new Label();
            lvDetalles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 30);
            label1.TabIndex = 0;
            label1.Text = "VENTA DE PRODUCTOS AL CONTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(68, 62);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 1;
            label2.Text = "Datos del Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 2;
            label3.Text = "Cliente o Razón Social";
            // 
            // RUC
            // 
            RUC.AutoSize = true;
            RUC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RUC.Location = new Point(221, 103);
            RUC.Name = "RUC";
            RUC.Size = new Size(43, 19);
            RUC.TabIndex = 3;
            RUC.Text = "RUC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(407, 103);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 4;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(497, 103);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 5;
            label6.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.Location = new Point(419, 140);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(24, 19);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "---";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblHora.Location = new Point(503, 140);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(24, 19);
            lblHora.TabIndex = 7;
            lblHora.Text = "---";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.LavenderBlush;
            txtCliente.Location = new Point(29, 141);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(159, 23);
            txtCliente.TabIndex = 8;
            // 
            // txtRuc
            // 
            txtRuc.BackColor = Color.LavenderBlush;
            txtRuc.Location = new Point(221, 140);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(159, 23);
            txtRuc.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(68, 181);
            label9.Name = "label9";
            label9.Size = new Size(122, 19);
            label9.TabIndex = 10;
            label9.Text = "Datos de la Venta";
            // 
            // cboProducto
            // 
            cboProducto.BackColor = Color.LavenderBlush;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(33, 236);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(158, 23);
            cboProducto.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 214);
            label10.Name = "label10";
            label10.Size = new Size(163, 19);
            label10.TabIndex = 12;
            label10.Text = "Seleccione un Producto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(221, 214);
            label11.Name = "label11";
            label11.Size = new Size(138, 19);
            label11.TabIndex = 13;
            label11.Text = "Cantidad Solicitada";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.LavenderBlush;
            txtCantidad.Location = new Point(221, 236);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(159, 23);
            txtCantidad.TabIndex = 14;
            // 
            // btnAdquirir
            // 
            btnAdquirir.BackColor = SystemColors.ButtonHighlight;
            btnAdquirir.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdquirir.Location = new Point(436, 235);
            btnAdquirir.Name = "btnAdquirir";
            btnAdquirir.Size = new Size(91, 23);
            btnAdquirir.TabIndex = 15;
            btnAdquirir.Text = "Adquirir";
            btnAdquirir.UseVisualStyleBackColor = false;
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.ItemHeight = 15;
            lstResumen.Location = new Point(33, 420);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(423, 94);
            lstResumen.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(33, 398);
            label12.Name = "label12";
            label12.Size = new Size(72, 19);
            label12.TabIndex = 18;
            label12.Text = "Resumen";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(482, 420);
            label13.Name = "label13";
            label13.Size = new Size(97, 19);
            label13.TabIndex = 19;
            label13.Text = "Neto a Pagar";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblNeto.Location = new Point(515, 457);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(24, 19);
            lblNeto.TabIndex = 20;
            lblNeto.Text = "---";
            // 
            // lvDetalles
            // 
            lvDetalles.BackColor = SystemColors.ButtonHighlight;
            lvDetalles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvDetalles.GridLines = true;
            lvDetalles.Location = new Point(33, 285);
            lvDetalles.Name = "lvDetalles";
            lvDetalles.Size = new Size(506, 97);
            lvDetalles.TabIndex = 37;
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
            // FrmContado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(639, 529);
            Controls.Add(lvDetalles);
            Controls.Add(lblNeto);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lstResumen);
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
            Controls.Add(label1);
            Name = "FrmContado";
            Text = "Venta de Productos al Contado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label RUC;
        private Label label5;
        private Label label6;
        private Label lblFecha;
        private Label lblHora;
        private TextBox txtCliente;
        private TextBox txtRuc;
        private Label label9;
        private ComboBox cboProducto;
        private Label label10;
        private Label label11;
        private TextBox txtCantidad;
        private Button btnAdquirir;
        private ListBox lstResumen;
        private Label label12;
        private Label label13;
        private Label lblNeto;
        private ListView lvDetalles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}