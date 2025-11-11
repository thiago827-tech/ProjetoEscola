using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAluno
{
     class Aluno
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
        
        public string NomeBusca {  get; set; }
        public void Cadastro() {
            Console.WriteLine("Informe o nome do aluno:");
            this.Nome = Console.ReadLine();
            Console.WriteLine("\nInforme a idade do aluno:");
            this.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o curso do aluno:");
            this.Curso = Console.ReadLine(); 
        }

        public string Buscar()
        {
          
            Console.WriteLine("Digite o nome do aluno que voce está buscando:");
            this.NomeBusca = Console.ReadLine();
            return this.NomeBusca;
        }
    }
}
