using BravosdomaquisApp.Config;
using BravosdomaquisApp.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class PreVeiwImagem : Form
    {
        string _path;
        bool darkmode;
        public PreVeiwImagem(string caminho, bool darkMode)
        {
            darkmode = darkMode;
             _path=caminho;
           
;           InitializeComponent();
            this.Load += PreVeiwImagem_Load;
           
        }
        public void darkMode()
        {
            panelInfoMembro.BaseColor = Color.FromArgb(5, 10, 26);
            
            pictureBox1.BackColor = Color.FromArgb(4, 8, 20);
            lblDescrTitulo.ForeColor = Color.Gainsboro;
        }

        private void PreVeiwImagem_Load(object sender, EventArgs e)
        {
            if (darkmode)
            {
                darkMode();
            }
            Visualizar();
        }

        private async void Visualizar()
        {
            try
            {
                var img = await ConversorFiles.ConverterParaImagem($"socio/{_path}");
                pictureBox1.Image = img;
            }
            catch (Exception ex)
            {

                this.ShowNotify(NotifyType.erro, ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
