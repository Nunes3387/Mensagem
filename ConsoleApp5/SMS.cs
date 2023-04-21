using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class SMS : IMensagem
    {
        public void EnviarMensagem(string destinatario, string mensagem)
        {
            // Código para enviar SMS
            Console.WriteLine($"Enviando SMS para {destinatario}: {mensagem}");
        }
    }
}
