namespace Ecommerce.Lib.Models
{
    public class Pedido
    {
        private Cliente Cliente { get; set; }
        private List<Produto> ListProdutos { get; set; }
        private double ValorTotal { get; set; }
        private string Status { get; set; }
        private DateTime Data { get; set; }
        public Pedido(Cliente cliente, string status, DateTime data)
        {
            SetCliente(cliente);
            ListProdutos = new List<Produto>();
            ValorTotal=0;
            SetStatus(status);
            SetData(data);
        }

        private void SetCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public Cliente GetCliente()
        {
            return Cliente;
        }

        private void SetStatus(string status)
        {
            Status = status;
        }
        public string GetStatus()
        {
            return Status;
        }

        private void SetData(DateTime data)
        {
            Data = data;
        }
        public DateTime GetData()
        {
            return Data;
        }
    }
}