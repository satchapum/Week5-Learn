class Program {

    public static string InputRound() {
        Console.Write("please input round : ");
        
        return Console.ReadLine();
    }
    
    public static int ConvertStringToint(string RoundText) {
        int.TryParse(RoundText, out int number);
        
        return number;
    }

    static void Main(string[] args) {
        string RoundText = InputRound();
        int RoundNumber = ConvertStringToint(RoundText);
        string HamletOutput = hamletCal(RoundNumber);

        PrintHamlet(HamletOutput);
    }

    public static string hamletCal(int Round) {
        if(Round != 0) {
            return "hamlet\n" + hamletCal(Round-1);
        }
        return "";
    }

    public static void PrintHamlet(string hamletCount) {
        Console.Write(hamletCount);
    }
    
}