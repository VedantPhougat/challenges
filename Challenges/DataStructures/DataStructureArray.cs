using static System.Console;

namespace Challenges.DataStructures
{
    public partial class DataStructure
    {
        /// <summary>
        /// Reverses a given array 
        /// Takes the following input ->
        /// 4
        /// 1 2 3 4 
        /// Expects following output ->
        /// 4 3 2 1
        /// </summary>
        public void ArrayInReverse()
        {
            var str = ReadLine() ?? "";
            if (string.IsNullOrEmpty(str))
            {
                return;
            }

            var count = int.Parse(str);
            str = ReadLine() ?? "";
            if (string.IsNullOrEmpty(str))
            {
                return;
            }

            var strArr = str.Split(' ');
            for (var i = count - 1; i >= 0; --i)
            {
                Write("{0} ", strArr[i]);
            }
        }
    }
}