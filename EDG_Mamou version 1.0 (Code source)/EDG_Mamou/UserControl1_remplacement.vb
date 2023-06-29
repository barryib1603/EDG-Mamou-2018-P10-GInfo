Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class UserControl1_remplacement

    Private Sub UserControl1_remplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chaine_connection()
        Dim cmn As New SqlCommand()
        cmn.CommandText = "select NUM_POSTE from POSTE"
        cmn.CommandType = CommandType.Text
        cmn.Connection = conx
        Dim dtrd As SqlDataReader = cmn.ExecuteReader
        cbxposte_remplacment.Items.Clear()
        While (dtrd.Read)
            cbxposte_remplacment.Items.Add(dtrd.Item(0))
        End While
        dtrd.Close()

        btn_modif.Enabled = False

        cmb_rechercher.SelectedItem = "Numéro"


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If txtnum_remplacement.Text = "" Then
                MessageBox.Show("Veuillez entrer le numéro")
                txtnum_remplacement.Focus()
                Exit Sub
            End If

            If cbxposte_remplacment.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Poste ")
                cbxposte_remplacment.Focus()
                Exit Sub
            End If
            If txtnouv_puis_remplacemt.Text = "" Then
                MessageBox.Show("Veuillez entrer la nouvelle puissance")
                txtnouv_puis_remplacemt.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select * from REMPLACEMENT where(NUM_REMP=@NUM)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@NUM"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtnum_remplacement.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtnum_remplacement.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into REMPLACEMENT(NUM_REMP,NUM_POSTE,NOUV_PUI,DATE_REMP,ANCIEN_PUISS) values (@nume,@poste,@nouv,@date,@ancienpuiss)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@nume"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_remplacement.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@poste"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = cbxposte_remplacment.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@nouv"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtnouv_puis_remplacemt.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@date"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = dtp_remplace.Text
            cmd.Parameters.Add(param3)

            Dim param57 As New SqlParameter
            param57.ParameterName = "@ancienpuiss"
            param57.SqlDbType = SqlDbType.NVarChar
            param57.Value = txt_ancien_puis_remplacemt.Text
            cmd.Parameters.Add(param57)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Enregistrement dun Remplacement sur le poste " & cbxposte_remplacment.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")

            Dim cm0 As New SqlCommand
            cm0.CommandText = "UPDATE POSTE set PUISSNCE_NOMI=@PUISS where (NUM_POSTE=@POST)"
            cm0.Connection = conx

            Dim param55 As New SqlParameter
            param55.ParameterName = "@PUISS"
            param55.SqlDbType = SqlDbType.NVarChar
            param55.Value = txtnouv_puis_remplacemt.Text
            cm0.Parameters.Add(param55)

            Dim param56 As New SqlParameter
            param56.ParameterName = "@POST"
            param56.SqlDbType = SqlDbType.NVarChar
            param56.Value = cbxposte_remplacment.Text
            cm0.Parameters.Add(param56)

            cm0.ExecuteNonQuery()
            affiche_poste()

            txtnum_remplacement.Text = ""
            cbxposte_remplacment.Text = ""
            txtnouv_puis_remplacemt.Text = ""
            dtp_remplace.Value = Date.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage affectation
        affiche_remplacement()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtnum_remplacement.Text = ""
        cbxposte_remplacment.Text = ""
        txtnouv_puis_remplacemt.Text = ""
        dtp_remplace.Value = Date.Now
    End Sub

    Private Sub btn_modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click
        If txtnum_remplacement.Text <> "" Then

            Try
                Call chaine_connection()

                Dim cmd As New SqlCommand("UPDATE REMPLACEMENT SET NUM_REMP=@nume,NUM_POSTE=@poste,NOUV_PUI=@nouv,DATE_REMP=@date where NUM_REMP=@nume")
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@nume"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = txtnum_remplacement.Text
                cmd.Parameters.Add(param)

                Dim param1 As New SqlParameter
                param1.ParameterName = "@poste"
                param1.SqlDbType = SqlDbType.Int
                param1.Value = cbxposte_remplacment.Text
                cmd.Parameters.Add(param1)

                Dim param2 As New SqlParameter
                param2.ParameterName = "@nouv"
                param2.SqlDbType = SqlDbType.NVarChar
                param2.Value = txtnouv_puis_remplacemt.Text
                cmd.Parameters.Add(param2)

                Dim param3 As New SqlParameter
                param3.ParameterName = "@date"
                param3.SqlDbType = SqlDbType.NVarChar
                param3.Value = dtp_remplace.Text
                cmd.Parameters.Add(param3)

                cmd.ExecuteNonQuery()

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification des Informations du Remplacement du poste " & cbxposte_remplacment.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                MessageBox.Show("Modification effectuée avec succès")

                txtnum_remplacement.Text = ""
                cbxposte_remplacment.Text = ""
                txtnouv_puis_remplacemt.Text = ""
                dtp_remplace.Value = Date.Now

                btn_modif.Enabled = False
                Button5.Enabled = True
                Button6.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Aucun élément à modifier n'a été selectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'procedure affichage affectation
        affiche_remplacement()
    End Sub

    Private Sub dgv_remplacement_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_remplacement.CellDoubleClick
        If dgv_remplacement.CurrentRow.Cells(0).Value.ToString <> "" Then
            txtnum_remplacement.Text = dgv_remplacement.CurrentRow.Cells(0).Value.ToString
            cbxposte_remplacment.Text = dgv_remplacement.CurrentRow.Cells(1).Value.ToString
            txtnouv_puis_remplacemt.Text = dgv_remplacement.CurrentRow.Cells(2).Value.ToString
            dtp_remplace.Text = dgv_remplacement.CurrentRow.Cells(3).Value.ToString
            txt_ancien_puis_remplacemt.Text = dgv_remplacement.CurrentRow.Cells(4).Value.ToString
            btn_modif.Enabled = True
            Button5.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub btn_suppr_Click(sender As Object, e As EventArgs) Handles btn_suppr.Click
        If dgv_remplacement.CurrentRow.Cells(0).Value.ToString <> "" Then
            Try
                Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmation = DialogResult.Yes Then
                    chaine_connection()
                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from REMPLACEMENT where(NUM_REMP=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgv_remplacement.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    cmd.ExecuteNonQuery()

                    Dim c As New SqlCommand
                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression du Remplacement du Poste N°" & cbxposte_remplacment.Text & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()

                    MessageBox.Show("Suppression effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    affiche_remplacement()
                    txt_ancien_puis_remplacemt.Text = ""
                    txtnouv_puis_remplacemt.Text = ""
                    txtnum_remplacement.Text = ""
                    cbxposte_remplacment.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmb_rechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_rechercher.SelectedIndexChanged
        If cmb_rechercher.SelectedItem = "Date" Then
            dtp_rechercher.Visible = True
            txt_rechercher.Visible = False
        Else
            dtp_rechercher.Visible = False
            txt_rechercher.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand("select NUM_REMP as Numéros,NUM_POSTE as Postes,NOUV_PUI as [Nouvelles puissances],DATE_REMP as Dates from REMPLACEMENT where NUM_REMP=@num")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_rechercher.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_remplacement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If
        If cmb_rechercher.SelectedItem = "Poste" Then
            Dim cmd As New SqlCommand("select NUM_REMP as Numéros,NUM_POSTE as Postes,NOUV_PUI as [Nouvelles puissances],DATE_REMP as Dates from REMPLACEMENT where NUM_POSTE=@Poste")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@poste"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_rechercher
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_remplacement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas eu de remplacement sur ce Poste")

            End If

        End If

        If cmb_rechercher.SelectedItem = "Date" Then
            Dim cmd As New SqlCommand("select NUM_REMP as Numéros,NUM_POSTE as Postes,NOUV_PUI as [Nouvelles puissances],DATE_REMP as Dates from REMPLACEMENT where DATE_REMP like'" & dtp_rechercher.Value & "%'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_remplacement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas eu de remplacement à cette date")

            End If

        End If
    End Sub

    Private Sub txt_rechercher_TextChanged(sender As Object, e As EventArgs) Handles txt_rechercher.TextChanged
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand("select NUM_REMP as Numéros,NUM_POSTE as Postes,NOUV_PUI as [Nouvelles puissances],DATE_REMP as Dates from REMPLACEMENT where NUM_REMP like '%" & txt_rechercher.Text & "%'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_remplacement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If
        If cmb_rechercher.SelectedItem = "Poste" Then
            Dim cmd As New SqlCommand("select NUM_REMP as Numéros,NUM_POSTE as Postes,NOUV_PUI as [Nouvelles puissances],DATE_REMP as Dates from REMPLACEMENT where NUM_POSTE like '%" & txt_rechercher.Text & "%'")
            cmd.Connection = conx
            
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_remplacement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If

    End Sub

    Private Sub cbxposte_remplacment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxposte_remplacment.SelectedIndexChanged
        Try
            chaine_connection()
            Dim cmd As New SqlCommand
            cmd.CommandText = "select PUISSNCE_NOMI from POSTE where NUM_POSTE=@puissance"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@puissance"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cbxposte_remplacment.Text
            cmd.Parameters.Add(param)

            txt_ancien_puis_remplacemt.Text = cmd.ExecuteScalar().ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgv_remplacement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_remplacement.CellContentClick

    End Sub

    Private Sub dgv_remplacement_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_remplacement.CellEndEdit

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_impression_remplacement.ShowDialog()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
