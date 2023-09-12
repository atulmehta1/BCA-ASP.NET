Module Module1
    Sub Main()
        Dim sub1, sub2, sub3, sub4, sub5, total As Integer
        Dim name As String
        Dim div As Double

        Console.WriteLine("Enter the name:")
        name = Console.ReadLine(

        Console.WriteLine("Enter the Marks:")
        sub1 = Console.ReadLine()
        sub2 = Console.ReadLine()
        sub3 = Console.ReadLine()
        sub4 = Console.ReadLine()
        sub5 = Console.ReadLine()

        total = sub1 + sub2 + sub3 + sub4 + sub5
        div = total / 500 * 100
        Console.WriteLine("Total Marks=" & total)
        Console.WriteLine("Avrage=" & div)




        If (div >= 75) Then
            Console.WriteLine("1st Division")

        ElseIf (div >= 60) Then
            Console.WriteLine("2nd Division")

            Console.WriteLine("3rd Division")
        
        Else
            Console.WriteLine("Fail")
        End If

        Console.ReadLine()
    End Sub
End Module
