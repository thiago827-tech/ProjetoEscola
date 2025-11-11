using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestaoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu display = new Menu();
            Aluno aluno = new Aluno();
            MySqlConnection conexao;

            conexao = new MySqlConnection("server=127.0.0.1;uid=root;pwd='1234';database=escola; Port=3307");

            try
            {
                conexao.Open();
            }
            catch (MySqlException erro)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados. \n" + erro.Message);
            }

            switch (display.Hud())
            {
                case "1":
                    aluno.Cadastro();

                    string sqlInsert = "INSERT INTO alunos (Nome, Idade, Curso) VALUES (@nome, @idade, @curso)";
                    MySqlCommand cmdCA = new MySqlCommand(sqlInsert, conexao);
                    cmdCA.Parameters.AddWithValue("@nome", aluno.Nome);
                    cmdCA.Parameters.AddWithValue("@idade", aluno.Idade);
                    cmdCA.Parameters.AddWithValue("@curso", aluno.Curso);
                    int linhas = cmdCA.ExecuteNonQuery();
                    Console.WriteLine("Aluno Cadastrado com sucesso.");
                    break;

                case "2":
                    string sqlSelect = "SELECT Id, Nome, Idade, Curso FROM alunos";
                     MySqlCommand cmdLI = new MySqlCommand(sqlSelect, conexao);
                     MySqlDataReader reader = cmdLI.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string nome = reader.GetString("Nome");
                        int idade = Convert.ToInt32(reader["Idade"]);
                        string curso = reader.GetString("Curso");
                        Console.WriteLine($"ID: {id} Nome: {nome} Idade: {idade} Curso: {curso}");
                    }
                    break;

                case "3":
                    aluno.Buscar();

                    string sqlSelect1 = "SELECT Id, Nome, Idade, Curso FROM alunos WHERE Nome LIKE @busca";
                    MySqlCommand cmdBU = new MySqlCommand(sqlSelect1, conexao);
                    cmdBU.Parameters.AddWithValue("@busca", aluno.NomeBusca);
                    MySqlDataReader reader1 = cmdBU.ExecuteReader();

                    while (reader1.Read())
                    {
                        int id = Convert.ToInt32(reader1["Id"]);
                        string nome = reader1.GetString("Nome");
                        int idade = Convert.ToInt32(reader1["Idade"]);
                        string curso = reader1.GetString("Curso");
                        Console.WriteLine($"ID: {id} Nome: {nome} Idade: {idade} Curso: {curso}");
                    }
                    break;
            }
        }
        }
    }