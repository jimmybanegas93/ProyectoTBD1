﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 12/7/2014 11:40:39 PM
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
    /// There are no comments for Pharma.Domain.InvoiceDetail, Pharma.Domain in the schema.
    /// </summary>
    public partial class InvoiceDetail {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          InvoiceDetail toCompare = obj as InvoiceDetail;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.InvoiceDetailNumber, toCompare.InvoiceDetailNumber))
            return false;
          if (!Object.Equals(this.InvoiceId, toCompare.InvoiceId))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + InvoiceDetailNumber.GetHashCode();
          hashCode = (hashCode * 7) + InvoiceId.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for InvoiceDetail constructor in the schema.
        /// </summary>
        public InvoiceDetail()
        {
            this.CreatedByUser = @"NULL";
            this.ModifiedByUser = @"NULL";
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for InvoiceDetailNumber in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int InvoiceDetailNumber
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for InvoiceId in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int InvoiceId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SalePrice in the schema.
        /// </summary>
        public virtual System.Nullable<float> SalePrice
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Quantity in the schema.
        /// </summary>
        public virtual System.Nullable<int> Quantity
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SubTotal in the schema.
        /// </summary>
        public virtual System.Nullable<float> SubTotal
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for CreatedByUser in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public virtual string CreatedByUser
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ModifiedByUser in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public virtual string ModifiedByUser
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for CreationDate in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> CreationDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ModifyDate in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> ModifyDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Invoice in the schema.
        /// </summary>
        public virtual Invoice Invoice
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        public virtual Product Product
        {
            get;
            set;
        }
    }

}