using System;

int numbers = -236111011;
string numberInString = numbers.ToString();
char[] number  = numberInString.ToCharArray();
int[] tab = new int[11];

foreach (char singe in number)
{
    if (singe == '0')
    {
        tab[0]++;
    }
    else if (singe == '1')
    {
        tab[1]++;
    }
    else if (singe == '2')
    {
        tab[2]++;
    }
    else if (singe == '3')
    {
        tab[3]++;
    }
    else if (singe == '4')
    {
        tab[4]++;
    }
    else if (singe == '5')
    {
        tab[5]++;
    }
    else if (singe == '6')
    {
        tab[6]++;
    }
    else if (singe == '7')
    {
        tab[7]++;
    }
    else if (singe == '8')
    {
        tab[8]++;
    }
    else if (singe == '9')
    {
        tab[9]++;
    }
    else
    {
        tab[10]++;
    }
}
Console.WriteLine($" W danej {numbers} znajdują się: \n0- {tab[0]} \n1- {tab[1]} \n2- {tab[2]} \n3- {tab[3]} \n4- {tab[4]} \n5- {tab[5]} \n6- {tab[6]} \n7- {tab[7]} \n8- {tab[8]} \n9- {tab[9]} \nInne- {tab[10]} ");