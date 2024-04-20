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
using BravosdomaquisApp.ExtensionMethod;
using Microsoft.AspNetCore.Http;

namespace BravosdomaquisApp
{
    public partial class Socios : UserControl
    {
        bool modoEscuro;
        public Socios()
        {
            InitializeComponent();

        

            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;

            panelAprovReproNotify.Width = 919; ;
        }

       

        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelVerSociosExistentes.BaseColor = panelVerSociosInscritos.BaseColor =
            panelSocios.BaseColor = Color.FromArgb(4, 8, 20);

            panelSociosInscritos.BaseColor =
            panelSociosExistentes.BaseColor = Color.FromArgb(14, 18, 30);

            txtMensagemMotivacao.FocusedBaseColor =
            btnVerAnexo1.BaseColor = btnVerAnexo2.BaseColor = txtMensagemMotivacao.BaseColor = 
            panelAprovReproNotify.BaseColor = Color.FromArgb(24, 28, 40);

            txtNomeSocioInscri.ForeColor = txtAnexo1.ForeColor =
            txtAnexo2.ForeColor = txtEmailSocioInscri.ForeColor =
            txtTelefoneSocioInscri.ForeColor = txtTipoSocio.ForeColor =

            lblTipoSocio.ForeColor =
            lblNome.ForeColor = lblAnexo1.ForeColor = lblAnexo2.ForeColor =
            lblTelefone.ForeColor = lblemail.ForeColor =

            lblFecharMensagemMot.ForeColor =
            lblDetalhesInscri.ForeColor = lblSMSMotivacao.ForeColor = 
            lblSociosexis.ForeColor = lblSocIncri.ForeColor =
            lblSocios.ForeColor = lblDesciSocios.ForeColor 
            = Color.Gainsboro;
        }

        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            btnVerAnexo1.BaseColor = btnVerAnexo2.BaseColor =
            panelVerSociosExistentes.BaseColor = panelVerSociosInscritos.BaseColor =
            panelSocios.BaseColor = 

            panelSociosInscritos.BaseColor =
            panelSociosExistentes.BaseColor =

            txtMensagemMotivacao.BaseColor = txtMensagemMotivacao.FocusedBaseColor =
            panelAprovReproNotify.BaseColor = Color.Gainsboro;


            txtNomeSocioInscri.ForeColor = txtAnexo1.ForeColor =
            txtAnexo2.ForeColor = txtEmailSocioInscri.ForeColor =
            txtTelefoneSocioInscri.ForeColor = txtTipoSocio.ForeColor =

            lblTipoSocio.ForeColor =
            lblNome.ForeColor = lblAnexo1.ForeColor = lblAnexo2.ForeColor =
            lblTelefone.ForeColor = lblemail.ForeColor = 

            lblFecharMensagemMot.ForeColor =
            lblDetalhesInscri.ForeColor = lblSMSMotivacao.ForeColor =
            lblSociosexis.ForeColor = lblSocIncri.ForeColor =
            lblSocios.ForeColor = lblDesciSocios.ForeColor
            = Color.FromArgb(27, 87, 165);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalhesInscricaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSociosInscritos.Visible = false;
            panelAprovReproNotify.Visible = true;
        }

        private void lblBtnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblVoltarr_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnVoltarr_MouseHover(object sender, EventArgs e)
        {
            lblVoltarr.Visible = true;
        }

        private void btnVoltarr_MouseLeave(object sender, EventArgs e)
        {
            lblVoltarr.Visible = false;
        }

        private void btnVoltarr_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;
            
            panelAprovReproNotify.Visible = false;
            DataGridViewSociosInscritos.Visible = true;
        }

        private async void btnVerSociosInscritos_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = true;
            panelVerSociosInscritos.Dock = DockStyle.Fill;

            panelSocios.Visible = false;
            panelSocios.Dock = DockStyle.None;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;
            await getSocios();
        }

        private void DataGridViewPontuacoes_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void DataGridViewSociosInscritos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int linhaEmCausa = DataGridViewSociosInscritos.HitTest(e.X, e.Y).RowIndex;
                if (linhaEmCausa >= 0)
                {
                    contextMenuDataGrid.Show(DataGridViewSociosInscritos, new Point(e.X, e.Y));
                }
            }
        }

        private void btnCancelarr_MouseHover(object sender, EventArgs e)
        {
            lblCancelarr.Visible = true;
        }

        private void btnCancelarr_MouseLeave(object sender, EventArgs e)
        {
            lblCancelarr.Visible = false;
        }

        private void btnCancelarr_Click(object sender, EventArgs e)
        {
            DataGridViewSociosInscritos.Visible = true;
            panelAprovReproNotify.Visible = false;
        }

        private void btnVoltarSocios_MouseHover(object sender, EventArgs e)
        {
            lblVoltarSoc.Visible = true;
        }

        private void btnVoltarSocios_MouseLeave(object sender, EventArgs e)
        {
            lblVoltarSoc.Visible = false;
        }

        private void btnVoltarSocios_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;
        }

        private async void btnVerSocios_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = false;
            panelSocios.Dock = DockStyle.None;

            panelVerSociosExistentes.Visible = true;
            panelVerSociosExistentes.Dock = DockStyle.Fill;

            await getSocios();
        }

        public async Task getSocios()
        {
            // Criação e exibição da tela de progresso em uma nova thread
            TelaProgress telaProgress = new TelaProgress(true);
            //telaProgress.TopMost = true;
            //Thread progressThread = new Thread(() => Application.Run(telaProgress));
            //progressThread.Start();


            try
            {
                this.ShowDialogThreadSafe(telaProgress);
                // Solicitação assíncrona para obter dados
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Socio>>("Socio");
                var result1 = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Socio>>("Socio/Activos");

                // Verifica se a resposta não é nula e atualiza a fonte de dados
                if (result != null && result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if(result.Data != null)
                        socioBindingSource.DataSource = result.Data;
                }
                if (result1 != null && result1.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (result.Data != null)
                        bindingSource1.DataSource = result1.Data;
                }
            }
            catch (HttpRequestException ex)
            {
                // Captura e trata exceções de HTTP
                this.ShowNotify(NotifyType.erro, "OCORREU ALGUM ERRO DE LIGAÇÃO: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                // Captura e trata outras exceções
                this.ShowNotify(NotifyType.erro, "OCORREU ALGUM ERRO DO SISTEMA: \n" + ex.Message);
            }
            finally
            {
                // Fecha a tela de progresso, independentemente do resultado
                if (telaProgress != null && !telaProgress.IsDisposed)
                {
                    telaProgress.Invoke((Action)telaProgress.Close);
                }
            }

        }



        private void btnAprovar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                ModalSMS sms = new ModalSMS(formModal, true);
                sms.Show();
            }
            else
            {
                ModalSMS sms = new ModalSMS(formModal, false);
                sms.Show();
            }
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.ShowNotify(NotifyType.sucesso, "Mensagem enviada");
        }

        private async void Socios_Load(object sender, EventArgs e)
        {
            //await getSocios();
        }

        private void Socios_VisibleChanged(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;

            lblInfoListaSociosInscri.Visible = lblSocIncri.Visible =
            DataGridViewSociosInscritos.Visible = true;
            panelAprovReproNotify.Visible = false;
        }

        private void DataGridViewSociosInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridViewSociosInscritos.Columns[e.ColumnIndex].Name == "ViewDetail")
            {
                panelAprovReproNotify.Visible = true;
                lblInfoListaSociosInscri.Visible = lblSocIncri.Visible = true;

                var data = (DataGridViewSociosInscritos.CurrentRow.DataBoundItem as Socio);
                txtTipoSocio.Text = $"{data.Classe.Nome_Classe}"; 
                txtNomeSocioInscri.Text = $"{data.Nome} {data.Sobrenome}";
                txtTelefoneSocioInscri.Text = $"{data.Contactos.Principal}";
                txtEmailSocioInscri.Text = $"{data.Contactos.Email}";
                lbBilhete.Text = $"{data.Documento.NumeroDocumento}";
                txtAnexo1.Text = data.Foto.Caminho;
                txtAnexo2.Text = data.Documento.Caminho;
            }
        }

        private async void gunaButton1_Click(object sender, EventArgs e)
        {

            try
            {
                //showNotify(NotifyType.informacao, "Sem nenhum documento!");
                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                var img = await ConversorFiles.ConverterParaImagem("socio/" + txtAnexo1.Text);
                PreVeiwImagem contato = new PreVeiwImagem(formModal, modoEscuro,img );
                contato.ShowDialog();
            }
            catch (Exception ex)
            {

                this.ShowNotify(NotifyType.erro, ex.Message);
            }
        }

        private void btnVerAnexo2_Click(object sender, EventArgs e)
        {
            this.ShowNotify(NotifyType.informacao, "Sem nenhum documento!");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBoxImagSocio.Visible = true;
           txtMensagemMotivacao.Visible = lblFecharMensagemMot.Visible =
           lblDaTxtSMSMotivcacao.Visible = false;
           
        }

        private void lbLinkSMSMotivacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxImagSocio.Visible = false;
            txtMensagemMotivacao.Visible = lblFecharMensagemMot.Visible =
             lblDaTxtSMSMotivcacao.Visible = true;
        }

        private void panelVerSociosInscritos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSociosInscritos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 