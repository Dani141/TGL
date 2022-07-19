
    public class PersonUser{

        private string nickname;
        private int points;
        private List<int> numbersBet = new List<int>();
        private List<int> pointsBet = new List<int>();
    
        public PersonUser(string nickname){
        this.nickname=nickname;
        this.points=25;
        }

        public string Nickname{
            get{
                return nickname;
            }
            set{
                nickname=value;
            }
        }

        public int Point{
            get{
                return points;
            }
            set{
                points=value;
            }
        }

        public List<int> NumbersBet{
            get{
                return numbersBet;
            }
            set{
                numbersBet=value;
            }
        }

        public List<int> PointsBet{
            get{
                return pointsBet;
            }
            set{
                pointsBet=value;
            }
        }
    
        public int Result(int investment, int winNumber){
        int points=0;   
        int unit = winNumber%10;
        int tens=winNumber/10;
        int index = numbersBet.IndexOf(winNumber);
        if(index!=-1){
            points+=30*pointsBet.ElementAt(index);
        }
        index=numbersBet.IndexOf(unit);
        if(index!=-1){
            points+=5*pointsBet.ElementAt(index);
        }
        index=numbersBet.IndexOf(tens);
        if(index!=-1){
            points+=10*pointsBet.ElementAt(index);
        }
        return points-investment;
        }
    }