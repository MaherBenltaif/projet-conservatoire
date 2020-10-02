Imports MySql.Data.MySqlClient


Module BaseDeDonne
    ''' <summary>
    ''' Permet de creer le connection
    ''' </summary>
    ''' ''' <returns></returns>
    Public Function Connect() As MySqlConnection
        Dim chaineConnection As String = "Datasource=localhost;User id=root;Database=conservatoire1;passord="
        Dim connection = New MySqlConnection(chaineConnection)
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If
        Return connection
    End Function
    ''' <summary>
    ''' Permet d'initialiser une commandde pour executer une requete sql 
    ''' </summary>
    ''' <param name="sql">la requete sql a executer</param>
    ''' <returns></returns>
    Public Function GetCommande(ByVal sql As String) As MySqlCommand
        Dim cmd = Connect().CreateCommand
        cmd.CommandText = sql
        Return cmd
    End Function
End Module
