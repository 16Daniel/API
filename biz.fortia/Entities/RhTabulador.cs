﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhTabulador
    {
        public RhTabulador()
        {
            RhTabuladorFactors = new HashSet<RhTabuladorFactor>();
        }

        public int ClaEmpresa { get; set; }
        public int ClaTabulador { get; set; }
        public string Descripcion { get; set; }
        public int? IdCorporativo { get; set; }
        public int TipoSueldo { get; set; }
        public string FormulaValpto { get; set; }
        public string FormulaCalculoValpto { get; set; }

        public virtual ICollection<RhTabuladorFactor> RhTabuladorFactors { get; set; }
    }
}