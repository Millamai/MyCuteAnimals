using MyCuteAnimals.Models;

namespace MyCuteAnimals
{
    public interface IAnimalRepository
    {

        public void Add(Animal a);
        public Animal Get(int id);
        public void Delete(int id);

        public List<Animal> GetAll();
    }
}
