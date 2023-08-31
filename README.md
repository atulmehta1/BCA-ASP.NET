# BCA-ASP.NET
Module Module1

    Sub Main()
        Dim Marks(5) As Integer

        For i As Integer = 0 To 5

            Console.WriteLine("Enter the Marks of student" & (i + 1) & ":")

            Marks(i) = Convert.ToInt32(Console.ReadLine())



        Next

        For i As Integer = 0 To 4

            For j As Integer = 0 To 4 - i

                If Marks(j) > Marks(j + 1) Then

                    Dim temp As Integer = Marks(j)

                    Marks(j) = Marks(j + 1)

                    Marks(j + 1) = temp


                End If
            Next
        Next

        Console.WriteLine(vbCrLf & "sorted marks:")

        For i As Integer = 0 To 5

            Console.WriteLine("Student" & (i + 1) & ":" & Marks(i))

        Next
        Console.ReadLine()

    End Sub

End Module
