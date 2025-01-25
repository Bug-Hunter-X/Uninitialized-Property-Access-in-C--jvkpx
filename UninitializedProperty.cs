public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned a value can lead to unexpected behavior.
        Console.WriteLine(MyProperty); // This line will print 0

        // Assigning a value to MyProperty after it was accessed
        MyProperty = 10;
        Console.WriteLine(MyProperty); // This will print 10
    }
}