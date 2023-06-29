
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Zone

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        frmTourne.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            chaine_connection()

            If txtnum_zone.Text = "" Then
                MsgBox("veuillez entrer le numero de la zone")
                txtnum_zone.Focus()
                Exit Sub
            End If
            Call chaine_connection()
            Dim cmd As New SqlCommand("Insert into ZONE(NUME_ZONE) values(@numero)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@numero"
            param.SqlDbType = SqlDbType.Int
            param.Value = txtnum_zone.Text
            cmd.Parameters.Add(param)

            cmd.ExecuteNonQuery()
            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de la Zone N° " & txtnum_zone.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MsgBox("ENREGISTREMENT EFFECTUE AVEC SUCCES")
            affiche_zone()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtnum_zone.Text = ""


        Dim cmnd As New SqlCommand("select NUME_ZONE as Zone  From ZONE")
        cmnd.Connection = conx
        Dim adpt = New SqlDataAdapter(cmnd)
        Dim ta As New DataTable
        adpt.Fill(ta)
        dgvzone.DataSource = ta
    End Sub

    Private Sub Zone_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim da As New SqlDataAdapter
        'Dim ds As New DataSet

        'chaine_connection()

        'cmd.Connection = conx

        'cmd.CommandText = " SELECT NUME_ZONE as ZONE FROM ZONE"

        'da.SelectCommand = cmd

        'da.Fill(ds, "ZONE")

        'dgvzone.DataSource = ds.Tables("ZONE")



    End Sub

    Private Sub dgvzone_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvzone.CellDoubleClick
        txtnum_zone.Text = dgvzone.CurrentRow.Cells(0).Value.ToString
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            chaine_connection()

            Dim cmd As New SqlCommand("UPDATE ZONE SET NUME_ZONE='" & txtnum_zone.Text & "'  where NUME_ZONE='" & txtnum_zone.Text & "'")
            cmd.Connection = conx
            Dim adapt = New SqlDataAdapter(cmd)
            Dim t As New DataTable
            adapt.Fill(t)
            dgvzone.DataSource = t

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de la zone N° " & txtnum_zone.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Modification effectuée avec succès")
            affiche_zone()

            Button1.Visible = False
            Button2.Visible = True
            Button3.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If dgvzone.CurrentRow.Cells(0).Value().ToString() <> "" Then
                chaine_connection()
                Dim cmdx As New SqlCommand
                cmdx.CommandText = "select * from TOURNE where(NUME_ZONE='" & dgvzone.CurrentRow.Cells(0).Value.ToString & "')"
                cmdx.Connection = conx
                Dim rde As SqlDataReader = cmdx.ExecuteReader
                If Not rde.Read Then

                    Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmation = DialogResult.Yes Then
                        chaine_connection()
                        Dim cmd As New SqlCommand
                        cmd.CommandText = "delete from ZONE where(NUME_ZONE=@code)"
                        cmd.Connection = conx

                        Dim param As New SqlParameter
                        param.ParameterName = "@code"
                        param.SqlDbType = SqlDbType.NVarChar
                        param.Value = dgvzone.CurrentRow.Cells(0).Value.ToString
                        cmd.Parameters.Add(param)

                        txtnum_zone.Text = ""

                        Dim zon As String = dgvzone.CurrentRow.Cells(0).Value().ToString()

                        cmd.ExecuteNonQuery()

                        Dim c As New SqlCommand
                        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de la zone N° " & zon & "','" & Date.Now & "')"
                        c.Connection = conx
                        c.ExecuteNonQuery()

                        MessageBox.Show("Suppression Effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        affiche_zone()

                    End If
                Else
                    MessageBox.Show("il y a des batiment associer a cette tournée, vous ne pouvez donc pas la supprimer")
                End If
            Else
                MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class