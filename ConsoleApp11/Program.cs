using System.Numerics;

namespace ConsoleApp11
{
    internal class Program
    {
        #region q4
      static  void  Swap<T>(ref T v1,ref  T v2)
        {
            T temp=v1;
            v1= v2;
            v2= temp;

        }
        #endregion
        #region q5
        static T FindMax<T>(T[] VALUES) where T: INumber<T>
        {
            T max = VALUES[0];
            foreach (T value in VALUES)
            {
                if (value > max) max = value;
            }
            return max;
        }
        #endregion
        static void Main(string[] args)
        {
            #region q2
            Container<int> l = new Container<int>();
            l.Add(1);
            Console.WriteLine(l.Get(0));
            #endregion
            #region q3
            Pair<int, string> pair = new Pair<int, string>(0, "menna");
            Console.WriteLine(pair);
            #endregion
            #region Q4
            int x = 5;
            int y = 8;
            Swap(ref x,ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion
            #region Q5
            int[] values = {1,2,3,4,5,6,7};
            Console.WriteLine( FindMax(values)); //7
            #endregion


        }
    }

}
