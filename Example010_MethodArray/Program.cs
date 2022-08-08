//              0    1     2   3     4   5     6   7    8
int[] array = { 113, 212, 331, 421, 153, 612, 127, 182, 192 };


int n = array.Length;
int find = 421;


int index = 0;

while (index < n)

{

    if (array[index] == find)
    {

        Console.WriteLine(index);
        break;
    }

        //index = index +1;
        index++;



}