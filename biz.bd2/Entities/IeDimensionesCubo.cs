﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class IeDimensionesCubo
    {
        public int IdDimension { get; set; }
        public int IdCubo { get; set; }
        public bool? Generar { get; set; }

        public virtual IeCubo IdCuboNavigation { get; set; }
        public virtual IeDimensione IdDimensionNavigation { get; set; }
    }
}