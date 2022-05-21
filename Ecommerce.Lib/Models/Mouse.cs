namespace Ecommerce.Lib.Models
{
    public class Mouse
    {
        private int Dpi { get; set; }
        public Mouse(int dpi)
        {
            SetDpi(dpi);
        }

        private void SetDpi(int dpi)
        {
            Dpi = dpi;
        }
        public int GetDpi()
        {
            return Dpi;
        }
    }
}