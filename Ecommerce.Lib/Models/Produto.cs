namespace Ecommerce.Lib.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
        public bool SemFio { get; set; }
        public Produto(string nome, string marca, string descricao, double valor, int estoque, bool semFio)
        {
            Nome = nome;
            Marca = marca;
            Descricao = descricao;
            Valor = valor;
            Estoque = estoque;
            SemFio = semFio;
        }
    }
}