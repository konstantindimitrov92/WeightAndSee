using System.ComponentModel;
using WeightAndSee2.ViewModels;
using Xamarin.Forms;

namespace WeightAndSee2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}