namespace LearningByDoing.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = String.Empty;
        public string? Desciption { get; set; }
        public List<Pie>? Pies { get; set; }
    }
}
