

Imports System.Data.SqlClient

Public Class DataBasesAccess

    'MÉTODO QUE DEVOLVE A STRING COM A CONEXÃO À BASE DE DADOS
    'nota: pode haver várias SC; escolher qual a que se pretende usar
    Public Function ConnectionString() As String
        Dim SCuserNovo As String = "Data Source=DESKTOP-A077TH4\SQL2;Initial Catalog=F12.adamastor;User ID=karinabueno;Password=123; "

        Dim SCescola As String = "Data Source= DESKTOP-A077TH4\SQL2;Initial Catalog=bdKarinaVBPROD;User ID=karinabueno;Password=123;"

        Dim SCGata As String = "Data Source=DESKTOP-SBS9GUS\SQLEXPRESS;Initial Catalog=lojaChina;User ID=sa;Password=123;"

        'retornar a que é pretendida:
        Return SCescola

    End Function

    'MÉTODO QUE DEVOLVE A DATABLE A PARTIR DOS PARÂMETROS
    ' SC (string connection) e ssql (query à BD).
    Public Function BuscaDados(SC As String, ssql As String) As DataTable

        Dim Con As SqlConnection = New SqlConnection(SC)
        Con.Open()

        Dim cmd As SqlCommand = New SqlCommand(ssql, Con)

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()
        adapter.Fill(dt)

        adapter.Dispose()
        Con.Close()

        Return dt

    End Function
End Class




