//  ici ce seras tous les exo codewars fait en C#

//  Even or Odd kyu 8 


// using System;

// namespace Solution
// {
//   public class SolutionClass
//   {
   
//     public static string EvenOrOdd(int number)
//     {
//        string even = "Even";
//        string Odd = "Odd";
    
      
//       if (number % 2 == 0)
//         {
//         return even ;
//       }
//     else 
//       {
//       return Odd;
//     }
      
      
//     }
//   }
// }


//  multiply kyu 8 


// public class CustomMath {
//     public static int multiply(int a, int b) {
//         return a * b;
//     }
// }
// ```

// ### return negative kyu 8 

// using System;

// ```cs
// public static class Kata
// {
//   public static int MakeNegative(int number)
//   {
//     // Code?
//     return -Math.Abs(number);
//   }
// }



//  Convert a Number to a String! kyu 8 

// 2 version possible 

// 1e version
// using System;

// public class Kata
// {
//   public static string NumberToString(int num)
//   {
//     // la premiere qui dit que num va en string 
//     string stringToNumber = num.ToString();
//     return stringToNumber;
//   }
// }

// 2e version 
 
// using System;

// public class Kata
// {
//   public static string NumberToString(int num)
//   {
//     // la deuxieme on utilise Convert et num dans les parenthese
//     string stringToNumber = Convert.ToString(num);
//     return stringToNumber;
//   }
// }


//  Convert boolean values to strings 'Yes' or 'No'. kyu 8


// using System;
// using System.Linq;

// public static class Kata
// {
//   public static string boolToWord(bool word)
//   {
//     if(word == true){
//       return "Yes";
//     }
//     else
//       {
//       return "No";
//     }
//   }
// }

//  Remove First and Last Character kyu 8


// using System;

// public class Kata
// {
//     public static string Remove_char(string s)
//     {
//         return s[1..^1];
//     }
// }


//  Vowel Count kyu 7 


using System;

// public static class Kata
// {
//     public static int GetVowelCount(string str)
//     {
//         int vowelCount = 0;

//       for (int i = 0; i < str.Length ; i++)
//         {
//         if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
        
          
//         {
//           vowelCount++;
//         }
//       }

//         return vowelCount;
//     }
// }

// autre version 


// using System;
// using System.Linq;

// public static class Kata
// {
//     public static int GetVowelCount(string str)
//     {
//         return str.Count(i => "aeiou".Contains(i));
//     }
// }


//  Convert a String to a Number! kyu 8


// using System;
//   public class Kata
//   {
//     public static int StringToNumber(String str) {
//         //TODO: Convert str into a number
     
//       int convert =  int.Parse(str);
//       return convert;
//   }
// }

//  Jenny's secret message kyu 8


// using System;

// public static class Kata
// {
//   public static string greet(string name)
//   {
   
//     if(name == "Johnny"){
//        return "Hello, my love!";
      
//     }else{
//       return "Hello, " + name + "!";
//     }
      
//   }
// }


//  Get Planet Name By ID kyu 8


// public class Kata
// {
//   public static string GetPlanetName(int id)
//   {
//     string name = "";
//     switch(id)
//     {
//       case 1:
//         name = "Mercury";
//         break;
//       case 2:
//         name = "Venus";
//         break;
//       case 3:
//         name = "Earth";
//         break;
//       case 4:
//         name = "Mars";
//         break;
//       case 5:
//         name = "Jupiter";
//         break;
//       case 6:
//         name = "Saturn";
//         break;
//       case 7:
//         name = "Uranus";
//         break;
//       case 8:
//         name = "Neptune";
//         break;
    
//     }
    
//     return name;
//   }
// }


//  Convert a string to an array kyu 8


// namespace Solution {
//   using System;

//   public class Solution
//   {
//     public static string[] StringToArray(string str)
//     {
//       return str.Split(' ');
//     }
//   }
// }


//  Remove String Spaces kyu 8


// namespace Solution 
// {
//   public static class SpacesRemover
//   {
//     public static string NoSpace(string input)
//     {
      
//       return  input.Replace(" ", "");
//     }  
//   }
// }


//  Renvoyer des chaînes kyu 8


// using System;

// public static class Kata
// {
//   public static string Greet(string name)
//   {
    
//     return "Hello, " + name + " how are you doing today?";
//   }
// }


//  String repeat kyu 8


// namespace Solution
// {
//   public static class Program
//   {
//     public static string RepeatStr(int n, string s)
//     {
//       string result = "";
      
//       for (int y = 0; y < n; y++)
//       {
//          result += s;
//       }
//       return result;
       
      
//     }
//   }
// }

// Reversed Strings kyu 8


// using System;

// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//     string reverse = string.Empty;
//     for(int n = str.Length - 1; n >= 0; n--)
//       {
//       reverse += str[n];
//     }
    
//     return reverse;
//   }
// }



//  Opposite number kyu 8


// using System;

// public class Kata
//     {
//         public  static int Opposite(int number)
//         {
//             // Happy Coding
//           return (-number);
//         }
//     }



//  Beginner Series #3 Sum of Numbers kyu 7

  // using System;
  // public class Sum
  // {
  //    public int GetSum(int a, int b)
  //    {
  //      if (a == b){
  //   return a;
  // }else if (a > b){
  //   return a + GetSum(a-1,b);
  // } else {
  //   return a + GetSum(a+1,b);
  // }
  //    }
  // }


//  Is the string uppercase? kyu 8



// public static class StringExtensions
// {
//   public static bool IsUpperCase(this string text)
//   {
//   for( int i = 0; i < text.Length ; i++)
//     {
//     if (char.IsLetter(text[i]) && !char.IsUpper(text[i]))
//       {
//       return false;
//     }
      
//     }
//     return true;
//   }
//   }

//  MakeUpperCase kyu 8


  // public class Kata
  // {
  //       public static string MakeUpperCase(string str)
  //       {
  //            return str.ToUpper();
  //       }

  // }



//  Convert a Boolean to a String kyu 8

 
// using System;

// public class kata
// {
//   public static string BooleanToString(bool b)
//   {
//     //Please don't delete me!
//     return b.ToString();
//   }
// }

//  Opposites Attract kyu 8

// using System;

// public class LoveDetector
// {
//     public static bool lovefunc(int flower1, int flower2)
//     { 
//        if (flower1 % 2 == 0 && flower2 % 2 != 0){
//     return true;
//   }else if(flower1 % 2 != 0 && flower2 % 2 == 0){
//     return true;
//   }
//   return false;    
//     }
// }






