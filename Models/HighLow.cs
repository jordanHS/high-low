using System;

namespace HighLowGame.Models
{
  class HighLowNumber
  {
    public int UserNumber { get; set; }
    public int CurrentGuessNumber { get; set; }
    public string TempGuessNumber { get; set; }
    public string Message { get; set; }
  
    public static void HighLowNumber( int userNumber, int currentGuessNumber, int tempGuessNumber, string message)
    { //** MAINLY PSEUDOCODING */
      UserNumber = userNumber;
      CurrentGuessNumber = currentGuessNumber; 
      TempGuessNumber = tempGuessNumber;
      Message = message;
      //========= Taking userInput as a marker for YES:'+'(aka'50>') OR NO:'-'(aka<50); for any num = n ===========
      //METHODOLOGY: Given-> if (currentGuessNumber > userInput), we loop the modulo in a loop and 'x' to inch closer to userNumber.
      //YES: ((currentGuessNumber%(1/x)) + currentGuessNumber);  
      //NO: ((currentGuessNumber%(1/x)) - currentGuessNumber); 
      public NumbersMatchingSearch(userInput) 
      {
        foreach(var currentGuessNumber in 1..100) //JIC: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum
        {
          if (userNumber == currentGuessNumber) 
          {   
              message = Console.WriteLine("Hooray! An exact match!");
              return message;
          }  
          // else if 
          // { // 3. otherwise recur down the correct subtree if (target < node->data) return(lookup(node->left, target)); 
          //   //CALL METHODS how?
          //   message = Console.WriteLine("Is your number" currentGuessNumber%(1/2)higher + " or " + lower() ?");
          // } 
          else if (userNumber != currentGuessNumber)
          { // 2. see if found here if (target == node->data) return(true);  
            Console.WriteLine("Is your number higher or lower than 50?");
            int currentGuessNumber = 100;
            //+,-:currentGuessNumber
            if (currentGuessNumber > userInput) //|| (currentGuessNumber < 50 )//userNumber if currentGuessNumber%(1/2)
            {
              tempGuessNumber = ((currentGuessNumber%(1/2)) + currentGuessNumber); 
              Console.WriteLine("Is your number higher or lower than " + tempGuessNumber + "?");
            } 
            else if (currentGuessNumber < 50 ) //userNumber if currentGuessNumber%(1/2)
            {
              tempGuessNumber = ((currentGuessNumber%(1/2)) - currentGuessNumber); 
              Console.WriteLine("Is your number higher or lower than " + tempGuessNumber + "?");
            } 
          }
          else 
          {
            // return(lookup(node->right, target)); 
            //validator 
            message = Console.WriteLine("Number is not between 1-100; Please type a number between 1-100..");
            return message;
          }
        }
      }  
    }
  }
}