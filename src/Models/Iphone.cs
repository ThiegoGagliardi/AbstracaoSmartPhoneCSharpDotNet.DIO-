using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstacaoSmartPhoneCSharpDotNet.DIO.src.Models
{
    public class Iphone :SmartPhone
    {
        public Iphone(int memoria, string modelo, string imei, string numero): base(memoria,modelo,imei,numero)
        {

        }

        public override void InstalarAplicativo(string aplicativo){
            Console.WriteLine($"Instalando {aplicativo} no {this.GetType().Name} {this.Modelo}.");
        }
        
    }
}