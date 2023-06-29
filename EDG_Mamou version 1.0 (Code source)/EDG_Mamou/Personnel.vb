Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Personnel
    Dim nbr() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If nbr.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPre_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

 



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnValide_pers.Click
        Try
            If txtMat.Text = "" Then
                MessageBox.Show("Veuillez entrer le MATRICULE DU PERSONNEL")
                txtMat.Focus()
                Exit Sub
            End If
            If txtPre.Text = "" Then
                MessageBox.Show("Veuillez saisir le PRENOM DU PERSONNEL")
                txtPre.Focus()
                Exit Sub
            End If
            If txtNom.Text = "" Then
                MessageBox.Show("Veuillez entrer le NOM DU PERSONNEL")
                txtNom.Focus()
                Exit Sub
            End If
            If txtfonc.Text = "" Then
                MessageBox.Show("Veuillez entrer LA FONCTION DU PERSONNEL")
                txtfonc.Focus()
                Exit Sub
            End If

            If (rbMpers.Checked = False) And (rbFpers.Checked = False) Then
                MessageBox.Show("Veuillez choisir le GENRE DU PERSONNEL")
                Exit Sub
            End If
            If txtadresse.Text = "" Then
                MessageBox.Show("Veuillez entrer L'ADRESSE DU PERSONNEL")
                txtadresse.Focus()
                Exit Sub
            End If
            If txtTel.Text = "" Then
                MessageBox.Show("Veuillez entrer LE NUMERO DU PERSONNEL")
                txtTel.Focus()
                Exit Sub
            End If
            If txtbadge.Text = "" Then
                MessageBox.Show("Veuillez entrer LE NUMERO DE BAGET DU PERSONNEL")
                txtbadge.Focus()
                Exit Sub
            End If
            If txtMail.Text = "" Then
                MessageBox.Show("Veuillez entrer LE MAIL DU PERSONNEL")
                txtMail.Focus()
                Exit Sub
            End If

            Call chaine_connection()


            Dim cmd0 As New SqlCommand("select *from PERSONNEL where(MAT=@matricule)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@matricule"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtMat.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtMat.Focus()

                lire.Close()

            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into PERSONNEL(MAT,NOM_SERVICE,PRENOM_PERS,NOM_PERS,FONCTION_PERS,AGE_PERS,GENRE_PERS,ADRESSE_PERS,TEL_PERS,NUM_BADGE_PERS,PHOTO,EMAIL_PERS,STATUT) values(@MAT,@SERVICE,@PRENOM,@nom,@FONCTION, @AGE,@GENRE,@ADRESSE,@TEL,@BADGE,@PHOTO,@EMAIL,@statut)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@MAT"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtMat.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@SERVICE"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtser.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@PRENOM"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtPre.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@nom"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtNom.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@FONCTION"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtfonc.Text
            cmd.Parameters.Add(param4)


            Dim param5 As New SqlParameter
            param5.ParameterName = "@AGE"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = datNaissPers.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@GENRE"
            If (rbMpers.Checked = True) Then
                param6.Value = "Masculin"
                cmd.Parameters.Add(param6)
            Else
                param6.Value = "Féminin"
                cmd.Parameters.Add(param6)
            End If

            Dim param7 As New SqlParameter
            param7.ParameterName = "@ADRESSE"
            param7.SqlDbType = SqlDbType.NVarChar
            param7.Value = txtadresse.Text
            cmd.Parameters.Add(param7)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@TEL"
            param8.SqlDbType = SqlDbType.NVarChar
            param8.Value = txtTel.Text
            cmd.Parameters.Add(param8)

            Dim param9 As New SqlParameter
            param9.ParameterName = "@BADGE"
            param9.SqlDbType = SqlDbType.NVarChar
            param9.Value = txtbadge.Text
            cmd.Parameters.Add(param9)

            Dim img As Image
            Dim t() As Byte
            img = Image.FromFile(TbPhoto.Text)
            t = Image2ByteArray(img)
            Dim param10 As New SqlParameter
            param10.ParameterName = "@photo"
            param10.SqlDbType = SqlDbType.VarBinary
            param10.Value = t
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@EMAIL"
            param11.SqlDbType = SqlDbType.NVarChar
            param11.Value = txtMail.Text
            cmd.Parameters.Add(param11)

            Dim param12 As New SqlParameter
            param12.ParameterName = "@statut"
            param12.SqlDbType = SqlDbType.NVarChar

            param12.Value = cbx_statut_pers.SelectedItem

            cmd.Parameters.Add(param12)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du personnel N°:" & txtMat.Text & " ','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")

            'procedure affichage client
            affiche_personnel()

            txtadresse.Text = ""
            txtNom.Clear()
            txtMat.Text = ""
            txtPre.Text = ""
            txtTel.Clear()
            txtMail.Text = ""
            txtfonc.Text = ""
            txtser.Text = ""
            cbx_statut_pers.Text = ""
            txtbadge.Text = ""
            TbPhoto.Text = ""

            rbMpers.Checked = False
            rbFpers.Checked = False
            picbxPerson.Image = My.Resources.default_avatar1

            frmBatiments.Refresh()
            Form1_Evenement.Refresh()
            Form1_Rapport.Refresh()
            Form2_menu_principal.UserControl1_affectation1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        OpenFileDialog1.Filter = ("Choisir une image|*.jpg;*.Bmp;*.png;*.ico;*.bitmap")

        OpenFileDialog1.ShowDialog()
        TbPhoto.Text = OpenFileDialog1.FileName
        Dim img As Image
        Dim t() As Byte
        If Not ((TbPhoto.Text).Equals("OpenFileDialog1")) Then
            img = Image.FromFile(TbPhoto.Text)
            t = Image2ByteArray(img)
            img = ByteArray2Image(t)
            picbxPerson.Image = img


        End If
    End Sub

    Private Sub picbxPerson_Click(sender As Object, e As EventArgs) Handles picbxPerson.Click
        OpenFileDialog1.Filter = ("Choisir une image|*.jpg;*.Bmp;*.png;*.ico;*.bitmap")

        OpenFileDialog1.ShowDialog()
        TbPhoto.Text = OpenFileDialog1.FileName
        Dim img As Image
        Dim t() As Byte
        If Not ((TbPhoto.Text).Equals("OpenFileDialog1")) Then
            img = Image.FromFile(TbPhoto.Text)
            t = Image2ByteArray(img)
            img = ByteArray2Image(t)
            picbxPerson.Image = img


        End If
    End Sub

   
    Private Sub Personnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chaine_connection()

        Dim com As New SqlCommand()
        com.CommandText = "select NOM_SERVICE from SERVICE"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        txtser.Items.Clear()
        While (dr.Read)
            txtser.Items.Add(dr.Item(0))
        End While

    End Sub

    Private Sub BtnModifier_pers_Click(sender As Object, e As EventArgs) Handles BtnModifier_pers.Click
        Try

            If txtMat.Text = "" Then
                MessageBox.Show("Veuillez entrer le MATRICULE DU PERSONNEL")
                txtMat.Focus()
                Exit Sub
            End If
            If txtPre.Text = "" Then
                MessageBox.Show("Veuillez saisir le PRENOM DU PERSONNEL")
                txtPre.Focus()
                Exit Sub
            End If
            If txtNom.Text = "" Then
                MessageBox.Show("Veuillez entrer le NOM DU PERSONNEL")
                txtNom.Focus()
                Exit Sub
            End If
            If txtfonc.Text = "" Then
                MessageBox.Show("Veuillez entrer LA FONCTION DU PERSONNEL")
                txtfonc.Focus()
                Exit Sub
            End If

            If (rbMpers.Checked = False) And (rbFpers.Checked = False) Then
                MessageBox.Show("Veuillez choisir le GENRE DU PERSONNEL")
                Exit Sub
            End If
            If txtadresse.Text = "" Then
                MessageBox.Show("Veuillez entrer L'ADRESSE DU PERSONNEL")
                txtadresse.Focus()
                Exit Sub
            End If
            If txtTel.Text = "" Then
                MessageBox.Show("Veuillez entrer LE NUMERO DU PERSONNEL")
                txtTel.Focus()
                Exit Sub
            End If
            If txtbadge.Text = "" Then
                MessageBox.Show("Veuillez entrer LE NUMERO DE BAGET DU PERSONNEL")
                txtbadge.Focus()
                Exit Sub
            End If
            If txtMail.Text = "" Then
                MessageBox.Show("Veuillez entrer LE MAIL DU PERSONNEL")
                txtMail.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand
            If TbPhoto.Text <> "" Then
                cmd.CommandText = "UPDATE PERSONNEL SET  NOM_SERVICE=@service, PRENOM_PERS=@prenom,NOM_PERS=@nom, FONCTION_PERS=@fonction, AGE_PERS=@age, GENRE_PERS=@genre,ADRESSE_PERS=@adresse, TEL_PERS=@telephone, NUM_BADGE_PERS=@badge,PHOTO=@photo, EMAIL_PERS=@email, STATUT=@statut where MAT=@matricule"
                cmd.Connection = conx

                Dim img As Image
                Dim t() As Byte
                img = Image.FromFile(TbPhoto.Text)
                t = Image2ByteArray(img)
                Dim param6 As New SqlParameter
                param6.ParameterName = "@photo"
                param6.SqlDbType = SqlDbType.VarBinary
                param6.Value = t
                cmd.Parameters.Add(param6)
            Else
                cmd.CommandText = "UPDATE PERSONNEL SET  NOM_SERVICE=@service, PRENOM_PERS=@prenom,NOM_PERS=@nom, FONCTION_PERS=@fonction, AGE_PERS=@age, GENRE_PERS=@genre,ADRESSE_PERS=@adresse, TEL_PERS=@telephone, NUM_BADGE_PERS=@badge, EMAIL_PERS=@email, STATUT=@statut where MAT=@matricule"
                cmd.Connection = conx

            End If




            Dim param20 As New SqlParameter
            param20.ParameterName = "@matricule"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = txtMat.Text
            cmd.Parameters.Add(param20)



            Dim param21 As New SqlParameter
            param21.ParameterName = "@service"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = txtser.Text
            cmd.Parameters.Add(param21)


            Dim param22 As New SqlParameter
            param22.ParameterName = "@prenom"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = txtPre.Text
            cmd.Parameters.Add(param22)


            Dim param3 As New SqlParameter
            param3.ParameterName = "@nom"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtNom.Text
            cmd.Parameters.Add(param3)


            Dim paramx As New SqlParameter
            paramx.ParameterName = "@genre"
            paramx.SqlDbType = SqlDbType.NVarChar
            If rbFpers.Checked = True Then
                paramx.Value = "Féminin"
            Else
                paramx.Value = "Masculin"
            End If
            cmd.Parameters.Add(paramx)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@fonction"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtfonc.Text
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@age"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = datNaissPers.Text
            cmd.Parameters.Add(param5)

            Dim paramadresse As New SqlParameter
            paramadresse.ParameterName = "@adresse"
            paramadresse.SqlDbType = SqlDbType.NVarChar
            paramadresse.Value = txtadresse.Text
            cmd.Parameters.Add(paramadresse)

            Dim paramt As New SqlParameter
            paramt.ParameterName = "@telephone"
            paramt.SqlDbType = SqlDbType.NVarChar
            paramt.Value = datNaissPers.Text
            cmd.Parameters.Add(paramt)

            Dim paramba As New SqlParameter
            paramba.ParameterName = "@badge"
            paramba.SqlDbType = SqlDbType.NVarChar
            paramba.Value = txtbadge.Text
            cmd.Parameters.Add(paramba)

            Dim parame As New SqlParameter
            parame.ParameterName = "@email"
            parame.SqlDbType = SqlDbType.NVarChar
            parame.Value = txtMail.Text
            cmd.Parameters.Add(parame)

            Dim params As New SqlParameter
            params.ParameterName = "@statut"
            params.SqlDbType = SqlDbType.NVarChar
            params.Value = cbx_statut_pers.Text
            cmd.Parameters.Add(params)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification des Informations du Personnel " & txtMat.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")
            affiche_personnel()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_mat.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_prenom.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_nom.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_service.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_fonction.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_age.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_genre.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_adresse.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_tel.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_badge.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.Pict_pers_image.Image = My.Resources.default_avatar1
        Form2_menu_principal.Usercontroler2_personnel1.lbl_pers_email.Text = ""
        Form2_menu_principal.Usercontroler2_personnel1.lblStatut_pers.Text = ""

    End Sub

    Private Sub Personnel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtadresse.Text = ""
        txtNom.Clear()
        txtMat.Text = ""
        txtPre.Text = ""
        txtTel.Clear()
        txtMail.Text = ""
        txtfonc.Text = ""
        txtser.Text = ""
        cbx_statut_pers.Text = ""
        txtbadge.Text = ""
        TbPhoto.Text = ""
        picbxPerson.Image = My.Resources.default_avatar1

        rbMpers.Checked = False
        rbFpers.Checked = False

    End Sub
End Class
