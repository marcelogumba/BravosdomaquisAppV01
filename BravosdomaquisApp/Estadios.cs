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
using System.Net;
using System.Net.Http;
using System.Threading;

namespace BravosdomaquisApp
{
    public partial class Estadios : UserControl
    {
        bool modoEscuro;
        public Estadios()
        {
            InitializeComponent();
        }
        public void darkMode()
        {
            modoEscuro = true;

            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            lblTitulo.ForeColor = lblVerListaEstadios.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.Gainsboro;

            lblTitulo.ForeColor = lblVerListaEstadios.ForeColor = Color.FromArgb(27, 87, 165);
        }

        private void DataGridViewListaEstadios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewListaEstadios.Columns[e.ColumnIndex].Name == "Detalhes")
            {

                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();

                if (modoEscuro)
                {
                    InfoEstadios infoEstadio = new InfoEstadios(formModal, true, false);
                    infoEstadio.Show();
                }
                else
                {
                    InfoEstadios infoEstadio = new InfoEstadios(formModal, false, false);
                    infoEstadio.Show();
                }

            }
        }

        private async void Estadios_Load(object sender, EventArgs e)
        {
            TelaProgress tl = new TelaProgress(true);
            Thread progressThread = new Thread(() => Application.Run(tl));
            progressThread.Start();

            try
            {
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Estadio>>("Estadio");

                if (result.Data != null)
                {
                    DataGridViewListaEstadios.DataSource = result.Data;
                    lblNumAdicionados.Text = result.Data.Count.ToString();
                }
                tl.Invoke((Action)delegate { tl.Close(); });
            }
            catch (HttpRequestException ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                MessageBox.Show(ex.Message, "ERRO DE LIGAÇÃO");
            }
            catch (Exception ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                MessageBox.Show(ex.Message, "ERRO DO SISTEMA");
            }
        }

        private void btnAddEstadios_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            InfoEstadios estadio = new InfoEstadios(formModal, modoEscuro, true);
            estadio.Show();
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
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Estadio>>("Estadio");

                if (result.Data != null)
                {
                    DataGridViewListaEstadios.DataSource = result.Data;
                    lblNumAdicionados.Text = result.Data.Count.ToString();
                }
                tl.Invoke((Action)delegate { tl.Close(); });
            }
            catch (HttpRequestException ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                MessageBox.Show(ex.Message, "ERRO DE LIGAÇÃO");
            }
            catch (Exception ex)
            {
                tl.Invoke((Action)delegate { tl.Close(); });
                MessageBox.Show(ex.Message, "ERRO DO SISTEMA");
            }
        }
    }
}
