using System.ComponentModel.DataAnnotations;

public class Grados
{
    [Key]
    public int id_grados { get; set; } // Matches id_grados
    public string grados { get; set; }
}
