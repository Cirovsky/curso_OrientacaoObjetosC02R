using bytebank_ADM.Funcionarios;
using System;

class Program
{
    static void Main(string[] args)
    {
        Funcionario fulano = new("Fulano", "123456789-10", 5000);
        Console.WriteLine(fulano);

        Diretor cicrano = new("Cicrano", "987654321-00", 8000);
        Console.WriteLine(cicrano);
    }
}