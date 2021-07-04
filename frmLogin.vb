Public Class frmLogin
    Public Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click

        Dim user As String = "admin" ' Variavel do usuario
        Dim pass As String = "admin" ' Variavel da senha

        If (txtUser.Text & txtPass.Text = user & pass) Then ' Faz a verificação se os dados informados estão corretos

            MessageBox.Show("Login correto!", "Logado com Sucesso") ' Exibe mensagem avisando sobre sucesso ao fazer Login
        Else
            MessageBox.Show("Usuário ou senha está incorreto!", "Erro") 'Exibe mensagem sobre erro ao tentar fazer login com informações incorretas

        End If
    End Sub
End Class
