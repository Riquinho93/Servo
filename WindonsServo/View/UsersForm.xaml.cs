using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using WindonsServo.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace WindonsServo.View
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class UsersForm : Page
    {
        private List<User> Userses;
        // private ObservableCollection<User> Userses;

        public UsersForm()
        {
            this.InitializeComponent();
            Userses = UserViewModel.ListAll();

           
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
           
            this.Frame.Navigate(typeof(UsersCadastroForm));
        }

        private void excluirButton_Click(object sender, RoutedEventArgs e)
        {
            
            Button b = (Button)sender;
            int id =  Convert.ToInt32(b.Tag);
            
            string myString = id.ToString();
            //  string str = (string) id;
            teste.Text = myString;
            User user = UserViewModel.getById(id);
            UserViewModel.delete(user);
            atualizarDados();
        }

        private void atualizarDados()
        {
            Userses = UserViewModel.ListAll();
            this.Frame.Navigate(typeof(UsersForm));
            //  DtView.UpdateLayout();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);
            User user = UserViewModel.getById(id);
            this.Frame.Navigate(typeof(UsersCadastroForm),user);
            //this.Frame.Navigate(typeof(UsersCadastro(user)));
        }
    }
    
}
