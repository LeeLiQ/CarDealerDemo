using System.Collections.Generic;
using System.Collections.ObjectModel;
using CarDealer.Models;

namespace CarDealer.ViewModels
{
    public class VehicleResource
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }

        public ICollection<int> Features { get; set; }

        //Best practice: always initiate collection properties.
        public VehicleResource() => Features = new Collection<int>();
    }
}