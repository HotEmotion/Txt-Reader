Public Class User
    'UNum, UName, UPass, UEmail, UVIP, UBNum
    Private _uNum As Integer
    Private _uName As String
    Private _uPass As String
    Private _uEmail As String
    Private _uVIP As Boolean
    Private _uBNum As Integer

    Public Property UNum As Integer
        Get
            Return _uNum
        End Get
        Set(value As Integer)
            _uNum = value
        End Set
    End Property

    Public Property UName As String
        Get
            Return _uName
        End Get
        Set(value As String)
            _uName = value
        End Set
    End Property

    Public Property UPass As String
        Get
            Return _uPass
        End Get
        Set(value As String)
            _uPass = value
        End Set
    End Property

    Public Property UEmail As String
        Get
            Return _uEmail
        End Get
        Set(value As String)
            _uEmail = value
        End Set
    End Property

    Public Property UVIP As Boolean
        Get
            Return _uVIP
        End Get
        Set(value As Boolean)
            _uVIP = value
        End Set
    End Property

    Public Property UBNum As Integer
        Get
            Return _uBNum
        End Get
        Set(value As Integer)
            _uBNum = value
        End Set
    End Property
End Class
