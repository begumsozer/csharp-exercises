public class Program
{
	public static string Bomb(string txt)
	{
		if(txt.ToLower().Contains("bomb"))
    {
     return "Duck!!!";
    } 
    else
    {
      return "There is no bomb, relax.";
    }
	}
}
