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
    /// There are no comments for Pharma.Domain.Entities.account_has_grupos_roles, Pharma.Domain in the schema.
    /// </summary>
    public partial class account_has_grupos_roles {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          account_has_grupos_roles toCompare = obj as account_has_grupos_roles;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Id, toCompare.Id))
            return false;
          if (!Object.Equals(this.id_rol, toCompare.id_rol))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Id.GetHashCode();
          hashCode = (hashCode * 7) + id_rol.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for account_has_grupos_roles constructor in the schema.
        /// </summary>
        public account_has_grupos_roles()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual long Id
        {
            get;
            set;
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
        /// There are no comments for account in the schema.
        /// </summary>
        public virtual account account
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
    }

}