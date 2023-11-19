using System.ComponentModel.DataAnnotations;
namespace gs_enterprise.Entities;
using System;

public class Usuario
{
    [Key]
    public int IdCadastro { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Nacionalidade { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
    [Required]
    public string CPF { get; set; }
    public string SUS { get; set; }
    [Required]
    public string Login { get; set; }
    [Required]
    public string Senha { get; set; }
}
