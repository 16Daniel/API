﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Mappingspropiedade
    {
        public int Idmap { get; set; }
        public string Propiedad { get; set; }
        public string Valor { get; set; }

        public virtual Mappingscab IdmapNavigation { get; set; }
    }
}