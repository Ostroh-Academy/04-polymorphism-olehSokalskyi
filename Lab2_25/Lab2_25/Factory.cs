namespace Lab2_25;

public abstract class Factory
{
  public abstract SystemOfEquations FactoryMethod();
}

public class FactoryA(): Factory
{
  public override SystemOfEquations FactoryMethod()
  {
    double[,] coefficients2x2 = new double[,] { { 2, 3 }, { 4, 5 } };
    double[] freeTerms2x2 = new double[] { 7, 11 };
    return new SystemOfEquations(coefficients2x2, freeTerms2x2);
  }
}

public class FactoryB() : Factory
{
  public override SystemOfEquations FactoryMethod()
  {
    double[,] coefficients3x3 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    double[] freeTerms3x3 = new double[] { 6, 15, 24 };
    return new LinearEquation(coefficients3x3, freeTerms3x3);
  }
}