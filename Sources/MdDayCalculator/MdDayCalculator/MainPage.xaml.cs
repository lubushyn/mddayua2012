using System.Windows;
using MdDayCalculator.ViewModels;
using Microsoft.Phone.Controls;

namespace MdDayCalculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MainPageViewModel;
            if (vm != null)
            {
                vm.Calculate();
            }
        }
    }
}