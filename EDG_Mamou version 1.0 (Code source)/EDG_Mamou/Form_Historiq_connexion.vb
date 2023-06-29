Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Form_Historiq_connexion

    Private Sub Form_Historiq_connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        combox_hist_conex_utili()

        affiche_historique_connexion()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((cb_uti.Checked = False) And (cb_dat.Checked = False)) Then
            MessageBox.Show("Veuillez Selectionner une option de Recherche", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If ((cb_uti.Checked = True) And (cb_dat.Checked = True)) Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_HIST as[Numero],UTILISATEUR as Utilisateur,ACTION_H as Action,DATE_ACTION as Date from HISTORIQUE_CONNEXION where UTILISATEUR LIKE '" & cbx_utili.SelectedItem & "' and DATE_ACTION like '" & txt_dat.Text & "'  order by DATE_ACTION desc"
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridView1.DataSource = ds
        ElseIf ((cb_uti.Checked = True) And (cb_dat.Checked = False)) Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_HIST as[Numero],UTILISATEUR as Utilisateur,ACTION_H as Action,DATE_ACTION as Date from HISTORIQUE_CONNEXION where UTILISATEUR LIKE '" & cbx_utili.SelectedItem & "'   order by DATE_ACTION desc"
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridView1.DataSource = ds
        Else
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_HIST as[Numero],UTILISATEUR as Utilisateur,ACTION_H as Action,DATE_ACTION as Date from HISTORIQUE_CONNEXION where DATE_ACTION like '" & txt_dat.Text & "'  order by DATE_ACTION desc"
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridView1.DataSource = ds
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        affiche_historique_connexion()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class