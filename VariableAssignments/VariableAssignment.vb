Option Explicit On
Option Strict On


Module VariableAssignment

    Sub Main()
        Dim fruit As String
        Dim count As Integer
        Dim price As Double
        Dim userInput As String
        Dim userNum As Integer
        fruit = "Apples"
        count = 5
        price = 1.99
        Console.WriteLine("I have " & count & " " & fruit)
        userInput = Console.ReadLine()
        Console.WriteLine("You Typed: " & userInput)
        Console.WriteLine($"You Typed: {userInput}")
        'Entropolated string ^^ (Formatted Strings FStrings)

        'Pause for user to press enter
        'Console.WriteLine("Hit Enter to continue")
        'Console.Read()

        Console.WriteLine("Please enter a number:")
        userInput = Console.ReadLine()
        userNum = CInt(userInput)


        'sets userNum to the numeric value of userInput
        Console.WriteLine("You entered: " & userNum)
        Console.WriteLine($"{userNum} + {count} = {userNum + count}")
        ' Displays Number and equation

        Console.WriteLine("Please Press Enter to Close Program")
        Console.Read()

    End Sub

End Module
