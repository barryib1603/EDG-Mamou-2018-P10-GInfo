Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class UserControl1_message_réçu

    Private Sub UserControl1_message_réçu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche_message_reçu()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        compte_message_non_lu()
    End Sub



    Private Sub dgvmessageReçu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmessageReçu.CellDoubleClick
        If dgvmessageReçu.CurrentRow.Cells(0).Value.ToString <> "" Then
            chaine_connection()
            Dim com As New SqlCommand
            com.CommandText = "select exp_msg from MESSAGERIE where num_msg=@num"
            com.Connection = conx
            Dim com1 As New SqlCommand
            com1.CommandText = "select entete_msg from MESSAGERIE where num_msg=@num1"
            com1.Connection = conx
            Dim com2 As New SqlCommand
            com2.CommandText = "select corp_msg from MESSAGERIE where num_msg=@num2"
            com2.Connection = conx

            Dim param1 As New SqlParameter
            param1.ParameterName = "@num"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = Val(dgvmessageReçu.CurrentRow.Cells(0).Value.ToString)
            com.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@num1"
            param2.SqlDbType = SqlDbType.Int
            param2.Value = Val(dgvmessageReçu.CurrentRow.Cells(0).Value.ToString)
            com1.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@num2"
            param3.SqlDbType = SqlDbType.Int
            param3.Value = Val(dgvmessageReçu.CurrentRow.Cells(0).Value.ToString)
            com2.Parameters.Add(param3)

            Form2_menu_principal.UserControl1_lire_message1.lbl_a.Text = com.ExecuteScalar().ToString()
            Form2_menu_principal.UserControl1_lire_message1.lbl__objet.Text = com1.ExecuteScalar().ToString()
            Form2_menu_principal.UserControl1_lire_message1.rtxt_lire_message.Text = com2.ExecuteScalar().ToString()
            Form2_menu_principal.lb_titre_msg.Text = "Message Réçu"

            chaine_connection()
            Dim com66 As New SqlCommand
            com66.CommandText = "update MESSAGERIE set status_msg=@statut where num_msg=@num_m"
            com66.Connection = conx

            Dim param16 As New SqlParameter
            param16.ParameterName = "@num_m"
            param16.SqlDbType = SqlDbType.NVarChar
            param16.Value = Val(dgvmessageReçu.CurrentRow.Cells(0).Value.ToString)
            com66.Parameters.Add(param16)

            Dim param161 As New SqlParameter
            param161.ParameterName = "@statut"
            param161.SqlDbType = SqlDbType.NVarChar
            param161.Value = "lu"
            com66.Parameters.Add(param161)

            com66.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','consultation du message envoyé N° " & dgvmessageReçu.CurrentRow.Cells(0).Value().ToString() & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            Form2_menu_principal.UserControl1_lire_message1.btnRepondre.Visible = True
            Form2_menu_principal.UserControl1_lire_message1.Show()
            Form2_menu_principal.UserControl1_message_réçu1.Hide()
            Form2_menu_principal.UserControl1_nouveau_message1.Hide()

        End If

    End Sub


    '-------------------------------------------------------------------------------------------------------------------------
    '-------------------------Colorer la une ligne lorsque le message n'est pas -----------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------

    'Private Sub dgvmessageReçu_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvmessageReçu.RowsAdded
    '    chaine_connection()
    '    Dim cmd As New SqlCommand
    '    Dim statut As String

    '    For i As Integer = e.RowIndex To e.RowCount

    '        cmd.CommandText = "select status_msg from dbo.MESSAGERIE where num_msg=" & i + 1 & ""
    '        cmd.Connection = conx

    '        statut = cmd.ExecuteScalar().ToString()

    '        If statut = "non lu" Then
    '            dgvmessageReçu.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
    '        End If

    '    Next

    'End Sub

End Class
