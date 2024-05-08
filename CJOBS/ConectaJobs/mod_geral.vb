Imports System.Data.SqlClient
Module mod_geral
    Public Sub FecharFormulario(ByVal form As Form)
        form.Close() 'pra fechar o formulario
    End Sub

    Public con As New SqlConnection("Data Source=PATINHO;Initial Catalog=CJOBS;User ID=sa;Password=03041998;") 'string de conexao com o banco
End Module
