using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    class Details
    {
        public class Persons
        {
            public static List<Pips> LoadPersonData()
            {

                List<Pips> ListofPeople = new List<Pips>();
                {
                    ListofPeople.Add(new Pips() { PersonName = "Jelmarose", PersonAge = 21, PersonGender = "Female" });
                    ListofPeople.Add(new Pips() { PersonName = "Marc", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Felix", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Dino", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Charles", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Arnold", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Aaron", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Jasper", PersonAge = 21, PersonGender = "Male" });
                    ListofPeople.Add(new Pips() { PersonName = "Melrose", PersonAge = 21, PersonGender = "Female" });
                    ListofPeople.Add(new Pips() { PersonName = "Kyla", PersonAge = 21, PersonGender = "Female" });
                    ListofPeople.Add(new Pips() { PersonName = "Ella", PersonAge = 21, PersonGender = "Female" });
                    return ListofPeople;
                }
            }
        }
    }
}

