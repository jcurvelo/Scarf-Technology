Imports MySql.Data.MySqlClient

Module modVariables
    Friend fConexionBD As New frmFunciones
    Friend sSqlLogin, sLogin, sClave, sTipo_Usuario, sLocacion As String
    Friend iCodigo_Usuario As Integer
    Friend cmdLogin As MySqlCommand
    Friend idrConsultaSqlLogin As System.Data.IDataReader
End Module
