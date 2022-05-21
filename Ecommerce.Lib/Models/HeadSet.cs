namespace Ecommerce.Lib.Models
{
    public class HeadSet
    {
        public bool Surround { get; set; }
        public HeadSet(bool surround)
        {
            Surround = surround;
        }
    }
}