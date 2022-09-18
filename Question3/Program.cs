class Program {

    public static int InputAmountNumber() {
        Console.Write("Please input amount of number : ");

        return int.Parse(Console.ReadLine());
    }

    public static double InputNumber(int NumberAmount, ref double[] NumberList, int numberArray) {
        if(NumberAmount != 0) {
            Console.Write("Please input number : ");
            NumberList[numberArray] = double.Parse(Console.ReadLine());
            return InputNumber(NumberAmount-1, ref NumberList, numberArray+1);
        }
        return 0;

    } 

    public static double CheckThanNumber(int NumberAmount, double[] NumberList) {
        double a = NumberList[0];
        double b = NumberList[1];
        if(a > b) {
            return GreatestCal(a,b);
            
        }
        else {
            return GreatestCal(b,a);
        }
    }

    public static double GreatestCal(double a, double b) {
        double remain = a % b;
        if(remain != 0){
            return GreatestCal(b,remain);
        }
        else {
            return b;
        }
    }

    public static void Main(string[] args) {
        int numberArray = 0;
        int NumberAmount = InputAmountNumber();
        double[] NumberList = new double[NumberAmount];
        InputNumber(NumberAmount, ref NumberList, numberArray);

        if(NumberAmount != 0 && NumberAmount != 1) {
            CheckThanNumber(NumberAmount, NumberList);
        } 
        
        PrintResult(NumberAmount, NumberList);
        
    } 

    public static void PrintResult(int NumberAmount, double[] NumberList) {
        if (NumberAmount != 0 && NumberAmount != 1) {
            double GreatestCommonFactor = CheckThanNumber(NumberAmount, NumberList);
            Console.WriteLine("Greatest Common Divisor : {0}",GreatestCommonFactor);
        }
        else if(NumberAmount == 1) {
            Console.WriteLine("Greatest Common Divisor : {0}",NumberList[0]);
        }
        else {
            Console.WriteLine("Please input amount of number > 0");
        }
    }

}