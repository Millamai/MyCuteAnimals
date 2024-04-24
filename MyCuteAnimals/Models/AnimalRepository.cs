using System.Diagnostics;

namespace MyCuteAnimals.Models
{
    public class AnimalRepository :IAnimalRepository
    {

         List<Animal> _animals;
        public AnimalRepository()
        {
            if ((_animals == null) || (_animals.Count == 0))
            {
                _animals = new List<Animal>();
                _animals.Add(new Animal("Pindsvineunge", "I Danmark er det et af de mest velkendte pattedyr og lever ofte i småskove eller haver, hvor det er aktivt om natten. Dyret kendes på at have pigge på ryggen, hvilket fungerer som forsvar mod fjender.", "pexels-pixabay-50577.jpg"));
                _animals.Add(new Animal("Sæl", "Sæler er en undergruppe af rovdyrordenen, der enten samles i overfamilien Phocoidea eller underordenen Pinnipedia. Tidligere havde gruppen status af selvstændig orden, men der er bred enighed om at alle sæler nedstammer fra odderlignende rovdyr og derfor hører til i Carnivora", "cuteanimals20.png"));
                _animals.Add(new Animal("Pingvin", "Pingviner (Spheniscidae) er en familie af flyveudygtige, dykkende søfugle, som lever på den sydlige halvkugle. Mange pingviner er tilpasset et liv i havet omkring Sydpolen, men der findes også tre arter pingviner i troperne, og en art lever så langt mod nord som Galapagosøerne, hvor fuglene af og til krydser ækvator.", "cuteanimals08.png"));
                _animals.Add(new Animal("Chinchilla", "Chinchillaen er en gnaver fra Sydamerika, hvor de lever i huler og sprækker i klipperne i Andesbjergene. Dyrene holder sammen i store kolonier gerne med over 100 individer.", "cuteanimals06.png"));

            }


        }

     
        public List<Animal> GetAll()
        {
            return _animals;

        }

        public void Add(Animal a)
        {
            if (_animals != null)
            {
                _animals.Add(a);
            }
        }

        public Animal Get(int id)
        {
            if (_animals != null)
                return (_animals[_animals.FindIndex(a => a.Id == id)]);
            return null;
        }

        public void Delete(int id)
        {
            //Vi tjekker lige at listen ikke er null eller tom - alternativt ville der blive smidt en exception
            if ((_animals != null) && (_animals.Count > 0))
            {
                //Her leder vi efter elementet gennem linq
                int c = _animals.FindIndex(a => a.Id == id);
                _animals.RemoveAt(_animals.FindIndex(a => a.Id == id));
            }
        }
    }
}
