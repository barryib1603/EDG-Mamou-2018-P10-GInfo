Imports System.IO
Imports System.Data
Imports System.Data.SqlClient


Public Class usercontroler2_personnel

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Personnel.Label5.Text = "Enregistrement D'un Personnel"
        Personnel.BtnModifier_pers.Visible = False
        Personnel.lblmodifier.Visible = False
        Personnel.lblajout.Visible = True
        Personnel.lblannuler.Visible = True
        Personnel.Button3.Visible = True
        Personnel.BtnValide_pers.Visible = True
        Personnel.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If lbl_pers_mat.Text <> "" Then

            Personnel.txtMat.Text = lbl_pers_mat.Text
            Personnel.txtNom.Text = lbl_pers_nom.Text
            Personnel.txtPre.Text = lbl_pers_prenom.Text
            Personnel.picbxPerson.Image = Pict_pers_image.Image
            Personnel.txtadresse.Text = lbl_pers_adresse.Text
            Personnel.cbx_statut_pers.Text = lblStatut_pers.Text
            Personnel.txtbadge.Text = lbl_pers_badge.Text
            Personnel.txtfonc.Text = lbl_pers_fonction.Text
            Personnel.txtMail.Text = lbl_pers_email.Text
            Personnel.txtser.Text = lbl_pers_service.Text
            Personnel.txtser.Text = lbl_pers_service.Text
            Personnel.txtTel.Text = lbl_pers_tel.Text


            Personnel.datNaissPers.Text = lbl_pers_age.Text
            If lbl_pers_genre.Text = "Féminin" Then
                Personnel.rbFpers.Checked = True
            Else
                Personnel.rbMpers.Checked = True


            End If


            Personnel.Label5.Text = "Modifier un Personnel"

            Personnel.BtnModifier_pers.Visible = True
            Personnel.lblmodifier.Visible = True
            Personnel.lblajout.Visible = False
            Personnel.lblannuler.Visible = False
            Personnel.Button3.Visible = False
            Personnel.BtnValide_pers.Visible = False
            Personnel.ShowDialog()
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à modifier")
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If lbl_pers_mat.Text <> "" Then
            If DGVPERSONNEL.CurrentRow.Cells(0).Value.ToString <> "" Then
                Try
                    Dim confirmation As DialogResult = MsgBox("Voulez-vous vraiment effectuer cette suppression ?", MsgBoxStyle.Question, MsgBoxStyle.YesNo)
                    If confirmation = DialogResult.Yes Then
                        Dim cmd As New SqlCommand
                        cmd.CommandText = "delete from PERSONNEL where(MAT=@code)"
                        cmd.Connection = conx

                        Dim param As New SqlParameter
                        param.ParameterName = "@code"
                        param.SqlDbType = SqlDbType.NVarChar
                        param.Value = DGVPERSONNEL.CurrentRow.Cells(0).Value.ToString
                        cmd.Parameters.Add(param)

                        cmd.ExecuteNonQuery()

                        Dim c As New SqlCommand
                        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression du Personnel de Matricule" & lbl_pers_mat.Text & "','" & Date.Now & "'"
                        c.Connection = conx
                        c.ExecuteNonQuery()

                        MessageBox.Show("Suppression effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        affiche_personnel()

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub DGVPERSONNEL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPERSONNEL.CellClick
        Try
            If DGVPERSONNEL.CurrentRow.Cells(0).Value.ToString <> "" Then
                lbl_pers_mat.Text = DGVPERSONNEL.CurrentRow.Cells(0).Value.ToString
                lbl_pers_prenom.Text = DGVPERSONNEL.CurrentRow.Cells(1).Value.ToString
                lbl_pers_nom.Text = DGVPERSONNEL.CurrentRow.Cells(2).Value.ToString
                lbl_pers_service.Text = DGVPERSONNEL.CurrentRow.Cells(3).Value.ToString
                lbl_pers_fonction.Text = DGVPERSONNEL.CurrentRow.Cells(4).Value.ToString
                lbl_pers_age.Text = DGVPERSONNEL.CurrentRow.Cells(5).Value.ToString
                lbl_pers_genre.Text = DGVPERSONNEL.CurrentRow.Cells(6).Value.ToString
                lbl_pers_adresse.Text = DGVPERSONNEL.CurrentRow.Cells(7).Value.ToString
                lbl_pers_tel.Text = DGVPERSONNEL.CurrentRow.Cells(8).Value.ToString
                lbl_pers_badge.Text = DGVPERSONNEL.CurrentRow.Cells(9).Value.ToString

                If Pict_pers_image.Visible = True Then
                    Dim img As Image
                    Dim t() As Byte
                    t = DGVPERSONNEL.CurrentRow.Cells(10).Value
                    img = ByteArray2Image(t)
                    Pict_pers_image.Image = img

                Else
                    Pict_pers_image.Image = My.Resources.default_avatar1
                End If

                lbl_pers_email.Text = DGVPERSONNEL.CurrentRow.Cells(11).Value.ToString
                lblStatut_pers.Text = DGVPERSONNEL.CurrentRow.Cells(12).Value.ToString

                Dim cmd As New SqlCommand("select NUM_INTER as NUMERO, CODE_BAT as BATIMENT,NATURE_INTERV as NATURE, DATE_DEBUT_INTERV as DATE_DEBUT,FRAIS_INTERV as FRAIS from INTERVENTION where MAT like '" & DGVPERSONNEL.CurrentRow.Cells(0).Value.ToString & "'")
                cmd.Connection = conx
                Dim da = New SqlDataAdapter(cmd)
                Dim ds As New DataTable
                da.Fill(ds)
                dgvintervenAgent.DataSource = ds


                Dim cmdev As New SqlCommand("select NUM_EV as Numero,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut from EVENEMENT where MAT like '" & DGVPERSONNEL.CurrentRow.Cells(0).Value.ToString & "'")
                cmdev.Connection = conx
                Dim dat = New SqlDataAdapter(cmdev)
                Dim dst As New DataTable
                dat.Fill(dst)
                dgvEvenAgent.DataSource = dst
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Matricule" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select MAT as Matricule, NOM_SERVICE as service,PRENOM_PERS as Prenom, NOM_PERS as Nom,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Genre,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut   from PERSONNEL where(MAT=@Matricule)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@Matricule"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = Txt_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If
        If cmb_rechercher.SelectedItem = "Nom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select MAT as Matricule, NOM_SERVICE as service,PRENOM_PERS as Prenom, NOM_PERS as Nom,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Genre,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut   from PERSONNEL where(NOM_PERS=@NOM)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NOM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = Txt_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce nom n'existe pas")

            End If
        End If

        If cmb_rechercher.SelectedItem = "Prénom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select MAT as Matricule, NOM_SERVICE as service,PRENOM_PERS as Prenom, NOM_PERS as Nom,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Genre,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut   from PERSONNEL where(PRENOM_PERS=@PRENOM)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@PRENOM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = Txt_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce prénom n'existe pas")
            End If

        End If

    End Sub

    
    Private Sub Txt_recherche_TextChanged(sender As Object, e As EventArgs) Handles Txt_recherche.TextChanged
        chaine_connection()
        If cmb_rechercher.SelectedItem = "Matricule" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select MAT as Matricule, NOM_SERVICE as service,PRENOM_PERS as Prenom, NOM_PERS as Nom,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Genre,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut  from PERSONNEL where[MAT] LIKE '%" & Txt_recherche.Text & "%'"
            cmd.Connection = conx


            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then


            End If
        End If

        If cmb_rechercher.SelectedItem = "Nom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select MAT as Matricule, NOM_SERVICE as service,PRENOM_PERS as Prenom, NOM_PERS as Nom,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Genre,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut   from PERSONNEL where[NOM_PERS] LIKE '%" & Txt_recherche.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If

        If cmb_rechercher.SelectedItem = "Prénom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select MAT as Matricule, NOM_SERVICE as service,PRENOM_PERS as Prenom, NOM_PERS as Nom,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Genre,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut   from PERSONNEL where[PRENOM_PERS] LIKE '%" & Txt_recherche.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If

        End If

    End Sub

    Private Sub usercontroler2_personnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_rechercher.SelectedItem = "Matricule"

    End Sub


    Private Sub TabPage9_Click(sender As Object, e As EventArgs) Handles TabPage9.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Impression_fiche_personnel.ShowDialog()
    End Sub

  

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        form_Impression_liste_personnel.ShowDialog()
    End Sub
End Class
