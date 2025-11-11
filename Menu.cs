using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAluno
{
     class Menu
    {
        public string Hud()
        {
            Console.WriteLine("===========BEM VINDO AO SISTEMA DE CADASTRO DE ALUNOS==============\n \t\tSELECIONE A OPCAO DESEJADA:\n 1. CADASTRAR. \n 2. LISTAR. \n 3. BUSCAR ALUNO.\n 4. ATUALIZAR INFORMACOES. \n 5. EXCLUIR. \n 6. EXIBIR TOTAL DE ALUNOS CADASTRADOS. \n 0. SAIR");
            string select = Console.ReadLine();
            select = select.ToUpper();
            return select;
        }
    }
}
