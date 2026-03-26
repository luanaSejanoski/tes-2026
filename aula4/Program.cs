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
    string status = disponivel ? "Sim" : "Não";
    Console.WriteLine($"\nTítulo: {titulo}\nAno: {ano}\nDisponível: {status}\n");
}

public void Emprestar(){
   if(disponivel){
    disponivel = false;
    Console.WriteLine($"Livro {titulo} emprestado!");
   } else{
    Console.WriteLine($"Livro {titulo} não está disponível!");
    }  
 
   
}

public void Devolver(){
   if(!disponivel){
    disponivel = true;
    Console.WriteLine($"Livro {titulo} devolvido com sucesso!");
   } else{
    Console.WriteLine($"O livro {titulo} já está disponível!");
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

       Livro l2 = new Livro();
       l2.titulo = "Além da Porta Sussurrante";
       l2.ano = 2023;
       l2.disponivel = false;


       Livro l3 = new Livro();
       l3.titulo = "Jogos vorazes";
       l3.ano = 2012;
       l3.disponivel = false;



        Livro[] biblioteca = new Livro[3];
        biblioteca[0] = l1;
        biblioteca[0].ExibirLivro();
        Console.WriteLine("----------------------------\n");

        biblioteca[1] = l2;
        biblioteca[1].ExibirLivro();
        Console.WriteLine("----------------------------\n");

        biblioteca[2] = l3;
        biblioteca[2].ExibirLivro();
        Console.WriteLine("----------------------------\n");

        l1.ExibirLivro();
        l1.Emprestar();
        l1.ExibirLivro();
        l1.Emprestar();
        l1.Devolver();
        l1.ExibirLivro();
      
        l2.ExibirLivro();
        l2.Emprestar();
        l2.Devolver();
        l2.ExibirLivro();

        l3.ExibirLivro();
        l3.Devolver();
        l3.ExibirLivro();
    }
}
}