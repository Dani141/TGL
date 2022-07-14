
public class Circule: Figure{
    
    public double Radius;

    public Circule(double radius){
      Radius=radius;
    }
    public override double CalculateArea(){
        return  Math.PI*Math.Pow(Radius,2);
    }
    public override double CalculatePerimeter(){
        return 2*Math.PI*Radius;
    }
}