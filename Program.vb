
Imports System
Imports System.ComponentModel.Design

Module HomeWork
    Sub Main(args As String())
        Dim x, y, g As Integer
        Const ULONGMAX As ULong = 18446744073709551615UL
        y = 1
        Console.WriteLine("������������, � ���� �������� �����. ��������, ������� ����� ��������� �����������")
        g = CInt(Console.ReadLine())
        For i = 1 To g
            If (y < ULONGMAX / i) Then
                Console.WriteLine("������� ���������")
                x = Console.ReadLine()
                y = y * x
            Else
                Console.Write("� �� ���� ������� ����� ������� �����, ������������ ������ :(")
                Console.WriteLine(x - 1)
            End If
        Next
        Console.WriteLine("������������ �������� ���� ����� �����:")
        Console.WriteLine(y)




    End Sub
End Module
