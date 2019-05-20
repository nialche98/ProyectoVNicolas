using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Proyecto.Droid.Modelos
{
    public class Login : INotifyPropertyChanged

    {

        //Atributos
        private string idUsuario;
        private string contrasena;
        private string llave;
        private string valor;
        private bool isBusy = false;

        //Evento
        public event PropertyChangedEventHandler PropertyChanged;

        //Metodos

        public string Valor
        {
            get { return valor; }
            set { valor = value;
                OnPropertyChanged();
            }
        }

        public string Llave
        {
            get { return llave; }
            set { llave = value;
                OnPropertyChanged();
            }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value;
                OnPropertyChanged();
            }
        }

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName]string idUsuario = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(idUsuario));
        }

        public bool IsBusy
        {
            get { return isBusy = false; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }


    }
}