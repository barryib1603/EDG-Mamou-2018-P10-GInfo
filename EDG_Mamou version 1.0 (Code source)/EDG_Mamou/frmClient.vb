Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class frmClient
    Dim nbr() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}


    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If nbr.Contains(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnvalider_cl.Click
        chaine_connection()
        Try
            If txtNumero.Text = "" Then
                MessageBox.Show("VEUILLEZ SAISIR LE NUMERO DU CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNumero.Focus()
                Exit Sub
            End If
            If txtNom.Text = "" Then
                MessageBox.Show("VEUILLEZ SAISIR LE NOM DU CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNom.Focus()
                Exit Sub
            End If
            If txtPrenom.Text = "" Then
                MessageBox.Show("VEUILLEZ SAISIR LE PRENOM DU CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrenom.Focus()
                Exit Sub
            End If
            If txtAdresse.Text = "" Then
                MessageBox.Show("VEUILLEZ DONNER UNE ADRESSE A CE CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAdresse.Focus()
                Exit Sub
            End If

            If txtTelephone.Text = "" Then
                MessageBox.Show("VEUILLEZ ENTRER UN NUMERO POUR CE CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTelephone.Focus()
                Exit Sub
            End If

            If (rbM.Checked = False) And (rbF.Checked = False) Then
                MessageBox.Show("VEUILLEZ CHOISIR GENRE POUR LE CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrenom.Focus()
                Exit Sub
            End If

            If TbPhoto.Text = "" Then
                MessageBox.Show("VEUILLEZ CHOISIR UNE PHOTO POUR CE CLIENT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Call chaine_connection()


            Dim cmd0 As New SqlCommand("select *from CLIENT where(NUM_CL=@txtnum_cl)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@txtnum_cl"
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
            Dim cmd As New SqlCommand("Insert into CLIENT(NUM_CL,PRENOM_CL,NOM_CL,AGE_CL,GENRE_CL,ADRESSE_CL,TEL_CL,PHOTO_CL,EMAIL_CL,STATUT_CL) values(@num,@prenom_cl,@nom_cl,@age, @genre,@adresse,@tel,@photo,@mail,'Abonné')")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtNumero.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@prenom_cl"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtPrenom.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@nom_cl"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtNom.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@age"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = DatNaissCL.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@genre"
            param4.SqlDbType = SqlDbType.NVarChar
            If (rbM.Checked = True) Then
                param4.Value = "Masculin"
            Else
                param4.Value = "Féminin"
            End If
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@adresse"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = txtAdresse.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@tel"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = txtTelephone.Text
            cmd.Parameters.Add(param6)

            Dim img As Image
            Dim t() As Byte
            img = Image.FromFile(TbPhoto.Text)
            t = Image2ByteArray(img)
            Dim param7 As New SqlParameter
            param7.ParameterName = "@photo"
            param7.SqlDbType = SqlDbType.VarBinary
            param7.Value = t
            cmd.Parameters.Add(param7)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@mail"
            param8.SqlDbType = SqlDbType.NVarChar
            param8.Value = txtmail_cl.Text
            cmd.Parameters.Add(param8)


            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du Client N°" & txtNumero.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()
            aff_client_sta()

            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim confirmation As DialogResult = MessageBox.Show("VOULEZ VOUS AJOUTER UN BATIMENT POUR CE CLIENT", "DEMANDE D'AJOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If confirmation = Windows.Forms.DialogResult.Yes Then
                frmBatiments.cmb_client_bat.Text = txtNumero.Text
                Me.Hide()

                frmBatiments.ShowDialog()
            End If

            'procedure affichage client
            affiche_client()

            txtAdresse.Text = ""
            txtNom.Clear()
            txtNumero.Text = ""
            txtPrenom.Text = ""
            txtTelephone.Clear()
            rbM.Checked = False
            rbF.Checked = False
            PictureBox1.Image = My.Resources.default_avatar1


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = ("Choisir une image|*.jpg;*.Bmp;*.png;*.ico;*.bitmap")

        OpenFileDialog1.ShowDialog()
        TbPhoto.Text = OpenFileDialog1.FileName
        Dim img As Image
        Dim t() As Byte
        If Not ((TbPhoto.Text).Equals("OpenFileDialog1")) Then
            img = Image.FromFile(TbPhoto.Text)
            t = Image2ByteArray(img)
            img = ByteArray2Image(t)
            PictureBox1.Image = img
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = ("Choisir une image|*.jpg;*.Bmp;*.png;*.ico;*.bitmap")

        OpenFileDialog1.ShowDialog()
        TbPhoto.Text = OpenFileDialog1.FileName
        Dim img As Image
        Dim t() As Byte
        If Not ((TbPhoto.Text).Equals("OpenFileDialog1")) Then
            img = Image.FromFile(TbPhoto.Text)
            t = Image2ByteArray(img)
            img = ByteArray2Image(t)
            PictureBox1.Image = img


        End If
    End Sub


    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles btnmodifier_cl.Click
        Try

            If txtNumero.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DU CLIENT")
                txtNumero.Focus()
                Exit Sub
            End If
            If txtNom.Text = "" Then
                MessageBox.Show("Veuillez saisir le NOM DU CLIENT")
                txtNom.Focus()
                Exit Sub
            End If
            If txtPrenom.Text = "" Then
                MessageBox.Show("Veuillez entrer le PRENOM DU CLIENT")
                txtPrenom.Focus()
                Exit Sub
            End If
            If txtAdresse.Text = "" Then
                MessageBox.Show("Veuillez entrer L'ADRESSE DU CLIENT")
                txtAdresse.Focus()
                Exit Sub
            End If

            If txtTelephone.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DE TELEPHONE DU CLIENT")
                txtTelephone.Focus()
                Exit Sub
            End If

            If (rbM.Checked = False) And (rbF.Checked = False) Then
                MessageBox.Show("Veuillez choisir le GENRE DU CLIENT")
                txtPrenom.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand
            If TbPhoto.Text <> "" Then
                chaine_connection()
                cmd.CommandText = "UPDATE CLIENT SET PRENOM_CL=@prenom,NOM_CL=@nom,AGE_CL=@age,GENRE_CL=@genre,ADRESSE_CL=@adresse,TEL_CL=@tel,PHOTO_CL=@photo where NUM_CL=@code"
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
                chaine_connection()
                cmd.CommandText = "UPDATE CLIENT SET PRENOM_CL=@prenom,NOM_CL=@nom,AGE_CL=@age,GENRE_CL=@genre,ADRESSE_CL=@adresse,TEL_CL=@tel where NUM_CL=@code"
                cmd.Connection = conx
            End If

            Dim paramx1 As New SqlParameter
            paramx1.ParameterName = "@code"
            paramx1.SqlDbType = SqlDbType.Int
            paramx1.Value = Form2_menu_principal.UserControl1_client1.lbl_num_client.Text
            cmd.Parameters.Add(paramx1)

            Dim param21 As New SqlParameter
            param21.ParameterName = "@prenom"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = txtPrenom.Text
            cmd.Parameters.Add(param21)


            Dim param22 As New SqlParameter
            param22.ParameterName = "@nom"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = txtNom.Text
            cmd.Parameters.Add(param22)


            Dim param3 As New SqlParameter
            param3.ParameterName = "@age"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = DatNaissCL.Text
            cmd.Parameters.Add(param3)


            Dim paramx As New SqlParameter
            paramx.ParameterName = "@genre"
            paramx.SqlDbType = SqlDbType.NVarChar
            If rbF.Checked = True Then
                paramx.Value = "Féminin"
            Else
                paramx.Value = "Masculin"
            End If
            cmd.Parameters.Add(paramx)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@adresse"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtAdresse.Text
            cmd.Parameters.Add(param4)


            Dim param5 As New SqlParameter
            param5.ParameterName = "@tel"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = txtTelephone.Text
            cmd.Parameters.Add(param5)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification du Client " & txtNumero.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")
            TbPhoto.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        affiche_client()
        Form2_menu_principal.UserControl1_client1.lbl_num_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_prenom_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_nom_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_genre_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_tel_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_adresse_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_age_client.Text = ""
        Form2_menu_principal.UserControl1_client1.lbl_email_client.Text = ""
        Form2_menu_principal.UserControl1_client1.Pict_img__client.Image = My.Resources.default_avatar1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      
        txtNumero.Clear()
        txtNom.Clear()
        txtmail_cl.Clear()
        txtPrenom.Clear()
        txtAdresse.Clear()
        txtTelephone.Clear()
        DatNaissCL.Text = ""
        rbF.Checked = False
        rbM.Checked = False
        PictureBox1.Image = My.Resources.default_avatar1
    End Sub


    Private Sub frmClient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtNumero.Clear()
        txtNom.Clear()
        txtmail_cl.Clear()
        txtPrenom.Clear()
        txtAdresse.Clear()
        txtTelephone.Clear()
        DatNaissCL.Text = ""
        rbF.Checked = False
        rbM.Checked = False
        PictureBox1.Image = My.Resources.default_avatar1
    End Sub

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblannuler.Click

    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        chaine_connection()
        Dim cmd As New SqlCommand
        cmd.CommandText = "select max(NUM_CL) from CLIENT"
        cmd.Connection = conx
        If IsDBNull(cmd.ExecuteScalar) Then
            txtNumero.Text = 1
        Else
            txtNumero.Text = cmd.ExecuteScalar + 1
        End If
    End Sub
End Class