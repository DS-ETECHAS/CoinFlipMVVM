using CoinFlip.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip.ViewModels
{
    public partial class MoedaViewModel : ObservableObject
    {
        //Instalar o community toolkit
        //Anotar as propriedades como sendo Propriedades Observáveis
        //Fazer com que a classe "herde" ObservableObject e que seja uma classe Partial
        [ObservableProperty]
        private string resultado;
        [ObservableProperty]
        private string ladoSelecionado;
        [ObservableProperty]
        private string nome;
        [ObservableProperty]
        private string nomeImagem;

        public ICommand JogarCommand { get; }

        public MoedaViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            Moeda moeda = new Moeda();
            moeda.Sortear();
            NomeImagem = $"{moeda.Lado}.png";
            if (LadoSelecionado == moeda.Lado)
            {
                Resultado = $"Parabéns {Nome}! Você venceu!";
            }
            else
            {
                Resultado = $"Que pena,{Nome}. Você perdeu.";
            }
        }
    }
}
