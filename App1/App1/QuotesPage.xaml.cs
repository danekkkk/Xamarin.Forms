using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    // Właczenie kompilacje XAML.
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        // tablica z cytatami
        public string[] Quotes =
        {
            "Jeśli potrafisz o czymś marzyć, to potrafisz tego dokonać.",
            "Móc czegoś nie chcieć, to już jest szczeście.",
            "Każdą pracę wykonuj, jakby miała ona być ostatnią w życiu.",
            "Szczęście to jedyna rzecz, która się mnoży, jeśli się ją dzieli.",
            "Nie wydawaj wyroku, zanim nie wysłuchasz przeciwnej strony"
        };

        // zmienna przechowujaca, ktory index tablicy wyswietlic
        public int QuoteNum = 0;

        public MainPage()
        {
            InitializeComponent();
            quoteLabel.Text = Quotes[QuoteNum];

            // zmiana Paddingu w zaleznosci od platformy
            if (Device.OS == TargetPlatform.Android) Padding = new Thickness(20, 30, 20, 20);
            if (Device.OS == TargetPlatform.WinPhone) Padding = new Thickness(20, 40, 20, 20);

            Device.OnPlatform(
                iOS: new Thickness(20, 20, 20, 20),
                Android: new Thickness(20, 30, 20, 20),
                WinPhone: new Thickness(20, 40, 20, 20)
            );
        }

        public void ChangeQuote(object sender, EventArgs e)
        {
            QuoteNum++;

            if (QuoteNum > Quotes.Length - 1) QuoteNum = 0;

            quoteLabel.Text = Quotes[QuoteNum];

        }
    }
}
