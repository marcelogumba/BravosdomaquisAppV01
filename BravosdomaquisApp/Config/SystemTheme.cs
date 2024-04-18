using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravosdomaquisApp.Config
{
    public class SystemTheme
    {
        public static bool GetWindowsDarkTheme()
        {
            const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string valueName = "AppsUseLightTheme";

            int registryValue = (int)Registry.GetValue(keyName, valueName, 1);

            return registryValue == 1 ? false : true;
        }
    }
}
