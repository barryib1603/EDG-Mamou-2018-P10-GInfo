Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Module Module1

    Public mp As String
    Public profil As String

    Public i1 As Integer
    Public i2 As Integer
    Public i3 As Integer
    Public itn As UInteger

    Public imoy As Double
    Public taux_des As Double
    Public max As Double
    Public tch As Double
    Public ides As Double

    Public nom_util As String
    Public compteur_message_non_lu As Integer

    Public conx As SqlConnection

    Public Sub chaine_connection()
        'conx = New SqlConnection("Data Source=(local);Initial Catalog=EDG_Mamou_G8;Integrated Security=True")
        conx = New SqlConnection("Data Source=192.168.1.1;Initial Catalog=EDG_Mamou_G8;Persist Security Info=True;User ID=EDG_G8;Password=edg_g8123")
        Try
            If conx.State = ConnectionState.Closed Then
                conx.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function ByteArray2Image(ByVal BArray As Byte()) As Image
        Try
            Dim mstImage As MemoryStream = New MemoryStream(BArray)
            Dim img As Image = Image.FromStream(mstImage)
            Return img
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Image2ByteArray(ByVal img As Image) As Byte()

        Try
            Dim mstimage As MemoryStream = New MemoryStream
            img.Save(mstimage, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim BytImage As Byte() = mstimage.GetBuffer
            Return BytImage
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing

        End Try
    End Function

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE client
    '**************************************************************************************************************'
    Public Sub affiche_client()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where STATUT_CL='Abonné'")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_client1.dgvclients.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE perssonnel
    '**************************************************************************************************************'
    Public Sub affiche_personnel()
        chaine_connection()
        Dim cmd As New SqlCommand("select MAT as Matricule,PRENOM_PERS as Prenom, NOM_PERS as Nom, NOM_SERVICE as service,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Adresse,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut  from PERSONNEL")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE Agents
    '**************************************************************************************************************'
    Public Sub affiche_agent()
        chaine_connection()
        Dim cmd As New SqlCommand("select MAT as Matricule,PRENOM_PERS as Prenom, NOM_PERS as Nom, NOM_SERVICE as service,  FONCTION_PERS as Fonction, AGE_PERS as Age,GENRE_PERS as GENRE,ADRESSE_PERS as Adresse,TEL_PERS as Telephone,NUM_BADGE_PERS AS BADGE, PHOTO AS Photo, EMAIL_PERS as EMAIL,STATUT as Statut  from PERSONNEL where FONCTION_PERS='Agent'")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.DataSource = ds
    End Sub



    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE tourne
    '**************************************************************************************************************'
    Public Sub affiche_zone()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUME_ZONE as Zone  From ZONE")
        cmd.Connection = conx
        Dim adapt = New SqlDataAdapter(cmd)
        Dim t As New DataTable
        adapt.Fill(t)
        Zone.dgvzone.DataSource = t
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE zone
    '**************************************************************************************************************'
    Public Sub affiche_toune()
        chaine_connection()
        Dim cmd As New SqlCommand("select CODE_TOURNE as Identifiants, NUM_TOURNE as Numéros, NUME_ZONE as ZONES from TOURNE")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        frmTourne.dgv_toune.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE affectation
    '**************************************************************************************************************'
    Public Sub affiche_affectation()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_AF as Numéros,MAT as Agents,NUME_ZONE as Zones,DATE_DEBUT_AF as Dates,DATE_FIN_AF as Date_fin,STATU_AFF as Statut from AFFECTATION")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_affectation1.dgv_affectation.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE rapport
    '**************************************************************************************************************'
    Public Sub affiche_rapport()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_RAP as Numéros,MAT as Personnels,LIBELLE_RAP Libellés,DESC_RAP Description,DATE_RAP as Date from RAPPORT_ADMIN")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_Rapport1.dgvrapport.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE PAIEMENT
    '**************************************************************************************************************'
    Public Sub affiche_paiement()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_PAIE as Numéros,NUM_COMSOM as CONSOMATION,NATURE_PAIE as NATURE,CODE_BAT as Bâtiments,MONTANT_PAIE as MONTANT,DATE_PAIEMENT as Date from PAIEMENT order by NUM_PAIE desc")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE batiment
    '**************************************************************************************************************'
    Public Sub affiche_batiment()
        chaine_connection()
        Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where STATUT='Abonné'")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_batiment1.DGV_batiment.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE SOLDE batiment
    '**************************************************************************************************************'
    Public Sub affiche_solde_batiment()
        chaine_connection()
        Dim cmd As New SqlCommand("select sum(SOLDE) from BATIMENT where CODE_BAT='" & Form2_menu_principal.UserControl1_batiment1.DGV_batiment.CurrentRow.Cells(0).Value.ToString & "'")
        cmd.Connection = conx
        If Not IsDBNull(cmd.ExecuteScalar) Then
            Form2_menu_principal.UserControl1_batiment1.lbl_solde_bat.Text = cmd.ExecuteScalar
        End If
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE Facture Impayé
    '**************************************************************************************************************'
    Public Sub affiche_facture_impaye()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_COMSOM as Numero,CODE_BAT as Batiment,ANCIEN_INDEX_CONSOM as [Ancien Index],NOUVEL_INDEX_CONSOM as [Nouvel Index],MONTANT_TTC as Montant from CONSOMMATION  where STATUT_CONSOM='Impayé'")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form_Facture_non_payé.dgv_facture_non_paye.DataSource = ds
    End Sub




    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE consommation
    '**************************************************************************************************************'

    Public Sub affiche_consommation()
        chaine_connection()
        Dim cmd As New SqlCommand("select [NUM_COMSOM] as [N°],[CODE_BAT] as Batiment,[MOIS_CONSOM] as Mois,[ANNEE_CONSOM] as Année,[ANCIEN_INDEX_CONSOM] as [Ancien Index (kWh)],[NOUVEL_INDEX_CONSOM] as [Nouvel Index (kWh)],[NOUVEL_INDEX_CONSOM]-[ANCIEN_INDEX_CONSOM] as [Difference  (kWh)],[DATE_DEBUT_CONSOM] as [Date de debut],[DATE_FIN_CONSOM] as [Date de fin],datediff(day,DATE_DEBUT_CONSOM,DATE_FIN_CONSOM) as [Nombres de jours],[PRIME_FIX] as [Prime fix (FGN)],[TVA_PRIME_FIX] as [TVA Prime fix (FGN)],[MONTANT_ENERGIE] as [Montant d'energie (FGN)],[TVA_ENERGIE] as [TVA Energie (FGN)],[MONTANT_TTC] as [Montant TTC (FGN)],[IMPAYE] as [Impayé(FGN)] from CONSOMMATION order by NUM_COMSOM desc")
        cmd.Connection = conx

        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_facturation1.dgv_facturation.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE categorie
    '**************************************************************************************************************'
    Public Sub affiche_categorie()
        chaine_connection()
        Dim cmd As New SqlCommand("select LIBELLE_CAT as Libéllé,TRANCHE1 as [Tranche 1],MONTANT1 as [Montant 1],TRANCHE2 as [Tranche 2],MONTANT2 as [Montant 2],TRANCHE3 as [Tranche 3],MONTANT3 as [Montant 3],PRIME_FIX as [Prime fix],POURCENT_FRANCHI as Franchissement,LIMITE_FRANCHI as [Limite de franchissement] from CATEGORIE_BATIMENT")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Categories.dgvcategorie.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE INTERVENTION
    '**************************************************************************************************************'
    Public Sub affiche_Intervention()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_INTER as NUMERO, MAT as AGENT, CODE_BAT as BATIMENT,NATURE_INTERV as NATURE, DATE_DEBUT_INTERV as DATE_DEBUT,FRAIS_INTERV as FRAIS from INTERVENTION")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_intervention1.dgvInterv.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE OPERATION
    '**************************************************************************************************************'
    Public Sub affiche_operation()
        chaine_connection()
        Dim cmd As New SqlCommand("select ID_OP as Identifiant,CODE_BAT as Batiment,NATURE_OP as Nature,MONTANT_OP as Montant,SOLDE as Solde,DATE_OP as Date from OPERATION order by DATE_OP desc")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)

        Form_Gestion_comptes.dgv_operation.DataSource = ds
    End Sub
    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE Batiment dans Statistique
    '**************************************************************************************************************'
    Public Sub aff_client_sta()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_CL as Numero,PRENOM_CL as Prénom, NOM_CL as Nom ,AGE_CL  as Age, GENRE_CL as Genre, ADRESSE_CL as Adresse, TEL_CL as Téléphone, PHOTO_CL as Photo,EMAIL_CL as EMail from CLIENT where STATUT_CL='Abonné'")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.dgvstacli.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE ACTIVITE
    '**************************************************************************************************************'
    Public Sub affiche_activite()
        chaine_connection()
        Dim cmd As New SqlCommand(" select NUM_ACT as Numéros,UTILISATEUR as Utilisateurs,DESCRIPTION_ACT as Descriptions,DATE_ACT  as Dates from ACTIVITE_UTILISATEUR order by NUM_ACT desc")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form1_activites.dgv_activite.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE prelevement
    '**************************************************************************************************************'
    Public Sub affiche_Prelevement()

        chaine_connection()
        Dim cmd As New SqlCommand
        cmd.CommandText = "select * from PRELEVEMENT"
        cmd.Connection = conx
        Dim lire As SqlDataReader
        lire = cmd.ExecuteReader
        Form2_menu_principal.UserControl1_prelevement1.dgv_prelevement.Rows.Clear()
        While lire.Read
            chaine_connection()
            Dim c1 As New SqlCommand
            c1.CommandText = "select INTENSITE_NOMI from POSTE where NUM_POSTE=@num"
            c1.Connection = conx
            Dim p1 As New SqlParameter
            p1.ParameterName = "@num"
            p1.SqlDbType = SqlDbType.NVarChar
            p1.Value = lire.GetValue(5)
            c1.Parameters.Add(p1)
            itn = Val(c1.ExecuteScalar)

            Dim c2 As New SqlCommand
            c2.CommandText = "select I1 from PRELEVEMENT where NUM_POST=@numero"
            c2.Connection = conx
            Dim p2 As New SqlParameter
            p2.ParameterName = "@numero"
            p2.SqlDbType = SqlDbType.NVarChar
            p2.Value = lire.GetValue(5)
            c2.Parameters.Add(p2)
            i1 = Val(c2.ExecuteScalar)

            Dim c3 As New SqlCommand
            c3.CommandText = "select I2 from PRELEVEMENT where NUM_POST=@numer"
            c3.Connection = conx
            Dim p3 As New SqlParameter
            p3.ParameterName = "@numer"
            p3.SqlDbType = SqlDbType.NVarChar
            p3.Value = lire.GetValue(5)
            c3.Parameters.Add(p3)
            i2 = Val(c3.ExecuteScalar)

            Dim c4 As New SqlCommand
            c4.CommandText = "select I3 from PRELEVEMENT where NUM_POST=@nume"
            c4.Connection = conx
            Dim p4 As New SqlParameter
            p4.ParameterName = "@nume"
            p4.SqlDbType = SqlDbType.NVarChar
            p4.Value = lire.GetValue(5)
            c4.Parameters.Add(p4)
            i3 = Val(c4.ExecuteScalar)

            If i1 > i2 Then
                If i1 > i3 Then
                    max = i1
                Else
                    max = i3
                End If
            ElseIf i3 > i1 Then
                If i3 > i2 Then
                    max = i3
                Else
                    max = i2
                End If
            Else
                max = i2
            End If
            imoy = (i1 + i2 + i3) / 3
            ides = (3 * max) / itn
            tch = imoy / itn
            taux_des = ides * 100


            Form2_menu_principal.UserControl1_prelevement1.dgv_prelevement.Rows.Add(lire.Item("Num_prele"), lire.Item("I0"), lire.Item("I1"), lire.Item("I2"), lire.Item("I3"), lire.Item("NUM_POST"), imoy, tch, taux_des, lire.Item("date_prelev"))

        End While
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE POSTE
    '**************************************************************************************************************'
    Public Sub affiche_poste()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_POSTE as Numéros,LIBELLE_POSTE as Libeelés,NUME_ZONE as Zones,Num_dep as Departs,PUISSNCE_NOMI as Puissaces,INTENSITE_NOMI as [Intensités nomminales],TYPE_POSTE as Types,NATURE_POSTE as Natures,LONG_MT_POSTE as [Longueurs MT],SECTION_MT_POSTE as [Sections MT],LONG_BT_POSTE as [Longueur BT],date_raccorde as [Date Raccordement] from POSTE")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE evenement
    '**************************************************************************************************************'
    Public Sub affiche_evenement()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_EV as Numero,MAT as Agent,NUM_POSTE as Poste,NUME_ZONE as Zone,LIBELLE_EV as Libelle,EVENEMENT as Evenement,DATE_DEBU_EV as Date_Debut,DATE_FIN_EV as Date_Fin from EVENEMENT")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_evenement1.dgvevenement.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE depart
    '**************************************************************************************************************'
    Public Sub affiche_depart()
        chaine_connection()
        Dim cmd As New SqlCommand("select Num_dep as Numéros,libelle_dep as Libellés from DEPART")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form1_depart.dgv_depart.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE remplacement
    '**************************************************************************************************************'
    Public Sub affiche_remplacement()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_REMP as Numéros,NUM_POSTE as Postes,NOUV_PUI as [Nouvelles puissances],DATE_REMP as Dates,ANCIEN_PUISS as [Ancienne Puisssance] from REMPLACEMENT")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_remplacement1.dgv_remplacement.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE service
    '**************************************************************************************************************'
    Public Sub affiche_service()
        chaine_connection()
        Dim cmd As New SqlCommand("select num_serv as Numéros,NOM_SERVICE as Libellés from SERVICE order by num_serv")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Service.dgv_service.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE batiment statistique
    '**************************************************************************************************************'
    Public Sub affiche_batiment_statis()
        chaine_connection()
        Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories from BATIMENT where STATUT='Abonné'")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.dgv_bat_statis.DataSource = ds
    End Sub



    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE Utilisateur
    '**************************************************************************************************************'
    Public Sub affiche_Utilisateur()
        chaine_connection()
        Dim cmd As New SqlCommand("select * from UTILISATEUR")
        cmd.Connection = conx
        Dim lect As SqlDataReader = cmd.ExecuteReader
        Form2_menu_principal.UserControl1_utilisateur2.dgv_utilisateur.Rows.Clear()
        While lect.Read
            Form2_menu_principal.UserControl1_utilisateur2.dgv_utilisateur.Rows.Add(lect.Item("NOM_UT"), lect.Item("LOGIN_UT"), lect.Item("M_PASSE_UT"), lect.Item("droit"), lect.Item("STATUT"), lect.Item("DATE_CREA"))
        End While

        'Dim da = New SqlDataAdapter(cmd)
        'Dim ds As New DataTable
        'da.Fill(ds)
        'Form2_menu_principal.UserControl1_utilisateur2.dgv_utilisateur.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE message envoyé
    '**************************************************************************************************************'
    Public Sub affiche_message_envoyé()
        chaine_connection()
        Dim cmd As New SqlCommand("select num_msg as [N°],recp_msg as [Envoyé à],entete_msg as Objet,dat_msg [date de reception] from MESSAGERIE where exp_msg like '" & nom_util & "' order by num_msg desc")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_message_envoyé1.dgvmessageEnvoye.DataSource = ds
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE message reçu
    '**************************************************************************************************************'
    Public Sub affiche_message_reçu()
        chaine_connection()
        Dim cmd As New SqlCommand("select num_msg as [N°],exp_msg as [Envoyé par],entete_msg as Objet,dat_msg as [date de reception],status_msg as Statut from MESSAGERIE where recp_msg like '" & nom_util & "' order by num_msg desc")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form2_menu_principal.UserControl1_message_réçu1.dgvmessageReçu.DataSource = ds
        conx.Close()
    End Sub

    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE Historique Connexions
    '**************************************************************************************************************'
    Public Sub affiche_historique_connexion()
        chaine_connection()
        Dim cmd As New SqlCommand("select NUM_HIST as[Numero],UTILISATEUR as Utilisateur,ACTION_H as Action,POSTE_CON as [Nom du Poste],IP_CON as [Adresse IP],DATE_ACTION as Date from HISTORIQUE_CONNEXION order by NUM_HIST desc")
        cmd.Connection = conx
        Dim da = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        Form_Historiq_connexion.DataGridView1.DataSource = ds
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE conteur message non lu
    '**************************************************************************************************************'
    Dim c As Integer = 0

    Public Sub compte_message_non_lu()
        chaine_connection()
        Dim cmd As New SqlCommand("select count(*) from MESSAGERIE where recp_msg=@recp and status_msg='non lu'")
        cmd.Connection = conx

        Dim param12 As New SqlParameter
        param12.ParameterName = "@recp"
        param12.SqlDbType = SqlDbType.NVarChar
        param12.Value = nom_util
        cmd.Parameters.Add(param12)

        compteur_message_non_lu = cmd.ExecuteScalar

        If compteur_message_non_lu <> 0 Then
            Form2_menu_principal.lbl_nbr_msg_non_lu.Visible = True
            Form2_menu_principal.lbl_nbr_msg_non_lu.Text = compteur_message_non_lu
        Else
            Form2_menu_principal.lbl_nbr_msg_non_lu.Visible = False
        End If

        If c <> compteur_message_non_lu Then
            affiche_message_reçu()
            c = compteur_message_non_lu
        End If

        Form1_statitstique.dgv_statistique.ClearSelection()
        conx.Close()
    End Sub


    '**************************************************************************************************************'
    '                               PROCEDURE AFFICHAGE statistique de vente
    '**************************************************************************************************************'

    Public nbr_bat_cat, nbr_bat_fact, nbr_cons_bat, MEV, prime_fixe, tva_prmfix, tva_mev, mttc As Integer

    Public Sub affiche_statitique()
        chaine_connection()
        Dim cmds As New SqlCommand("select LIBELLE_CAT from CATEGORIE_BATIMENT")
        cmds.Connection = conx

        Dim li As SqlDataReader = cmds.ExecuteReader

        Form1_statitstique.dgv_statistique.Rows.Clear()

        While li.Read
            chaine_connection()

            nbr_bat_cat = 0
            nbr_bat_fact = 0
            nbr_cons_bat = 0
            MEV = 0
            prime_fixe = 0

            Dim cmd As New SqlCommand("select COUNT(CODE_BAT) from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "'")
            cmd.Connection = conx
            If Not IsDBNull(cmd.ExecuteScalar) Then
                nbr_bat_cat = cmd.ExecuteScalar
            End If

            Dim cmd1 As New SqlCommand("select COUNT(NUM_COMSOM) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd1.Connection = conx
            If Not IsDBNull(cmd1.ExecuteScalar) Then
                nbr_bat_fact = cmd1.ExecuteScalar
            End If

            Dim cmd2 As New SqlCommand("select sum(NOUVEL_INDEX_CONSOM-ANCIEN_INDEX_CONSOM) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd2.Connection = conx
            If Not IsDBNull(cmd2.ExecuteScalar) Then
                nbr_cons_bat = cmd2.ExecuteScalar
            End If

            Dim cmd4 As New SqlCommand("select sum(MONTANT_PAIE) from PAIEMENT where NUM_COMSOM in(select NUM_COMSOM from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "'))")
            cmd4.Connection = conx
            If Not IsDBNull(cmd4.ExecuteScalar) Then
                MEV = cmd4.ExecuteScalar
            End If

            Dim cmd5 As New SqlCommand("select sum(PRIME_FIX) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd5.Connection = conx
            If Not IsDBNull(cmd5.ExecuteScalar) Then
                prime_fixe = cmd5.ExecuteScalar
            End If

            Dim cmd10 As New SqlCommand("select sum([MONTANT_ENERGIE]) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd10.Connection = conx
            If Not IsDBNull(cmd10.ExecuteScalar) Then
                MEV = cmd10.ExecuteScalar
            End If

            Dim cmd101 As New SqlCommand("select sum(TVA_PRIME_FIX) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd101.Connection = conx
            If Not IsDBNull(cmd101.ExecuteScalar) Then
                tva_prmfix = cmd101.ExecuteScalar
            End If

            Dim cmd11 As New SqlCommand("select sum(TVA_ENERGIE) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd11.Connection = conx
            If Not IsDBNull(cmd11.ExecuteScalar) Then
                tva_mev = cmd11.ExecuteScalar
            End If

            Dim cmd111 As New SqlCommand("select sum(MONTANT_TTC) from CONSOMMATION where CODE_BAT in(select CODE_BAT from BATIMENT where LIBELLE_CAT='" & li.GetValue(0) & "')")
            cmd111.Connection = conx
            If Not IsDBNull(cmd111.ExecuteScalar) Then
                mttc = cmd111.ExecuteScalar
            End If

            Form1_statitstique.dgv_statistique.Rows.Add(li.GetValue(0), nbr_bat_cat, nbr_bat_fact, nbr_cons_bat, MEV, prime_fixe, tva_mev, tva_prmfix, tva_mev + tva_prmfix, MEV)

        End While
        li.Close()
    End Sub
    '**************************************************************************************************************'
    '                               GESTION DES AFFICHAGE DES COMBO-BOX
    '*************************************************************************************************************

    '**************************************************************************************************************'
    '                               GESTION DES AFFICHAGE DES COMBO-BOX batiment
    '*************************************************************************************************************
    Public Sub combox_batiment_consom()
        chaine_connection()
        Dim com As New SqlCommand()
        com.CommandText = "select CODE_BAT from BATIMENT where STATUT='Abonné'"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        Form2_menu_principal.UserControl1_facturation1.cmb_bat.Items.Clear()
        While (dr.Read)
            Form2_menu_principal.UserControl1_facturation1.cmb_bat.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub


    '**************************************************************************************************************'
    '                               GESTION DES AFFICHAGE DES COMBO-BOX categorie batiment-statistique
    '*************************************************************************************************************
    Public Sub combox_stat_bat()
        chaine_connection()
        Dim com As New SqlCommand()
        com.CommandText = "select LIBELLE_CAT from CATEGORIE_BATIMENT"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        Form2_menu_principal.cbx_cat_sta.Items.Clear()
        While (dr.Read)
            Form2_menu_principal.cbx_cat_sta.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub


    Public Sub combox_consom_paie()
        chaine_connection()
        Dim com As New SqlCommand()
        com.CommandText = "select NUM_COMSOM from CONSOMMATION order by NUM_COMSOM desc"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        Form2_menu_principal.UserControl1_paiements1.txt_con_paie.Items.Clear()
        While (dr.Read)
            Form2_menu_principal.UserControl1_paiements1.txt_con_paie.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub

    Public Sub combox_hist_conex_utili()
        chaine_connection()
        Dim com As New SqlCommand()
        com.CommandText = "select NOM_UT from UTILISATEUR"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        Form_Historiq_connexion.cbx_utili.Items.Clear()
        While (dr.Read)
            Form_Historiq_connexion.cbx_utili.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub

    Public Sub combox_activte_utili()
        chaine_connection()
        Dim com As New SqlCommand()
        com.CommandText = "select NOM_UT from UTILISATEUR"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        Form1_activites.cbx_utili.Items.Clear()
        While (dr.Read)
            Form1_activites.cbx_utili.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub


    '**************************************************************************************************************'
    '                               GESTION DES DROITS
    '**************************************************************************************************************'

    Public Sub admin()

        affiche_Utilisateur()
        affiche_evenement()
        affiche_Prelevement()
        affiche_Intervention()
        affiche_consommation()
        affiche_paiement()
        affiche_rapport()
        affiche_client()
        affiche_personnel()
        affiche_batiment()
        affiche_poste()
        affiche_remplacement()

        Form2_menu_principal.Show()

    End Sub

    Public Sub caisse()
        Form2_menu_principal.UserControl1_paiements1.Show()
        Form2_menu_principal.UserControl1_client1.Hide()
        Form2_menu_principal.UserControl1_batiment1.Hide()
        Form2_menu_principal.UserControl1_paiements1.Hide()


        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_securite)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_facturation)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_DT)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_Personnel)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_statistique)



        Form2_menu_principal.btn_batiment.Visible = False
        Form2_menu_principal.Btn_categorie.Visible = False
        Form2_menu_principal.Btn_client.Visible = False



        affiche_paiement()
        affiche_client()
        affiche_batiment()
        Form2_menu_principal.ShowDialog()

    End Sub

    Public Sub litige()

        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_securite)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_facturation)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_DT)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_Personnel)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_statistique)

        Categories.GroupBox3.Enabled = False
        Categories.Button1.Enabled = False
        Categories.Button3.Enabled = False
        Categories.Button4.Enabled = False
        Categories.Button5.Enabled = False
        Categories.dgvcategorie.Enabled = False

        Form2_menu_principal.UserControl1_client1.Show()
        Form2_menu_principal.UserControl1_batiment1.Hide()
        Form2_menu_principal.UserControl1_paiements1.Hide()

        Form2_menu_principal.UserControl1_paiements1.btn_ajout_paiement.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.btn_imprime_paiement.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.btn_reçu.Enabled = False

        Form2_menu_principal.UserControl1_client1.Button7.Enabled = False
        Form2_menu_principal.UserControl1_client1.Button8.Enabled = False
        Form2_menu_principal.UserControl1_client1.Button9.Enabled = False

        Form2_menu_principal.UserControl1_batiment1.Button7.Enabled = False
        Form2_menu_principal.UserControl1_batiment1.Button8.Enabled = False
        Form2_menu_principal.UserControl1_batiment1.Button9.Enabled = False

        affiche_paiement()
        affiche_client()
        affiche_batiment()

        Form2_menu_principal.ShowDialog()

    End Sub

    Public Sub division_com()

        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_securite)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_facturation)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_DT)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_Personnel)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_statistique)

        Form2_menu_principal.btn_batiment.Visible = True
        Form2_menu_principal.Btn_client.Visible = True
        Form2_menu_principal.Btn_categorie.Visible = True
        Form2_menu_principal.btn_paiement.Visible = True

        Form2_menu_principal.UserControl1_paiements1.btn_ajout_paiement.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.btn_imprime_paiement.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.btn_reçu.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.txt_mont_paie.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.txt_num_paie.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.txt_con_paie.Enabled = False
        Form2_menu_principal.UserControl1_paiements1.cb_nat_paie.Enabled = False

        Form2_menu_principal.UserControl1_client1.Hide()
        Form2_menu_principal.UserControl1_paiements1.Show()
        Form2_menu_principal.UserControl1_batiment1.Hide()

        affiche_paiement()
        affiche_client()
        affiche_batiment()

        Form2_menu_principal.ShowDialog()

    End Sub

    Public Sub facturation()
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_dc)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_DT)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_securite)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_Personnel)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_statistique)

        affiche_consommation()

        Form2_menu_principal.ShowDialog()
    End Sub

    Public Sub division_tech()
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_dc)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_facturation)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_securite)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_Personnel)
        Form2_menu_principal.TabControl1_menu.TabPages.Remove(Form2_menu_principal.TabPage_statistique)

        Form2_menu_principal.Usercontroler2_personnel1.Button2.Visible = False
        Form2_menu_principal.Usercontroler2_personnel1.Button3.Visible = False
        Form2_menu_principal.Usercontroler2_personnel1.Button7.Visible = False
        Form2_menu_principal.Usercontroler2_personnel1.Button8.Visible = False
        Form2_menu_principal.Usercontroler2_personnel1.Button9.Visible = False

        Form2_menu_principal.UserControl1_intervention1.Show()
        Form2_menu_principal.UserControl1_poste1.Hide()
        Form2_menu_principal.UserControl1_prelevement1.Hide()
        Form2_menu_principal.UserControl1_affectation1.Hide()
        Form2_menu_principal.UserControl1_poste1.Hide()
        Form2_menu_principal.UserControl1_evenement1.Hide()
        Form2_menu_principal.UserControl1_remplacement1.Hide()
        Form2_menu_principal.UserControl1_Rapport1.Hide()

        affiche_evenement()
        affiche_Prelevement()
        affiche_Intervention()
        affiche_rapport()
        affiche_agent()
        affiche_batiment()
        affiche_poste()
        affiche_remplacement()

        Form2_menu_principal.ShowDialog()

    End Sub

End Module
