Imports System.Data.SqlClient
Imports System.Data


Public Class Form1_sauvegarder_restaurer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lbl_chemin.Text <> "" Then
            Try
                chaine_connection()
                Dim dat As String = Format(DateTime.Now, "dd_MM_yyy_HH_mm_ss")
                Dim req As New SqlCommand
                req.CommandText = "BACKUP DATABASE EDG_Mamou_G8 TO DISK=N'" & lbl_chemin.Text & "\EDG_Mamou_" & dat & ".BAK'"
                req.Connection = conx
                req.ExecuteNonQuery()

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Sauvegarde de la base de données dans le repertoir " & lbl_chemin.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                MessageBox.Show("Sauvegarde effectuée avec succès !")
            Catch ex As Exception
                MessageBox.Show("Impossible d'effectuer la sauvegarde : ", ex.Message)
            End Try
        Else
            MessageBox.Show("Veuillez choisir un emplacement pour effectuer la sauvegarde")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        lbl_chemin.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class