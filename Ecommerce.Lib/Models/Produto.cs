namespace Ecommerce.Lib.Models
{
    public class Produto
    {
       
                private string Nome { get; set; }
        private string Marca { get; set; }
        private string Descricao { get; set; }
        private double Valor { get; set; }
        private int Estoque { get; set; }
        private bool SemFio { get; set; }
        public Produto(string nome, string marca, string descricao, double valor, int estoque, bool semFio)
        {
            SetNome(nome);
            SetMarca(marca);
            SetDescricao(descricao);
            SetValor(valor);
            SetEstoque(estoque);
            SetSemFio(semFio);
        }
        private void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        private void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetMarca()
        {
            return Marca;
        }

        private void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public string GetDescricao()
        {
            return Descricao;
        }

        private void SetValor(double valor)
        {
            Valor = valor;
        }
        public double GetValor()
        {
            return Valor;
        }

        private void SetEstoque(int estoque)
        {
            Estoque = estoque;;
        }
        public int GeEstoque()
        {
            return Estoque;
        }

        private void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }
        public bool GetSemFio()
        {
            return SemFio;
        }        
    }
}