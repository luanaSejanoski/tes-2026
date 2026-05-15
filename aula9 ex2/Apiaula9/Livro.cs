
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

List<Livro> livros = new List<Livro>();

app.MapGet("/", () => "API funcionando!");


//Adicionar
app.MapGet("/livros", () => livros);

    app.MapPost("/livros", (Livro l) =>
{
    livros.Add(l);
    return Results.Ok("Livro adicionado!");
});


//Buscar por titulo
 app.MapGet("/livros/{titulo}", (String titulo) =>
{
    foreach (var l in livros)
{
    if (l.titulo.ToLower() == titulo.ToLower())
{
    return Results.Ok(l);
}
}
return Results.NotFound("Livro não encontrado");
});


//Buscar por disponivel
app.MapGet("/livros/disponivel/{disponivel}", (bool disponivel) =>{

    List<Livro> encontrados = new List<Livro>();

    foreach (var l in livros){
        if(l.disponivel == disponivel){
            encontrados.Add(l);
        }
    }

    if(encontrados.Count() > 0){
        return Results.Ok(encontrados);
    }

    return Results.NotFound("Livro não disponível");
});


//Emprestar
 app.MapPut("/livros/emprestar/{titulo}", (String titulo) => {
    foreach(var l in livros){
        if(l.titulo.ToLower() ==  titulo.ToLower()){
            if(l.disponivel == true){
                l.disponivel = false;

                return Results.Ok("Livro emprestado");
            }
                return Results.BadRequest("Livro já está emprestado");
        }
    }
                return Results.NotFound("Livro não encontrado");

 });

 //Devolver
 app.MapPut("/livros/devolver/{titulo}", (String titulo) => {
    foreach(var l in livros){
        if(l.titulo.ToLower() ==  titulo.ToLower()){
            if(l.disponivel == false){
                l.disponivel = true;

                return Results.Ok("Livro devolvido");
            }
                return Results.BadRequest("Livro já foi devolvido");
        }
    }
                return Results.NotFound("Livro não encontrado");

 });

app.Run();

class Livro
{
    public String titulo { get; set; }
    public int ano { get; set; }
    public bool disponivel {get; set;}
}