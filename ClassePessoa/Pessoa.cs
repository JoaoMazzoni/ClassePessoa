using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePessoa
{
    internal class Pessoa //Classe do tipo internal
    {
        string Nome; //Variavel sem modificador, usa o padrão do C#, "internal"
        int Idade;

        public Pessoa() //Construtor
        {

        }

        public Pessoa(string nome, int idade) //Construtor
        {
            this.Nome = nome; 
            this.Idade = idade; 
        }


        public void setNome(string nome) //Método para receber um valor e atribuí-lo/inseri-lo no atributo "Nome"
        {
            this.Nome = nome;
        }

        public string getNome() //Método que acessa o atributo e pega o valor que está inserido lá dentro, podendo imprimi-lo ou processar uma ação.  
        {
            return this.Nome; //Retorna o valor que está dentro do atributo "Nome"
        }

        public void setIdade(int idade)
        {
            this.Idade = idade;
        }

        public void setIdade()
        {
            this.Idade = int.Parse(Console.ReadLine());
        }

        public int getIdade()
        {
            return this.Idade;
        }

    }
}
