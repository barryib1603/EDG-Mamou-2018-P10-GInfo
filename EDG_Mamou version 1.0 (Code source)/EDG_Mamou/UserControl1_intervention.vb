Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class UserControl1_intervention

    Private Sub UserControl1_intervention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFrais.Visible = False
        lblfrais.Visible = False
        chaine_connection()

        Dim com As New SqlCommand()
        com.CommandText = "select MAT from PERSONNEL where FONCTION_PERS='Agent' AND STATUT='En Service'"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        txtMatricule.Items.Clear()
        While (dr.Read)
            txtMatricule.Items.Add(dr.Item(0))
        End While
        dr.Close()

        Dim cmn As New SqlCommand()
        cmn.CommandText = "select CODE_BAT from BATIMENT"
        cmn.CommandType = CommandType.Text
        cmn.Connection = conx
        Dim dtrd As SqlDataReader = cmn.ExecuteReader
        cmb_bat.Items.Clear()
        While (dtrd.Read)
            cmb_bat.Items.Add(dtrd.Item(0))
        End While
        dtrd.Close()

        Cmb_recherche.SelectedItem = "Numéro"


    End Sub

    Private Sub Cmb_recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_recherche.SelectedIndexChanged
        If Cmb_recherche.SelectedItem = "Numéro" Then
            txt_recherche_paie.Visible = True
            DateTimePicker1.Visible = False
            cbxnature_recher.Visible = False
           
        ElseIf ((Cmb_recherche.SelectedItem = "Date Debut") Or (Cmb_recherche.SelectedItem = "Date Fin")) Then
            txt_recherche_paie.Visible = False
            cbxnature_recher.Visible = False
            DateTimePicker1.Visible = True
        Else
            cbxnature_recher.Visible = True
            txt_recherche_paie.Visible = False
            DateTimePicker1.Visible = False
        End If
    End Sub

    Private Sub btnEnregistrer_interven_Click(sender As Object, e As EventArgs) Handles btnEnregistrer_interven.Click
        Try

            If txtNumero.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero de l'intervention")
                txtNumero.Focus()
                Exit Sub
            End If
            If txtMatricule.Text = "" Then
                MessageBox.Show("Veuillez saisir le Matricule de l'agent")
                txtMatricule.Focus()
                Exit Sub
            End If
            If cmb_bat.Text = "" Then
                MessageBox.Show("Veuillez entrer le code du Batiment concerné")
                cmb_bat.Focus()
                Exit Sub
            End If
            If cmb_nature.Text = "" Then
                MessageBox.Show("Veuillez entrer La Nature de l'intervention")
                cmb_nature.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select * from INTERVENTION where(NUM_INTER=@numero)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@numero"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtNumero.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtNumero.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()

            If cmb_nature.SelectedItem = "Retablissement" Then

                Dim cmd As New SqlCommand("Insert into INTERVENTION(NUM_INTER,MAT,CODE_BAT,NATURE_INTERV,DATE_DEBUT_INTERV,FRAIS_INTERV) values(@numero,@matricule,@batiment,@natinterve, @datedeb,@frais)")
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@numero"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = txtNumero.Text
                cmd.Parameters.Add(param)

                Dim param1 As New SqlParameter
                param1.ParameterName = "@matricule"
                param1.SqlDbType = SqlDbType.NVarChar
                param1.Value = txtMatricule.Text
                cmd.Parameters.Add(param1)

                Dim param2 As New SqlParameter
                param2.ParameterName = "@batiment"
                param2.SqlDbType = SqlDbType.NVarChar
                param2.Value = cmb_bat.Text
                cmd.Parameters.Add(param2)

                Dim param3 As New SqlParameter
                param3.ParameterName = "@natinterve"
                param3.SqlDbType = SqlDbType.NVarChar
                param3.Value = cmb_nature.Text
                cmd.Parameters.Add(param3)

                Dim param4 As New SqlParameter
                param4.ParameterName = "@datedeb"
                param4.SqlDbType = SqlDbType.NVarChar
                param4.Value = dtpDateDebut.Text
                cmd.Parameters.Add(param4)

                Dim param6 As New SqlParameter
                param6.ParameterName = "@frais"
                param6.SqlDbType = SqlDbType.NVarChar
                param6.Value = txtFrais.Text
                cmd.Parameters.Add(param6)

                txtMatricule.Text = ""
                txtNumero.Text = ""
                cmb_nature.SelectedItem = ""
                cmb_bat.Text = ""
                txtFrais.Text = ""

                cmd.ExecuteNonQuery()

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de l Intervention N°:" & txtNumero.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                MessageBox.Show("Enregistrement effectué avec succès")
                affiche_Intervention()
            Else
                Dim cmd As New SqlCommand("Insert into INTERVENTION(NUM_INTER,MAT,CODE_BAT,NATURE_INTERV,DATE_DEBUT_INTERV) values(@numero,@matricule,@batiment,@natinterve, @datedeb)")
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@numero"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = txtNumero.Text
                cmd.Parameters.Add(param)

                Dim param1 As New SqlParameter
                param1.ParameterName = "@matricule"
                param1.SqlDbType = SqlDbType.NVarChar
                param1.Value = txtMatricule.Text
                cmd.Parameters.Add(param1)

                Dim param2 As New SqlParameter
                param2.ParameterName = "@batiment"
                param2.SqlDbType = SqlDbType.NVarChar
                param2.Value = cmb_bat.Text
                cmd.Parameters.Add(param2)

                Dim param3 As New SqlParameter
                param3.ParameterName = "@natinterve"
                param3.SqlDbType = SqlDbType.NVarChar
                param3.Value = cmb_nature.Text
                cmd.Parameters.Add(param3)

                Dim param4 As New SqlParameter
                param4.ParameterName = "@datedeb"
                param4.SqlDbType = SqlDbType.Date
                param4.Value = dtpDateDebut.Text
                cmd.Parameters.Add(param4)
                txtMatricule.Text = ""
                txtNumero.Text = ""
                cmb_nature.SelectedItem = ""
                cmb_bat.Text = ""

                cmd.ExecuteNonQuery()

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de l Intervention N°:" & txtNumero.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                MessageBox.Show("Enregistrement effectué avec succès")
                affiche_Intervention()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModifier_interven_Click(sender As Object, e As EventArgs) Handles btnModifier_interven.Click
        Try

            If txtNumero.Text = "" Then
                MessageBox.Show("Veuillez entrer le Numero de l'intervention")
                txtNumero.Focus()
                Exit Sub
            End If
            If txtMatricule.Text = "" Then
                MessageBox.Show("Veuillez saisir le Matricule de l'Agent")
                txtMatricule.Focus()
                Exit Sub
            End If
            If cmb_bat.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Batiment")
                cmb_bat.Focus()
                Exit Sub
            End If
            If cmb_nature.Text = "" Then
                MessageBox.Show("Veuillez entrer la Nature de l'intervention")
                cmb_nature.Focus()
                Exit Sub
            End If

            If txtFrais.Text = "" Then
                MessageBox.Show("Veuillez entrer les Frais de L'intervention ")
                txtFrais.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand

            cmd.CommandText = "UPDATE INTERVENTION SET NUM_INTER=@numero, MAT=@matricule, CODE_BAT=@batiment,NATURE_INTERV=@nature,DATE_DEBUT_INTERV=@datdeb,FRAIS_INTERV=@frais where (NUM_INTER=@numero)"
            cmd.Connection = conx

            Dim param20 As New SqlParameter
            param20.ParameterName = "@numero"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = txtNumero.Text
            cmd.Parameters.Add(param20)

            Dim param21 As New SqlParameter
            param21.ParameterName = "@matricule"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = txtMatricule.Text
            cmd.Parameters.Add(param21)

            Dim param22 As New SqlParameter
            param22.ParameterName = "@batiment"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = cmb_bat.Text
            cmd.Parameters.Add(param22)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@nature"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = cmb_nature.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@datdeb"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = dtpDateDebut.Text
            cmd.Parameters.Add(param4)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@frais"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = txtFrais.Text
            cmd.Parameters.Add(param6)

            cmd.ExecuteNonQuery()

            Dim c12 As New SqlCommand
            c12.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de l Intervention N°:" & txtNumero.Text & "','" & Date.Now & "')"
            c12.Connection = conx
            c12.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")
            
            affiche_Intervention()
            affiche_personnel()
            affiche_batiment()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where NUM_INTER=@num"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If
        If Cmb_recherche.SelectedItem = "Nature" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where NATURE_INTERV=@nature"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@nature"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cbxnature_recher.SelectedItem
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Date Debut" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where DATE_DEBUT_INTERV=@date_d"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@date_d"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = DateTimePicker1.Value
            cmd.Parameters.Add(param)


            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("cette date debut n'est pas enregistré")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Date Fin" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where DATE_FIN_INTERV=@date_f"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@date_f"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = DateTimePicker1.Value
            cmd.Parameters.Add(param)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox(" cette date fin n'existe pas")

            End If
        End If

    End Sub

    Private Sub txt_recherche_paie_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche_paie.TextChanged
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where NUM_INTER=@num"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            

            End If
        End If
        If Cmb_recherche.SelectedItem = "Nature" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where NATURE_INTERV=@nature"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@nature"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            

            End If
        End If

        'If Cmb_recherche.SelectedItem = "Date Debut" Then
        '    Dim cmd As New SqlCommand
        '    cmd.CommandText = cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where DATE_DEBUT_INTERV=@date_d"
        '    cmd.Connection = conx

        '    Dim param As New SqlParameter
        '    param.ParameterName = "@date_d"
        '    param.SqlDbType = SqlDbType.NVarChar
        '    param.Value = cmb_mois_recherche_paie.Text
        '    cmd.Parameters.Add(param)


        '    Dim da = New SqlDataAdapter(cmd)
        '    Dim ds As New DataTable
        '    da.Fill(ds)
        '    Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

        '    Dim lire As SqlDataReader
        '    lire = cmd.ExecuteReader
        '    If lire.Read Then


        '    End If
        'End If

        'If Cmb_recherche.SelectedItem = "Date Fin" Then
        '    Dim cmd As New SqlCommand
        '    cmd.CommandText = "select NUM_INTER as NUMERO, MAT AS Matricule,CODE_BAT AS Batiment,NATURE_INTERV AS Intervention,DATE_DEBUT_INTERV AS Date_Debut,DATE_FIN_INTERV AS Date_Fin,FRAIS_INTERV AS Frais   from INTERVENTION where DATE_FIN_INTERV=@date_f"
        '    cmd.Connection = conx

        '    Dim param As New SqlParameter
        '    param.ParameterName = "@date_f"
        '    param.SqlDbType = SqlDbType.NVarChar
        '    param.Value = cmb_annee_recherche_paie.Text
        '    cmd.Parameters.Add(param)
        '    Dim da = New SqlDataAdapter(cmd)
        '    Dim ds As New DataTable
        '    da.Fill(ds)
        '    Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds

        '    Dim lire As SqlDataReader
        '    lire = cmd.ExecuteReader
        '    If lire.Read Then


        '    End If
        'End If
    End Sub

    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_sup.Click
        If dgvInterv.CurrentRow.Cells(0).Value.ToString <> "" Then
            Try
                Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmation = DialogResult.Yes Then
                    chaine_connection()
                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from INTERVENTION where(NUM_INTER=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgvInterv.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    cmd.ExecuteNonQuery()

                    Dim c As New SqlCommand
                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de l Intervention N° " & txtNumero.Text & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()

                    MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    affiche_Intervention()
                    txtMatricule.Text = ""
                    txtNumero.Text = ""
                    cmb_nature.SelectedItem = ""
                    cmb_bat.Text = ""
                    txtFrais.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvInterv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInterv.CellDoubleClick
        If dgvInterv.CurrentRow.Cells(0).Value.ToString <> "" Then
            txtNumero.Text = dgvInterv.CurrentRow.Cells(0).Value.ToString
            txtMatricule.Text = dgvInterv.CurrentRow.Cells(1).Value.ToString
            cmb_bat.Text = dgvInterv.CurrentRow.Cells(2).Value.ToString
            cmb_nature.Text = dgvInterv.CurrentRow.Cells(3).Value.ToString
            dtpDateDebut.Text = dgvInterv.CurrentRow.Cells(4).Value.ToString
            txtFrais.Text = dgvInterv.CurrentRow.Cells(5).Value.ToString
        End If
    End Sub

    Private Sub cmb_nature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nature.SelectedIndexChanged
        If cmb_nature.SelectedItem = "Coupure" Then
            txtFrais.Visible = False
            lblfrais.Visible = False
        Else
            txtFrais.Visible = True
            lblfrais.Visible = True
        End If
    End Sub

    Private Sub cmb_bat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bat.SelectedIndexChanged

    End Sub

    Private Sub btn_Imp_Indivi_Click(sender As Object, e As EventArgs) Handles btn_Imp_Indivi.Click
        If dgvInterv.CurrentRow.Cells(1).Value <> "" Then

            Form_Impression_Intervention_Individuelle.ShowDialog()
        Else
            MessageBox.Show("Vous n'avez selectionné aucun élément", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Impression_Liste_Interventionl.ShowDialog()
    End Sub
End Class
