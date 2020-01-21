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
    public sealed partial class ProductCadastroForm : Page
    {

        Product dados;
        Category categoria;
        private List<Category> Categorias;
      
        public ProductCadastroForm()
        {
            this.InitializeComponent();
            dados = new Product();
            Categorias = CategoryViewModel.ListAll();
      

        }

        private void Button_Cadastro(object sender, RoutedEventArgs e)
        {
            dados.Name = lblName.Text;
            dados.Profession = lblProfession.Text;
            string idade = lblAge.Text;
            int old = Convert.ToInt32(idade);
            dados.Age = old;
            
          //  int temp = Convert.ToInt32(lblAge);
            //dados.Age = lblAge;
            ProductViewModel.createProduct(categoria, dados);
            //categoria.Products.Add(dados);
            Address address = new Address();
            address.Cidade = lblCity.Text;
           
            address.Complemento = lblcomplemento.Text;
            address.Rua = lblStreet.Text;
            address.Product = dados;
            address.ProductId = dados.Id;
 
            AddressViewModel addressViewModel = new AddressViewModel();
            addressViewModel.createAddress(dados, address);
           
 

            this.Frame.Navigate(typeof(ProductForm));
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProductForm));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var b = (ComboBox)sender;
 
            int t = (int)b.SelectedValue;
            
            if(t > 0) {
                categoria= CategoryViewModel.getById(t);
                
                dados.Category = categoria;
                
               
            }   
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            

            User users = e.Parameter as User;

            dados.User = users;




        }
    }
}
