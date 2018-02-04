using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CarDealer.ViewModels;

namespace CarDealer.ViewModels
{
    public class VehicleResource
    {
        public int Id { get; set; }

        public KeyValuePairResource Model { get; set; }

        public KeyValuePairResource Make { get; set; }

        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }

        public DateTime LastUpdate { get; set; }

        public ICollection<KeyValuePairResource> Features { get; set; }

        //Best practice: always initiate collection properties.
        public VehicleResource() => Features = new Collection<KeyValuePairResource>();
    }
}