using System;

namespace C__DEV_tarde
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;
           

            // sistema de produtos/entrada
            Console.Clear();
            Console.WriteLine("----- Produtos -----");
            Console.WriteLine("______________________________________________________ \r\n");

            
            Console.WriteLine("Vamos lá; \r\nDigite ok para começarmos a seção produtos: ");
            string entradaProdutos = Console.ReadLine();
            
          
          do{
              Console.WriteLine("\r\n Menu de produtos");
              Console.WriteLine("Selecione a opção que deseja: ");
              Console.WriteLine("[1º] Produtos");
              Console.WriteLine("[2º] Preço de cada produto");
              Console.WriteLine("[3º] Produtos em promoção");
              Console.WriteLine("[0] Sair");
              resposta = int.Parse(Console.ReadLine());

              switch (resposta)
              {
                  case 1:
                
                // Visualizar produtos
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("--- Seção Produtos ---");
                Console.WriteLine(" -> Celular");
                Console.WriteLine(" -> Geladeira");
                Console.WriteLine(" -> Relógio");
                break;

                case 2:
                // Visualizar preço dos produtos 
                Console.WriteLine("Digite o nome do produto em que deseja ver o preço: ");
                break;

                case 3:
                // Visualizar produtos em promoção
                break;

                case 0: 
                // Sair da página de produtos
                break;
              }

          } while (resposta != 0);

            
        }
          } 

        }
