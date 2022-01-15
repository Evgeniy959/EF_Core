#nullable disable

namespace Ef_Core.Model
{
    public partial class PriceBook
    {
        public int Id { get; set; }
        public int IdEdition { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }

        public virtual Edition IdEditionNavigation { get; set; }
    }
}
