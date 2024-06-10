using System.ComponentModel.DataAnnotations;

namespace K.Model
{
	public class Perfil
	{
		[Key]
		public int Id { get; set; }
		public String? Descricao { get; set; }

	}
}
