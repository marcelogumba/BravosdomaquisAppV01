using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BravosdomaquisApp.Config;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading;
using iTextSharp.text;
using System.Collections;
using Maquis.Models.Domain;

namespace BravosdomaquisApp
{
    public partial class Parceiro : UserControl
    {
        bool modoEscuro;
        int idParceieroSelect;
        public Parceiro()
        {
            
            InitializeComponent();
            panelParceiros.Visible = true;
            panelParceiros.Dock = DockStyle.Fill;

            paneNossosParceiros.Visible = false;
            paneNossosParceiros.Dock = DockStyle.None;


            //sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "1", Nome = "Margareth de Souza", Descricao = "Parceira 100%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
            //sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "2", Nome = "Andre de Almeida", Descricao = "Parceira 80%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
            //sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "3", Nome = "Souza Diogo", Descricao = "Parceira 10%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
            //sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "4", Nome = "Armando Vieira", Descricao = "Parceira 50%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            paneNossosParceiros.BaseColor =
            panelParceiros.BaseColor = Color.FromArgb(4, 8, 20);

            panelNParceiros.BaseColor = Color.FromArgb(14, 18, 30);

            lblNParceiros.ForeColor =
            lblParceiros.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            paneNossosParceiros.BaseColor = panelNParceiros.BaseColor =
            panelParceiros.BaseColor = Color.Gainsboro;

            lblNParceiros.ForeColor =
            lblParceiros.ForeColor = Color.FromArgb(27, 87, 165);
        }
        public void showNotify(NotifyType tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        private async void btnVerParceiros_Click(object sender, EventArgs e)
        {
            
            panelParceiros.Visible = false;
            panelParceiros.Dock = DockStyle.None;

            paneNossosParceiros.Visible = true;
            paneNossosParceiros.Dock = DockStyle.Fill;

            getParceiros();

        }
        public async void getParceiros()
        {
            TelaProgress tl = new TelaProgress(true);
            Thread progressThread = new Thread(() => Application.Run(tl));
            progressThread.Start();

            try
            {
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Parceiro>>("Parceiro");
                
                if (result != null)
                {
                    parceiroBindingSource.DataSource = result.Data; 
                }
                tl.Invoke((Action)delegate { tl.Close(); });
            }
            catch (HttpRequestException ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                showNotify(NotifyType.erro, "OCORREU ALGUM ERRO DE LIGAÇÃO: \n"+ex.Message);
            }
            catch (Exception ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                showNotify(NotifyType.erro, "OCORREU ALGUM ERRO DO SISTEMA: \n" + ex.Message);
            }

        }
        private void btnVerParceirosInscritos_Click(object sender, EventArgs e)
        {
            ModalScreen formModal = new ModalScreen();
            formModal.Show();
            AddParceiro addParceiro = new AddParceiro(formModal, modoEscuro, true, null);
            addParceiro.Show();
            
        }
  
        private void btnVoltar_Click(object sender, EventArgs e)
        {

            panelParceiros.Visible = true;
            panelParceiros.Dock = DockStyle.Fill;

            paneNossosParceiros.Visible = false;
            paneNossosParceiros.Dock = DockStyle.None;
        }

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            lblVoltar.Visible = true;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.Visible = false;
        }

        private void DataGridViewNossosParceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewNossosParceiros.Columns[e.ColumnIndex].Name == "Detalhes")
            {
                var data = (DataGridViewNossosParceiros.CurrentRow.DataBoundItem as Maquis.Models.Domain.Parceiro);

                string id = $"{data.Id}";
                string nomeParceiro = $"{data.NomeParceiro}";
                string descricao = $"{data.Descricao}";
                string tipo = $"{data.Tipo}";
                string descricaoTipo = $"{data.DescricaoTipo}";
                string redesSociais = $"{data.Site.LinkFacebook}";
                string imagem = data.Imagem.Caminho;

                object[] dadosParceiro = new object[] { id, nomeParceiro, descricao, tipo, descricaoTipo, redesSociais, imagem };


                ModalScreen formModal = new ModalScreen();
                formModal.Show();
                AddParceiro addParceiro = new AddParceiro(formModal, modoEscuro, false, dadosParceiro);
                addParceiro.Show();

                //MessageBox.Show(DataGridViewNossosParceiros.CurrentRow.Cells[6].Value.ToString());

                //txtInfoTipoParceiro.Text = DataGridViewNossosParceiros.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void Parceiro_Load(object sender, EventArgs e)
        {

        }

        private void paneNossosParceiros_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
