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
    public class Usuario : INotifyPropertyChanged
    {
        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        //Atributos
        private string idUsuario;
        private string nombre;
        private string apellido;
        private string nombreCompleto;
        private bool isBusy = false;
        private string correo;

        //Métodos

        public string IdUsuario
        {
            get { return idUsuario; }
            set {
                idUsuario = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set {
                nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set {
                apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get {   return $"{Nombre} {Apellido}"; }
            set {
                nombreCompleto = value;
                OnPropertyChanged();
            }
        }


        public string Correo
        {
            get { return correo; }
            set {
                correo = value;
                OnPropertyChanged();
            }
        }


        public bool IsBusy
        {
            get { return isBusy = false; }
            set  {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

 

    }
}