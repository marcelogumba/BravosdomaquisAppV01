using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BravosdomaquisApp
{
    public partial class TelaProgress : Form
    {
        public TelaProgress(bool darkMode)
        {
            InitializeComponent();
            progressCircle.Show();
            if (darkMode)
            {
                this.BackColor = Color.FromArgb(14, 18, 30);
                progressCircle.ProgressColor = Color.Gainsboro;
            }
        }
        public void UpdateProgress()
        {
            
        }
    }
}
