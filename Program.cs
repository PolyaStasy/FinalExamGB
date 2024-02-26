string [] STR = new string[] {"Hello", "2", "world", ";-)"};
string [] NewArray = new string[STR.Length];

int count = 0;

for(int i = 0; i< STR.Length; i++)
{
    if(STR[i].Length <= 3)
    {
       NewArray[count] = STR[i];
       count ++; 
    }  
}

void PrintArray(string[] arrayForPrint)
        {
            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                System.Console.Write(arrayForPrint[i] + "  ");
            }
        }

PrintArray(NewArray);