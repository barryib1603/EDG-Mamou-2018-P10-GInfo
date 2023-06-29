Public Class UserControl1_lire_message

    Private Sub btnRepondre_Click(sender As Object, e As EventArgs) Handles btnRepondre.Click
        Form2_menu_principal.UserControl1_nouveau_message1.cmb_a.Text = lbl_a.Text
        Form2_menu_principal.UserControl1_nouveau_message1.Show()
        Form2_menu_principal.UserControl1_lire_message1.Hide()
        Form2_menu_principal.lb_titre_msg.Text = "Nouveau Message"
    End Sub
End Class
