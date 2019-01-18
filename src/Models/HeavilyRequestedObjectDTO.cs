using System;

namespace Models
{
    [Serializable]
    public class HeavilyRequestedObjectDTO
    {
         public int Id { get; set; }
        public string SomeProperty { get; set; }
        public string AnotherImportantProperty { get; set; }
    }
}
