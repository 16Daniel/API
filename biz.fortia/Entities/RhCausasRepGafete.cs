﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhCausasRepGafete
    {
        public RhCausasRepGafete()
        {
            RhSolRepGafetes = new HashSet<RhSolRepGafete>();
        }

        public int FolCausaRep { get; set; }
        public int ClaEmpresa { get; set; }
        public string NomCausaRep { get; set; }
        public int AplicaCobro { get; set; }
        public int? ClaPerded { get; set; }
        public double? Importe { get; set; }
        public int? MostrarImporteKiosco { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public int? ClaUsuarioUltCambio { get; set; }

        public virtual ICollection<RhSolRepGafete> RhSolRepGafetes { get; set; }
    }
}