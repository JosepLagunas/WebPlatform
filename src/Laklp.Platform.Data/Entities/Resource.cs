using System;

namespace Laklp.Platform.Data.Entities
{
    public class Resource : Traceable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Properties { get; set; }
        public string Url { get; set; }
        public Entity Entity { get; set; }
    }
}