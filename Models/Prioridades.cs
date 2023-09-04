using System.ComponentModel.DataAnnotations;


public class Prioridades{

    [Key]
    public int PrioridadId { get; set; }

    [Required(ErrorMessage ="La descripcion es requerida")]
    public string Descripcion { get; set; } = string.Empty;

    [Range(1,31, ErrorMessage = "Los dias de compromiso tienen que estar entre 1 y 31 ")]
    public int DiasCompromiso { get; set; }

}