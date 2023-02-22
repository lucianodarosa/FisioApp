using FisioApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FisioApp.Views
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