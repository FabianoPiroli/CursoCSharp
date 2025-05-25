using System;

namespace Curso_Danki_Code
{
    interface IControle // Interface é uma assinatura onde será implementada, serve ter um código mais limpo e organizado
    {
        void ApertarBotao();
        void JogarControleNaParede();
    }

    interface Itela
    {
        void Pintar();
    }

    class ClasseBase : IControle, Itela // Uma classe pode implementar várias interfaces
    // A classe está implementando as interfaces IControle e Itela
    // Uma interface pode herdar de outra interface
    {
        public void ApertarBotao()
        {
           
        }
        public void JogarControleNaParede()
        {

        }
        public void Pintar()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}