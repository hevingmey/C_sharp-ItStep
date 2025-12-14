namespace HW_10_12_2025.calculator;

public class Calculator
{
    private int a;
    private int[] result;
    private int counter=0;
    
    public Calculator(int a)
    {
        this.a = a;
        result=new int[32];
        counter = 0;
    }

    public void change()
    {
        counter = 0;
        int temp1 = a;
 if (counter == 0)
                     {
                         result[counter] = 0;
                         counter = 1;
                     }
        while (temp1 > 0)
        {
            result[counter] = temp1 % 2;
            counter++;
            temp1 /= 2;
           
        } 
       
    }

    public void print()
        {
            for (int i = counter-1; i >=0 ; i--)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
