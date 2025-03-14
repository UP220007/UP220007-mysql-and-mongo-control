using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("maestros")]

public class Maestros
{
    [Key]
    public int id_maestro { get; set; } // Matches id_maestro
    public string Nombre { get; set; }
}