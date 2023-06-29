Imports System.Data.SqlClient
Imports System.Data

Public Class Form1_statitstique

    Private Sub Form1_statitstique_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim anee As Integer
        cmb_annee_recherche.Items.Clear()
        For anee = 2000 To (Year(Date.Today))
            cmb_annee_recherche.Items.Add(anee)
        Next

        affiche_statitique()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmb_annee_recherche.Text <> "" And cmb_mois_recherche.Text <> "" Then



        End If
    End Sub
End Class