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
    /// There are no comments for Pharma.Domain.Entities.detalle_cotizaciones, Pharma.Domain in the schema.
    /// </summary>
    public partial class detalle_cotizaciones {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          detalle_cotizaciones toCompare = obj as detalle_cotizaciones;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.num_detalle, toCompare.num_detalle))
            return false;
          if (!Object.Equals(this.id_cotizacion, toCompare.id_cotizacion))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + num_detalle.GetHashCode();
          hashCode = (hashCode * 7) + id_cotizacion.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for detalle_cotizaciones constructor in the schema.
        /// </summary>
        public detalle_cotizaciones()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for num_detalle in the schema.
        /// </summary>
        public virtual int num_detalle
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for id_cotizacion in the schema.
        /// </summary>
        public virtual int id_cotizacion
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for cantidad in the schema.
        /// </summary>
        public virtual System.Nullable<int> cantidad
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for precio_unit in the schema.
        /// </summary>
        public virtual System.Nullable<double> precio_unit
        {
            get;
            set;
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
        /// There are no comments for cotizaciones in the schema.
        /// </summary>
        public virtual cotizaciones cotizaciones
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
    }

}
