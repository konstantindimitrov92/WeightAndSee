using System;
using System.Collections.Generic;
using WeightAndSee2.ViewModels;
using WeightAndSee2.Views;
using Xamarin.Forms;

namespace WeightAndSee2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
