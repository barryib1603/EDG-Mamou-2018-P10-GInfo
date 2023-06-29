Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Form1_poste

    Private Sub Form1_poste_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtnum_poste.Text = ""
        cmb_zone.Text = ""
        txtlibelle_poste.Text = ""
        cmb_depart.Text = ""
        txtpuissance_nominale_poste.Text = ""
        txtintensite_nominale_poste.Text = ""
        txttype_poste.Text = ""
        txtnature_poste.Text = ""
        txtlignemt_long_poste.Text = ""
        txtlignemt_section_poste.Text = ""
        txtlignebt_long_poste.Text = ""
    End Sub

    Private Sub Form1_poste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chaine_connection()

        Dim cmn As New SqlCommand()
        cmn.CommandText = "select Num_dep from DEPART"
        cmn.CommandType = CommandType.Text
        cmn.Connection = conx
        Dim dtrd As SqlDataReader = cmn.ExecuteReader
        cmb_depart.Items.Clear()
        While (dtrd.Read)
            cmb_depart.Items.Add(dtrd.Item(0))
        End While
        dtrd.Close()

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ajou.Click
        Try
            If txtnum_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DU CLIENT")
                txtnum_poste.Focus()
                Exit Sub
            End If
            If txtlibelle_poste.Text = "" Then
                MessageBox.Show("Veuillez saisir le NOM DU CLIENT")
                txtlibelle_poste.Focus()
                Exit Sub
            End If
            If txttype_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer le PRENOM DU CLIENT")
                txttype_poste.Focus()
                Exit Sub
            End If
            If txtnature_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer L'ADRESSE DU CLIENT")
                txtnature_poste.Focus()
                Exit Sub
            End If

            If cmb_depart.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DE TELEPHONE DU CLIENT")
                cmb_depart.Focus()
                Exit Sub
            End If

            Call chaine_connection()


            Dim cmd0 As New SqlCommand("select * from POSTE where (NUM_POSTE=@txtnum_cl)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@txtnum_cl"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtnum_poste.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtnum_poste.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into POSTE(NUM_POSTE,NUME_ZONE,LIBELLE_POSTE,Num_dep,PUISSNCE_NOMI,INTENSITE_NOMI,TYPE_POSTE,NATURE_POSTE,LONG_MT_POSTE,SECTION_MT_POSTE,LONG_BT_POSTE,date_raccorde) values(@num,@zone,@libelle,@depart,@puis,@int,@type,@nat,@long_mt,@section,@long_bt,@date)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_poste.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@zone"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_zone.Text
            cmd.Parameters.Add(param1)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@libelle"
            param7.SqlDbType = SqlDbType.NVarChar
            param7.Value = txtlibelle_poste.Text
            cmd.Parameters.Add(param7)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@depart"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_depart.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@puis"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtpuissance_nominale_poste.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@int"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtintensite_nominale_poste.Text
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@type"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = txttype_poste.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@nat"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = txtnature_poste.Text
            cmd.Parameters.Add(param6)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@long_mt"
            param8.SqlDbType = SqlDbType.NVarChar
            param8.Value = txtlignemt_long_poste.Text
            cmd.Parameters.Add(param8)

            Dim param9 As New SqlParameter
            param9.ParameterName = "@section"
            param9.SqlDbType = SqlDbType.NVarChar
            param9.Value = txtlignemt_section_poste.Text
            cmd.Parameters.Add(param9)

            Dim param10 As New SqlParameter
            param10.ParameterName = "@long_bt"
            param10.SqlDbType = SqlDbType.NVarChar
            param10.Value = txtlignebt_long_poste.Text
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@date"
            param11.SqlDbType = SqlDbType.NVarChar
            param11.Value = dtpraccorde.Text
            cmd.Parameters.Add(param11)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du poste N° " & txtnum_poste.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")

            txtnum_poste.Text = ""
            cmb_zone.Text = ""
            txtlibelle_poste.Text = ""
            cmb_depart.Text = ""
            txtpuissance_nominale_poste.Text = ""
            txtintensite_nominale_poste.Text = ""
            txttype_poste.Text = ""
            txtnature_poste.Text = ""
            txtlignemt_long_poste.Text = ""
            txtlignemt_section_poste.Text = ""
            txtlignebt_long_poste.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage poste
        affiche_poste()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_annul.Click
        txtnum_poste.Text = ""
        cmb_zone.Text = ""
        txtlibelle_poste.Text = ""
        cmb_depart.Text = ""
        txtpuissance_nominale_poste.Text = ""
        txtintensite_nominale_poste.Text = ""
        txttype_poste.Text = ""
        txtnature_poste.Text = ""
        txtlignemt_long_poste.Text = ""
        txtlignemt_section_poste.Text = ""
        txtlignebt_long_poste.Text = ""
    End Sub

    Private Sub Btn_modif_Click(sender As Object, e As EventArgs) Handles Btn_modif.Click
        Try

            If txtnum_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DU CLIENT")
                txtnum_poste.Focus()
                Exit Sub
            End If
            If txtlibelle_poste.Text = "" Then
                MessageBox.Show("Veuillez saisir le NOM DU CLIENT")
                txtlibelle_poste.Focus()
                Exit Sub
            End If
            If txttype_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer le PRENOM DU CLIENT")
                txttype_poste.Focus()
                Exit Sub
            End If
            If txtnature_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer L'ADRESSE DU CLIENT")
                txtnature_poste.Focus()
                Exit Sub
            End If

            If cmb_depart.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DE TELEPHONE DU CLIENT")
                cmb_depart.Focus()
                Exit Sub
            End If


            chaine_connection()
            Dim cmd As New SqlCommand
            cmd.CommandText = "UPDATE POSTE SET NUM_POSTE=@num,NUME_ZONE=@zone,LIBELLE_POSTE=@libelle,Num_dep=@depart,PUISSNCE_NOMI=@puis,INTENSITE_NOMI=@int,TYPE_POSTE=@type,NATURE_POSTE=@nat,LONG_MT_POSTE=@long_mt,SECTION_MT_POSTE=@section,LONG_BT_POSTE=@long_bt,date_raccorde=@date_rac where (NUM_POSTE=@num)"
            cmd.Connection = conx
            
            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_poste.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@zone"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_zone.Text
            cmd.Parameters.Add(param1)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@libelle"
            param7.SqlDbType = SqlDbType.NVarChar
            param7.Value = txtlibelle_poste.Text
            cmd.Parameters.Add(param7)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@depart"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_depart.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@puis"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtpuissance_nominale_poste.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@int"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtintensite_nominale_poste.Text
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@type"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = txttype_poste.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@nat"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = txtnature_poste.Text
            cmd.Parameters.Add(param6)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@long_mt"
            param8.SqlDbType = SqlDbType.NVarChar
            param8.Value = txtlignemt_long_poste.Text
            cmd.Parameters.Add(param8)

            Dim param9 As New SqlParameter
            param9.ParameterName = "@section"
            param9.SqlDbType = SqlDbType.NVarChar
            param9.Value = txtlignemt_section_poste.Text
            cmd.Parameters.Add(param9)

            Dim param10 As New SqlParameter
            param10.ParameterName = "@long_bt"
            param10.SqlDbType = SqlDbType.NVarChar
            param10.Value = txtlignebt_long_poste.Text
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@date_rac"
            param11.SqlDbType = SqlDbType.NVarChar
            param11.Value = dtpraccorde.Text
            cmd.Parameters.Add(param11)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification du poste N° " & txtnum_poste.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")
            affiche_poste()
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
End Class