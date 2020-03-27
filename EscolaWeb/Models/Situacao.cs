using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaWeb.Models
{
	public class Situacao
	{
		public int Id_Situacao_PK { get; set; }
		public string Descricao { get; set; }
		public Boolean Ativo { get; set; }
	}
}
