using ServoLibrary.Model;
using ServoWindows.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WindonsServo.Data;
using WindonsServo.View;
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

    
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicationDBContent())
            {
                User user = context.Users.FirstOrDefault(p => p.email == txtEmail.Text && p.password == txtPassword.Password);

                if(user != null)
                {
                    this.Frame.Navigate(typeof(Menu), user);
                 
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
