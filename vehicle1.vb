Imports System
Imports System.Net.Mail
Imports System.Threading

Module Program
    Class VEHICLE
        Protected speed As Double
        Protected n As String
        Protected type As String

        Public Sub New()
            Dim speed As Double
            speed = 0
        End Sub

        Public Sub New(name As String, Speed As Double)
            n = name
            Speed = Speed
            Console.WriteLine("Speed is " & speed)
        End Sub

        Public Overridable Sub typ(typ As String)
            typ = typ
            Console.WriteLine("Type of vehicle is " & typ)
        End Sub
    End Class

    Class AltoK10
        Inherits VEHICLE
        Protected mile As Double

        Public Sub New(name, Speed)
            MyBase.New("AltoK10", 40)
        End Sub

        Public Sub mileage(distance As Double, litres As Double)
            mile = distance / litres
            Console.WriteLine("Mileage is " & mile)
        End Sub

        Public Function getValue() As Integer
            Return mile
        End Function

        Public Overridable Sub typ(typ As String)
            MyBase.typ("Manual")
        End Sub
    End Class

    Class Kwid
        Inherits VEHICLE
        Public mil As Double

        Public Sub New(name, Speed)
            MyBase.New("Kwid", 60)
        End Sub

        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overridable Sub typ(type As String)
            MyBase.typ("Manual")
        End Sub
    End Class

    Class Tiago
        Inherits VEHICLE
        Public mil As Double

        Public Sub New(name, Speed)
            MyBase.New("Tiago", 70)
        End Sub

        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overridable Sub typ(type As String)
            MyBase.typ("Manual")
        End Sub
    End Class

    Sub main()
        Dim v1 As Double
        Dim v2 As Double
        Dim v3 As Double
        Console.WriteLine("Specifications of AltoK10 " & vbCrLf)
        Dim c1 As AltoK10 = New AltoK10("AltoK10", 22)
        c1.typ("Manual")
        c1.mileage(110, 5)
        v1 = c1.getValue()
        Console.WriteLine("")

        Console.WriteLine("Specifications of Kwid" & vbCrLf)
        Dim c2 As Kwid = New Kwid("Kwid", 20)
        c2.typ("Manual")
        c2.mileage(100, 5)
        v2 = c2.val()
        Console.WriteLine("")

        Console.WriteLine("Specifications of Tiago" & vbCrLf)
        Dim c3 As Tiago = New Tiago("Tiago", 16)
        c3.typ("Manual")
        c3.mileage(80, 5)
        v3 = c3.val()
        Console.WriteLine("")

        If v1 > v2 Then
            If v1 > v3 Then
                Console.WriteLine("AltoK10 has more mileage than Kwid  so its more econimical")
            End If
        ElseIf v2 > v3 Then
            Console.WriteLine("Kwid is more economical with high mileage")
        Else
            Console.WriteLine("Tiago is more economical with high mileage")
        End If

        Console.ReadLine()
    End Sub
End Module
