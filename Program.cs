﻿string [] STR = new string[] {"Hello", "2", "world", ";-)"};

int N = STR.Length;
int count = 0;
string [] NewArray = new string[STR.Length];
for(int i = 0; i<N; i++)
{
    if(STR[i].Length <= 3)
    {
       NewArray[count] = STR[i];
       count ++; 
    }  
}