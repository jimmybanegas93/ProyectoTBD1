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
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Pharma.Domain.Entities
{

    /// <summary>
    /// There are no comments for Pharma.Domain.Entities.grupos_roles_has_privilegios, Pharma.Domain in the schema.
    /// </summary>
    public partial class grupos_roles_has_privilegios {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          grupos_roles_has_privilegios toCompare = obj as grupos_roles_has_privilegios;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.id_rol, toCompare.id_rol))
            return false;
          if (!Object.Equals(this.id_privilegio, toCompare.id_privilegio))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + id_rol.GetHashCode();
          hashCode = (hashCode * 7) + id_privilegio.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for grupos_roles_has_privilegios constructor in the schema.
        /// </summary>
        public grupos_roles_has_privilegios()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for id_rol in the schema.
        /// </summary>
        public virtual int id_rol
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for id_privilegio in the schema.
        /// </summary>
        public virtual int id_privilegio
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
        /// There are no comments for grupos_roles in the schema.
        /// </summary>
        public virtual grupos_roles grupos_roles
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for privilegios in the schema.
        /// </summary>
        public virtual privilegios privilegios
        {
            get;
            set;
        }
    }

}