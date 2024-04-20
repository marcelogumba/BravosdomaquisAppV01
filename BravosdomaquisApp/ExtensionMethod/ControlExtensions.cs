using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp.ExtensionMethod
{
    public static class ControlExtensions
    {
        public static void ShowDialogThreadSafe(this Control control, Form dialog)
        {
            if (control.InvokeRequired)
            {
                control.Invoke((Action)(() => { dialog.TopMost = true; dialog.Show(control); }));
            }
            else
            {
                dialog.TopMost = true;
                dialog.Show(control);
            }
        }

        public static void ShowNotify(this Control control, NotifyType tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
    }
}
