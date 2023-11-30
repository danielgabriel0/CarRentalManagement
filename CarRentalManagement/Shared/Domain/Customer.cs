namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? DrivingLicense { get; set; }
        public string? Address { get;}
        public string? ContactNumber { get; set; }

        public string? EmailAddress { get; set; }
        public virtual List<Booking>? Bookings { get; set; }

    }
}