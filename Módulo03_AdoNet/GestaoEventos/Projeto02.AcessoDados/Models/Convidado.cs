﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.AcessoDados.Models
{
	public class Convidado
	{
		public string Cpf { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }

		//Propriedade de navegação
		public Evento EventoInfo { get; set; }

	}
}
