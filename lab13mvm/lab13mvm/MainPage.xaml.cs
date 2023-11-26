using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab13mvm
{
    public partial class MainPage : ContentPage
    {
        private ViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            BindingContext = _viewModel;
        }
    }
}
