Imports MySql.Data.MySqlClient

'MySQL connection string
Public Class DB
    Public Shared sqlConnect As New MySqlConnection("server=" & My.Settings.setServer & ";port=" & My.Settings.setPort & ";uid=" & My.Settings.setUID & ";password=" & My.Settings.setPassword &
                                          ";database=" & My.Settings.setDB & "")
End Class
