using System;
using System.Collections.Generic;
using PokedexApp.ViewModels;
using Xamarin.Forms;

namespace PokedexApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
