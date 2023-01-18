
Imports System
Imports System.ComponentModel.Design

Module HomeWork
    Sub Main(args As String())
        Dim x, y, g As Integer
        Const ULONGMAX As ULong = 18446744073709551615UL
        y = 1
        Console.WriteLine("Здравствуйте, я умею умножать числа. Напишите, сколько чисел требуется перемножить")
        g = CInt(Console.ReadLine())
        For i = 1 To g
            If (y < ULONGMAX / i) Then
                Console.WriteLine("Введите множитель")
                x = Console.ReadLine()
                y = y * x
            Else
                Console.Write("Я не умею считать такие большие числа, недостаточно памяти :(")
                Console.WriteLine(x - 1)
            End If
        Next
        Console.WriteLine("Произведение введённых вами чисел равно:")
        Console.WriteLine(y)




    End Sub
End Module
