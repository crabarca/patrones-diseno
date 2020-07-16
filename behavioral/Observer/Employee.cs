using System;
using System.Collections.Generic;

namespace Observer
{
    public class Employee
    {
        public string Name { get; }

        public int Income
        {
            get => _income;
            set
            {
                var oldIncome = _income;
                _income = value;

                foreach (var listener in _listeners)
                {
                    listener.OnIncomeChanged(oldIncome, _income);
                }

                if (OnIncomeChanged != null)
                {
                    OnIncomeChanged.Invoke(oldIncome, _income);
                }
            }
        }

        private int _income;
        private List<IEmployeeListener> _listeners;

        public Employee(string name, int income)
        {
            Name = name;
            _income = income;
            _listeners = new List<IEmployeeListener>();
        }

        public void AddListener(IEmployeeListener listener)
        {
            _listeners.Add(listener);
        }

        public interface IEmployeeListener
        {
            void OnIncomeChanged(int oldIncome, int newIncome);
        }

        public event Action<int, int> OnIncomeChanged;
    }
}