using System.ComponentModel.DataAnnotations;

public class Prioridades{

    [Key]
    public int PrioridadId { get; set; } 
    public String Descripcion { get; set; } = string.Empty;
    public int DiasCompromiso { get; set; }

}