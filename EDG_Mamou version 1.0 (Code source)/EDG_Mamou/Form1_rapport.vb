Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1_Rapport

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Try
            If txtnum_rapport.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero du rapport")
                txtnum_rapport.Focus()
                Exit Sub
            End If

            If cmb_tpersonnel_rapport.Text = "" Then
                MessageBox.Show("Veuillez vous Identifier svp ")
                cmb_tpersonnel_rapport.Focus()
                Exit Sub
            End If
            If txtlibelle_rapport.Text = "" Then
                MessageBox.Show("Veuillez entrer un titre pour votre rapport")
                txtlibelle_rapport.Focus()
                Exit Sub
            End If

            If rtxtdescription_rapport.Text = "" Then
                MessageBox.Show("Veuillez entrer le contenu du rapport")
                rtxtdescription_rapport.Focus()
                Exit Sub
            End If

            Call chaine_connection()

            Dim cmd0 As New SqlCommand("select * from RAPPORT_ADMIN where(NUM_RAP=@NUM)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@NUM"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtnum_rapport.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtnum_rapport.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into RAPPORT_ADMIN(NUM_RAP,MAT,LIBELLE_RAP,DESC_RAP,DATE_RAP) values (@NUME,@PERS,@LIBELLE,@DESC,@DATE)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@NUME"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_rapport.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@PERS"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = cmb_tpersonnel_rapport.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@LIBELLE"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtlibelle_rapport.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@DESC"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = rtxtdescription_rapport.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@DATE"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = Date.Now()
            cmd.Parameters.Add(param4)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du rapport N° " & txtnum_rapport.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            affiche_rapport()
            MessageBox.Show("Enregistrement effectué avec succès")
            txtnum_rapport.Text = ""
            cmb_tpersonnel_rapport.Text = ""
            txtlibelle_rapport.Text = ""
            rtxtdescription_rapport.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage affectation
        affiche_rapport()
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Try
            Call chaine_connection()

            Dim cmd As New SqlCommand("UPDATE RAPPORT_ADMIN SET NUM_RAP=@NUME,MAT=@PERS,LIBELLE_RAP=@LIBELLE,DESC_RAP=@DESC where NUM_RAP=@NUME")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@NUME"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtnum_rapport.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@PERS"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = cmb_tpersonnel_rapport.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@LIBELLE"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtlibelle_rapport.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@DESC"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = rtxtdescription_rapport.Text
            cmd.Parameters.Add(param3)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification du rapport N° " & txtnum_rapport.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            affiche_rapport()
            MessageBox.Show("Modification effectuée avec succès")
            txtlibelle_rapport.Text = ""
            txtnum_rapport.Text = ""
            cmb_tpersonnel_rapport.Text = ""
            rtxtdescription_rapport.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'procedure affichage affectation
        affiche_rapport()
    End Sub

    Private Sub Form1_Rapport_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtnum_rapport.Text = ""
        cmb_tpersonnel_rapport.Text = ""
        txtlibelle_rapport.Text = ""
        rtxtdescription_rapport.Text = ""
    End Sub

  
    Private Sub Form1_Rapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand
        cmd.CommandText = "select MAT from Personnel where NOM_SERVICE='division technique'"
        cmd.Connection = conx
        Dim dr As SqlDataReader = cmd.ExecuteReader
        cmb_tpersonnel_rapport.Items.Clear()
        While dr.Read
            cmb_tpersonnel_rapport.Items.Add("MAT")
        End While
    End Sub

    
End Class