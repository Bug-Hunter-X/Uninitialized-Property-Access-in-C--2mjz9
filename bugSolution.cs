public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize MyProperty in the constructor
        MyProperty = 0; // Or another appropriate default value
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; 
    }
}