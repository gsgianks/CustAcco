using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB_CustAcco.Web_Common.GeneralAppService;

namespace WB_CustAcco.Web_Common.ClientServices
{
    public class GeneralAppClientService
    {
        public static GeneralAppServiceClient GetServiceClient()
        {
            GeneralAppServiceClient cliente = new GeneralAppServiceClient();

            return cliente;
        }

        public static void CloseServiceClient(GeneralAppServiceClient cliente)
        {
            if (cliente != null)
            {
                if (cliente.State == System.ServiceModel.CommunicationState.Opened)
                {
                    cliente.Close();
                }
            }
        }
    }
}
