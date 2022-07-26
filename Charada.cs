    public class Charada{
        private string description;
        private List<string> numbers = new List<string>();
        private PersonUser pu;

        public Charada(PersonUser pu){
        
            this.pu=pu;

            description="welcome to the Charada...\nCharada is a gambling game in which you try to guess a number between 1 and 10, associated with a meaning.The winning number contains two figures.\n1. if you guess the number of units you will get 5 points for each point wagered\n2. if you hit the number of tens you will get 10 points for each point wagered\n3. If exactly the bet number comes out, you will get 30 points for each obtained.\nyou can bet as many numbers as you want, good luck :)";

            numbers.Insert(0,"1. Sea - Padlock");
            numbers.Insert(1,"2. Horse - Sun - Camel");
            numbers.Insert(2,"3. Love");
            numbers.Insert(3,"4. Moon - Money");
            numbers.Insert(4,"5. Money - Boat");
            numbers.Insert(5,"6. Key");
            numbers.Insert(6,"7. Dream - Knight");
            numbers.Insert(7,"8. Work");
            numbers.Insert(8,"9. Family - Health");
            numbers.Insert(9,"10. Moon - Plane");
        }
        public string Description{
            get{
                return description;
            }
        }

        public List<String> Numbers{
            get{
                return numbers;
            }
        }
        public PersonUser PersonUser{
            get{
                return pu;
            }
            set{
                pu=value;
            }
        }
    }