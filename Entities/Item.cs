using System;

namespace Catalog.Entites   
{
    public record Item 
    {
        // Can use create expression to construct item object, but after creation
        // can no longer modify this property (with init)
        public Guid Id { get; init; }

        public string Name {get; init;}
        public decimal Price{get; init;}

        public DateTimeOffset CreatedDate {get; init;}
        
        
    }
}   