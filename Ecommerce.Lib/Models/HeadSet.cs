namespace Ecommerce.Lib.Models
{
    public class HeadSet
    {
        private bool Surround { get; set; }
        public HeadSet(bool surround)
        {
            SetSurround(surround);
        }

        private void SetSurround(bool surround)
        {
            Surround = surround;
        }
        public bool GetSurround()
        {
            return Surround;
        }
    }
}