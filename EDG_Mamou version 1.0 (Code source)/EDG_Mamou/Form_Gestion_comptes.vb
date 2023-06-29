Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Form_Gestion_comptes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lbl_Num_CL.Text <> "" Then

            If Cbx_bat.Text = "" Then
                MessageBox.Show("Veuillez entrer le Numero du Batiment sur lequel le Solde doit être Ajouter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cbx_bat.Focus()
                Exit Sub
            End If

            If txt_montant.Text = "" Then
                MessageBox.Show("Veuillez entrer le Montant du Solde à Ajouter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_montant.Focus()
                Exit Sub
            End If
            Try
                chaine_connection()
                Dim cmd As New SqlCommand
                cmd.CommandText = "UPDATE BATIMENT set SOLDE=@solde where CODE_BAT=@code"
                cmd.Connection = conx

                Dim param As New SqlParameter
                param.ParameterName = "@solde"
                param.SqlDbType = SqlDbType.Money
                param.Value = Val(lblsolde.Text) + Val(txt_montant.Text)
                cmd.Parameters.Add(param)

                Dim para As New SqlParameter
                para.ParameterName = "@code"
                para.SqlDbType = SqlDbType.NVarChar
                para.Value = Cbx_bat.Text
                cmd.Parameters.Add(para)

                cmd.ExecuteNonQuery()
                chaine_connection()
                Dim ca As New SqlCommand
                ca.CommandText = "insert into OPERATION(CODE_BAT,NATURE_OP,MONTANT_OP,SOLDE,DATE_OP) values(@codebat,'CREDIT',@montant,@s,@da)"
                ca.Connection = conx

                Dim p1 As New SqlParameter
                p1.ParameterName = "@codebat"
                p1.SqlDbType = SqlDbType.NVarChar
                p1.Value = Cbx_bat.Text
                ca.Parameters.Add(p1)

                Dim pa As New SqlParameter
                pa.ParameterName = "@montant"
                pa.SqlDbType = SqlDbType.Money
                pa.Value = Val(txt_montant.Text)
                ca.Parameters.Add(pa)

                Dim pa1 As New SqlParameter
                pa1.ParameterName = "@s"
                pa1.SqlDbType = SqlDbType.Money
                pa1.Value = Val(lblsolde.Text) + Val(txt_montant.Text)
                ca.Parameters.Add(pa1)

                Dim pa2 As New SqlParameter
                pa2.ParameterName = "@da"
                pa2.SqlDbType = SqlDbType.Date
                pa2.Value = Date.Now
                ca.Parameters.Add(pa2)

                ca.ExecuteNonQuery()

                lblsolde.Text = Val(lblsolde.Text) + Val(txt_montant.Text)
                affiche_operation()
                chaine_connection()
                Dim c As New SqlCommand
                c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Alimentation du Solde du Batiment N° " & Cbx_bat.Text & "','" & Date.Now & "')"
                c.Connection = conx
                c.ExecuteNonQuery()
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_montant.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Veuillez entrer un batiment existant dans base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Form_Gestion_comptes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche_operation()
        chaine_connection()
        Dim com As New SqlCommand()
        com.CommandText = "select CODE_BAT from BATIMENT where STATUT='Abonné'"
        com.CommandType = CommandType.Text
        com.Connection = conx
        Dim dr As SqlDataReader = com.ExecuteReader
        Cbx_bat.Items.Clear()
        While (dr.Read)
            Cbx_bat.Items.Add(dr.Item(0))
        End While
        dr.Close()

    End Sub

    Private Sub Cbx_bat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_bat.SelectedIndexChanged
        chaine_connection()
        Dim c As New SqlCommand
        c.CommandText = "select SOLDE from BATIMENT WHERE CODE_BAT=@num"
        c.Connection = conx
        Dim p As New SqlParameter
        p.ParameterName = "@num"
        p.SqlDbType = SqlDbType.NVarChar
        p.Value = Cbx_bat.Text
        c.Parameters.Add(p)
        lblsolde.Text = c.ExecuteScalar().ToString()

        chaine_connection()

        Dim cmnd12 As New SqlCommand
        cmnd12.CommandText = "select NUM_CL from BATIMENT where CODE_BAT=@cod"
        cmnd12.Connection = conx

        Dim param12 As New SqlParameter
        param12.ParameterName = "@cod"
        param12.SqlDbType = SqlDbType.NVarChar
        param12.Value = Cbx_bat.SelectedItem
        cmnd12.Parameters.Add(param12)

        lbl_Num_CL.Text = cmnd12.ExecuteScalar().ToString()
        chaine_connection()
        Dim cmnd121 As New SqlCommand
        cmnd121.CommandText = "select NOM_CL from CLIENT where NUM_CL=@num"
        cmnd121.Connection = conx

        Dim param121 As New SqlParameter
        param121.ParameterName = "@num"
        param121.SqlDbType = SqlDbType.NVarChar
        param121.Value = lbl_Num_CL.Text
        cmnd121.Parameters.Add(param121)
        chaine_connection()

        lbl_Nom_CL.Text = cmnd121.ExecuteScalar().ToString()

        Dim cmnd1211 As New SqlCommand
        cmnd1211.CommandText = "select PRENOM_CL from CLIENT where NUM_CL=@num1"
        cmnd1211.Connection = conx

        Dim param1211 As New SqlParameter
        param1211.ParameterName = "@num1"
        param1211.SqlDbType = SqlDbType.NVarChar
        param1211.Value = lbl_Num_CL.Text
        cmnd1211.Parameters.Add(param1211)

        lbl_Prenom_CL.Text = cmnd1211.ExecuteScalar().ToString()
        chaine_connection()
        Dim cmnd12111 As New SqlCommand
        cmnd12111.CommandText = "select PHOTO_CL as photo from CLIENT where NUM_CL=@n1"
        cmnd12111.Connection = conx

        Dim param12111 As New SqlParameter
        param12111.ParameterName = "@n1"
        param12111.SqlDbType = SqlDbType.NVarChar
        param12111.Value = lbl_Num_CL.Text
        cmnd12111.Parameters.Add(param12111)
        Dim da = New SqlDataAdapter(cmnd12111)
        Dim ds As New DataTable
        da.Fill(ds)
        DataGridView1.DataSource = ds

        chaine_connection()
        Dim cmd As New SqlCommand("select ID_OP,CODE_BAT,NATURE_OP,MONTANT_OP,SOLDE,DATE_OP from OPERATION where CODE_BAT like '" & Cbx_bat.Text & "' order by DATE_OP desc")
        cmd.Connection = conx
        Dim dat = New SqlDataAdapter(cmd)
        Dim dst As New DataTable
        dat.Fill(dst)
        dgv_operation.DataSource = dst

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.default_avatar1
        Cbx_bat.Text = ""
        lbl_Num_CL.Text = ""
        lbl_Nom_CL.Text = ""
        lbl_Prenom_CL.Text = ""
        lblsolde.Text = ""
        affiche_operation()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.CurrentRow.Cells(0).Value.ToString <> "" Then


            If PictureBox1.Visible = True Then
                Dim img As Image
                Dim t() As Byte
                t = DataGridView1.CurrentRow.Cells(0).Value
                img = ByteArray2Image(t)
                PictureBox1.Image = img
            Else
                PictureBox1.Image = My.Resources.default_avatar1
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If Label1.Text <> "" Then
                Form_Impression_recu_versement.ShowDialog()
            Else
                MessageBox.Show("Veuillez selectionner un élément pour Imprimer sa Facture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form_Gestion_comptes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        lbl_Nom_CL.Text = ""
        lbl_Num_CL.Text = ""
        lbl_Prenom_CL.Text = ""
        lblsolde.Text = ""
        txt_montant.Text = ""
        Cbx_bat.Text = ""
        PictureBox1.Image = My.Resources.default_avatar1
    End Sub

    Private Sub dgv_operation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_operation.CellClick
        Label1.Text = dgv_operation.CurrentRow.Cells(0).Value.ToString()
    End Sub
End Class