Public Class District
    Private var_db As New DB()
    Private var_id, var_name, var_id_province As String

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

    Public Property id_province() As String
        Get
            Return var_id_province
        End Get
        Set(value As String)
            var_id_province = value
        End Set
    End Property

    Public Function getDistrict(ID_PROVINCE As String) As DataTable

        Dim dtDistrict As DataTable
        dtDistrict = New DataTable()
        dtDistrict = var_db.getDistrict(ID_PROVINCE)

        Return dtDistrict

    End Function


End Class
