using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Proyecto.Droid.Modelos
{
    class Clase
    {
        // private DateTime fecha;
        private string lugar;
        private int horaInicio;
        private int horaFinal;
        private string diaSemana;

        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }
                     
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public int HoraFinal
        {
            get { return horaFinal; }
            set { horaFinal = value; }
        }


        public int HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }


        /*public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }*/

    }
}