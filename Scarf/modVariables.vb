Imports MySql.Data.MySqlClient

Module modVariables
    Friend fConexionBD, fFormularios As New frmFunciones
    Friend sSqlLogin, sLogin, sClave, sTipo_Usuario, sLocation, sSqlConsultar, sSqlAgregar, sSqlEliminar, sSqlActualizar As String
    Friend iCodigo_Usuario As Integer
    Friend bhabilitarEdicion As Boolean = False
    Friend cmdLogin, cmdConsultar As MySqlCommand
    Friend idrConsultaSqlLogin, idrConsultaSqlConsultar, idrConsultaSqlAgregar, idrConsultaSqlEliminar, idrConsultaSqlActualizar As System.Data.IDataReader
End Module
