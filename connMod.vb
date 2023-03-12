Imports System.Data
Imports System.Data.SqlClient

Module connMod

    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public reader As SqlDataReader
    Public ds As New DataSet
    Public adapter As New SqlDataAdapter

    Public query, user As String

End Module
