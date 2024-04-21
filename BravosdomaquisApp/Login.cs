using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Maquis.Models.ModelView;
using BravosdomaquisApp.Config;
using Maquis.Models.Domain;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using BravosdomaquisApp.Properties;
using System.Net;
using System.Threading;

namespace BravosdomaquisApp
{
    public partial class Login : Form
    {
        bool ModoEscuro, Splash;
        int cont = 1, flag = 0, contg;
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public void showNotify(NotifyType tipo, string mensagem)
        {
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        public Login(bool modoescuro, bool splash)
        {
            ModoEscuro = modoescuro;

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));
            progress.Show();
            panelSplash.Dock = DockStyle.Fill;

            if (!splash)
            {
                panelSplash.Visible = false;
            }
            if (ModoEscuro)
            {
                btnCriarConta.BackColor = btnSair.BackColor = 
                this.BackColor = Color.FromArgb(10, 19, 48);
                txtUsername.BackColor = txtPassword.BackColor = BackColor = Color.FromArgb(10, 19, 48);
                panelLogin.BackColor = Color.FromArgb(10, 19, 48);
                label2.Text = "Desativar modo escuro:";
                pictureBox12.Image = Properties.Resources.darkmode;
                txtUsername.SetColor();
                txtPassword.SetColor();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBoxUI2__TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModoEscuro_CheckedChanged(object sender, EventArgs e)
        {
            if (btnModoEscuro.Checked == true)
            {
                this.BackColor = Color.FromArgb(10, 19, 48);
                txtUsername.BackColor = txtPassword.BackColor = BackColor = Color.FromArgb(10, 19, 48);
                panelLogin.BackColor = Color.FromArgb(10, 19, 48);
                label2.Text = "Desativar modo escuro:";
                pictureBox12.Image = Properties.Resources.darkmode;
                txtUsername.SetColor();
                txtPassword.SetColor();
            }
            else
            {
                this.BackColor = Color.FromArgb(225, 225, 225);
                txtUsername.BackColor = txtPassword.BackColor = BackColor = Color.FromArgb(225, 225, 225);
                panelLogin.BackColor = Color.FromArgb(225, 225, 225);
                label2.Text = "Ativar modo escuro:";
                pictureBox12.Image = Properties.Resources.lightmode;
                txtUsername.SetColor();
                txtPassword.SetColor();
            }
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            

            try
            {
                var model=new ModelLogin() { Email=txtUsername.Text.Trim(), Password=txtPassword.Text.Trim()};
                var login = await ServiceBase.service().GetAsync<Register>("Register/Login",model);
               
                if(login.StatusCode == HttpStatusCode.OK)
                {
                    if (login.Data != null)
                    {
                        Settings.Default.UserLogado = login.Data;
                        Settings.Default.IsAnyOne = true;
                        Settings.Default.Save();
                        var principal = new Principal(ModoEscuro);
                        this.Hide();
                        principal.Show();
                    }
                }
                
            }
            catch (HttpRequestException ex)
            {
                showNotify(NotifyType.aviso, "O Login não pode ser concluído, verifique as crendenciais.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
    
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void lblEsqueceuPasse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showNotify( NotifyType.aviso, "Indisponível");
            
        }

        private void btnCriarConta_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnCriarConta_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            ModalScreen formModal = new ModalScreen();
            formModal.Show();
            CriarConta CriarConta = new CriarConta(formModal, ModoEscuro);
            CriarConta.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contg++;
            if (contg > 20) lblinfoSplash.Text = "Preparando as funcionalidades!";
            if (contg > 70) lblinfoSplash.Text = "Esta quase pronto, aguarde...";
            if (contg > 90)
            {
                progress.Visible = false;
                lblinfoSplash.Text = "Tudo pronto, seja bem-vindo!";
            }
            if (contg > 100) panelSplash.Visible = false;

            if (flag == 0)
            {
                if(cont == 1) pictureBoxSplash.Image = Properties.Resources.splash1;
                if (cont == 2) pictureBoxSplash.Image = Properties.Resources.splash2;
                if (cont == 3) pictureBoxSplash.Image = Properties.Resources.splash3;
                if (cont == 4) pictureBoxSplash.Image = Properties.Resources.splash4;
                if (cont == 5) pictureBoxSplash.Image = Properties.Resources.splash5;
                if (cont == 6) pictureBoxSplash.Image = Properties.Resources.splash6;
                if (cont == 7) pictureBoxSplash.Image = Properties.Resources.splash7;
                if (cont == 8) pictureBoxSplash.Image = Properties.Resources.splash8;
                if (cont == 9) pictureBoxSplash.Image = Properties.Resources.splash9;
                if (cont == 10) pictureBoxSplash.Image = Properties.Resources.splash10;
                if (cont == 11) pictureBoxSplash.Image = Properties.Resources.splash11;
                if (cont == 12)
                {
                    pictureBoxSplash.Image = Properties.Resources.splash12;
                    flag = 1;
                }
                cont++;
            }
            else
            {
                if (cont == 1)
                {
                    pictureBoxSplash.Image = Properties.Resources.splash1;
                    flag = 0;
                }
                if (cont == 2) pictureBoxSplash.Image = Properties.Resources.splash2;
                if (cont == 3) pictureBoxSplash.Image = Properties.Resources.splash3;
                if (cont == 4) pictureBoxSplash.Image = Properties.Resources.splash4;
                if (cont == 5) pictureBoxSplash.Image = Properties.Resources.splash5;
                if (cont == 6) pictureBoxSplash.Image = Properties.Resources.splash6;
                if (cont == 7) pictureBoxSplash.Image = Properties.Resources.splash7;
                if (cont == 8) pictureBoxSplash.Image = Properties.Resources.splash8;
                if (cont == 9) pictureBoxSplash.Image = Properties.Resources.splash9;
                if (cont == 10) pictureBoxSplash.Image = Properties.Resources.splash10;
                if (cont == 11) pictureBoxSplash.Image = Properties.Resources.splash11;
                if (cont == 12) pictureBoxSplash.Image = Properties.Resources.splash12;
                cont--;
            }
        }
    }
}
