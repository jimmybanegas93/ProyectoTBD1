﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 26/11/2014 12:07:32 a.m.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;

namespace Pharma.Domain.Entities
{

    /// <summary>
    /// There are no comments for Pharma.Domain.Entities.telefonos_clientes, Pharma.Domain in the schema.
    /// </summary>
    public partial class telefonos_clientes {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          telefonos_clientes toCompare = obj as telefonos_clientes;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.id_telefonosclientes, toCompare.id_telefonosclientes))
            return false;
          if (!Object.Equals(this.id_cliente, toCompare.id_cliente))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + id_telefonosclientes.GetHashCode();
          hashCode = (hashCode * 7) + id_cliente.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for telefonos_clientes constructor in the schema.
        /// </summary>
        public telefonos_clientes()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for id_telefonosclientes in the schema.
        /// </summary>
        public virtual int id_telefonosclientes
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for id_cliente in the schema.
        /// </summary>
        public virtual int id_cliente
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for numero_tel in the schema.
        /// </summary>
        public virtual string numero_tel
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for fecha_crea in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> fecha_crea
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for fecha_actu in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> fecha_actu
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for usuario_crea in the schema.
        /// </summary>
        public virtual string usuario_crea
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for usuario_actu in the schema.
        /// </summary>
        public virtual string usuario_actu
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for clientes in the schema.
        /// </summary>
        public virtual clientes clientes
        {
            get;
            set;
        }
    }

}
