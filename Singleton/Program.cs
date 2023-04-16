
using Singleton;

SingletonClass singletonClass = SingletonClass.GetInstance();
SingletonClass singletonClass2 = SingletonClass.GetInstance();

Console.WriteLine(singletonClass.GetHashCode());
Console.WriteLine(singletonClass2.GetHashCode());

NoSingletonClass noSingletonClass = new NoSingletonClass();
NoSingletonClass noSingletonClass2 = new NoSingletonClass();

Console.WriteLine(noSingletonClass.GetHashCode());
Console.WriteLine(noSingletonClass2.GetHashCode());


Console.ReadKey();
