﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class Gruposalmacencriterio
    {
        public Gruposalmacencriterio()
        {
            Gruposalmacenlincriterios = new HashSet<Gruposalmacenlincriterio>();
        }

        public int Idgrupo { get; set; }
        public int Idcriterio { get; set; }
        public string Titulocolumna { get; set; }

        public virtual ICollection<Gruposalmacenlincriterio> Gruposalmacenlincriterios { get; set; }
    }
}