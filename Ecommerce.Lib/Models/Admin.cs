namespace Ecommerce.Lib.Models
{
    public class Admin : Usuario
    {
        private string Cnpj { get; set; }
        public Admin(string nome, string email, string senha, string cnpj) : base(nome, email, senha)
        {
            SetCnpj(cnpj);
        }
        private void SetCnpj(string cnpj)
        {
            Cnpj = cnpj;
        }
        public string GetCnpj()
        {
            return Cnpj;
        }

    }
}