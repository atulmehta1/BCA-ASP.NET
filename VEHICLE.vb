Module Module1

End Module


Class Vehicle
    Public Speed As Double
    Public Mileage As Double

    Public Sub New(speed As Double, mileage As Double)
        Me.Speed = speed
        Me.Mileage = mileage
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim car As New Vehicle(100, 10)
        Dim bike As New Vehicle(50, 20)
        Dim truck As New Vehicle(80, 5)
        Dim bus As New Vehicle(60, 15)

        Dim vehicles() As Vehicle = {car, bike, truck, bus} ' Array of vehicles

        Dim bestMileageVehicle As Vehicle = GetBestMileageVehicle(vehicles)
        Console.WriteLine("The vehicle with the best mileage has a speed of " & bestMileageVehicle.Speed & " and mileage of " & bestMileageVehicle.Mileage)
        Console.ReadLine()
    End Sub

    Function GetBestMileageVehicle(vehicles As Vehicle()) As Vehicle
        Dim bestMileage As Double = 0
        Dim bestMileageVehicle As Vehicle = Nothing

        For Each vehicle As Vehicle In vehicles
            If vehicle.Mileage > bestMileage Then
                bestMileage = vehicle.Mileage
                bestMileageVehicle = vehicle
            End If
        Next

        Return bestMileageVehicle
    End Function


End Module

