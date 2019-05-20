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
    public class Asignatura : INotifyPropertyChanged
    {
        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        // Atributos
        private string  idAsignatura;
        private string nombreAsignatura;
        private int nota;
        private string grupo;
        private int porcentajeInacistencia;


        //Metodos
        public int PorcentajeInacistencia
        {
            get { return porcentajeInacistencia; }
            set { porcentajeInacistencia = value; }
        }



        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }


        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }


        public string NombreAsignatura
        {
            get { return nombreAsignatura; }
            set { nombreAsignatura = value; }
        }


        public string  IdAsignaruta
        {
            get { return idAsignatura; }
            set { idAsignatura = value; }
        }

        public void OnPropertyChanged([CallerMemberName]string nombreAsignatura = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombreAsignatura));
        }


    }
}