<%@ WebHandler Language="VB" Class="GetPDF" %>

Imports System
Imports System.Web

Public Class GetPDF : Implements IHttpHandler
                   
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        context.Response.ContentType = "Application/pdf"
        context.Response.WriteFile(context.Session("Rapport"))
        context.Response.End()
    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property


End Class