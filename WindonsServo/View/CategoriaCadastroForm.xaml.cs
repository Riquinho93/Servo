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
    public sealed partial class CategoriaCadastroForm : Page
    {

        Category dados;

        public CategoriaCadastroForm()
        {
            this.InitializeComponent();
            dados = new Category();
        }

        private void Register_Button(object sender, RoutedEventArgs e)
        {
            
            dados.Name = lblName.Text;
            if(dados.Name != null)
            {
                CategoryViewModel.createCategory(dados);
                Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Successfully registered!! ", "Register Category");

                m.ShowAsync();
               
                this.Frame.Navigate(typeof(CategoriaForm));

            }
            else
            {
                Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Name is null or exist in database!! ", "Register Category Error!");
                m.ShowAsync();
            }
           
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CategoriaForm));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // this.navigationHelper.OnNavigatedTo(e);

            //Todo parâmetro chega pelo argumento e
            //Você o recepciona e converte para o tipo de origem do parâmetro
            //User dados2 = new User();

            dados = e.Parameter as Category;

            if (dados == null)
            {
                dados = new Category();
                dados.Name = lblName.Text;
                
                //  UserViewModel.createUser(dados);
            }
            else
            {
                lblName.Text = dados.Name;
                
            }




        }
    }
}
