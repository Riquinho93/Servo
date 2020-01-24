using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WindonsServo.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace WindonsServo.View
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            User user = new User();
            user.email = lblEmail.Text;
            user.password = lblPassword.Password;
            user.confirmaPassword = lblConfirPassword.Password;

            if(user.email!= null && user.password != null && user.confirmaPassword != null)
            {
                UserViewModel.createUser(user);
                Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Successfully registered!! ", "Login");

                m.ShowAsync();
                
                this.Frame.Navigate(typeof(MainPage));
            }
            else
            {
                Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Email or password is Incorrect!! ", "Login Error!");

                m.ShowAsync();

            }


           

        }
    }
}
