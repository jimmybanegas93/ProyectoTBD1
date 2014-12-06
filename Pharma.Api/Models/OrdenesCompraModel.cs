﻿using System;
using System.Collections.Generic;
using Pharma.Domain.Entities;

namespace Pharma.Api.Models
{
    public class OrdenesCompraModel
    {
        public int id_ordencompra { get; set; }



        /// There are no comments for fecha in the schema.

        public DateTime fecha { get; set; }



        /// There are no comments for total in the schema.

        public double total { get; set; }



        /// There are no comments for id_proveedor in the schema.

        public int id_proveedor { get; set; }



        /// There are no comments for ejecutada in the schema.

        public bool ejecutada { get; set; }



        /// There are no comments for cancelada in the schema.

        public bool cancelada { get; set; }



        /// There are no comments for activa in the schema.

        public bool activa { get; set; }



        /// There are no comments for fecha_crea in the schema.

        public DateTime fecha_crea { get; set; }



        /// There are no comments for fecha_actu in the schema.

        public DateTime fecha_actu { get; set; }



        /// There are no comments for usuario_crea in the schema.

        public string usuario_crea { get; set; }



        /// There are no comments for usuario_actu in the schema.

        public string usuario_actu { get; set; }



        /// There are no comments for detalle_ocs in the schema.

        public ICollection<DetalleOcModel> detalle_ocs { get; set; }



        /// There are no comments for proveedores in the schema.

        public ProveedoresModel proveedores { get; set; }
    }
}