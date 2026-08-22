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
        static void Main(string[] args)
        {
            #region q2
            Container<int> l = new Container<int>();
            l.Add(1);
            Console.WriteLine(l.Get(0));
            #endregion
            #region q3
            Pair<int, string> pair = new Pair<int, string>(0, "menna");
            Console.Write(pair);
            #endregion
            #region Q4
            int x = 5;
            int y = 8;
            Swap(ref x,ref y);
            Console.WriteLine(x);
            Console.WriteLine(y); 
            #endregion 

        }
    }

}
