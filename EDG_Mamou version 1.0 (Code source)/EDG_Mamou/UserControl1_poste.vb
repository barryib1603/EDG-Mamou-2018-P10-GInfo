Imports System.IO
Imports System.Data.SqlClient
Imports System.Data

Public Class UserControl1_poste

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1_poste.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form1_poste.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnajouter_post.Click
        Form1_poste.Btn_ajou.Visible = True
        Form1_poste.lblAjouter.Visible = True
        Form1_poste.Btn_modif.Visible = False
        Form1_poste.lblModifier.Visible = False
        Form1_poste.Btn_annul.Visible = True
        Form1_poste.lblAnnuler.Visible = True
        Form1_poste.lbltitre_poste.Text = "Enregistrement d'un Poste"
        Form1_poste.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnmodif_post.Click
      
        If lblnum_post.Text <> "" Then

            Form1_poste.txtnum_poste.Text = lblnum_post.Text
            Form1_poste.txtlibelle_poste.Text = lbl_libelle_post.Text
            Form1_poste.cmb_zone.Text = lblzone_post.Text
            Form1_poste.cmb_depart.Text = lbldepart_post.Text
            Form1_poste.txtpuissance_nominale_poste.Text = lblpuisance_post.Text
            Form1_poste.txtintensite_nominale_poste.Text = lblintensite_post.Text
            Form1_poste.txttype_poste.Text = lbltype_post.Text
            Form1_poste.txtnature_poste.Text = lblnature_post.Text
            Form1_poste.txtlignemt_long_poste.Text = lbllongMT_post.Text
            Form1_poste.txtlignemt_section_poste.Text = lblsectionpost.Text
            Form1_poste.txtlignebt_long_poste.Text = lbllongBT_post.Text
            Form1_poste.dtpraccorde.Text = lbl_date_rac.Text

            Form1_poste.Btn_ajou.Visible = False
            Form1_poste.lblAjouter.Visible = False
            Form1_poste.Btn_modif.Visible = True
            Form1_poste.lblModifier.Visible = True
            Form1_poste.Btn_annul.Visible = False
            Form1_poste.lblAnnuler.Visible = False
            Form1_poste.lbltitre_poste.Text = "Modification d'un Poste"

            Form1_poste.ShowDialog()
        Else
            MessageBox.Show("Vous N'avez selectionné aucun element à modifier")
        End If
    End Sub

    Private Sub dgv_poste_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_poste.CellClick
        If dgv_poste.CurrentRow.Cells(0).Value.ToString <> "" Then
            lblnum_post.Text = dgv_poste.CurrentRow.Cells(0).Value.ToString
            lbl_libelle_post.Text = dgv_poste.CurrentRow.Cells(1).Value.ToString
            lblzone_post.Text = dgv_poste.CurrentRow.Cells(2).Value.ToString
            lbldepart_post.Text = dgv_poste.CurrentRow.Cells(3).Value.ToString
            lblpuisance_post.Text = dgv_poste.CurrentRow.Cells(4).Value.ToString
            lblintensite_post.Text = dgv_poste.CurrentRow.Cells(5).Value.ToString
            lbltype_post.Text = dgv_poste.CurrentRow.Cells(6).Value.ToString
            lblnature_post.Text = dgv_poste.CurrentRow.Cells(7).Value.ToString
            lbllongMT_post.Text = dgv_poste.CurrentRow.Cells(8).Value.ToString
            lblsectionpost.Text = dgv_poste.CurrentRow.Cells(9).Value.ToString
            lbllongBT_post.Text = dgv_poste.CurrentRow.Cells(10).Value.ToString
            lbl_date_rac.Text = dgv_poste.CurrentRow.Cells(11).Value.ToString
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnrechercher_post_Click(sender As Object, e As EventArgs) Handles btnrechercher_post.Click

        If cmb_rechercher.SelectedItem = "Numero" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where(NUM_POSTE=@Num)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@Num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_poste.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Zone" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where(NUME_ZONE=@Num)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@Num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_poste.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Libelle" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where(LIBELLE_POSTE=@Num)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@Num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_poste.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
            lire.Close()
        End If

        If cmb_rechercher.SelectedItem = "Depart" Then
            Dim cmd As New SqlCommand
            cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where(Num_dep=@Num)"
            cmd.Connection = conx


            Dim param As New SqlParameter
            param.ParameterName = "@Num"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtrecherche_poste.Text
            cmd.Parameters.Add(param)

            Dim da = New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)
            Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

            Dim lire As SqlDataReader
            lire = cmd.ExecuteReader
            If lire.Read Then
            Else
                MsgBox("ce numero n'existe pas")

            End If
            lire.Close()
        End If
    End Sub

    Private Sub txtrecherche_poste_TextChanged(sender As Object, e As EventArgs) Handles txtrecherche_poste.TextChanged
        Try
            If cmb_rechercher.SelectedItem = "Numero" Then
                Dim cmd As New SqlCommand
                cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where NUM_POSTE LIKE  '%" & txtrecherche_poste.Text & "%'"
                cmd.Connection = conx




                Dim da = New SqlDataAdapter(cmd)
                Dim ds As New DataTable
                da.Fill(ds)
                Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

                Dim lire As SqlDataReader
                lire = cmd.ExecuteReader
                If lire.Read Then


                End If
                lire.Close()
            End If

            If cmb_rechercher.SelectedItem = "Zone" Then
                Dim cmd As New SqlCommand
                cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where NUME_ZONE LIKE  '%" & txtrecherche_poste.Text & "%'"
                cmd.Connection = conx




                Dim da = New SqlDataAdapter(cmd)
                Dim ds As New DataTable
                da.Fill(ds)
                Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

                Dim lire As SqlDataReader
                lire = cmd.ExecuteReader
                If lire.Read Then


                End If
                lire.Close()
            End If

            If cmb_rechercher.SelectedItem = "Libelle" Then
                Dim cmd As New SqlCommand
                cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where LIBELLE_POSTE LIKE  '%" & txtrecherche_poste.Text & "%'"
                cmd.Connection = conx




                Dim da = New SqlDataAdapter(cmd)
                Dim ds As New DataTable
                da.Fill(ds)
                Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

                Dim lire As SqlDataReader
                lire = cmd.ExecuteReader
                If lire.Read Then


                End If
                lire.Close()
            End If

            If cmb_rechercher.SelectedItem = "Depart" Then
                Dim cmd As New SqlCommand
                cmd.CommandText = "select NUM_POSTE as Numero,NUME_ZONE as Zone, LIBELLE_POSTE as Libelle ,Num_dep as Depart, PUISSNCE_NOMI as PUISSANCE_NOMINALE, INTENSITE_NOMI as Intensite_Nominale, TYPE_POSTE as TYPE, NATURE_POSTE as Nature,LONG_MT_POSTE as Longueur_MT,SECTION_MT_POSTE as Section_MT,LONG_BT_POSTE as Longueur_BT from POSTE where Num_dep LIKE  '%" & txtrecherche_poste.Text & "%'"
                cmd.Connection = conx



                Dim da = New SqlDataAdapter(cmd)
                Dim ds As New DataTable
                da.Fill(ds)
                Form2_menu_principal.UserControl1_poste1.dgv_poste.DataSource = ds

                Dim lire As SqlDataReader
                lire = cmd.ExecuteReader
                If lire.Read Then


                End If
                lire.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnimp_post_Click(sender As Object, e As EventArgs) Handles btnimp_post.Click
        Form_impression_poste.ShowDialog()
    End Sub

    Private Sub btnremplace_post_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
