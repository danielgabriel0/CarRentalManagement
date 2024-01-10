using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel 
    {
        public int Year { get; set; }
        
        [RegularExpression(@"^[A-Za-z]{3}\d{4}[A-Za-z]", ErrorMessage = "License Plate Number doesnot meet requirements")]
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual Make? Makes { get; set; }
        public int ModelId { get; set; }
        public virtual Model? Models { get; set; }
        public int ColourId { get; set; }
        public virtual Colour? Colours { get; set; }

        public virtual List<Booking>? Bookings { get; set; }

        [DataType(DataType.Currency)]
        public double RentalRate { get; set; }
    }
}
