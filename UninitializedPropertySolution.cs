public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Assign a default value to MyProperty during declaration
        MyProperty = 0; 

        Console.WriteLine(MyProperty); // This will now print the initialized value 0

        MyProperty = 10;
        Console.WriteLine(MyProperty); // This will still print 10
    }
}