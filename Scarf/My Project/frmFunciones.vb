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

    Public Function fSetVisible(item)
        item.Visible = True
        Return True
    End Function
End Class
