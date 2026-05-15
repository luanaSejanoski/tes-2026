
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

List<Contato> contatos = new List<Contato>();

app.MapGet("/", () => "API funcionando!");

app.MapGet("/contatos", () => contatos);

app.MapPost("/contatos", (Contato c) =>
{
    contatos.Add(c);

    return Results.Ok("Contato adicionado!");
});

app.MapGet("/contatos/{nome}", (string nome) =>
{
    foreach (var c in contatos)
    {
        if (c.Nome.ToLower() == nome.ToLower())
        
            return Results.Ok(c);
        }
    }

    return Results.NotFound("Contato não encontrado");
});

app.Run();

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
}