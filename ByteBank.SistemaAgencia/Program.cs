﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Compradoroes;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program 
    {

        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>() {
                new ContaCorrente(418, 10),
                new ContaCorrente(097, 20),
                new ContaCorrente(221, 40),
                new ContaCorrente(315, 35),
                new ContaCorrente(257, 18)
            };

            Console.WriteLine("Order By por Numero da Conta");

            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(cc => cc.Numero);

            foreach (var conta in contasOrdenadas.ToArray())
            {
                Console.WriteLine($"Conta: {conta.Numero} | Agencia: {conta.Agencia}");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Ordenação de Lista de Conta Corrente  (Por Agencia)");

            contasOrdenadas = contas.OrderBy(cc => cc.Agencia);

            foreach (var conta in contasOrdenadas.ToArray())
            {
                Console.WriteLine($"Conta: {conta.Numero} | Agencia: {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void Main5(string[] args)
        {
            var idades = new List<int>();
            idades.Add(10);
            idades.Add(20);
            idades.Add(30);
            idades.AdicionarVarios(40, 50, 60, 70);
            int index = 0;
            foreach (int idade in idades.ToArray())
            {
                Console.WriteLine($"[{index}] = {idade}");
                index++;
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Ordenação de Lista de Conta Corrente  (Por Número)");

            var contas = new List<ContaCorrente>() {
                new ContaCorrente(418, 102030),
                new ContaCorrente(097, 102029),
                new ContaCorrente(221, 102027),
                new ContaCorrente(315, 102040),
                new ContaCorrente(257, 102025)
            };

            // Sort usando a implementação do IComparable
            contas.Sort();

            foreach (var conta in contas.ToArray())
            {
                Console.WriteLine($"Conta: {conta.Numero} | Agencia: {conta.Agencia}");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Ordenação de Lista de Conta Corrente (Por Agência)");

            // Sort usando a implementação do IComparer
            contas.Sort(new ContaCorrentePorAgencia());

            foreach (var conta in contas.ToArray())
            {
                Console.WriteLine($"Conta: {conta.Numero} | Agencia: {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void Main4(string[] args)
        {
            ExemploList();
            Console.ReadLine();
        }

        static void Main3(string[] args) {
            Program.exemploArray();
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!

            // Meu nome é Guilherme, me ligue em 4784-4546

            //  "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //  "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //  "[0-9]{4,5}[-][0-9]{4}";
            //  "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //  "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            // 879.546.120-20
            // 879546120-20

            string textoDeTeste = "idyufdgfugfjksdhf 99871--5456 sdjkfgsdjgsjgh sfsdjgsdjghsdfj";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();








            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");




            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));


            Console.WriteLine(urlTeste.Contains("ByteBank"));


            Console.ReadLine();

            // pagina?argumentos
            // 012345678



            //moedaOrigem=real&moedaDestino=dolar
            //          |
            //  -------´

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();



            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());


            // Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            // Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();


            // <nome>=<valor>
            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();





            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }


        public static void ExemploList()
        {
            List<int> idades = new List<int>();
            idades.Add(24);
            idades.Add(27);
            idades.Add(31);
            
            int index = 0;
            foreach(int idade in idades.ToArray())
            {
                Console.WriteLine($"[{index}] = {idade}");
            }
        }



        public static void exemploArray() {

            int[] numeros = new int[]
            {
                10, 20, 30, 40, 50, 60
            };

            Program.imprimirArray(numeros);
            
            int remover = 10;
            Console.WriteLine($"Removendo {remover}");

            Console.WriteLine("Novo array");
            numeros = Program.remover(numeros, remover);

            Program.imprimirArray(numeros);

        }

        public static void imprimirArray(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"numeros[{i}] = {numeros[i]}");
            }
        }

        public static int[] remover(int[] numeros, int remover)
        {
            // 1. Achar o numero a ser removido
            int pos = -1;
            int i = 0;
            for(i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == remover)
                {
                    pos = i;
                    break;
                }
            }
            if (pos == -1)
                return numeros;

            if (pos == numeros.Length - 1)
            {
                numeros[numeros.Length - 1] = -1;
                return numeros;
            }
            int prox = 0;
            for (i = pos; i < numeros.Length; i++)
            { 
                prox = i + 1;
                if (prox < numeros.Length)
                {
                    numeros[i] = numeros[prox];
                } else
                {
                    numeros[i] = -1;
                }
            }
            return numeros;
        }


    }

}
