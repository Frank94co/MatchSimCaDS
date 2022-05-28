using MatchSimCaDSLibrary.Competencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchSimCaDSWindows
{
    public partial class MatchCupForm : Form
    {
        public MatchCupForm()
        {
            InitializeComponent();
        }

        private void btnCupResult_Click(object sender, EventArgs e)
        {

            bool haceFalta = cmbLocal.SelectedItem == null || cmbVisitante.SelectedItem == null;

            if (haceFalta)
            {
                MessageBox.Show("No están completos los datos de los rivales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ushort cmbResultLocal, cmbResultVisitante;

                ushort.TryParse(cmbLocal.SelectedItem.ToString(), out cmbResultLocal);
                ushort.TryParse(cmbVisitante.SelectedItem.ToString(), out cmbResultVisitante);
                bool neutral = chkNeutral.Checked;
                string resultado = Copa.Partido(neutral, cmbResultLocal, cmbResultVisitante);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
