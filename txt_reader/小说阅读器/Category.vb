Public Class Category
    'CId, CName, CParentId
    Dim _cId As Integer
    Dim _cName As String
    Dim _cParentId As Integer
    Dim _cBNum As Integer
    Public Property CId As Integer
        Get
            Return _cId
        End Get
        Set(value As Integer)
            _cId = value
        End Set
    End Property

    Public Property CName As String
        Get
            Return _cName
        End Get
        Set(value As String)
            _cName = value
        End Set
    End Property

    Public Property CParentId As Integer
        Get
            Return _cParentId
        End Get
        Set(value As Integer)
            _cParentId = value
        End Set
    End Property

    Public Property CBNum As Integer
        Get
            Return _cBNum
        End Get
        Set(value As Integer)
            _cBNum = value
        End Set
    End Property
End Class
