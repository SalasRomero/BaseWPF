using EstructuraMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EstructuraMVVM.Command;

namespace EstructuraMVVM.ViewModel
{
    public class TareaViewModel:ViewModelBase
    {
        public Tarea _tarea;

        public string Titulo 
        {
            get { return _tarea.Titulo; }
            set {
                if (_tarea.Titulo != value) 
                {
                    _tarea.Titulo = value;
                    OnPropetyChanged(nameof(_tarea.Titulo));
                }
            }
        }

        public string Descripcion
        {
            get { return _tarea.Descripcion; }
            set
            {
                if (_tarea.Descripcion != value)
                {
                    _tarea.Descripcion = value;
                    OnPropetyChanged(nameof(_tarea.Descripcion));
                }
            }
        }

        public string Persona
        {
            get { return _tarea.Persona; }
            set
            {
                if (_tarea.Persona != value)
                {
                    _tarea.Persona = value;
                    OnPropetyChanged(nameof(_tarea.Persona));
                }
            }
        }

        public DateTime FechaLimite
        {
            get { return _tarea.FechaLimite; }
            set
            {
                if (_tarea.FechaLimite != value)
                {
                    _tarea.FechaLimite = value;
                    OnPropetyChanged(nameof(_tarea.FechaLimite));
                }
            }
        }


        public ICommand GuardarCommand { get; }
        public TareaViewModel() 
        {
            _tarea = new Tarea();
            GuardarCommand = new Commando(Guardar,CanGuardar);
        }

        //Command

        public bool CanGuardar(object parameter) 
        {
            if (_tarea.Titulo == null || _tarea.Titulo.Length == 0) 
            {
                return false;
            }
            return true;
        }
        public void Guardar(object parameter) 
        {
            //Lógica al guardar
        }
    }
}
