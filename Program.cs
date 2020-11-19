using System;

namespace Projeto_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");
            string[]nomes = new string[3];
            int[]idades = new int[3];


            for(var contador=0; contador<3; contador++){
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idades[contador]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nomes Cadastrados");

            for(var contador=0; contador<3; contador++){
                Console.WriteLine("Nome:"+nomes[contador]);
                Console.WriteLine("idade:"+idades[contador]);
            }

            Console.WriteLine("Comparando as idades");

            if(idades[0]< idades[1] && idades[0]<idades[2]){
                Console.WriteLine(nomes[0]+" é mais jovem que os outros");
            } else if(idades[1]< idades[0] && idades[1]< idades[2]){
                Console.WriteLine(nomes[1]+" é mais jovem que os outros");
            }else if(idades[2]< idades[0] && idades[2]< idades[1]){
                Console.WriteLine(nomes[2]+" é mais jovem que os outros");
            }else if(idades[0]==idades[1] && idades[0]==idades[2]){
                Console.WriteLine("Todos tem a mesma idade");
            }
        }
    }
}
