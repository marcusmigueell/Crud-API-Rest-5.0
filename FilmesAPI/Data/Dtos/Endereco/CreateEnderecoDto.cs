﻿using System.ComponentModel.DataAnnotations;


namespace FilmesAPI.Data.Dtos {

    public class CreateEnderecoDto {

        [Required(ErrorMessage = "O campo de Logradouro é obrigatório")]
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }
    }
}
