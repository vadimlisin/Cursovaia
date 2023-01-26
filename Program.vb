Imports System
Imports System.ComponentModel
Imports System.Cryptography

Module Program
    Sub Main(args As String())

        Dim a, c As Integer
        a = 1

        Do
            Console.WriteLine("Введите множитель")
            c = Console.ReadLine
            a = a * c
        Loop Until c = 1

        Console.WriteLine("Произведение = {0}", a)

    End Sub
End Module
