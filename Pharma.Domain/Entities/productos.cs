﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 12/11/2014 01:41:26 p.m.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Pharma.Domain
{

    /// <summary>
    /// There are no comments for Pharma.Domain.productos, Pharma.Domain in the schema.
    /// </summary>
    public partial class productos {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for productos constructor in the schema.
        /// </summary>
        public productos()
        {
            this.detalle_ajustes = new HashSet<detalle_ajustes>();
            this.detalle_compras = new HashSet<detalle_compras>();
            this.detalle_cotizaciones = new HashSet<detalle_cotizaciones>();
            this.detalle_ocs = new HashSet<detalle_oc>();
            this.detallle_facturas = new HashSet<detallle_facturas>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for cod_prod in the schema.
        /// </summary>
        public virtual int cod_prod
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for existencia in the schema.
        /// </summary>
        public virtual System.Nullable<int> existencia
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for fecha_venc in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> fecha_venc
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for costo in the schema.
        /// </summary>
        public virtual System.Nullable<float> costo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for precio_consumi in the schema.
        /// </summary>
        public virtual System.Nullable<float> precio_consumi
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for precio_mayor in the schema.
        /// </summary>
        public virtual System.Nullable<float> precio_mayor
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for nombre in the schema.
        /// </summary>
        public virtual string nombre
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for cod_presentacion in the schema.
        /// </summary>
        public virtual System.Nullable<int> cod_presentacion
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for cod_categoria in the schema.
        /// </summary>
        public virtual System.Nullable<int> cod_categoria
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for existencia_min in the schema.
        /// </summary>
        public virtual System.Nullable<int> existencia_min
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for existencia_max in the schema.
        /// </summary>
        public virtual System.Nullable<int> existencia_max
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for porcentaje_m in the schema.
        /// </summary>
        public virtual System.Nullable<int> porcentaje_m
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for categoria_productos in the schema.
        /// </summary>
        public virtual categoria_productos categoria_productos
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_ajustes in the schema.
        /// </summary>
        public virtual ISet<detalle_ajustes> detalle_ajustes
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_compras in the schema.
        /// </summary>
        public virtual ISet<detalle_compras> detalle_compras
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_cotizaciones in the schema.
        /// </summary>
        public virtual ISet<detalle_cotizaciones> detalle_cotizaciones
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_ocs in the schema.
        /// </summary>
        public virtual ISet<detalle_oc> detalle_ocs
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detallle_facturas in the schema.
        /// </summary>
        public virtual ISet<detallle_facturas> detallle_facturas
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for presentacion_productos in the schema.
        /// </summary>
        public virtual presentacion_productos presentacion_productos
        {
            get;
            set;
        }
    }

}
