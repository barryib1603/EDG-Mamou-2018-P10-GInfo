Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class UserControl1_facturation

    Private Sub UserControl1_facturation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chaine_connection()

        combox_batiment_consom()

        Cmb_recherche.SelectedItem = "Facture"

        Dim jour As Integer
        Dim anee As Integer
        cmb_jour_recherche_paie.Items.Clear()
        For jour = 1 To 31
            cmb_jour_recherche_paie.Items.Add(jour)
        Next

        cmb_annee_recherche_paie.Items.Clear()
        For anee = 2000 To (Year(Date.Today))
            cmb_annee_recherche_paie.Items.Add(anee)
        Next

    End Sub

    Private Sub Cmb_recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_recherche.SelectedIndexChanged
        If Cmb_recherche.SelectedItem = "Mois et Annee" Then
            cmb_annee_recherche_paie.Visible = True
            cmb_mois_recherche_paie.Visible = True
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = False
        ElseIf Cmb_recherche.SelectedItem = "Date Enregistrement" Then
            cmb_annee_recherche_paie.Visible = False
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = False
        ElseIf Cmb_recherche.SelectedItem = "Année" Then
            cmb_annee_recherche_paie.Visible = True
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = False
        Else
            cmb_annee_recherche_paie.Visible = False
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = True
        End If
    End Sub

    'Pour la categorie
    Dim TRANCHE1, MONTANT1, TRANCHE2, MONTANT2, TRANCHE3, MONTANT3, PRIME_FIX, POURCENT_FRANCHI, LIMITE_FRANCHI As Integer
    'Pour la consommation
    Dim ANCIEN_INDEX_CONSOM, NOUVEL_INDEX_CONSOM, TR1, MONT1, TR2, MONT2, TR3, MONT3, TVA_PRIME_FIX, MONTANT_ENERGIE, TVA_ENERGIE, MONTANT_TTC, IMPAYE As Integer
    Dim LIBELLE_CAT As String

    Dim M1 As Integer
    Dim M2 As Integer
    Dim M3 As Integer
    Dim kw_cons As Integer

    Private Sub btnvalider_cons_Click(sender As Object, e As EventArgs) Handles btnvalider_cons.Click

        TRANCHE1 = 0
        MONTANT1 = 0
        TRANCHE2 = 0
        MONTANT2 = 0
        TRANCHE3 = 0
        MONTANT3 = 0
        PRIME_FIX = 0
        POURCENT_FRANCHI = 0
        LIMITE_FRANCHI = 0
        ANCIEN_INDEX_CONSOM = 0
        NOUVEL_INDEX_CONSOM = 0
        TR1 = 0
        MONT1 = 0
        TR2 = 0
        MONT2 = 0
        TR3 = 0
        MONT3 = 0
        TVA_PRIME_FIX = 0
        MONTANT_ENERGIE = 0
        TVA_ENERGIE = 0
        MONTANT_TTC = 0
        IMPAYE = 0
        M1 = 0
        M2 = 0
        M3 = 0

        Try
            If TxtNumero_cons.Text = "" Then
                MessageBox.Show("Veuillez entrer le NUMERO DE CONSOMMATION")
                TxtNumero_cons.Focus()
                Exit Sub
            End If
            If cmb_bat.Text = "" Then
                MessageBox.Show("VEUILLEZ SELECTIONNER LE BATIMENT  ")
                cmb_bat.Focus()
                Exit Sub
            End If
            If txt_nouvel_index.Text = "" Then
                MessageBox.Show("Veuillez entrer le PRENOM DU CLIENT")
                txt_nouvel_index.Focus()
                Exit Sub
            End If
            If cbx_mois_cons.Text = "" Then
                MessageBox.Show("Veuillez entrer MOIS ")
                cbx_mois_cons.Focus()
                Exit Sub
            End If
            If cbx_annee_cons.Text = "" Then
                MessageBox.Show("Veuillez entrer l'ANNEE")
                cbx_annee_cons.Focus()
                Exit Sub
            End If

            If Val(txt_ancien_index.Text) > Val(txt_nouvel_index.Text) Then
                MessageBox.Show("Le Nouvel doit être superieur à l'ancien", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_nouvel_index.Focus()
                Exit Sub
            End If

            Call chaine_connection()
            Dim cmd0 As New SqlCommand("select * from CONSOMMATION where(NUM_COMSOM=@numero)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@numero"
            param0.SqlDbType = SqlDbType.Int
            param0.Value = Val(TxtNumero_cons.Text)
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                TxtNumero_cons.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()

            Dim cmd1 As New SqlCommand("select * from CONSOMMATION where (CODE_BAT=@CODE) and (MOIS_CONSOM=@MOIS) and (ANNEE_CONSOM=@annee)")
            cmd1.Connection = conx
            Dim param8 As New SqlParameter
            param8.ParameterName = "@CODE"
            param8.SqlDbType = SqlDbType.NVarChar
            param8.Value = cmb_bat.Text
            cmd1.Parameters.Add(param8)

            Dim paramx As New SqlParameter
            paramx.ParameterName = "@MOIS"
            paramx.SqlDbType = SqlDbType.NVarChar
            paramx.Value = cbx_mois_cons.Text
            cmd1.Parameters.Add(paramx)

            Dim parame As New SqlParameter
            parame.ParameterName = "@annee"
            parame.SqlDbType = SqlDbType.Int
            parame.Value = Val(cbx_annee_cons.Text)
            cmd1.Parameters.Add(parame)

            Dim lir As SqlDataReader = cmd1.ExecuteReader

            If ((lir.Read)) Then
                MessageBox.Show("La Consommation pour La période selectionnée a déjà été établie pour ce Batiment")
                lir.Close()
                Exit Sub
            End If
            lir.Close()

            '///////////////////RECUPERATION DES IMPAYES///////////////

            Dim c As New SqlCommand()
            c.CommandText = "select SUM(MONTANT_TTC) from CONSOMMATION where CODE_BAT=@code"
            c.Connection = conx
            Dim p As New SqlParameter
            p.ParameterName = "@code"
            p.SqlDbType = SqlDbType.NVarChar
            p.Value = cmb_bat.Text
            c.Parameters.Add(p)
            Dim montant_t As Long
            If IsDBNull(c.ExecuteScalar) Then
                montant_t = 0
            Else
                montant_t = c.ExecuteScalar()
            End If

            Dim c1 As New SqlCommand()
            c1.CommandText = "select SUM(MONTANT_PAIE) from PAIEMENT where NUM_COMSOM in (select NUM_COMSOM from CONSOMMATION where CODE_BAT=@cod)"
            c1.Connection = conx
            Dim pp As New SqlParameter
            pp.ParameterName = "@cod"
            pp.SqlDbType = SqlDbType.NVarChar
            pp.Value = cmb_bat.Text
            c1.Parameters.Add(pp)
            Dim montant_p As Long
            If IsDBNull(c1.ExecuteScalar) Then
                montant_p = 0
            Else
                montant_p = c1.ExecuteScalar()
            End If

            chaine_connection()
            Dim cmd As New SqlCommand("Insert into CONSOMMATION([CODE_BAT],[ANCIEN_INDEX_CONSOM],[NOUVEL_INDEX_CONSOM],[MOIS_CONSOM],[ANNEE_CONSOM],[DATE_DEBUT_CONSOM],[DATE_FIN_CONSOM],[TRANCHE1],[MONTANT1],[TRANCHE2],[MONTANT2],[TRANCHE3],[MONTANT3],[POURCENT_FRANCHI],[LIMITE_FRANCHI],[PRIME_FIX],[TVA_PRIME_FIX],[MONTANT_ENERGIE],[TVA_ENERGIE],[MONTANT_TTC],[IMPAYE],[STATUT_CONSOM]) values(@CODE_BAT,@ANCIEN_INDEX_CONSOM,@NOUVEL_INDEX_CONSOM,@MOIS_CONSOM,@ANNEE_CONSOM,@DATE_DEBUT_CONSOM,@DATE_FIN_CONSOM,@TRANCHE1,@MONTANT1,@TRANCHE2,@MONTANT2,@TRANCHE3,@MONTANT3,@POURCENT_FRANCHI,@LIMITE_FRANCHI,@PRIME_FIX,@TVA_PRIME_FIX,@MONTANT_ENERGIE,@TVA_ENERGIE,@MONTANT_TTC,@IMPAYE,'Impayé')")
            cmd.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@CODE_BAT"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_bat.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@ANCIEN_INDEX_CONSOM"
            param2.SqlDbType = SqlDbType.Int
            param2.Value = Val(txt_ancien_index.Text)
            cmd.Parameters.Add(param2)

            Dim parama As New SqlParameter
            parama.ParameterName = "@NOUVEL_INDEX_CONSOM"
            parama.SqlDbType = SqlDbType.Int
            parama.Value = Val(txt_nouvel_index.Text)
            cmd.Parameters.Add(parama)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@MOIS_CONSOM"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = cbx_mois_cons.Text
            cmd.Parameters.Add(param3)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@ANNEE_CONSOM"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = cbx_annee_cons.Text
            cmd.Parameters.Add(param5)

            Dim param78 As New SqlParameter
            param78.ParameterName = "@MONTANT_ENERGIE"
            param78.SqlDbType = SqlDbType.Money
            Try
                chaine_connection()

                Dim cmnd3 As New SqlCommand
                cmnd3.CommandText = "select LIBELLE_CAT from BATIMENT where CODE_BAT=@code"
                cmnd3.Connection = conx

                Dim p1 As New SqlParameter
                p1.ParameterName = "@code"
                p1.SqlDbType = SqlDbType.NVarChar
                p1.Value = cmb_bat.Text
                cmnd3.Parameters.Add(p1)

                LIBELLE_CAT = cmnd3.ExecuteScalar().ToString()

                NOUVEL_INDEX_CONSOM = Val(txt_nouvel_index.Text)
                ANCIEN_INDEX_CONSOM = Val(txt_ancien_index.Text)
                kw_cons = Val(NOUVEL_INDEX_CONSOM) - Val(ANCIEN_INDEX_CONSOM)

                Dim cmd7 As New SqlCommand
                cmd7.CommandText = "select TRANCHE1 from CATEGORIE_BATIMENT where LIBELLE_CAT=@c1"
                cmd7.Connection = conx

                Dim param7 As New SqlParameter
                param7.ParameterName = "@c1"
                param7.SqlDbType = SqlDbType.NVarChar
                param7.Value = LIBELLE_CAT
                cmd7.Parameters.Add(param7)

                TRANCHE1 = Val(cmd7.ExecuteScalar())

                Dim cmd8 As New SqlCommand
                cmd8.CommandText = "select MONTANT1 from CATEGORIE_BATIMENT where LIBELLE_CAT=@C2"
                cmd8.Connection = conx

                Dim p3 As New SqlParameter
                p3.ParameterName = "@C2"
                p3.SqlDbType = SqlDbType.NVarChar
                p3.Value = LIBELLE_CAT
                cmd8.Parameters.Add(p3)

                MONTANT1 = Val(cmd8.ExecuteScalar())

                Dim cmnd9 As New SqlCommand
                cmnd9.CommandText = "select TRANCHE2 from CATEGORIE_BATIMENT where LIBELLE_CAT=@c3"
                cmnd9.Connection = conx

                Dim param9 As New SqlParameter
                param9.ParameterName = "@c3"
                param9.SqlDbType = SqlDbType.NVarChar
                param9.Value = LIBELLE_CAT
                cmnd9.Parameters.Add(param9)

                TRANCHE2 = Val(cmnd9.ExecuteScalar())

                Dim cmd10 As New SqlCommand
                cmd10.CommandText = "select MONTANT2 from CATEGORIE_BATIMENT where LIBELLE_CAT=@c4"
                cmd10.Connection = conx

                Dim param10 As New SqlParameter
                param10.ParameterName = "@c4"
                param10.SqlDbType = SqlDbType.NVarChar
                param10.Value = LIBELLE_CAT
                cmd10.Parameters.Add(param10)

                MONTANT2 = Val(cmd10.ExecuteScalar())

                Dim cmnd11 As New SqlCommand
                cmnd11.CommandText = "select TRANCHE3 from CATEGORIE_BATIMENT where LIBELLE_CAT=@c5"
                cmnd11.Connection = conx

                Dim param11 As New SqlParameter
                param11.ParameterName = "@c5"
                param11.SqlDbType = SqlDbType.NVarChar
                param11.Value = LIBELLE_CAT
                cmnd11.Parameters.Add(param11)

                TRANCHE3 = Val(cmnd11.ExecuteScalar())

                Dim cmnd12 As New SqlCommand
                cmnd12.CommandText = "select MONTANT3 from CATEGORIE_BATIMENT where LIBELLE_CAT=@c6"
                cmnd12.Connection = conx

                Dim param12 As New SqlParameter
                param12.ParameterName = "@c6"
                param12.SqlDbType = SqlDbType.NVarChar
                param12.Value = LIBELLE_CAT
                cmnd12.Parameters.Add(param12)

                MONTANT3 = Val(cmnd12.ExecuteScalar())

                Dim cmnd13 As New SqlCommand
                cmnd13.CommandText = "select PRIME_FIX from CATEGORIE_BATIMENT where LIBELLE_CAT=@cat1"
                cmnd13.Connection = conx

                Dim param13 As New SqlParameter
                param13.ParameterName = "@cat1"
                param13.SqlDbType = SqlDbType.NVarChar
                param13.Value = LIBELLE_CAT
                cmnd13.Parameters.Add(param13)

                PRIME_FIX = Val(cmnd13.ExecuteScalar())

                Dim cmnd14 As New SqlCommand
                cmnd14.CommandText = "select POURCENT_FRANCHI from CATEGORIE_BATIMENT where LIBELLE_CAT=@cat2"
                cmnd14.Connection = conx

                Dim param14 As New SqlParameter
                param14.ParameterName = "@cat2"
                param14.SqlDbType = SqlDbType.NVarChar
                param14.Value = LIBELLE_CAT
                cmnd14.Parameters.Add(param14)

                POURCENT_FRANCHI = Val(cmnd14.ExecuteScalar())

                Dim cmnd15 As New SqlCommand
                cmnd15.CommandText = "select LIMITE_FRANCHI from CATEGORIE_BATIMENT where LIBELLE_CAT=@cat3"
                cmnd15.Connection = conx

                Dim param15 As New SqlParameter
                param15.ParameterName = "@cat3"
                param15.SqlDbType = SqlDbType.NVarChar
                param15.Value = LIBELLE_CAT
                cmnd15.Parameters.Add(param15)

                LIMITE_FRANCHI = Val(cmnd15.ExecuteScalar())

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            If (MONTANT1 <> 0) And (MONTANT2 = 0) And (MONTANT3 = 0) Then
                MONT1 = kw_cons * MONTANT1
                TR1 = kw_cons
                M1 = MONTANT1
                MONTANT_ENERGIE = MONT1
            ElseIf (MONTANT1 <> 0) And (MONTANT2 <> 0) And (MONTANT3 = 0) Then
                If (kw_cons <= TRANCHE1) Then
                    MONT1 = kw_cons * MONTANT1
                    TR1 = kw_cons
                    M1 = MONTANT1
                    MONTANT_ENERGIE = MONT1
                Else
                    MONT1 = TRANCHE1 * MONTANT1
                    kw_cons = kw_cons - TRANCHE1
                    MONT2 = kw_cons * MONTANT2

                    TR1 = TRANCHE1
                    TR2 = kw_cons
                    M1 = MONTANT1
                    M2 = MONTANT2

                    MONTANT_ENERGIE = MONT1 + MONT2
                End If
            ElseIf (MONTANT1 <> 0) And (MONTANT2 <> 0) And (MONTANT3 <> 0) Then
                If (kw_cons <= TRANCHE1) Then
                    MONT1 = kw_cons * MONTANT1
                    TR1 = kw_cons
                    M1 = MONTANT1
                    MONTANT_ENERGIE = MONT1
                Else
                    If (kw_cons <= TRANCHE2) Then
                        MONT1 = TR1 * MONTANT1
                        kw_cons = kw_cons - TR1
                        MONT2 = kw_cons * MONTANT2

                        TR1 = TRANCHE1
                        TR2 = kw_cons
                        M1 = MONTANT1
                        M2 = MONTANT2

                        MONTANT_ENERGIE = MONT1 + MONT2
                    Else
                        MONT1 = TRANCHE1 * MONTANT1
                        MONT2 = TRANCHE2 * MONTANT2
                        kw_cons = kw_cons - (TRANCHE1 + TRANCHE2)
                        MONT3 = kw_cons * MONTANT3

                        TR1 = TRANCHE1
                        TR2 = TRANCHE2
                        TR3 = kw_cons
                        M1 = MONTANT1
                        M2 = MONTANT2
                        M3 = MONTANT3

                        MONTANT_ENERGIE = MONT1 + MONT2 + MONT3
                    End If
                End If
            End If
            If MONTANT_ENERGIE >= LIMITE_FRANCHI Then
                TVA_ENERGIE = ((MONTANT_ENERGIE - LIMITE_FRANCHI) * POURCENT_FRANCHI) / 100
            Else
                TVA_ENERGIE = 0
            End If
            TVA_PRIME_FIX = (PRIME_FIX * POURCENT_FRANCHI) / 100
            MONTANT_TTC = MONTANT_ENERGIE + TVA_ENERGIE + PRIME_FIX + TVA_PRIME_FIX

            param78.Value = MONTANT_ENERGIE
            cmd.Parameters.Add(param78)

            Dim paramet As New SqlParameter
            paramet.ParameterName = "@IMPAYE"
            paramet.SqlDbType = SqlDbType.Money
            paramet.Value = montant_t - montant_p
            cmd.Parameters.Add(paramet)

            Dim paramete As New SqlParameter
            paramete.ParameterName = "@DATE_DEBUT_CONSOM"
            paramete.SqlDbType = SqlDbType.Date
            paramete.Value = dtpdebut.Text
            cmd.Parameters.Add(paramete)

            Dim pi As New SqlParameter
            pi.ParameterName = "@DATE_FIN_CONSOM"
            pi.SqlDbType = SqlDbType.Date
            pi.Value = dtpfin.Text
            cmd.Parameters.Add(pi)

            Dim paramet1 As New SqlParameter
            paramet1.ParameterName = "@TRANCHE1"
            paramet1.SqlDbType = SqlDbType.Int
            paramet1.Value = TR1
            cmd.Parameters.Add(paramet1)

            Dim paramet2 As New SqlParameter
            paramet2.ParameterName = "@MONTANT1"
            paramet2.SqlDbType = SqlDbType.Money
            paramet2.Value = M1
            cmd.Parameters.Add(paramet2)

            Dim paramet3 As New SqlParameter
            paramet3.ParameterName = "@TRANCHE2"
            paramet3.SqlDbType = SqlDbType.Int
            paramet3.Value = TR2
            cmd.Parameters.Add(paramet3)


            Dim paramet4 As New SqlParameter
            paramet4.ParameterName = "@MONTANT2"
            paramet4.SqlDbType = SqlDbType.Money
            paramet4.Value = M2
            cmd.Parameters.Add(paramet4)

            Dim paramet5 As New SqlParameter
            paramet5.ParameterName = "@TRANCHE3"
            paramet5.SqlDbType = SqlDbType.Int
            paramet5.Value = TR3
            cmd.Parameters.Add(paramet5)

            Dim paramet6 As New SqlParameter
            paramet6.ParameterName = "@MONTANT3"
            paramet6.SqlDbType = SqlDbType.Money
            paramet6.Value = M3
            cmd.Parameters.Add(paramet6)

            Dim paramet7 As New SqlParameter
            paramet7.ParameterName = "@POURCENT_FRANCHI"
            paramet7.SqlDbType = SqlDbType.Int
            paramet7.Value = POURCENT_FRANCHI
            cmd.Parameters.Add(paramet7)

            Dim paramet8 As New SqlParameter
            paramet8.ParameterName = "@LIMITE_FRANCHI"
            paramet8.SqlDbType = SqlDbType.Money
            paramet8.Value = LIMITE_FRANCHI
            cmd.Parameters.Add(paramet8)

            Dim paramet9 As New SqlParameter
            paramet9.ParameterName = "@PRIME_FIX"
            paramet9.SqlDbType = SqlDbType.Money
            paramet9.Value = PRIME_FIX
            cmd.Parameters.Add(paramet9)

            Dim paramet10 As New SqlParameter
            paramet10.ParameterName = "@TVA_PRIME_FIX"
            paramet10.SqlDbType = SqlDbType.Money
            paramet10.Value = TVA_PRIME_FIX
            cmd.Parameters.Add(paramet10)

            Dim paramet11 As New SqlParameter
            paramet11.ParameterName = "@TVA_ENERGIE"
            paramet11.SqlDbType = SqlDbType.Money
            paramet11.Value = TVA_ENERGIE
            cmd.Parameters.Add(paramet11)

            Dim paramet12 As New SqlParameter
            paramet12.ParameterName = "@MONTANT_TTC"
            paramet12.SqlDbType = SqlDbType.Money
            paramet12.Value = MONTANT_TTC
            cmd.Parameters.Add(paramet12)

            cmd.ExecuteNonQuery()

            Dim c22 As New SqlCommand
            c22.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de la consommation N°:" & TxtNumero_cons.Text & " ','" & Date.Now & "')"
            c22.Connection = conx
            c22.ExecuteNonQuery()

            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

            combox_consom_paie()
            affiche_consommation()
            txt_ancien_index.Text = ""
            txt_nouvel_index.Text = ""
            TxtNumero_cons.Text = ""
            cmb_bat.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Facture" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_COMSOM,CODE_BAT,ANCIEN_INDEX_CONSOM,NOUVEL_INDEX_CONSOM ,MOIS_CONSOM, ANNEE_CONSOM,DATE_DEBUT_CONSOM,DATE_FIN_CONSOM,MONTANT_TTC_CONSOM,IMPAYE from CONSOMMATION where NUM_COMSOM=@num"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim lecteur As SqlDataReader = cmd.ExecuteReader
            dgv_facturation.Rows.Clear()
            While lecteur.Read
                Dim nvIndex As Integer = Val(lecteur.GetValue(5))
                Dim anIndex As Integer = Val(lecteur.GetValue(2))


                dgv_facturation.Rows.Add(lecteur.Item("NUM_COMSOM"), lecteur.Item("CODE_BAT"), lecteur.Item("ANCIEN_INDEX_CONSOM"), lecteur.Item("NOUVEL_INDEX_CONSOM"), nvIndex - anIndex, lecteur.Item("MOIS_CONSOM"), lecteur.Item("ANNEE_CONSOM"), lecteur.Item("DATE_DEBUT_CONSOM"), lecteur.Item("DATE_FIN_CONSOM"), lecteur.Item("MONTANT_TTC_CONSOM"), lecteur.Item("IMPAYE"))
            End While


            'Dim da = New SqlDataAdapter(cmd)
            'Dim ds As New DataTable
            'da.Fill(ds)
            'Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

            'Dim lire As SqlDataReader
            'lire = cmd.ExecuteReader
            'If lire.Read Then
            'Else
            '    MsgBox("ce numero n'existe pas")
            'End If
            'lire.Close()
        End If

        If Cmb_recherche.SelectedItem = "Batiment" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_COMSOM, CODE_BAT , ANCIEN_INDEX_CONSOM,NOUVEL_INDEX_CONSOM,MOIS_CONSOM, ANNEE_CONSOM,DATE_DEBUT_CONSOM,DATE_FIN_CONSOM,MONTANT_TTC_CONSOM,IMPAYE from CONSOMMATION where CODE_BAT=@Batiment"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@Batiment"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim lecteur As SqlDataReader = cmd.ExecuteReader
            dgv_facturation.Rows.Clear()
            While lecteur.Read
                Dim nvIndex As Integer = Val(lecteur.GetValue(5))
                Dim anIndex As Integer = Val(lecteur.GetValue(2))


                dgv_facturation.Rows.Add(lecteur.Item("NUM_COMSOM"), lecteur.Item("CODE_BAT"), lecteur.Item("ANCIEN_INDEX_CONSOM"), lecteur.Item("NOUVEL_INDEX_CONSOM"), nvIndex - anIndex, lecteur.Item("MOIS_CONSOM"), lecteur.Item("ANNEE_CONSOM"), lecteur.Item("DATE_DEBUT_CONSOM"), lecteur.Item("DATE_FIN_CONSOM"), lecteur.Item("MONTANT_TTC_CONSOM"), lecteur.Item("IMPAYE"))
            End While

            'Dim da = New SqlDataAdapter(cmd)
            'Dim ds As New DataTable
            'da.Fill(ds)
            'Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

            'Dim lire As SqlDataReader
            'lire = cmd.ExecuteReader
            'If lire.Read Then
            'Else
            '    MsgBox("ce batiment n'existe pas")

            'End If
            'lire.Close()
        End If

        If Cmb_recherche.SelectedItem = "Mois et Annee" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_COMSOM, CODE_BAT,ANCIEN_INDEX_CONSOM,NOUVEL_INDEX_CONSOM,MOIS_CONSOM, ANNEE_CONSOM,DATE_DEBUT_CONSOM,DATE_FIN_CONSOM,MONTANT_TTC_CONSOM,IMPAYE from CONSOMMATION where MOIS_CONSOM=@moi and ANNEE_CONSOM=@année"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@moi"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_mois_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@année"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_annee_recherche_paie.Text
            cmd.Parameters.Add(param1)

            Dim lecteur As SqlDataReader = cmd.ExecuteReader
            dgv_facturation.Rows.Clear()
            While lecteur.Read
                Dim nvIndex As Integer = Val(lecteur.GetValue(5))
                Dim anIndex As Integer = Val(lecteur.GetValue(2))


                dgv_facturation.Rows.Add(lecteur.Item("NUM_COMSOM"), lecteur.Item("CODE_BAT"), lecteur.Item("ANCIEN_INDEX_CONSOM"), lecteur.Item("NOUVEL_INDEX_CONSOM"), nvIndex - anIndex, lecteur.Item("MOIS_CONSOM"), lecteur.Item("ANNEE_CONSOM"), lecteur.Item("DATE_DEBUT_CONSOM"), lecteur.Item("DATE_FIN_CONSOM"), lecteur.Item("MONTANT_TTC_CONSOM"), lecteur.Item("IMPAYE"))
            End While


            'Dim da = New SqlDataAdapter(cmd)
            'Dim ds As New DataTable
            'da.Fill(ds)
            'Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

            'Dim lire As SqlDataReader
            'lire = cmd.ExecuteReader
            'If lire.Read Then
            'Else
            '    MsgBox("ce moi n'est pas enregistré")

            'End If
            'lire.Close()
        End If

        If Cmb_recherche.SelectedItem = "Année" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_COMSOM, CODE_BAT,ANCIEN_INDEX_CONSOM,NOUVEL_INDEX_CONSOM,MOIS_CONSOM, ANNEE_CONSOM,DATE_DEBUT_CONSOM,DATE_FIN_CONSOM,MONTANT_TTC_CONSOM,IMPAYE from CONSOMMATION where ANNEE_CONSOM =@année "
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@année"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_annee_recherche_paie.Text
            cmd.Parameters.Add(param)
            'Dim da = New SqlDataAdapter(cmd)
            'Dim ds As New DataTable
            'da.Fill(ds)
            'Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

            Dim lecteur As SqlDataReader = cmd.ExecuteReader
            dgv_facturation.Rows.Clear()
            While lecteur.Read
                Dim nvIndex As Integer = Val(lecteur.GetValue(5))
                Dim anIndex As Integer = Val(lecteur.GetValue(2))


                dgv_facturation.Rows.Add(lecteur.Item("NUM_COMSOM"), lecteur.Item("CODE_BAT"), lecteur.Item("ANCIEN_INDEX_CONSOM"), lecteur.Item("NOUVEL_INDEX_CONSOM"), nvIndex - anIndex, lecteur.Item("MOIS_CONSOM"), lecteur.Item("ANNEE_CONSOM"), lecteur.Item("DATE_DEBUT_CONSOM"), lecteur.Item("DATE_FIN_CONSOM"), lecteur.Item("MONTANT_TTC_CONSOM"), lecteur.Item("IMPAYE"))
            End While


            '    Dim lire As SqlDataReader
            '    lire = cmd.ExecuteReader
            '    If lire.Read Then
            '    Else
            '        MsgBox(" il n'ya pas d'enregistrment aucours de l'année saisie")

            '    End If
            '    lire.Close()
        End If

       
    End Sub

    Private Sub txt_recherche_paie_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche_paie.TextChanged
        'chaine_connection()

        'If Cmb_recherche.SelectedItem = "Numéro" Then
        '    Dim cmd As New SqlCommand
        '    cmd.CommandText = "select NUM_COMSOM as NUMERO, CODE_BAT as BATIMENT, ANCIEN_INDEX_CONSOM,NOUVEL_INDEX_CONSOM,MOIS_CONSOM as MOIS, ANNEE_CONSOM as ANNEE,DATE_ENREG_CONSOM as Date_Enregistrement from CONSOMMATION where NUM_COMSOM LIKE '%" & txt_recherche_paie.Text & "%'"
        '    cmd.Connection = conx

        '    Dim param As New SqlParameter
        '    param.ParameterName = "@num"
        '    param.SqlDbType = SqlDbType.NVarChar
        '    param.Value = txt_recherche_paie.Text
        '    cmd.Parameters.Add(param)

        '    Dim da = New SqlDataAdapter(cmd)
        '    Dim ds As New DataTable
        '    da.Fill(ds)
        '    Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

        '    Dim lire As SqlDataReader
        '    lire = cmd.ExecuteReader
        '    If lire.Read Then

        '    End If
        '    lire.Close()
        'End If
        'If Cmb_recherche.SelectedItem = "Batiment" Then
        '    Dim cmd As New SqlCommand
        '    cmd.CommandText = "select NUM_COMSOM as NUMERO, CODE_BAT as BATIMENT, ANCIEN_INDEX_CONSOM as [Ancien Index],NOUVEL_INDEX_CONSOM as [Nouvel Index],MOIS_CONSOM as MOIS, ANNEE_CONSOM as ANNEE,DATE_ENREG_CONSOM as Date_Enregistrement from CONSOMMATION where [CODE_BAT] LIKE '%" & txt_recherche_paie.Text & "%'"
        '    cmd.Connection = conx

        '    Dim da = New SqlDataAdapter(cmd)
        '    Dim ds As New DataTable
        '    da.Fill(ds)
        '    Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds

        '    Dim lire As SqlDataReader
        '    lire = cmd.ExecuteReader
        '    If lire.Read Then

        '    End If
        '    lire.Close()
        'End If
    End Sub
    
    Private Sub dgv_facturation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturation.CellDoubleClick
        If dgv_facturation.CurrentRow.Cells(0).Value.ToString <> "" Then
            TxtNumero_cons.Text = dgv_facturation.CurrentRow.Cells(0).Value.ToString
            cmb_bat.Text = dgv_facturation.CurrentRow.Cells(1).Value.ToString
            txt_ancien_index.Text = dgv_facturation.CurrentRow.Cells(4).Value.ToString
            txt_nouvel_index.Text = dgv_facturation.CurrentRow.Cells(5).Value.ToString

            chaine_connection()
            Dim cmnd1 As New SqlCommand
            cmnd1.CommandText = "select [MOIS_CONSOM] from CONSOMMATION where [NUM_COMSOM]=@moi"
            cmnd1.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@moi"
            param.SqlDbType = SqlDbType.Int
            param.Value = Val(dgv_facturation.CurrentRow.Cells(0).Value().ToString())
            cmnd1.Parameters.Add(param)
            If Not IsDBNull(cmnd1.ExecuteScalar) Then
                cbx_mois_cons.Text = cmnd1.ExecuteScalar
            End If

            Dim cmnd11 As New SqlCommand
            cmnd11.CommandText = "select [ANNEE_CONSOM] from CONSOMMATION where [NUM_COMSOM]=@moi"
            cmnd11.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@moi"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = Val(dgv_facturation.CurrentRow.Cells(0).Value().ToString())
            cmnd11.Parameters.Add(param1)
            If Not IsDBNull(cmnd1.ExecuteScalar) Then
                cbx_annee_cons.Text = cmnd11.ExecuteScalar
            End If

            dtpdebut.Text = dgv_facturation.CurrentRow.Cells(7).Value.ToString
            dtpfin.Text = dgv_facturation.CurrentRow.Cells(8).Value.ToString
        End If
    End Sub

    Private Sub cmb_bat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bat.SelectedIndexChanged
        chaine_connection()
        Dim cmnd1 As New SqlCommand
        cmnd1.CommandText = "select max(NUM_COMSOM) from CONSOMMATION"
        cmnd1.Connection = conx
        If Not IsDBNull(cmnd1.ExecuteScalar) Then
            chaine_connection()
            TxtNumero_cons.Text = Val(cmnd1.ExecuteScalar) + 1
        Else
            TxtNumero_cons.Text = 1
        End If

        Dim cmnd12 As New SqlCommand
        cmnd12.CommandText = "select max(NOUVEL_INDEX_CONSOM) from CONSOMMATION where CODE_BAT=@cod"
        cmnd12.Connection = conx

        Dim param12 As New SqlParameter
        param12.ParameterName = "@cod"
        param12.SqlDbType = SqlDbType.NVarChar
        param12.Value = cmb_bat.SelectedItem
        cmnd12.Parameters.Add(param12)

        txt_ancien_index.Text = cmnd12.ExecuteScalar().ToString()

        Dim c As New SqlCommand
        c.CommandText = "select max(DATE_DEBUT_CONSOM) from CONSOMMATION where CODE_BAT like'" & cmb_bat.Text & "'"
        c.Connection = conx

        If Not IsDBNull(c.ExecuteScalar) Then
            chaine_connection()
            dtpdebut.Text = c.ExecuteScalar
        Else
            dtpdebut.Enabled = True
        End If

    End Sub

    Private Sub cmb_bat_TextChanged(sender As Object, e As EventArgs) Handles cmb_bat.TextChanged

        If cmb_bat.Text <> "" Then
            chaine_connection()
            Dim cmnd1 As New SqlCommand
            cmnd1.CommandText = "select max(NUM_COMSOM) from CONSOMMATION"
            cmnd1.Connection = conx

            If Not IsDBNull(cmnd1.ExecuteScalar) Then
                TxtNumero_cons.Text = Val(cmnd1.ExecuteScalar) + 1
            Else
                TxtNumero_cons.Text = 1
            End If

            Dim cmnd12 As New SqlCommand
            cmnd12.CommandText = "select max(NOUVEL_INDEX_CONSOM) from CONSOMMATION where CODE_BAT=@cod"
            cmnd12.Connection = conx

            Dim param12 As New SqlParameter
            param12.ParameterName = "@cod"
            param12.SqlDbType = SqlDbType.NVarChar
            param12.Value = cmb_bat.Text
            cmnd12.Parameters.Add(param12)

            txt_ancien_index.Text = cmnd12.ExecuteScalar().ToString()
        Else
            TxtNumero_cons.Text = ""
            txt_ancien_index.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1_imprime_facture_originale.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        affiche_consommation()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        combox_consom_paie()
        affiche_consommation()
        txt_ancien_index.Text = ""
        txt_nouvel_index.Text = ""
        TxtNumero_cons.Text = ""
        cmb_bat.Text = ""
        cbx_annee_cons.Text = ""
        cbx_mois_cons.Text = ""
        dtpdebut.Value = Date.Now
        dtpfin.Value = Date.Now
    End Sub

    Private Sub BtnModifier_cons_Click(sender As Object, e As EventArgs)

    End Sub
End Class
