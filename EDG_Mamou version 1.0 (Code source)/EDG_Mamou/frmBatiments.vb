Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class frmBatiments

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Try
            If txt_id_bat.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Identifiant du Batiment")
                txtCode_batiment.Focus()
                Exit Sub
            End If

            If cmb_client_bat.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom du Proprietaire ")
                cmb_client_bat.Focus()
                Exit Sub
            End If
            If cmbCategorie_batiment.Text = "" Then
                MessageBox.Show("Veuillez entrer la Categorie du Batiment")
                cmbCategorie_batiment.Focus()
                Exit Sub
            End If
            If cmb_agent_branch.Text = "" Then
                MessageBox.Show("Veuillez Entrer le Nom de l'agent qui A Branche le Batiment")
                cmb_agent_branch.Focus()
                Exit Sub
            End If

            If cmbnature_branche_batiment.Text = "" Then
                MessageBox.Show("Veuillez entrer La Nature du branchement du batiment")
                cmbnature_branche_batiment.Focus()
                Exit Sub
            End If
            If txtFraiPayer_batiment.Text = "" Then
                MessageBox.Show("Veuillez les frais de branchement")
                txtFraiPayer_batiment.Focus()
                Exit Sub
            End If

            If cmbTournee.Text = "" Then
                MessageBox.Show("Veuillez entrer la Tourne du Batiment")
                cmbTournee.Focus()
                Exit Sub
            End If

            If txtAmperage_batiment.Text = "" Then
                MessageBox.Show("Veuillez entrer L'amperage du Batiment")
                txtAmperage_batiment.Focus()
                Exit Sub
            End If
            If txtPuissance_batiment.Text = "" Then
                MessageBox.Show("Veuillez entrer La Puissance Utilisé")
                txtPuissance_batiment.Focus()
                Exit Sub
            End If

            If cmbTypeBat_batiment.Text = "" Then
                MessageBox.Show("Veuillez entrer LE Type du Batiment")
                cmbTypeBat_batiment.Focus()
                Exit Sub
            End If

            If cmbTypeTension_batiment.Text = "" Then
                MessageBox.Show("Veuillez entrer LE Type De tension Utilisé")
                cmbTypeTension_batiment.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select *from BATIMENT where(CODE_BAT=@CODE)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@CODE"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtCode_batiment.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtCode_batiment.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into BATIMENT(CODE_BAT,ID_BAT,NUM_TOURNE,NUM_CL,MAT,LIBELLE_CAT,NATURE_BR_BAT,FRAIS_A_PAYE,DATE_BR_BAT,REGLAGE_AMPER_DISJ_BAT,PUISSANCE_BAT,TYPE_BAT,TYPE_TENSION,STATUT,SOLDE) values (@CODE,@id,@TOURNE,@CLIENT,@AGENT,@categorie,@NATURE,@FRAIS,@DATE,@REGLAGE,@PUISSANCE,@TYPE_BAT,@TYPE_TENSION,@Abonné,@sol)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@CODE"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtCode_batiment.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@id"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txt_id_bat.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@TOURNE"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmbTournee.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@CLIENT"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = cmb_client_bat.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@AGENT"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = cmb_agent_branch.Text
            cmd.Parameters.Add(param4)


            Dim param5 As New SqlParameter
            param5.ParameterName = "@categorie"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = cmbCategorie_batiment.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@NATURE"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = cmbnature_branche_batiment.Text
            cmd.Parameters.Add(param6)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@FRAIS"
            param7.SqlDbType = SqlDbType.Money
            param7.Value = Val(txtFraiPayer_batiment.Text)
            cmd.Parameters.Add(param7)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@DATE"
            param8.SqlDbType = SqlDbType.Date
            param8.Value = dt_date_brach.Text
            cmd.Parameters.Add(param8)

            Dim param9 As New SqlParameter
            param9.ParameterName = "@REGLAGE"
            param9.SqlDbType = SqlDbType.Int
            param9.Value = Val(txtAmperage_batiment.Text)
            cmd.Parameters.Add(param9)

            Dim param10 As New SqlParameter
            param10.ParameterName = "@PUISSANCE"
            param10.SqlDbType = SqlDbType.Int
            param10.Value = Val(txtPuissance_batiment.Text)
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@TYPE_BAT"
            param11.SqlDbType = SqlDbType.NVarChar
            param11.Value = cmbTypeBat_batiment.Text
            cmd.Parameters.Add(param11)

            Dim param12 As New SqlParameter
            param12.ParameterName = "@TYPE_TENSION"
            param12.SqlDbType = SqlDbType.NVarChar
            param12.Value = cmbTypeTension_batiment.Text
            cmd.Parameters.Add(param12)

            Dim param122 As New SqlParameter
            param122.ParameterName = "@sol"
            param122.SqlDbType = SqlDbType.Money
            param122.Value = 0
            cmd.Parameters.Add(param122)

            Dim param132 As New SqlParameter
            param132.ParameterName = "@Abonné"
            param132.SqlDbType = SqlDbType.NVarChar
            param132.Value = "Abonné"
            cmd.Parameters.Add(param132)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du Batiment N° " & txtCode_batiment.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            affiche_batiment_statis()

            combox_batiment_consom()
            txtCode_batiment.Text = ""
            txt_id_bat.Text = ""
            cmbTournee.Text = ""
            cmbCategorie_batiment.Text = ""
            cmb_agent_branch.Text = ""
            cmbnature_branche_batiment.Text = ""
            dt_date_brach.Text = ""
            txtAmperage_batiment.Text = ""
            txtPuissance_batiment.Text = ""
            cmbTypeBat_batiment.Text = ""
            cmbTypeTension_batiment.Text = ""
            txtFraiPayer_batiment.Text = ""

            Form2_menu_principal.UserControl1_batiment1.lblcode_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblagent_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblamp_dijon_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblclient_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbldate_branche_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbldate_branche_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblfrais_paye_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblpuissance_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbltype_batiment_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblnat_branche_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbtcat_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbltype_tension_bat.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage client
        affiche_batiment()
    End Sub

    Private Sub txt_id_bat_TextChanged(sender As Object, e As EventArgs) Handles txt_id_bat.TextChanged
        txtCode_batiment.Text = cmbTournee.Text + "-" + txt_id_bat.Text
    End Sub

    Private Sub cmbTournee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTournee.SelectedIndexChanged
        txtCode_batiment.Text = cmbTournee.Text + "-" + txt_id_bat.Text
    End Sub

    
    Private Sub cmbTournee_TextChanged(sender As Object, e As EventArgs) Handles cmbTournee.TextChanged
        txtCode_batiment.Text = cmbTournee.Text + "-" + txt_id_bat.Text
    End Sub

    Private Sub frmBatiments_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtCode_batiment.Text = ""
        txt_id_bat.Text = ""
        cmbTournee.Text = ""
        cmb_client_bat.Text = ""
        cmbCategorie_batiment.Text = ""
        cmb_agent_branch.Text = ""
        cmbnature_branche_batiment.Text = ""
        dt_date_brach.Text = ""
        txtAmperage_batiment.Text = ""
        txtPuissance_batiment.Text = ""
        cmbTypeBat_batiment.Text = ""
        cmbTypeTension_batiment.Text = ""
        txtFraiPayer_batiment.Text = ""
    End Sub

    Private Sub frmBatiments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chaine_connection()

        Dim cmn As New SqlCommand()
        cmn.CommandText = "select CODE_TOURNE from TOURNE"
        cmn.CommandType = CommandType.Text
        cmn.Connection = conx
        Dim dtrd As SqlDataReader = cmn.ExecuteReader
        cmbTournee.Items.Clear()
        While (dtrd.Read)
            cmbTournee.Items.Add(dtrd.Item(0))
        End While
        dtrd.Close()

        Dim cm As New SqlCommand()
        cm.CommandText = "select LIBELLE_CAT from CATEGORIE_BATIMENT"
        cm.CommandType = CommandType.Text
        cm.Connection = conx
        Dim dt As SqlDataReader = cm.ExecuteReader
        cmbCategorie_batiment.Items.Clear()
        While (dt.Read)
            cmbCategorie_batiment.Items.Add(dt.Item(0))
        End While
        dt.Close()

        Dim com As New SqlCommand()
        com.CommandText = "select MAT from PERSONNEL where FONCTION_PERS='Agent'"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        cmb_agent_branch.Items.Clear()
        While (dr.Read)
            cmb_agent_branch.Items.Add(dr.Item(0))
        End While
        dr.Close()

        Dim cmnd As New SqlCommand()
        cmnd.CommandText = "select NUM_CL from CLIENT"
        cmnd.CommandType = CommandType.Text
        cmnd.Connection = conx
        Dim dat As SqlDataReader = cmnd.ExecuteReader
        cmb_client_bat.Items.Clear()
        While (dat.Read)
            cmb_client_bat.Items.Add(dat.Item(0))
        End While
        dat.Close()


        txt_id_bat.Focus()

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Try
            chaine_connection()

            Dim cmd As New SqlCommand("UPDATE BATIMENT SET ID_BAT=@id,NUM_TOURNE=@TOURNE,NUM_CL=@CLIENT,MAT=@AGENT,LIBELLE_CAT=@categorie,NATURE_BR_BAT=@NATURE,FRAIS_A_PAYE=@FRAIS,DATE_BR_BAT=@DATE,REGLAGE_AMPER_DISJ_BAT=@REGLAGE,PUISSANCE_BAT=@PUISSANCE,TYPE_BAT=@TYPE_BAT,TYPE_TENSION=@TYPE_TENSION where CODE_BAT=@CODE")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@CODE"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = Form2_menu_principal.UserControl1_batiment1.lblcode_bat.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@id"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = Val(txt_id_bat.Text)
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@TOURNE"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmbTournee.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@CLIENT"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = cmb_client_bat.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@AGENT"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = cmb_agent_branch.Text
            cmd.Parameters.Add(param4)


            Dim param5 As New SqlParameter
            param5.ParameterName = "@categorie"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = cmbCategorie_batiment.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@NATURE"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = cmbnature_branche_batiment.Text
            cmd.Parameters.Add(param6)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@FRAIS"
            param7.SqlDbType = SqlDbType.Money
            param7.Value = Val(txtFraiPayer_batiment.Text)
            cmd.Parameters.Add(param7)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@DATE"
            param8.SqlDbType = SqlDbType.Date
            param8.Value = dt_date_brach.Text
            cmd.Parameters.Add(param8)

            Dim param9 As New SqlParameter
            param9.ParameterName = "@REGLAGE"
            param9.SqlDbType = SqlDbType.Int
            param9.Value = Val(txtAmperage_batiment.Text)
            cmd.Parameters.Add(param9)

            Dim param10 As New SqlParameter
            param10.ParameterName = "@PUISSANCE"
            param10.SqlDbType = SqlDbType.Int
            param10.Value = Val(txtPuissance_batiment.Text)
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@TYPE_BAT"
            param11.SqlDbType = SqlDbType.NVarChar
            param11.Value = cmbTypeBat_batiment.Text
            cmd.Parameters.Add(param11)

            Dim param12 As New SqlParameter
            param12.ParameterName = "@TYPE_TENSION"
            param12.SqlDbType = SqlDbType.NVarChar
            param12.Value = cmbTypeTension_batiment.Text
            cmd.Parameters.Add(param12)

            chaine_connection()
            cmd.ExecuteNonQuery()
            affiche_batiment()
            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification du Batiment " & txtCode_batiment.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Modification effectuée avec succès")

            Form2_menu_principal.UserControl1_batiment1.lblcode_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblagent_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblamp_dijon_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblclient_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbldate_branche_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbldate_branche_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblfrais_paye_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblpuissance_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbltype_batiment_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lblnat_branche_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbtcat_bat.Text = ""
            Form2_menu_principal.UserControl1_batiment1.lbltype_tension_bat.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage client

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class