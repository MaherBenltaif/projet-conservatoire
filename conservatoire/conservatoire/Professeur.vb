Imports MySql.Data.MySqlClient
Public Class Professeur
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sql = "INSERT INTO proffesseurs(Nom, Prenom, Email, Tel, Adresse, Classe, Salaire) VALUES (@Nom, @Prenom, @Email, @Tel, @Adresse, @Classe, @Salaire)"
            Dim cmd As MySqlCommand = BaseDeDonne.GetCommande(sql)
            cmd.Parameters.AddWithValue("@Nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Tel", txtTel.Text)
            cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text)
            cmd.Parameters.AddWithValue("@Classe", Classebox.Text)
            cmd.Parameters.AddWithValue("@Salaire", txtsalaire.Text)

            Dim rowAffected = cmd.ExecuteNonQuery()

            If rowAffected > 0 Then
                MsgBox("Enregistrement effectuer avec success")
                Close()
            Else
                MsgBox("Une erreur est survenu")
            End If
        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub Professeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class