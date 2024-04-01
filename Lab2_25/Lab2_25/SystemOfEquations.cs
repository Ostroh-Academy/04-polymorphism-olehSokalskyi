namespace Lab2_25;

public class SystemOfEquations
{
    protected double[,] coefficients { get;}
    protected double [] terms { get; }

    public SystemOfEquations(double[,] coefficients, double[] terms)
    {
        this.coefficients = coefficients;
        this.terms = terms;
    }

    public void PrintEquationSystem()
    {
        for (int i = 0; i < coefficients.GetLength(0); i++)
        {
            for (int j = 0; j < coefficients.GetLength(1); j++)
            {
            
                if (j != coefficients.GetLength(1) - 1)
                {
                    Console.Write($"{coefficients[i, j]} * x{j + 1} + ");
                }
                else
                {
                    Console.Write($"{coefficients[i, j]} * x{j + 1} ");
                }
            }
            Console.WriteLine($"= {terms[i]}");
        }
        Console.WriteLine();
    }

    public virtual bool CheckVectorSatisfies(double[] data)
    {
        if(data.Length != coefficients.GetLength(1))
        {
            return false;
        }
        for(int i = 0 ; i< coefficients.GetLength(0); i++)
        {
            double sum = 0;
            for(int j = 0; j < coefficients.GetLength(1); j++)
            {
                sum += coefficients[i, j] * data[j];
            }
            if(Math.Abs(sum - terms[i]) > 1e-6)
            {
                return false;
            }
        }
        return true;
    }
}