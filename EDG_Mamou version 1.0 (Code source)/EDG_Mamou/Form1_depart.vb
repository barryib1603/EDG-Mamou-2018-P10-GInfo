
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Form1_depart

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If txtnum_depart.Text = "" Then
                MsgBox("VEUILLEZ ENTRER LE NUMERO DU DEPART")
                txtnum_depart.Focus()
                Exit Sub
            End If

            If txtlibelle_dep.Text = "" Then
                MsgBox("veuillez entrer le NOM du depart")
                txtlibelle_dep.Focus()
                Exit Sub
            End If


            Call chaine_connection()
            Dim cmd As New SqlCommand("Insert into DEPART(Num_dep,libelle_dep) values(@numero,@libelle)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@numero"
            param.SqlDbType = SqlDbType.Int
            param.Value = txtnum_depart.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@libelle"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtlibelle_dep.Text
            cmd.Parameters.Add(param1)
            cmd.ExecuteNonQuery()

            affiche_depart()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du depart N° " & txtnum_depart.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES")
            txtlibelle_dep.Text = ""
            txtnum_depart.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_depart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche_depart()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgv_depart.CurrentRow.Cells(0).Value.ToString <> "" Then
            Dim confirmation As DialogResult

            confirmation = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = Windows.Forms.DialogResult.Yes Then

                Try
                    chaine_connection()

                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from DEPART where(Num_dep=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgv_depart.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    txtnum_depart.Text = ""
                    txtlibelle_dep.Text = ""

                    Dim num As String = dgv_depart.CurrentRow.Cells(0).Value().ToString()

                    cmd.ExecuteNonQuery()

                    affiche_depart()

                    Dim c As New SqlCommand
                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression du depart N° " & num & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()

                    MessageBox.Show("SUPPRESSION EFFECTUEE AVEC SUCCES")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        End If
    End Sub

    Private Sub dgv_depart_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_depart.CellDoubleClick
        If dgv_depart.CurrentRow.Cells(0).Value.ToString <> "" Then
            txtnum_depart.Text = dgv_depart.CurrentRow.Cells(0).Value.ToString
            txtlibelle_dep.Text = dgv_depart.CurrentRow.Cells(1).Value.ToString
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If txtnum_depart.Text = "" Then
                MsgBox("VEUILLEZ ENTRER LE NUMERO DU DEPART")
                txtnum_depart.Focus()
                Exit Sub
            End If

            If txtlibelle_dep.Text = "" Then
                MsgBox("veuillez entrer le NOM du depart")
                txtlibelle_dep.Focus()
                Exit Sub
            End If


            Call chaine_connection()
            Dim cmd As New SqlCommand("update DEPART set Num_dep=@numero,libelle_dep=@libelle where Num_dep=@numero")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@numero"
            param.SqlDbType = SqlDbType.Int
            param.Value = txtnum_depart.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@libelle"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtlibelle_dep.Text
            cmd.Parameters.Add(param1)
            cmd.ExecuteNonQuery()

            affiche_depart()
            affiche_depart()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification du depart N° " & txtnum_depart.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUEE AVEC SUCCES")

            txtlibelle_dep.Text = ""
            txtnum_depart.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtlibelle_dep_TextChanged(sender As Object, e As EventArgs) Handles txtlibelle_dep.TextChanged
        Try
            If txtlibelle_dep.Text <> "" Then
                chaine_connection()
                Dim cmnd12 As New SqlCommand
                cmnd12.CommandText = "select max(Num_dep) from DEPART"
                cmnd12.Connection = conx
                If Not IsDBNull(cmnd12.ExecuteScalar) Then
                    txtnum_depart.Text = Val(cmnd12.ExecuteScalar) + 1
                Else
                    txtnum_depart.Text = 1
                End If
            Else
                txtnum_depart.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class