namespace Ecommerce.Lib.Models
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<Produto> ListProdutos { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public Pedido(Cliente cliente, string status, DateTime data)
        {
            Cliente = cliente;
            ListProdutos = new List<Produto>();
            ValorTotal=0;
            Status = status;
            Data = data;
        }
    }
}