using System;

namespace KT_Container
{
    public class StringContainer : Container<string>
    {
        public void PrintAllUpper()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToUpper());
            }
        }
    }
}