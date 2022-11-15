using Hai.UI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Hai.UI.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration c)
        {
            c.MessageHandlers.Add(new APIKeyHandler());
        }
    }
}
