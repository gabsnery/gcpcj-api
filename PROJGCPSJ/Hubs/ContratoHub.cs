using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.SignalR;


namespace PROJGCPSJ.Hubs
{
    public class ContratoHub : Hub
    {

        static int usuarios = 0;
        [EnableCors]
        public override Task OnConnectedAsync()
        {
            usuarios++;
            return base.OnConnectedAsync();
        }
        [EnableCors]
        public override Task OnDisconnectedAsync(Exception exception)
        {
            usuarios--;
            return base.OnDisconnectedAsync(exception);
        }
        [EnableCors]
        public async Task EnviarMensagem(string usuario, string msg)
        {
            await Clients.All.SendAsync("ReceberMensagem", usuario
                , "sadsadsads", "Contrato adicionado" + msg);

        }
    }
}
