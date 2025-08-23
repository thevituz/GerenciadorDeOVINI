using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVINI
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            // Adicionar os Planetas no ComboBox
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Verificar se o número de tripulantes está vazio:
            if (txbtripulantes.Text == "")
            {
                MessageBox.Show("informe o Máximo de tripulantes!",
                "Errro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAbduzidos.Text =="")
            {
                MessageBox.Show("informe a Capacidade de Abduzidos!",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbPlanetas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o planeta de origem!",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
               //Variaveis para receber os valores dos txbs
               int maxtripulantes =  int.Parse(txbtripulantes.Text);
               int maxAbiduzidos =  int.Parse(txbAbduzidos.Text);
                string planetaOrigem = cmbPlanetas.Text;

                // instanciar o OVNI
                BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxtripulantes, maxAbiduzidos, planetaOrigem);



            
            }
        }
    }
}
