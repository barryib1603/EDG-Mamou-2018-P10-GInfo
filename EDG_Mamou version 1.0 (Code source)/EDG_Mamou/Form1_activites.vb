Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1_activites

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((cb_uti.Checked = False) And (cb_dat.Checked = False)) Then
            MessageBox.Show("Veuillez Selectionner une option de Recherche", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If ((cb_uti.Checked = True) And (cb_dat.Checked = True)) Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_ACT as Numéros,UTILISATEUR as Utilisateurs,DESCRIPTION_ACT as Descriptions,DATE_ACT as Dates from ACTIVITE_UTILISATEUR where UTILISATEUR LIKE '" & cbx_utili.SelectedItem & "' and DATE_ACT like '" & txt_dat.Text & "'  order by DATE_ACT desc"
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_activite.DataSource = ds
        ElseIf ((cb_uti.Checked = True) And (cb_dat.Checked = False)) Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_ACT as Numéros,UTILISATEUR as Utilisateurs,DESCRIPTION_ACT as Descriptions,DATE_ACT  as Dates from ACTIVITE_UTILISATEUR where UTILISATEUR LIKE '" & cbx_utili.SelectedItem & "'   order by DATE_ACT desc"
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_activite.DataSource = ds
        Else
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_ACT as Numéros,UTILISATEUR as Utilisateurs,DESCRIPTION_ACT as Descriptions,DATE_ACT  as Dates from ACTIVITE_UTILISATEUR where DATE_ACT like '" & txt_dat.Text & "'  order by DATE_ACT desc"
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_activite.DataSource = ds
        End If
    End Sub

    Private Sub Form1_activites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche_activite()
        combox_activte_utili()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        affiche_activite()
    End Sub
End Class