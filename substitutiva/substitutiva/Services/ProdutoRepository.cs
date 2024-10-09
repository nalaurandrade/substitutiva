using substitutiva.Models;

namespace substitutiva.Services
{
    public class ProdutoRepository
    {
        public void SalvarProdutoNoBanco(Produto produto)
        {
            // Simulação de salvamento no banco de dados
            Console.WriteLine($"Salvando produto {produto.Nome} no banco de dados...");
        }
    }
    public class ProdutoView
    {
        public void ExibirProduto(Produto produto)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Descrição: {produto.Descricao}");
            Console.WriteLine($"Estoque: {produto.Estoque}");
        }
    }

}
