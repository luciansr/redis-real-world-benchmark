using System.ComponentModel.DataAnnotations;

namespace Repository.DatabaseModels
{
    internal class HeavilyRequestedObject
    {
        public int Id { get; set; }

        [MaxLength(256)]
        public string SomeProperty { get; set; }

        [MaxLength(256)]
        public string AnotherImportantProperty { get; set; }
    }
}