﻿using System.ComponentModel.DataAnnotations;
using LocadoraVeiculos.Dominio.ModuloCliente;
using LocadoraVeiculos.Dominio.ModuloEndereco;

namespace LocadoraDeVeiculos.WebApp.Models;

public class FormularioClienteViewModel
{
	[Required(ErrorMessage = "O nome é obrigatório")]
	[MinLength(3, ErrorMessage = "O nome deve conter ao menos 3 caracteres")]
	public string Nome { get; set; }

	[Required(ErrorMessage = "O email é obrigatório")]
	[EmailAddress(ErrorMessage = "O email deve ser válido")]
	public string Email { get; set; }

	[Required(ErrorMessage = "O telefone é obrigatório")]
	[Phone(ErrorMessage = "O telefone deve ser válido")]
	public string Telefone { get; set; }

	[Required(ErrorMessage = "O tipo de cadastro é obrigatório")]
	public TipoCadastroClienteEnum TipoCadastro { get; set; }

	[Required(ErrorMessage = "O número do documento é obrigatório")]
	[MinLength(11, ErrorMessage = "O número do documento deve conter ao menos 11 caracteres")]
	public string NumeroDocumento { get; set; }

    public string Cidade { get; set; }
    public EstadoEnum Estado { get; set; }
    public string Bairro { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
}

public class InserirClienteViewModel : FormularioClienteViewModel
{
}

public class EditarClienteViewModel : FormularioClienteViewModel
{
	public int Id { get; set; }
}

public class ListarClienteViewModel
{
	public int Id { get; set; }

	public string Nome { get; set; }
	public string Email { get; set; }
	public string Telefone { get; set; }

	public string TipoCadastro { get; set; }
	public string NumeroDocumento { get; set; }

	public int EnderecoId { get; set; }
	public Endereco Endereco { get; set; }
}

public class DetalhesClienteViewModel
{
	public int Id { get; set; }

	public string Nome { get; set; }
	public string Email { get; set; }
	public string Telefone { get; set; }

	public string TipoCadastro { get; set; }
	public string NumeroDocumento { get; set; }

	public int EnderecoId { get; set; }
	public Endereco Endereco { get; set; }
}