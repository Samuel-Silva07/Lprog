// primeiro trabalho de linguagem de programação
using System;

class Aula1 {
static double f(double x,
          double a,
          double b,
          double c){ 
    double y = a*Math.Pow(x,2) + b*x + c;
    return y;
  }
static double [] zeros(
  double a,
  double b,
  double c,{
  double[] z = new double[2];
  double delta = Math.Pow(b,2)-4*a*c;
  if (delta >= 0){
    z[0] = (-b + Math.Sqrt(delta))/(2*a);
    z[1] = (-b + Math.Sqrt(delta))/(2*a)
  }
  return z;
  }
)
  
public static void Main (string[] args)  {
  // int v = 0;
  // Console.writeline (v);
  // double y = f(1,2,3,4);
  // Console.WriteLine(y);
  Console.WriteLine("Digite o valor de x");
  double  x = double.Parse(
    Console.ReadLine ()
    );
    y = false(x,2,3,4);
  Console.WriteLine (y);  
  }
}