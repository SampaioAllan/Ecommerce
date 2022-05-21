namespace Ecommerce.Lib.Models
{
    public class Admin
    {
        public string Cnpj { get; set; }
        public Admin(string cnpj)
        {
            Cnpj = cnpj;
        }
    }
}