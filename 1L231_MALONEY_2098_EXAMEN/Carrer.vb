Public Class Carrer
    Dim CAR_NAME, CAR_CODIGO As String
    Dim ID_CAREER, ID_FACULTY As Integer
    Private var_db As New DB()
    Public Property _CAR_NAME As String
        Get
            Return CAR_NAME
        End Get
        Set(value As String)
            CAR_NAME = value
        End Set
    End Property

    Public Property _CAR_CODIGO As String
        Get
            Return CAR_CODIGO
        End Get
        Set(value As String)
            CAR_CODIGO = value
        End Set
    End Property

    Public Property _ID_CAREER As Integer
        Get
            Return ID_CAREER
        End Get
        Set(value As Integer)
            ID_CAREER = value
        End Set
    End Property

    Public Property _ID_FACULTY As Integer
        Get
            Return ID_FACULTY
        End Get
        Set(value As Integer)
            ID_FACULTY = value
        End Set
    End Property

    Public Function getCarrer(ID_FACULTY As String) As DataTable
        Dim dtCarrer As DataTable
        dtCarrer = New DataTable()
        dtCarrer = var_db.getCareer(ID_FACULTY)
        Return dtCarrer
    End Function

    Public Function getCarrerById(ID_CAREER As String) As DataTable
        Dim dtCarrer As DataTable
        dtCarrer = New DataTable()
        dtCarrer = var_db.getCareerById(ID_CAREER)
        Return dtCarrer
    End Function

    Public Function postCarrerNew(CAR_NAME As String, CAR_CODIGO As String, ID_FACULTY As String) As Boolean
        Return var_db.postCareerNew(CAR_NAME, CAR_CODIGO, ID_FACULTY)
    End Function




End Class
