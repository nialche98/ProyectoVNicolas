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
    class Libro
    {
        private string idLibro;
        private string nombreLibro;


        public string NombreLibro
        {
            get { return nombreLibro; }
            set { nombreLibro = value; }
        }


        public string IdLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }

    }
}