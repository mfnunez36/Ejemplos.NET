using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bibliotecas.DALC;

namespace Bibliotecas.Negocio
{
    public class CommonBC
    {
        private static BibliotecasEntities _modeloBibliotecas;

        public static BibliotecasEntities ModeloBibliotecas
        {
            get
            {
                if(_modeloBibliotecas == null)
                {
                    _modeloBibliotecas = new BibliotecasEntities();
                }
                return _modeloBibliotecas;
            }
        }

        public CommonBC() { }


    }
}
