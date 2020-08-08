using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Book
    {
          
        public string Id { get; set; }
 
        public string Name { get; set; }
 
        public decimal Price { get; set; }
 
        public string Category { get; set; }
 
        public string Author { get; set; }
    }