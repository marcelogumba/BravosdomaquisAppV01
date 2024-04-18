using Maquis.Models.APIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravosdomaquisApp.Config
{
    public static class ServiceBase
    {
        public static ConsumerService service()
        {
            return new ConsumerService(Properties.Settings.Default.ApiBase);
        }
    }
}
