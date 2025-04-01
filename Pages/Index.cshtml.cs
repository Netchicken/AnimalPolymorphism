﻿using Microsoft.AspNetCore.Mvc.RazorPages;

using Polymorphism;

namespace AnimalPolymorphism.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }


        private void ShowAnimalInfo(Animal animal)
        {
            ViewData["message"] = ($"Species: {animal.Species}");
            animal.MakeSound();
        }

        private void createAnimal(object sender, EventArgs e)
        {
            var myAnimal = new Animal("Regular animal");
            ShowAnimalInfo(myAnimal);
        }

        private void createDog(object sender, EventArgs e)
        {
            var myDog = new Dog("Fido");
            ViewData["message"] = ($"The dog's name is {myDog.Name}.");
            ShowAnimalInfo(myDog);
        }

        private void createCat(object sender, EventArgs e)
        {
            var myCat = new Cat("Kitty");
            ViewData["message"] = ($"The cat's name is {myCat.Name}.");
            ShowAnimalInfo(myCat);
        }



    }
}
