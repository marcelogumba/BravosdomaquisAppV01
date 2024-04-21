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
    public partial class ModalScreen : Form
    {
        private Form _chield { get; set; }
        private Form _parentForm { get; set; }
        public ModalScreen()
        {
            InitializeComponent();
        }
        public ModalScreen(Form parent, Form chield)
        {
            InitializeComponent();
            this._chield = chield;
            this._parentForm= parent;
            this.WindowState = FormWindowState.Normal;
            
            Point parentLoc=_parentForm.PointToScreen(Point.Empty);
            Size parentSize = _parentForm.ClientSize;

          
            this._chield.StartPosition = FormStartPosition.CenterParent;


            this.Size = parentSize;
            this.Location = parentLoc;
            this.Shown += FormBackgroudModal_Shown;
        }

        private void FormBackgroudModal_Shown(object sender, EventArgs e)
        {
            //this.BringToFront();
            this._chield.ShowDialog();
            this.Close();
            //this._chield.FormClosed += _chield_FormClosed;
         
        }

        private void _chield_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBackgroudModal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
