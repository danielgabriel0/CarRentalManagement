
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarRentalManagement.Shared.Domain

{
    public class Booking : BaseDomainModel , IValidatableObject
    {
        public DateTime? DateIn { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }       
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle{ get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                if (DateIn != null)
                {
                    if (DateIn <= DateOut)
                    {
                        yield return new ValidationResult("DateIn must be greater than DateOut", new[] { "DateIn" });
                    }

                }
            }
        
    }
    
}


