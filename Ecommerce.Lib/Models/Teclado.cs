namespace Ecommerce.Lib.Models
{
    public class Teclado
    {
        private bool Mecanico { get; set; }
        public Teclado(bool mecanico)
        {
            SetMecanico(mecanico);
        }

        private void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }
        public bool GetMecanico()
        {
            return Mecanico;
        }
    }
}