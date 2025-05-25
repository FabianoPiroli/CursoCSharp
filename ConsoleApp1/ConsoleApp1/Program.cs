namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TipoDessaVariaviável nomeParaEssaVariaável = atribuirValor
            // Exemplo: int numero = 10;
            // Variáveis são espaços na memória que armazenam dados temporariamente.
            // Existem vários tipos de variáveis em C# que podem armazenar diferentes tipos de dados.

            // int - armazenam números inteiros. Ex: 1, 2, 3, 4, 5...
            int numero = 26;

            // float - armazenam números decimais. Ex: 1.5, 2.5, 3.5...
            float numeroDecimal = 10.5f;

            // string - armazenam textos. Ex: "Olá", "Mundo", "C#"
            string nome = "Fabiano Piroli";

            // char - armazenam um único caractere. Ex: 'a', 'b', 'c'
            char letra = 'F';

            // bool - armazenam valores lógicos. Ex: true, false
            bool verdadeiro = true;

            Console.WriteLine(nome);
            Console.WriteLine(numero);

        }
    }
}