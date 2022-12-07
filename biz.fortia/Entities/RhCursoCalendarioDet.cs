﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhCursoCalendarioDet
    {
        public RhCursoCalendarioDet()
        {
            RhCursoCalAsistentes = new HashSet<RhCursoCalAsistente>();
            RhCursoCalCostos = new HashSet<RhCursoCalCosto>();
            RhCursoCalRecursos = new HashSet<RhCursoCalRecurso>();
        }

        public int FolCalendario { get; set; }
        public int FolioCurso { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime? ProgFechaIni { get; set; }
        public DateTime? ProgFechaFin { get; set; }
        public int FolioRef { get; set; }

        public virtual RhCursoCalendario FolioCursoNavigation { get; set; }
        public virtual ICollection<RhCursoCalAsistente> RhCursoCalAsistentes { get; set; }
        public virtual ICollection<RhCursoCalCosto> RhCursoCalCostos { get; set; }
        public virtual ICollection<RhCursoCalRecurso> RhCursoCalRecursos { get; set; }
    }
}