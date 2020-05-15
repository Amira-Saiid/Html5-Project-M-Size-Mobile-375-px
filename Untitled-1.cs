using System;
class MainClass
{
    public static void Main (string[] args){
        float a= float.Parse(Console.Readline());
        float b= float.Parse(Console.Readline());
         float c= float.Parse(Console.Readline());
  }

  public static void Quadratic(float a,float b,float c){
      double Root=Math.Sqrt(b*b-4*a*c);

      if(root >= 0){
          double x1= (-b + root) / 2*a;
          double x2=(-b - root) / 2*a;

          System.Console.WriteLine( "x1= "+ x1 + "x2= "+ x2 );
      }
      else
      {
          System.Console.WriteLine("No roots");
      }
  }

}

