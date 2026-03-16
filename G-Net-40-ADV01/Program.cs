using G_Net_40_ADV01.Constraines;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace G_Net_40_ADV01
{
    public class User { public string Name { get; set; } = ""; }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?
            // Generic:     ddefined  class  , stuct ,  interface , method without integrate with  Specific DT .
            //  Why use generics?
            // 1-  Solve Problem  Repeat same code but different datatype 
            // 2-  Solve problem  Coupling   code to  specific DT  
            // 3- make Preformance Good  .
            // 4- IntelliSense Better for IDE

            #endregion
            #region  Q2
            //Q2: Write a generic class Container<T> with Add and Get methods.
            ContainerGeneric<int> Object1 = new ContainerGeneric<int>(10);
            Object1.Add(300);
            Console.WriteLine(Object1.Get());

            ContainerGeneric<string> Object2 = new ContainerGeneric<string>("Ahmed Ramzy");
            Object2.Add("Saeed");
            Console.WriteLine(Object2.Get());
            Console.WriteLine(new string('-' ,  70));

            #endregion
            #region Q3

            //Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            //  multiple type parameters: Class or container contain  multiple  Tempalates using in Containers

            Pairs<string, int> objectpair = new Pairs<string, int>("Ahmed", 10);
            Console.WriteLine(objectpair);

            Pairs<char, int> objectpair1 = new Pairs<char, int>('C', 10);
            Console.WriteLine(objectpair1);
            Console.WriteLine(new string('-', 70));
            #endregion
            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.

            //  generic method :  method Can  make same code wiht any  data type  
            int x = 10, y = 20;
            Console.WriteLine($"Before Swap  x : {x} , y  : {y}");
            BuildInGeneric.Swap<int>(ref x,  ref y);
            Console.WriteLine($"After Swap  x : {x} , y  : {y}");


            string x1 = "abc", y1 = "dfg";
            Console.WriteLine($"Before Swap  x1 : {x1} , y1  : {y1}");
            BuildInGeneric.Swap<string>(ref x1, ref y1);
            Console.WriteLine($"After Swap  x1 : {x1} , y1  : {y1}");
            Console.WriteLine(new string('-', 70));

            #endregion
            #region Q5
            // Q5: Write a generic method FindMax<T> that finds maximum value

            int[] arr = { 10 ,1 , 20  , 30};
            Console.WriteLine($"Max VAlue : {BuildInGeneric.FindMax<int>(arr)}");
            char[] arr1 = { 'a', 'd', 'k', 'z' };
            Console.WriteLine($"Max VAlue : {BuildInGeneric.FindMax<char>(arr1)}");
            Console.WriteLine(new string('-', 70));
            #endregion
            #region Q6
            // Q6: What is a generic interface? Write IRepository<T>.
            // generic interface :  interface  contain  method  without integrate with  Specific DT .
            StackGeneric stack = new StackGeneric();
            stack.Push("Ahmed"); 
            stack.Push("Saeed");
            Console.WriteLine($"Peek : {stack.Peek()}");
            Console.WriteLine(new string('-', 70));

            #endregion
            #region Q7

            //Q7: What is the 'struct' constraint? Write an example.
            //struct restricts T take DT inhertiance from  Struct  only , for example  int , char , bool  and also  user defined struct
            StuctConstraines<int> SC =  new StuctConstraines<int>(10);
            Console.WriteLine(SC.Get());

            StuctConstraines<char> SC1 = new StuctConstraines<char>('A');
            Console.WriteLine(SC1.Get());

            //  StuctConstraines<string> SC2 = new StuctConstraines<string>("Ahmed"); =>  this error because string not struct
            Console.WriteLine(new string('-', 70));
            #endregion
            #region  Q8
            //What is the 'class' constraint? Write an example.
            // class restricts T take DT inhertiance from  class  only , for example  string  and also  user defined class
            ClassConstraines<string> CC = new ClassConstraines<string>("Ahmed");
            Console.WriteLine(CC.Get());

            //  ClassConstraines<int> CC1 = new ClassConstraines<int>(123); => this error because int not class
            Console.WriteLine(new string('-', 70));

            #endregion
            #region Q9
            // Q9: What is the 'new()' constraint? Write an example.
            // new() restricts T to have a public parameterless constructor, allowing you to create instances of T within the generic class or method.
            NewConstraines<User> NC = new NewConstraines<User>();
            NC.Display();
            Console.WriteLine(new string('-', 70));
            #endregion
            #region Q10

            // Q10: What is the interface constraint? Write an example.
            // interface constraint restricts T to implement a specific interface, ensuring that T has certain methods or properties defined by that interface.
            InterfaceConstriances<int> IC = new InterfaceConstriances<int>();
            IC.Compare(10, 20);
            IC.Compare(30, 30);
            IC.Compare(40, 30);
            Console.WriteLine(new string('-', 70));





            #endregion
            #region Q11
            // Q11: What is the base class constraint? Write an example.
            // base class constraint restricts T to inherit from a specific base class, ensuring that T has the properties and methods defined in that base class.
            BaseConstrainces<User> BC = new BaseConstrainces<User>();
            BC.Display();
            Console.WriteLine(new string('-', 70));

            #endregion
            #region Q12
            // Q12: How do you apply multiple constraints? Write an example.
            // You can combine multiple constraints for a single type parameter, and have different constraints for different type parameters.

            MultiContrainces<int> MC = new MultiContrainces<int>();
            MC.Display();
            MC.Compare(10, 20);
            MC.Compare(30, 30);
            MC.Compare(40, 30);
            Console.WriteLine(new string('-', 70));


            #endregion
            #region Q13
            //Q13: What does the 'default' keyword do in generics ?
            // default : returns the default value for type T: null for reference types, 0or false for value types.
            #endregion
            #region Q14

            //  Q14: Write a SafeList<T> that returns default when the index is invalid.
            SafeList<int> SL = new SafeList<int>();
            SL.Add(10);
            SL.Add(30);
            Console.WriteLine(SL.Get(0));
            Console.WriteLine(SL.Get(10));


            SafeList<bool> SL1 = new SafeList<bool>();
            SL1.Add(true);
            SL1.Add(true);
            Console.WriteLine(SL1.Get(0));
            Console.WriteLine(SL1.Get(10));

            SafeList<string> SL2 = new SafeList<string>();
            SL2.Add("abc");
            SL2.Add("def");
            Console.WriteLine(SL2.Get(0));
            Console.WriteLine(SL2.Get(10)?? "This is NULL");

            Console.WriteLine(new string('-', 70));






            #endregion
            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            // covariance:  allows you to use a more derived type than originally specified,
            // 'out' keyword is used to indicate that a type parameter is covariant, meaning it can be substituted with a more derived type.

            #endregion
            #region Q16
            // Q16: What is contravariance? Explain the 'in' keyword.
            // contravariance: allows you to use a less derived type than originally specified,
            // 'in' keyword is used to indicate that a type parameter is contravariant, meaning it can be substituted with a less derived type.
            #endregion
            #region Q17
            //Q17: What is the difference between covariance and contravariance?


            //    Covariance => out  ,    Contravariance => in
            //  Covariance =>  Derived --> Base
            //  Contravariance => Base --> Derived
            //  Covariance => Output only(return)	
            //Contravariance => Input only(parameter)

            #endregion
            #region Q18
            // Q18: How do static members work in generic types ?
            // Each closed generic type has its own copy of static fields
            //  for example when make int  this mean in craete static  memeber related jsut DT int 
            //  and also  string ,  char 


            #endregion
            #region Q19
            // Q19: How can you inherit from a generic class?
            // Generic classes can inherit from other generic or non-generic classes. 
            //  1- Inherit and Pass Type Parameter 
            //  2- Inherit with Concrete Type
            //  3- Add New Type Parameter
            #endregion
            #region Q20

            // Q20: Complete Exercise -Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
            GenericCache<string, string> cache = new GenericCache<string, string>();
            cache.Add("key1", "value", TimeSpan.FromSeconds(10));
            cache.Add("key2", "value2", TimeSpan.FromSeconds(5));
            cache.Add("key3", "value3", TimeSpan.FromSeconds(15));
            Console.WriteLine(cache.Get("key1"));
            Console.WriteLine(cache.Contains("key1"));
            Console.WriteLine(cache.CheckExpirationDate("key1"));
            System.Threading.Thread.Sleep(11000); //  use this to make key1 expired
            Console.WriteLine(cache.CheckExpirationDate("key1"));
            Console.WriteLine(new string('-', 70));


            #endregion
        }
    }
}
