using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EstructuraMVVM.Command
{
    public class Commando : ICommand
    {
        //Vamos a definir los delegados
        public Action<object> _action;//Execute
        public Predicate<object> _predicate; //canExecute
        //Fin de la definición de los delegados

        public Commando(Action<object> action) : this(action, null) { }
        public Commando(Action<object> action, Predicate<object> predicate)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }
            _action = action;
            _predicate = predicate;
        }

        //public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _predicate is null ? true : _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged 
        {
            add{ CommandManager.RequerySuggested += value; }    
            remove{ CommandManager.RequerySuggested += value; }
        }

    }
}
