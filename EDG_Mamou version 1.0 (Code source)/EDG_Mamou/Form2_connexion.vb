Imports System.Data
Imports System.Data.SqlClient
Imports System.Net

Public Class Form2_connexion

    Dim nbr_tenter As Integer = 0

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtlogin_connexion.Text = "" Then
            MessageBox.Show("Veuillz saisir votre login")
            txtlogin_connexion.Focus()
            Exit Sub
        End If
        If txtmpasse_connexion.Text = "" Then
            MessageBox.Show("Veuillz saisir votre mot de passe")
            txtmpasse_connexion.Focus()
            Exit Sub
        End If
        Try
            chaine_connection()
            Dim cmd As New SqlCommand("select * from UTILISATEUR where(LOGIN_UT=@login) and (M_PASSE_UT=@password)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@login"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtlogin_connexion.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@password"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtmpasse_connexion.Text
            cmd.Parameters.Add(param1)

            Dim lire As SqlDataReader = cmd.ExecuteReader

            If lire.Read Then
                lire.Close()
                chaine_connection()
                Dim cmd1 As New SqlCommand("select STATUT from UTILISATEUR where(LOGIN_UT=@login) and (M_PASSE_UT=@password)")
                cmd1.Connection = conx

                Dim param11 As New SqlParameter
                param11.ParameterName = "@login"
                param11.SqlDbType = SqlDbType.NVarChar
                param11.Value = txtlogin_connexion.Text
                cmd1.Parameters.Add(param11)

                Dim param12 As New SqlParameter
                param12.ParameterName = "@password"
                param12.SqlDbType = SqlDbType.NVarChar
                param12.Value = txtmpasse_connexion.Text
                cmd1.Parameters.Add(param12)

                Dim statut As String = cmd1.ExecuteScalar().ToString()

                If statut = "Activé" Then
                    Try
                        chaine_connection()

                        Dim cmda As New SqlCommand
                        cmda.CommandText = "select NOM_UT from UTILISATEUR where(LOGIN_UT=@login) and (M_PASSE_UT=@password)"
                        cmda.Connection = conx

                        Dim parama1 As New SqlParameter
                        parama1.ParameterName = "@login"
                        parama1.SqlDbType = SqlDbType.NVarChar
                        parama1.Value = txtlogin_connexion.Text
                        cmda.Parameters.Add(parama1)

                        Dim param1a1 As New SqlParameter
                        param1a1.ParameterName = "@password"
                        param1a1.SqlDbType = SqlDbType.NVarChar
                        param1a1.Value = txtmpasse_connexion.Text
                        cmda.Parameters.Add(param1a1)

                        Dim cmnd1a As New SqlCommand
                        cmnd1a.CommandText = "select droit from UTILISATEUR where(LOGIN_UT=@login) and (M_PASSE_UT=@password)"
                        cmnd1a.Connection = conx

                        Dim parama As New SqlParameter
                        parama.ParameterName = "@login"
                        parama.SqlDbType = SqlDbType.NVarChar
                        parama.Value = txtlogin_connexion.Text
                        cmnd1a.Parameters.Add(parama)

                        Dim param1a As New SqlParameter
                        param1a.ParameterName = "@password"
                        param1a.SqlDbType = SqlDbType.NVarChar
                        param1a.Value = txtmpasse_connexion.Text
                        cmnd1a.Parameters.Add(param1a)

                        Dim droit As String = cmnd1a.ExecuteScalar().ToString()
                        nom_util = cmda.ExecuteScalar().ToString()

                        Form2_menu_principal.Timer1.Start()
                        Form2_menu_principal.UserControl1_message_réçu1.Timer1.Start()
                        Form_Historiq_connexion.Timer1.Start()

                        If droit = "admin" Then
                            profil = txtlogin_connexion.Text
                            mp = txtmpasse_connexion.Text
                            admin()
                        End If
                        If droit = "litige" Then
                            profil = txtlogin_connexion.Text
                            mp = txtmpasse_connexion.Text
                            litige()
                        End If
                        If droit = "facturation" Then
                            profil = txtlogin_connexion.Text
                            mp = txtmpasse_connexion.Text
                            facturation()
                        End If
                        If droit = "Div Techn" Then
                            profil = txtlogin_connexion.Text
                            mp = txtmpasse_connexion.Text
                            division_tech()
                        End If
                        If droit = "caisse" Then
                            profil = txtlogin_connexion.Text
                            mp = txtmpasse_connexion.Text
                            caisse()
                        End If
                        If droit = "Div Com" Then
                            profil = txtlogin_connexion.Text
                            mp = txtmpasse_connexion.Text
                            division_com()
                        End If
                    Catch ex As Exception

                    End Try
                ElseIf statut = "Desactivé" Then
                    MessageBox.Show("Ce compte est desactivé. Veuillez contacter l'administrateur de l'application")
                End If
            Else
                Dim poste As String = Dns.GetHostName
                Dim ipV6ipV4 As IPHostEntry = Dns.GetHostEntry(poste)
                Dim ipad As String = ipV6ipV4.HostName
                Dim ipV4 As IPAddress() = ipV6ipV4.AddressList
                'ipV4 est un tableau a une dimension dont ipV4(0) contient ipv6 et ipV4(1) ipV4
                Dim ip_address As String = ipV4(1).ToString

                nbr_tenter = nbr_tenter + 1
                If nbr_tenter = 4 Then
                    chaine_connection()
                    Dim com As New SqlCommand
                    com.CommandText = "insert into MESSAGERIE(recp_msg,entete_msg,corp_msg,dat_msg,status_msg) values('Georges','Accès illégal detecté','Une personne tante illegallement de se connecter à cette application sur le poste " & poste & " dont IP= " & ip_address & "','" & Date.Now & "','non lu')"
                    com.Connection = conx
                    com.ExecuteNonQuery()
                End If
                MessageBox.Show("Mot de Passe ou Login Incorrect")
                txtlogin_connexion.Clear()
                txtmpasse_connexion.Clear()
                txtlogin_connexion.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class