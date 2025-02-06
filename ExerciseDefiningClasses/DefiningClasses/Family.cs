namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.People = new List<Person>();
        }
        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public string GetOldestMember()
        {
            //int age = -1;
            //string name = null;

            //for (int i = 0; i < people.Count; i++)
            //{
            //    Person member = (Person)people[i];
            //    if (member.Age > age)
            //    {
            //        age = member.Age;
            //        name = member.Name;
            //    }
            //}

            //return $"{name} {age}";

            Person oldestMember = people.OrderByDescending(x => x.Age).FirstOrDefault();

            return $"{oldestMember.Name} {oldestMember.Age}";
        }
    }
}
