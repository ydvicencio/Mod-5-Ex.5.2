using System;

class Program 
{
  static void Main()
  {
    int[] temperatures = new int[5];
    bool isAscending = true;
    bool isDescending = true;
    int total = 0;

    //input temperatures
    for (int i = 0; i < temperatures.Length; i++)
    {
      int temp;
      while (true) //make program continue until valid input is used
      {
        try
        {
          temp = GetTempearture(i + 1);



          //check if temp is valid
          temperatures[i] = temp;
          total += temp;

          //check if temp is desceding
          if (i > 0)
          {
            if (temperatures[i] < temperatures[i - 1])
            {
              isDescending = false;
            }
            if (temperatures[i] < temperatures[i - 1])
            {
              isAscending = false;
            }
          
          }
        

        break;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    //output temperatures
    if (isAscending)
    {
      Console.WriteLine("Getting warmer");
    }
    else if (isDescending)
    {
      Console.WriteLine("Getting cooler");
    }
    else
    {
      Console.WriteLine("It's a mixed bag");
    }

    //display temps in order
    Console.WriteLine("\nTemperatures entered:");
    foreach (int currentTemp in temperatures)
    {
      Console.WriteLine(currentTemp);
    }

    //display average temp
    double average = total / (double)temperatures.Length;
    Console.WriteLine("\nAverage temperature: " + average);
   
  
  }

  static int GetTempearture(int day)
  {
    Console.Write($"Enter temperature for the day {day} (between -30 and 130): ");
    int temp = Convert.ToInt32(Console.ReadLine());

    if (temp < -30 || temp > 130)
    {
      throw new Exception($"Temperature {temp} is invalid, Please enter a valid temperature between -30 and 130");
    }

    return temp;
  }
    }
  
}
  
  

  