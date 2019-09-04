using Projeto02_AcessoDados.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_CadastoEscolas.RepositoryDao
{
	public sealed class Repository
	{

		static EscolaDao escolaDao;
		static CursoDao cursoDao;

		public static EscolaDao GetEscolaDao()
		{
			if(escolaDao == null)
			{
				escolaDao = new EscolaDao();
			}
			return escolaDao;
		}

		public static CursoDao GetCursoDao()
		{
			if (cursoDao == null)
			{
				escolaDao = new EscolaDao();
			}
			return cursoDao;
		}


	}
}
