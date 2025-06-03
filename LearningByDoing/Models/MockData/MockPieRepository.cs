using Faker;
using LearningByDoing.Models.IRepository;
using static System.Net.WebRequestMethods;

namespace LearningByDoing.Models.MockData
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies {  get; set; }

        public MockPieRepository() 
        {
            var Pies = new List<Pie>();

            for(int i = 0; i < 3; i++)
            {
                Pies.Add(new Pie
                {
                    PieId = i + 1,
                    Name = Faker.Name.First().ToString(),
                    Price = Convert.ToDecimal(Faker.RandomNumber.Next(100, 300)),
                    ShortDescription = string.Join(" ", Faker.Lorem.Words(5)),
                    LongDescription = string.Join(" ", Faker.Lorem.Words(20)),
                    IsPieofTheWeek = Faker.Boolean.Random(),
                    InStock = Faker.Boolean.Random(),
                    Category = categoryRepository.AllCategories.ToList()[0],
                    ImageUrl = "https://picsum.photos/id/1/400/600",
                    ImageThumbnail = "https://picsum.photos/id/1/200"
                });
            }

            AllPies = Pies;
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieofTheWeek);
            }
        }
        public Pie? GetPieById(int pieId)
        {
            //return AllPies.Where(p => p.PieId == pieId).FirstOrDefault();
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }

    }
}
