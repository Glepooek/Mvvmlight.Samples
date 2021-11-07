using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;

namespace Dialog.Services
{
    public interface IFrameNavigationService : INavigationService
    {
        object Parameter { get; set; }
        void GoBack(object parameter);
    }
}
