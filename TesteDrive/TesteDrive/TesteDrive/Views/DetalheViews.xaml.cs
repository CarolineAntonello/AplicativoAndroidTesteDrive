using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheViews : ContentPage
    {
        private const int Freio_ABS = 800;
        private const int Ar_Condicionado = 1000;
        private const int MP3_Player = 500;

        public Veiculo Veiculo { get; set; }

        public string TextFreioABS { get { return string.Format("Freio ABS - R$ {0}", Freio_ABS); } }
        public string TextArCondicionado { get { return string.Format("Ar Condicionado - R$ {0}", Ar_Condicionado); } }
        public string TextMP3Player { get { return string.Format("MP3 Player - R$ {0}", MP3_Player); } }
        bool temFreioABS;
        public bool TemFreioABS
        {
            get
            {
                return temFreioABS;
            }
            set
            {
                temFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));

                //if (temFreioABS)
                //    DisplayAlert("Tem Freio ABS", "Ligado!", "OK");
                //else
                //    DisplayAlert("Freio ABS", "Desligado!", "OK");
            }
        }

        bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temMP3Player;
        public bool TemMP3Player
        {
            get
            {
                return temMP3Player;
            }
            set
            {
                temMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", 
                    Veiculo.Preco 
                    + (TemFreioABS ? Freio_ABS : 0)
                    + (TemArCondicionado ? Ar_Condicionado : 0)
                    + +(TemMP3Player ? MP3_Player : 0)
                    ); //se tem freio ABS retorna freio ABS se não retorna 0 
            }
        }


        public DetalheViews(Veiculo veiculo)
        {
            InitializeComponent();

            this.Title = veiculo.Nome;
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }

    }
}