using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotecas.Negocio
{
    public class Biblioteca
    {
        private int _Id;
        private DateTime _Inauguracion;
        private int _Libros;
        private String _Nombre;
        private bool _Publica;

        public bool Publica
        {
            get { return _Publica; }
            set { _Publica = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int Libros
        {
            get { return _Libros; }
            set { _Libros = value; }
        }

        public DateTime Inauguracion
        {
            get { return _Inauguracion; }
            set { _Inauguracion = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public Biblioteca() { }

        private void Init() { }


        public bool Create()
        {
            try
            {

                Bibliotecas.DALC.Biblioteca bib = new DALC.Biblioteca();

                bib.Id = this._Id;
                bib.Inauguracion = this._Inauguracion;
                bib.Libros = this._Libros;
                bib.Nombre = this._Nombre;
                bib.Publica = this._Publica;

                CommonBC.ModeloBibliotecas.AddToBiblioteca(bib);
                CommonBC.ModeloBibliotecas.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool read()
        {
            try
            {
                Bibliotecas.DALC.Biblioteca biblioteca = CommonBC.ModeloBibliotecas.Biblioteca.First(bib => bib.Id == this._Id);

                this.Nombre = biblioteca.Nombre;
                this.Publica = biblioteca.Publica;
                this.Inauguracion = biblioteca.Inauguracion;
                this.Libros = biblioteca.Libros;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool update()
        {
            try
            {
                Bibliotecas.DALC.Biblioteca biblioteca = CommonBC.ModeloBibliotecas.Biblioteca.First(bib => bib.Id == this._Id);

                this.Nombre = biblioteca.Nombre;
                this.Publica = biblioteca.Publica;
                this.Inauguracion = biblioteca.Inauguracion;
                this.Libros = biblioteca.Libros;

                CommonBC.ModeloBibliotecas.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool delete()
        {
            Bibliotecas.DALC.Biblioteca biblioteca = CommonBC.ModeloBibliotecas.Biblioteca.First(bib => bib.Id == this._Id);

            CommonBC.ModeloBibliotecas.DeleteObject(biblioteca);
            CommonBC.ModeloBibliotecas.SaveChanges();

            return true;
        }


    }
}
