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
    /// There are no comments for Pharma.Domain.Entities.privilegios, Pharma.Domain in the schema.
    /// </summary>
    public partial class privilegios {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for privilegios constructor in the schema.
        /// </summary>
        public privilegios()
        {
            this.grupos_roles_has_privilegios = new HashSet<grupos_roles_has_privilegios>();
            this.submodulos = new HashSet<submodulos>();
            OnCreated();
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
        /// There are no comments for nombre in the schema.
        /// </summary>
        public virtual string nombre
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
        /// There are no comments for grupos_roles_has_privilegios in the schema.
        /// </summary>
        public virtual ICollection<grupos_roles_has_privilegios> grupos_roles_has_privilegios
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for submodulos in the schema.
        /// </summary>
        public virtual ICollection<submodulos> submodulos
        {
            get;
            set;
        }
    }

}
