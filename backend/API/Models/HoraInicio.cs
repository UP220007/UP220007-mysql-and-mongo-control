using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("hora_inicio")]
public class HoraInicio
{
    [Key]
    public int id_inicio { get; set; } // Matches id_inicio
    public string hora { get; set; }
}
