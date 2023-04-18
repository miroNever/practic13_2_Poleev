using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_13
{
    class House
    {
        private string name;
        private string surname;
        private string secondname;
        private string adress;
        private double price;
        public string Name
        {
            get { return this.name; }
            set { this.name = name; }
        }        public string Surname
        {
            get { return this.surname; }
            set { this.surname = surname; }
        }        public string Secondname
        {
            get { return this.secondname; }
            set { this.secondname = secondname; }
        }
        public string Adress
        {
            get { return this.adress; }
            set { this.adress = adress; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = price; }
        }
        public House(string name, string surname, string secondname, string adress, double price)
        {
            this.name = name;
            this.surname = surname;
            this.secondname = secondname;
            this.adress = adress;
            this.price = price;
        }
    }
}
