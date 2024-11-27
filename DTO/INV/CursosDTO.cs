using System;
using System.Collections.Generic;

namespace MATRICULA.DTO.INV;

public partial class CursosDTO
{
    public int Id { get; set; }

    public string NombreCurso { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Creditos { get; set; }

    public virtual ICollection<InscripcionesDTO> Inscripciones { get; set; } = new List<InscripcionesDTO>();
}
