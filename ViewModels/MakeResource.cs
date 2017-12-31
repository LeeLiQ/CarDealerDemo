using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarDealer.ViewModels
{
    public class MakeResource
    {
        public MakeResource() => Models = new Collection<ModelResource>();

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }
    }
}