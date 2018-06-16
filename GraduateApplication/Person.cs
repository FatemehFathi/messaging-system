using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateApplication
{
    public class Person
    {
        DatabasePerson dbPerson = new DatabasePerson();

        public Person() { }
        public Person(string n, string e) { person_name = n; person_email = e; }


        //methods:
        public bool check_duplicate(string n, string e)
        {
            List<Person> persons = new List<Person>();
            persons = dbPerson.loadPersons();

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].get_person_name() == n)
                {
                    if (persons[i].get_person_email() == e)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        //DAO:
        public List<Person> loadPersons()
        {
            List<Person> persons = new List<Person>();
            persons = dbPerson.loadPersons();
            return persons;
        }
        public void addPerson(Person p)
        {
            dbPerson.addPerson(p);
        }
        public void editPerson(Person person, Person updated_person)
        {
            dbPerson.editPerson(person, updated_person);
        }
        public void deletePerson(string n, string e)
        {
            dbPerson.deletePerson(n, e);
        }


        //getters:
        public void set_person_name(string n) { person_name = n; }
        public void set_person_email(string e) { person_email = e; }


        //setters:
        public string get_person_name() { return person_name; }
        public string get_person_email() { return person_email; }


        //fields:
        string person_name;
        string person_email;
    }
}
