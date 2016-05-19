using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguridad.DALC;

namespace Seguridad.Negocio
{
    public class CommonBC
    {
        private static EmpresasEntities _modeloSeguridad;

        public static EmpresasEntities ModeloSeguridad
        {
            get
            {
                if(_modeloSeguridad == null)
                {
                    _modeloSeguridad = new EmpresasEntities();
                }
                return _modeloSeguridad;
            }
        }

        public CommonBC() { }
    }
}
