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
    /// There are no comments for Pharma.Domain.Entities.costo_prod_proveedor, Pharma.Domain in the schema.
    /// </summary>
    public partial class costo_prod_proveedor {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          costo_prod_proveedor toCompare = obj as costo_prod_proveedor;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.cod_prod, toCompare.cod_prod))
            return false;
          if (!Object.Equals(this.id_proveedor, toCompare.id_proveedor))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + cod_prod.GetHashCode();
          hashCode = (hashCode * 7) + id_proveedor.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for costo_prod_proveedor constructor in the schema.
        /// </summary>
        public costo_prod_proveedor()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for cod_prod in the schema.
        /// </summary>
        public virtual string cod_prod
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for id_proveedor in the schema.
        /// </summary>
        public virtual int id_proveedor
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for costo in the schema.
        /// </summary>
        public virtual double costo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for productos in the schema.
        /// </summary>
        public virtual productos productos
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for proveedores in the schema.
        /// </summary>
        public virtual proveedores proveedores
        {
            get;
            set;
        }
    }

}
