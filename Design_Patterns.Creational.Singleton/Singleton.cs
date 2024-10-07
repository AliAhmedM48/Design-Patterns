namespace Design_Patterns.Creational.Singleton;

internal class Singleton
{

    /*
     * The private constructor: Prevents creating multiple instances of the object.
     * We use the GetInstance() method to control when and how the single instance is created.
     * This guarantees that the Singleton pattern provides global access to a single instance of the class and prevents multiple instances from being created.
     */

    private static Singleton? instance = null;
    public string Data { get; private set; }

    // Since this constructor is private, it cannot be called from outside the class. This ensures that no one can create a new instance except the class itself.
    // In the Singleton pattern, we want to ensure that only one instance of the class exists
    // throughout the lifetime of the program, so we don’t want any code to be able to create new instances directly with new.
    // Here, it’s used to initialize the Data property with a value when the single instance of the Singleton class is created.
    private Singleton()
    {
        Data = "I am the only instance";
    }

    public static Singleton GetInstance()
    {
        if (instance is null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void SetData(string value)
    {
        Data = value;
    }
}
