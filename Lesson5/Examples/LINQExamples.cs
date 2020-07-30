using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5.Examples
{
    /// <summary>
    /// LINQ Examples model
    /// </summary>
    public class LINQExamples
    {
        /// <summary>
        /// Run LINQ Examples
        /// </summary>
        public void Run()
        {
            // example of querying list of strings 
            this.QueryStringList();

            // example of querying collection
            this.QueryCollection();

            // example of querying animal data
            this.QueryAnimalData();
        }

        public class Dog
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        /// <summary>
        /// Query list of strings
        /// </summary>
        private void QueryStringList()
        {
            var dogs = new List<string>
            {
                "K 9", "Brian Griffin", "Scooby Doo",
                "Old Yeller", "Rin Tin Tin", "Benji",
                "Charlie B. Barkin", "Lassie", "Snoopy"
            };

            // Get strings with spaces and put in 
            // alphabetical order
        }

        /// <summary>
        /// Query Animal collection
        /// </summary>
        private void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal
                {
                    Name = "German Shepherd",
                    Height = 25,
                    Weight = 77
                },
                new Animal
                {
                    Name = "Chihuahua",
                    Height = 7,
                    Weight = 4.4
                },
                new Animal
                {
                    Name = "Saint Bernard",
                    Height = 30,
                    Weight = 200
                }
            };

            // Get big dogs which weight is greater than 70 and height is greater than 20
        }

        /// <summary>
        /// Query animal owner data
        /// </summary>
        private void QueryAnimalData()
        {
            // create owners
            var owners = new List<Owner>
            {
                new Owner
                {
                    Name = "Doug Parks"
                },
                new Owner
                {
                    Name = "Sally Smith",
                },
                new Owner
                {
                    Name = "Paul Brooks",
                }
            };

            // create animals
            var animals = new List<Animal>
            {
                new Animal
                {
                    Name = "German Shepherd",
                    Height = 25,
                    Weight = 77,
                    OwnerID = owners[0].ID
                },
                new Animal
                {
                    Name = "Chihuahua",
                    Height = 7,
                    Weight = 4.4,
                    OwnerID = owners[1].ID
                },
                new Animal
                {
                    Name = "Saint Bernard",
                    Height = 30,
                    Weight = 200,
                    OwnerID = owners[2].ID
                },
                new Animal
                {
                    Name = "Pug",
                    Height = 12,
                    Weight = 16,
                    OwnerID = owners[0].ID
                },
                new Animal
                {
                    Name = "Beagle",
                    Height = 15,
                    Weight = 23,
                    OwnerID = owners[2].ID
                }
            };


            // select animal name and heght group

            // Join info in owners and animals using
            // equal values for IDs
            // Store values for animal and owner

            // Get all animals and put them in a
            // newly created owner group if their
            // IDs match the owners ID 
        }
    }
}
