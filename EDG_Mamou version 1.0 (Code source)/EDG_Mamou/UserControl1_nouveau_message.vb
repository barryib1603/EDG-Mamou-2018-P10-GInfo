Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class UserControl1_nouveau_message

    Private Sub btnEnvoie_Click(sender As Object, e As EventArgs) Handles btnEnvoie.Click
        Try
            chaine_connection()
            Dim com As New SqlCommand
            com.CommandText = "insert into MESSAGERIE(exp_msg,recp_msg,entete_msg,corp_msg,dat_msg,status_msg) values(@exp_msg,@recp_msg,@entete_msg,@corp_msg,@dat_msg,@status_msg)"
            com.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@exp_msg"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = nom_util
            com.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@recp_msg"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = cmb_a.Text
            com.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@entete_msg"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txt_objet.Text
            com.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@corp_msg"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = rtxt_message.Text
            com.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@dat_msg"
            param5.SqlDbType = SqlDbType.DateTime
            param5.Value = Date.Now
            com.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@status_msg"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = "non lu"
            com.Parameters.Add(param6)

            com.ExecuteNonQuery()

            affiche_message_envoyé()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Envoie d un Message à " & cmb_a.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MsgBox("Message envoyé avec succès")

            cmb_a.SelectedItem = False
            txt_objet.Clear()
            rtxt_message.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

  
End Class
