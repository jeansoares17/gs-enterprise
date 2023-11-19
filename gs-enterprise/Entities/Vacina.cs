using System.ComponentModel.DataAnnotations;
namespace gs_enterprise.Entities;
public class Vacina
{
    [Key]
    public int IdRegistro { get; set; }
    public string CPF { get; set; }
}
