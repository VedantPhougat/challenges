using System;
using Challenges.Interfaces;

namespace Challenges.Implementations
{
    public static class DataStructure : IDataStructure
    {
        public void ArrayInReverse()
        {
            var str = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(str)) return;
            
            var arr = new int[int.Parse(str)];

            for (var i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            for (var i = arr.Length - 1; i <= 0; --i)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }
    }
}