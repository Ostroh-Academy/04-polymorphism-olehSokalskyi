namespace Lab2_25;

public class LinearEquation: SystemOfEquations
{
    public LinearEquation(double[,] coefficients, double[] terms) : base(coefficients, terms){}


    public override bool CheckVectorSatisfies(double[] x)
    {
        if (x.Length != 3)
        {
            return false;
        }

        return base.CheckVectorSatisfies(x);
    }
}