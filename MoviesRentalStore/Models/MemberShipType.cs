namespace MoviesRentalStore.Models
{
    public class MemberShipType
    {
        public int Id { get; set; }
        public short SignUpfee { get; set; }
        public byte DurationinMonth { get; set; }
        public byte DiscountRate { get; set; }

    }
}
