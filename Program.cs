using System;

class Programa
{
    static void Main()
    {
        (int idade, string nome) pessoa;

        // Exemplo de variáveis nulas
        int? inteiroNulo = null;
        string textoNulo = null;

        int numero = 10;
        bool ehPositivo = numero > 0 ? true : false;

        Console.Write("Digite seu nome: ");
        string nomeDigitado = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int.TryParse(Console.ReadLine(), out int idadeDigitada);

        pessoa = (idadeDigitada, nomeDigitado);

        Console.WriteLine("\nDados da pessoa:");
        Console.WriteLine($"Nome: {pessoa.nome ?? "N/A"}"); 
        Console.WriteLine($"Idade: {pessoa.idade}");

        Console.WriteLine("\nValor da variável numero: " + numero);
        Console.WriteLine("O valor de numero é positivo? " + ehPositivo);
    }
}
