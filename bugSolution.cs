public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod(int y)
    {
        // Some code here
        int x = 5;
        int z = 0;
        if (y != 0)
        {
            z = x / y; 
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        // More code here
    }
}