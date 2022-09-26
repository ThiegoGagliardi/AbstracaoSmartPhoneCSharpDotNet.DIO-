using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstacaoSmartPhoneCSharpDotNet.DIO.src.Models
{
    public abstract class SmartPhone
    {
        protected  int Memoria { get; }

        protected string Modelo { get; }

        protected string Imei { get; }

        public string Numero {get; set;}

        public SmartPhone(int memoria, string modelo, string imei, string numero)
        {
            this.Memoria = memoria;
            this.Modelo  = modelo;
            this.Imei    = imei;
            this.Numero  = numero;
        }

        public void Ligar ()
        {
            Console.WriteLine($"{this.GetType().Name} ligado.");
        }

        public void ReceberLigacao ()
        {
            Console.WriteLine($"{this.GetType().Name} está recebendo uma ligação.");
        }

        public abstract void InstalarAplicativo (string aplicativo);
        
    }
}