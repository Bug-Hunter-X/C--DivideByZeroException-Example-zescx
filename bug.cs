public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Some code here
        int x = 5;
        int y = 0;
        int z = x / y; // Potential for DivideByZeroException
        // More code here
    }
}