using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("materia")]
public class Materias
{
    [Key]
    public int id_materia { get; set; } // Matches id_materia
    public string materia { get; set; }
}
