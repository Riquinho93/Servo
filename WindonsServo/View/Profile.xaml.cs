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
    public sealed partial class Profile : Page
    {

        private User user;

        private Telephone telephone;
        Product product;
        public Profile()
        {
            this.InitializeComponent();
            User myUser = user;
                lblTele.IsEnabled = false;
                btnSave.IsEnabled = false;
            
            product = ProductViewModel.getByIdUser(1007);


            if (!product.Equals(null))
            {
                lblName.Text = product.Name;
                lblbProfession.Text = product.Profession;
                Address address = AddressViewModel.getByIdUser(product.Id);
                if(address.Cidade != null)
                {
                    lblCity.Text = address.Cidade;
                }
                else
                {
                    lblCity.Text = "";
                }
                
                
            }
            else
            {
                lblName.Text = "";
                lblbProfession.Text = "null";
                lblCity.Text = "";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblTele.IsEnabled = true;
            btnSave.IsEnabled = true;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            lblTele.IsEnabled = false;
            btnSave.IsEnabled = false;

            telephone = new Telephone();
            if(lblTele.Text != null)
            {
                telephone.number = lblTele.Text;
                telephone.code = "31";
                telephone.products = product;
                TelephoneViewModel.createTelephone(telephone, product);
            }

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            User users = e.Parameter as User;

            user = users;

        }
    }
}
