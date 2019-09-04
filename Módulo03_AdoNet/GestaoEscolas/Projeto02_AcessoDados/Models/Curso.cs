using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.Models
{
	public class Curso
	{
		public string Descricao { get; set; }
		public int CargaHoraria { get; set; }
		public double Preco { get; set; }

		//propriedade de navegação
		public Escola escolaInfo { get; set; }
	}
}
