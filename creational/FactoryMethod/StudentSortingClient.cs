using System;
using System.Collections.Generic;

namespace FactoryMethod
{
  public class StudentSortingClient: SortingClient
  {
    private Random _random = new Random();

    private static List<string> _students = new List<string>()
    {"Nico", "Seba", "Cristobal", "Jose", "Paula"};

    public StudentSortingClient(int numberStudent): base(numberStudent)
    {
    }

    protected override IIndexedItem BuildItem()
    {
      var name = _students[_random.Next(_students.Count)];
      var index = _random.Next(100);
      return new Student(name, index);
    }
  }
}