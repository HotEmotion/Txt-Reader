Imports System.Data.SqlClient
Imports System.Configuration
Public Class SqlHelper
    Private ReadOnly con As String = "Data Source=DESKTOP-71FFAUM;Initial Catalog=小说阅读器;Integrated Security=True"
    Dim SqlCon As SqlConnection = New SqlConnection(con)
    Dim SqlCmd As SqlCommand = New SqlCommand
    ''' <summary>
    ''' 关闭命令SqlCmd
    ''' </summary>
    ''' <param name="cmd"></param>
    Public Sub CloseCmd(ByVal cmd As SqlCommand)
        If Not IsNothing(cmd) Then
            cmd.Dispose()
            cmd = Nothing
        End If
    End Sub
    ''' <summary>
    ''' 关闭连接
    ''' </summary>
    ''' <param name="con"></param>
    Public Sub CloseCon(ByVal con As SqlConnection)
        If (con.State <> ConnectionState.Closed) Then
            con.Close()
            con = Nothing
        End If
    End Sub
    ''' <summary>
    ''' 执行增删改 无参数 
    ''' </summary>
    ''' <param name="cmdText">字符连接串</param>
    ''' <returns></returns>
    Public Function ExecuteNonQuery(ByVal cmdText As String) As Integer
        SqlCmd.CommandText = cmdText
        SqlCmd.Connection = SqlCon
        Try
            SqlCon.Open()
            Return SqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        Finally
            Call CloseCon(SqlCon)
            Call CloseCmd(SqlCmd)
        End Try
    End Function
    ''' <summary>
    ''' 用于查询 无参数
    ''' </summary>
    ''' <param name="cmdText"></param>
    ''' <returns>返回的是DataTable</returns>
    Public Function ExecuteDataAdapter(ByRef cmdText As String) As DataTable
        Dim sqlAdapter As SqlDataAdapter
        Dim ds As New DataSet
        SqlCmd.CommandText = cmdText
        SqlCmd.Connection = SqlCon
        sqlAdapter = New SqlDataAdapter(SqlCmd)

        Try
            sqlAdapter.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
        Finally
            Call CloseCmd(SqlCmd)
        End Try
    End Function
    ''' <summary>
    ''' 用于查询 
    ''' </summary>
    ''' <param name="cmdText"></param>
    ''' <returns>返回的是SqlReader</returns>
    Public Function ExecuteSqlReader(ByRef cmdText As String) As SqlDataReader
        Dim Sqlcon As SqlConnection = New SqlConnection(con)
        Sqlcon.Open()
        Dim SqlCmd As SqlCommand = New SqlCommand(cmdText, Sqlcon)
        Return SqlCmd.ExecuteReader
        Call CloseCmd(SqlCmd)
        Call CloseCon(Sqlcon)
    End Function
    ''' <summary>
    ''' 用于执行数据库中的聚合函数
    ''' </summary>
    ''' <param name="cmdText"></param>
    ''' <returns>返回的是首行内容</returns>
    Public Function ExecuteScalar(ByRef cmdText As String) As Object
        Dim SqlCon As SqlConnection = New SqlConnection(con)
        SqlCon.Open()
        Dim SqlCmd As SqlCommand = New SqlCommand(cmdText, SqlCon)
        Return SqlCmd.ExecuteScalar()
        Call CloseCmd(SqlCmd)
        Call CloseCon(SqlCon)
    End Function
End Class