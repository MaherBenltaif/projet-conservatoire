Imports MySql.Data.MySqlClient
Public Class Etudiants


    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Close()
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Try
            Dim sql = "INSERT INTO students(Nom, Prenom, Email, Tel, Adresse, Naissance, Classe, Paiement) VALUES (@Nom, @Prenom, @Email, @Tel, @Adresse, @Naissance, @Classe, @Paiement)"
            Dim cmd As MySqlCommand = BaseDeDonne.GetCommande(sql)
            cmd.Parameters.AddWithValue("@Nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Tel", txtTel.Text)
            cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text)
            cmd.Parameters.AddWithValue("@Naissance", txtDateNaissance.Value)
            cmd.Parameters.AddWithValue("@Classe", Classebox.Text)
            cmd.Parameters.AddWithValue("@Paiement", ckPaiement.Checked)

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

    Private Sub ckPaiement_CheckedChanged(sender As Object, e As EventArgs) Handles ckPaiement.CheckedChanged

    End Sub

    Private Sub Etudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class