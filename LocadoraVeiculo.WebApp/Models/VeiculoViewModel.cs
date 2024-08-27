﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculo.WebApp.Models
{
	public class FormularioVeiculoViewModel
	{
		[Required(ErrorMessage = "O modelo é obrigatório")]
		[MinLength(3, ErrorMessage = "O modelo deve conter ao menos 3 caracteres")]
		public string Modelo { get; set; }

		[Required(ErrorMessage = "A marca é obrigatória")]
		[MinLength(2, ErrorMessage = "A marca deve conter ao menos 2 caracteres")]
		public string Marca { get; set; }

		[Required(ErrorMessage = "O tipo de combustível é obrigatório")]
		public int TipoCombustivel { get; set; }

		[Required(ErrorMessage = "O ano do veiculo é obrigatória")]
		[Range(1, int.MaxValue, ErrorMessage = "O ano do veiculo deve ser maior que 0")]
		public int Ano { get; set; }

		[Required(ErrorMessage = "O grupo de veículos é obrigatório")]
		public int GrupoVeiculoId { get; set; }

		public IEnumerable<SelectListItem>? GruposVeiculos { get; set; }
	}

	public class InserirVeiculoViewModel : FormularioVeiculoViewModel { }

	public class EditarVeiculoViewModel : FormularioVeiculoViewModel
	{
		public int Id { get; set; }
	}
	public class ListarVeiculoViewModel
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string TipoCombustivel { get; set; }
        public string GrupoVeiculos { get; set; }
    }

    public class DetalhesVeiculoViewModel
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string TipoCombustivel { get; set; }
        public string GrupoVeiculos { get; set; }
    }
}