﻿namespace Pustok_DbStructure.Entities
{
    public class BookImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public bool? PosterStatus { get; set; }
        public int BookId { get; set; }
    }
}
