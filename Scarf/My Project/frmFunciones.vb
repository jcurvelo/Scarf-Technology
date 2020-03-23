Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmFunciones
    Friend sConexionBD As MySqlConnection
    Friend sServidor As String = "localhost"
    Friend sUsuario As String = "root"
    Friend sPassword As String = ""
    Friend sBaseDatos As String = "administracion"

    'FUNCION PARA LA CONEXION A LA BASE DE DATOS
    Public Function fConexionBD()
        Try 'INTENTAMOS

            sConexionBD = New MySqlConnection
            sConexionBD.ConnectionString = "server=" & sServidor & ";userid=" & sUsuario & ";password=" & sPassword & ";database=" & sBaseDatos & ";port=3306;"
            sConexionBD.Open()
            Return True
        Catch ex As MySqlException 'Y SI FALLA...

            MessageBox.Show("Hay un error en la conexion al servidor")
            Return False
        End Try
    End Function

    'PARA HABILITAR O DESHABILITAR LOS TEXTBOX. 
    'SE HACE MAS FACIL QUE COPIAR Y PEGAR EL CODIGO
    Public Function fOcultar(who, bol) 'EN WHO VA 'ME' CUANDO ESTEMOS EN EL FORMULARIO. BOL PUEDE SER TRUE O FALSE
        Dim c As Control 'UN NOMBRE SIMPLE DE VARIABLE. CONTROL ES UNA CLASE DE VISUAL
        If bhabilitarEdicion = False Then 'LA VARIABLE AHÍ ESTA EN MODVARIABLES
            For Each c In who.Controls 'PARA CADA C EN CONTROLS...
                If TypeOf c Is TextBox Then 'SI C IS UN TEXTBOX...
                    c.Enabled = bol 'LO HABILITAMOS O DESHABILITAMOS
                End If
            Next
        End If
        Return True
    End Function

End Class
