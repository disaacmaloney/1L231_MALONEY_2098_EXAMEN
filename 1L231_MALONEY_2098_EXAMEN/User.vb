Public Class User
    Private var_db As New DB()

    Private _ID_USER As Integer
    Private _COD_TEACHER As String
    Private _USE_NAME As String
    Private _USE_LASTNAME As String
    Private _USE_ADDRESS As String
    Private _USE_PHONE As String
    Private _USE_EMAIL As String
    Private _ID_DITRICT As Integer
    Private _USE_SALARIE As Double
    Private _USE_STATE As String


    Public Property ID_USER() As Integer
        Get
            Return _ID_USER
        End Get
        Set(value As Integer)
            _ID_USER = value
        End Set
    End Property

    Public Property COD_TEACHER() As String
        Get
            Return _COD_TEACHER
        End Get
        Set(value As String)
            _COD_TEACHER = value
        End Set
    End Property

    Public Property USE_NAME() As String
        Get
            Return _USE_NAME
        End Get
        Set(value As String)
            _USE_NAME = value
        End Set
    End Property

    Public Property USE_LASTNAME() As String
        Get
            Return _USE_LASTNAME
        End Get
        Set(value As String)
            _USE_LASTNAME = value
        End Set
    End Property

    Public Property USE_ADDRESS() As String
        Get
            Return _USE_ADDRESS
        End Get
        Set(value As String)
            _USE_ADDRESS = value
        End Set
    End Property

    Public Property USE_PHONE() As String
        Get
            Return _USE_PHONE
        End Get
        Set(value As String)
            _USE_PHONE = value
        End Set
    End Property

    Public Property USE_EMAIL() As String
        Get
            Return _USE_EMAIL
        End Get
        Set(value As String)
            _USE_EMAIL = value
        End Set
    End Property

    Public Property ID_DITRICT() As Integer
        Get
            Return _ID_DITRICT
        End Get
        Set(value As Integer)
            _ID_DITRICT = value
        End Set
    End Property

    Public Property USE_SALARIE() As Double
        Get
            Return _USE_SALARIE
        End Get
        Set(value As Double)
            _USE_SALARIE = value
        End Set
    End Property

    Public Property USE_STATE() As String
        Get
            Return _USE_STATE
        End Get
        Set(value As String)
            _USE_STATE = value
        End Set
    End Property

    Public Function getUser() As DataTable

        Dim dtUser As DataTable
        dtUser = New DataTable()
        dtUser = var_db.getList("SP_USER_GET")
        Return dtUser

    End Function

    Public Function getUserByCod(codTeacher As String, typeUser As String) As DataTable

        Dim dtUser As DataTable
        dtUser = New DataTable()
        dtUser = var_db.getUserByCod("SP_USERS_GET_BY_ID", codTeacher, typeUser)
        Return dtUser

    End Function



End Class
