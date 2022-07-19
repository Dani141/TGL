    // See https://aka.ms/new-console-template for more information
    namespace HelloWorld
    {
        class Program 
        {
            static void Main(string[] args)
            {
                /*//Task Lecture 3
                L3();*/

                //Task Practice 2
                P2();
            }
            public static void L3(){
                Task1 t1 = new Task1(6);

                System.Console.WriteLine("Factorial");
                System.Console.WriteLine(t1.factorialFunction());

                System.Console.WriteLine("Fibonacci");
                List<int> l=t1.fibonacciFunction();
                l.ForEach(i=>Console.WriteLine("{0}",i));
            }
            public static void P2(){
                
                LogicEvents le = new LogicEvents();

                System.Console.WriteLine("Enter username: ");
                string username=Console.ReadLine();
                PersonUser pu = new PersonUser(username); 
                le.AccountCreation(); 

                Charada ch = new Charada(pu);
                System.Console.WriteLine(ch.Description);
                System.Console.WriteLine("\nThese are the meanings associated with each number.\nWhat do you want in your life? choose the one you want to bet, you have 25 points");
                
                int outGame=0;
                int input =0;
                int investment=0;

                do{
                le.StartsGame();    
                ch.Numbers.ForEach(i=>Console.WriteLine("{0}",i));      

                do{
                    Boolean again=false;

                    do{
                System.Console.WriteLine("Enter your bet:");
                try{
                    int betNumber=int.Parse(System.Console.ReadLine());
                    if(betNumber>10 || betNumber<0){
                    le.DataEntryError();
                    again=true;
                    }
                    else{
                    ch.PersonUser.NumbersBet.Add(betNumber);
                    again=false;
                    }
                }catch{
                le.DataEntryError();
                again=true;
                };
                } while (again);

                do{
                System.Console.WriteLine("Enter the amount of points to bet on that number\n you have "+ch.PersonUser.Point+" points");
                try{
                int money=int.Parse(System.Console.ReadLine());
                if(money>ch.PersonUser.Point){
                le.DataEntryError();
                again=true;
                }
                else{
                investment+=money;
                ch.PersonUser.PointsBet.Add(money);
                ch.PersonUser.Point=ch.PersonUser.Point-money;
                again=false;
                }
                }catch{
                    le.DataEntryError();
                    again=true;
                };
                } while (again);

                le.BetMade();
                
                do{
                System.Console.WriteLine("Enter 0 to finish");
                try{
                input=int.Parse(System.Console.ReadLine());
                }catch{
                    le.DataEntryError();
                    again=true;
                }
                } while (again);

                } while (input!=0);
                
                int winNumber=new Random().Next(1,99);
                System.Console.WriteLine("The winning number is "+ winNumber);
                int result = pu.Result(investment,winNumber);
                System.Console.WriteLine("You win "+ result);
                
                System.Console.WriteLine("Enter 0 to finish");
                outGame=int.Parse(System.Console.ReadLine());
                    
                } while (outGame!=0);
            }
                        
        }
        public delegate void Notify();  // delegate

        public class LogicEvents {
        public event Notify NotifyAccountCreation; // event
        public event Notify NotifyStartGame;
        public event Notify NotifyError;
        public event Notify NotifyBetMade;

        //Notify Account Creation
        public void AccountCreation()
        {
            Console.WriteLine("Account Created!\n");
            OnNotifyAccountCreation();
        }

        protected virtual void OnNotifyAccountCreation() //protected virtual method
        {
            NotifyAccountCreation?.Invoke(); 
        }

        //Start Game
        public void StartsGame()
        {
            Console.WriteLine("Starts the Game!\n");
            OnNotifyStartsGame();
        }

        protected virtual void OnNotifyStartsGame() //protected virtual method
        {
            NotifyStartGame?.Invoke(); 
        }

        //Data Entry Error
        public void DataEntryError()
        {
            Console.WriteLine("Data Entry Error!\nEnter only numbers and stay within the traits described\n");
            OnNotifyError();
        }

        protected virtual void OnNotifyError() //protected virtual method
        {
            NotifyError?.Invoke(); 
        }

        //Notify Bet Made
        public void BetMade()
        {
            Console.WriteLine("Bet Made Successfully!\n");
            OnNotifyBetMade();
        }

        protected virtual void OnNotifyBetMade() //protected virtual method
        {
            NotifyBetMade?.Invoke(); 
        }
    }
    }