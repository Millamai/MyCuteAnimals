namespace MyCuteAnimals.Models
{
    public class Animal
    {

        static int idCounter = 0;
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Image { get; set; }

        public int Id { get; set; }
        public Animal(string name, string description, string image)
        {
            Name = name;
            Description = description;
            Image = image;
            Id = idCounter;
            idCounter++;
        }
    }
}
