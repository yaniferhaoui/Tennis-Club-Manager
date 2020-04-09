using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{

    public abstract class Person: IComparable<Person>
    {
        private static int nbInstancied = 0;
        private int id;
        private string firstName;
        private string lastName;
        private Gender gender;
        private DateTime birthdate;
        private Address address;

        protected Person(DateTime birthdate, Gender gender, string firstName, string lastName, Address address)
        {
            this.birthdate = birthdate;
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            id = nbInstancied;
            nbInstancied++;
        }

        public int CompareTo(Person obj)
        {
            if ((this.FirstName + this.LastName).Equals(obj.FirstName + obj.LastName))
            {
                return (this.id).CompareTo(obj.id);
            }
            return (this.FirstName + this.LastName).CompareTo(obj.FirstName + obj.LastName);
        }

        // Getters
        public int Age
        {
            get
            {
                DateTime currentTime = DateTime.Today;
                int age = currentTime.Year - this.birthdate.Year;
                if (this.birthdate.Date > currentTime.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

        public DateTime BirthDate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }
        public string StringBirthDate
        {
            get { return this.birthdate.ToString("dd/MM/yyyy"); }
        }


        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int ID
        {
            get { return this.id; }
        }
    }

}