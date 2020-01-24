using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WindonsServo.Model;
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
    public sealed partial class ProductForm : Page
    {
        private List<Product> Products;
        private User user;
        public ProductForm()
        {
            this.InitializeComponent();
            Products = ProductViewModel.ListAll();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);
            Product prod = ProductViewModel.getById(id);

            Address address = AddressViewModel.getByIdUser(id);
           
            this.Frame.Navigate(typeof(ProductCadastroForm), prod);

        }

        private void excluirButton_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);

            string myString = id.ToString();
         
            Product prod = ProductViewModel.getById(id);
            ProductViewModel.delete(prod);
            atualizarDados();
        }

        private void atualizarDados()
        {
            Products = ProductViewModel.ListAll();
            
            this.Frame.Navigate(typeof(ProductForm));
            //  DtView.UpdateLayout();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProductCadastroForm), user);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            User users = e.Parameter as User;

            user = users;
    
        }
    }
}
