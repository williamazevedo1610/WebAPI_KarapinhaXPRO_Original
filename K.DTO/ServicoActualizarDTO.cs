using K.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.DTO
{
	public class ServicoActualizarDTO
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public double Preco { get; set; }
		public int CategoriaID { get; set; }
	}
}
