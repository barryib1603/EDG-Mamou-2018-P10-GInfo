Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class UserControl1_paiements

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_ajout_paiement.Click
        Try
            If txt_num_paie.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero de la paye")
                txt_num_paie.Focus()
                Exit Sub
            End If
            If cb_nat_paie.Text = "Paiement de Facture" And txt_con_paie.Text = "" Then
                MessageBox.Show("Veuillez saisir le Numero de la facture")
                txt_con_paie.Focus()
                Exit Sub
            End If
            If cb_nat_paie.Text = "" Then
                MessageBox.Show("Veuillez entrer la nature de la paye")
                cb_nat_paie.Focus()
                Exit Sub
            End If
            If cb_nat_paie.Text <> "Paiement de Facture par le Solde" Then
                If txt_mont_paie.Text = "" Then
                    MessageBox.Show("Veuillez entrer LE MONTANT Payé")
                    txt_mont_paie.Focus()
                    Exit Sub
                End If
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select * from PAIEMENT where(NUM_PAIE=@txt_num_paie)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@txt_num_paie"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txt_num_paie.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txt_num_paie.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand
            If txt_con_paie.Text <> "" Then
                If lblmontantàpayé.Text = "0" Then
                    MessageBox.Show("Cette Facture a atteind sa Limite de Paiement", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If Val(lblmontantàpayé.Text) < Val(txt_mont_paie.Text) Then

                    MessageBox.Show("Ce Paiement est superieur au reste à Payer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_mont_paie.Text = ""
                    txt_mont_paie.Focus()
                    Exit Sub
                End If
                Dim d As New SqlCommand
                d.CommandText = "select CODE_BAT from CONSOMMATION where NUM_COMSOM like '" & txt_con_paie.Text & "'"
                d.Connection = conx

                cmd.CommandText = ("Insert into PAIEMENT(NUM_COMSOM,NATURE_PAIE,MONTANT_PAIE,CODE_BAT,DATE_PAIEMENT) values(@numconsom,@nature,@montant,@c, @date)")
                cmd.Connection = conx

                Dim p As New SqlParameter
                p.ParameterName = "@c"
                p.SqlDbType = SqlDbType.NVarChar
                p.Value = d.ExecuteScalar
                cmd.Parameters.Add(p)

                Dim param1 As New SqlParameter
                param1.ParameterName = "@numconsom"
                param1.SqlDbType = SqlDbType.NVarChar
                param1.Value = txt_con_paie.Text
                cmd.Parameters.Add(param1)
            Else
                cmd.CommandText = ("Insert into PAIEMENT(NATURE_PAIE,MONTANT_PAIE,DATE_PAIEMENT) values(@nature,@montant, @date)")
                cmd.Connection = conx
            End If

            If cb_nat_paie.Text = "Paiement d'abonnement" Then
                cmd.CommandText = "Insert into PAIEMENT(NATURE_PAIE,MONTANT_PAIE,CODE_BAT,DATE_PAIEMENT) values(@nature,@montant,@co, @date)"
                cmd.Connection = conx
                Dim p As New SqlParameter
                p.ParameterName = "@co"
                p.SqlDbType = SqlDbType.NVarChar
                p.Value = cbx_bat.Text
                cmd.Parameters.Add(p)
            End If

            Dim param2 As New SqlParameter
            param2.ParameterName = "@nature"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cb_nat_paie.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@montant"
            param3.SqlDbType = SqlDbType.Money
            If cb_nat_paie.Text = "Paiement de Facture par le Solde" Then
                If Val(lbl_solde.Text) >= Val(lblmontantàpayé.Text) Then
                    Dim c As New SqlCommand
                    c.CommandText = "UPDATE BATIMENT Set SOLDE=@solde where CODE_BAT=(select CODE_BAT from CONSOMMATION where NUM_COMSOM=@n)"
                    c.Connection = conx

                    Dim ca As New SqlCommand
                    ca.CommandText = "insert into OPERATION(CODE_BAT,NATURE_OP,MONTANT_OP,SOLDE,DATE_OP) values(@codebat,'DEBIT',@montant,@s,@da)"
                    ca.Connection = conx

                    Dim c1 As New SqlCommand
                    c1.CommandText = "select CODE_BAT from consommation where NUM_COMSOM=@numero"
                    c1.Connection = conx

                    Dim pp As New SqlParameter
                    pp.ParameterName = "@numero"
                    pp.SqlDbType = SqlDbType.Int
                    pp.Value = txt_con_paie.Text
                    c1.Parameters.Add(pp)

                    Dim p1 As New SqlParameter
                    p1.ParameterName = "@codebat"
                    p1.SqlDbType = SqlDbType.NVarChar
                    p1.Value = c1.ExecuteScalar
                    ca.Parameters.Add(p1)

                    Dim pa As New SqlParameter
                    pa.ParameterName = "@montant"
                    pa.SqlDbType = SqlDbType.Money
                    pa.Value = Val(lblmontantàpayé.Text)
                    ca.Parameters.Add(pa)

                    Dim pa1 As New SqlParameter
                    pa1.ParameterName = "@s"
                    pa1.SqlDbType = SqlDbType.Money
                    pa1.Value = Val(lbl_solde.Text) - Val(lblmontantàpayé.Text)
                    ca.Parameters.Add(pa1)

                    Dim pa2 As New SqlParameter
                    pa2.ParameterName = "@da"
                    pa2.SqlDbType = SqlDbType.Date
                    pa2.Value = Date.Now
                    ca.Parameters.Add(pa2)

                    ca.ExecuteNonQuery()


                    Dim p2 As New SqlParameter
                    p2.ParameterName = "@solde"
                    p2.SqlDbType = SqlDbType.Money
                    p2.Value = Val(lbl_solde.Text) - Val(lblmontantàpayé.Text)
                    c.Parameters.Add(p2)

                    Dim p22 As New SqlParameter
                    p22.ParameterName = "@n"
                    p22.SqlDbType = SqlDbType.Int
                    p22.Value = Val(txt_con_paie.Text)
                    c.Parameters.Add(p22)

                    c.ExecuteNonQuery()
                    param3.Value = Val(lblmontantàpayé.Text)
                Else
                    Dim c11 As New SqlCommand
                    c11.CommandText = "UPDATE BATIMENT Set SOLDE=@sol where CODE_BAT=(select CODE_BAT from CONSOMMATION where NUM_COMSOM=@nu)"
                    c11.Connection = conx

                    Dim ca As New SqlCommand
                    ca.CommandText = "insert into OPERATION(CODE_BAT,NATURE_OP,MONTANT_OP,SOLDE,DATE_OP) values(@codebat,'DEBIT',@montant,@s,@da)"
                    ca.Connection = conx

                    Dim c1 As New SqlCommand
                    c1.CommandText = "select CODE_BAT from consommation where NUM_COMSOM=@numero"
                    c1.Connection = conx

                    Dim pp As New SqlParameter
                    pp.ParameterName = "@numero"
                    pp.SqlDbType = SqlDbType.Int
                    pp.Value = txt_con_paie.Text
                    c1.Parameters.Add(pp)

                    Dim p1 As New SqlParameter
                    p1.ParameterName = "@codebat"
                    p1.SqlDbType = SqlDbType.NVarChar
                    p1.Value = c1.ExecuteScalar
                    ca.Parameters.Add(p1)

                    Dim pa As New SqlParameter
                    pa.ParameterName = "@montant"
                    pa.SqlDbType = SqlDbType.Money
                    pa.Value = Val(lbl_solde.Text)
                    ca.Parameters.Add(pa)

                    Dim pa1 As New SqlParameter
                    pa1.ParameterName = "@s"
                    pa1.SqlDbType = SqlDbType.Money
                    pa1.Value = 0
                    ca.Parameters.Add(pa1)

                    Dim pa2 As New SqlParameter
                    pa2.ParameterName = "@da"
                    pa2.SqlDbType = SqlDbType.Date
                    pa2.Value = Date.Now
                    ca.Parameters.Add(pa2)

                    ca.ExecuteNonQuery()

                    Dim p21 As New SqlParameter
                    p21.ParameterName = "@sol"
                    p21.SqlDbType = SqlDbType.Money
                    p21.Value = 0
                    c11.Parameters.Add(p21)

                    Dim p222 As New SqlParameter
                    p222.ParameterName = "@nu"
                    p222.SqlDbType = SqlDbType.Int
                    p222.Value = Val(txt_con_paie.Text)
                    c11.Parameters.Add(p222)

                    param3.Value = Val(lbl_solde.Text)
                    c11.ExecuteNonQuery()
                End If
            ElseIf cb_nat_paie.Text = "Paiement de Facture par Cash" Then
                param3.Value = Val(txt_mont_paie.Text)
            Else
                param3.Value = txt_mont_paie.Text
            End If
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@date"
            param4.SqlDbType = SqlDbType.Date
            param4.Value = Date.Now()
            cmd.Parameters.Add(param4)

            cmd.ExecuteNonQuery()

            Dim cc As New SqlCommand
            cc.CommandText = "select CODE_BAT from consommation where NUM_COMSOM='" & txt_con_paie.Text & "'"
            cc.Connection = conx
            Dim code As String = cc.ExecuteScalar

            Dim co As New SqlCommand
            co.CommandText = "Update CONSOMMATION set STATUT_CONSOM='Payé' where CODE_BAT='" & code & "'"
            co.Connection = conx
            co.ExecuteNonQuery()

            Dim c22 As New SqlCommand
            c22.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du Paiement N°: " & txt_num_paie.Text & "','" & Date.Now & "')"
            c22.Connection = conx
            c22.ExecuteNonQuery()

            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            affiche_facture_impaye()
            affiche_paiement()
            txt_con_paie.Text = ""
            txt_mont_paie.Text = ""
            txt_num_paie.Text = ""
            cb_nat_paie.Text = ""
            lblmontantàpayé.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


        Try

            If txt_num_paie.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero de paiement")
                txt_num_paie.Focus()
                Exit Sub
            End If
            If txt_con_paie.Text = "" Then
                MessageBox.Show("Veuillez saisir le numéro de la consommation")
                txt_con_paie.Focus()
                Exit Sub
            End If
            If cb_nat_paie.Text = "" Then
                MessageBox.Show("Veuillez entrer la nature de paiement")
                cb_nat_paie.Focus()
                Exit Sub
            End If
            If txt_mont_paie.Text = "" Then
                MessageBox.Show("Veuillez entrer Le montant")
                txt_mont_paie.Focus()
                Exit Sub
            End If


            chaine_connection()
            Dim cmd As New SqlCommand

            cmd.CommandText = "UPDATE PAIEMENT SET NUM_PAIE=@numéro, NUM_COMSOM=@consommation, NATURE_PAIE=@nature,MONTANT_PAIE=@montant where (NUM_PAIE=@numéro)"
            cmd.Connection = conx






            Dim param20 As New SqlParameter
            param20.ParameterName = "@numéro"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = txt_num_paie.Text
            cmd.Parameters.Add(param20)



            Dim param21 As New SqlParameter
            param21.ParameterName = "@consommation"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = txt_con_paie.Text
            cmd.Parameters.Add(param21)


            Dim param22 As New SqlParameter
            param22.ParameterName = "@nature"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = cb_nat_paie.Text
            cmd.Parameters.Add(param22)


            Dim param3 As New SqlParameter
            param3.ParameterName = "@montant"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txt_mont_paie.Text
            cmd.Parameters.Add(param3)


            cmd.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            affiche_paiement()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_payement_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserControl1_paiements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_con_paie.Enabled = False

        chaine_connection()
        combox_consom_paie()
       

        Cmb_recherche.SelectedItem = "Numéro"

        Dim jour As Integer
        Dim mois As Integer
        Dim anee As Integer

        cmb_jour_recherche_paie.Items.Clear()
        For jour = 1 To 31
            cmb_jour_recherche_paie.Items.Add(jour)
        Next
        cmb_mois_recherche_paie.Items.Clear()
        For mois = 1 To 12
            cmb_mois_recherche_paie.Items.Add(mois)
        Next
        cmb_annee_recherche_paie.Items.Clear()
        For anee = 2000 To (Year(Date.Today))
            cmb_annee_recherche_paie.Items.Add(anee)
        Next

    End Sub


    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where(NUM_PAIE=@numéro)"
            cmd.Connection = conx


            Dim param1 As New SqlParameter
            param1.ParameterName = "@numéro"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param1)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
        End If
        If Cmb_recherche.SelectedItem = "Facture" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where(NUM_COMSOM=@NUM)"
            cmd.Connection = conx


            Dim param2 As New SqlParameter
            param2.ParameterName = "@NUM"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txt_recherche_paie.Text
            cmd.Parameters.Add(param2)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Cette Facture n'existe pas")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Batiment" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where(CODE_BAT=@code)"
            cmd.Connection = conx


            Dim param1 As New SqlParameter
            param1.ParameterName = "@code"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cbx_recherche_bat.Text
            cmd.Parameters.Add(param1)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("Le Numero de Paiement est Incorrect")

            End If
        End If

        If Cmb_recherche.SelectedItem = "Date" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where(NUM_PAIE=@Date)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@date"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_mois_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("cette date n'existe pas")

            End If

        End If








    End Sub

    Private Sub txt_recherche_paie_TextChanged(sender As Object, e As EventArgs)
        chaine_connection()

        If Cmb_recherche.SelectedItem = "Numéro" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where[NUM_PAIE] LIKE '%" & cmb_mois_recherche_paie.Text & "%'"
            cmd.Connection = conx


            Dim param1 As New SqlParameter
            param1.ParameterName = "@numéro"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_mois_recherche_paie.Text
            cmd.Parameters.Add(param1)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If
        If Cmb_recherche.SelectedItem = "Facture" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where[NUM_COMSOM] LIKE '%" & cmb_mois_recherche_paie.Text & "%'"
            cmd.Connection = conx


            Dim param2 As New SqlParameter
            param2.ParameterName = "@NOM"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_mois_recherche_paie.Text
            cmd.Parameters.Add(param2)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            End If
        End If

        If Cmb_recherche.SelectedItem = "Nature" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where[NATURE_PAIE] LIKE '%" & cmb_mois_recherche_paie.Text & "%'"
            cmd.Connection = conx


            Dim param1 As New SqlParameter
            param1.ParameterName = "@nature"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_mois_recherche_paie.Text
            cmd.Parameters.Add(param1)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then

            End If
        End If

        If Cmb_recherche.SelectedItem = "Date" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_PAIE as numéro, NUM_COMSOM as consommation,NATURE_PAIE as nature,CODE_BAT as Batiments, MONTANT_PAIE as montant from PAIEMENT where[DATE_PAIEMENT] LIKE '%" & cmb_mois_recherche_paie.Text & "%'"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@date"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = cmb_mois_recherche_paie.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_paiements1.dgv_paiement.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            End If

        End If

    End Sub

    Private Sub Cmb_recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_recherche.SelectedIndexChanged
        
        
        
        If Cmb_recherche.SelectedItem = "Batiment" Then
            cbx_recherche_bat.Visible = True
            cmb_annee_recherche_paie.Visible = False
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = False

            Dim com As New SqlCommand()
            com.CommandText = "select CODE_BAT from BATIMENT where STATUT='Abonné'"
            com.CommandType = CommandType.Text
            com.Connection = conx
            cbx_recherche_bat.Items.Clear()
            Dim dr As SqlDataReader = com.ExecuteReader
            While (dr.Read)
                cbx_recherche_bat.Items.Add(dr.Item(0))
            End While
            dr.Close()
        ElseIf Cmb_recherche.SelectedItem = "Numéro" Then
            cmb_annee_recherche_paie.Visible = False
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = True
            cbx_recherche_bat.Visible = False
        Else
            cmb_annee_recherche_paie.Visible = False
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = True
            cbx_recherche_bat.Visible = False
        End If
    End Sub

    

    Private Sub txt_num_paie_TextChanged(sender As Object, e As EventArgs) Handles txt_num_paie.TextChanged

    End Sub

    Private Sub dgv_paiement_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_paiement.CellDoubleClick
        If dgv_paiement.CurrentRow.Cells(0).Value.ToString <> "" Then
            txt_num_paie.Text = dgv_paiement.CurrentRow.Cells(0).Value.ToString
            txt_con_paie.Text = dgv_paiement.CurrentRow.Cells(1).Value.ToString
            cb_nat_paie.Text = dgv_paiement.CurrentRow.Cells(2).Value.ToString
            txt_mont_paie.Text = dgv_paiement.CurrentRow.Cells(3).Value.ToString
        End If
    End Sub

    Private Sub cb_nat_paie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_nat_paie.SelectedIndexChanged
        chaine_connection()
        Dim cmnd1 As New SqlCommand
        cmnd1.CommandText = "select max(NUM_PAIE) from PAIEMENT"
        cmnd1.Connection = conx
        If Not IsDBNull(cmnd1.ExecuteScalar) Then
            txt_num_paie.Text = Val(cmnd1.ExecuteScalar) + 1
        Else
            txt_num_paie.Text = 1
        End If
        If cb_nat_paie.Text = "Paiement de Facture par le Solde" Then
            Label3.Visible = True
            txt_con_paie.Visible = True
            cbx_bat.Visible = False
            Label14.Visible = False
            Label11.Visible = True
            Label12.Visible = True

            txt_con_paie.Enabled = True
            lbl_solde.Visible = True
            lblsold.Visible = True
            lblmontantàpayé.Visible = True
            Label6.Visible = True
            txt_mont_paie.Enabled = False

            Dim com As New SqlCommand()
            com.CommandText = "select NUM_COMSOM from CONSOMMATION where CODE_BAT in (select CODE_BAT FROM BATIMENT WHERE SOLDE>0) "
            com.CommandType = CommandType.Text
            com.Connection = conx
            Dim dr As SqlDataReader = com.ExecuteReader
            Form2_menu_principal.UserControl1_paiements1.txt_con_paie.Items.Clear()
            While (dr.Read)
                Form2_menu_principal.UserControl1_paiements1.txt_con_paie.Items.Add(dr.Item(0))
            End While
            dr.Close()
        ElseIf (cb_nat_paie.Text = "Paiement de Facture par Cash") Then
            Label3.Visible = True
            txt_con_paie.Visible = True
            cbx_bat.Visible = False
            Label14.Visible = False
            Label11.Visible = True
            Label12.Visible = True

            txt_con_paie.Enabled = True
            lbl_solde.Visible = False
            lblsold.Visible = False
            lblmontantàpayé.Visible = True
            Label6.Visible = True
            combox_consom_paie()
            txt_mont_paie.Enabled = True
        ElseIf (cb_nat_paie.Text = "Paiement d'abonnement") Then
            txt_mont_paie.Enabled = True
            Label3.Visible = False
            txt_con_paie.Enabled = False
            cbx_bat.Visible = True
            Label14.Visible = True
            Label11.Visible = False
            Label12.Visible = False
            lbl_solde.Visible = False
            lblsold.Visible = False
            Label6.Visible = False
            lblmontantàpayé.Visible = False

            Dim com As New SqlCommand()
            com.CommandText = "select CODE_BAT from BATIMENT where STATUT='Abonné'"
            com.CommandType = CommandType.Text
            com.Connection = conx
            cbx_bat.Items.Clear()
            Dim dr As SqlDataReader = com.ExecuteReader
            While (dr.Read)
                cbx_bat.Items.Add(dr.Item(0))
            End While
            dr.Close()
        Else
            cbx_bat.Visible = False
            Label14.Visible = False
            txt_con_paie.Enabled = False
            lbl_solde.Visible = False
            lblsold.Visible = False
            lblmontantàpayé.Visible = False
            Label6.Visible = False
            txt_mont_paie.Enabled = True
            Label11.Visible = False
            Label12.Visible = False
        End If
     









    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_imprime_paiement.Click
        Form_impression_liste_paiement.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_reçu.Click
        'Try
        '    chaine_connection()
        '    If dgv_paiement.CurrentRow.Cells(0).Value.ToString <> "" Then


        '        Dim cmd As New SqlCommand
        '        cmd.CommandText = "select *from PAIEMENT where(NUM_PAIE=@NUM)"
        '        cmd.Connection = conx

        '        Dim param As New SqlParameter
        '        param.ParameterName = "@NUM"
        '        param.SqlDbType = SqlDbType.NVarChar
        '        param.Value = dgv_paiement.CurrentRow.Cells(0).Value.ToString
        '        cmd.Parameters.Add(param)

        '        Dim adatp = New SqlDataAdapter(cmd)
        '        adatp.Fill(Form_Impression_recu_paiement.EDG_Mamou_G8DataSet.PAIEMENT1)

        '        conx.Close()
        '        Form_Impression_recu_paiement.ReportViewer1.RefreshReport()
        '        Form_Impression_recu_paiement.ShowDialog()

        '    Else
        '        MessageBox.Show("Aucun élément selectionné")

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Form_Impression_recu_paiement.ShowDialog()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_con_paie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_con_paie.SelectedIndexChanged
        chaine_connection()
        Dim cmd As New SqlCommand
        cmd.CommandText = "select MONTANT_TTC from CONSOMMATION WHERE NUM_COMSOM=@montant"
        cmd.Connection = conx
        Dim param As New SqlParameter
        param.ParameterName = "@montant"
        param.SqlDbType = SqlDbType.Money
        param.Value = Val(txt_con_paie.Text)
        cmd.Parameters.Add(param)
        Dim montant As Integer = cmd.ExecuteScalar

        Dim cmd1 As New SqlCommand
        cmd1.CommandText = "select SUM(MONTANT_PAIE) from PAIEMENT where NUM_COMSOM=@num"
        cmd1.Connection = conx
        Dim para As New SqlParameter
        para.ParameterName = "@num"
        para.SqlDbType = SqlDbType.Money
        para.Value = txt_con_paie.Text
        cmd1.Parameters.Add(para)
        If Not IsDBNull(cmd1.ExecuteScalar) Then
            Dim Paie As Integer = cmd1.ExecuteScalar
            If Paie < montant Then
                lblmontantàpayé.Text = montant - Paie
            Else
                lblmontantàpayé.Text = "0"
            End If
        Else
            lblmontantàpayé.Text = montant
        End If

        If cb_nat_paie.Text = "Paiement de Facture par le Solde" Then
            Dim c As New SqlCommand
            c.CommandText = "select SOLDE from BATIMENT where CODE_BAT=(select CODE_BAT from CONSOMMATION WHERE NUM_COMSOM=@num)"
            c.Connection = conx
            Dim p1 As New SqlParameter
            p1.ParameterName = "@num"
            p1.SqlDbType = SqlDbType.Int
            p1.Value = Val(txt_con_paie.Text)
            c.Parameters.Add(p1)



            If Not IsDBNull(c.ExecuteScalar) Then
                lbl_solde.Text = c.ExecuteScalar
            Else
                lbl_solde.Text = 0
            End If

        End If

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_Gestion_comptes.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        affiche_paiement()
    End Sub
End Class
