
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Categories


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Call chaine_connection()
            Dim cmd As New SqlCommand("Insert into CATEGORIE_BATIMENT(LIBELLE_CAT,TRANCHE1,MONTANT1,TRANCHE2,MONTANT2,TRANCHE3,MONTANT3,PRIME_FIX,POURCENT_FRANCHI,LIMITE_FRANCHI) values(@LIBELLE_CAT,@TRANCHE1,@MONTANT1,@TRANCHE2,@MONTANT2,@TRANCHE3,@MONTANT3,@PRIME_FIXE,@POURCENT_FRANCHI,@LIMITE_FRANCHI)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@LIBELLE_CAT"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtcategorie_cat.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@TRANCHE1"
            param1.SqlDbType = SqlDbType.Int
            param1.Value = Val(txttranche1_cat.Text)
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@MONTANT1"
            param2.SqlDbType = SqlDbType.Money
            param2.Value = Val(txtmontant1_cat.Text)
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@TRANCHE2"
            param3.SqlDbType = SqlDbType.Int
            param3.Value = Val(txttranche2_cat.Text)
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@MONTANT2"
            param4.SqlDbType = SqlDbType.Money
            param4.Value = Val(txtmontant2_cat.Text)
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@TRANCHE3"
            param5.SqlDbType = SqlDbType.Int
            param5.Value = Val(txttranche3_cat.Text)
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@MONTANT3"
            param6.SqlDbType = SqlDbType.Money
            param6.Value = Val(txtmontant3_cat.Text)
            cmd.Parameters.Add(param6)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@POURCENT_FRANCHI"
            param8.SqlDbType = SqlDbType.Money
            param8.Value = Val(txt_franchi_pourcent.Text)
            cmd.Parameters.Add(param8)

            Dim param10 As New SqlParameter
            param10.ParameterName = "@PRIME_FIXE"
            param10.SqlDbType = SqlDbType.Money
            param10.Value = Val(txt_prime_fix.Text)
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@LIMITE_FRANCHI"
            param11.SqlDbType = SqlDbType.Money
            param11.Value = Val(txt_limit_franchi.Text)
            cmd.Parameters.Add(param11)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout de la categorie : " & txtcategorie_cat.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MsgBox("ENREGISTREMENT EFFECTUE AVEC SUCCES !")
            affiche_categorie()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche_categorie()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chaine_connection()
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "UPDATE CATEGORIE_BATIMENT SET LIBELLE_CAT=@LIBELLE_CAT,TRANCHE1=@TRANCHE1,MONTANT1=@MONTANT1,TRANCHE2=@TRANCHE2,MONTANT2=@MONTANT2,TRANCHE3=@TRANCHE3,MONTANT3=@MONTANT3,PRIME_FIX=@PRIME_FIXE,POURCENT_FRANCHI=@POURCENT_FRANCHI,LIMITE_FRANCHI=@LIMITE_FRANCHI WHERE LIBELLE_CAT=@LIBELLE_CAT"
            cmd.Connection = conx

            Dim param20 As New SqlParameter
            param20.ParameterName = "@LIBELLE_CAT"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = txtcategorie_cat.Text
            cmd.Parameters.Add(param20)

            Dim param21 As New SqlParameter
            param21.ParameterName = "@TRANCHE1"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = txttranche1_cat.Text
            cmd.Parameters.Add(param21)

            Dim param22 As New SqlParameter
            param22.ParameterName = "@MONTANT1"
            param22.SqlDbType = SqlDbType.Money
            param22.Value = txtmontant1_cat.Text
            cmd.Parameters.Add(param22)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@TRANCHE2"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txttranche2_cat.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@MONTANT2"
            param4.SqlDbType = SqlDbType.Money
            param4.Value = txtmontant2_cat.Text
            cmd.Parameters.Add(param4)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@TRANCHE3"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = txttranche3_cat.Text
            cmd.Parameters.Add(param5)

            Dim param7 As New SqlParameter
            param7.ParameterName = "@MONTANT3"
            param7.SqlDbType = SqlDbType.Money
            param7.Value = Val(txtmontant3_cat.Text)
            cmd.Parameters.Add(param7)

            Dim param8 As New SqlParameter
            param8.ParameterName = "@POURCENT_FRANCHI"
            param8.SqlDbType = SqlDbType.Money
            param8.Value = Val(txt_franchi_pourcent.Text)
            cmd.Parameters.Add(param8)

            Dim param10 As New SqlParameter
            param10.ParameterName = "@PRIME_FIXE"
            param10.SqlDbType = SqlDbType.Money
            param10.Value = Val(txt_prime_fix.Text)
            cmd.Parameters.Add(param10)

            Dim param11 As New SqlParameter
            param11.ParameterName = "@LIMITE_FRANCHI"
            param11.SqlDbType = SqlDbType.Money
            param11.Value = Val(txt_limit_franchi.Text)
            cmd.Parameters.Add(param11)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification de la categorie : " & txtcategorie_cat.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")
            affiche_categorie()
            txtcategorie_cat.Text = ""
            txtmontant1_cat.Text = ""
            txtmontant2_cat.Text = ""
            txtmontant3_cat.Text = ""
            txttranche2_cat.Text = ""
            txttranche1_cat.Text = ""
            txttranche3_cat.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            If dgvcategorie.CurrentRow.Cells(0).Value.ToString <> "" Then
                Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmation = Windows.Forms.DialogResult.Yes Then

                    chaine_connection()

                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from CATEGORIE_BATIMENT where(LIBELLE_CAT=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgvcategorie.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    txtcategorie_cat.Text = ""
                    txtmontant1_cat.Text = ""
                    txtmontant2_cat.Text = ""
                    txtmontant3_cat.Text = ""
                    txttranche1_cat.Text = ""
                    txttranche2_cat.Text = ""
                    txttranche3_cat.Text = ""

                    cmd.ExecuteNonQuery()

                    Dim c As New SqlCommand
                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression de la categorie : " & dgvcategorie.CurrentRow.Cells(0).Value().ToString() & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()

                    affiche_categorie()

                End If
            Else
                MessageBox.Show("Vous n'avez selectionné aucun element à supprimer")
            End If
        Catch ex As Exception
            MessageBox.Show("Impossible! Veuillez supprimer les Consommations Rattachées à cette Categorie", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub dgvcategorie_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategorie.CellDoubleClick
        If dgvcategorie.CurrentRow.Cells(0).Value.ToString <> "" Then
            txtcategorie_cat.Text = dgvcategorie.CurrentRow.Cells(0).Value.ToString
            txttranche1_cat.Text = dgvcategorie.CurrentRow.Cells(1).Value.ToString
            txtmontant1_cat.Text = dgvcategorie.CurrentRow.Cells(2).Value.ToString
            txttranche2_cat.Text = dgvcategorie.CurrentRow.Cells(3).Value.ToString
            txtmontant2_cat.Text = dgvcategorie.CurrentRow.Cells(4).Value.ToString
            txttranche3_cat.Text = dgvcategorie.CurrentRow.Cells(5).Value.ToString
            txtmontant3_cat.Text = dgvcategorie.CurrentRow.Cells(6).Value.ToString
            txt_prime_fix.Text = dgvcategorie.CurrentRow.Cells(7).Value.ToString
            txt_franchi_pourcent.Text = dgvcategorie.CurrentRow.Cells(8).Value.ToString
            txt_limit_franchi.Text = dgvcategorie.CurrentRow.Cells(9).Value.ToString
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtcategorie_cat.Text = ""
        txttranche1_cat.Text = ""
        txttranche2_cat.Text = ""
        txttranche3_cat.Text = ""
        txtmontant1_cat.Text = ""
        txtmontant2_cat.Text = ""
        txtmontant3_cat.Text = ""
        txt_franchi_pourcent.Text = ""
        txt_prime_fix.Text = ""
        txt_limit_franchi.Text = ""

    End Sub
End Class
