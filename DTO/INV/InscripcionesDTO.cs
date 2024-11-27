using System;
using System.Collections.Generic;

namespace MATRICULA.DTO.INV;

public partial class InscripcionesDTO
{
    public int Id { get; set; }

    public int EstudianteId { get; set; }

    public int CursoId { get; set; }

    public DateTime FechaInscripcion { get; set; }

    public virtual CursosDTO Curso { get; set; } = null!;

    public virtual Estudiante Estudiante { get; set; } = null!;
}
