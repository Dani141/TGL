
public class Task1{
    public int n;
    public Task1(int n){
     this.n=n;
    }
    public int factorialFunction(){
    List<int> numbers = Enumerable.Range(1,n).ToList();
    int factorial = numbers.Aggregate((x,y)=>x*y);
    return factorial;
    }
    public List<int> fibonacciFunction(){
     List<int> fibonacci = new List<int>();
     Enumerable.Range(0,n).ToList().ForEach (x=>fibonacci.Add((x<=1?1:fibonacci[x-2] + fibonacci[x-1])));
     return fibonacci;
    }
}
