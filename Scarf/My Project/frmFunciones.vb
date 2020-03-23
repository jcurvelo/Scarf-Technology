Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmFunciones
    Friend sConexionBD As MySqlConnection
    Friend sServidor As String = "localhost"
    Friend sUsuario As String = "root"
    Friend sPassword As String = ""
    Friend sBaseDatos As String = "administracion"

    Public Function fConexionBD()
        Try
            sConexionBD = New MySqlConnection
            sConexionBD.ConnectionString = "server=" & sServidor & ";userid=" & sUsuario & ";password=" & sPassword & ";database=" & sBaseDatos & ";port=3306;"
            sConexionBD.Open()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Hay un error en la conexion al servidor")
            Return False
        End Try
    End Function

    Public Function fOcultar(who, bol)
        Dim c As Control
        If bhabilitarEdicion = False Then
            For Each c In who.Controls
                If TypeOf c Is TextBox Then
                    c.Enabled = bol
                End If
            Next
        End If
        Return True
    End Function

End Class
