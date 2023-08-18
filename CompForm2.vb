Imports MySql.Data.MySqlClient

'Display client clinical data
Public Class CompForm2
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim formName As String = "EYE HEALTH EXAMINATION FORM"

    Private Sub CompForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clinic name
        lblTitle.Text = frmUAC.clinic_name.ToUpper & vbCrLf & formName
        'Extenal exam data
        txtOdLids.Text = frmConsultView.OdLids
        txtOsLids.Text = frmConsultView.OsLids
        txtOdConjuct.Text = frmConsultView.OdConjuct
        txtOsConjuct.Text = frmConsultView.OsConjuct
        txtOdCornea.Text = frmConsultView.OdCornea
        txtOsCornea.Text = frmConsultView.OsCornea
        txtOdAc.Text = frmConsultView.OdAc
        txtOsAc.Text = frmConsultView.OsAc
        txtOdIris.Text = frmConsultView.OdIris
        txtOsIris.Text = frmConsultView.OsIris
        txtOdPupil.Text = frmConsultView.OdPupil
        txtOsPupil.Text = frmConsultView.OsPupil
        txtOsIris.Text = frmConsultView.OsIris
        txtOdLens.Text = frmConsultView.OdLens
        txtOsLens.Text = frmConsultView.OsLens

        'Internal exam data
        txtOdVitr.Text = frmConsultView.OdVitr
        txtOsVitr.Text = frmConsultView.OsVitr
        txtOdDisc.Text = frmConsultView.OdDisc
        txtOsDisc.Text = frmConsultView.OsDisc
        txtOdCd.Text = frmConsultView.OdCd
        txtOsCd.Text = frmConsultView.OsCd
        txtOdRim.Text = frmConsultView.OdRim
        txtOsRim.Text = frmConsultView.OsRim
        txtOdAv.Text = frmConsultView.OdAv
        txtOsAv.Text = frmConsultView.OsAv
        txtOdPeripap.Text = frmConsultView.OdPeripap
        txtOsPeripap.Text = frmConsultView.OsPeripap
        txtOdMacular.Text = frmConsultView.OdMacular
        txtOsMacular.Text = frmConsultView.OsMacular
        txtOdPeriRet.Text = frmConsultView.OdPeriRet
        txtOsPeriRet.Text = frmConsultView.OsPeriRet

        'Impression/diagnosis data
        txtDx.Text = frmConsultView.Dx

        'Prescription/management data
        txtPx.Text = frmConsultView.Px

        'Clinical comments data
        txtComments.Text = frmConsultView.Comments
    End Sub

End Class