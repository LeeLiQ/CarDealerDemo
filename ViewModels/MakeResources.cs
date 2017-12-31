using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarDealer.ViewModels
{
    public class MakeResources
    {
        public MakeResources() => Models = new Collection<ModelResource>();

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }
    }
}