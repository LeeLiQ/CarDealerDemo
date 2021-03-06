using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using CarDealer.Models;

namespace CarDealer.ViewModels
{
    public class SaveVehicleResource
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        public bool IsRegistered { get; set; }

        [Required]
        public ContactResource Contact { get; set; }

        public ICollection<int> Features { get; set; }

        //Best practice: always initiate collection properties.
        public SaveVehicleResource() => Features = new Collection<int>();
    }
}