Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class UserControl1_evenement

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1_Evenement.btnModifier_ev.Visible = False
        Form1_Evenement.Button1.Visible = True
        Form1_Evenement.Button2.Visible = True

        Form1_Evenement.txtnum_even.ReadOnly = False

        Form1_Evenement.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If lbl_num_even.Text = "" Then
            MessageBox.Show("Vous n'avez selectionné aucun élément à modifier")
        Else
            Form1_Evenement.txtnum_even.Text = lbl_num_even.Text
            Form1_Evenement.txtlibelle_even.Text = lbllibelle_even.Text
            Form1_Evenement.cmb_agent.Text = lblagent_even.Text
            Form1_Evenement.cmb_poste.Text = lblposte_even.Text
            Form1_Evenement.cmb_zone.Text = lblzone_even.Text
            Form1_Evenement.dtpdebut.Text = lbldate_debut_even.Text
            Form1_Evenement.dtpfin.Text = lbldate_fin_even.Text
            Form1_Evenement.rtxt_evensur_even.Text = rtxt_eve_sur_even.Text

            Form1_Evenement.btnModifier_ev.Visible = True
            Form1_Evenement.Button1.Visible = False
            Form1_Evenement.Button2.Visible = False

            Form1_Evenement.txtnum_even.ReadOnly = True

            Form1_Evenement.ShowDialog()
        End If

    End Sub

    Private Sub dgvevenement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvevenement.CellClick
        If dgvevenement.CurrentRow.Cells(0).Value.ToString <> "" Then
            lbl_num_even.Text = dgvevenement.CurrentRow.Cells(0).Value.ToString
            lblagent_even.Text = dgvevenement.CurrentRow.Cells(1).Value.ToString
            lblposte_even.Text = dgvevenement.CurrentRow.Cells(2).Value.ToString
            lblzone_even.Text = dgvevenement.CurrentRow.Cells(3).Value.ToString
            lbllibelle_even.Text = dgvevenement.CurrentRow.Cells(4).Value.ToString
            rtxt_eve_sur_even.Text = dgvevenement.CurrentRow.Cells(5).Value.ToString
            lbldate_debut_even.Text = dgvevenement.CurrentRow.Cells(6).Value.ToString
            lbldate_fin_even.Text = dgvevenement.CurrentRow.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where(NUM_EV=@NUM)"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_even.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
            lire.Close()
        End If
        If cmb_rechercher.SelectedItem = "Agent" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where(MAT=@Mat)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@Mat"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_even.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)

            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Cet Agent n'a pas effectué de taches")

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Poste" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where(NUM_POSTE=@NUME)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUME"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_even.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Aucune tabhe n'est réalisée sur ce Poste")

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where(NUME_ZONE=@NUM_Z)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM_Z"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_even.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Aucune tabhe n'est réalisée sur ce Poste")

            End If
            lire.Close()
        End If

    End Sub

    Private Sub txtrecherche_even_TextChanged(sender As Object, e As EventArgs) Handles txtrecherche_even.TextChanged
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where NUM_EV like '%" & txtrecherche_even.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If
        If cmb_rechercher.SelectedItem = "Agent" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where MAT like '%" & txtrecherche_even.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)

            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Poste" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where NUM_POSTE like '%" & txtrecherche_even.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT where NUME_ZONE like '%" & txtrecherche_even.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If
    End Sub

    Private Sub UserControl1_evenement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_rechercher.SelectedItem = "Numéro"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If lbl_num_even.Text <> "" Then
            Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then
                chaine_connection()
                Dim cmd As New SqlCommand
                cmd.CommandText = "delete from EVENEMENT where(NUM_EV=@code)"
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@code"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = dgvevenement.CurrentRow.Cells(0).Value.ToString
                cmd.Parameters.Add(param)

                cmd.ExecuteNonQuery()

                Dim c1 As New SqlCommand
                c1.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de l evenement N° " & lbl_num_even.Text & "','" & Date.Now & "')"
                c1.Connection = conx
                c1.ExecuteNonQuery()

                MessageBox.Show("Suppression Effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                lbl_num_even.Text = ""
                lblagent_even.Text = ""
                lblposte_even.Text = ""
                lblzone_even.Text = ""
                lbllibelle_even.Text = ""
                lbldate_debut_even.Text = ""
                lbldate_fin_even.Text = ""
                rtxt_eve_sur_even.Text = ""

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de l'évènement N° " & lbl_num_even.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                affiche_evenement()

            End If
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            chaine_connection()
            If dgvevenement.CurrentRow.Cells(0).Value.ToString <> "" Then


                Dim cmd As New SqlCommand
                cmd.CommandText = "select * from EVENEMENT where(NUM_EV=@NUM)"
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@NUM"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = dgvevenement.CurrentRow.Cells(0).Value.ToString
                cmd.Parameters.Add(param)

                Dim adatp = New SqlDataAdapter(cmd)
                adatp.Fill(Form_impression_evenement.EDG_Mamou_G8DataSet.EVENEMENT1)

                conx.Close()
                Form_impression_evenement.ReportViewer1.RefreshReport()
                Form_impression_evenement.ShowDialog()

            Else
                MessageBox.Show("Aucun élément selectionné")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub dgvevenement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvevenement.CellContentClick

    End Sub
End Class
