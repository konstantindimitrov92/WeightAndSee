using System;
using System.Collections.Generic;
using System.ComponentModel;
using WeightAndSee2.Models;
using WeightAndSee2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightAndSee2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}