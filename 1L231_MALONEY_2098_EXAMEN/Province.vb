Public Class Province
    Private var_db As New DB()
    Private var_id, var_name As String

    Public Property id() As String
        Get
            Return var_id
        End Get
        Set(value As String)
            var_id = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return var_name
        End Get
        Set(value As String)
            var_name = value
        End Set
    End Property

    Public Function getProvince() As DataTable

        Dim dtProvince As DataTable
        dtProvince = New DataTable()
        dtProvince = var_db.getList("SP_PROVINCE_GET")
        Return dtProvince

    End Function
End Class
