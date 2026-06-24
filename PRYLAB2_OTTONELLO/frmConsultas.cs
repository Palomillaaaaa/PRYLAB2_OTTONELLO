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
        }
    }
}
