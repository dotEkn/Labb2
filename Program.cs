using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Hur många familjemedlemmar har du?");

int AntalFam = int.Parse(Console.ReadLine());



string[] Familj = new string[AntalFam];
int ÅlderUser = int.Parse(Console.ReadLine());


for (int b = 0; b < AntalFam; b++)
{
    Console.WriteLine("Skriv namn på en familjemedlem " + (b + 1) + ": ");
    Familj[b] = Console.ReadLine();


    for (int c = 0; c < ÅlderUser; c++)
    {
        Console.WriteLine("Skriv ålder på " + Familj[b]);

    }
}



for (int b = 0; b < AntalFam; b++)
{
    Console.WriteLine(Familj[b]);
}



// Variablar för namn och ålder för 4 personer! (Ändrar du på [4] till t.ex [6] så blir det 6 personer/åldrar i strängarna!)
// *string[] namn = new string[4];
// *int[] ålder = new int[4];

// Användaren får själv skriva in namn och åldrar för varje person!
// *for (int a = 0; a < 4; a++)

  //  {   
  //  Console.WriteLine("Skriv namn på en person " + (a + 1) + ": ");
   // namn[a] = Console.ReadLine();

   // Console.WriteLine("Skriv ålder för " + namn[a] + ": ");
   // if (int.TryParse(Console.ReadLine(), out ålder[a]) == false)
   //     {
        // Om det är en ogiltig ålder, så får den försöka igen för samma person.
   //     Console.WriteLine("Var snäll och ange ett heltal.");
   //     a--;
   //     }
   // }
// Skriver ut namn och åldrarna på  alla personer så att användaren får se vad den har skrivit.
//Console.WriteLine("Namn och ålder på personer:");
//for (int a = 0; a < 4; a++)
   // {
   // Console.WriteLine(namn[a] + " är " + ålder[a] + " år gammal.");
   // }
// Summan på åldrarna!
// int summaåld = ålder[0] + ålder[1] + ålder[2] + ålder[3];
// Console.WriteLine("Summa av åldrarna: " + summaåld);

// Medelåldern med två decimaler!
// double medelåld = (double)summaåld / 4;
// Console.WriteLine("Medelålder: " + medelåld.ToString());
