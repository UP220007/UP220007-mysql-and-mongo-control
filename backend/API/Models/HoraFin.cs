using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("hora_fin")]
public class HoraFin
{
    [Key]
    public int id_fin { get; set; } // Matches id_fin
    public string hora { get; set; }
}
