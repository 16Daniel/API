﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class Linea
    {
        public int Codmarca { get; set; }
        public int Codlinea { get; set; }
        public string Descripcion { get; set; }

        public virtual Marca CodmarcaNavigation { get; set; }
    }
}