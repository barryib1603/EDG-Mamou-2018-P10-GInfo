Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Form1_Evenement

    Private Sub Form1_Evenement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chaine_connection()

        Dim com As New SqlCommand()
        com.CommandText = "select MAT from PERSONNEL where FONCTION_PERS='Agent' AND STATUT='En Service'"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        cmb_agent.Items.Clear()
        While (dr.Read)
            cmb_agent.Items.Add(dr.Item(0))
        End While
        dr.Close()

        Dim cmn As New SqlCommand()
        cmn.CommandText = "select NUM_POSTE from POSTE"
        cmn.CommandType = CommandType.Text
        cmn.Connection = conx
        Dim dtrd As SqlDataReader = cmn.ExecuteReader
        cmb_poste.Items.Clear()
        While (dtrd.Read)
            cmb_poste.Items.Add(dtrd.Item(0))
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            chaine_connection()
            If txtnum_even.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero de l'evenement")
                txtnum_even.Focus()
                Exit Sub
            End If
            If cmb_agent.Text = "" Then
                MessageBox.Show("Veuillez saisir le Matricule de l'agent")
                cmb_agent.Focus()
                Exit Sub
            End If
            If cmb_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer le Poste")
                cmb_poste.Focus()
                Exit Sub
            End If
            If cmb_zone.Text = "" Then
                MessageBox.Show("Veuillez entrer La Zone")
                cmb_zone.Focus()
                Exit Sub
            End If

            If txtlibelle_even.Text = "" Then
                MessageBox.Show("Veuillez entrer Le Libelle de l'evenement")
                txtlibelle_even.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select * from EVENEMENT where(NUM_EV=@num)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@num"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtnum_even.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtnum_even.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into EVENEMENT(NUM_EV,MAT,NUM_POSTE,NUME_ZONE,LIBELLE_EV,EVENEMENT,DATE_DEBU_EV,DATE_FIN_EV) values(@num,@matricule,@poste,@zone, @lib,@evenement,@datdeb,@datfin)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_even.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@matricule"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_agent.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@poste"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_poste.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@zone"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = cmb_zone.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@lib"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtlibelle_even.Text
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@evenement"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = rtxt_evensur_even.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@datdeb"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = dtpdebut.Text
            cmd.Parameters.Add(param6)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@datfin"
            param7.SqlDbType = SqlDbType.NVarChar
            param7.Value = dtpfin.Text
            cmd.Parameters.Add(param7)





            cmd.ExecuteNonQuery()
            affiche_evenement()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de l evenement N° " & txtnum_even.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()
            MessageBox.Show("Enregistrement effectué avec succès")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtlibelle_even.Text = ""
        txtnum_even.Text = ""
        cmb_agent.Text = ""
        cmb_poste.Text = ""
        cmb_zone.Text = ""
        rtxt_evensur_even.Text = ""
    End Sub

    Private Sub btnModifier_ev_Click(sender As Object, e As EventArgs) Handles btnModifier_ev.Click
        Try
            chaine_connection()
            If txtnum_even.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero de l'evenement")
                txtnum_even.Focus()
                Exit Sub
            End If
            If cmb_agent.Text = "" Then
                MessageBox.Show("Veuillez saisir le Matricule de l'agent")
                cmb_agent.Focus()
                Exit Sub
            End If
            If cmb_poste.Text = "" Then
                MessageBox.Show("Veuillez entrer le Poste")
                cmb_poste.Focus()
                Exit Sub
            End If
            If cmb_zone.Text = "" Then
                MessageBox.Show("Veuillez entrer La Zone")
                cmb_zone.Focus()
                Exit Sub
            End If

            If txtlibelle_even.Text = "" Then
                MessageBox.Show("Veuillez entrer Le Libelle de l'evenement")
                txtlibelle_even.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand
            cmd.CommandText = "UPDATE  EVENEMENT SET NUM_EV=@num,MAT=@matricule,NUM_POSTE=@poste,NUME_ZONE=@zone,LIBELLE_EV=@lib,EVENEMENT=@evenement,DATE_DEBU_EV=@datdeb,DATE_FIN_EV=@datfin where NUM_EV=@num"
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_even.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@matricule"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = cmb_agent.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@poste"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_poste.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@zone"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = cmb_zone.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@lib"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtlibelle_even.Text
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@evenement"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = rtxt_evensur_even.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@datdeb"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = dtpdebut.Text
            cmd.Parameters.Add(param6)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@datfin"
            param7.SqlDbType = SqlDbType.NVarChar
            param7.Value = dtpfin.Text
            cmd.Parameters.Add(param7)

            cmd.ExecuteNonQuery()
            affiche_evenement()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de l evenement N° " & txtnum_even.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Modification effectuée avec succès")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Form1_Evenement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtlibelle_even.Text = ""
        txtnum_even.Text = ""
        cmb_agent.Text = ""
        cmb_poste.Text = ""
        cmb_zone.Text = ""
        rtxt_evensur_even.Text = ""
    End Sub


    Private Sub rtxt_evensur_even_TextChanged(sender As Object, e As EventArgs) Handles rtxt_evensur_even.TextChanged
        chaine_connection()
        Dim cmnd12 As New SqlCommand
        cmnd12.CommandText = "select max(NUM_EV) from EVENEMENT"
        cmnd12.Connection = conx

        txtnum_even.Text = Val(cmnd12.ExecuteScalar()) + 1
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class