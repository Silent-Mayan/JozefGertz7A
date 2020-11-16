'*******************************************
'*******************************************
'Programmer: {Your name goes here}
'Course: ITSE 1332 (VB)
'Program purpose: {Program Purpose Goes here}
'*******************************************
'*******************************************

#Region "Compiler_Directives"
'*******************************************
Option Explicit On  'Forces explicit declaration of all variables in a file, or allows implicit declarations of variables
Option Strict On    'Restricts implicit data type conversions to only widening conversions, disallows late binding, and disallows implicit typing
Option Infer Off    'Disables the use of local type inference in declaring variables
#Disable Warning IDE1006    'Disables warnings over class naming convention for controls
'*******************************************
#End Region

Public Class frmGame
    Private bolOkToClose As Boolean = False


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        bolOkToClose = True
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not bolOkToClose Then
            MessageBox.Show("You must exit via the Menu 'Exit' button", "use the Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

End Class
