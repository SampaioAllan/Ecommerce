namespace Ecommerce.Lib.Models
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public Cliente(string cpf, string endereco)
        {
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}