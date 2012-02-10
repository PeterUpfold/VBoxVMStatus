' VBoxVMStatus
' This program is a simple way to see the status of your VBoxVmService-started VirtualBox virtual machines.
'
' Copyright (C) 2012 Peter Upfold. All rights reserved.
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software
' and associated documentation files (the "Software"), to deal in the Software without restriction,
' including without limitation the rights to use, copy, modify, merge, publish, distribute,
' sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial
' portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
' IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
' WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
' OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'
' Except as contained in this notice, the names of the authors or copyright holders shall not be used in
' commercial advertising or to otherwise promote the sale, commercial use or other commercial dealings
' regarding this Software without prior written authorization from the the authors or copyright holders.
' Non-commercial use of the authors and copyright holders' names is permitted, but it may be revoked
' on a case-by-case basis if the authors wish to disconnect themselves from a particular use.

Public Class Main

    Private VMStatusResults(2) As String
    ' store the VM status results

    Private VMIterations As UInteger = 2
    ' how many times do we check for VMs?
    ' for our code here, we want to check VM 0, then VM 1, so we set it to 2.

    Private VmServiceControlLocation As String = "C:\vms\VmServiceControl.exe"
    ' where is the VmServiceControl.exe file?

    ' note that you must also change the array bounds of VMStatusResults if you alter this.

    Private Sub updateVMStatusDisplay()
        ' we need to spawn two processes -- one to check each VM's status and return the results
        ' into the right label

        ' for future expandability of this code, though, we will run 'VMIterations' number of times
        Dim i As UInteger = 0
        Dim p As Process

        For i = 0 To VMIterations - 1

            p = New Process
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.RedirectStandardError = True
            p.StartInfo.FileName = VmServiceControlLocation
            p.StartInfo.Arguments = "-st " & i
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.StartInfo.CreateNoWindow = True ' hide the command from throwing a cmd window

            Try
                p.Start()
                VMStatusResults(i) = p.StandardOutput.ReadToEnd()
            Catch ex As Exception
                VMStatusResults(i) = "Unable to run VboxVmService."
                Console.WriteLine("Unable to run VboxVmService. " & ex.Message.ToString())
            End Try


            p.Dispose()

        Next

        ' now, place the strings into the labels
        lblVM0Status.Text = VMStatusResults(0)
        lblVM1Status.Text = VMStatusResults(1)
    End Sub

    Private Sub startVM(ByVal vmID As UInteger)
        ' start the specified Virtual Machine ID number


        Dim p As New Process
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.FileName = VmServiceControlLocation
        p.StartInfo.Arguments = "-su " & vmID
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True ' hide the command from throwing a cmd window
        Try
            p.Start()
        Catch ex As Exception
            MessageBox.Show("Unable to run VboxVmService.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Console.WriteLine("Unable to run VboxVmService. " & ex.Message.ToString())
        End Try

        p.Dispose()

        tmrPostActionUpdate.Enabled = True  ' have the status update in a moment or two

    End Sub

    Private Sub stopVM(ByVal vmID As UInteger)

        ' start the specified Virtual Machine ID number


        Dim p As New Process
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.FileName = VmServiceControlLocation
        p.StartInfo.Arguments = "-sd " & vmID
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True ' hide the command from throwing a cmd window
        Try
            p.Start()
        Catch ex As Exception
            MessageBox.Show("Unable to run VboxVmService.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Console.WriteLine("Unable to run VboxVmService. " & ex.Message.ToString())
        End Try

        p.Dispose()

        tmrPostActionUpdate.Enabled = True  ' have the status update in a moment or two
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' the form has loaded, so we need to get the VM status display ready

        updateVMStatusDisplay()

    End Sub

    Private Sub btnUpdateStatus_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateStatus.Click

        ' set to loading..., then update
        lblVM0Status.Text = "Loading..."
        lblVM1Status.Text = "Loading..."

        updateVMStatusDisplay()
    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub tmrRegularUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRegularUpdate.Tick
        updateVMStatusDisplay()
    End Sub

    Private Sub tmrPostActionUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrPostActionUpdate.Tick
        updateVMStatusDisplay()
        tmrPostActionUpdate.Enabled = False ' prevent it ticking again and re-spawning processes every second
    End Sub

    Private Sub btnVM0Start_Click(sender As System.Object, e As System.EventArgs) Handles btnVM0Start.Click
        lblVM0Status.Text = "Starting..."
        startVM(0)
    End Sub

    Private Sub btnVM0Stop_Click(sender As System.Object, e As System.EventArgs) Handles btnVM0Stop.Click
        lblVM0Status.Text = "Stopping..."
        stopVM(0)
    End Sub

    Private Sub btnVM1Start_Click(sender As System.Object, e As System.EventArgs) Handles btnVM1Start.Click
        lblVM1Status.Text = "Starting..."
        startVM(1)
    End Sub

    Private Sub btnVM1Stop_Click(sender As System.Object, e As System.EventArgs) Handles btnVM1Stop.Click
        lblVM1Status.Text = "Stopping..."
        stopVM(1)
    End Sub
End Class
