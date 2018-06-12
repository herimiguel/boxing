using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
        List<object> box = new List<object>();
        box.Add(7);
        box.Add(28);
        box.Add(-1);
        box.Add(true);
        box.Add("chair");

        for(int i = 0; i<box.Count; i++){
            Console.WriteLine(box[i]);
        }
            int sum = 0;
            foreach (var x in box){
                if(x is int){
                    sum += (int)x;
                }
        }Console.WriteLine(value: "The sum of the box is" + sum);
        }
    }
}
