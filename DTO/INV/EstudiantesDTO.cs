using System;
using System.Collections.Generic;

namespace MATRICULA.DTO.INV;

public partial class EstudiantesDTO
{
    public int Id { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public virtual ICollection<InscripcionesDTO> Inscripciones { get; set; } = new List<InscripcionesDTO>();
}
