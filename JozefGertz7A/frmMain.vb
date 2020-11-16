'*******************************************
'*******************************************
'Programmer: Jozef Gertz
'Course: ITSE 1332 10X1
'Program purpose: Jozef's Game Store. Allows the user to view and update specials as well as lets the user view some games that are for sell.
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
Imports System.IO
Public Class frmMain

    Private bolOkToClose As Boolean = False 'if this boolean value is false then the program will not close


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        bolOkToClose = True 'sets boolean value to true so that the program can close
        Application.Exit()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'prevents the program from being closed via the X
        If Not bolOkToClose Then
            MessageBox.Show("You must exit via the Menu 'Exit' button", "use the Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

    Private Sub StellarisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStellaris.Click

        Dim frmStellaris As New frmGame 'creates a new form for the game

        frmStellaris.Text = "Stellaris" 'names the form

        frmStellaris.lblGameName.Text = "Stellaris" 'lists the game's name in the label

        frmStellaris.lblGameDesc.Text = "This is a 4X strategy about building a Galactic Empire" 'Describes the game

        frmStellaris.pbxGameCover.Image = My.Resources.Stellaris 'sets an image for the game

        frmStellaris.ShowDialog()
    End Sub

    Private Sub Divinity2OriginalSinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDivinity.Click

        Dim frmDivinity2 As New frmGame 'creates a new form for the game

        frmDivinity2.Text = "Divinity2" 'names the form

        frmDivinity2.lblGameName.Text = "Divinity Original Sin: 2" 'lists the game's name in the label

        frmDivinity2.lblGameDesc.Text = "This is an immense RPG with fantastic turn based combat full of elemental ground based 
effects, and engaging story." 'Describes the game

        frmDivinity2.pbxGameCover.Image = My.Resources.Divinity2 'sets an image for the game

        frmDivinity2.ShowDialog()
    End Sub

    Private Sub TheElderScrollsIVOblivionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOblivion.Click

        Dim frmOblivion As New frmGame 'creates a new form for the game

        frmOblivion.Text = "Oblivion" 'names the form

        frmOblivion.lblGameName.Text = "The Elder Scrolls IV: Oblivion" 'lists the game's name in the label

        frmOblivion.lblGameDesc.Text = "A Classic Bethesda RPG. A great Story, but lackluster combat." 'Describes the game

        frmOblivion.pbxGameCover.Image = My.Resources.TES4 'sets an image for the game

        frmOblivion.ShowDialog()

    End Sub

    Private Sub mnuDisplaySpecials_Click(sender As Object, e As EventArgs) Handles mnuDisplaySpecials.Click

        Try

            If File.Exists("Specials.Txt") Then 'checks to see if the file exists

                Dim srSpecials As New StreamReader("Specials.Txt") 'creates a new streamreader
                Dim strLine As String = String.Empty

                Do Until srSpecials.EndOfStream 'runs the loop until there is nothing to read
                    strLine = srSpecials.ReadToEnd ' read's until the end and assigns it to the strLine variable
                Loop

                MessageBox.Show(strLine, "Specials", MessageBoxButtons.OK, MessageBoxIcon.Information) 'displays the contents of the txt file
                srSpecials.Close() 'closes the file so that it can be opened elsewhere
            Else

                MessageBox.Show("Specials.Txt not found.", "Error: File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error) 'message to inform the user that the File doesn't exist

            End If

        Catch ex As Exception 'catches errors and displays an error message

            MessageBox.Show("An Error has occured:" & ex.Message, "Catch: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub mnuUpdateSpecials_Click(sender As Object, e As EventArgs) Handles mnuUpdateSpecials.Click

        Dim strInput As String
        Try

            If File.Exists("Specials.Txt") Then 'Makes sure the file exists

                strInput = InputBox("enter Specials") 'assigns the contents of the inputbox to the variable
                strInput = strInput.Trim() 'trims the contents of the variable

                If strInput Is String.Empty Then ' prevents the input from being applied to the StreamWriter if it is empty


                    Return
                Else

                    Dim swSpecials As New StreamWriter("Specials.Txt") 'establishes StreamWriter

                    swSpecials.WriteLine(strInput) 'writes the strinput to the txt File

                    swSpecials.Close() 'closes the file

                End If
            End If

        Catch ex As Exception 'catches errors and displays an error message

            MessageBox.Show("An Error has occured:" & ex.Message, "Catch: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class
