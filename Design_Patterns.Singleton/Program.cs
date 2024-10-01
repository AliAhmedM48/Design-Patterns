namespace Design_Patterns.Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        #region Demo

        //var instance1 = Singleton.GetInstance();
        //var instance2 = Singleton.GetInstance();
        //Console.Write("ReferenceEquals(instance1, instance2): ");
        //Console.WriteLine(object.ReferenceEquals(instance1, instance2));

        //// ------------------------------------------------------------------------

        //Console.WriteLine("--------------------------------------");
        //Console.Write("instance1.Data: ");
        //Console.WriteLine(instance1.Data);

        //Console.Write("instance2.Data: ");
        //Console.WriteLine(instance2.Data);
        //// ------------------------------------------------------------------------

        //Console.WriteLine("\nAfter udating instance1\n");

        //instance1.SetData("Updated Singleton instance!");

        //// ------------------------------------------------------------------------
        //Console.Write("instance1.Data: ");
        //Console.WriteLine(instance1.Data);

        //Console.Write("instance2.Data: ");
        //Console.WriteLine(instance2.Data);
        //// ------------------------------------------------------------------------

        //Console.WriteLine("--------------------------------------");

        #endregion

        #region Logging System

        // Getting the single instance of Logger
        Logger logger1 = Logger.GetInstance();
        logger1.LogMessage("Application started");

        // Later in the application, another part of the system wants to log something
        Logger logger2 = Logger.GetInstance();
        logger2.LogMessage("User logged in");

        //Console.WriteLine(object.ReferenceEquals(logger1, logger2));

        #endregion


    }
}
