class Program {

    public static int InputNumberLevel() {
        Console.Write("Please input level : ");

        return int.Parse(Console.ReadLine());
    }

    public static void Main(string[] args) {
        int InputLevel = InputNumberLevel();
        PrintPyramid(InputLevel);
    }

    public static void PrintPyramid(int InputLevel) {

        int Floor = 1;
        for(int floorCal = 1; floorCal < InputLevel; floorCal++) {
            Floor += 2;
        }
        int Space = Floor / 2;
        int SpaceInside = 1;
        for(int CurrentLevel = 1; CurrentLevel <= InputLevel; CurrentLevel++) { 
            int PrintAmount = 1;
            if(PrintAmount == CurrentLevel) {
                for(int SpacePrint = 1; SpacePrint <= Space; SpacePrint++) {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
                Space--;
            }
            else if (CurrentLevel == InputLevel){
                for(CurrentLevel = 1; CurrentLevel <= Floor; CurrentLevel++) {
                        Console.Write("#");
                }
            }
            else {
                for(int SpacePrint = 1; SpacePrint <= Space; SpacePrint++) {
                        Console.Write(" ");
                }
                Console.Write("#");
                for(int SpacePrint = 1; SpacePrint <= SpaceInside; SpacePrint++) {
                    Console.Write(" ");
                        
                }
                SpaceInside += 2;
                Console.WriteLine("#");
                Space--;
            }   
        } 
    }
}