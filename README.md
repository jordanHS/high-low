# High Low Game

#### _C#, .NET: High Low Game, 9/24/2019_

## Description
Create a High Low Game console application that 'guesses' what number a user is thinking of.

## Application should have:
- Separate frontend and backend logic

- Make a console app with a `HighLowNumber` class.

- Use `Console.ReadLine()` to gather three numbers from the user.

- Create a method in the `HighLowNumber` class:
    - That 'guesses' what number a user is thinking of.
    - The app should ask the user to pick a number between 1-100.
    - The app should then 'guess' a number and ask whether the user's number is higher or lower than the 'guessed' number.
    - If the user says the number is lower, the program should guess a lower number. If the user says the number is higher, the program should guess a higher number.
    - The game should go on until the program guesses the correct number.
    
## Use Case:
Program: Would you like to play the higher/lower game? (Yes/No)
User: Yes.
Program: Okay.
Program: Is your number higher or lower than 50? (Higher/Lower/Correct)
User: Lower
Program: Is your number higher or lower than 25? (Higher/Lower/Correct)
User: Higher
Program: Is your number higher or lower than 33? (Higher/Lower/Correct)
User: Higher
Program: Is your number higher or lower than 42? (Higher/Lower/Correct)
User: Higher
Program: Is your number higher or lower than 46? (Higher/Lower/Correct)
User: Lower
Program: Is your number higher or lower than 44? (Higher/Lower/Correct)
User: Correct
Program: Great! I guessed your number. Would you like to play again? (Yes/No)
User: No
-Program Quits-    

## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone this repo URL
```

2. Go into the repo and run this application:
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com
 jordansafford@gmail.com
 vera.weikel@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 under the MIT License