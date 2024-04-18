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
    public partial class Clubes : UserControl
    {
        bool modoEscuro;
        public Clubes()
        {
            InitializeComponent();

        }
        public void darkMode()
        {
            modoEscuro = true;

            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            lblTitulo.ForeColor = lblVerListaClube.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.Gainsboro;

            lblTitulo.ForeColor = lblVerListaClube.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void DataGridViewListaClubes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
        public void showNotify(NotifyType tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        private void DataGridViewListaClubes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewListaClubes.Columns[e.ColumnIndex].Name == "Detalhes")
            {
                string id = DataGridViewListaClubes.CurrentRow.Cells[0].Value.ToString();
                string nomeClube = DataGridViewListaClubes.CurrentRow.Cells[1].Value.ToString();
                string sigla = DataGridViewListaClubes.CurrentRow.Cells[2].Value.ToString();
              //  string historia = DataGridViewListaClubes.CurrentRow.Cells[3].Value.ToString();
                string redes = DataGridViewListaClubes.CurrentRow.Cells[4].Value.ToString();

                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                if (modoEscuro)
                {
                    infoClube infoClube = new infoClube(formModal, true, false, id, nomeClube, sigla, "", "", redes);
                    infoClube.Show();
                }
                else
                {
                    infoClube infoClube = new infoClube(formModal, false, false, id, nomeClube, sigla, "", "", redes);
                    infoClube.Show();
                }
            }
        }

        private void btnAddClubes_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                infoClube infoClube = new infoClube(formModal, true, true);
                infoClube.Show();
            }
            else
            {
                infoClube infoClube = new infoClube(formModal, false, true);
                infoClube.Show();
            }
        }

        private async void Clubes_Load(object sender, EventArgs e)
        {
            TelaProgress tl = new TelaProgress(true);
            Thread progressThread = new Thread(() => Application.Run(tl));
            progressThread.Start();

            try
            {
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Clubes>>("Clube");

                if (result.Data != null)
                {
                    DataGridViewListaClubes.DataSource = result.Data;
                    lblNumAdicionados.Text = result.Data.Count().ToString();
                }
                tl.Invoke((Action)delegate { tl.Close(); });
            }
            catch (HttpRequestException ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                showNotify(NotifyType.erro, "OCORREU ALGUM ERRO DE LIGAÇÃO: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                showNotify(NotifyType.erro, "OCORREU ALGUM ERRO DO SISTEMA: \n" + ex.Message);
            }
        }

        private void btnAtualizar_MouseHover(object sender, EventArgs e)
        {
            lblAtualizar.Visible = true;
        }

        private void btnAtualizar_MouseLeave(object sender, EventArgs e)
        {
            lblAtualizar.Visible = false;

        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            TelaProgress tl = new TelaProgress(true);
            Thread progressThread = new Thread(() => Application.Run(tl));
            progressThread.Start();

            try
            {
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Clubes>>("Clube");

                if (result.Data != null)
                {
                    DataGridViewListaClubes.DataSource = result.Data;
                    lblNumAdicionados.Text = result.Data.Count().ToString();
                }
                tl.Invoke((Action)delegate { tl.Close(); });
            }
            catch (HttpRequestException ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                showNotify(NotifyType.erro, "OCORREU ALGUM ERRO DE LIGAÇÃO: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                showNotify(NotifyType.erro, "OCORREU ALGUM ERRO DO SISTEMA: \n" + ex.Message);
            }
        }
    }
}
