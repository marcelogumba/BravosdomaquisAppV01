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

namespace BravosdomaquisApp
{
    public partial class MembrosDaDirecao : UserControl
    {
        bool modoEscuro;
        public MembrosDaDirecao()
        {
            InitializeComponent();

            panelMembros.Visible = true;
            panelMembros.Dock = DockStyle.Fill;

            paneNossosMembros.Visible = false;
            paneNossosMembros.Dock = DockStyle.None;

            sourceMembrosBindingSource.Add(new sourceMembros() { ID = "1", Nome = "Margareth de Souza", Cargo = "CEO", DataPosse = "2019-02-19", RedesSociais = "Por colocar", Imagem = "por colocar" });
            sourceMembrosBindingSource.Add(new sourceMembros() { ID = "2", Nome = "Andre de Almeida", Cargo = "Director do Clube", DataPosse = "2019-02-09", RedesSociais = "Por colocar", Imagem = "por colocar" });
            sourceMembrosBindingSource.Add(new sourceMembros() { ID = "3", Nome = "Souza Diogo", Cargo = "Financeiro", DataPosse = "2019-12-19", RedesSociais = "Por colocar", Imagem = "por colocar" });
            sourceMembrosBindingSource.Add(new sourceMembros() { ID = "4", Nome = "Armando Vieira", Cargo = "Director Adjunto", DataPosse = "2009-08-10", RedesSociais = "Por colocar", Imagem = "por colocar" });
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            paneNossosMembros.BaseColor = 
            panelMembros.BaseColor = Color.FromArgb(4, 8, 20);

            panelMdDireccao.BaseColor = Color.FromArgb(14, 18, 30);

            lblMdDirecao.ForeColor  =
            lblMembros.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelMdDireccao.BaseColor =
            paneNossosMembros.BaseColor =
            panelMembros.BaseColor = Color.Gainsboro;

            lblMdDirecao.ForeColor =
            lblMembros.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            lblVoltar.Visible = true;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelMembros.Visible = true;
            panelMembros.Dock = DockStyle.Fill;

            paneNossosMembros.Visible = false;
            paneNossosMembros.Dock = DockStyle.None;
        }

        private void DataGridViewNossosMembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridViewNossosMembros.Columns[e.ColumnIndex].Name == "Detalhes")
            {
                
                ModalScreen formModal = new ModalScreen();
                formModal.Show();
                if (modoEscuro)
                {
                    InfoMembro infomembros = new InfoMembro(formModal, true, false);
                    infomembros.Show();
                }
                else
                {
                    InfoMembro infomembros = new InfoMembro(formModal, false, false);
                    infomembros.Show();
                }
                
                //txtInfoNomeParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[1].Value.ToString();
                //txtInfoTipoParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private async void btnVerMembros_Click(object sender, EventArgs e)
        {
            paneNossosMembros.Visible = true;
            paneNossosMembros.Dock = DockStyle.Fill;

            panelMembros.Visible = false;
            panelMembros.Dock = DockStyle.None;

            getMembros();
        }

        public async void getMembros()
        {
            TelaProgress tl = new TelaProgress(true);
            Thread progressThread = new Thread(() => Application.Run(tl));
            progressThread.Start();

            try
            {
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.MembrosDireccao>>("MembrosDireccao");

                if (result != null)
                {
                    DataGridViewNossosMembros.DataSource = result;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "HTTP ERRO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO SISTEMA");
            }

            tl.Invoke((Action)delegate { tl.Close(); });
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ModalScreen formModal = new ModalScreen();
            formModal.Show();
            if (modoEscuro)
            {
                InfoMembro infomembros = new InfoMembro(formModal, true, true);
                infomembros.Show();
            }
            else
            {
                InfoMembro infomembros = new InfoMembro(formModal, false, true);
                infomembros.Show();
            }
        }
    }
}
