namespace Ecommerce.Lib.Models
{
    public class Cliente : Usuario
    {
        private string Cpf { get; set; }
        private string Endereco { get; set; }
        public Cliente(string nome, string email, string senha, string cpf, string endereco) : base(nome, email, senha)
        {
            SetCpf(cpf);
            SetEndereco(endereco);
        }
        private void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        private void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
    }
}