Imports MySql.Data.MySqlClient

Public Class db_config
    Public con As New MySqlConnection("server= localhost; user id = 'root'; password= '';database=db_rrms;")
    'Public con As New MySqlConnection("server= 192.168.0.100; user id = 'loyd'; password= 'loyd';database=db_sboam;")

    Sub New()

    End Sub



    Public Function getCon()
        Return con
    End Function
End Class
