Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Service


    Private Sub btnvalider_Click(sender As Object, e As EventArgs) Handles btnvalider.Click
        Try
            If txtlibelle_service.Text = "" Then
                MsgBox("VEUILLEZ ENTRER LE LIBELLE")
                txtlibelle_service.Focus()
                Exit Sub
            End If

            Call chaine_connection()
            Dim cmd As New SqlCommand("Insert into SERVICE (NOM_SERVICE) values (@libelle)")
            cmd.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@libelle"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtlibelle_service.Text
            cmd.Parameters.Add(param1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES")

            affiche_service()

            txtlibelle_service.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        affiche_service()

        btn_supprim.Enabled = False
        btnmodifier.Enabled = False

    End Sub

    Private Sub btnmodifier_Click(sender As Object, e As EventArgs) Handles btnmodifier.Click
        Try
            If txtlibelle_service.Text = "" Then
                MsgBox("VEUILLEZ ENTRER LE LIBELLE")
                txtlibelle_service.Focus()
                Exit Sub
            End If

            Call chaine_connection()
            Dim cmd As New SqlCommand("update SERVICE set NOM_SERVICE=@libelle where num_serv=@num")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@libelle"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtlibelle_service.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@num"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = i
            cmd.Parameters.Add(param1)

            cmd.ExecuteNonQuery()
            MessageBox.Show("MODIFICATION EFFECTUEE AVEC SUCCES")

            affiche_service()

            txtlibelle_service.Text = ""

            btnvalider.Enabled = True
            btnmodifier.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim i As String

    Private Sub dgv_service_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_service.CellDoubleClick

        i = dgv_service.CurrentRow.Cells(0).Value.ToString
        txtlibelle_service.Text = dgv_service.CurrentRow.Cells(1).Value.ToString

        btnvalider.Enabled = False
        btnmodifier.Enabled = True

    End Sub

    Private Sub txtlibelle_service_TextChanged(sender As Object, e As EventArgs) Handles txtlibelle_service.TextChanged
        If txtlibelle_service.Text <> "" Then
            btn_supprim.Enabled = True
        Else
            btn_supprim.Enabled = False
        End If
    End Sub

    Private Sub btn_annul_Click(sender As Object, e As EventArgs)

        txtlibelle_service.Text = ""
        btnvalider.Enabled = True
        btnmodifier.Enabled = False
        btn_supprim.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If dgv_service.CurrentRow.Cells(0).Value.ToString <> "" Then
            MsgBox("Voulez-vous vraiment effectuer cette suppression ?", MsgBoxStyle.YesNo)
            If vbYes Then

                Try
                    chaine_connection()

                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from SERVICE where(NOM_SERVICE=@NOM)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@NOM"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgv_service.CurrentRow.Cells(1).Value.ToString
                    cmd.Parameters.Add(param)

                    txtlibelle_service.Text = ""

                    cmd.ExecuteNonQuery()
                    affiche_service()

                    btnvalider.Enabled = True
                    btnmodifier.Enabled = False
                    btn_supprim.Enabled = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_supprim.Click
        Try
            If dgv_service.CurrentRow.Cells(0).Value().ToString() <> "" Then
                chaine_connection()
                Dim cmdx As New SqlCommand
                cmdx.CommandText = "select * from PERSONNEL where(NOM_SERVICE='" & dgv_service.CurrentRow.Cells(1).Value().ToString() & "')"
                cmdx.Connection = conx
                Dim rde As SqlDataReader = cmdx.ExecuteReader
                If Not rde.Read Then

                    Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmation = DialogResult.Yes Then
                        chaine_connection()
                        Dim cmd As New SqlCommand
                        cmd.CommandText = "delete from SERVICE where NOM_SERVICE=@code"
                        cmd.Connection = conx

                        Dim param As New SqlParameter
                        param.ParameterName = "@code"
                        param.SqlDbType = SqlDbType.NVarChar
                        param.Value = dgv_service.CurrentRow.Cells(1).Value.ToString
                        cmd.Parameters.Add(param)

                        txtlibelle_service.Text = ""

                        Dim serv As String = dgv_service.CurrentRow.Cells(0).Value().ToString()

                        cmd.ExecuteNonQuery()

                        Dim c As New SqlCommand
                        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression du service N° " & serv & "','" & Date.Now & "')"
                        c.Connection = conx
                        c.ExecuteNonQuery()

                        MessageBox.Show("Suppression Effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        affiche_service()

                    End If
                Else
                    MessageBox.Show("il y a des personnels associer a ce service, vous ne pouvez donc pas le supprimer")
                End If
            Else
                MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class