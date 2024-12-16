using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraMVVM.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropetyChanged(string property) 
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
    }
}
