using System.ComponentModel.DataAnnotations;

namespace CP2.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display (Name = "Nome do Produto")]
        public string? NomeProduto { get; set; }

        [Display (Name = "Preço")]
        public decimal Preco { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Criação")]
        public DateTime DataCadastro { get; set; }
        public bool Favorito { get; set; }
        public Tamanho Tamanho { get; set; }
    }
}

public enum Tamanho
{
    Grande,
    Medio,
    Pequeno
}
