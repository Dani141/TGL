
public class Rectangle: Figure{
    
    public double A {get;}
    public double B {get;}

    public Rectangle(double a, double b){
      A=a;
      B=b;
    }
    public override double CalculateArea(){
        return  A*B;
    }
    public override double CalculatePerimeter(){
        return 2*(A+B);
    }
}