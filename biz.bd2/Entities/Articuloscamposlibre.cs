// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Articuloscamposlibre
    {
        public int Codarticulo { get; set; }
        public int? Proveedor { get; set; }
        public string Clasificacion { get; set; }
        public double? Precioproveedor { get; set; }
        public string Clasificacionv { get; set; }
        public string Entrega { get; set; }
        public string Unidadessat { get; set; }
        public string Catalogosat { get; set; }
        public string FamiliaRw { get; set; }
        public string Tipo { get; set; }
        public int? ValorAyc { get; set; }
        public string TipoDeArticulo { get; set; }
        public string Inventariable { get; set; }
        public string Regulariza { get; set; }
        public string UnidadMedida { get; set; }

    public virtual Articulo1 CodarticuloNavigation { get; set; }
    }
}