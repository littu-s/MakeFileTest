using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class IterateNumbers
    {
        // Dictionary of divisors
        /*Dictionary<int, string> divisors = new Dictionary<int, string>()
                                            {
                                                {3,"Fizz"},
                                                {5, "Buzz"}
                                            };*/

        // Struct of Divisors
        public struct DivNumbers
        {
            public int key;
            public string value;

            public DivNumbers(int _key, string _value)
            {
                key = _key;
                value = _value;
            }
        }

        
        List<DivNumbers> _divisors = new List<DivNumbers>
                        {
                           new DivNumbers(3,"Fizz"),
                            new DivNumbers(5, "Buzz")
                        };

        public void UpdateDictionary()
        {
            // Update Dictionary items
            /* Removed as Overwriting is not allowed
            //divisors.Remove(5);
            //divisors.Add(5, "Buff");*/
            /*divisors.Add(6, "Six");
            divisors.Add(11, "Foo");*/

            // Update List of struct items
            _divisors.Add(new DivNumbers(5, "Buff"));
            _divisors.Add(new DivNumbers(6, "Six"));
            _divisors.Add(new DivNumbers(11, "Foo"));

            Display();
        }

        public void Display()
        {
            string result = "";

            //_divisors.Sort();
            _divisors.OrderBy(x => x.key).ToList();
            for (int i = 1; i <= 100; i++)
            {
                result = "";

                // Foreach loop for Dictionary items
                /*foreach (KeyValuePair<int, string> item in divisors)
                {
                    if (i % item.Key == 0)
                    {
                        result += item.Value + " ";
                    }
                }
                if (String.IsNullOrEmpty(result))
                {
                    result += i;
                }*/

                foreach (DivNumbers item in _divisors)
                {
                    if (i % item.key == 0)
                    {
                        result += item.value + " ";
                    }
                }
                if (String.IsNullOrEmpty(result))
                {
                    result += i;
                }
                Console.WriteLine(result);
            }
        }

        
    }
}
