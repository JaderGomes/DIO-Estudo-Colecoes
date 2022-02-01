using System;
using System.Collections.Generic;
using Colecoes.Helper;
using Colecoes.Models; 

namespace Colecoes
{

    class Program 
    {

        static void Main(String[] args)
        {


            // Valor Mínimo, Máximo, Médio de uma coleção e SOMA/ nova coleção com valores distintos
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico =arrayNumeros.Distinct().ToArray();


            System.Console.WriteLine($"Mínimo: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", " , arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", " , arrayUnico)}");
           
           
           
           
            // var numerosParesQuery = 
            //         from num in arrayNumeros
            //         where num % 2 == 0 
            //         orderby num
            //         select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 ==0).OrderBy(x => x).ToList();
            
            // System.Console.WriteLine("Números pares query:" + string.Join( ", ", numerosParesQuery));
            // System.Console.WriteLine("Números pares métodos:" + string.Join(", ", numerosParesMetodo));





                // Dictionary<string, string> estados = new Dictionary<string, string>();

                // estados.Add("SP" , "São Paulo");
                // estados.Add("MG", "Minas Gerais");
                // estados.Add("BA" , "Bahia");

                // foreach (KeyValuePair<string, string> item in estados)
                // {
                //     System.Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
                // }
                    


            //   Queue<string>  fila = new Queue<string>();

            //   fila.Enqueue("Jader");
            //   fila.Enqueue("Sabrina");
            //   fila.Enqueue("Gomes");

            //   while(fila.Count > 0)
            //   {
            //         System.Console.WriteLine($"Ves de : {fila.Peek()}");
            //         System.Console.WriteLine($"{fila.Dequeue()}");
            //   }

            //         System.Console.WriteLine($"Pessoas na fila: {fila.Count}");





                // OperacoesLista opLista = new OperacoesLista();
                // List<string> estados = new List<string> {"SP", "MG", "BA"};
                // String[] estadosArray = new string[2] {"SC" , "MT"};
                

                // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

                // opLista.ImprimirListaString(estados);

                // // System.Console.WriteLine("Removendo o elemento");
                // // estados.Remove("RJ");
                
                // estados.AddRange(estadosArray);

                //  opLista.ImprimirListaString(estados); 



                // foreach (var item in estados)
                // {
                //     System.Console.WriteLine(item);
                // }

                
                    
        }




        //Ordenar Array BulleSort
        //     OperacoesArray op = new OperacoesArray();
        //     int[] array = new int[5] {6, 3, 8, 1, 9};

        //     System.Console.WriteLine("Array original:");
        //     op.ImprimirArray(array);

        //     op.OrdenarBulleSort(ref array);

        //     System.Console.WriteLine("Array ordenado");
        //     op.ImprimirArray(array);
        }
    }




