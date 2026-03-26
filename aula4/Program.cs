using System;


public class Carro{
    public string fabricante;
    public string modelo;
    public string cor;
    public double aro;
    public int ano;
    public bool estado;

public void ExibirDados()
{
    Console.WriteLine($"Fabricante: {fabricante}\nModelo: {modelo}\nCor: {cor}\nAro: {aro}\nAno: {ano}" );
}

public void ligou(){
    Console.WriteLine("Ligou!");
}

public void desligou(){
    Console.WriteLine("Desligou!");
}

}

public class Livro{
    public string titulo;
    public int ano;
    public bool disponivel;


public void ExibirLivro()
{
    Console.WriteLine($"Titulo: {titulo}\nAno: {ano}\nDisponível: {disponivel}");
}

public void Emprestar(){
   if(disponivel){
    disponivel = true;
    Console.WriteLine("Livro disponível!");
    else{
    Console.WriteLine("Esse livro não está disponível");
    }  
 
   }
}

public void Devolver(){
    public void Emprestar(){
   if(!=disponivel){
    disponivel = false;
    Console.WriteLine("Livro não esta disponível!");
    else{
    Console.WriteLine("Livro disponível");
    }  
   }
    }
}

class Program
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.fabricante = "Toyota";
        c1.modelo = "Corolla";
        c1.cor = "Roxo";
        c1.aro = 17;
        c1.ano = 2022;
        c1.estado = false;

        c1.ExibirDados();

        if(c1.estado){
            Console.WriteLine("Ligou");
        }else{
           Console.WriteLine("Desligou");
        }

       Console.WriteLine("-----------------------------------\n");


        Livro l1 = new Livro();
        l1.titulo = "Jantar Secreto";
        li.ano = 2016;
        l1.disponivel = true;
        
    }



    

}