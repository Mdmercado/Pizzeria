Module Modulo
    'Variable de cadena de conexion. Cambiar el Catalog='*Nombre de la tabla' '
    Public Const CadCon As String = "Data Source=localhost\sqlexpress;Initial Catalog=Pizzeria;Integrated Security=True"

    'Funcion utilizada para obtener valores de la bd'
    Public Sub RecuperarSQL(ByVal sql As String, ByRef Tabla As DataTable)
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand

        conexion = New SqlClient.SqlConnection()
        conexion.ConnectionString = CadCon
        conexion.Open()
        comando = New SqlClient.SqlCommand()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        Tabla.Load(comando.ExecuteReader)
        conexion.Close()
    End Sub
    'Funcion utilizada para insertar valores dentro de la bd'
    Public Sub EjecutarSQL(ByVal sql As String)
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand

        conexion = New SqlClient.SqlConnection()
        conexion.ConnectionString = CadCon
        conexion.Open()
        comando = New SqlClient.SqlCommand()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Module
