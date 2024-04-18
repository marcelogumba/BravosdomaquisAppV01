using BravosdomaquisApp.Config;
using Maquis.Models.Domain;
using Maquis.Models.ModelView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class Newslatter : Form
    {
        Form form;
        bool darkmode;
        public Newslatter(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();
            
            darkmode = darkMode;
            if (darkmode)
            {
                panelNewslatter.BackColor = Color.FromArgb(5, 10, 26);
                lblNewsLatter.ForeColor = Color.Gainsboro;
            }
        }
        public void showNotify(NotifyType tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void DataGridViewInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridViewInscritos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                showNotify(NotifyType.sucesso, "Eliminado");
                int num; 
                int.TryParse(lblNumInscritos.Text, out num);
                num = num - 1;
                lblNumInscritos.Text = num.ToString();
            }
        }

        private async void Newslatter_Load(object sender, EventArgs e)
        {
            TelaProgress tl = new TelaProgress(darkmode);
            Thread progressThread = new Thread(() => tl.ShowDialog());
            progressThread.Start();

            try
            { 
                var result = await ServiceBase.service().GetAsync<Collection<Maquis.Models.Domain.Newslatter>>("Newslatter");

                if (result.Data != null)
                {
                    newslatterBindingSource.DataSource = result.Data;
                    lblNumInscritos.Text = result.Data.Count.ToString();
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
