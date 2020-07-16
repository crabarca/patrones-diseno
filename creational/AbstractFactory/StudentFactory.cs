using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class StudentFactory: IFactory<Student>
    {
        private Random _random = new Random();
        private static List<string> _names = new List<string>
            {"Alvaro", "Bruno", "Carlos", "Daniel", "Esteban"};
        
        public Student BuildItem()
        {
            var name = _names[_random.Next(_names.Count)];
            var id = _random.Next(1000);
            
            return new Student(name, id);
        }
    }
}