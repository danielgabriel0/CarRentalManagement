using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel 
    {
        public int Year { get; set; }
        public int LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual Make? Makes { get; set; }
        public virtual Model? Models { get; set; }

        public virtual Colour? Colours { get; set; }

        public virtual List<Booking>? Bookings { get; set; }
    }
}
