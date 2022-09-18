class Program {

    public static string InputLevel() {
        Console.Write("Please input level : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string InputText) {
        int.TryParse(InputText, out int number);

        return number;
    }

    public static double AllBlockCal(int PyramidLevel, double NumberForCal) {
        if(PyramidLevel != 0) {
            return Math.Pow(NumberForCal,2) + AllBlockCal(PyramidLevel-1, NumberForCal+2);
        }
        return 0; 
    }

    public static void Main(string[] args) {
        double NumberForCal = 1;
        
        string PyramidLevelText = InputLevel();
        int PyramidLevelNumber = ConvertStringToInt(PyramidLevelText);
        double Summary = AllBlockCal(PyramidLevelNumber, NumberForCal); 

        PrintSummary(Summary);
    }

    public static void PrintSummary(double Summary) {
        Console.WriteLine("All Block = {0}",Summary);

    }

}