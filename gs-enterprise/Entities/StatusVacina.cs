using System.ComponentModel.DataAnnotations;
namespace gs_enterprise.Entities;

public class StatusVacina
{
    [Key]
    public int IdStatus { get; set; }
    [Required]
    public string TipoStatys { get; set; }
    [Required]
    public DateTime Data { get; set; }
    [Required]
    public int NumeroLote { get; set; }
}
