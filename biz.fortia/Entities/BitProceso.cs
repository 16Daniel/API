﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class BitProceso
    {
        public int ClaUsuario { get; set; }
        public int ClaSistema { get; set; }
        public DateTime FechaOper { get; set; }
        public int FolBitacora { get; set; }
        public int ClaProceso { get; set; }
        public int ClaEmpresa { get; set; }
        public string NomProceso { get; set; }
        public byte? NumCaso { get; set; }
        public byte? TipoOper { get; set; }
        public string Localizacion { get; set; }
    }
}