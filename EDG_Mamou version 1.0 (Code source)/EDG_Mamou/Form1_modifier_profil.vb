Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Form1_modifier_profil

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btn_modifier_login_Click(sender As Object, e As EventArgs) Handles btn_modifier_login.Click
        chaine_connection()
        If txt_ancien.Text = profil Then
            If txt_nouv.Text = txt_confirme.Text Then
                Dim cmd As New SqlCommand
                cmd.CommandText = "UPDATE [dbo].[UTILISATEUR] set LOGIN_UT='" & txt_confirme.Text & "' where NOM_UT='" & nom_util & "'"
                cmd.Connection = conx
                cmd.ExecuteNonQuery()

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de login','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                MessageBox.Show("Modification Effectué avec Succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Les deux LOGIN sont pas compatible", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_confirme.Text = ""
                txt_nouv.Text = ""
            End If
        Else
            MessageBox.Show("L'ancien LOGIN Incorrect ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_confirme.Text = ""
            txt_nouv.Text = ""
            txt_ancien.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_modifier_mp.Click
        chaine_connection()
        If txt_ancien.Text = mp Then
            If txt_nouv.Text = txt_confirme.Text Then
                Dim cmd As New SqlCommand
                cmd.CommandText = "UPDATE [dbo].[UTILISATEUR] set M_PASSE_UT='" & txt_confirme.Text & "' where NOM_UT='" & nom_util & "'"
                cmd.Connection = conx
                cmd.ExecuteNonQuery()

                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de son mot de passe','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()

                MessageBox.Show("Modification Effectué avec Succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Les deux Mots de passe sont pas compatible", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_confirme.Text = ""
                txt_nouv.Text = ""
            End If
        Else
            MessageBox.Show("L'ancien Mot de passe Incorrect ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_confirme.Text = ""
            txt_nouv.Text = ""
            txt_ancien.Text = ""
        End If
    End Sub

End Class