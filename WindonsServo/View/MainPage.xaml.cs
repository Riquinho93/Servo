using ServoLibrary.Model;
using System.Linq;
using WindonsServo.Data;
using WindonsServo.View;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace WindonsServo
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }


        private async void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicationDBContent())
            {
                User user = context.Users.FirstOrDefault(p => p.email == txtEmail.Text && p.password == txtPassword.Password);

                if (user != null)
                {
                    this.Frame.Navigate(typeof(Menu), user);

                }
                else
                {
                     Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Email or password is Incorrect!! ", "Login Error!");

                      m.ShowAsync();

                 

                }
            }


            {

            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }

      
    }
}
