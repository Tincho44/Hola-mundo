using System;
using System.Collections.Generic;

namespace Program
{
    public class Producto
    {

        public string Nombre { get; }
        public int Precio { get; set; }
        public List<Review> AgregarReviews = new List<Review>();

    }

}


