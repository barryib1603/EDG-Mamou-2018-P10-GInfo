Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class UserControl1_client

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        frmClient.btnmodifier_cl.Visible = False
        frmClient.btnvalider_cl.Visible = True
        frmClient.Button3.Visible = True
        frmClient.lbltitre_cl.Text = "Ajouter un Client"
        frmClient.lblmodifiercl.Visible = False
        frmClient.lblannuler.Visible = True
        frmClient.lblajoutcli.Visible = True




        frmClient.ShowDialog()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If lbl_num_client.Text <> "" Then

            frmClient.txtNumero.Text = lbl_num_client.Text
            frmClient.txtAdresse.Text = lbl_adresse_client.Text
            frmClient.txtNom.Text = lbl_nom_client.Text
            frmClient.PictureBox1.Image = Pict_img__client.Image
            frmClient.txtTelephone.Text = lbl_tel_client.Text
            frmClient.txtPrenom.Text = lbl_prenom_client.Text

            frmClient.DatNaissCL.Text = lbl_age_client.Text
            frmClient.txtmail_cl.Text = lbl_email_client.Text
            If lbl_genre_client.Text = "Féminin" Then
                frmClient.rbF.Checked = True
            Else
                frmClient.rbM.Checked = True
            End If

            frmClient.btnvalider_cl.Visible = False
            frmClient.lblajoutcli.Visible = False
            frmClient.btnmodifier_cl.Visible = True
            frmClient.lblmodifiercl.Visible = True
            frmClient.Button3.Visible = False
            frmClient.lblannuler.Visible = False
            frmClient.lbltitre_cl.Text = "Modifier un Client"
            frmClient.ShowDialog()
        Else
            MessageBox.Show("Vous N'avez selectionné aucun element à modifier")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        chaine_connection()
        If lbl_num_client.Text <> "" Then
            chaine_connection()
            Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim client As String = dgvclients.CurrentRow.Cells(0).Value.ToString
            If confirmation = DialogResult.Yes Then
                chaine_connection()
                Dim lire As SqlDataReader
                Dim cm As New SqlCommand
                cm.Connection = conx

                cm.CommandText = "select * from BATIMENT where NUM_CL=@cod and STATUT='Abonné'"
                cm.Connection = conx
                Dim para As New SqlParameter

                para.ParameterName = "@cod"
                para.SqlDbType = SqlDbType.NVarChar
                para.Value = dgvclients.CurrentRow.Cells(0).Value.ToString
                cm.Parameters.Add(para)
                chaine_connection()
                lire = cm.ExecuteReader
                chaine_connection()
                If lire.Read Then
                    confirmation = MsgBox("En supprimant ce client vous supprimez aussi tous les batiments et les autres informations qui lui sont liés. Cette action entrainera aussi la suppression automatique des informations liés au batiment appartenant à ce client !", MsgBoxStyle.YesNo)
                    lire.Close()
                    If confirmation = DialogResult.Yes Then
                        Try
                            chaine_connection()
                            Dim cmd As New SqlCommand
                            cmd.CommandText = "update CLIENT set STATUT_CL='Desabonné' where(NUM_CL=@code)"
                            cmd.Connection = conx

                            Dim param As New SqlParameter
                            param.ParameterName = "@code"
                            param.SqlDbType = SqlDbType.NVarChar
                            param.Value = dgvclients.CurrentRow.Cells(0).Value.ToString
                            cmd.Parameters.Add(param)

                            cmd.ExecuteNonQuery()

                            Dim c1 As New SqlCommand
                            c1.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Desabonnement du client N° " & lbl_num_client.Text & "','" & Date.Now & "')"
                            c1.Connection = conx
                            c1.ExecuteNonQuery()

                            MessageBox.Show("DESABONNEMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            lbl_num_client.Text = ""
                            lbl_nom_client.Text = ""
                            lbl_prenom_client.Text = ""
                            lbl_age_client.Text = ""
                            lbl_adresse_client.Text = ""
                            lbl_email_client.Text = ""
                            lbl_genre_client.Text = ""
                            lbl_tel_client.Text = ""
                            Pict_img__client.Image = My.Resources.default_avatar1

                            Try
                                chaine_connection()

                                Dim cmd1 As New SqlCommand("UPDATE BATIMENT SET STATUT='Desabonné' where NUM_CL=@CL")
                                cmd1.Connection = conx

                                Dim para1 As New SqlParameter
                                para1.ParameterName = "@CL"
                                para1.SqlDbType = SqlDbType.NVarChar
                                para1.Value = client
                                cmd1.Parameters.Add(para1)

                                cmd1.ExecuteNonQuery()

                                Dim c11 As New SqlCommand
                                c11.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Desabonnement de tous les batiments du clent " & lbl_num_client.Text & "','" & Date.Now & "')"
                                c11.Connection = conx
                                c11.ExecuteNonQuery()

                                MessageBox.Show("DESABONNEMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            'Dim cmnd As New SqlCommand
                            'cmnd.CommandText = "UPDATE BATIMENT set STATUT='Desabonné' where(NUM_CL=@code)"
                            'cmnd.Connection = conx

                            'Dim para6 As New SqlParameter
                            'para6.ParameterName = "@code"
                            'para6.SqlDbType = SqlDbType.NVarChar
                            'para6.Value = client
                            'cmnd.Parameters.Add(para6)

                            affiche_batiment()
                            affiche_client()
                        Catch ex As Exception
                            MessageBox.Show("Suppression impossible : ", ex.Message)
                        End Try
                        Exit Sub
                    End If
                Else
                    lire.Close()
                    confirmation = MessageBox.Show("Ce Client n'est associé à aucun Batiment Voulez vous toujours le Supprimer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirmation = DialogResult.Yes Then
                        Try
                            chaine_connection()
                            Dim cmd As New SqlCommand
                            cmd.CommandText = "update CLIENT set STATUT_CL='Desabonné' where(NUM_CL=@code)"
                            cmd.Connection = conx

                            Dim param As New SqlParameter
                            param.ParameterName = "@code"
                            param.SqlDbType = SqlDbType.NVarChar
                            param.Value = dgvclients.CurrentRow.Cells(0).Value.ToString
                            cmd.Parameters.Add(param)

                            Dim c As New SqlCommand
                            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Desabonnement du client N°" & client & "','" & Date.Now & "')"
                            c.Connection = conx
                            c.ExecuteNonQuery()

                            lbl_num_client.Text = ""
                            lbl_nom_client.Text = ""
                            lbl_prenom_client.Text = ""
                            lbl_age_client.Text = ""
                            lbl_adresse_client.Text = ""
                            lbl_email_client.Text = ""
                            lbl_genre_client.Text = ""
                            lbl_tel_client.Text = ""
                            Pict_img__client.Image = My.Resources.default_avatar1

                            cmd.ExecuteNonQuery()
                            affiche_client()
                            affiche_batiment()

                        Catch ex As Exception
                            MessageBox.Show("Suppression impossible")
                        End Try
                    End If
                End If


            End If
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        End If
    End Sub

    Private Sub dgvclients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclients.CellClick
        Try
            If dgvclients.CurrentRow.Cells(0).Value.ToString <> "" Then
                lbl_num_client.Text = dgvclients.CurrentRow.Cells(0).Value.ToString
                lbl_prenom_client.Text = dgvclients.CurrentRow.Cells(1).Value.ToString
                lbl_nom_client.Text = dgvclients.CurrentRow.Cells(2).Value.ToString
                lbl_age_client.Text = dgvclients.CurrentRow.Cells(3).Value.ToString
                lbl_genre_client.Text = dgvclients.CurrentRow.Cells(4).Value.ToString
                lbl_adresse_client.Text = dgvclients.CurrentRow.Cells(5).Value.ToString
                lbl_tel_client.Text = dgvclients.CurrentRow.Cells(6).Value.ToString
                If Pict_img__client.Visible = True Then
                    Dim img As Image
                    Dim t() As Byte
                    t = dgvclients.CurrentRow.Cells(7).Value
                    img = ByteArray2Image(t)
                    Pict_img__client.Image = img
                Else
                    Pict_img__client.Image = My.Resources.default_avatar1
                End If
                lbl_email_client.Text = dgvclients.CurrentRow.Cells(8).Value.ToString
                ''Affichage des Batiments d'un Client''
                chaine_connection()
                Dim cmd As New SqlCommand("select CODE_BAT as Code,LIBELLE_CAT as Libelle,MAT as Matricule,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_CL=@client")
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@client"
                param.SqlDbType = SqlDbType.NVarChar
                param.Value = dgvclients.CurrentRow.Cells(0).Value.ToString
                cmd.Parameters.Add(param)

                Dim da = New SqlDataAdapter(cmd)
                Dim ds As New DataTable
                da.Fill(ds)
                dgvbatimenclient.DataSource = ds

                ''affichage des paiement des batiments d'un client''
                Dim cmdev As New SqlCommand("select NUM_PAIE as Numéros,NUM_COMSOM as CONSOMATION,NATURE_PAIE NATURE,MONTANT_PAIE MONTANT,DATE_PAIEMENT as Date from PAIEMENT where NUM_COMSOM IN (select NUM_COMSOM From CONSOMMATION where CODE_BAT IN(select CODE_BAT from BATIMENT where NUM_CL like'" & dgvclients.CurrentRow.Cells(0).Value.ToString & "') )")
                cmdev.Connection = conx
                Dim dat = New SqlDataAdapter(cmdev)
                Dim dst As New DataTable
                dat.Fill(dst)
                dgvpaiemenClient.DataSource = dst
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub UserControl1_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_rechercher.SelectedItem = "Numéro"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where(NUM_CL=@NUM)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_client.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If
        If cmb_rechercher.SelectedItem = "Nom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where(NOM_CL=@NOM)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NOM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_client.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce nom n'existe pas")

            End If
        End If

        If cmb_rechercher.SelectedItem = "Prénom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where(PRENOM_CL=@PRENOM)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@PRENOM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_client.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce prénom n'existe pas")

            End If
        End If
    End Sub

    Private Sub txt_recherche_client_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche_client.TextChanged

        chaine_connection()

        If cmb_rechercher.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where[NUM_CL] LIKE '%" & txt_recherche_client.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If
        If cmb_rechercher.SelectedItem = "Nom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where[NOM_CL] LIKE '%" & txt_recherche_client.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If

        If cmb_rechercher.SelectedItem = "Prénom" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where[PRENOM_CL] LIKE '%" & txt_recherche_client.Text & "%'"
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Impression_Fiche_client.ShowDialog()
       
    End Sub

    Private Sub dgvclients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclients.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Impression_liste_client.ShowDialog()
    End Sub
End Class
