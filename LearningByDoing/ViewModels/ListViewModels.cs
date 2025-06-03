using LearningByDoing.Models;

namespace LearningByDoing.ViewModels
{
    public class ListViewModels
    {
        public IEnumerable<Pie> pies { get;}
        public string? title { get;}

        public ListViewModels(IEnumerable<Pie> pies, string? CategoryName)
        {
            this.pies = pies;
            this.title = CategoryName;
        }
    }
}
