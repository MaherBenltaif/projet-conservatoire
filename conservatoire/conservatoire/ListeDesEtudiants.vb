Imports MySql.Data.MySqlClient
Public Class ListeDesEtudiants
    ''' <summary>
    ''' Permet de charger les donnees de la base de donnees sur la ListView
    ''' </summary>

    Private Sub RemplirListView()
        ListViewStudents.Items.Clear()
        Try
            Dim connection = BaseDeDonne.Connect()
            Dim cmd As MySqlCommand = connection.CreateCommand
            cmd.CommandText = "Select * From students"
            Dim resultat = cmd.ExecuteReader()
            While resultat.Read
                Dim item As ListViewItem = New ListViewItem(resultat.GetString("Nom"))
                item.SubItems.Add(resultat.GetString("Prenom"))
                item.SubItems.Add(resultat.GetString("Email"))
                item.SubItems.Add(resultat.GetString("Tel"))
                item.SubItems.Add(resultat.GetString("Adresse"))
                item.SubItems.Add(resultat.GetString("Naissance"))
                item.SubItems.Add(resultat.GetString("Classe"))
                Dim Paiement As Boolean = resultat.GetBoolean("Paiement")
                If Paiement = True Then
                    item.SubItems.Add("Payée")
                Else
                    item.SubItems.Add("Non-Payée")
                End If
                item.SubItems.Add(resultat.GetString("Paiement"))
                ListViewStudents.Items.Add(item)
            End While
            resultat.Close()
            connection.Close()
        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub ListeDesEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirListView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRafraichir.Click
        RemplirListView()
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim formAjout = New Etudiants
        formAjout.ShowDialog()
        RemplirListView()
    End Sub

    Public Sub btnEditer_Click(sender As Object, e As EventArgs) Handles btnEditer.Click
        Try
            If ListViewStudents.SelectedItems.Count = 1 Then
                Dim element As ListViewItem = ListViewStudents.SelectedItems(0)
                Dim nom As String = element.SubItems(0).Text
                Dim connection = BaseDeDonne.Connect()
                Dim cmd As MySqlCommand = connection.CreateCommand
                cmd.CommandText = "DELETE FROM students WHERE nom=@Nom"
                cmd.Parameters.AddWithValue("@Nom", nom)
                cmd.ExecuteNonQuery()
                element.Remove()
                Dim formAjout = New Etudiants2
                formAjout.ShowDialog()
                RemplirListView()
            Else
                MsgBox("Il Faut Selectioner Un Etudiant A Modifier")
            End If

        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click

        Try
            If ListViewStudents.SelectedItems.Count = 1 Then
                Dim element As ListViewItem = ListViewStudents.SelectedItems(0)
                Dim nom As String = element.SubItems(0).Text
                Dim connection = BaseDeDonne.Connect()
                Dim cmd As MySqlCommand = connection.CreateCommand
                cmd.CommandText = "DELETE FROM students WHERE nom=@Nom"
                cmd.Parameters.AddWithValue("@Nom", nom)
                cmd.ExecuteNonQuery()
                element.Remove()
                MsgBox("Etudiant Supprimé")
            Else
                MsgBox("Il Faut Selectioner Un Etudiant A Supprimer")
            End If

        Catch ex As Exception
            Util.ManageError(ex)
        End Try


    End Sub

    Private Sub ListViewStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewStudents.SelectedIndexChanged

    End Sub

End Class
