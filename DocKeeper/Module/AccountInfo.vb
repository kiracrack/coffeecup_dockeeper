Imports System.IO

Module AccountInfo
    Public screenHeight As Integer
    Public screenWidth As Integer
    Public screenres As String
    Public globallogin As Boolean
    Public PasswordProtectConfirmed As Boolean
    Public globaluserid As String
    Public globalusername As String
    Public globalfullname As String
    Public globalposition As String
    Public globaladminuser As Boolean
    Public GlobalOrganizationName As String
    Public GlobalOrganizationOffice As String
    Public GlobalOrganizationTelephone As String
    Public GlobalOrganizationAddress As String
    Public GlobalDatabaseLocation As String
    Public GlobalReportHeaderCenterAlignment As Boolean

    Public GlobalAllowableAttachSize As Double
    Public ZIPFILE_LOCATION As String = Application.StartupPath.ToString & "\Archieved\"

    Public Sub check_win()
        screenHeight = My.Computer.Screen.Bounds.Height
        screenWidth = My.Computer.Screen.Bounds.Width
        screenres = "236," + screenHeight
    End Sub

    Public Function LoadAccountDetails(ByVal userid As String)
        com.CommandText = "select * from tblaccounts where accountid='" & userid & "'" : rst = com.ExecuteReader
        While rst.Read
            globalfullname = rst("fullname").ToString
            globalposition = StrConv(rst("position").ToString, vbProperCase)
            globalusername = rst("username").ToString
            globaladminuser = rst("adminuser")
        End While
        rst.Close()

        com.CommandText = "select * from tblgeneralsettings" : rst = com.ExecuteReader
        While rst.Read
            GlobalOrganizationName = rst("orgname").ToString
            GlobalOrganizationOffice = rst("orgoffice").ToString
            GlobalOrganizationTelephone = rst("orgtelephone").ToString
            GlobalOrganizationAddress = rst("orgaddress").ToString
            GlobalAllowableAttachSize = rst("allowableattachsize").ToString
            GlobalReportHeaderCenterAlignment = rst("headercenter")
            GlobalDatabaseLocation = rst("archiveddir").ToString
        End While
        rst.Close()

        Return 0
    End Function
      
    Public Sub userexit()
        globallogin = False
        globalfullname = ""
        globalposition = ""
        globalusername = ""
        conn.Close()
    End Sub
End Module

