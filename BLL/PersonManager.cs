using Common.Enums;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonManager
    {
        public List<Person> GetPersonList()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Person temp = new Person();
                temp.Name = "Person#" + i.ToString();

                temp.Age = rnd.Next(1, 99);

                temp.Race = (PersonRace)rnd.Next(0, 4);

                switch (temp.Race)
                {
                    case PersonRace.Angles:
                        temp.Height = temp.Age * 0.45 + 1.5;
                        break;
                    case PersonRace.Saxons:
                        temp.Height = temp.Age * 0.45 + 1.5;
                        break;
                    case PersonRace.Jutes:
                        temp.Height = temp.Age * 1.6 / 2;
                        break;
                    case PersonRace.Asians:
                        temp.Height = (temp.Age + 2) * 0.23 + 1.7;
                        break;
                }

                temp.Age = temp.Age + 1;
                people.Add(temp);
            }

            return people;
        }

        public PersonApiResponse GetPeopleInfo(IEnumerable<Person> personList)
        {
            PersonApiResponse response = new PersonApiResponse();
            response.NumberOfPeople = personList.Count();
            response.MaxAge = personList.Max(c=>c.Age);
            response.MinAge = personList.Min(c=>c.Age);
            response.AverageOfAge = personList.Average(c=>c.Age);

            response.NumberOfAngles = personList.Where(c => c.Race == PersonRace.Angles).Count();
            response.NumberOfAsians = personList.Where(c => c.Race == PersonRace.Asians).Count();
            response.NumberOfJutes = personList.Where(c => c.Race == PersonRace.Jutes).Count();
            response.NumberOfSaxons = personList.Where(c => c.Race == PersonRace.Saxons).Count();

            return response;
        }
    }
}
