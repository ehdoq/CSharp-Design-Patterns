namespace _06_Adapter.Classes
{
    //Bu sınıf NuGet paketiyle gelen sınıftır. Bu sınıfa herhangi bir işlem yapmak için Adapter Design Pattern'ini kullanırız.
    public class Log4Net
    {
        public void Log4NetLogging(string mesaj)
        {
            Console.WriteLine($"Loglandı, Log4NetLogging, {mesaj}");
        }
    }
}