using System;
using System.Linq;
using System.Collections;
using Information_System;

namespace Information_System
{
	public class Animal
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public double Height { get; set; }
		public int AnimalID { get; set; }

		public Animal(string name = "No Name",
			double weight = 0,
			double height = 0)
		{
			Name = name;
			Weight = weight;
			Height = height;
		}

		//public void animal()
		//{
			ArrayList famAnimals = new ArrayList()
			{
				new Animal{Name = "Heidi",
				Height = .8,
				Weight = 18},
				new Animal
				{
					Name = "Shrek",
					Height = 4,
					Weight = 130
				},
				new Animal
				{
					Name = "RON",
					Height = 3.8,
					Weight = 90
				}
			};

		void toViewAll()
		{
			var famAnimalEnum = famAnimals.OfType<Animal>();
			//var smAnimals = from animal in famAnimalEnum
			//                where animal.Weight <= 90
			//                orderby animal.Name
			//                select animal;
			foreach (var animal in famAnimalEnum)
			{
				Console.WriteLine("{0} weighs {1}lbs",
					animal.Name, animal.Weight);
			}

			Console.WriteLine();
			Console.ReadKey();
		}
			void toView()
			{

			}



		//}


	}

	
}
