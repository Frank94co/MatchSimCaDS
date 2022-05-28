using MatchSimCaDSLibrary;
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
    public partial class MatchStandardForm : Form
    {
        public MatchStandardForm()
        {
            InitializeComponent();
        }

        private void btnStdResult_Click(object sender, EventArgs e)
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

                string _out = Liga.Partido(cmbResultLocal, cmbResultVisitante);
                string resultado = $"El resultado es {_out}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
