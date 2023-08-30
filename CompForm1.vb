Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.EntityFrameworkCore.Metadata.Internal
Imports MySql.Data.MySqlClient

'Display client clinical data
Public Class CompForm1
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim formName As String = "EYE HEALTH EXAMINATION FORM"

    Private Sub CompForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainComp.lblTitle.Select()

        'Clinic name
        txtCardNum.Text = frmConsultView.card_num
        txtFirstName.Text = frmConsultView.first_name
        txtSurname.Text = frmConsultView.surname
        txtOtherName.Text = frmConsultView.other_name
        txtBirthDate.Text = frmConsultView.birth_date
        txtBirthDate.Text = Replace(txtBirthDate.Text, " 00:00:00", "")
        txtAge.Text = frmConsultView.age
        txtGender.Text = frmConsultView.gender
        txtPhoneNum.Text = frmConsultView.phone_num
        txtJob.Text = frmConsultView.job
        txtReligion.Text = frmConsultView.religion
        txtEmail.Text = frmConsultView.email
        txtDate.Text = frmConsultView.added_on

        'Cardiovascular data
        txtBP.Text = frmConsultView.BP
        txtSugar.Text = frmConsultView.sugar

        'Visual acuity data
        txtPdOut.Text = frmConsultView.PdOut
        txtPdIn.Text = frmConsultView.PdIn
        txtRmono.Text = frmConsultView.RMono
        txtLmono.Text = frmConsultView.Lmono
        txtOdUnAid.Text = frmConsultView.OdUnAid
        txtOsUnAid.Text = frmConsultView.OsUnAid
        txtOdAided.Text = frmConsultView.OdAid
        txtOsAided.Text = frmConsultView.OsAid
        txtOdPin.Text = frmConsultView.OdPin
        txtOsPin.Text = frmConsultView.OsPin
        txtOdPlusOne.Text = frmConsultView.OdPlus
        txtOsPlusOne.Text = frmConsultView.OsPlus

        'Patient history data
        txtOdq.Text = frmConsultView.odq
        txtPC.Text = frmConsultView.pcCC
        txtHPC.Text = frmConsultView.HPC
        txtPOH.Text = frmConsultView.POH
        txtPMH.Text = frmConsultView.PMH
        txtDH.Text = frmConsultView.DH
        txtAllerg.Text = frmConsultView.Allerg
        txtSH.Text = frmConsultView.SH
        txtFOH.Text = frmConsultView.FOH
        txtFMH.Text = frmConsultView.FMH
        txtDdx.Text = frmConsultView.Ddx
    End Sub

End Class