using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gs_enterprise.Entities;

public class Anteriores
{
    public DateTime Data { get; set; }
    public string Horario { get; set; }
    public string NomeVacina { get; set; }
    public string FaixaEtaria { get; set; }
    public string Lote { get; set; }

    [ForeignKey("Vacina ")]
    public int IdRegistro { get; set; }
    public Vacina Vacina { get; set; }
}
