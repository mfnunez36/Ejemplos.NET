﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Seguridad.DALC
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class EmpresasEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto EmpresasEntities usando la cadena de conexión encontrada en la sección 'EmpresasEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public EmpresasEntities() : base("name=EmpresasEntities", "EmpresasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EmpresasEntities.
        /// </summary>
        public EmpresasEntities(string connectionString) : base(connectionString, "EmpresasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EmpresasEntities.
        /// </summary>
        public EmpresasEntities(EntityConnection connection) : base(connection, "EmpresasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Usuarios> Usuarios
        {
            get
            {
                if ((_Usuarios == null))
                {
                    _Usuarios = base.CreateObjectSet<Usuarios>("Usuarios");
                }
                return _Usuarios;
            }
        }
        private ObjectSet<Usuarios> _Usuarios;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Usuarios. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToUsuarios(Usuarios usuarios)
        {
            base.AddObject("Usuarios", usuarios);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmpresasModel", Name="Usuarios")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Usuarios : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Usuarios.
        /// </summary>
        /// <param name="username">Valor inicial de la propiedad username.</param>
        /// <param name="password">Valor inicial de la propiedad password.</param>
        public static Usuarios CreateUsuarios(global::System.String username, global::System.String password)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.username = username;
            usuarios.password = password;
            return usuarios;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String username
        {
            get
            {
                return _username;
            }
            set
            {
                if (_username != value)
                {
                    OnusernameChanging(value);
                    ReportPropertyChanging("username");
                    _username = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("username");
                    OnusernameChanged();
                }
            }
        }
        private global::System.String _username;
        partial void OnusernameChanging(global::System.String value);
        partial void OnusernameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                OnpasswordChanging(value);
                ReportPropertyChanging("password");
                _password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("password");
                OnpasswordChanged();
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();

        #endregion

    
    }

    #endregion

    
}
