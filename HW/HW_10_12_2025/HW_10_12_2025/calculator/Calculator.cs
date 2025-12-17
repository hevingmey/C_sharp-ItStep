namespace HW_10_12_2025.calculator;

public class Calculator
{

    public string db(string input)
    {
        checked
        {
           int a =int.Parse(input);
           string result = "";
           while (a > 0)
           {
               result = (a % 2) + result;
               a /= 2;
           }

           return result;
        }

    }

    public int bd(string w)
    {
        int result = 0;
        checked
        {
            for (int i = 0; i < w.Length; i++)
            {
                int bit=w[w.Length - 1 - i]-'0';
                result+=bit*(1<<i);
            }
            return result;
        }
    }
}