using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Views;

namespace Controllers
{
    public class ClientController
    {
        public Client loadClient() => ClientView.InputCLient();
        public void ShowClient(Client c) => ClientView.ShowClient(c);
    }
}
