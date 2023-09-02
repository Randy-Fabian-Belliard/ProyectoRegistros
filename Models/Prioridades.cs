using System.ComponentModel.DataAnnotations;

public class Prioridades{

    [Key]
    public int PrioridadId { get; set; }
    [Required(ErrorMessage ="La descripcion es requerida")]
    public string Descripcion { get; set; } = string.Empty;
    public int DiasCompromiso { get; set; }

}