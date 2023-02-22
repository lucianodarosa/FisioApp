﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioApp.XamarinForms.Paginas.PaginaDeModal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalCardio : ContentPage
    {
        public ModalCardio()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}