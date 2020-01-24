using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WindonsServo;
using WindonsServo.Model;
using WindonsServo.View;
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

namespace ServoWindows.View
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Home : Page
    {
        private List<Product> Products;
        //private List<User> lista;
       // private List<User> Users;

        public Home()
        {
            this.InitializeComponent();

            // UserViewModel userViewModel = new UserViewModel();
            //  Products = userViewModel.ListAll();

            Products = ProductViewModel.ListAll();
            //lista = UserViewModel.ListAll();
            //Users = UserViewModel.ListAll();
            //teste.Text = lista[0].name;
            
          //  Products = ProductViewModel.GetProducts();
           // ProductViewModel productViewModel = new ProductViewModel();

            // UserViewModel.delete(lista[2]);
            //User user2 = new User();
            //User user = UserViewModel.getById(lista[0].id);
           // teste.Text = user.name;

            //user.name = "Professor";
            //UserViewModel userViewModel = new UserViewModel();
            //userViewModel.createUser(user);

        }

        private void StackPanel_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ProfilePage));
        }
    }
}
