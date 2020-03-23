Imports MySql.Data.MySqlClient

'---------------------------------LA FRIENDZONE---------------------------
Module modVariables
    'PARA LLAMAR A VARIABLES Y FUNCIONES DESDE TODOS LADOS
    Friend fConexionBD, fFormularios As New frmFunciones '<-FUNCIONES
    'STRINGS O TEXTOS
    Friend sSqlLogin, sLogin, sClave, sTipo_Usuario, sLocation, sSqlConsultar, sSqlAgregar, sSqlEliminar, sSqlActualizar As String
    'ENTEROS
    Friend iCodigo_Usuario As Integer
    'BOOLEANOS
    Friend bhabilitarEdicion As Boolean = False
    'COMANDOS SQL
    Friend cmdLogin, cmdConsultar As MySqlCommand
    'DATAREADRES. OSEA, LEE DATOS, SEGÚN
    Friend idrConsultaSqlLogin, idrConsultaSqlConsultar, idrConsultaSqlAgregar, idrConsultaSqlEliminar, idrConsultaSqlActualizar As System.Data.IDataReader
End Module


'HECHO POR JUAN CURVELO Y ANGEL ARANGUREN!