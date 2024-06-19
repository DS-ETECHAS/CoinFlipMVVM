using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Moeda
    {
        //Encapsulamento "tradicional"
        //Botão direito no nome do atributo, clique na primeira opção e depois encapsulate field.
/*
        private string lado;
        public string Lado { get => lado; set => lado = value; }
*/

        //Criando uma propriedade
        //Utilize o atalho "prop" dê enter e depois troque o nome da propriedade SEMPRE começando com maiúsculo
        public string Lado { get; set; }

        public void Sortear()
        {
            Lado = new Random().Next(2).ToString();
            if (Lado == "0")
            {
                Lado = "cara";
            }
            else
            {
                Lado = "coroa";
            }
        }
    }
}
