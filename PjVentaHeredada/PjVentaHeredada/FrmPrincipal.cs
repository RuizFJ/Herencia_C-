﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjVentaHeredada
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            FrmContado frmContado = new FrmContado();
            frmContado.ShowDialog();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            FrmCredito frmCredito = new FrmCredito();
            frmCredito.ShowDialog();
            //Dejando mensaje
        }
    }
}
