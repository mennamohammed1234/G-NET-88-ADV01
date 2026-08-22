namespace ConsoleApp11
{
    internal class Program
    {
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

        }
    }

}
