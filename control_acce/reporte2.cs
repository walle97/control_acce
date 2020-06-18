using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace control_acce
{
    public partial class reporte2 : Form
    {
        public List<datosreg> datosregs = new List<datosreg>();
        public reporte2()
        {
            InitializeComponent();
        }

        private void Reporte2_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datosregs));
            this.reportViewer1.RefreshReport();
        }
    }
}
