using Microsoft.VisualBasic;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata;

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
            #region q7
            StructConstraint<int> s = new StructConstraint<int>(2, 4);
            Console.WriteLine(s);
            #endregion
            #region q8
            Classconstraint<String> c = new();
            c.Add("a");
            #endregion
            #region q9
            //The new() constraint specifies that the generic type must have a public parameterless constructor,
            //allowing us to create an object of type T using new T().
          Container<Animal> container = new Container<Animal>();
#endregion
            #region Q14
            Safelist<int> list = new(6);
            list.Add(1);
            list.Add(2);
            list.Add(3);
          Console.WriteLine(  list.Getbyindex(1)); //2
            Console.WriteLine(list.Getbyindex(4)); // DEFAULT 0

            #endregion

            #region q11
            Animal animal = new Animal();
            AnimalSound<Animal>animalSound= new AnimalSound<Animal>();
            animalSound.MakeSound(animal);

            Cat cat = new Cat();
            AnimalSound<Cat> catSound = new AnimalSound<Cat>();
            animalSound.MakeSound(cat);


            //     AnimalSound<Pair<int,string> cSound = new AnimalSound<Pair<int,string>>(); error cuse class pair not ihhrit from animal


            #endregion
            #region q12
            //You can apply multiple constraints using the where keyword.Multiple constraints are separated by commas.
            Multiconstrain<Animal> multiconstrain = new Multiconstrain<Animal>(); // class and has paramterless constructor
            #endregion
            #region q13
            //The default keyword returns the default value of the generic type T
            #endregion
            #region Q16
            Iprocessor <Cat> processor = new AnimalPreocess();
            cat.Name = "c0";
            processor.Process(cat);

            #endregion
            #region q15
            Ipreocess2<Animal> ipreocess2 = new Cat_preocess();
          Console.WriteLine(  ipreocess2.Get().Name); // 
            #endregion
            #region q17
            //  Covariance(out): works with output /return types and allows derived → base.
            //Contravariance(in): works with input / parameters and allows base → derived.
            #endregion
            #region q18
       //     Static members in a generic class are separate for each type argument.
            Counter<int>.COUNT = 1;
            Counter<Animal>.COUNT = 2;
            Console.WriteLine(Counter<int>.COUNT);//1
            Console.WriteLine(Counter<Animal>.COUNT);//2
            #endregion
            #region q19
            //You can inherit from a generic class by specifying the type parameter in the derived class
            Child_Pair child_Pair = new Child_Pair(5, "Menna");
            Console.Write(child_Pair);

            #endregion

        }
    }

}
