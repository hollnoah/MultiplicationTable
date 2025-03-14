'Noah Holloway
'RCET 2265
'Spring 2025
'MultiplicationTable

Option Explicit On
Option Strict On
Option Compare Text
Module MultiplicationTable

    Sub Main()
        Dim userInput As String
        Dim tableSize As Integer
        Dim validInput As Boolean = False


        Do

            Console.WriteLine("Please enter a positive whole number")
            userInput = Console.ReadLine()
            Try
                tableSize = CInt(userInput)
                If tableSize > 0 Then
                    validInput = True
                Else
                    Console.WriteLine("Looks like someone can't follow directions... ")

                End If

            Catch ex As Exception
                Console.WriteLine()
            End Try

        Loop Until validInput

        Console.WriteLine()

        Console.WriteLine("Enjoy your " & userInput & " " & "*" & " " & userInput & " " & "Multiplication table:")
        For i As Integer = 1 To tableSize
            For j As Integer = 1 To tableSize
                Console.Write((i * j).ToString().PadLeft(5))

            Next
            Console.WriteLine()
        Next


    End Sub

End Module
