Public Class Book
    'BNum, BName, BPath, BCount, BType, BAttr
    Private _bNum As Integer
    Private _bName As String
    Private _bPath As String
    Private _bCount As Integer
    Private _bType As String
    Private _bAttr As String
    Private _bPer As String
    Public Property BNum As Integer
        Get
            Return _bNum
        End Get
        Set(value As Integer)
            _bNum = value
        End Set
    End Property

    Public Property BName As String
        Get
            Return _bName
        End Get
        Set(value As String)
            _bName = value
        End Set
    End Property

    Public Property BPath As String
        Get
            Return _bPath
        End Get
        Set(value As String)
            _bPath = value
        End Set
    End Property

    Public Property BCount As Integer
        Get
            Return _bCount
        End Get
        Set(value As Integer)
            _bCount = value
        End Set
    End Property

    Public Property BType As Integer
        Get
            Return _bType
        End Get
        Set(value As Integer)
            _bType = value
        End Set
    End Property


    Public Property BPer As String
        Get
            Return _bPer
        End Get
        Set(value As String)
            _bPer = value
        End Set
    End Property

    Public Property BAttr As String
        Get
            Return _bAttr
        End Get
        Set(value As String)
            _bAttr = value
        End Set
    End Property
End Class
