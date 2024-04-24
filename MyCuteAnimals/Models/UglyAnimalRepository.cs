namespace MyCuteAnimals.Models
{


   
    public class UglyAnimalRepository : IAnimalRepository
    {
        List<Animal> _ugly;


        public UglyAnimalRepository()
        {
             _ugly = new List<Animal>();
            Animal a = new Animal("Næseabe", "Han-næseaben har en kæmpetud, der kan blive næsten 20 centimeter lang. Den hænger og dasker ned foran munden på ham, så han bliver nødt til at holde den til side, når han skal spise. Når hannen bliver gal, svulmer næsen endnu mere op og bliver ildrød. Er der fare på færde, udstøder han høje advarselstrut, som får tuden til at stritte lige ud i luften.","næse.jpg");
            Animal p = new Animal("Blobfish", "bla bla", "Blobfish-ugly-470.png");
            _ugly.Add(a);   
            _ugly.Add(p);
        }

        public void Add(Animal a)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Animal Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAll()
        {
           return _ugly;
        }
    }
}
