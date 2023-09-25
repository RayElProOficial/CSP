# CSP
C#+ (C Sharp Plus) is an API for C# to make C# Learning &amp; Coding Easier.


## In C#...
```cs
using System;

namespace Application
{
  public static class APP
  {
    public static void Main(string[] args)
    {
      string MyText;
      MyText = "STRVLE";
      Console.WriteLine(MyText);
      Console.ReadLine();
      int MyNum;
      MyNum = 0;
      decimal MyDecimal;
      MyDecimal = 0.1;
      string MyFText;
      string = $"text: {MyText}, number: {MyNum}";
      string[] MyMultiText;
      MyMutliText = { "mmt", "1.1.1.1" }
      //ASSIGN TO VARIABLE
      MyText = "Assign!";
    }
  }
}

```
## While in C#+...
```
using System;
using static csp.CSPv;

namespace iNS_CROSS_PLATFORM_LinxCLI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Text text;
            text = new Text("STRVLE");
            Console.WriteLine(text); 
            Console.ReadLine();
            Num number;
            number = new Num(0);
            DNum decimal; //STILL IN DEVELOPMENT.
            decimal = new DNum(0.1);
            FText formattedtext;
            formattedtext = new FText($"Text: {text}, Number: {number}.");
            MText multitext;
            multitext = new multitext(new string[] mtBase = {"wow", "mtext.wow.nmo});
            //ASSIGN TO VARIABLE:
            text.Assign("WOW wow");
        }

     }
}

```
