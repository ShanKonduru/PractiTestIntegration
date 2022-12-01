namespace MyCalc;
public static class Calculator
{
    public static int Add(int operand1, int operand2)
    {
        return operand1 + operand2;
    }

    public static int Sub(int operand1, int operand2)
    {
        return operand1 - operand2;
    }

    public static int Mul(int operand1, int operand2)
    {
        return operand1 * operand2;
    }

    public static float Div(float operand1, float operand2)
    {
        float result = operand1 / operand2;
        return result;
    }

    public static bool FloatNearlyEqual(float a, float b, float epsilon)
    {
        const float MinNormal = float.MinValue;
        float absA = Math.Abs(a);
        float absB = Math.Abs(b);
        float diff = Math.Abs(a - b);

        if (a.Equals(b))
        { // shortcut, handles infinities
            return true;
        }
        else if (a == 0 || b == 0 || absA + absB < MinNormal)
        {
            // a or b is zero or both are extremely close to it
            // relative error is less meaningful here
            return diff < (epsilon * MinNormal);
        }
        else
        { // use relative error
            return diff / (absA + absB) < epsilon;
        }
    }

    public static bool DoubleNearlyEqual(double a, double b, double epsilon = 0.00000000001)
    {
        const double MinNormal = 2.2250738585072014E-308d;
        double absA = Math.Abs(a);
        double absB = Math.Abs(b);
        double diff = Math.Abs(a - b);

        if (a.Equals(b))
        { // shortcut, handles infinities
            return true;
        }
        else if (a == 0 || b == 0 || absA + absB < MinNormal)
        {
            // a or b is zero or both are extremely close to it
            // relative error is less meaningful here
            return diff < (epsilon * MinNormal);
        }
        else
        { // use relative error
            return diff / (absA + absB) < epsilon;
        }
    }
}
