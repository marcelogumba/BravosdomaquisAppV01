using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class Inicio : UserControl
    {
        bool modoEscuro;
        public Inicio()
        {
            InitializeComponent();
            Dictionary<DateTime, int> GraficoInfo = new Dictionary<DateTime, int>();
            var r=new Random();
            for (int i = 0; i < 5; i++)
            {
                GraficoInfo.Add(DateTime.Now.AddDays(i).AddHours(r.Next(1,24)),r.Next(800) );
            }
            foreach (var i in GraficoInfo)
                gunaLineDataset1.DataPoints.Add(i.Key.ToString(), i.Value);
            lblNumAcessos.Text = GraficoInfo.Sum(x => x.Value).ToString("0 000");
           
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);
          
            panelSuperior.BaseColor = panelBase.BaseColor = Color.FromArgb(14, 18, 30);

            panelInfoBravo.BaseColor=panelGrafico.BaseColor=gGrafico.BackColor = Color.FromArgb(24, 28, 40);

            lblInfoBravos.ForeColor = 
            lblCTitulo.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);
           
            panelSuperior.BaseColor = panelBase.BaseColor = 
            panelInfoBravo.BaseColor= panelGrafico.BaseColor = gGrafico.BackColor = Color.Gainsboro;

            lblInfoBravos.ForeColor = 
            lblCTitulo.ForeColor = Color.FromArgb(27, 87, 165);

        }
        private void btnInfoClube_Click(object sender, EventArgs e)
        {
            ModalScreen formModal = new ModalScreen();
            formModal.Show();
            InfoClubes InfoClubes = new InfoClubes(formModal, modoEscuro, "");
            InfoClubes.Show();
        }

        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInfoBravos_Click(object sender, EventArgs e)
        {

        }
    }
}
