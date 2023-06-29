Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Public Class UserControl1_utilisateur

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("voulez vous vraiment desactive ce compte", MsgBoxStyle.YesNo)
    End Sub

   Private Sub UserControl1_utilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbdesactiver.Checked = True
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Try
            If txtNom.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom de L'Utilisateur ")
                txtNom.Focus()
                Exit Sub
            End If
            If txtLogin.Text = "" Then
                MessageBox.Show("Veuillez entrer le Login De L'Utilisateur")
                txtLogin.Focus()
                Exit Sub
            End If
            If txtMotPasse.Text = "" Then
                MessageBox.Show("Veuillez Entrer Le Mot De Passe")
                txtMotPasse.Focus()
                Exit Sub
            End If

            If cbx_droit.Text = "" Then
                MessageBox.Show("Veuillez entrer Le Droit")
                cbx_droit.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select *from UTILISATEUR where(NOM_UT=@nom)")
            cmd0.Connection = conx

            Dim par As New SqlParameter
            par.ParameterName = "@nom"
            par.SqlDbType = SqlDbType.NVarChar
            par.Value = txtNom.Text
            cmd0.Parameters.Add(par)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce Nom d'Utilisateur existe déjà")
                txtNom.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into UTILISATEUR(NOM_UT,LOGIN_UT,M_PASSE_UT,DATE_CREA,STATUT,droit) values (@nom,@login,@mp,@date,@statut,@droit)")
            cmd.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@nom"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtNom.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@login"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtLogin.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@mp"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtMotPasse.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@date"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = Date.Now()
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@droit"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = cbx_droit.Text
            cmd.Parameters.Add(param5)

            Dim para As New SqlParameter
            para.ParameterName = "@statut"
            para.SqlDbType = SqlDbType.NVarChar
            If rbActiver.Checked = True Then
              
                para.Value = "Activé"
                cmd.Parameters.Add(para)
            Else
                para.Value = "Desactivé"
                cmd.Parameters.Add(para)
            End If

            cmd.ExecuteNonQuery()
            combox_hist_conex_utili()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de L'utilisateur " & txtNom.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")

            txtLogin.Text = ""
            txtNom.Text = ""
            txtMotPasse.Text = ""
            rbdesactiver.Checked = True
            cbx_droit.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        affiche_Utilisateur()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Try
            If txtNom.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom de L'Utilisateur ")
                txtNom.Focus()
                Exit Sub
            End If
            If txtLogin.Text = "" Then
                MessageBox.Show("Veuillez entrer le Login De L'Utilisateur")
                txtLogin.Focus()
                Exit Sub
            End If
            If txtMotPasse.Text = "" Then
                MessageBox.Show("Veuillez Entrer Le Mot De Passe")
                txtMotPasse.Focus()
                Exit Sub
            End If

            If cbx_droit.Text = "" Then
                MessageBox.Show("Veuillez entrer Le Droit")
                cbx_droit.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd As New SqlCommand("update UTILISATEUR set LOGIN_UT=@login,M_PASSE_UT=@mp,DROIT=@droit,STATUT=@statut where NOM_UT=@nom")
            cmd.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@nom"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtNom.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@login"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtLogin.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@mp"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtMotPasse.Text
            cmd.Parameters.Add(param3)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@droit"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = cbx_droit.Text
            cmd.Parameters.Add(param5)

            Dim para As New SqlParameter
            para.ParameterName = "@statut"
            para.SqlDbType = SqlDbType.NVarChar
            If rbActiver.Checked = True Then
                para.Value = "Activé"
            Else
                para.Value = "Desactivé"
            End If
            cmd.Parameters.Add(para)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification des Informations de Lutilisateur " & txtNom.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()
            combox_hist_conex_utili()

            MessageBox.Show("Modification effectuée avec succès")

            txtLogin.Text = ""
            txtNom.Text = ""
            txtMotPasse.Text = ""
            rbdesactiver.Checked = True
            cbx_droit.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        affiche_Utilisateur()
    End Sub

    Private Sub dgv_utilisateur_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_utilisateur.CellDoubleClick

        txtNom.Text = dgv_utilisateur.CurrentRow.Cells(0).Value.ToString
        txtLogin.Text = dgv_utilisateur.CurrentRow.Cells(1).Value.ToString
        txtLogin.UseSystemPasswordChar = True
        txtMotPasse.UseSystemPasswordChar = True
        txtLogin.ReadOnly = True
        txtMotPasse.ReadOnly = True
        txtMotPasse.Text = dgv_utilisateur.CurrentRow.Cells(2).Value.ToString
        cbx_droit.SelectedItem = dgv_utilisateur.CurrentRow.Cells(3).Value.ToString

        If dgv_utilisateur.CurrentRow.Cells(4).Value.ToString = "Activé" Then
            rbActiver.Checked = True
        ElseIf dgv_utilisateur.CurrentRow.Cells(4).Value.ToString = "Desactivé" Then
            rbdesactiver.Checked = True
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        txtLogin.Text = ""
        txtNom.Text = ""
        txtMotPasse.Text = ""
        rbdesactiver.Checked = True
        cbx_droit.SelectedItem = ""
        txtLogin.ReadOnly = False
        txtMotPasse.ReadOnly = False
        txtLogin.UseSystemPasswordChar = False
        txtMotPasse.UseSystemPasswordChar = False
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dgv_utilisateur.CurrentRow.Cells(0).Value.ToString <> "" Then
            Try
                Dim confirmation As DialogResult = MsgBox("Voulez-vous vraiment effectuer cette suppression ?", MsgBoxStyle.Question, MsgBoxStyle.YesNo)
                If confirmation = DialogResult.Yes Then
                    chaine_connection()
                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from UTILISATEUR where(NUM_UT=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgv_utilisateur.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    cmd.ExecuteNonQuery()

                    Dim c As New SqlCommand
                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de lutilisateur " & txtNom.Text & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()

                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    affiche_Utilisateur()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Consultation de l historique des connexions','" & Date.Now & "')"
        c.Connection = conx
        c.ExecuteNonQuery()
        Form_Historiq_connexion.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Consultation de l historique des activités','" & Date.Now & "')"
        c.Connection = conx
        c.ExecuteNonQuery()
        Form1_activites.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1_sauvegarder_restaurer.ShowDialog()
    End Sub
End Class
