using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Horario
{
    [Key]
    public int id_horario  { get; set; }

    public int id_maestro { get; set; }
    public int id_materia { get; set; }
    public int id_grados { get; set; }
    public int id_grupo { get; set; }
    public int id_inicio { get; set; }
    public int id_fin { get; set; }

    // Relaciones con otras tablas (Opcional)
    [ForeignKey("id_maestro")]
    public Maestros? Maestros { get; set; }

    [ForeignKey("id_materia")]
    public Materias? Materias { get; set; }

    [ForeignKey("id_grados")]
    public Grados? Grados { get; set; }

    [ForeignKey("id_grupo")]
    public Grupos? Grupos { get; set; }

    [ForeignKey("id_inicio")]
    public HoraInicio? HoraInicio { get; set; }

    [ForeignKey("id_fin")]
    public HoraFin? HoraFin { get; set; }
}
