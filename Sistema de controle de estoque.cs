using System;
using System.Data.SqlClient;
using Projeto_Sistema_Gestão_Estoque.Funcionalidades;
using Projeto_Sistema_Gestao_Estoque.Funcionalidades;

namespace Projeto_Sistema_Gestão_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de Estoque da empresa");
            Console.WriteLine();

            // Exemplo de conexão com SQL Server
            string connectionString = "Server=NOTEBOOK-ISAQUE;Database=Estoque_Empresa;Integrated Security=True;";

            bool conexaoBemSucedida = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");
                    conexaoBemSucedida = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

            Console.WriteLine();
            if (!conexaoBemSucedida)
            {
                Console.WriteLine("Aviso: O sistema não conseguiu estabelecer conexão com o banco de dados.");
                Console.WriteLine();
            }

            // Menu principal
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine(" 1 - Produto");
            Console.WriteLine(" 2 - Fornecedor");
            Console.WriteLine(" 3 - Clientes");
            Console.WriteLine(" 4 - Sair");

            Console.Write("Escolha uma opção: ");
            int escolha_menu = int.Parse(Console.ReadLine());

            if (escolha_menu == 1)
            {
                
                Produto produto = new Produto();
                produto.MenuProduto();
            }
            else if (escolha_menu == 2)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.MenuFornecedor();

            }
            else if (escolha_menu == 3)
            {
                Cliente cliente = new Cliente();
                cliente.MenuCliente();
            }
            else if (escolha_menu == 4)
            {
                Console.WriteLine("Saindo do sistema...");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}