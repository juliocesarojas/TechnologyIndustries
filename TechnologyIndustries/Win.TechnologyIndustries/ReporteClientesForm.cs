﻿using BL.Technology;
using System;
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
    public partial class ReporteClientesForm : Form
    {
        public ReporteClientesForm()
        {
            InitializeComponent();

            var _clientesBL = new ClientesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _clientesBL.ObtenerClientes();

            var reporte = new ReporteClientes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
