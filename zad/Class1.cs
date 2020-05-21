using System;
using System.Collections.Generic;
using System.Text;

namespace zad
{
    public enum gender
    {
        boy,
        girl
    }
    class person
    {
        public string name { get; set; } 
        public int age { get; set; }

        public gender persongender;

        public person(string name , int age , gender persongender)
        {
            this.name = name;
            this.age = age;
            this.persongender = persongender;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\tAge : {1}\tGender: {2}", name, age, persongender);
        }




    }

    

}
