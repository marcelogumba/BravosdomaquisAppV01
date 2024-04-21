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
using Maquis.Models.Domain;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading;

namespace BravosdomaquisApp
{
    public partial class EquipaTecnica : UserControl
    {
        bool modoEscuro;
        public EquipaTecnica()
        {
            InitializeComponent();

        }

        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            //panelViewAllContacto.BaseColor = Color.FromArgb(14, 18, 30);

            lblEquipaTecnica.ForeColor =
            lblListaTecnicos.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor  = Color.Gainsboro;

           // panelViewAllContacto.BaseColor = Color.Gainsboro;

            lblEquipaTecnica.ForeColor =
            lblListaTecnicos.ForeColor = Color.FromArgb(27, 87, 165);
        }
        public void showNotify(NotifyType tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        private void DataGridViewListaTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DataGridViewListaTecnicos.CurrentRow.Cells[0].Value.ToString();
            string nomeCompleto = DataGridViewListaTecnicos.CurrentRow.Cells[1].Value.ToString();
            string Funcao = DataGridViewListaTecnicos.CurrentRow.Cells[2].Value.ToString();
            string DataIngresso = DataGridViewListaTecnicos.CurrentRow.Cells[3].Value.ToString();
            string Nacionlidade = DataGridViewListaTecnicos.CurrentRow.Cells[4].Value.ToString();
            string Redes = DataGridViewListaTecnicos.CurrentRow.Cells[5].Value.ToString();

            ModalScreen formModal = new ModalScreen();
            formModal.Show();
            if (modoEscuro)
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, true, false);
                infoTecnicos.ShowDialog();
            }
            else
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, false, false);
                infoTecnicos.ShowDialog();
            }
        }

        private void btnAddTecnico_Click(object sender, EventArgs e)
        {
            ModalScreen formModal = new ModalScreen();
            formModal.Show();
            if (modoEscuro)
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, true, true);
                infoTecnicos.ShowDialog();
            }
            else
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, false, true);
                infoTecnicos.ShowDialog();
            }
        }

        private async void EquipaTecnica_Load(object sender, EventArgs e)
        {
            TelaProgress tl = new TelaProgress(true);
            Thread progressThread = new Thread(() => Application.Run(tl));
            progressThread.Start();

            try
            {
                var result = await ServiceBase.service().GetAsync<Collection<EquipaTecnica>>("EquipeTecnica");
                if (result.Data != null)
                {
                    DataGridViewListaTecnicos.DataSource = result;
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

        private  void btnAtualizar_MouseLeave(object sender, EventArgs e)
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
                var result = await ServiceBase.service().GetAsync<Collection<EquipaTecnica>>("EquipeTecnica");
                if (result.Data != null)
                {
                    DataGridViewListaTecnicos.DataSource = result;
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
