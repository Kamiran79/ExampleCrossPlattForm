using System;
using System.Collections.Generic;
using ExampleCrossPlattForm.Model;

namespace ExampleCrossPlattForm.DataModel
{
    class FruitData
    {
        public IList<Fruit> GetFruits()
        {
            return new List<Fruit>
            {
                new Fruit
                {
                    Name = "Apple",
                    Description = "somthing",
                    ImageUrl ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.com%2FDELICIOUS-APPLES-WASHINGTON-STATE-PRODUCE%2Fdp%2FB00AXYF5EY&psig=AOvVaw07sEhwdvKqKjRk72H14OrJ&ust=1582856232770000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMCKg5XV8OcCFQAAAAAdAAAAABAF"
                },
                new Fruit
                {
                    Name = "Mango",
                    Description = "Fruit2",
                    ImageUrl = "Smoky.jpg"
                },
                new Fruit
                {
                    Name = "Chicko",
                    Description = "Fruit 3",
                    ImageUrl = "ImageTest.png"
                }

            };
        }


    }
}
