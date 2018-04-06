using System;
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
    }

	public partial class MainPage : ContentPage
	{
        public List<Veiculo> Veiculos { get; set; }

        public MainPage()
		{
			InitializeComponent();

            ListViewVeiculos.ItemsSource = new string[]
            {
                "Azera V6",
                "Fiesta 2.0",
                "HB20 S",
                "Prisma LZT",
                "Saveiro Cross",
                "Amarock",
                "S10",
                "Golf esport",
                "Classic",
                "Strada",
                "Sonic"
            };

		}
	}
}
