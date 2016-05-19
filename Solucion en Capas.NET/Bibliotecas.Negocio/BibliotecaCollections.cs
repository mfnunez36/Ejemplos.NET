using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotecas.Negocio
{
    public class BibliotecaCollections
    {
        private List<Biblioteca> GenerarListado(List<Bibliotecas.DALC.Biblioteca> bibliotecasDALC)
        {
            List<Bibliotecas.Negocio.Biblioteca> bibliotecas = new List<Biblioteca>();

            foreach (Bibliotecas.DALC.Biblioteca bib in bibliotecasDALC)
            {
                Bibliotecas.Negocio.Biblioteca biblioteca = new Biblioteca();

                biblioteca.Id = bib.Id;
                biblioteca.Inauguracion = bib.Inauguracion;
                biblioteca.Libros = bib.Libros;
                biblioteca.Nombre = bib.Nombre;
                biblioteca.Publica = bib.Publica;

                bibliotecas.Add(biblioteca);
            }
            return bibliotecas;
        }



        public List<Biblioteca> readAll()
        {
            var bibliotecas = CommonBC.ModeloBibliotecas.Biblioteca;

            return GenerarListado(bibliotecas.ToList());
        }

    }
}
