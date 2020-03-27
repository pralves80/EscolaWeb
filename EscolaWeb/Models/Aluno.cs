using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaWeb.Models
{
	public class Aluno
	{
		public int Id_Aluno_PK { get; set; }
		public int Matricula { get; set; }
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }
		public string NomePai { get; set; }
		public string NomeMae { get; set; }
		public string NomeResponsavel { get; set; }
		public string GrauParentesco { get; set; }

	}
}
