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
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblIntroText = New System.Windows.Forms.Label()
        Me.picAppIcon128 = New System.Windows.Forms.PictureBox()
        Me.lblVM0StatusPrefix = New System.Windows.Forms.Label()
        Me.lblVM1StatusPrefix = New System.Windows.Forms.Label()
        Me.lblVM0Status = New System.Windows.Forms.Label()
        Me.lblVM1Status = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnVM0Start = New System.Windows.Forms.Button()
        Me.btnVM1Start = New System.Windows.Forms.Button()
        Me.btnVM0Stop = New System.Windows.Forms.Button()
        Me.btnVM1Stop = New System.Windows.Forms.Button()
        Me.btnUpdateStatus = New System.Windows.Forms.Button()
        Me.tmrRegularUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPostActionUpdate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picAppIcon128, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIntroText
        '
        Me.lblIntroText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIntroText.AutoSize = True
        Me.lblIntroText.Location = New System.Drawing.Point(14, 11)
        Me.lblIntroText.Name = "lblIntroText"
        Me.lblIntroText.Size = New System.Drawing.Size(613, 17)
        Me.lblIntroText.TabIndex = 0
        Me.lblIntroText.Text = "This window shows you the status of the autostart VirtualBox VMs. It also allows " & _
    "you to control the VMs." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picAppIcon128
        '
        Me.picAppIcon128.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picAppIcon128.Image = Global.VBoxVMStatus.My.Resources.Icons.app_icon
        Me.picAppIcon128.InitialImage = Nothing
        Me.picAppIcon128.Location = New System.Drawing.Point(605, 115)
        Me.picAppIcon128.Name = "picAppIcon128"
        Me.picAppIcon128.Size = New System.Drawing.Size(64, 64)
        Me.picAppIcon128.TabIndex = 2
        Me.picAppIcon128.TabStop = False
        '
        'lblVM0StatusPrefix
        '
        Me.lblVM0StatusPrefix.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVM0StatusPrefix.Location = New System.Drawing.Point(14, 53)
        Me.lblVM0StatusPrefix.Name = "lblVM0StatusPrefix"
        Me.lblVM0StatusPrefix.Size = New System.Drawing.Size(168, 17)
        Me.lblVM0StatusPrefix.TabIndex = 6
        Me.lblVM0StatusPrefix.Text = "Cisco Eagle Server status:"
        '
        'lblVM1StatusPrefix
        '
        Me.lblVM1StatusPrefix.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVM1StatusPrefix.Location = New System.Drawing.Point(14, 86)
        Me.lblVM1StatusPrefix.Name = "lblVM1StatusPrefix"
        Me.lblVM1StatusPrefix.Size = New System.Drawing.Size(168, 15)
        Me.lblVM1StatusPrefix.TabIndex = 8
        Me.lblVM1StatusPrefix.Text = "Ubuntu Server status:"
        '
        'lblVM0Status
        '
        Me.lblVM0Status.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVM0Status.Location = New System.Drawing.Point(204, 53)
        Me.lblVM0Status.Name = "lblVM0Status"
        Me.lblVM0Status.Size = New System.Drawing.Size(241, 23)
        Me.lblVM0Status.TabIndex = 7
        Me.lblVM0Status.Text = "Loading status..."
        '
        'lblVM1Status
        '
        Me.lblVM1Status.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVM1Status.Location = New System.Drawing.Point(204, 86)
        Me.lblVM1Status.Name = "lblVM1Status"
        Me.lblVM1Status.Size = New System.Drawing.Size(241, 23)
        Me.lblVM1Status.TabIndex = 9
        Me.lblVM1Status.Text = "Loading status..."
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(17, 146)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(58, 24)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnVM0Start
        '
        Me.btnVM0Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVM0Start.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVM0Start.Location = New System.Drawing.Point(451, 53)
        Me.btnVM0Start.Name = "btnVM0Start"
        Me.btnVM0Start.Size = New System.Drawing.Size(75, 23)
        Me.btnVM0Start.TabIndex = 1
        Me.btnVM0Start.Text = "Start"
        Me.btnVM0Start.UseVisualStyleBackColor = True
        '
        'btnVM1Start
        '
        Me.btnVM1Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVM1Start.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVM1Start.Location = New System.Drawing.Point(451, 86)
        Me.btnVM1Start.Name = "btnVM1Start"
        Me.btnVM1Start.Size = New System.Drawing.Size(75, 23)
        Me.btnVM1Start.TabIndex = 3
        Me.btnVM1Start.Text = "Start"
        Me.btnVM1Start.UseVisualStyleBackColor = True
        '
        'btnVM0Stop
        '
        Me.btnVM0Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVM0Stop.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVM0Stop.Location = New System.Drawing.Point(532, 53)
        Me.btnVM0Stop.Name = "btnVM0Stop"
        Me.btnVM0Stop.Size = New System.Drawing.Size(75, 23)
        Me.btnVM0Stop.TabIndex = 2
        Me.btnVM0Stop.Text = "Stop"
        Me.btnVM0Stop.UseVisualStyleBackColor = True
        '
        'btnVM1Stop
        '
        Me.btnVM1Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVM1Stop.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVM1Stop.Location = New System.Drawing.Point(532, 86)
        Me.btnVM1Stop.Name = "btnVM1Stop"
        Me.btnVM1Stop.Size = New System.Drawing.Size(75, 23)
        Me.btnVM1Stop.TabIndex = 4
        Me.btnVM1Stop.Text = "Stop"
        Me.btnVM1Stop.UseVisualStyleBackColor = True
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdateStatus.Location = New System.Drawing.Point(306, 135)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(139, 35)
        Me.btnUpdateStatus.TabIndex = 0
        Me.btnUpdateStatus.Text = "&Update Status"
        Me.btnUpdateStatus.UseVisualStyleBackColor = True
        '
        'tmrRegularUpdate
        '
        Me.tmrRegularUpdate.Enabled = True
        Me.tmrRegularUpdate.Interval = 30000
        '
        'tmrPostActionUpdate
        '
        Me.tmrPostActionUpdate.Interval = 2000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(681, 182)
        Me.Controls.Add(Me.btnUpdateStatus)
        Me.Controls.Add(Me.btnVM1Stop)
        Me.Controls.Add(Me.btnVM0Stop)
        Me.Controls.Add(Me.btnVM1Start)
        Me.Controls.Add(Me.btnVM0Start)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lblVM1Status)
        Me.Controls.Add(Me.lblVM0Status)
        Me.Controls.Add(Me.lblVM1StatusPrefix)
        Me.Controls.Add(Me.lblVM0StatusPrefix)
        Me.Controls.Add(Me.picAppIcon128)
        Me.Controls.Add(Me.lblIntroText)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(697, 220)
        Me.Name = "Main"
        Me.Text = "VirtualBox VM Status"
        CType(Me.picAppIcon128, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntroText As System.Windows.Forms.Label
    Friend WithEvents picAppIcon128 As System.Windows.Forms.PictureBox
    Friend WithEvents lblVM0StatusPrefix As System.Windows.Forms.Label
    Friend WithEvents lblVM1StatusPrefix As System.Windows.Forms.Label
    Friend WithEvents lblVM0Status As System.Windows.Forms.Label
    Friend WithEvents lblVM1Status As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnVM0Start As System.Windows.Forms.Button
    Friend WithEvents btnVM1Start As System.Windows.Forms.Button
    Friend WithEvents btnVM0Stop As System.Windows.Forms.Button
    Friend WithEvents btnVM1Stop As System.Windows.Forms.Button
    Friend WithEvents btnUpdateStatus As System.Windows.Forms.Button
    Friend WithEvents tmrRegularUpdate As System.Windows.Forms.Timer
    Friend WithEvents tmrPostActionUpdate As System.Windows.Forms.Timer

End Class
