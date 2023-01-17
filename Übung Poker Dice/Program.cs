int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0;
bool fixed1 = false, fixed2 = false, fixed3 = false, fixed4 = false, fixed5 = false;

int round = 2;
int roll = 1;

void RollDice()
{
    if (fixed1 == false) { dice1 = Random.Shared.Next(1, 7); }
    if (fixed2 == false) { dice2 = Random.Shared.Next(1, 7); }
    if (fixed3 == false) { dice3 = Random.Shared.Next(1, 7); }
    if (fixed4 == false) { dice4 = Random.Shared.Next(1, 7); }
    if (fixed5 == false) { dice5 = Random.Shared.Next(1, 7); }
}

void PrintDice()
{
    Console.WriteLine("---");
    Console.Write($"Dice roll #{roll} (out of 3): ");
    Console.WriteLine($"{dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
    roll++;
}

void FixDice()
{
    fixed1 = false; fixed2 = false; fixed3 = false; fixed4 = false; fixed5 = false;

    while (round != 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dice)");
        string Userinput = Console.ReadLine()!;
        if (Userinput == "1") { fixed1 = !fixed1; }
        else if (Userinput == "2") { fixed2 = !fixed2; }
        else if (Userinput == "3") { fixed3 = !fixed3; }
        else if (Userinput == "4") { fixed4 = !fixed4; }
        else if (Userinput == "5") { fixed5 = !fixed5; }
        else if (Userinput == "r") { RollDice(); PrintDice(); round--; }

        if (fixed1 || fixed2 || fixed3 || fixed4 || fixed5) { Console.Write("Fixed: "); }
        if (fixed1) { Console.Write("1 "); }
        if (fixed2) { Console.Write("2 "); }
        if (fixed3) { Console.Write("3 "); }
        if (fixed4) { Console.Write("4 "); }
        if (fixed5) { Console.Write("5 "); }

        if (fixed1 == true && fixed2 == true && fixed3 == true && fixed4 == true && fixed5 == true)
        { return; }
    }
}

Console.Clear();
RollDice();
PrintDice();
FixDice();