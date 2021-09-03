using Kappa.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kappa.ViewModels
{
    class MainWindowViewModel
    {
        /*private ICommand _close;
        public ICommand Close
        {
            get
            {
                return _close ?? (_close = new CommandHandler(CloseEvent));
            }
        }*/

        public RoutedUICommand CloseCommand { get; set; } = new RoutedUICommand("Close", "CloseCommand", typeof(RoutedEventHandler));
        private void CloseEvent(object sender, RoutedEventArgs e)
        {

        }
    }
}
