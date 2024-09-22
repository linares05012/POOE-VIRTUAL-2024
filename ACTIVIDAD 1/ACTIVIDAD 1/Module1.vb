Imports System.Diagnostics.Eventing.Reader

Module Module1


    Sub Main()
        Dim continuar As String = "s"
        While continuar = "s"

            Console.WriteLine("*** MENU ***")
            Console.WriteLine("1. Determinar si una persona es menor o mayor de edad.")
            Console.WriteLine("2. Determinar si un numero es positivo o negativo.")
            Console.WriteLine("3. Calcular descuento y total a pagar.")
            Console.WriteLine("4. calcular suma de numeros naturales")
            Console.WriteLine("5. Tabla Multiplicar.")
            Console.WriteLine("0. Salir.")
            Console.Write("Opcion: ")

            Dim opcion As Integer = Console.ReadLine()
            Console.Clear()
            Select Case opcion
                Case 1
                    edad()
                Case 2
                    PositivoNegativo()
                Case 3
                    totalpagar(0.00
)
                Case 4
                    tablaMultiplicar()
                Case Else
                    continuar = "0"
            End Select
        End While
    End Sub
    Sub edad()
        Dim edad As Integer

        Console.Write("ingresa su edad: ")
        edad = Double.Parse(Console.ReadLine())
        If (edad >= 18) Then
            Console.WriteLine("Usted es Mayor de edad ")
        Else Console.WriteLine("Usted es Menor de edad")
        End If

    End Sub
    Sub PositivoNegativo()

        Dim numero As Integer
        Console.Write("Escriba un numero: ")
        numero = Console.ReadLine()

        If (numero >= 0) Then
            Console.WriteLine("Su numero es Positivo")
        Else Console.WriteLine("su numero es Negativo")
        End If

    End Sub
    Sub tablaMultiplicar()
        Console.Write("Tabla: ")
        Dim i = 0, ntabla As Integer = Console.ReadLine()

        For i = 1 To 10 Step 1
            Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i)
        Next
    End Sub
    Sub totalpagar(descuento As Double)

        Console.Write("Ingrese el monto de la compra: ")
        Dim montoCompra As Double = Convert.ToDouble(Console.ReadLine())

        If (montoCompra >= 1000) Then

            descuento = 0.3

        ElseIf (montoCompra >= 500 <= 999.99) Then

            descuento = 0.2

        ElseIf (montoCompra >= 250.0 <= 499.99) Then

            descuento = 0.1

        ElseIf (montoCompra > 0 <= 249.99) Then

            descuento = 0.05

        End If


        Dim montoDescuento = montoCompra * descuento
        Dim totalpagar = montoCompra - montoDescuento


        Console.WriteLine($"\nMonto de compra: ${montoCompra}")
        Console.WriteLine($"Descuento aplicado: ${descuento * 100}%")

        Console.WriteLine($"Total a pagar: ${totalpagar}")
    End Sub
End Module



