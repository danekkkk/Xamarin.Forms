using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    // Enable XAML compilation.
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
            BindingContext = this;

            if (Device.OS == TargetPlatform.Android) Padding = new Thickness(20, 30, 20, 20);
            if (Device.OS == TargetPlatform.WinPhone) Padding = new Thickness(20, 40, 20, 20);

            Device.OnPlatform(
                iOS: new Thickness(20, 20, 20, 20),
                Android: new Thickness(20, 30, 20, 20),
                WinPhone: new Thickness(20, 40, 20, 20)
            );

        }

        public string[] Quotes { get; set; } = {
            "Jeśli potrafisz o czymś marzyć, to potrafisz tego dokonać.",
            "Móc czegoś nie chcieć, to już jest szczeście.",
            "Każdą pracę wykonuj, jakby miała ona być ostatnią w życiu."
        };
    }
}