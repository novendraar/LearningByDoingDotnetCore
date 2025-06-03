using LearningByDoing.Models.IRepository;

namespace LearningByDoing.Models.MockData
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; set; }

        public MockCategoryRepository()
        {
            var categories = new List<Category>();

            for (int i = 0; i < 3; i++)
            {
                categories.Add(new Category
                {
                    CategoryId = i + 1,
                    CategoryName = Faker.Name.First(),
                    Desciption = string.Join(" ", Faker.Lorem.Words(30))
                });
            }

            AllCategories = categories;
        }
    }
}
