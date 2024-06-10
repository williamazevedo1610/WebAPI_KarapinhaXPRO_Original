using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Model
{
	public class Servico
	{
		[Key]
		public int MyProperty { get; set; }
		public String ?Descricao { get; set; }
		public double Preco { get; set; }
		public int CategoriaID {  get; set; }
		[ForeignKey(nameof(CategoriaID))]

		public Categoria Categoria { get; set; }
		
	}
}
