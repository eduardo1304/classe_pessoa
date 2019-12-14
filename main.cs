using System;

    class Pessoa
    {

        string nome;
        int idade = 0;
        double altura = 0;
        double peso = 0;


        public Pessoa(string nome, int idade = 0, double altura = 0, double peso = 0)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            


        } 
                

  public void setNome(string nome)
    {
        this.nome = nome;
    }

  public string getNome()
    {
        return nome;
    }

public double IMC()
    {
        double IMC;
        IMC = (peso / altura);
        return IMC;
    } 


 


    }
    class Program
    {
        static void Main(string[] args)
        {

        Pessoa ze = new Pessoa("josé", 36, 1.75, 60.0);

        Console.WriteLine("Nome e idade da pessoa: {0}", ze.getNome());
        Console.WriteLine("IMC da pessoa {0}", ze.IMC());

        }
    }
