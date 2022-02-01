using System;
using ProjetoDeMedias.entities;
public class Projeto
{
    static void Main(String[] args)
    {
        int opcaoUsuario;
        string[] listaAlunos = new string[5];

        do
        {
            Console.WriteLine(@"
            Seja bem vindo!
            1- Cadastrar aluno
            2- listar alunos
            3- inserir nota
            4- excluir nota
            0- sair ");

            opcaoUsuario = int.Parse(Console.ReadLine());

            switch(opcaoUsuario)
            {
                case 1:
                
                for(int i=0; i < listaAlunos.Length; i++)
                {
                    Console.WriteLine("Informe o nome do aluno: ");
                    listaAlunos[i] = Console.ReadLine();

                }
                break;

                case 2:
                foreach(string alunos in listaAlunos)
                {
                    Console.WriteLine(alunos);
                }
                break;

                case 3:
                break;

                case 4: 
                break;

                default:
                break;
            }
        }while(opcaoUsuario != 0);


    }
}