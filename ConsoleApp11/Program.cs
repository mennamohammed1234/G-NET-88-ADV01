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
        }
    }
}
