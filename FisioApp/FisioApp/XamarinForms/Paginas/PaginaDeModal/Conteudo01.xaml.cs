using FisioApp.XamarinForms.Paginas.PaginaDeModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioApp.XamarinForms.Paginas.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo01 : ContentPage
    {
        public Conteudo01()
        {
            InitializeComponent();
        }

        private void AbrirDesportiva(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ModalDesportiva());
        }

        private void AbrirCardio(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ModalCardio());
        }
    }
}