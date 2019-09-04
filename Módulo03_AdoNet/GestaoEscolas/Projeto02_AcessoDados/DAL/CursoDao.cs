using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class CursoDao : Dao<Curso, string>
	{
		public int statusInclusaoCurso { get; set; }

		public override Curso Buscar(string chave)
		{
			throw new NotImplementedException();
		}

		public override void Incluir(Curso elemento)
		{
			try
			{
				AbrirConexao();

				//campos onde será feita a inserção de dados
				cmd.CommandText = "pr_incluir_curso";
				cmd.CommandType = CommandType.StoredProcedure;

				//incluir dados pelo formulario
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@IdEscola", elemento.escolaInfo.Id);
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@CargaHoraria", elemento.CargaHoraria);
				cmd.Parameters.AddWithValue("@Preco", elemento.Preco);

				//parâmetro de saída
				SqlParameter parameter = new SqlParameter();
				parameter.ParameterName = "@status";
				parameter.SqlDbType = SqlDbType.Int;
				parameter.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(parameter);

				cmd.ExecuteNonQuery();
				int status = (int)parameter.Value;
				statusInclusaoCurso = status;
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
		}

		public override IEnumerable<Curso> Listar(int id = 0)
		{
			throw new NotImplementedException();
		}
	}
}
