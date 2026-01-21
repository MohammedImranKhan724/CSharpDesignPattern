using Singleton;

Console.WriteLine("LazySingleton: " + (LazySingleton.GetInstance() == LazySingleton.GetInstance()));
Console.WriteLine("ThreadSafeSingleton: " + (ThreadSafeSingleton.GetInstance() == ThreadSafeSingleton.GetInstance()));
Console.WriteLine("DoubleCheckedLockingSingleton: " + (DoubleCheckedLockingSingleton.GetInstance() == DoubleCheckedLockingSingleton.GetInstance()));
Console.WriteLine("EagerSingleton: " + (EagerSingleton.GetInstance() == EagerSingleton.GetInstance()));
Console.WriteLine("StaticBlockSingleton: " + (StaticBlockSingleton.GetInstance() == StaticBlockSingleton.GetInstance()));
Console.WriteLine("BillPughSingleton: " + (BillPughSingleton.GetInstance() == BillPughSingleton.GetInstance()));
Console.WriteLine("ModernSingleton: " + (ModernSingleton.GetInstance() == ModernSingleton.GetInstance()));

Console.ReadKey();