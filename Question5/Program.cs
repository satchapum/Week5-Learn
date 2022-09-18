class Program {

    public static int InputAllInfo(ref List<string> Positionlist, ref List<int> BElist, int RoundCount, int LowerBECheck) {
        Console.Write("Please input position : ");
        string PositionInput = Console.ReadLine();

        Console.Write("Please input B.E. : ");
        int BEInput = int.Parse(Console.ReadLine());

        if(BEInput <= 2564) {
            Positionlist.Add(PositionInput);
            BElist.Add(BEInput);
            if(BEInput <= BElist[RoundCount-1]) {
                LowerBECheck = CalMinBE(RoundCount,Positionlist,BElist,BEInput); 
            }
            return InputAllInfo(ref Positionlist,ref BElist, RoundCount+1, LowerBECheck);
        } 
        else {
            Positionlist.Add(PositionInput);
            BElist.Add(BEInput);

            return LowerBECheck;
        }
    }

    public static int CalMinBE(int RoundCount, List<string> Positionlist, List<int> BElist, int BEInput) {
            int LowerBECheck;
            LowerBECheck = RoundCount;
            return LowerBECheck;
    }

    public static void Main(string[] args) {
        
        List<string> Positionlist = new List<string>();
        List<int> BElist = new List<int>();

        Positionlist.Add("nothing");
        BElist.Add(2565);

        int RoundCount = 1;
        int LowerBECheck = 0;
        int LowerBE = InputAllInfo(ref Positionlist,ref BElist,RoundCount,LowerBECheck);

        
        PrintSummary(Positionlist, BElist, LowerBE);
    }

    public static void PrintSummary(List<string> Positionlist, List<int> BElist, int LowerBE) {
        int MaxCountPosition = Positionlist.Count-1;
        int MaxCountBE = BElist.Count-1;


        Console.WriteLine(Positionlist[LowerBE]);
        Console.WriteLine(BElist[LowerBE]);
        Console.WriteLine(Positionlist[MaxCountPosition]);
        Console.WriteLine(BElist[MaxCountBE]);
        int WorkingPeriod = BElist[MaxCountBE] - BElist[LowerBE] + 1;
        Console.WriteLine("Working period is : {0}",WorkingPeriod);
        
    }
}