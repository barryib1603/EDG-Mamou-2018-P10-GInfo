Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class UserControl1_batiment

    Private Sub UserControl1_des_clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_rechercher.SelectedItem = "Code"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmBatiments.Label15.Text = "Ajout d'un bâtiment"
        frmBatiments.btnModifier.Visible = False
        frmBatiments.lblajout.Visible = True
        frmBatiments.lblannuler.Visible = True
        frmBatiments.btnEnregistrer.Visible = True
        frmBatiments.btnQuitter.Visible = True
        frmBatiments.lblmodifier.Visible = False
      

        frmBatiments.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If lblcode_bat.Text <> "" Then
            frmBatiments.Label15.Text = "Modification du bâtiment"
            frmBatiments.txtCode_batiment.Text = lblcode_bat.Text
            frmBatiments.cmb_client_bat.Text = lblclient_bat.Text
            frmBatiments.cmbCategorie_batiment.Text = lbtcat_bat.Text
            frmBatiments.cmbTypeBat_batiment.Text = lbltype_batiment_bat.Text
            frmBatiments.cmbTypeTension_batiment.Text = lbltype_tension_bat.Text
            frmBatiments.cmbnature_branche_batiment.Text = lblnat_branche_bat.Text
            frmBatiments.cmb_agent_branch.Text = lblagent_bat.Text
            frmBatiments.txtAmperage_batiment.Text = lblamp_dijon_bat.Text
            frmBatiments.txtFraiPayer_batiment.Text = lblfrais_paye_bat.Text
            frmBatiments.txtPuissance_batiment.Text = lblpuissance_bat.Text
            frmBatiments.dt_date_brach.Text = lbldate_branche_bat.Text
            frmBatiments.txt_id_bat.Text = DGV_batiment.CurrentRow.Cells(11).Value.ToString
            frmBatiments.cmbTournee.Text = DGV_batiment.CurrentRow.Cells(12).Value.ToString

            frmBatiments.btnEnregistrer.Visible = False
            frmBatiments.btnModifier.Visible = True
            frmBatiments.btnQuitter.Visible = False
            frmBatiments.lblmodifier.Visible = True
            frmBatiments.lblannuler.Visible = False
            frmBatiments.lblajout.Visible = False

            frmBatiments.ShowDialog()
        Else
            MessageBox.Show("Vous n'avez selectionné aucun element à modifier")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If lblcode_bat.Text <> "" Then
            If DGV_batiment.CurrentRow.Cells(0).Value.ToString <> "" Then
                Dim confirmation As DialogResult = MsgBox("Voulez-vous vraiment desabonner ce batiment ?", MsgBoxStyle.YesNo)
                If confirmation = DialogResult.Yes Then
                    Try
                        Dim client As String = DGV_batiment.CurrentRow.Cells(1).Value.ToString

                        chaine_connection()

                        Dim cmd As New SqlCommand("UPDATE BATIMENT SET STATUT='Desabonné' where CODE_BAT=@CODE")
                        cmd.Connection = conx

                        Dim param As New SqlParameter
                        param.ParameterName = "@CODE"
                        param.SqlDbType = SqlDbType.NVarChar
                        param.Value = DGV_batiment.CurrentRow.Cells(0).Value.ToString
                        cmd.Parameters.Add(param)

                        cmd.ExecuteNonQuery()

                        Dim c As New SqlCommand
                        c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Desabonnement du batiment N° " & DGV_batiment.CurrentRow.Cells(0).Value.ToString & "','" & Date.Now & "')"
                        c.Connection = conx
                        c.ExecuteNonQuery()

                        MessageBox.Show("DESABONNEMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call chaine_connection()


                        Dim cmd0 As New SqlCommand("select * from BATIMENT where(NUM_CL=@txtnum_cl) and STATUT='Abonné'")
                        cmd0.Connection = conx

                        Dim param0 As New SqlParameter
                        param0.ParameterName = "@txtnum_cl"
                        param0.SqlDbType = SqlDbType.NVarChar
                        param0.Value = client
                        cmd0.Parameters.Add(param0)

                        Dim lire As SqlDataReader = cmd0.ExecuteReader

                        If Not (lire.Read) Then
                            Dim conf As DialogResult = MessageBox.Show("C'est le seul Batiment de ce Client, Voulez vous le desabonner de Même?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            If confirmation = DialogResult.Yes Then
                                Dim com As New SqlCommand
                                com.CommandText = "Update CLIENT set STATUT_CL='Desabonné' where NUM_CL='" & client & "'"
                                com.Connection = conx
                                com.ExecuteNonQuery()
                                affiche_client()

                                Dim c1 As New SqlCommand
                                c1.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Desabonnement du client N° " & lblclient_bat.Text & "','" & Date.Now & "')"
                                c1.Connection = conx
                                c1.ExecuteNonQuery()
                                MessageBox.Show("DESABONNEMENT EFFECTUE AVEC SUCCES", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End If
                            lire.Close()
                            Exit Sub
                        End If

                        'procedure affichage client
                        affiche_client()
                        affiche_batiment()
                        combox_batiment_consom()

                        lire.Close()
                        lblagent_bat.Text = ""
                        lblamp_dijon_bat.Text = ""
                        lblclient_bat.Text = ""
                        lblcode_bat.Text = ""
                        lbldate_branche_bat.Text = ""
                        lblfrais_paye_bat.Text = ""
                        lblnat_branche_bat.Text = ""
                        lblpuissance_bat.Text = ""
                        lbltype_batiment_bat.Text = ""
                        lbltype_tension_bat.Text = ""


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If
            End If
        End If
        'If DGV_batiment.CurrentRow.Cells(0).Value.ToString <> "" Then
        '    Dim confirmation As DialogResult = MsgBox("Voulez-vous vraiment effectuer cette suppression ?", MsgBoxStyle.YesNo)
        '    If confirmation = DialogResult.Yes Then
        '        Dim cmd As New SqlCommand
        '        cmd.CommandText = "delete from BATIMENT where(CODE_BAT=@code)"
        '        cmd.Connection = conx

        '        Dim param As New SqlParameter
        '        param.ParameterName = "@code"
        '        param.SqlDbType = SqlDbType.NVarChar
        '        param.Value = DGV_batiment.CurrentRow.Cells(0).Value.ToString
        '        cmd.Parameters.Add(param)

        '        lblcode_bat.Text = ""
        '        lblclient_bat.Text = ""
        '        lbtcat_bat.Text = ""
        '        lbltype_batiment_bat.Text = ""
        '        lbltype_tension_bat.Text = ""
        '        lblnat_branche_bat.Text = ""
        '        lblagent_bat.Text = ""
        '        lblamp_dijon_bat.Text = ""
        '        lblfrais_paye_bat.Text = ""
        '        lblpuissance_bat.Text = ""
        '        lbldate_branche_bat.Text = ""

        '        cmd.ExecuteNonQuery()
        '        affiche_batiment()

        '    End If
        'Else
        '    MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
        'End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles lblagent_bat.Click

    End Sub

    Private Sub DGV_batiment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_batiment.CellClick
        If DGV_batiment.CurrentRow.Cells(0).Value.ToString <> "" Then

            lblcode_bat.Text = DGV_batiment.CurrentRow.Cells(0).Value.ToString
            lblclient_bat.Text = DGV_batiment.CurrentRow.Cells(1).Value.ToString
            lbtcat_bat.Text = DGV_batiment.CurrentRow.Cells(2).Value.ToString
            lblagent_bat.Text = DGV_batiment.CurrentRow.Cells(3).Value.ToString
            lblnat_branche_bat.Text = DGV_batiment.CurrentRow.Cells(4).Value.ToString
            lbldate_branche_bat.Text = DGV_batiment.CurrentRow.Cells(6).Value.ToString
            lblfrais_paye_bat.Text = DGV_batiment.CurrentRow.Cells(5).Value.ToString
            lblamp_dijon_bat.Text = DGV_batiment.CurrentRow.Cells(7).Value.ToString
            lblpuissance_bat.Text = DGV_batiment.CurrentRow.Cells(8).Value.ToString
            lbltype_batiment_bat.Text = DGV_batiment.CurrentRow.Cells(9).Value.ToString
            lbltype_tension_bat.Text = DGV_batiment.CurrentRow.Cells(11).Value.ToString
           
            Dim cmd As New SqlCommand("select NUM_PAIE as Numéros,NUM_COMSOM as CONSOMATION,NATURE_PAIE NATURE,MONTANT_PAIE MONTANT,DATE_PAIEMENT as Date from PAIEMENT where NUM_COMSOM IN (select NUM_COMSOM From CONSOMMATION where CODE_BAT like '" & DGV_batiment.CurrentRow.Cells(0).Value.ToString & "')")
            cmd.Connection = conx
            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            dgvPaiementBat.DataSource = ds

            Dim cmdev As New SqlCommand("select NUM_INTER as NUMERO, MAT as AGENT,NATURE_INTERV as NATURE, DATE_DEBUT_INTERV as DATE_DEBUT,FRAIS_INTERV as FRAIS from INTERVENTION where CODE_BAT like '" & DGV_batiment.CurrentRow.Cells(0).Value.ToString & "'")
            cmdev.Connection = conx
            Dim dat = New SqlDataAdapter(cmdev)
            Dim dst As New DataTable
            dat.Fill(dst)
            dgvIntervenBat.DataSource = dst

            Dim cmnd As New SqlCommand("select NUM_COMSOM as NUMERO, NOUVEL_INDEX_CONSOM as [ Nouvel index consommation],ANCIEN_INDEX_CONSOM as [Ancien index consommation],MOIS_CONSOM as MOIS, ANNEE_CONSOM as ANNEE,DATE_DEBUT_CONSOM as [Debut de consommation],DATE_FIN_CONSOM as [Fin de Consommation] from CONSOMMATION where CODE_BAT like '" & DGV_batiment.CurrentRow.Cells(0).Value.ToString & "'")
            cmnd.Connection = conx
            Dim dt = New SqlDataAdapter(cmnd)
            Dim dset As New DataTable
            dt.Fill(dset)
            dgv_consom_batim.DataSource = dset

            chaine_connection()
            Dim c As New SqlCommand("select ID_OP as Identifiant,CODE_BAT as Batiment,NATURE_OP as Nature,MONTANT_OP as Montant,SOLDE as Solde,DATE_OP as Date from OPERATION where CODE_BAT='" & DGV_batiment.CurrentRow.Cells(0).Value & "' order by DATE_OP desc")
            c.Connection = conx
            Dim datt = New SqlDataAdapter(c)
            Dim dstt As New DataTable
            datt.Fill(dstt)
            Form2_menu_principal.UserControl1_batiment1.dgv_compte.DataSource = dstt
            'Dim cmdcpt As New SqlCommand
            ''cmdcpt.CommandText = "select * from PAIEMENT where NUM_PAIE in(select NUM_COMSOM from CONSOMMATION where CODE_BAT=@bat)"
            'cmdcpt.CommandText = "select * from PAIEMENT"
            'cmdcpt.Connection = conx
            'Dim par As New SqlParameter
            'par.ParameterName = "@bat"
            'par.SqlDbType = SqlDbType.NVarChar
            'cmd.Parameters.Add(par)

            'Dim l As SqlDataReader
            'l = cmdcpt.ExecuteReader
            'Dim rcp As Integer
            'Dim r As Integer

            'Try
            '    Do
            '        Dim cm As New SqlCommand
            '        cm.CommandText = "select MONTANT_TTC_CONSOM from CONSOMMATION where NUM_COMSOM=@num_c"
            '        cm.Connection = conx

            '        Dim parm As New SqlParameter
            '        parm.ParameterName = "@num_c"
            '        parm.SqlDbType = SqlDbType.NVarChar
            '        parm.Value = l.GetValue(3)
            '        cmd.Parameters.Add(parm)

            '        rcp = cm.ExecuteScalar

            '        Dim c As New SqlCommand
            '        c.CommandText = "select MONTANT_PAIE from PAIEMENT where NUM_PAIE=@n"
            '        Dim p As New SqlParameter
            '        p.ParameterName = "@n"
            '        p.SqlDbType = SqlDbType.NVarChar
            '        p.Value = l.GetValue(0)
            '        c.Parameters.Add(p)

            '        r = c.ExecuteScalar

            '        Form2_menu_principal.UserControl1_batiment1.dgv_compte.Rows.Add(rcp, r, rcp - r, l.Item("DATE_PAIEMENT"))

            '    Loop While l.NextResult

            '    l.Close()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try


            'Dim cmdcp As New SqlCommand
            'cmdcp.CommandText = "select NUM_PAIE from PAIEMENT where NUM_COMSOM IN (select NUM_COMSOM From CONSOMMATION where CODE_BAT like '" & DGV_batiment.CurrentRow.Cells(0).Value.ToString & "')"
            'cmdcp.Connection = conx

            'Dim lec As SqlDataReader
            'lec = cmdcp.ExecuteReader
            'Dim num_p As Integer
            'Dim mtp As Integer
            'Dim mtap As Integer
            'Dim cons As Integer
            'Dim date_p As Date
            'Try
            '    While lec.Read
            '        num_p = cmdcp.ExecuteScalar()


            '        Dim c As New SqlCommand
            '        c.CommandText = "select MONTANT_PAIE from PAIEMENT where NUM_PAIE=@n"
            '        c.Connection = conx

            '        Dim p As New SqlParameter
            '        p.ParameterName = "@n"
            '        p.SqlDbType = SqlDbType.Int
            '        p.Value = num_p
            '        c.Parameters.Add(p)

            '        mtp = c.ExecuteScalar

            '        Dim cx As New SqlCommand
            '        cx.CommandText = "select DATE_PAIEMENT from PAIEMENT where NUM_PAIE=@date"
            '        cx.Connection = conx

            '        Dim px As New SqlParameter
            '        px.ParameterName = "@date"
            '        px.SqlDbType = SqlDbType.Date
            '        px.Value = num_p
            '        cx.Parameters.Add(px)

            '        date_p = cx.ExecuteScalar

            '        Dim cs As New SqlCommand
            '        cs.CommandText = "select NUM_COMSOM from PAIEMENT where NUM_PAIE=@nu"
            '        cs.Connection = conx

            '        Dim ps As New SqlParameter
            '        ps.ParameterName = "@nu"
            '        ps.SqlDbType = SqlDbType.Int
            '        ps.Value = num_p
            '        cs.Parameters.Add(ps)

            '        cons = cs.ExecuteScalar

            '        Dim cm As New SqlCommand
            '        cm.CommandText = "select MONTANT_TTC_CONSOM from CONSOMMATION where NUM_COMSOM=@num_c"
            '        cm.Connection = conx

            '        Dim par As New SqlParameter
            '        par.ParameterName = "@num_c"
            '        par.SqlDbType = SqlDbType.NVarChar
            '        par.Value = cons
            '        cmd.Parameters.Add(par)

            '        mtap = cm.ExecuteScalar


            '        Form2_menu_principal.UserControl1_batiment1.dgv_compte.Rows.Add(mtap, mtp, mtap - mtp, date_p)

            '    End While

            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try

            'lec.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Code" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where CODE_BAT=@NUM and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_bat.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Ce batiment n'existe pas")

            End If
            lire.Close()
        End If
        If cmb_rechercher.SelectedItem = "Client" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_CL=@NUM and STATUT='Abonné'")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txt_recherche_bat.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment pour ce client")
            End If

            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Catégorie" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where LIBELLE_CAT=@NOM and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NOM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_entrez_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment de cette categorie")

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Type de tension" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where TYPE_TENSION=@NUM and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_entrez_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment pour ce type tension")
            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Type de Batiment" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where TYPE_BAT=@NUM and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_entrez_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment pour ce type")
            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Tournée" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_TOURNE=@NUM and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_entrez_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment pour cette tournée")
            End If
            lire.Close()
        End If


        If cmb_rechercher.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_TOURNE in (select CODE_TOURNE from TOURNE where NUME_ZONE=@NUM) and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.Int
            param.Value = Val(cmb_entrez_recherche.Text)
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment dans cette zone")
            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Agent qui a branché" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where MAT=@NUM and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_entrez_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Il n'y a pas de batiment pour ce type")
            End If
            lire.Close()
        End If

    End Sub

    Private Sub txt_recherche_bat_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche_bat.TextChanged
        chaine_connection()

        If cmb_rechercher.SelectedItem = "Code" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where CODE_BAT like '%" & txt_recherche_bat.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
            lire.Close()
        End If
        If cmb_rechercher.SelectedItem = "Client" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_CL like '%" & txt_recherche_bat.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

    End Sub

    Private Sub cmb_rechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_rechercher.SelectedIndexChanged

        If cmb_rechercher.SelectedItem = "Code" Or cmb_rechercher.SelectedItem = "Client" Or cmb_rechercher.SelectedItem = "" Then
            chaine_connection()
            cmb_entrez_recherche.Visible = False
            txt_recherche_bat.Visible = True

        End If

        If cmb_rechercher.SelectedItem = "Date de branchement" Then

            cmb_entrez_recherche.Visible = False
            txt_recherche_bat.Visible = False
        End If

        If cmb_rechercher.SelectedItem = "Catégorie" Then
            chaine_connection()
            Dim com As New SqlCommand()
            com.CommandText = "select LIBELLE_CAT from CATEGORIE_BATIMENT"
            com.CommandType = CommandType.Text
            com.Connection = conx
            Dim dr As SqlDataReader = com.ExecuteReader
            cmb_entrez_recherche.Items.Clear()
            While (dr.Read)
                cmb_entrez_recherche.Items.Add(dr.Item(0))
            End While
            dr.Close()

            cmb_entrez_recherche.Visible = True
            txt_recherche_bat.Visible = False
        End If

        If cmb_rechercher.SelectedItem = "Type de tension" Then

            cmb_entrez_recherche.Items.Clear()

            cmb_entrez_recherche.Items.Add("BT")
            cmb_entrez_recherche.Items.Add("MT")
            cmb_entrez_recherche.Items.Add("HT")

            cmb_entrez_recherche.Visible = True
            txt_recherche_bat.Visible = False
        End If

        If cmb_rechercher.SelectedItem = "Type de Batiment" Then
            chaine_connection()
            cmb_entrez_recherche.Items.Clear()

            cmb_entrez_recherche.Items.Add("Non forfetaire")
            cmb_entrez_recherche.Items.Add("Forfetaire")

            cmb_entrez_recherche.Visible = True
            txt_recherche_bat.Visible = False
        End If

        If cmb_rechercher.SelectedItem = "Zone" Then
            chaine_connection()
            Dim cm As New SqlCommand()
            cm.CommandText = "select NUME_ZONE from ZONE"
            cm.CommandType = CommandType.Text
            cm.Connection = conx
            Dim dt As SqlDataReader = cm.ExecuteReader
            cmb_entrez_recherche.Items.Clear()
            While (dt.Read)
                cmb_entrez_recherche.Items.Add(dt.Item(0))
            End While
            dt.Close()

            cmb_entrez_recherche.Visible = True
            txt_recherche_bat.Visible = False
        End If

        If cmb_rechercher.SelectedItem = "Tournée" Then
            chaine_connection()
            Dim cmn As New SqlCommand()
            cmn.CommandText = "select CODE_TOURNE from TOURNE"
            cmn.CommandType = CommandType.Text
            cmn.Connection = conx
            Dim dtrd As SqlDataReader = cmn.ExecuteReader
            cmb_entrez_recherche.Items.Clear()
            While (dtrd.Read)
                cmb_entrez_recherche.Items.Add(dtrd.Item(0))
            End While
            dtrd.Close()

            cmb_entrez_recherche.Visible = True
            txt_recherche_bat.Visible = False
        End If

        If cmb_rechercher.SelectedItem = "Agent qui a branché" Then
            chaine_connection()
            Dim com As New SqlCommand()
            com.CommandText = "select MAT from BATIMENT group by MAT"
            com.CommandType = CommandType.Text
            com.Connection = conx
            Dim dr As SqlDataReader = com.ExecuteReader
            cmb_entrez_recherche.Items.Clear()
            While (dr.Read)
                cmb_entrez_recherche.Items.Add(dr.Item(0))
            End While
            dr.Close()

            cmb_entrez_recherche.Visible = True
            txt_recherche_bat.Visible = False
        End If



    End Sub


    Private Sub cmb_entrez_recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_entrez_recherche.SelectedIndexChanged

        If cmb_rechercher.SelectedItem = "Catégorie" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where LIBELLE_CAT like '%" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If
        If cmb_rechercher.SelectedItem = "Type de tension" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where TYPE_TENSION like '%" & cmb_entrez_recherche.SelectedItem & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Type de Batiment" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where TYPE_BAT like '" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Agent qui a branché" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where MAT like '%" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If
        If cmb_rechercher.SelectedItem = "Tournée" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_TOURNE like '%" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@NUM"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_entrez_recherche.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If


        If cmb_rechercher.SelectedItem = "Zone" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where STATUT='Abonné' and NUM_TOURNE in (select CODE_TOURNE from TOURNE where NUME_ZONE like '%" & Val(cmb_entrez_recherche.Text) & "%')")
            cmd.Connection = conx


            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

    End Sub

    Private Sub cmb_entrez_recherche_TextChanged(sender As Object, e As EventArgs) Handles cmb_entrez_recherche.TextChanged

        If cmb_rechercher.SelectedItem = "Catégorie" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where LIBELLE_CAT like '%" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Type de tension" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where TYPE_TENSION like '%" & cmb_entrez_recherche.SelectedItem & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Type de Batiment" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where TYPE_BAT like '" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Agent qui a branché" Then
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where MAT like '%" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            
            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Tournée" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where NUM_TOURNE like '%" & cmb_entrez_recherche.Text & "%' and STATUT='Abonné'")
            cmd.Connection = conx

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If


        If cmb_rechercher.SelectedItem = "Zone" Then
            chaine_connection()
            Dim cmd As New SqlCommand("select CODE_BAT as Code,NUM_CL as Client,LIBELLE_CAT as Catégories,MAT as Agent,NATURE_BR_BAT as Nature,FRAIS_A_PAYE as Frais,DATE_BR_BAT as Date,REGLAGE_AMPER_DISJ_BAT as Amperage,PUISSANCE_BAT as Puissance,TYPE_BAT as Type,TYPE_TENSION as Tension,ID_BAT as Identifiant,NUM_TOURNE as Tourne from BATIMENT where STATUT='Abonné' and NUM_TOURNE in (select CODE_TOURNE from TOURNE where NUME_ZONE like '%" & Val(cmb_entrez_recherche.Text) & "%')")
            cmd.Connection = conx


            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            DGV_batiment.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
            lire.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Impression_liste_batiment.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       
            If DGV_batiment.CurrentRow.Cells(0).Value.ToString <> "" Then

            Form_Impression_fiche_batiment.ShowDialog()

            Else
                MessageBox.Show("Aucun élément selectionné")

            End If

       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        affiche_batiment()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form_Gestion_comptes.Cbx_bat.Text = lblcode_bat.Text
        Form_Gestion_comptes.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form1_imprime_recepice.ShowDialog()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class
