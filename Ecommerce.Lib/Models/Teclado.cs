namespace Ecommerce.Lib.Models
{
    public class Teclado
    {
        public bool Mecanico { get; set; }
        public Teclado(bool mecanico)
        {
            Mecanico = mecanico;
        }
    }
}