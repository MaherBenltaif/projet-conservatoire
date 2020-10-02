Imports MySql.Data.MySqlClient
Public Class ListeDesProfs
    Private Sub RemplirListView()
        ListViewProfs.Items.Clear()
        Try
            Dim connection = BaseDeDonne.Connect()
            Dim cmd As MySqlCommand = connection.CreateCommand
            cmd.CommandText = "Select * From proffesseurs"
            Dim resultat = cmd.ExecuteReader()
            While resultat.Read
                Dim item As ListViewItem = New ListViewItem(resultat.GetString("Nom"))
                item.SubItems.Add(resultat.GetString("Prenom"))
                item.SubItems.Add(resultat.GetString("Email"))
                item.SubItems.Add(resultat.GetString("Tel"))
                item.SubItems.Add(resultat.GetString("Adresse"))
                item.SubItems.Add(resultat.GetString("Classe"))
                item.SubItems.Add(resultat.GetString("Salaire"))
                ListViewProfs.Items.Add(item)
            End While
            resultat.Close()
            connection.Close()
        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub
    Private Sub ListeDesProfs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirListView()
    End Sub

    Private Sub btnRafraichir_Click(sender As Object, e As EventArgs) Handles btnRafraichir.Click
        RemplirListView()
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim formAjout = New Professeur
        formAjout.ShowDialog()
        RemplirListView()
    End Sub



    Private Sub btnEditer_Click(sender As Object, e As EventArgs) Handles btnEditer.Click
        Try
            If ListViewProfs.SelectedItems.Count = 1 Then
                Dim element As ListViewItem = ListViewProfs.SelectedItems(0)
                Dim nom As String = element.SubItems(0).Text
                Dim connection = BaseDeDonne.Connect()
                Dim cmd As MySqlCommand = connection.CreateCommand
                cmd.CommandText = "DELETE FROM proffesseurs WHERE nom=@Nom"
                cmd.Parameters.AddWithValue("@Nom", nom)
                cmd.ExecuteNonQuery()
                element.Remove()
                Dim formAjout = New Professeur2
                formAjout.ShowDialog()
                RemplirListView()
            Else
                MsgBox("Il Faut Selectioner Un Professeur A Modifier")
            End If

        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try
            If ListViewProfs.SelectedItems.Count = 1 Then
                Dim element As ListViewItem = ListViewProfs.SelectedItems(0)
                Dim nom As String = element.SubItems(0).Text
                Dim connection = BaseDeDonne.Connect()
                Dim cmd As MySqlCommand = connection.CreateCommand
                cmd.CommandText = "DELETE FROM proffesseurs WHERE nom=@Nom"
                cmd.Parameters.AddWithValue("@Nom", nom)
                cmd.ExecuteNonQuery()
                element.Remove()
                MsgBox("Professeurs Supprimé")
            Else
                MsgBox("Il Faut Selectioner Un Professeur A Supprimer")
            End If

        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub
End Class