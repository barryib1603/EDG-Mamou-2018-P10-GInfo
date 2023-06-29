Public Class Form1_profil

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1_modifier_profil.btn_modifier_login.Visible = True
        Form1_modifier_profil.btn_modifier_mp.Visible = False
        Form1_modifier_profil.lbl_titre.Text = "Modifier mon login"

        Form1_modifier_profil.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1_modifier_profil.btn_modifier_login.Visible = False
        Form1_modifier_profil.btn_modifier_mp.Visible = True
        Form1_modifier_profil.lbl_titre.Text = "Modifier mon mot de passe"

        Form1_modifier_profil.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
    
    Private Sub Form1_profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nom_ut.Text = nom_util
        lbl_login_ut.Text = "***************"
        lbl_mdp_ut.Text = "************"

    End Sub

    Private Sub Form1_profil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        lbl_login_ut.Text = ""
        lbl_mdp_ut.Text = ""
        lbl_nom_ut.Text = ""
    End Sub
End Class