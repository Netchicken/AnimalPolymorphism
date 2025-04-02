using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Polymorphism;

namespace AnimalPolymorphism.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Dog myDog { get; set; } = new Dog("Fido");
        public Cat myCat { get; set; } = new Cat("Kat");
        public Animal myAnimal { get; set; } = new Animal();

        public void OnGet()
        {
            ViewData["message"] = "Species: = " + myCat.Species + ".   Sound: = " + myCat.MakeSound();
            ViewData["newmessage"] = "Victims from the " + myCat.Species + " are " + myCat.Victims;
        }

        private void ShowAnimalInfo(Animal animal)
        {
            ViewData["message"] = ($"Species: {animal.Species}");
            animal.MakeSound();
        }

        //private void createAnimal()
        //{
        //    var myAnimal = new Animal("Regular animal");
        //    ShowAnimalInfo(myAnimal);
        //}

        private void createDog()
        {
            var myDog = new Dog("Fido");
            ViewData["message"] = ($"The dog's name is {myDog.Name}.");
            ShowAnimalInfo(myDog);
        }

        private void createCat()
        {
            var myCat = new Cat("Kitty");
            ViewData["message"] = ($"The cat's name is {myCat.Name}.");
            ShowAnimalInfo(myCat);
        }
    }
}
