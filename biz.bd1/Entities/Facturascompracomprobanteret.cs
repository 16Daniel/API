﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class Facturascompracomprobanteret
    {
        public string Numserie { get; set; }
        public int Numfactura { get; set; }
        public string N { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public bool Manual { get; set; }
        public bool Electronica { get; set; }

        public virtual Facturascompra NNavigation { get; set; }
    }
}