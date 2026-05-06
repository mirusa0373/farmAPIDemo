namespace FarmAPI
{
    public static class AnimalUtilities
    {
        private static readonly HashSet<string> ValidSpecies = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "cow", "sheep", "lamb", "chicken", "goat", "pig"
        };

        public static bool ValidateSpecies(string species)
        {
            return !string.IsNullOrWhiteSpace(species) && ValidSpecies.Contains(species);
        }
    }
}