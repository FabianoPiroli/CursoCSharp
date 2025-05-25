using System;

namespace Curso_Dankicode
{
    // Definição da classe Aluno
    public class Aluno
    {
        public Aluno( string nome)
        {
            // Construtor padrão da classe Aluno
            // O construtor é chamado quando um novo objeto da classe Aluno é criado
            // Serve para inicializar as propriedades do objeto
            nomeDoAluno = nome;
        }

        // Propriedade nome do aluno
        public string nomeDoAluno { get; }
    }

    // Definição da classe Program
    public class Program
    {
        // Método principal que é o ponto de entrada do programa
        // O método Main é o ponto de entrada do programa
        public static void Main(string[] args)
        {
            // Criação de um objeto da classe Aluno
            // O operador new é usado para criar uma nova instância da classe Aluno
            // O objeto aluno é criado e suas propriedades são inicializadas com os valores padrão definidos na classe
            Aluno aluno1 = new Aluno("Fabiano");
            Aluno aluno2 = new Aluno("Lucas");


            // Exibição das propriedades do objeto aluno
            // O Console.WriteLine é usado para imprimir os valores das propriedades no console
            Console.WriteLine(aluno1.nomeDoAluno);
            Console.WriteLine(aluno2.nomeDoAluno);
        }
    }
    abstract class Motocicleta
    {
        // Métodos
        // Propriedade para armazenar o modelo da motocicleta
        // Qualquer classe consegue acessar essa propriedade
        public void LigarMoto()
        {

        }

        // Somente a classe que herdar essa classe consegue acessar essa propriedade
        protected void AdicionarGasolina(int galoes)
        {

        }


        public abstract double ChegarNaVelocidadeX();
        // Método abstrato que deve ser implementado pelas classes derivadas

        public virtual int Drive (int quilometros, int velocidade) //
        {
            // Método virtual que pode ser sobrescrito por classes derivadas
            // O método Drive é usado para calcular a distância percorrida pela motocicleta
            // O método retorna a distância percorrida em quilômetros
            return quilometros / velocidade;
        }

    }
}