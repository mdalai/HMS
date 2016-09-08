Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Public conn As New SqlConnection
    'dbConnString As String = "Data Source=NARANDALAI-PC\SQLEXPRESS;Initial Catalog=HMS;User ID=sa;Password=1234"
    'Public dbConnString As String = "Data Source=192.168.1.75,1433;Network Library=DBMSSOCN;Initial Catalog=HMS;User ID=sa;Password=1234"
    Public dbConnString As String = "Data Source=192.168.1.100,1433;Network Library=DBMSSOCN;Initial Catalog=HMS2;User ID=sa;Password=4321"

    Public Function opendb()
        Try
            'If conn Is Nothing = True Then
            conn.ConnectionString = "Data Source=NARANDALAI-PC\SQLEXPRESS;Initial Catalog=HMS;User ID=sa;Password=1234"
            conn.Open()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Public Function dbClose()
        If conn Is Nothing = False Then
            conn.Close()
            conn.Dispose()
        End If
        Return 0
    End Function





End Module
