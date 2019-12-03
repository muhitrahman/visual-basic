<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Txtcalculate
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtrent = New System.Windows.Forms.TextBox
        Me.Txtcommission = New System.Windows.Forms.TextBox
        Me.Txtnweeks = New System.Windows.Forms.TextBox
        Me.Calculatebutton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.OutputLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Commission"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ServiceFee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Weeks"
        '
        'Txtrent
        '
        Me.Txtrent.Location = New System.Drawing.Point(154, 76)
        Me.Txtrent.Name = "Txtrent"
        Me.Txtrent.Size = New System.Drawing.Size(164, 20)
        Me.Txtrent.TabIndex = 4
        '
        'Txtcommission
        '
        Me.Txtcommission.Location = New System.Drawing.Point(154, 105)
        Me.Txtcommission.Name = "Txtcommission"
        Me.Txtcommission.Size = New System.Drawing.Size(164, 20)
        Me.Txtcommission.TabIndex = 5
        '
        'Txtnweeks
        '
        Me.Txtnweeks.Location = New System.Drawing.Point(154, 177)
        Me.Txtnweeks.Name = "Txtnweeks"
        Me.Txtnweeks.Size = New System.Drawing.Size(164, 20)
        Me.Txtnweeks.TabIndex = 7
        '
        'Calculatebutton
        '
        Me.Calculatebutton.Location = New System.Drawing.Point(154, 231)
        Me.Calculatebutton.Name = "Calculatebutton"
        Me.Calculatebutton.Size = New System.Drawing.Size(133, 36)
        Me.Calculatebutton.TabIndex = 8
        Me.Calculatebutton.Text = "Calculate"
        Me.Calculatebutton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Output"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(336, 256)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(0, 13)
        Me.OutputLabel.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "200"
        '
        'Txtcalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 323)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Calculatebutton)
        Me.Controls.Add(Me.Txtnweeks)
        Me.Controls.Add(Me.Txtcommission)
        Me.Controls.Add(Me.Txtrent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Txtcalculate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "calculate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtrent As System.Windows.Forms.TextBox
    Friend WithEvents Txtcommission As System.Windows.Forms.TextBox
    Friend WithEvents Txtnweeks As System.Windows.Forms.TextBox
    Friend WithEvents Calculatebutton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
