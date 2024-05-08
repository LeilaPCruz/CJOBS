Imports System.Data
Imports System.Data.SqlClient

Public Class cadastro

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If (txt_cpf.Text = "" OrElse txt_nome.Text = "" OrElse txt_email.Text = "" OrElse txt_senha.Text = "" OrElse Not ck_termos.Checked) Then 'se esses campos estiverem em branco
            MsgBox("Insira todos os dados!")
            Exit Sub
        End If

        Try
            'uma variavel pra cada valor de input
            Dim cpf As String = txt_cpf.Text
            Dim nome As String = txt_nome.Text
            Dim email As String = txt_email.Text
            Dim senha As String = txt_senha.Text

            mod_geral.con.Open() 'metodo para chamar o banco do mod_geral
            Dim command As New SqlCommand("INSERT INTO usuariosCJOBS (cpf, nome, email, senha) VALUES (@cpf, @nome, @email, @senha)", con) 'metodo utilizando os parametros do sql
            command.Parameters.AddWithValue("@cpf", cpf)
            command.Parameters.AddWithValue("@nome", nome)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@senha", senha)
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cadastro efetuado com sucesso!")
            login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao efetuar o cadastro. Detalhes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_logincaminho_Click(sender As Object, e As EventArgs) Handles btn_logincaminho.Click
        login.Show() 'vai pro login.vb
        Me.Hide() 'fecha o formulario atual
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        mod_geral.FecharFormulario(Me) 'fecha o aplicativo chamando o metodo do mod_geral
    End Sub
End Class
