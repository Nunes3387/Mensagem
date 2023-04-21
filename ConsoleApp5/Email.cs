using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Email : IMensagem
    {
        public void EnviarMensagem(string destinatario, string mensagem)
        {
            // Código para enviar e-mail
            Console.WriteLine($"Enviando e-mail para {destinatario}: {mensagem}");
        }
    }
}
