using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Titulo { get; set; } = string.Empty;
        [Display(Name = "Data de lançamento")]


        [Required(ErrorMessage = "Este campo é obrigatório")]

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório"),
        StringLength(50)]
        public string Genero { get; set; } = string.Empty;


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal 18, 2")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(0,5)]
        public int? Pontos { get; set; }


    }
}
