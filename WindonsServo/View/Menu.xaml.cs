using ServoLibrary.Model;
using ServoWindows.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class Menu : Page
    {
        private User user;
        public Menu()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Home), user);

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            myslitview.IsPaneOpen = !myslitview.IsPaneOpen;
        }

        private void IconListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (HomeListBoxItem.IsSelected)
            {
                this.MyFrame.Navigate(typeof(Home));
            }
            if (ProfileListBoxItem.IsSelected)
            {
                this.MyFrame.Navigate(typeof(Profile), user);
            }

            if (CategoryListBoxItem.IsSelected)
            {
                this.MyFrame.Navigate(typeof(CategoriaForm));
            }

            if (ProductListBoxItem.IsSelected)
            {
                this.MyFrame.Navigate(typeof(ProductForm), user);
            }

            if (UsersListBoxItem.IsSelected)
            {
                this.MyFrame.Navigate(typeof(UsersForm));
            }

            if (AboutListBoxItem.IsSelected)
            {
                this.MyFrame.Navigate(typeof(About));
            }

            /* if (AboutListBoxItem.IsSelected)
             {
                 ResultTextBlock.Text = "This application was develop by Henrique";
             }*/

            if (ExitListBoxItem.IsSelected)
            {
                this.Frame.Navigate(typeof(MainPage));
            }

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // this.navigationHelper.OnNavigatedTo(e);

            //Todo parâmetro chega pelo argumento e
            //Você o recepciona e converte para o tipo de origem do parâmetro
            //User dados2 = new User();

            User users = e.Parameter as User;

            user= users;




        }

    }
}
