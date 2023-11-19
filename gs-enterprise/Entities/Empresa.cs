using System.ComponentModel.DataAnnotations;
namespace gs_enterprise.Entities;

public class Empresa
{
    [Key]
    public int IdEmpresa { get; set; }
    public string CNPJ { get; set; }
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public string RazaoSocial { get; set; }
    public string Telefone { get; set; }

    public int EnderecoId { get; set; }
    public Endereco Endereco { get; set; }
}

