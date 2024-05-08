Imports System.Data.SqlClient
Public Class login
    Dim cmd As SqlCommand 'para dar os comandos na tabela
    Dim rdr As SqlDataReader 'para consultar (ler, rdr = reader/leitor) os dados na tabela
    Private Sub btn_fechar2_Click(sender As Object, e As EventArgs) Handles btn_fechar2.Click
        mod_geral.FecharFormulario(Me) 'fechar o aplicativo chamando o metodo do mod_geral
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If (txt_email.Text = "") Then 'se o input do email estiver vazio
            MsgBox("Insira o email!")
            txt_email.Focus() 'pra focar a caixa de texto
            Exit Sub
        End If
        If (txt_senha.Text = "") Then 'se o input da senha estiver vazio
            MsgBox("Insira a senha!")
            txt_senha.Focus()
            Exit Sub
        End If

        Try
            mod_geral.con.Open() 'metodo para chamar o banco do mod_geral
            cmd = New SqlCommand("select * from usuariosCJOBS where email = '" & txt_email.Text & "' and senha = '" & txt_senha.Text & "'")
            cmd.Connection = mod_geral.con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then 'se os dados existirem na tabela...
                home.Show() 'abre o formulario home.vb
                Me.Hide() 'fecha o formulario atual
            End If

        Catch ex As Exception
            MsgBox("Email ou senha inválidos")
            txt_email.Text = "" 'isso limpa as caixas de textos
            txt_senha.Text = ""
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_cadastrarcaminho_Click(sender As Object, e As EventArgs) Handles btn_cadastrarcaminho.Click
        cadastro.Show() 'vai pro formulario cadastro.vb
        Me.Hide() 'fecha o formulario atual
    End Sub
End Class