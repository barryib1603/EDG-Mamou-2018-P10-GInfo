Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class UserControl1_Rapport

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1_Rapport.btn_ajout.Visible = True
        Form1_Rapport.btn_modifier.Visible = False
        Form1_Rapport.btn_annul.Visible = True

        Form1_Rapport.ShowDialog()
    End Sub

    Private Sub dgvrapport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrapport.CellClick
        If dgvrapport.CurrentRow.Cells(0).Value.ToString <> "" Then
            Lbl_num_rap.Text = dgvrapport.CurrentRow.Cells(0).Value.ToString
            Lbl_pers_rap.Text = dgvrapport.CurrentRow.Cells(1).Value.ToString
            Lbl_libelle_rap.Text = dgvrapport.CurrentRow.Cells(2).Value.ToString
            Rtbx_desc_rap.Text = dgvrapport.CurrentRow.Cells(3).Value.ToString
            Lbl_date_rap.Text = dgvrapport.CurrentRow.Cells(4).Value.ToString
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Lbl_num_rap.Text <> "" Then
            Form1_Rapport.txtnum_rapport.Text = Lbl_num_rap.Text
            Form1_Rapport.cmb_tpersonnel_rapport.Text = Lbl_pers_rap.Text
            Form1_Rapport.txtlibelle_rapport.Text = Lbl_libelle_rap.Text
            Form1_Rapport.rtxtdescription_rapport.Text = Rtbx_desc_rap.Text


            Form1_Rapport.btn_ajout.Visible = False
            Form1_Rapport.btn_modifier.Visible = True
            Form1_Rapport.btn_annul.Visible = False

            Form1_Rapport.ShowDialog()
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à modifier")
        End If
    End Sub

    Private Sub btn_supprim_Click(sender As Object, e As EventArgs) Handles btn_supprim.Click
        If dgvrapport.CurrentRow.Cells(0).Value.ToString <> "" Then
            Try
                Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmation = DialogResult.Yes Then
                    chaine_connection()
                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from RAPPORT_ADMIN where(NUM_RAP=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgvrapport.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    cmd.ExecuteNonQuery()
                    Dim c As New SqlCommand

                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression du Rapport N° " & Lbl_num_rap.Text & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()

                    MessageBox.Show("Suppression effectué avec Succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    affiche_rapport()
                    Lbl_libelle_rap.Text = ""
                    Lbl_num_rap.Text = ""
                    Lbl_pers_rap.Text = ""
                    Lbl_date_rap.Text = ""
                    Rtbx_desc_rap.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_Impression_Rapport.ShowDialog()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
