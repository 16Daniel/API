﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Rango
    {
        public int Codcomision { get; set; }
        public int Posicion { get; set; }
        public double? Desde { get; set; }
        public double? Hasta { get; set; }

        public virtual Comisionescab CodcomisionNavigation { get; set; }
    }
}