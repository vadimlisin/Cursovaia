Imports System
Imports System.ComponentModel
Imports System.Cryptography

Module Program
    Sub Main(args As String())

        Dim a, c As Integer
        a = 1

        Do
            Console.WriteLine("������� ���������")
            c = Console.ReadLine
            a = a * c
        Loop Until c = 1

        Console.WriteLine("������������ = {0}", a)

    End Sub
End Module
