﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TechnologyIndustries
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ingresoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ingresoInventario = new IngresoInventarioForm();
            ingresoInventario.MdiParent = this;
            ingresoInventario.Show();
        }

        private void salidaDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salidaInventario = new SalidaInventarioForm();
            salidaInventario.MdiParent = this;
            salidaInventario.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventas = new VentasForm();
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteProductos = new ReporteProductosForm();
            reporteProductos.MdiParent = this;
            reporteProductos.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteClientes = new ReporteClientesForm();
            reporteClientes.MdiParent = this;
            reporteClientes.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteVentas = new ReporteVentasForm();
            reporteVentas.MdiParent = this;
            reporteVentas.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}