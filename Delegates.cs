namespace Day10CSharp
{
    public delegate string StringTransformer(string input);

    public delegate int MathOperation(int a, int b);

    public delegate R GenericTransformer<T, R>(T input);
}
