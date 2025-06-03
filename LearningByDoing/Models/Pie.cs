﻿using System.ComponentModel;
using System.Diagnostics;

namespace LearningByDoing.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation {  get; set; }
        public decimal Price {  get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnail {  get; set; }
        public bool IsPieofTheWeek { get; set; }
        public bool InStock {  get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
