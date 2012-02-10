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
Partial Class AboutBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.lblAboutDesc = New System.Windows.Forms.Label()
        Me.lblAboutName = New System.Windows.Forms.Label()
        Me.lblAboutCopyright = New System.Windows.Forms.Label()
        Me.gbxLicence = New System.Windows.Forms.GroupBox()
        Me.gbxIconLicence = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLicence = New System.Windows.Forms.TextBox()
        Me.txtIconLicence = New System.Windows.Forms.TextBox()
        Me.gbxLicence.SuspendLayout()
        Me.gbxIconLicence.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAboutDesc
        '
        Me.lblAboutDesc.AutoSize = True
        Me.lblAboutDesc.Location = New System.Drawing.Point(12, 35)
        Me.lblAboutDesc.Name = "lblAboutDesc"
        Me.lblAboutDesc.Size = New System.Drawing.Size(546, 13)
        Me.lblAboutDesc.TabIndex = 0
        Me.lblAboutDesc.Text = "This program is a simple way to see the status of your VBoxVmService-started Virt" & _
    "ualBox virtual machines."
        '
        'lblAboutName
        '
        Me.lblAboutName.AutoSize = True
        Me.lblAboutName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutName.Location = New System.Drawing.Point(12, 9)
        Me.lblAboutName.Name = "lblAboutName"
        Me.lblAboutName.Size = New System.Drawing.Size(99, 17)
        Me.lblAboutName.TabIndex = 1
        Me.lblAboutName.Text = "VBoxVMStatus"
        '
        'lblAboutCopyright
        '
        Me.lblAboutCopyright.AutoSize = True
        Me.lblAboutCopyright.Location = New System.Drawing.Point(12, 59)
        Me.lblAboutCopyright.Name = "lblAboutCopyright"
        Me.lblAboutCopyright.Size = New System.Drawing.Size(267, 13)
        Me.lblAboutCopyright.TabIndex = 2
        Me.lblAboutCopyright.Text = "Copyright © 2012 Peter Upfold. All rights reserved."
        '
        'gbxLicence
        '
        Me.gbxLicence.Controls.Add(Me.txtLicence)
        Me.gbxLicence.Location = New System.Drawing.Point(15, 86)
        Me.gbxLicence.Name = "gbxLicence"
        Me.gbxLicence.Size = New System.Drawing.Size(571, 117)
        Me.gbxLicence.TabIndex = 3
        Me.gbxLicence.TabStop = False
        Me.gbxLicence.Text = "Licence"
        '
        'gbxIconLicence
        '
        Me.gbxIconLicence.Controls.Add(Me.txtIconLicence)
        Me.gbxIconLicence.Location = New System.Drawing.Point(15, 242)
        Me.gbxIconLicence.Name = "gbxIconLicence"
        Me.gbxIconLicence.Size = New System.Drawing.Size(571, 117)
        Me.gbxIconLicence.TabIndex = 4
        Me.gbxIconLicence.TabStop = False
        Me.gbxIconLicence.Text = "Icon Licence"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "The application icon for this application is from the Oxygen Icon Set, and is mad" & _
    "e available under this licence:"
        '
        'txtLicence
        '
        Me.txtLicence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLicence.Location = New System.Drawing.Point(3, 18)
        Me.txtLicence.Multiline = True
        Me.txtLicence.Name = "txtLicence"
        Me.txtLicence.ReadOnly = True
        Me.txtLicence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLicence.Size = New System.Drawing.Size(565, 96)
        Me.txtLicence.TabIndex = 0
        Me.txtLicence.Text = resources.GetString("txtLicence.Text")
        '
        'txtIconLicence
        '
        Me.txtIconLicence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIconLicence.Location = New System.Drawing.Point(3, 18)
        Me.txtIconLicence.Multiline = True
        Me.txtIconLicence.Name = "txtIconLicence"
        Me.txtIconLicence.ReadOnly = True
        Me.txtIconLicence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIconLicence.Size = New System.Drawing.Size(565, 96)
        Me.txtIconLicence.TabIndex = 2
        Me.txtIconLicence.Text = resources.GetString("txtIconLicence.Text")
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 371)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxIconLicence)
        Me.Controls.Add(Me.gbxLicence)
        Me.Controls.Add(Me.lblAboutCopyright)
        Me.Controls.Add(Me.lblAboutName)
        Me.Controls.Add(Me.lblAboutDesc)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.Text = "About"
        Me.gbxLicence.ResumeLayout(False)
        Me.gbxLicence.PerformLayout()
        Me.gbxIconLicence.ResumeLayout(False)
        Me.gbxIconLicence.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutDesc As System.Windows.Forms.Label
    Friend WithEvents lblAboutName As System.Windows.Forms.Label
    Friend WithEvents lblAboutCopyright As System.Windows.Forms.Label
    Friend WithEvents gbxLicence As System.Windows.Forms.GroupBox
    Friend WithEvents txtLicence As System.Windows.Forms.TextBox
    Friend WithEvents gbxIconLicence As System.Windows.Forms.GroupBox
    Friend WithEvents txtIconLicence As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
