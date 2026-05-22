using aula10.Data;
using aula10.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDataContext>(options =>
options.UseSqlite("Data Source=produtos.db"));

var app = builder.Build();


//lista produtos
app.MapGet("/produtos", (AppDataContext context) =>
{
    return context.Produtos.ToList();
});

//pega produto pelo Id
app.MapGet("/produtos/{id}", (int id, AppDataContext context) =>
{
    Produto produto = context.Produtos.Find(id);
    if (produto == null)
{
    return Results.NotFound();
}
    return Results.Ok(produto);
});

//adiciona produtos
app.MapPost("/produtos", (Produto produto, AppDataContext context) =>
{
    if(produto.Preco < 0){
       return Results.BadRequest("Preço não pode ser negativo!");
    }

    context.Produtos.Add(produto);
    context.SaveChanges();

     return Results.Created($"/produtos/{produto.Id}", produto);
});

//deleta produto
app.MapDelete("/produtos/{id}", (int id, AppDataContext context) =>{

    Produto produto = context.Produtos.Find(id);

    if (produto == null)
{
    return Results.NotFound("Produto não encontrado");
}
    context.Produtos.Remove(produto);
    context.SaveChanges();
    return Results.Ok("Produto removido");
});

//atualizar preço
app.MapPut("/produtos/{id}", (int id, Produto produtoAtualizado,  AppDataContext context) =>{

    Produto produto = context.Produtos.Find(id);

    if(produto == null){
        return Results.NotFound("Produto não encontrado");
    }

    if(produtoAtualizado.Preco < 0){
       return Results.NotFound("Preço não pode ser negativo!");
    }

    produto.Nome = produtoAtualizado.Nome;
    produto.Preco = produtoAtualizado.Preco;
    produto.Quantidade = produtoAtualizado.Quantidade;

    context.SaveChanges();

    return Results.Ok("Produto atualizado");

});

app.Run();


