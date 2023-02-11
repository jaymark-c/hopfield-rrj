using Hopfield9x9;

class Program
{
    static void Main(string[] args)
    {
        int[] patrn1 = { 1, -1, -1, 1, 1, 1, -1, -1, -1 };
        int[] wt1 = { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
        int[] wt2 = { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
        int[] wt3 = { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
        int[] wt4 = { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
        int[] wt5 = { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
        int[] wt6 = { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
        int[] wt7 = { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
        int[] wt8 = { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
        int[] wt9 = { 2, 0, 2, -2, -2, -2, 2, 0, 0 };

        Console.WriteLine("\nTHIS PROGRAM IS FOR A HOPFIELD NETWORK WITH A SINGLE LAYER OF");
        Console.WriteLine("4 FULLY INTERCONNECTED NEURONS. THE NETWORK SHOULD RECALL THE");
        Console.WriteLine("PATTERNS 1010 AND 0101 CORRECTLY.\n");

        Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);

        h1.activation(patrn1);

        Console.WriteLine("\n Your input in text form during 9x9 matrix\n");

        for(int i = 0; i < 9; i++)
        {
            if (i % 3 == 0 && i != 0)
                Console.Write("\n");
            if (patrn1[i] == 1) //black
                Console.Write(" + ");
            else //white
                Console.Write(" - ");
        }

        Console.WriteLine("\n The output based on hopfield \n");

        for (int i = 0; i < 9; i++)
        {
            if (i % 3 == 0 && i != 0)
                Console.Write("\n");
            if (h1.output[i] == 1) //black
                Console.Write(" + ");
            else //white
                Console.Write(" - ");
        }

        Console.WriteLine("\n\n");
    }

}
