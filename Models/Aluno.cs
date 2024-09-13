using System.ComponentModel.DataAnnotations;

public class Aluno
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    [DataType(DataType.Date)]

    public DateTime DataCadastro { get; set; }

    public bool Ativo { get; set; }
}