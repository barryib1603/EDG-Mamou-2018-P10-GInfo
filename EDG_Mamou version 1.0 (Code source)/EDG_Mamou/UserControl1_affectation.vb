Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class UserControl1_affectation

    Private Sub UserControl1_affectation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chaine_connection()

        lbldate_fin.Visible = False
        rbdesacffecter.Visible = False
        date_fin_affecte.Visible = False

        affiche_affectation()

        Dim com As New SqlCommand()
        com.CommandText = "select MAT from PERSONNEL where FONCTION_PERS='Agent' AND STATUT='En Service'"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        cmb_agent.Items.Clear()
        While (dr.Read)
            cmb_agent.Items.Add(dr.Item(0))
        End While
        dr.Close()

        Dim cm As New SqlCommand()
        cm.CommandText = "select NUME_ZONE from ZONE"
        cm.CommandType = CommandType.Text
        cm.Connection = conx
        Dim dt As SqlDataReader = cm.ExecuteReader
        cmb_zone.Items.Clear()
        While (dt.Read)
            cmb_zone.Items.Add(dt.Item(0))
        End While
        dt.Close()
        Cmb_recherche.SelectedItem = "Numéro"

    End Sub

    Private Sub btn_ajoute_Click(sender As Object, e As EventArgs) Handles btn_ajoute.Click
        Try
            If txt_affecte.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Identifiant du Batiment")
                txt_affecte.Focus()
                Exit Sub
            End If

            If cmb_agent.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom du Proprietaire ")
                cmb_agent.Focus()
                Exit Sub
            End If
            If cmb_zone.Text = "" Then
                MessageBox.Show("Veuillez entrer la Categorie du Batiment")
                cmb_zone.Focus()
                Exit Sub
            End If
            


            Call chaine_connection()


            Dim cmd0 As New SqlCommand("select * from AFFECTATION where(NUM_AF=@NUM) ")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@NUM"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txt_affecte.Text
            cmd0.Parameters.Add(param0)

           

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then

                MessageBox.Show("Ce numero existe déjà")
                txt_affecte.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            '''''''''''''''''''''''''''''''''''''''''''


            Dim cmd1 As New SqlCommand("select * from AFFECTATION where(NUME_ZONE=@NUM) and (STATU_AFF=@Statut)")
                cmd1.Connection = conx
                Dim param8 As New SqlParameter
            param8.ParameterName = "@NUM"
                param8.SqlDbType = SqlDbType.NVarChar
                param8.Value = cmb_zone.Text
                cmd1.Parameters.Add(param8)

                Dim paramx As New SqlParameter
            paramx.ParameterName = "@Statut"
                paramx.SqlDbType = SqlDbType.NVarChar
            paramx.Value = "Affecté(e)"
                cmd1.Parameters.Add(paramx)

                Dim lir As SqlDataReader = cmd1.ExecuteReader

                If ((lir.Read)) Then
                MessageBox.Show("Un agent déjà affecté à cette zone, veuillez le Desaffecter pour y Affecter un autre")

                    lir.Close()
                    Exit Sub
                End If
            lir.Close()

            Dim cmd2 As New SqlCommand("select * from AFFECTATION where(MAT=@MAT) and (STATU_AFF=@Statu)")
            cmd2.Connection = conx
            Dim params As New SqlParameter
            params.ParameterName = "@MAT"
            params.SqlDbType = SqlDbType.NVarChar
            params.Value = cmb_agent.Text
            cmd2.Parameters.Add(params)

            Dim parame As New SqlParameter
            parame.ParameterName = "@Statu"
            parame.SqlDbType = SqlDbType.NVarChar
            parame.Value = "Affecté(e)"
            cmd2.Parameters.Add(parame)

            Dim lires As SqlDataReader = cmd2.ExecuteReader

            If ((lires.Read)) Then
                MessageBox.Show("Cet Agent est déjà affecté à une Zone")

                lires.Close()
                Exit Sub
            End If
            lires.Close()

            Dim cmd As New SqlCommand("Insert into AFFECTATION(NUM_AF,MAT,NUME_ZONE,DATE_DEBUT_AF,STATU_AFF) values (@AFF,@AGENT,@ZONE,@DATE_D_AF,@Statut)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@AFF"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_affecte.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@AGENT"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = cmb_agent.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@ZONE"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_zone.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@DATE_D_AF"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = date_debut_affecte.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@Statut"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = "Affecté(e)"
            cmd.Parameters.Add(param4)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de lAffectation N°:" & txt_affecte.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")

            txt_affecte.Text = ""
            date_debut_affecte.Text = ""
            date_fin_affecte.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage affectation
        affiche_affectation()

    End Sub

    Private Sub btn_modifie_Click(sender As Object, e As EventArgs) Handles btn_modifie.Click
        Try

            If txt_affecte.Text = "" Then
                MessageBox.Show("Veuillez entrer le Numero de l'afectation")
                txt_affecte.Focus()
                Exit Sub
            End If
            If cmb_agent.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Agent")
                cmb_agent.Focus()
                Exit Sub
            End If
            If cmb_zone.Text = "" Then
                MessageBox.Show("Veuillez Entrer la zone")
                cmb_zone.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand

            cmd.CommandText = "UPDATE AFFECTATION SET NUM_AF=@numero, MAT=@matricule, NUME_ZONE=@zone,DATE_DEBUT_AF=@dateD,DATE_FIN_AF=@datdeF,STATU_AFF=@Statut where (NUM_AF=@numero)"
            cmd.Connection = conx


            Dim param20 As New SqlParameter
            param20.ParameterName = "@numero"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = txt_affecte.Text
            cmd.Parameters.Add(param20)


            Dim param21 As New SqlParameter
            param21.ParameterName = "@matricule"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = cmb_agent.Text
            cmd.Parameters.Add(param21)


            Dim param22 As New SqlParameter
            param22.ParameterName = "@zone"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = cmb_zone.Text
            cmd.Parameters.Add(param22)


            Dim param3 As New SqlParameter
            param3.ParameterName = "@dateD"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = date_debut_affecte.Value
            cmd.Parameters.Add(param3)

            If rbdesacffecter.Checked = True Then
                Dim param88 As New SqlParameter
                param88.ParameterName = "@Statut"
                param88.SqlDbType = SqlDbType.NVarChar
                param88.Value = "Desaffecté(e)"
                cmd.Parameters.Add(param88)
            End If

            Dim param4 As New SqlParameter
            param4.ParameterName = "@datdeF"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = date_fin_affecte.Value
            cmd.Parameters.Add(param4)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification des Informations de lAffectation N° " & txt_affecte.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")

            rbdesacffecter.Checked = False
            rbdesacffecter.Visible = False
            affiche_affectation()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Cmb_recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_recherche.SelectedIndexChanged
        If ((Cmb_recherche.SelectedItem = "Date Debut") Or (Cmb_recherche.SelectedItem = "Date Fin")) Then
            DateTimePicker1.Visible = True
            txtrecherch_affec.Visible = False
        Else
            txtrecherch_affec.Visible = True
            DateTimePicker1.Visible = False
        End If
    End Sub

    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where NUM_AF=@num"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherch_affec.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If
        If Cmb_recherche.SelectedItem = "Agent" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where MAT=@mat"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@mat"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherch_affec.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("cet agent n'existe pas")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where NUME_ZONE=@zone"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@zone"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherch_affec.Text
            cmd.Parameters.Add(param)


            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("cette zone n'existe pas")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Date Debut" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where DATE_DEBUT_AF=@dateD"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@dateD"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = DateTimePicker1.Value
            cmd.Parameters.Add(param)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas d'affectation à cette date")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Date Fin" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where DATE_FIN_AF=@dateF"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@dateF"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = DateTimePicker1.Value
            cmd.Parameters.Add(param)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de fin d'affectation à cette date")

            End If
        End If

    End Sub

    Private Sub btn_supprim_Click(sender As Object, e As EventArgs) Handles btn_supprim.Click
        If dgv_affectation.CurrentRow.Cells(0).Value.ToString <> "" Then
            Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                chaine_connection()
                Dim cmd As New SqlCommand
                cmd.CommandText = "delete from AFFECTATION where(NUM_AF=@code)"
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@code"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = dgv_affectation.CurrentRow.Cells(0).Value.ToString
                cmd.Parameters.Add(param)

                txt_affecte.Text = ""
                cmb_agent.Text = ""
                cmb_zone.Text = ""
                date_debut_affecte.Text = Date.Now
                date_fin_affecte.Visible = False
                lbldate_fin.Visible = False

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppresssion de l affectation N° " & txt_affecte.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                cmd.ExecuteNonQuery()
                MessageBox.Show("SUPPRESSION EFFECTUE AVEC SUCCES")
                affiche_affectation()
            Else

            End If
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        End If
    End Sub

    Private Sub txtrecherch_affec_TextChanged(sender As Object, e As EventArgs) Handles txtrecherch_affec.TextChanged
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Staut from AFFECTATION where NUM_AF=@num"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherch_affec.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
        End If
        If Cmb_recherche.SelectedItem = "Agent" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where MAT like '%" & txtrecherch_affec.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
        End If


        If Cmb_recherche.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where NUME_ZONE like '%" & txtrecherch_affec.Text & "%'"
            cmd.Connection = conx


            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        If Cmb_recherche.SelectedItem = "Date Debut" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where DATE_DEBUT_AF like '%" & DateTimePicker1.Value & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
        End If

        If Cmb_recherche.SelectedItem = "Date Fin" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_AF as NUMERO, MAT AS Agent,NUME_ZONE AS Zone,DATE_DEBUT_AF AS Date_Debut,DATE_FIN_AF AS Date_Fin,STATU_AFF as Statut from AFFECTATION where DATE_FIN_AF like '%" & DateTimePicker1.Value & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgv_affectation.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
        End If
    End Sub

    Private Sub dgv_affectation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_affectation.CellDoubleClick
        If dgv_affectation.CurrentRow.Cells(4).Value.ToString = "" Then
            rbdesacffecter.Checked = False
            lbldate_fin.Visible = False
            date_fin_affecte.Visible = False
            txt_affecte.Text = dgv_affectation.CurrentRow.Cells(0).Value.ToString
            cmb_agent.Text = dgv_affectation.CurrentRow.Cells(1).Value.ToString
            cmb_zone.Text = dgv_affectation.CurrentRow.Cells(2).Value.ToString
            date_debut_affecte.Value = dgv_affectation.CurrentRow.Cells(3).Value.ToString
        Else
            rbdesacffecter.Checked = True
            lbldate_fin.Visible = True
            date_fin_affecte.Visible = True
            txt_affecte.Text = dgv_affectation.CurrentRow.Cells(0).Value.ToString
            cmb_agent.Text = dgv_affectation.CurrentRow.Cells(1).Value.ToString
            cmb_zone.Text = dgv_affectation.CurrentRow.Cells(2).Value.ToString
            date_debut_affecte.Value = dgv_affectation.CurrentRow.Cells(3).Value.ToString
            date_fin_affecte.Value = dgv_affectation.CurrentRow.Cells(4).Value.ToString
        End If

        If dgv_affectation.CurrentRow.Cells(5).Value.ToString = "Desaffecté(e)" Then
            lbldate_fin.Visible = True
            date_fin_affecte.Visible = True
            rbdesacffecter.Visible = True
            date_fin_affecte.Enabled = False
            rbdesacffecter.Enabled = False
        Else
            lbldate_fin.Visible = True
            date_fin_affecte.Visible = True
            rbdesacffecter.Visible = True
            date_fin_affecte.Enabled = True
            rbdesacffecter.Enabled = True
        End If

    End Sub

    Private Sub dgv_affectation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_affectation.CellContentClick
        
    End Sub

    Private Sub rbdesacffecter_CheckedChanged(sender As Object, e As EventArgs)
       
        lbldate_fin.Visible = True
        date_fin_affecte.Visible = True
    End Sub

    Private Sub rbdesacffecter_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbdesacffecter.CheckedChanged
        If rbdesacffecter.Checked = True Then
            lbldate_fin.Visible = True
            date_fin_affecte.Visible = True
        Else
            date_fin_affecte.Visible = False
            lbldate_fin.Visible = False

        End If
    End Sub

    Private Sub dgv_affectation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_affectation.CellClick

    End Sub

    
    Private Sub btn_quitte_Click(sender As Object, e As EventArgs)

    End Sub
End Class
