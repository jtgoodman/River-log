<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtRiver = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFlow = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ttlMiles = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ttlRivers = New System.Windows.Forms.Label()
        Me.totalRivers = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRiver
        '
        Me.txtRiver.Location = New System.Drawing.Point(423, 92)
        Me.txtRiver.Name = "txtRiver"
        Me.txtRiver.Size = New System.Drawing.Size(100, 26)
        Me.txtRiver.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "River Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Paddled"
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(423, 238)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(100, 26)
        Me.txtDistance.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Distance Paddled (miles)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "River Flow (CFS)"
        '
        'txtFlow
        '
        Me.txtFlow.Location = New System.Drawing.Point(423, 317)
        Me.txtFlow.Name = "txtFlow"
        Me.txtFlow.Size = New System.Drawing.Size(100, 26)
        Me.txtFlow.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(619, 586)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 52)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(616, 507)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 51)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(423, 161)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(331, 26)
        Me.txtDate.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(619, 671)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 51)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 62)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate Total Miles Paddled"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ttlMiles
        '
        Me.ttlMiles.AutoSize = True
        Me.ttlMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlMiles.Location = New System.Drawing.Point(212, 517)
        Me.ttlMiles.Name = "ttlMiles"
        Me.ttlMiles.Size = New System.Drawing.Size(0, 32)
        Me.ttlMiles.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 77)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Calculate Total Paddling Sessions"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ttlRivers
        '
        Me.ttlRivers.AutoSize = True
        Me.ttlRivers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlRivers.Location = New System.Drawing.Point(212, 446)
        Me.ttlRivers.Name = "ttlRivers"
        Me.ttlRivers.Size = New System.Drawing.Size(0, 32)
        Me.ttlRivers.TabIndex = 15
        '
        'totalRivers
        '
        Me.totalRivers.AutoSize = True
        Me.totalRivers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalRivers.Location = New System.Drawing.Point(197, 596)
        Me.totalRivers.Name = "totalRivers"
        Me.totalRivers.Size = New System.Drawing.Size(0, 32)
        Me.totalRivers.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(211, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 37)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Whitewater River Log"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(40, 561)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 67)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "View detailed River Log"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(807, 781)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalRivers)
        Me.Controls.Add(Me.ttlRivers)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ttlMiles)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFlow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRiver)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRiver As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFlow As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ttlMiles As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ttlRivers As Label
    Friend WithEvents totalRivers As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
End Class
