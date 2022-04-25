using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PokedexApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        #region Fields

        private string email;
        private object password;

        #endregion


        #region Properties

        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged();

            }
        }

        public object Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public ICommand SingInCommand { protected set; get; }

        #endregion


        #region Methods

        public LoginViewModel()
        {
            SingInCommand = new Command(SingIn);
        }

        public async void SingIn()
        {
            if (email == "demo@demo.com" || password == "1234")
            {
                //await App.Current.MainPage.Navigation.PushAsync(new PokemonsPage());
            }
        }

        #endregion
    }
}
