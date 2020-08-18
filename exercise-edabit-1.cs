public class Program 
{
    public static int MinTurns(string current, string target) 
    {			    
     int total=0;
     for(int x=0;x<4;x++)
     { 
      int currentNum=current[x]-'0';
      int targetNum=target[x]-'0';
      if (currentNum<targetNum)
      {
       if (targetNum-currentNum<currentNum+10-targetNum)
       {
       total+=targetNum-currentNum;
       }
       else
       {
       total+=currentNum+10-targetNum;
       }      
      }
     else
     {
     if(currentNum-targetNum<targetNum+10-currentNum)
     {
     total+=currentNum-targetNum;
     }
     else
     {
     total+=targetNum+10-currentNum;
     }
     }
      }
     return total; 
    }
}
