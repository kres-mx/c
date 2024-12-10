using System;

namespace University.Data_Model
{
    public class Person
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(string id, string firstName, string lastName, int age, string phoneNumber, string email)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

}
