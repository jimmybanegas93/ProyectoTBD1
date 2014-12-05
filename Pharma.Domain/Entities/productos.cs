﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 04/12/2014 09:13:39 p.m.
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

namespace Pharma.Domain.Entities
{

    /// <summary>
    /// There are no comments for Pharma.Domain.Entities.productos, Pharma.Domain in the schema.
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
            this.costo_prod_proveedors = new HashSet<costo_prod_proveedor>();
            this.detalle_ajustes = new HashSet<detalle_ajustes>();
            this.detalle_compras = new HashSet<detalle_compras>();
            this.detalle_cotizaciones = new HashSet<detalle_cotizaciones>();
            this.detalle_facturas = new HashSet<detalle_facturas>();
            this.detalle_ocs = new HashSet<detalle_oc>();
            this.kardexes = new HashSet<kardex>();
            this.productos_has_categoria_productos = new HashSet<productos_has_categoria_productos>();
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
        /// There are no comments for existencia in the schema.
        /// </summary>
        public virtual int? existencia
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for fecha_venc in the schema.
        /// </summary>
        public virtual DateTime? fecha_venc
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for costo in the schema.
        /// </summary>
        public virtual double? costo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for precio_consumi in the schema.
        /// </summary>
        public virtual double? precio_consumi
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for precio_mayor in the schema.
        /// </summary>
        public virtual double? precio_mayor
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
        public virtual int? cod_presentacion
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for existencia_min in the schema.
        /// </summary>
        public virtual int? existencia_min
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for existencia_max in the schema.
        /// </summary>
        public virtual int? existencia_max
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for porcentaje_m in the schema.
        /// </summary>
        public virtual int? porcentaje_m
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for fecha_crea in the schema.
        /// </summary>
        public virtual DateTime? fecha_crea
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for fecha_actu in the schema.
        /// </summary>
        public virtual DateTime? fecha_actu
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
        /// There are no comments for costo_prod_proveedors in the schema.
        /// </summary>
        public virtual ICollection<costo_prod_proveedor> costo_prod_proveedors
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_ajustes in the schema.
        /// </summary>
        public virtual ICollection<detalle_ajustes> detalle_ajustes
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_compras in the schema.
        /// </summary>
        public virtual ICollection<detalle_compras> detalle_compras
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_cotizaciones in the schema.
        /// </summary>
        public virtual ICollection<detalle_cotizaciones> detalle_cotizaciones
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_facturas in the schema.
        /// </summary>
        public virtual ICollection<detalle_facturas> detalle_facturas
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for detalle_ocs in the schema.
        /// </summary>
        public virtual ICollection<detalle_oc> detalle_ocs
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for kardexes in the schema.
        /// </summary>
        public virtual ICollection<kardex> kardexes
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

    
        /// <summary>
        /// There are no comments for productos_has_categoria_productos in the schema.
        /// </summary>
        public virtual ICollection<productos_has_categoria_productos> productos_has_categoria_productos
        {
            get;
            set;
        }
    }

}
