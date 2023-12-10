Public Class Faculty
    Private var_db As New DB()

    Private var_ID_FACULTY As Integer
    Private var_cod_faculty As String
    Private var_fac_name As String

    Public Property ID_FACULTY() As Integer
        Get
            Return var_ID_FACULTY
        End Get
        Set(ByVal value As Integer)
            var_ID_FACULTY = value
        End Set
    End Property

    Public Property cod_faculty() As String
        Get
            Return var_cod_faculty
        End Get
        Set(ByVal value As String)
            var_cod_faculty = value
        End Set
    End Property

    Public Property fac_name() As String
        Get
            Return var_fac_name
        End Get
        Set(ByVal value As String)
            var_fac_name = value
        End Set
    End Property

    Public Function getFaculty() As DataTable

        Dim dtFaculty As DataTable
        dtFaculty = New DataTable()
        dtFaculty = var_db.getFaculty()
        Return dtFaculty

    End Function

    Public Function getFacultyById(ID_FACULTY As String) As DataTable

        Dim dtFaculty As DataTable
        dtFaculty = New DataTable()
        dtFaculty = var_db.getFacultyById(ID_FACULTY)
        Return dtFaculty

    End Function

    Public Function postFacultyNew(FAC_NAME As String, FAC_CODIGO As String) As Boolean

        Return var_db.postFacultyNew(FAC_NAME, FAC_CODIGO)

    End Function

End Class
