using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMensagem email = new Email();
            email.EnviarMensagem("fulano@gmail.com", "Olá, Fulano!");

            IMensagem sms = new SMS();
            sms.EnviarMensagem("999999999", "Olá, tudo bem?");

            Console.ReadKey();

        }
    }
}
