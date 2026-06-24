using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PRYLAB2_OTTONELLO
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        clsArchivo objRubro = new clsArchivo();
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            clsArchivo AD = new clsArchivo();
            AD.CargarCombo(cmbRubro);
            btnExportar.Enabled = false;
            btnMostrar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void cmbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRubro.Text != "")
            {
                btnMostrar.Enabled = true;
                btnExportar.Enabled = true;
                btnImprimir.Enabled = true;
            }
            else
            {
                btnMostrar.Enabled = false;
                btnExportar.Enabled = false;
                btnImprimir.Enabled = false;
            }

        }

        private void lnkDatos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Analista de Sistemas" +
               "\n Laboratorio de Programación " +
               "\n 2º Instancia Evaluativa " +
               "\n RECUPERATORIO " +
               "\n 43.881.903 – OTTONELLO PALOMA", ("Informacion"),
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedIndex != -1)
            {
                Int32 RubroSel = cmbRubro.SelectedIndex + 1;
                objRubro.RecorrerGrilla(dgvDatos, RubroSel);
                objRubro.CantidadArticulos(lblCantidad, RubroSel);
                objRubro.TotalGeneral(lblTotal, RubroSel);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rubro", "Seleccione Rubro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Int32 idRubroSel = cmbRubro.SelectedIndex + 1;
            string nombreRubro = cmbRubro.Text;
            objRubro.Imprimir(e, idRubroSel, nombreRubro);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedIndex != -1)
            {
                SaveFileDialog objCuadro = new SaveFileDialog();
                objCuadro.Title = "Seleccione carpeta y Guardar Reporte";
                objCuadro.FileName = "Reporte";
                objCuadro.RestoreDirectory = true;
                objCuadro.Filter = "Archivo separado por coma (*.csv)|*.csv|Archivo de Texto(*.txt)|*.txt";

                if (objCuadro.ShowDialog() == DialogResult.OK)
                {
                    Int32 idRubroSel = cmbRubro.SelectedIndex + 1;
                    objRubro.ExportarDatos(idRubroSel, objCuadro.FileName);
                    MessageBox.Show("Reporte generado con éxito", "Exportado con Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rubro", "Seleccione Rubro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedIndex != -1)
            {
                prtVentana.ShowDialog();
                prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
                prtDocumento.Print();
                MessageBox.Show("Reporte Impreso Correctamente");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rubro", "Seleccione Rubro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
