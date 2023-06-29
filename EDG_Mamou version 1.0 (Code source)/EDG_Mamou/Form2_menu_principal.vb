
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net

Public Class Form2_menu_principal

    Private Sub Form2_menu_principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        chaine_connection()
        Dim CMD_CON As New SqlCommand
        CMD_CON.CommandText = "insert into HISTORIQUE_CONNEXION(UTILISATEUR,ACTION_H,DATE_ACTION) values('" & nom_util & "','DECONNEXION','" & Date.Now & "')"
        CMD_CON.Connection = conx
        CMD_CON.ExecuteNonQuery()

        conx.Close()
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserControl1_message_réçu1.Timer1.Stop()
        Me.Timer1.Stop()
        Form_Historiq_connexion.Timer1.Stop()
        Me.Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub Form2_menu_principal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form2_connexion.Hide()
    End Sub

    Private Sub Form2_menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aff_client_sta()
        combox_stat_bat()
        affiche_batiment_statis()

        lblmessage.Text = "MESSAGERIE"
        lbl_droit_an.Text = Year(Date.UtcNow)
        compte_message_non_lu()
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

        UserControl1_poste1.cmb_rechercher.SelectedItem = "Numero"

        UserControl1_client1.Show()
        UserControl1_batiment1.Hide()
        UserControl1_paiements1.Hide()

        UserControl1_intervention1.Show()
        UserControl1_prelevement1.Hide()
        UserControl1_affectation1.Hide()
        UserControl1_poste1.Hide()
        UserControl1_evenement1.Hide()
        UserControl1_Rapport1.Hide()
        UserControl1_remplacement1.Hide()

        UserControl1_message_réçu1.Show()
        UserControl1_nouveau_message1.Hide()
        UserControl1_message_envoyé1.Hide()
        UserControl1_lire_message1.Hide()

        Dim poste As String = Dns.GetHostName
        Dim ipV6ipV4 As IPHostEntry = Dns.GetHostEntry(poste)
        Dim ipad As String = ipV6ipV4.HostName
        Dim ipV4 As IPAddress() = ipV6ipV4.AddressList
        'ipV4 est un tableau a une dimension dont ipV4(0) contient ipv6 et ipV4(1) ipV4
        Dim ip_address As String = ipV4(1).ToString

        Dim CMD_CON As New SqlCommand
        CMD_CON.CommandText = "insert into HISTORIQUE_CONNEXION(UTILISATEUR,ACTION_H,DATE_ACTION,POSTE_CON,IP_CON) values('" & nom_util & "','CONNEXION','" & Date.Now & "','" & poste & "','" & ip_address & "')"
        CMD_CON.Connection = conx
        CMD_CON.ExecuteNonQuery()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lb_titre_msg.Text = "Nouveau message"
        UserControl1_nouveau_message1.Show()
        UserControl1_message_envoyé1.Hide()
        UserControl1_message_réçu1.Hide()
        UserControl1_lire_message1.Hide()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        lb_titre_msg.Text = "Messages reçus"
        UserControl1_message_réçu1.Show()
        UserControl1_nouveau_message1.Hide()
        UserControl1_message_envoyé1.Hide()
        UserControl1_lire_message1.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        lb_titre_msg.Text = "Messages envoyés"
        UserControl1_message_envoyé1.Show()
        UserControl1_message_réçu1.Hide()
        UserControl1_nouveau_message1.Hide()
        UserControl1_lire_message1.Hide()

    End Sub

    Private Sub Btn_client_Click(sender As Object, e As EventArgs) Handles Btn_client.Click
        UserControl1_client1.Show()
        lbl_titre_div_com.Text = "Gestion des Clients"
        UserControl1_batiment1.Hide()
        UserControl1_paiements1.Hide()
    End Sub

    Private Sub btn_batiment_Click(sender As Object, e As EventArgs)
        UserControl1_batiment1.Show()
        lbl_titre_div_com.Text = "Gestion des Batiments"
        UserControl1_client1.Hide()
        UserControl1_paiements1.Hide()
    End Sub


    Private Sub btn_paiement_Click(sender As Object, e As EventArgs) Handles btn_paiement.Click
        UserControl1_paiements1.Show()
        lbl_titre_div_com.Text = "Gestion des Paiements"
        UserControl1_batiment1.Hide()
        UserControl1_client1.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Personnel.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Personnel.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        MsgBox("Voulez-vous vraiment effectuer cette suppression ?", MsgBoxStyle.YesNo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Categories.ShowDialog()
    End Sub

    Private Sub btn_batiment_Click_1(sender As Object, e As EventArgs) Handles btn_batiment.Click
        UserControl1_batiment1.Show()
        lbl_titre_div_com.Text = "Gestion des Batiments"
        UserControl1_paiements1.Hide()
        UserControl1_client1.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_categorie.Click
        Categories.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lbl_titre_div_techn.Text = "Interventions des Agents"
        UserControl1_intervention1.Show()
        UserControl1_prelevement1.Hide()
        UserControl1_affectation1.Hide()
        UserControl1_poste1.Hide()
        UserControl1_evenement1.Hide()
        UserControl1_Rapport1.Hide()
        UserControl1_remplacement1.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        lbl_titre_div_techn.Text = "Mesures de charges des Postes"
        UserControl1_prelevement1.Show()
        UserControl1_intervention1.Hide()
        UserControl1_affectation1.Hide()
        UserControl1_poste1.Hide()
        UserControl1_evenement1.Hide()
        UserControl1_Rapport1.Hide()
        UserControl1_remplacement1.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        lbl_titre_div_techn.Text = "Affectation des Agents dans les Zones"
        UserControl1_affectation1.Show()
        UserControl1_intervention1.Hide()
        UserControl1_prelevement1.Hide()
        UserControl1_poste1.Hide()
        UserControl1_evenement1.Hide()
        UserControl1_Rapport1.Hide()
        UserControl1_remplacement1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmTourne.ShowDialog()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Service.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbl_titre_div_techn.Text = "Gestion des Postes"
        UserControl1_poste1.Show()
        UserControl1_affectation1.Hide()
        UserControl1_intervention1.Hide()
        UserControl1_prelevement1.Hide()
        UserControl1_evenement1.Hide()
        UserControl1_Rapport1.Hide()
        UserControl1_remplacement1.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        frmTourne.Show()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Zone.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Form1_depart.ShowDialog()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form1_profil.ShowDialog()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        lbl_titre_div_techn.Text = "Gestion des evenements"
        UserControl1_evenement1.Show()
        UserControl1_intervention1.Hide()
        UserControl1_prelevement1.Hide()
        UserControl1_affectation1.Hide()
        UserControl1_poste1.Hide()
        UserControl1_Rapport1.Hide()
        UserControl1_remplacement1.Hide()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        lbl_titre_div_techn.Text = "Gestion des Rapports"
        UserControl1_Rapport1.Show()
        UserControl1_evenement1.Hide()
        UserControl1_intervention1.Hide()
        UserControl1_prelevement1.Hide()
        UserControl1_affectation1.Hide()
        UserControl1_poste1.Hide()
        UserControl1_remplacement1.Hide()
    End Sub



    Private Sub bbtn_Remplace_Click(sender As Object, e As EventArgs) Handles bbtn_Remplace.Click
        lbl_titre_div_techn.Text = "Gestion des Remplacements"
        UserControl1_remplacement1.Show()
        UserControl1_Rapport1.Hide()
        UserControl1_evenement1.Hide()
        UserControl1_intervention1.Hide()
        UserControl1_prelevement1.Hide()
        UserControl1_affectation1.Hide()
        UserControl1_poste1.Hide()
    End Sub

    Dim sta As String
    Dim cmpt_hist, nbr_his, cmpt_act, nbr_act As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        chaine_connection()
        Dim cy As New SqlCommand
        cy.CommandText = "select STATUT from UTILISATEUR where NOM_UT='" & nom_util & "'"
        cy.Connection = conx
        sta = cy.ExecuteScalar().ToString()
        If sta = "Desactivé" Then
            Me.Close()
            MessageBox.Show("Votre compte a été desactivé, veuillez contacter l'administrateur de cette application !")
            Form2_connexion.Show()
        End If

        Dim cmd As New SqlCommand("select count(*) from HISTORIQUE_CONNEXION")
        cmd.Connection = conx
        cmpt_hist = cmd.ExecuteScalar
        If nbr_his <> cmpt_hist Then
            affiche_historique_connexion()
            nbr_his = cmpt_hist
        End If

        Dim cmds As New SqlCommand("select count(*) from ACTIVITE_UTILISATEUR")
        cmds.Connection = conx
        cmpt_act = cmd.ExecuteScalar
        If nbr_act <> cmpt_act Then
            affiche_activite()
            nbr_act = cmpt_act
        End If

        conx.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Facture_non_payé.ShowDialog()
    End Sub

    Private Sub btnstatgenre_Click(sender As Object, e As EventArgs) Handles btnstatgenre.Click
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "select COUNT(NUM_CL) from CLIENT where GENRE_CL=@genre and STATUT_CL='Abonné'"
        c.Connection = conx
        Dim pa As New SqlParameter
        pa.ParameterName = "@genre"
        pa.SqlDbType = SqlDbType.NVarChar
        pa.Value = cbxgenresta.Text
        c.Parameters.Add(pa)

        Dim som As Integer = c.ExecuteScalar
        lblsommegenre.Text = som
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        chaine_connection()
        Dim cmd As New SqlCommand
        cmd.CommandText = "select COUNT(NUM_CL) from CLIENT WHERE STATUT_CL='Abonné'"
        cmd.Connection = conx
        lblsomtotal.Text = cmd.ExecuteScalar
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        chaine_connection()
        If cbxanne_sta_paie.SelectedItem = True And cbxmois_sta_paie.SelectedItem = True Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select SUM(MONTANT_PAIE) from PAIEMENT where MONTH(DATE_PAIEMENT)='" & cbxmois_sta_paie.SelectedItem & "' and YEAR(DATE_PAIEMENT)='" & Val(cbxanne_sta_paie.SelectedItem) & "'"
            cmd.Connection = conx
            If IsDBNull(cmd.ExecuteScalar) Then
                MessageBox.Show("Aucun Paiement pour la Periode Selectionnée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                chaine_connection()
                lblsompaiement.Text = cmd.ExecuteScalar
            End If
        ElseIf cbxanne_sta_paie.Text <> "" And cbxmois_sta_paie.Text = "" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select SUM(MONTANT_PAIE) from PAIEMENT where YEAR(DATE_PAIEMENT)='" & Val(cbxanne_sta_paie.SelectedItem) & "'"
            cmd.Connection = conx
            If IsDBNull(cmd.ExecuteScalar) Then
                MessageBox.Show("Aucun Paiement pour la Periode Selectionnée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                chaine_connection()
                lblsompaiement.Text = cmd.ExecuteScalar
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If cbxannee_kwh_sta.Text <> "" And cbxmois_kwh_sta.Text <> "" Then
            chaine_connection()

            Dim cmd As New SqlCommand
            cmd.CommandText = "select SUM(NOUVEL_INDEX_CONSOM) from CONSOMMATION where MOIS_CONSOM='" & cbxmois_kwh_sta.Text & "' and ANNEE_CONSOM='" & cbxannee_kwh_sta.Text & "'"
            cmd.Connection = conx

            Dim c As New SqlCommand
            c.CommandText = "select SUM(ANCIEN_INDEX_CONSOM) from CONSOMMATION where MOIS_CONSOM='" & cbxmois_kwh_sta.Text & "' and ANNEE_CONSOM='" & cbxannee_kwh_sta.Text & "'"
            c.Connection = conx
            If IsDBNull(c.ExecuteScalar) Then
                MessageBox.Show("Aucune Consommation pour la Periode Selectionnée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                chaine_connection()
                lblsom_kwh_sta.Text = cmd.ExecuteScalar - c.ExecuteScalar
            End If
        ElseIf cbxannee_kwh_sta.Text <> "" And cbxmois_kwh_sta.Text = "" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select SUM(NOUVEL_INDEX_CONSOM) from CONSOMMATION where ANNEE_CONSOM='" & cbxannee_kwh_sta.Text & "'"
            cmd.Connection = conx

            Dim c As New SqlCommand
            c.CommandText = "select SUM(ANCIEN_INDEX_CONSOM) from CONSOMMATION where ANNEE_CONSOM='" & cbxannee_kwh_sta.Text & "'"
            c.Connection = conx
            lblsom_kwh_sta.Text = cmd.ExecuteScalar - c.ExecuteScalar
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        affiche_statitique()
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Consultation des Historiques de vente','" & Date.Now & "')"
        c.Connection = conx
        c.ExecuteNonQuery()

        Form1_statitstique.ShowDialog()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If cbx_cat_sta.Text <> "" Then
            chaine_connection()
            Dim cmd As New SqlCommand
            cmd.CommandText = "select COUNT(CODE_BAT) from BATIMENT where LIBELLE_CAT='" & cbx_cat_sta.Text & "' and STATUT='Abonné'"
            cmd.Connection = conx
            If IsDBNull(cmd.ExecuteScalar) Then
                MessageBox.Show("Aucun Batiment pour Cette Categorie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                chaine_connection()
                lblsomcatbat.Text = cmd.ExecuteScalar
            End If
        Else
            MessageBox.Show("Veuillez selectionner une Categorie SVP ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "select COUNT(CODE_BAT) from BATIMENT where STATUT='Abonné'"
        c.Connection = conx
        lblsomstabat.Text = c.ExecuteScalar
    End Sub

    Private Sub TabPage_statistique_Click(sender As Object, e As EventArgs) Handles TabPage_statistique.Click
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Consutation des statistiques','" & Date.Now & "')"
        c.Connection = conx
        c.ExecuteNonQuery()
    End Sub
End Class