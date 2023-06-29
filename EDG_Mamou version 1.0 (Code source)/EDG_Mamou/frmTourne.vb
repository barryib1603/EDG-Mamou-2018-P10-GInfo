Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class frmTourne

    Private Sub frmTourne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call chaine_connection()
        Call affiche_toune()

        Dim cm As New SqlCommand()
        cm.CommandText = "select NUME_ZONE from ZONE"
        cm.CommandType = CommandType.Text
        cm.Connection = conx
        Dim dt As SqlDataReader = cm.ExecuteReader
        cbxzone_tourne.Items.Clear()
        While (dt.Read)
            cbxzone_tourne.Items.Add(dt.Item(0))
        End While
        dt.Close()

        cbxrecherche_tourne.SelectedItem = "Tournée"

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Zone.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If Txt_num_tourne.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Identifiant du Batiment")
                Txt_num_tourne.Focus()
                Exit Sub
            End If

            If cbxzone_tourne.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom du Proprietaire ")
                cbxzone_tourne.Focus()
                Exit Sub
            End If

            Call chaine_connection()


            Dim cmd0 As New SqlCommand("select * from TOURNE where(CODE_TOURNE=@CODE)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@CODE"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = Txt_id_tourne.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                Txt_id_tourne.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into TOURNE(CODE_TOURNE,NUM_TOURNE,NUME_ZONE) values (@CODE,@NUM,@ZONE)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@CODE"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = Txt_id_tourne.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@NUM"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = Txt_num_tourne.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@ZONE"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cbxzone_tourne.Text
            cmd.Parameters.Add(param2)

            cmd.ExecuteNonQuery()
            
            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de la tournée N° " & Txt_id_tourne.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")
            Txt_id_tourne.Text = ""
            Txt_num_tourne.Text = ""
            cbxzone_tourne.Text = ""

            frmBatiments.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage TOURNE
        affiche_toune()
    End Sub

    Private Sub Txt_num_tourne_Leave(sender As Object, e As EventArgs) Handles Txt_num_tourne.Leave
        If Txt_num_tourne.TextLength = 1 Then
            Txt_num_tourne.Text = "00" + Txt_num_tourne.Text
        ElseIf Txt_num_tourne.TextLength = 2 Then
            Txt_num_tourne.Text = "0" + Txt_num_tourne.Text
        End If
    End Sub

    Private Sub Txt_num_tourne_MouseLeave(sender As Object, e As EventArgs) Handles Txt_num_tourne.MouseLeave
        
    End Sub

    Private Sub Txt_num_tourne_TextChanged(sender As Object, e As EventArgs) Handles Txt_num_tourne.TextChanged
        
        Txt_id_tourne.Text = cbxzone_tourne.Text + "-" + Txt_num_tourne.Text
    End Sub

    Private Sub cbxzone_tourne_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxzone_tourne.SelectedIndexChanged
        Txt_id_tourne.Text = cbxzone_tourne.Text + "-" + Txt_num_tourne.Text
    End Sub

    Private Sub cbxzone_tourne_TextChanged(sender As Object, e As EventArgs) Handles cbxzone_tourne.TextChanged
        Txt_id_tourne.Text = cbxzone_tourne.Text + "-" + Txt_num_tourne.Text
    End Sub

    Private Sub dgv_toune_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_toune.CellDoubleClick
        Txt_id_tourne.Text = dgv_toune.CurrentRow.Cells(0).Value.ToString
        Txt_num_tourne.Text = dgv_toune.CurrentRow.Cells(1).Value.ToString
        cbxzone_tourne.Text = dgv_toune.CurrentRow.Cells(2).Value.ToString

        Button6.Visible = True
        Button4.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try
            If Txt_num_tourne.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Identifiant du Batiment")
                Txt_num_tourne.Focus()
                Exit Sub
            End If

            If cbxzone_tourne.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom du Proprietaire ")
                cbxzone_tourne.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand("UPDATE TOURNE SET CODE_TOURNE=@code, NUM_TOURNE=@num, NUME_ZONE=@zone where CODE_TOURNE=@code")
            cmd.Connection = conx

            Dim param20 As New SqlParameter
            param20.ParameterName = "@code"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = Txt_id_tourne.Text
            cmd.Parameters.Add(param20)

            Dim param21 As New SqlParameter
            param21.ParameterName = "@num"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = Txt_num_tourne.Text
            cmd.Parameters.Add(param21)

            Dim param22 As New SqlParameter
            param22.ParameterName = "@zone"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = cbxzone_tourne.Text
            cmd.Parameters.Add(param22)

            affiche_toune()

            Button6.Visible = False
            Button4.Visible = True
            Button5.Visible = True



            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de la tournée N° " & Txt_id_tourne.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chaine_connection()

        If (cbxrecherche_tourne.SelectedItem = "Tournée") Then
            Dim cmd As New SqlCommand("select CODE_TOURNE as Identifiants, NUM_TOURNE as Numéros, NUME_ZONE as ZONES from TOURNE where NUM_TOURNE=@NUM")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_tourne.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_toune.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("cette Tournée n'existe pas")

            End If
        End If
        If cbxrecherche_tourne.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand("select CODE_TOURNE as Identifiants, NUM_TOURNE as Numéros, NUME_ZONE as ZONES from TOURNE where NUME_ZONE=@zone")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@zone"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_tourne.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_toune.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de Turnée dans cette Zone")

            End If
        End If
    End Sub

    Private Sub txtrecherche_tourne_TextChanged(sender As Object, e As EventArgs) Handles txtrecherche_tourne.TextChanged
        chaine_connection()

        If (cbxrecherche_tourne.SelectedItem = "Tournée") Then
            Dim cmd As New SqlCommand("select CODE_TOURNE as Identifiants, NUM_TOURNE as Numéros, NUME_ZONE as ZONES from TOURNE where NUM_TOURNE like '%" & txtrecherche_tourne.Text & "%'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_tourne.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_toune.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If
        If cbxrecherche_tourne.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand("select CODE_TOURNE as Identifiants, NUM_TOURNE as Numéros, NUME_ZONE as ZONES from TOURNE where NUME_ZONE like '%" & txtrecherche_tourne.Text & "%'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@zone"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_tourne.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_toune.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If dgv_toune.CurrentRow.Cells(0).Value().ToString() <> "" Then
                chaine_connection()
                Dim cmdx As New SqlCommand
                cmdx.CommandText = "select * from BATIMENT where(NUM_TOURNE='" & dgv_toune.CurrentRow.Cells(0).Value.ToString & "')"
                cmdx.Connection = conx
                Dim rde As SqlDataReader = cmdx.ExecuteReader
                If Not rde.Read Then

                    Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmation = DialogResult.Yes Then
                        chaine_connection()
                        Dim cmd As New SqlCommand
                        cmd.CommandText = "delete from TOURNE where(CODE_TOURNE=@code)"
                        cmd.Connection = conx

                        Dim param As New SqlParameter
                        param.ParameterName = "@code"
                        param.SqlDbType = SqlDbType.NVarChar
                        param.Value = dgv_toune.CurrentRow.Cells(0).Value.ToString
                        cmd.Parameters.Add(param)

                        Txt_id_tourne.Text = ""
                        Txt_num_tourne.Text = ""
                        cbxzone_tourne.Text = ""

                        Dim tourn As String = dgv_toune.CurrentRow.Cells(0).Value().ToString()

                        cmd.ExecuteNonQuery()

                        Dim c As New SqlCommand
                        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de la tournée N° " & tourn & "','" & Date.Now & "')"
                        c.Connection = conx
                        c.ExecuteNonQuery()

                        MessageBox.Show("Suppression Effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        affiche_toune()

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

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class