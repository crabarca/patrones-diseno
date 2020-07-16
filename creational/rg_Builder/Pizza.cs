using System;
using System.Collections.Generic;

namespace rg_Builder
{
    class Pizza
    {
      private List<string> _parts = new List<string>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListIngredients()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}