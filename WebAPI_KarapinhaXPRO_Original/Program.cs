using K.DAL.Context;
using K.DAL.Repository;
using K.Service;
using K.Shared.IRepository;
using K.Shared.IService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cateorias
builder.Services.AddTransient<ICategoriaRepository,CategoriaRepository>();
builder.Services.AddTransient<ICategoriaService,CategoriaService>();

//Servicos
builder.Services.AddTransient<IServicoRepository, ServicoRepository>();
builder.Services.AddTransient<IServicoService,ServicoService>();

//Utilizadores
builder.Services.AddTransient<IUtilizadorRepository, UtilizadorRepository>();
builder.Services.AddTransient<IUtilizadorService, UtilizadorService>();

//Profissional
builder.Services.AddTransient<IProfissionalRepository, ProfissionalRepository>();
builder.Services.AddTransient<IProfissionalService, ProfissionalService>();



var conn = builder.Configuration.GetValue("conn", builder.Configuration.GetConnectionString("Conn"));

builder.Services.AddDbContext<KarapinhaContext>(o=>o.UseSqlServer(conn,b=>b.MigrationsAssembly(
	typeof(KarapinhaContext).Assembly.FullName)));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
