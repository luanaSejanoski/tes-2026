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
    Console.WriteLine($"Titulo: {titulo}\nAno: {ano}");
}

public void Emprestar(){
   if(disponivel){
    disponivel = true;
    Console.WriteLine($"Livro {titulo} disponível!");
   } else{
    Console.WriteLine($"Livro {titulo} não está disponível");
    }  
 
   
}

public void Devolver(){
   if(!disponivel){
    disponivel = false;
    Console.WriteLine($"Livro {titulo} devolvido com sucesso!");
   } else{
    Console.WriteLine($"O livro {titulo} já foi devolvido!");
    } 
    }




class Program
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.fabricante = "Chevrolet";
        c1.modelo = "Impala 1967";
        c1.cor = "Preto";
        c1.aro = 15;
        c1.ano = 1967;
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
        l1.ano = 2016;
        l1.disponivel = true;

        l1.ExibirLivro();
        l1.Emprestar();
        l1.Devolver();
        l1.Emprestar();
        
    }
}
}