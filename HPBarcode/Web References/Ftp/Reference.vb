﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3607
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.3607.
'
Namespace Ftp
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="FtpSoap", [Namespace]:="http://202.90.116.86:8010/VendingService")>  _
    Partial Public Class Ftp
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://203.130.133.90/VendingService/Ftp.asmx"
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://202.90.116.86:8010/VendingService/Browse", RequestNamespace:="http://202.90.116.86:8010/VendingService", ResponseNamespace:="http://202.90.116.86:8010/VendingService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Browse(ByVal VirtualPath As String, ByVal FileExtension As FileExtensions, ByVal WithContent As Boolean) As FileInformation()
            Dim results() As Object = Me.Invoke("Browse", New Object() {VirtualPath, FileExtension, WithContent})
            Return CType(results(0),FileInformation())
        End Function
        
        '''<remarks/>
        Public Function BeginBrowse(ByVal VirtualPath As String, ByVal FileExtension As FileExtensions, ByVal WithContent As Boolean, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Browse", New Object() {VirtualPath, FileExtension, WithContent}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndBrowse(ByVal asyncResult As System.IAsyncResult) As FileInformation()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),FileInformation())
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://202.90.116.86:8010/VendingService/GetFile", RequestNamespace:="http://202.90.116.86:8010/VendingService", ResponseNamespace:="http://202.90.116.86:8010/VendingService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetFile(ByVal VirtualPath As String, ByVal FileName As String) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetFile", New Object() {VirtualPath, FileName})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Function BeginGetFile(ByVal VirtualPath As String, ByVal FileName As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetFile", New Object() {VirtualPath, FileName}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetFile(ByVal asyncResult As System.IAsyncResult) As Byte()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://202.90.116.86:8010/VendingService/UploadFile", RequestNamespace:="http://202.90.116.86:8010/VendingService", ResponseNamespace:="http://202.90.116.86:8010/VendingService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UploadFile(ByVal VirtualPath As String, ByVal Name As String, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Content() As Byte) As String
            Dim results() As Object = Me.Invoke("UploadFile", New Object() {VirtualPath, Name, Content})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginUploadFile(ByVal VirtualPath As String, ByVal Name As String, ByVal Content() As Byte, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("UploadFile", New Object() {VirtualPath, Name, Content}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndUploadFile(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://202.90.116.86:8010/VendingService/DirectoryExists", RequestNamespace:="http://202.90.116.86:8010/VendingService", ResponseNamespace:="http://202.90.116.86:8010/VendingService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DirectoryExists(ByVal Path As String) As Boolean
            Dim results() As Object = Me.Invoke("DirectoryExists", New Object() {Path})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginDirectoryExists(ByVal Path As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DirectoryExists", New Object() {Path}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndDirectoryExists(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://202.90.116.86:8010/VendingService/FileExists", RequestNamespace:="http://202.90.116.86:8010/VendingService", ResponseNamespace:="http://202.90.116.86:8010/VendingService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FileExists(ByVal Path As String, ByVal FileName As String) As Boolean
            Dim results() As Object = Me.Invoke("FileExists", New Object() {Path, FileName})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginFileExists(ByVal Path As String, ByVal FileName As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("FileExists", New Object() {Path, FileName}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndFileExists(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
    End Class
    
    '''<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://202.90.116.86:8010/VendingService")>  _
    Public Enum FileExtensions
        
        '''<remarks/>
        htm
        
        '''<remarks/>
        html
        
        '''<remarks/>
        asp
        
        '''<remarks/>
        aspx
        
        '''<remarks/>
        jpg
        
        '''<remarks/>
        gif
        
        '''<remarks/>
        dll
        
        '''<remarks/>
        exe
        
        '''<remarks/>
        xml
        
        '''<remarks/>
        all
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://202.90.116.86:8010/VendingService")>  _
    Partial Public Class FileInformation
        
        Private nameField As String
        
        Private sizeField As Long
        
        Private creadedDateField As Date
        
        Private lastModifiedField As Date
        
        Private lastAccessField As Date
        
        Private fileTypeField As String
        
        Private fileLocationField As String
        
        Private fileContentField() As Byte
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Size() As Long
            Get
                Return Me.sizeField
            End Get
            Set
                Me.sizeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CreadedDate() As Date
            Get
                Return Me.creadedDateField
            End Get
            Set
                Me.creadedDateField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastModified() As Date
            Get
                Return Me.lastModifiedField
            End Get
            Set
                Me.lastModifiedField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastAccess() As Date
            Get
                Return Me.lastAccessField
            End Get
            Set
                Me.lastAccessField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FileType() As String
            Get
                Return Me.fileTypeField
            End Get
            Set
                Me.fileTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FileLocation() As String
            Get
                Return Me.fileLocationField
            End Get
            Set
                Me.fileLocationField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")>  _
        Public Property FileContent() As Byte()
            Get
                Return Me.fileContentField
            End Get
            Set
                Me.fileContentField = value
            End Set
        End Property
    End Class
End Namespace
