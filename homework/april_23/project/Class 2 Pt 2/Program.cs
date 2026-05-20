/* string log = "";
string specialName = "";
while (true)
{
    try
    {
        StreamReader logFile = new StreamReader("log.txt");

        log = logFile.ReadToEnd();
    }
    catch (Exception e)
    {

    }

    try
    {
        StreamReader specialFile = new StreamReader("special.txt");
        specialName = specialFile.ReadToEnd();
    }
    catch (Exception e)
    {

    }

    Console.WriteLine(specialName);
    Console.WriteLine(log);
} */

///////////////////////////////////////////////////////////////////////////////
class MyMath
{
    double average(int a, int b)
    {
        return (a + b) / 2;
    }

    double average(double a, double b)
    {
        return (a + b) / 2;
    }

    double average(string a, string b)
    {
        return average(double.Parse(a), double.Parse(b));
    }
    
    static void Main(string[] args)
    {
        
    }
}