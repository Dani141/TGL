
public class Triangle: Figure{
    
    public double A {get;}
    public double B {get;}
    public double C {get;}


    public Triangle(double a, double b, double c){
      A=a;
      B=b;
      C=c;
    }
    public override double CalculateArea(){
        var p = CalculatePerimeter() / 2;
        return  Math.Sqrt(p*(p-A)*(p-B)*(p-C));
    }
    public override double CalculatePerimeter(){
        return A+B+C;
    }
}