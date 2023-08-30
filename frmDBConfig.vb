Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports MySql.Data.MySqlClient
Imports OptoRec_1.My

'Configure, create and test database settings
Public Class frmDBConfig
    Dim sqlCommand As New MySqlCommand
    Dim sqlCon As New MySqlConnection
    Dim server, uid, port, password As String
    Private Sub frmDBConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Select()
        My.Settings.Reload()
        txtServer.PlaceholderText = My.Settings.setServer
        txtPort.PlaceholderText = My.Settings.setPort
        txtUID.PlaceholderText = My.Settings.setUID
    End Sub

    'Check connection string
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim dialog As DialogResult
        Try
            sqlCon.ConnectionString = "server=" & txtServer.Text & ";port=" & txtPort.Text & ";userid=" & txtUID.Text & ";password=" & txtPassword.Text & ";database=;"
            sqlCon.Open()
            MessageBox.Show("Successful connection!")
            sqlCon.Close()
            'Save connection string
            My.Settings.setServer = txtServer.Text
            My.Settings.setPort = txtPort.Text
            My.Settings.setUID = txtUID.Text
            My.Settings.setPassword = txtPassword.Text
            My.Settings.setDB = "opto_rec_1"
            My.Settings.Save()
            btnCreate.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            My.Settings.Reset()
            btnTest.Enabled = False
            btnCreate.Enabled = False
        Finally
            sqlCon.Dispose()
        End Try

        'Check database connection
        Try
            DB.sqlConnect.Open()
            DB.sqlConnect.Close()
            btnCreate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dialog = MessageBox.Show("Click 'OK' to apply connection settings and restart application in order to setup a database", "Exit",
                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialog = DialogResult.OK Then
                Windows.Forms.Application.Restart()
            End If
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub

    'Setup database
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sqlQuery As String = "CREATE DATABASE IF NOT EXISTS opto_rec_1; USE opto_rec_1;
                                    CREATE TABLE IF NOT EXISTS acc_info(
                                    account_id INT AUTO_INCREMENT,
                                    clinic_name VARCHAR(50) DEFAULT 'Unknown',
                                    owner VARCHAR(50),																									
                                    location VARCHAR(100),
                                    clinician VARCHAR(50),
                                    phone_num VARCHAR(30),
                                    email VARCHAR(50),
                                    added_on TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                    PRIMARY KEY (account_id)
                                    );
                                    CREATE TABLE IF NOT EXISTS passwords(
                                    account_id INT AUTO_INCREMENT,
                                    username VARCHAR(50) NOT NULL UNIQUE,
                                    password1 VARCHAR(50) NOT NULL UNIQUE,
                                    password2 VARCHAR(50) NOT NULL UNIQUE,
                                    PRIMARY KEY (account_id)
                                    );
                                    CREATE TABLE IF NOT EXISTS biodata(
                                    account_id INT,
                                    client_id INT AUTO_INCREMENT,
                                    card_num VARCHAR(10) UNIQUE,
                                    first_name VARCHAR(50),
                                    surname VARCHAR(50),
                                    other_name VARCHAR(50),
                                    job VARCHAR(50),
                                    birth_date DATE,
                                    gender ENUM('Male', 'Female'),
                                    phone_num VARCHAR(30),
                                    religion VARCHAR(50),
                                    email VARCHAR(50),
                                    added_on TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                    PRIMARY KEY (client_id)
                                    );
                                    CREATE TABLE IF NOT EXISTS cardio_vasc(
                                    client_id INT,
                                    consult_id INT,
                                    bp VARCHAR(7),
                                    sugar DEC(5,2)
                                    );
                                    CREATE TABLE IF NOT EXISTS va_exam(
                                    client_id INT,
                                    consult_id INT,
                                    outer_pd INT,
                                    inner_pd INT,
                                    od_mono_pd INT,
                                    os_mono_pd INT,
                                    od_unaided VARCHAR(10),
                                    os_unaided VARCHAR(10),
                                    od_aided VARCHAR(10),
                                    os_aided VARCHAR(10),
                                    od_plus_one VARCHAR(10),
                                    os_plus_one VARCHAR(10),
                                    od_pinhole VARCHAR(10),
                                    os_pinhole VARCHAR(10)
                                    );
                                    CREATE TABLE IF NOT EXISTS patient_hist(
                                    client_id INT,
                                    consult_id INT,
                                    pc_cc VARCHAR(255),
                                    hpc VARCHAR(255),
                                    odq VARCHAR(255),
                                    poh VARCHAR(255),
                                    pmh_psh VARCHAR(255),
                                    dh VARCHAR(255),
                                    allergy	VARCHAR(255),
                                    sh VARCHAR(255),
                                    foh VARCHAR(255),
                                    fmh VARCHAR(255),
                                    ddx VARCHAR(255)
                                    );
                                    CREATE TABLE IF NOT EXISTS ext_exam(
                                    client_id INT,
                                    consult_id INT,
                                    od_lids VARCHAR(255),
                                    od_conjuct VARCHAR(255),
                                    od_cornea VARCHAR(255),
                                    od_ac VARCHAR(255),
                                    od_iris VARCHAR(255),
                                    od_pupil VARCHAR(255),
                                    od_lens VARCHAR(255),
                                    os_lids VARCHAR(255),
                                    os_conjuct VARCHAR(255),
                                    os_cornea VARCHAR(255),
                                    os_ac VARCHAR(255),
                                    os_iris VARCHAR(255),
                                    os_pupil VARCHAR(255),
                                    os_lens VARCHAR(255)
                                    );
                                    CREATE TABLE IF NOT EXISTS int_exam(
                                    client_id INT,
                                    consult_id INT,
                                    od_vitr VARCHAR(255),
                                    od_disc VARCHAR(255),
                                    od_cd VARCHAR(255),
                                    od_rim VARCHAR(255),
                                    od_av VARCHAR(255),
                                    od_peripap VARCHAR(255),
                                    od_macular VARCHAR(255),
                                    od_peri_ret VARCHAR(255),
                                    os_vitr VARCHAR(255),
                                    os_disc VARCHAR(255),
                                    os_cd VARCHAR(255),
                                    os_rim VARCHAR(255),
                                    os_av VARCHAR(255),
                                    os_peripap VARCHAR(255),
                                    os_macular VARCHAR(255),
                                    os_peri_ret VARCHAR(255)
                                    );
                                    CREATE TABLE IF NOT EXISTS dx_mngmnt(
                                    client_id INT,
                                    consult_id INT,
                                    dx VARCHAR(255),
                                    px_mngmnt VARCHAR(255),
                                    comments VARCHAR(255)
                                    );
                                    CREATE TABLE IF NOT EXISTS consult(
                                    consult_id INT AUTO_INCREMENT,
                                    added_on TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                    PRIMARY KEY (consult_id)
                                    );
                                    CREATE TABLE IF NOT EXISTS message(
                                    account_id INT,
                                    message VARCHAR(1000)
                                    );
                                    CREATE TABLE IF NOT EXISTS acc_info_archive(
                                    account_id INT,
                                    clinic_name VARCHAR(50),
                                    owner VARCHAR(50),																									
                                    location VARCHAR(100),
                                    clinician VARCHAR(50),
                                    phone_num VARCHAR(30),
                                    email VARCHAR(50),
                                    added_on TIMESTAMP
                                    );
                                    CREATE TABLE IF NOT EXISTS passwords_archive(
                                    account_id INT,
                                    username VARCHAR(50),
                                    password1 VARCHAR(50),
                                    password2 VARCHAR(50)
                                    );
                                    CREATE TABLE IF NOT EXISTS biodata_archive(
                                    account_id INT,
                                    client_id INT,
                                    card_num VARCHAR(10),
                                    first_name VARCHAR(50),
                                    surname VARCHAR(50),
                                    other_name VARCHAR(50),
                                    job VARCHAR(50),
                                    birth_date DATE,
                                    gender ENUM('Male', 'Female'),
                                    phone_num VARCHAR(30),
                                    religion VARCHAR(50),
                                    email VARCHAR(50),
                                    added_on TIMESTAMP
                                    );"
        My.Settings.Reload()
        Try
            DB.sqlConnect.Open()
            sqlCommand.CommandText = sqlQuery
            sqlCommand = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Database successfully created")
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    'Clear text, reset connection string
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtServer.Text = ""
        txtPort.Text = ""
        txtUID.Text = ""
        txtPassword.Text = ""
        My.Settings.setServer = txtServer.Text
        My.Settings.setPort = txtPort.Text
        My.Settings.setUID = txtUID.Text
        My.Settings.setPassword = txtPassword.Text
        My.Settings.Save()
        btnTest.Enabled = True
        btnCreate.Enabled = True
    End Sub

    'Apply settings and exit
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to apply configuration settings? If 'Yes' application will be restarted.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Windows.Forms.Application.Restart()
        End If
    End Sub

End Class