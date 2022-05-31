<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.dtbday = New System.Windows.Forms.DateTimePicker()
        Me.cmbsection = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(258, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(309, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(283, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(273, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Birthday"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(282, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 44)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Section" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.LightCyan
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtname.Location = New System.Drawing.Point(357, 62)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(303, 19)
        Me.txtname.TabIndex = 5
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.LightCyan
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtage.Location = New System.Drawing.Point(357, 109)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(303, 19)
        Me.txtage.TabIndex = 6
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.BackColor = System.Drawing.Color.Transparent
        Me.radMale.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.radMale.Location = New System.Drawing.Point(372, 153)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(69, 26)
        Me.radMale.TabIndex = 7
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = False
        '
        'radFemale
        '
        Me.radFemale.AllowDrop = True
        Me.radFemale.AutoSize = True
        Me.radFemale.BackColor = System.Drawing.Color.Transparent
        Me.radFemale.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.radFemale.Location = New System.Drawing.Point(470, 151)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(86, 26)
        Me.radFemale.TabIndex = 8
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = False
        '
        'dtbday
        '
        Me.dtbday.CalendarFont = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.dtbday.CalendarMonthBackground = System.Drawing.Color.LightCyan
        Me.dtbday.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.dtbday.Location = New System.Drawing.Point(357, 203)
        Me.dtbday.Name = "dtbday"
        Me.dtbday.Size = New System.Drawing.Size(303, 30)
        Me.dtbday.TabIndex = 9
        '
        'cmbsection
        '
        Me.cmbsection.BackColor = System.Drawing.Color.LightCyan
        Me.cmbsection.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.cmbsection.FormattingEnabled = True
        Me.cmbsection.Items.AddRange(New Object() {"BSCPE - 2A", "BSCPE - 2B"})
        Me.cmbsection.Location = New System.Drawing.Point(357, 260)
        Me.cmbsection.Name = "cmbsection"
        Me.cmbsection.Size = New System.Drawing.Size(121, 30)
        Me.cmbsection.TabIndex = 10
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightCyan
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.btnsave.Location = New System.Drawing.Point(357, 333)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(303, 50)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "SAVE RECORD"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(898, 464)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbsection)
        Me.Controls.Add(Me.dtbday)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents dtbday As DateTimePicker
    Friend WithEvents cmbsection As ComboBox
    Friend WithEvents btnsave As Button
End Class
