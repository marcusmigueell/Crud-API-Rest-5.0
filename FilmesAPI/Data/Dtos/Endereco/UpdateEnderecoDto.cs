using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos {

    public class UpdateEnderecoDto {

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
