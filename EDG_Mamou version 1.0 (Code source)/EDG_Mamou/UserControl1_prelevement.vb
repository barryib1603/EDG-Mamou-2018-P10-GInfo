Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization


Public Class UserControl1_prelevement

    Public objetDataSet As New DataSet
    Public objetRemDataSet As New DataSet
    Private objetDataTable As New DataTable
    'Private objetCB As New OleDb.OleDbCommandBuilder
    Private objetDataGridView As New DataGridView

    Private Sub SetupDataGridView() 'PARAMETRE DU DATAGRIDVIEW
        objetDataGridView.DataSource = Nothing


        'Presentation Colonnes Lignes:En-tete non visible
        objetDataGridView.RowHeadersVisible = False
        ' Disable editing features.
        objetDataGridView.AllowUserToAddRows = False
        objetDataGridView.AllowUserToDeleteRows = False
        objetDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        '______________________________________________________________________
        'Presentation Colonnes
        '_____________________________________________________________________________
        objetDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        objetDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        objetDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke
        objetDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        objetDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
        '________________________________________________________________________________________________
        '-------------------------------------------------------------------------------
        'Auto-generation des colonnes moins colonnes NumberFormat & DateTimeFormat
        With objetDataGridView
            .AutoGenerateColumns = False
            .DataSource = CultureInfo.GetCultures(CultureTypes.AllCultures)
            .Columns.Remove("NumberFormat")
            .Columns.Remove("DateTimeFormat")
        End With
    End Sub
    'variables pour impression
    'ne t'occupe des Combox,CheckBoxes et Images
    'tu peux sans essayer sans eux.
    'Simplement l'auteur du code qui n'est pas moi a prevu de gerer meme ces cas......
    Private oStringFormat As StringFormat
    Private oStringFormatComboBox As StringFormat
    Private oButton As Button
    Private oCheckbox As CheckBox
    Private oComboBox As ComboBox

    Private nTotalWidth As Int16
    Private nRowPos As Int16
    Private NewPage As Boolean
    Private nPageNo As Int16
    Private Header As String = "Header Test"
    Private sUserName As String = "Will"

    Private Sub DrawFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal RowsPerPage As Int32)

        Dim sPageNo As String = nPageNo.ToString + " of " + Math.Ceiling(objetDataGridView.Rows.Count / RowsPerPage).ToString

        ' Right Align - User Name
        e.Graphics.DrawString(sUserName, objetDataGridView.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, objetDataGridView.Font, e.MarginBounds.Width).Width), e.MarginBounds.Top + e.MarginBounds.Height + 7)

        ' Left Align - Date/Time
        e.Graphics.DrawString(Now.ToLongDateString + " " + Now.ToShortTimeString, objetDataGridView.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + e.MarginBounds.Height + 7)

        ' Center  - Page No. Info
        e.Graphics.DrawString(sPageNo, objetDataGridView.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, objetDataGridView.Font, e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top + e.MarginBounds.Height + 31)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cmb_recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_recherche.SelectedIndexChanged
        If Cmb_recherche.SelectedItem = "Date" Then
            cmb_annee_recherche_paie.Visible = True
            cmb_mois_recherche_paie.Visible = True
            cmb_jour_recherche_paie.Visible = True
            txt_recherche_paie.Visible = False
        Else
            cmb_annee_recherche_paie.Visible = False
            cmb_mois_recherche_paie.Visible = False
            cmb_jour_recherche_paie.Visible = False
            txt_recherche_paie.Visible = True
        End If
    End Sub

    Private Sub UserControl1_prelevement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chaine_connection()

        Dim cmn As New SqlCommand()
        cmn.CommandText = "select NUM_POSTE from POSTE"
        cmn.CommandType = CommandType.Text
        cmn.Connection = conx
        Dim dtrd As SqlDataReader = cmn.ExecuteReader
        cmb_poste.Items.Clear()
        While (dtrd.Read)
            cmb_poste.Items.Add(dtrd.Item(0))
        End While
        dtrd.Close()

        Cmb_recherche.SelectedItem = "Numéro"

        Dim jour As Integer
        Dim mois As Integer
        Dim anee As Integer

        cmb_jour_recherche_paie.Items.Clear()
        For jour = 1 To 31
            cmb_jour_recherche_paie.Items.Add(jour)
        Next
        cmb_mois_recherche_paie.Items.Clear()
        For mois = 1 To 12
            cmb_mois_recherche_paie.Items.Add(mois)
        Next
        cmb_annee_recherche_paie.Items.Clear()
        For anee = 2000 To (Year(Date.Today))
            cmb_annee_recherche_paie.Items.Add(anee)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If txtNumero_prelev.Text = "" Then
                MessageBox.Show("Veuillez entrer le numero du prelevement")
                txtNumero_prelev.Focus()
                Exit Sub
            End If
            If cmb_poste.Text = "" Then
                MessageBox.Show("Veuillez saisir le Poste de Prelevement")
                cmb_poste.Focus()
                Exit Sub
            End If
            If txtIo.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Intensité Io")
                txtIo.Focus()
                Exit Sub
            End If
            If txtI1.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Intensité I1")
                txtI1.Focus()
                Exit Sub
            End If

            If txtI2.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Intensité I2")
                txtI2.Focus()
                Exit Sub
            End If

            If txtI3.Text = "" Then
                MessageBox.Show("Veuillez entrer l'Intensité I3")
                txtI3.Focus()
                Exit Sub
            End If

            Call chaine_connection()


            Dim cmd0 As New SqlCommand("select * from PRELEVEMENT where(Num_prele=@numero)")
            cmd0.Connection = conx

            Dim param0 As New SqlParameter
            param0.ParameterName = "@numero"
            param0.SqlDbType = SqlDbType.NVarChar
            param0.Value = txtNumero_prelev.Text
            cmd0.Parameters.Add(param0)

            Dim lire As SqlDataReader = cmd0.ExecuteReader

            If (lire.Read) Then
                MessageBox.Show("Ce numero existe déjà")
                txtNumero_prelev.Focus()

                lire.Close()
                Exit Sub
            End If
            lire.Close()
            Dim cmd As New SqlCommand("Insert into PRELEVEMENT(Num_prele,I0,I1,I2,I3,NUM_POST,date_prelev) values(@numero,@Io,@I1,@I2, @I3,@poste,@date)")
            cmd.Connection = conx

            Dim param As New SqlParameter
            param.ParameterName = "@numero"
            param.SqlDbType = SqlDbType.NVarChar
            param.Value = txtNumero_prelev.Text
            cmd.Parameters.Add(param)

            Dim param1 As New SqlParameter
            param1.ParameterName = "@Io"
            param1.SqlDbType = SqlDbType.NVarChar
            param1.Value = txtIo.Text
            cmd.Parameters.Add(param1)

            Dim param2 As New SqlParameter
            param2.ParameterName = "@I1"
            param2.SqlDbType = SqlDbType.NVarChar
            param2.Value = txtI1.Text
            cmd.Parameters.Add(param2)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@I2"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtI2.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@I3"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtI3.Text
            cmd.Parameters.Add(param4)


            Dim param5 As New SqlParameter
            param5.ParameterName = "@poste"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = cmb_poste.Text
            cmd.Parameters.Add(param5)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@date"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = dtpprelev.Text
            cmd.Parameters.Add(param6)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Ajout du Prelevement N°:" & txtNumero_prelev.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("Enregistrement effectué avec succès")

            affiche_Prelevement()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If txtNumero_prelev.Text = "" Then
                MessageBox.Show("Veuillez entrer le Numero du prelevement")
                txtNumero_prelev.Focus()
                Exit Sub
            End If
            If cmb_poste.Text = "" Then
                MessageBox.Show("Veuillez choisir le poste")
                cmb_poste.Focus()
                Exit Sub
            End If
            If txtIo.Text = "" Then
                MessageBox.Show("Veuillez saisir l'intensité [IO] ")
                txtIo.Focus()
                Exit Sub
            End If
            If txtI1.Text = "" Then
                MessageBox.Show("Veuillez saisir l'intensité [I1] ")
                txtI1.Focus()
                Exit Sub
            End If

            If txtI2.Text = "" Then
                MessageBox.Show("Veuillez saisir l'intensité [I2] ")
                txtI2.Focus()
                Exit Sub
            End If

            If txtI3.Text = "" Then
                MessageBox.Show("Veuillez saisir l'intensité [I3] ")
                txtI3.Focus()
                Exit Sub
            End If

            chaine_connection()
            Dim cmd As New SqlCommand

            cmd.CommandText = "UPDATE PRELEVEMENT SET Num_prele=@numero, I0=@int0, I1=@int1,I2=@int2,I3=@int3,NUM_POST=@post,date_prelev=@dateP where ( Num_prele=@numero)"
            cmd.Connection = conx

            Dim param20 As New SqlParameter
            param20.ParameterName = "@numero"
            param20.SqlDbType = SqlDbType.NVarChar
            param20.Value = txtNumero_prelev.Text
            cmd.Parameters.Add(param20)

            Dim param21 As New SqlParameter
            param21.ParameterName = "@int0"
            param21.SqlDbType = SqlDbType.NVarChar
            param21.Value = txtIo.Text
            cmd.Parameters.Add(param21)

            Dim param22 As New SqlParameter
            param22.ParameterName = "@int1"
            param22.SqlDbType = SqlDbType.NVarChar
            param22.Value = txtI1.Text
            cmd.Parameters.Add(param22)

            Dim param3 As New SqlParameter
            param3.ParameterName = "@int2"
            param3.SqlDbType = SqlDbType.NVarChar
            param3.Value = txtI2.Text
            cmd.Parameters.Add(param3)

            Dim param4 As New SqlParameter
            param4.ParameterName = "@int3"
            param4.SqlDbType = SqlDbType.NVarChar
            param4.Value = txtI3.Text
            cmd.Parameters.Add(param4)

            Dim param6 As New SqlParameter
            param6.ParameterName = "@post"
            param6.SqlDbType = SqlDbType.NVarChar
            param6.Value = cmb_poste.Text
            cmd.Parameters.Add(param6)

            Dim param5 As New SqlParameter
            param5.ParameterName = "@dateP"
            param5.SqlDbType = SqlDbType.NVarChar
            param5.Value = dtpprelev.Text
            cmd.Parameters.Add(param5)

            cmd.ExecuteNonQuery()

            Dim c As New SqlCommand
            c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Modification des Informations du Prelevement N°" & txtNumero_prelev.Text & "','" & Date.Now & "')"
            c.Connection = conx
            c.ExecuteNonQuery()

            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES")

            affiche_Prelevement()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_sup.Click
        If dgv_prelevement.CurrentRow.Cells(0).Value.ToString <> "" Then
            Try
                Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment effectuer cette suppression ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmation = DialogResult.Yes Then
                    chaine_connection()
                    Dim cmd As New SqlCommand
                    cmd.CommandText = "delete from PRELEVEMENT where(Num_prele=@code)"
                    cmd.Connection = conx

                    Dim param As New SqlParameter
                    param.ParameterName = "@code"
                    param.SqlDbType = SqlDbType.NVarChar
                    param.Value = dgv_prelevement.CurrentRow.Cells(0).Value.ToString
                    cmd.Parameters.Add(param)

                    cmd.ExecuteNonQuery()

                    Dim c As New SqlCommand
                    c.CommandText = "insert into ACTIVITE_UTILISATEUR(UTILISATEUR,DESCRIPTION_ACT,DATE_ACT) values('" & nom_util & "','Suppression du Prelevement N° " & txtNumero_prelev.Text & "','" & Date.Now & "')"
                    c.Connection = conx
                    c.ExecuteNonQuery()
                    affiche_Prelevement()

                    MessageBox.Show("Suppression effectué avec Succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgv_prelevement_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prelevement.CellDoubleClick
        If dgv_prelevement.CurrentRow.Cells(0).Value.ToString <> "" Then
            txtNumero_prelev.Text = dgv_prelevement.CurrentRow.Cells(0).Value.ToString
            txtIo.Text = dgv_prelevement.CurrentRow.Cells(1).Value.ToString
            txtI1.Text = dgv_prelevement.CurrentRow.Cells(2).Value.ToString
            txtI2.Text = dgv_prelevement.CurrentRow.Cells(3).Value.ToString
            txtI3.Text = dgv_prelevement.CurrentRow.Cells(4).Value.ToString
            cmb_poste.Text = dgv_prelevement.CurrentRow.Cells(5).Value.ToString
            dtpprelev.Text = dgv_prelevement.CurrentRow.Cells(9).Value.ToString
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static oColumnLefts As New ArrayList
        Static oColumnWidths As New ArrayList
        Static oColumnTypes As New ArrayList
        Static nHeight As Int16

        Dim nWidth, i, nRowsPerPage As Int16
        Dim nTop As Int16 = e.MarginBounds.Top
        Dim nLeft As Int16 = e.MarginBounds.Left

        If nPageNo = 1 Then

            For Each oColumn As DataGridViewColumn In objetDataGridView.Columns

                nWidth = CType(Math.Floor(oColumn.Width / nTotalWidth * nTotalWidth * (e.MarginBounds.Width / nTotalWidth)), Int16)
                'nWidth = CType(Math.Floor(oColumn.Width / nTotalWidth * nTotalWidth * (e.MarginBounds.Width / nTotalWidth)), Int16)

                nHeight = e.Graphics.MeasureString(oColumn.HeaderText, oColumn.InheritedStyle.Font, nWidth).Height + 11

                oColumnLefts.Add(nLeft)
                oColumnWidths.Add(nWidth)
                oColumnTypes.Add(oColumn.GetType)
                nLeft += nWidth

            Next

        End If

        Do While nRowPos < objetDataGridView.Rows.Count - 1

            Dim oRow As DataGridViewRow = objetDataGridView.Rows(nRowPos)

            If nTop + nHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then

                DrawFooter(e, nRowsPerPage)

                NewPage = True
                nPageNo += 1
                e.HasMorePages = True
                Exit Sub

            Else

                If NewPage Then

                    ' Draw Header
                    e.Graphics.DrawString(Header, New Font(objetDataGridView.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(Header, New Font(objetDataGridView.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                    ' Draw Columns
                    nTop = e.MarginBounds.Top
                    i = 0
                    For Each oColumn As DataGridViewColumn In objetDataGridView.Columns

                        e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                        e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                        i += 1

                    Next
                    NewPage = False

                End If

                nTop += nHeight
                i = 0
                For Each oCell As DataGridViewCell In oRow.Cells

                    If oColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) OrElse oColumnTypes(i) Is GetType(DataGridViewLinkColumn) Then

                        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                    ElseIf oColumnTypes(i) Is GetType(DataGridViewButtonColumn) Then

                        oButton.Text = oCell.Value.ToString
                        oButton.Size = New Size(oColumnWidths(i), nHeight)
                        Dim oBitmap As New Bitmap(oButton.Width, oButton.Height)
                        oButton.DrawToBitmap(oBitmap, New Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))

                    ElseIf oColumnTypes(i) Is GetType(DataGridViewCheckBoxColumn) Then

                        oCheckbox.Size = New Size(14, 14)
                        oCheckbox.Checked = CType(oCell.Value, Boolean)
                        Dim oBitmap As New Bitmap(oColumnWidths(i), nHeight)
                        Dim oTempGraphics As Graphics = Graphics.FromImage(oBitmap)
                        oTempGraphics.FillRectangle(Brushes.White, New Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        oCheckbox.DrawToBitmap(oBitmap, New Rectangle(CType((oBitmap.Width - oCheckbox.Width) / 2, Int32), CType((oBitmap.Height - oCheckbox.Height) / 2, Int32), oCheckbox.Width, oCheckbox.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))

                    ElseIf oColumnTypes(i) Is GetType(DataGridViewComboBoxColumn) Then

                        oComboBox.Size = New Size(oColumnWidths(i), nHeight)
                        Dim oBitmap As New Bitmap(oComboBox.Width, oComboBox.Height)
                        oComboBox.DrawToBitmap(oBitmap, New Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i) + 1, nTop, oColumnWidths(i) - 16, nHeight), oStringFormatComboBox)

                    ElseIf oColumnTypes(i) Is GetType(DataGridViewImageColumn) Then

                        Dim oCellSize As Rectangle = New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight)
                        Dim oImageSize As Size = CType(oCell.Value, Image).Size
                        e.Graphics.DrawImage(oCell.Value, New Rectangle(oColumnLefts(i) + CType(((oCellSize.Width - oImageSize.Width) / 2), Int32), nTop + CType(((oCellSize.Height - oImageSize.Height) / 2), Int32), CType(oCell.Value, Image).Width, CType(oCell.Value, Image).Height))

                    End If

                    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))

                    i += 1

                Next

            End If

            nRowPos += 1
            nRowsPerPage += 1

        Loop

        DrawFooter(e, nRowsPerPage)

        e.HasMorePages = False

        'Dim myPaintArgs As New PaintEventArgs(e.Graphics, New Rectangle(New Point(0, 0), Me.Size))
        'Me.InvokePaint(Me.EMPLOYEDataGridView, myPaintArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            objetDataGridView = Nothing
            objetDataGridView = Me.dgv_prelevement
            Dim pD As New PrintDialog 'Document à imprimer
            Dim reSultat As DialogResult = pD.ShowDialog
            pD.Document = Me.PrintDocument1
            If reSultat = Windows.Forms.DialogResult.OK Then
                Me.PrintDocument1.Print()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_prelevement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prelevement.CellContentClick

    End Sub
End Class
