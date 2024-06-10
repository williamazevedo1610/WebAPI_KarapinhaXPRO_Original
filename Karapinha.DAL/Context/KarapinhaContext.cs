using K.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.DAL.Context
{
	public class KarapinhaContext: DbContext
	{
        public KarapinhaContext(DbContextOptions<KarapinhaContext> options):base(options)
        {
            
        }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Marcacao> Marcacaos { get; set; }
        public DbSet<Profissional> Profissionals { get; set; }
        public DbSet<ProfissionalHorario> ProfissionalsHorarios { get;set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoMarcacao> ServicoMarcacaos { get; set; }
        public DbSet<Utilizador> Utilizadors { get; set; }
    }
}
