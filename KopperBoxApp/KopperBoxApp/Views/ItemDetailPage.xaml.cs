using KopperBoxApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KopperBoxApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}