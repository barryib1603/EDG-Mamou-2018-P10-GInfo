Public Class Form_Impression_fiche_personnel

  
    Private Sub Form_Impression_fiche_personnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.PERSONNEL1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNEL1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.PERSONNEL1, Param1:=Form2_menu_principal.Usercontroler2_personnel1.DGVPERSONNEL.CurrentRow.Cells(0).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class