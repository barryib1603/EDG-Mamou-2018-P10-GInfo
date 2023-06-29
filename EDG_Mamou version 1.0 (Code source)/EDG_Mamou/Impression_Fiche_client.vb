Public Class Impression_Fiche_client

    Private Sub Impression_Fiche_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.CLIENT1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENT1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.CLIENT1, Param1:=Form2_menu_principal.UserControl1_client1.dgvclients.CurrentRow.Cells(0).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class