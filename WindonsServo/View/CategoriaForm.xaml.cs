﻿using ServoLibrary.Model;
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
    public sealed partial class CategoriaForm : Page
    {
        private List<Category> Categories;

        public CategoriaForm()
        {
            this.InitializeComponent();
            Categories = CategoryViewModel.ListAll();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CategoriaCadastroForm));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);
            Category cat = CategoryViewModel.getById(id);
            
            this.Frame.Navigate(typeof(CategoriaCadastroForm), cat);

        }

        private void excluirButton_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);

            string myString = id.ToString();
            //  string str = (string) id;
            teste.Text = myString;
            Category cat = CategoryViewModel.getById(id);
            CategoryViewModel.delete(cat);
            atualizarDados();
        }

        private void atualizarDados()
        {
            Categories = CategoryViewModel.ListAll();
            this.Frame.Navigate(typeof(CategoriaForm));
            //  DtView.UpdateLayout();
        }

    }
}
