namespace FarmAPI
{
    public class AnimalItem
    {
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int Age { get; set; }

        public static List<AnimalItem> GetSampleAnimals()
        {
            return new List<AnimalItem>
            {
                new AnimalItem { Name = "Bessie", Species = "Cow", Age = 4 },
                new AnimalItem { Name = "Fluffy", Species = "Sheep", Age = 3 },
                new AnimalItem { Name = "Little Lamb", Species = "Lamb", Age = 1 }
            };
        }
    }
}