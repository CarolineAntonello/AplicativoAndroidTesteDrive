﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TesteDrive
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado { get { return string.Format("R$ {0}", Preco); } }
    }

	public partial class MainPage : ContentPage
	{
        public List<Veiculo> Veiculos { get; set; }

        public MainPage()
		{
			InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo{Nome = "Azera V6", Preco = 60000},
                new Veiculo{Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo{Nome = "HB20 S", Preco = 40000},
                new Veiculo{Nome = "Prisma LZT", Preco = 60000},
                new Veiculo{Nome = "Saveiro Cross", Preco = 40000},
                new Veiculo{Nome = "Amarock", Preco = 115000},
                new Veiculo{Nome = "S10", Preco = 120000},
                new Veiculo{Nome = "Golf esport", Preco = 90000},
                new Veiculo{Nome = "Strada", Preco = 45000},
                new Veiculo{Nome = "Classic", Preco = 30000},
                new Veiculo{Nome = "Prisma LZT", Preco = 60000},
                new Veiculo{Nome = "Saveiro Cross", Preco = 40000},
                new Veiculo{Nome = "Amarock", Preco = 115000},
                new Veiculo{Nome = "S10", Preco = 120000},
                new Veiculo{Nome = "Golf esport", Preco = 90000},
                new Veiculo{Nome = "Strada", Preco = 45000},
                new Veiculo{Nome = "Classic", Preco = 30000}
            };

            this.BindingContext = this;
		}

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;
            DisplayAlert("Teste Drive", string.Format("Você tocou no modelo '{0}', que custa {1}",veiculo.Nome,veiculo.PrecoFormatado), "OK");
        }

    }
}
