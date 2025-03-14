using System.ComponentModel.DataAnnotations;

public class Grupos
{
    [Key]
    public int id_grupo { get; set; } // Matches id_grupo
    public string grupo { get; set; }
}
