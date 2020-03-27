using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaWeb.Models
{
	public class SituacaoAluno
	{
		public int Id_SituacaoAluno_PK { get; set; }
		public int Matricula_Fk { get; set; }
		public int Ano { get; set; }
		public string Situacao { get; set; }
		public string Grau { get; set; }
		public string Serie { get; set; }
		public string Turma { get; set; }




	}
}
