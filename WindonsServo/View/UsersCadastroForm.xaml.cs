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
    public sealed partial class UsersCadastroForm : Page
    {

        User dados;

        public UsersCadastroForm()
        {
            this.InitializeComponent();
            dados = new User();

        }

        public UsersCadastroForm(User user)
        {
            

    }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // this.navigationHelper.OnNavigatedTo(e);

            //Todo parâmetro chega pelo argumento e
            //Você o recepciona e converte para o tipo de origem do parâmetro
            //User dados2 = new User();
            
            dados = e.Parameter as User;
           
            if (dados == null)
            {
                dados = new User();
                dados.email = lblEmail.Text;
                dados.password = lblPassword.Password;
                dados.confirmaPassword = lblConfirPassword.Password;
              //  UserViewModel.createUser(dados);
            }
            else
            {
                lblEmail.Text = dados.email;
                lblPassword.Password = dados.password;
                lblConfirPassword.Password = dados.password; 
            }
          

            

        }

        private void Register_Button(object sender, RoutedEventArgs e)
        {
            dados.email = lblEmail.Text;
            dados.password = lblPassword.Password;
            dados.confirmaPassword = lblConfirPassword.Password;

            if (dados.email != null && dados.password != null && dados.confirmaPassword != null)
            {
                UserViewModel.createUser(dados);
                Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Successfully registered!! ", "Login");

                m.ShowAsync();

                this.Frame.Navigate(typeof(UsersForm));
            }
            else
            {
                Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Email or password is Incorrect!! ", "Login Error!");

                m.ShowAsync();

            }

           
           
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UsersForm));
        }
    }
}
