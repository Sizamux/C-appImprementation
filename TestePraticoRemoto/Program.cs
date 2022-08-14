using System.Collections.Generic;
using System.Reflection;
using System.Reflection.PortableExecutable;

namespace TestePraticoRemoto
{
    //Classe Aluno Com suas Notas e sua media total
    class Aluno {
        public List<int> amostra { get; set; }  //Lista Int
        public double media { get; set; }       //Valor com media
        public Aluno(List<int> amostra) {       //construtor que aceita Lista de valores int
            this.amostra = amostra;
            this.media = amostra.Average();     //calculo de media
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Debug Teste de passo a passo
            /*
            Console.WriteLine("Bem Vindo ao software de amostragem de alunos!");
            //var de alunos
            Aluno aluno1 = new Aluno(new List<int> { 50, 50, 70, 80, 100 });
            Aluno aluno2 = new Aluno(new List<int> { 100, 95, 90, 80, 7, 60, 50 });
            Aluno aluno3 = new Aluno(new List<int> { 70, 90, 80 });
            Aluno aluno4 = new Aluno(new List<int> { 70, 90, 81 });
            Aluno aluno5 = new Aluno(new List<int> { 100, 99, 98, 97, 96, 95, 94, 93, 91 });
            Aluno aluno6 = new Aluno(new List<int> { 30, 50 });
            Aluno aluno7 = new Aluno(new List<int> { 45, 55 });
            Aluno aluno8 = new Aluno(new List<int> { 100, 55 });
            List<Aluno> alunos = new List<Aluno>();
            //adicionando alunos na lista
            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);
            alunos.Add(aluno4);
            alunos.Add(aluno5);
            alunos.Add(aluno6);
            alunos.Add(aluno7);
            alunos.Add(aluno8);
            //Debug. Todos Alunos
            
            Console.WriteLine("Todos Alunos");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.media);
            }

            //Escrevendo Apenas Alunos Acima da Media
            Console.WriteLine("Alunos Acima da media");
            List<Aluno> sortQuerry = alunos.OrderBy(aluno => aluno.media).Where(aluno => aluno.media >= 50).ToList();

            foreach (var aluno in sortQuerry)
            {
                Console.WriteLine(aluno.media);
            }*/

            //Lista a ser utilizada na adição de notas para cada aluno
            List<int> amostrasTemp = new List<int>();
            List<Aluno> alunosT = new List<Aluno>();
            //Menu
            for (bool exit = false; !exit;)
            {
                Console.Clear();//limpar tela
                Console.WriteLine("Deseja adicionar mais Amostras? \n1-Sim\n2-Não");
                ConsoleKey pressed = Console.ReadKey().Key;//apertar quallquer tecla
                switch (pressed)//checar tecla para Menu 1
                {
                    case ConsoleKey.D1://checar tecla
                        amostrasTemp = new List<int>();
                        for (bool exitVal = false; !exitVal;)
                        {
                            Console.WriteLine("Deseja adicionar notas de aluno \n1-Sim\n2-Não");
                            ConsoleKey pressed2 = Console.ReadKey().Key;
                            switch (pressed2)//checar tecla para Menu 2
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("Insira um valor valido");
                                    int temp = int.Parse(Console.ReadLine());//Aceita um valor int
                                    Console.WriteLine(temp);
                                    amostrasTemp.Add(temp);//Adiciona valor a uma lista de valores(notas)
                                    //debug
                                    
                                    break;
                                case ConsoleKey.D2:
                                    exitVal = true; //flag loopp2
                                    break;
                                default:
                                    break;
                            }
                        }
                        Aluno Teste = new Aluno(amostrasTemp);//Define Aluno em conjunto com a Lista de notas do aluno
                        alunosT.Add(Teste);//Adiciona Aluno á lista de Alunos para ser avaliado
                        break;
                    case ConsoleKey.D2:
                        exit = true;//flag loopp1
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("\n\n-=Todos Alunos");
            //
            List<int> intQuerry = new List<int>(); 
            //
            foreach (var aluno in alunosT)//Mostra os alunos com nota acima da media da amostra
            {
                Console.WriteLine("Media da amostra:"+aluno.media);
                intQuerry = aluno.amostra.Where(i => i >= aluno.media).ToList();//lambda de ppesquisa em amostra List<Int>
                Console.Write("\n");
                foreach (var i in intQuerry)
                {
                    Console.Write(i+" ");
                }
            }
            Console.Write("\n");
            Console.ReadKey();
        } 
    }
}