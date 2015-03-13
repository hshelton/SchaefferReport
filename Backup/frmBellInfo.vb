Option Strict Off
Option Explicit On 

Friend Class frmBellInfo
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents txtBellCount As System.Windows.Forms.TextBox
    Public WithEvents cmdWrite As System.Windows.Forms.Button
    Public WithEvents cmdRead As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents txtHour7 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute7 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute6 As System.Windows.Forms.TextBox
    Public WithEvents txtHour6 As System.Windows.Forms.TextBox
    Public WithEvents txtHour5 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute5 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute4 As System.Windows.Forms.TextBox
    Public WithEvents txtHour4 As System.Windows.Forms.TextBox
    Public WithEvents txtHour3 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute3 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute2 As System.Windows.Forms.TextBox
    Public WithEvents txtHour2 As System.Windows.Forms.TextBox
    Public WithEvents txtHour1 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute1 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute0 As System.Windows.Forms.TextBox
    Public WithEvents txtHour0 As System.Windows.Forms.TextBox
    Public WithEvents chkValid7 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid6 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid5 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid4 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid3 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid2 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid1 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid0 As System.Windows.Forms.CheckBox
    Public WithEvents Label2_7 As System.Windows.Forms.Label
    Public WithEvents Label2_6 As System.Windows.Forms.Label
    Public WithEvents Label2_5 As System.Windows.Forms.Label
    Public WithEvents Label2_4 As System.Windows.Forms.Label
    Public WithEvents Label2_3 As System.Windows.Forms.Label
    Public WithEvents Label2_2 As System.Windows.Forms.Label
    Public WithEvents Label2_1 As System.Windows.Forms.Label
    Public WithEvents Label2_0 As System.Windows.Forms.Label
    Public WithEvents lblCaption0 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2_8 As System.Windows.Forms.Label
    Public WithEvents Label2_15 As System.Windows.Forms.Label
    Public WithEvents Label2_14 As System.Windows.Forms.Label
    Public WithEvents Label2_13 As System.Windows.Forms.Label
    Public WithEvents Label2_12 As System.Windows.Forms.Label
    Public WithEvents Label2_11 As System.Windows.Forms.Label
    Public WithEvents Label2_10 As System.Windows.Forms.Label
    Public WithEvents Label2_9 As System.Windows.Forms.Label
    Public WithEvents Label2_24 As System.Windows.Forms.Label
    Public WithEvents Label2_31 As System.Windows.Forms.Label
    Public WithEvents Label2_30 As System.Windows.Forms.Label
    Public WithEvents Label2_29 As System.Windows.Forms.Label
    Public WithEvents Label2_28 As System.Windows.Forms.Label
    Public WithEvents Label2_27 As System.Windows.Forms.Label
    Public WithEvents Label2_26 As System.Windows.Forms.Label
    Public WithEvents Label2_25 As System.Windows.Forms.Label
    Public WithEvents Label2_23 As System.Windows.Forms.Label
    Public WithEvents Label2_22 As System.Windows.Forms.Label
    Public WithEvents Label2_21 As System.Windows.Forms.Label
    Public WithEvents Label2_20 As System.Windows.Forms.Label
    Public WithEvents Label2_19 As System.Windows.Forms.Label
    Public WithEvents Label2_18 As System.Windows.Forms.Label
    Public WithEvents Label2_17 As System.Windows.Forms.Label
    Public WithEvents Label2_16 As System.Windows.Forms.Label
    Public WithEvents Label2_33 As System.Windows.Forms.Label
    Public WithEvents Label2_32 As System.Windows.Forms.Label
    Public WithEvents Label2_40 As System.Windows.Forms.Label
    Public WithEvents Label2_47 As System.Windows.Forms.Label
    Public WithEvents Label2_46 As System.Windows.Forms.Label
    Public WithEvents Label2_45 As System.Windows.Forms.Label
    Public WithEvents Label2_44 As System.Windows.Forms.Label
    Public WithEvents Label2_43 As System.Windows.Forms.Label
    Public WithEvents Label2_42 As System.Windows.Forms.Label
    Public WithEvents Label2_41 As System.Windows.Forms.Label
    Public WithEvents Label2_39 As System.Windows.Forms.Label
    Public WithEvents Label2_38 As System.Windows.Forms.Label
    Public WithEvents Label2_37 As System.Windows.Forms.Label
    Public WithEvents Label2_36 As System.Windows.Forms.Label
    Public WithEvents Label2_35 As System.Windows.Forms.Label
    Public WithEvents Label2_34 As System.Windows.Forms.Label
    Public WithEvents chkValid15 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid14 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid13 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid12 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid11 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid10 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid9 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid8 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid23 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid22 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid21 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid20 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid19 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid18 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid17 As System.Windows.Forms.CheckBox
    Public WithEvents chkValid16 As System.Windows.Forms.CheckBox
    Public WithEvents txtHour15 As System.Windows.Forms.TextBox
    Public WithEvents txtHour14 As System.Windows.Forms.TextBox
    Public WithEvents txtHour13 As System.Windows.Forms.TextBox
    Public WithEvents txtHour12 As System.Windows.Forms.TextBox
    Public WithEvents txtHour11 As System.Windows.Forms.TextBox
    Public WithEvents txtHour10 As System.Windows.Forms.TextBox
    Public WithEvents txtHour9 As System.Windows.Forms.TextBox
    Public WithEvents txtHour8 As System.Windows.Forms.TextBox
    Public WithEvents txtHour23 As System.Windows.Forms.TextBox
    Public WithEvents txtHour22 As System.Windows.Forms.TextBox
    Public WithEvents txtHour21 As System.Windows.Forms.TextBox
    Public WithEvents txtHour20 As System.Windows.Forms.TextBox
    Public WithEvents txtHour19 As System.Windows.Forms.TextBox
    Public WithEvents txtHour18 As System.Windows.Forms.TextBox
    Public WithEvents txtHour17 As System.Windows.Forms.TextBox
    Public WithEvents txtHour16 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute15 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute14 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute13 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute12 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute11 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute10 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute9 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute8 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute23 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute22 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute21 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute20 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute19 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute18 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute17 As System.Windows.Forms.TextBox
    Public WithEvents txtMinute16 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBellInfo))
        Me.txtBellCount = New System.Windows.Forms.TextBox()
        Me.txtHour7 = New System.Windows.Forms.TextBox()
        Me.txtMinute7 = New System.Windows.Forms.TextBox()
        Me.txtMinute6 = New System.Windows.Forms.TextBox()
        Me.txtHour6 = New System.Windows.Forms.TextBox()
        Me.txtHour5 = New System.Windows.Forms.TextBox()
        Me.txtMinute5 = New System.Windows.Forms.TextBox()
        Me.txtMinute4 = New System.Windows.Forms.TextBox()
        Me.txtHour4 = New System.Windows.Forms.TextBox()
        Me.txtHour3 = New System.Windows.Forms.TextBox()
        Me.txtMinute3 = New System.Windows.Forms.TextBox()
        Me.txtMinute2 = New System.Windows.Forms.TextBox()
        Me.txtHour2 = New System.Windows.Forms.TextBox()
        Me.txtHour1 = New System.Windows.Forms.TextBox()
        Me.txtMinute1 = New System.Windows.Forms.TextBox()
        Me.txtMinute0 = New System.Windows.Forms.TextBox()
        Me.txtHour0 = New System.Windows.Forms.TextBox()
        Me.chkValid7 = New System.Windows.Forms.CheckBox()
        Me.chkValid6 = New System.Windows.Forms.CheckBox()
        Me.chkValid5 = New System.Windows.Forms.CheckBox()
        Me.chkValid4 = New System.Windows.Forms.CheckBox()
        Me.chkValid3 = New System.Windows.Forms.CheckBox()
        Me.chkValid2 = New System.Windows.Forms.CheckBox()
        Me.chkValid1 = New System.Windows.Forms.CheckBox()
        Me.chkValid0 = New System.Windows.Forms.CheckBox()
        Me.cmdWrite = New System.Windows.Forms.Button()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.Label2_8 = New System.Windows.Forms.Label()
        Me.Label2_15 = New System.Windows.Forms.Label()
        Me.Label2_14 = New System.Windows.Forms.Label()
        Me.Label2_13 = New System.Windows.Forms.Label()
        Me.Label2_12 = New System.Windows.Forms.Label()
        Me.Label2_11 = New System.Windows.Forms.Label()
        Me.Label2_10 = New System.Windows.Forms.Label()
        Me.Label2_9 = New System.Windows.Forms.Label()
        Me.lblCaption0 = New System.Windows.Forms.Label()
        Me.Label2_7 = New System.Windows.Forms.Label()
        Me.Label2_6 = New System.Windows.Forms.Label()
        Me.Label2_5 = New System.Windows.Forms.Label()
        Me.Label2_4 = New System.Windows.Forms.Label()
        Me.Label2_3 = New System.Windows.Forms.Label()
        Me.Label2_2 = New System.Windows.Forms.Label()
        Me.Label2_1 = New System.Windows.Forms.Label()
        Me.Label2_0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtHour15 = New System.Windows.Forms.TextBox()
        Me.txtMinute15 = New System.Windows.Forms.TextBox()
        Me.txtMinute14 = New System.Windows.Forms.TextBox()
        Me.txtHour14 = New System.Windows.Forms.TextBox()
        Me.txtHour13 = New System.Windows.Forms.TextBox()
        Me.txtMinute13 = New System.Windows.Forms.TextBox()
        Me.txtMinute12 = New System.Windows.Forms.TextBox()
        Me.txtHour12 = New System.Windows.Forms.TextBox()
        Me.txtHour11 = New System.Windows.Forms.TextBox()
        Me.txtMinute11 = New System.Windows.Forms.TextBox()
        Me.txtMinute10 = New System.Windows.Forms.TextBox()
        Me.txtHour10 = New System.Windows.Forms.TextBox()
        Me.txtHour9 = New System.Windows.Forms.TextBox()
        Me.txtMinute9 = New System.Windows.Forms.TextBox()
        Me.txtMinute8 = New System.Windows.Forms.TextBox()
        Me.txtHour8 = New System.Windows.Forms.TextBox()
        Me.chkValid15 = New System.Windows.Forms.CheckBox()
        Me.chkValid14 = New System.Windows.Forms.CheckBox()
        Me.chkValid13 = New System.Windows.Forms.CheckBox()
        Me.chkValid12 = New System.Windows.Forms.CheckBox()
        Me.chkValid11 = New System.Windows.Forms.CheckBox()
        Me.chkValid10 = New System.Windows.Forms.CheckBox()
        Me.chkValid9 = New System.Windows.Forms.CheckBox()
        Me.chkValid8 = New System.Windows.Forms.CheckBox()
        Me.Label2_24 = New System.Windows.Forms.Label()
        Me.Label2_31 = New System.Windows.Forms.Label()
        Me.Label2_30 = New System.Windows.Forms.Label()
        Me.Label2_29 = New System.Windows.Forms.Label()
        Me.Label2_28 = New System.Windows.Forms.Label()
        Me.Label2_27 = New System.Windows.Forms.Label()
        Me.Label2_26 = New System.Windows.Forms.Label()
        Me.Label2_25 = New System.Windows.Forms.Label()
        Me.Label2_23 = New System.Windows.Forms.Label()
        Me.Label2_22 = New System.Windows.Forms.Label()
        Me.Label2_21 = New System.Windows.Forms.Label()
        Me.Label2_20 = New System.Windows.Forms.Label()
        Me.Label2_19 = New System.Windows.Forms.Label()
        Me.Label2_18 = New System.Windows.Forms.Label()
        Me.Label2_17 = New System.Windows.Forms.Label()
        Me.Label2_16 = New System.Windows.Forms.Label()
        Me.txtHour23 = New System.Windows.Forms.TextBox()
        Me.txtMinute23 = New System.Windows.Forms.TextBox()
        Me.txtMinute22 = New System.Windows.Forms.TextBox()
        Me.txtHour22 = New System.Windows.Forms.TextBox()
        Me.txtHour21 = New System.Windows.Forms.TextBox()
        Me.txtMinute21 = New System.Windows.Forms.TextBox()
        Me.txtMinute20 = New System.Windows.Forms.TextBox()
        Me.txtHour20 = New System.Windows.Forms.TextBox()
        Me.txtHour19 = New System.Windows.Forms.TextBox()
        Me.txtMinute19 = New System.Windows.Forms.TextBox()
        Me.txtMinute18 = New System.Windows.Forms.TextBox()
        Me.txtHour18 = New System.Windows.Forms.TextBox()
        Me.txtHour17 = New System.Windows.Forms.TextBox()
        Me.txtMinute17 = New System.Windows.Forms.TextBox()
        Me.txtMinute16 = New System.Windows.Forms.TextBox()
        Me.txtHour16 = New System.Windows.Forms.TextBox()
        Me.chkValid23 = New System.Windows.Forms.CheckBox()
        Me.chkValid22 = New System.Windows.Forms.CheckBox()
        Me.chkValid21 = New System.Windows.Forms.CheckBox()
        Me.chkValid20 = New System.Windows.Forms.CheckBox()
        Me.chkValid19 = New System.Windows.Forms.CheckBox()
        Me.chkValid18 = New System.Windows.Forms.CheckBox()
        Me.chkValid17 = New System.Windows.Forms.CheckBox()
        Me.chkValid16 = New System.Windows.Forms.CheckBox()
        Me.Label2_40 = New System.Windows.Forms.Label()
        Me.Label2_47 = New System.Windows.Forms.Label()
        Me.Label2_46 = New System.Windows.Forms.Label()
        Me.Label2_45 = New System.Windows.Forms.Label()
        Me.Label2_44 = New System.Windows.Forms.Label()
        Me.Label2_43 = New System.Windows.Forms.Label()
        Me.Label2_42 = New System.Windows.Forms.Label()
        Me.Label2_41 = New System.Windows.Forms.Label()
        Me.Label2_39 = New System.Windows.Forms.Label()
        Me.Label2_38 = New System.Windows.Forms.Label()
        Me.Label2_37 = New System.Windows.Forms.Label()
        Me.Label2_36 = New System.Windows.Forms.Label()
        Me.Label2_35 = New System.Windows.Forms.Label()
        Me.Label2_34 = New System.Windows.Forms.Label()
        Me.Label2_33 = New System.Windows.Forms.Label()
        Me.Label2_32 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBellCount
        '
        Me.txtBellCount.AcceptsReturn = True
        Me.txtBellCount.AutoSize = False
        Me.txtBellCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtBellCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBellCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBellCount.Location = New System.Drawing.Point(336, 336)
        Me.txtBellCount.MaxLength = 0
        Me.txtBellCount.Name = "txtBellCount"
        Me.txtBellCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBellCount.Size = New System.Drawing.Size(39, 29)
        Me.txtBellCount.TabIndex = 3
        Me.txtBellCount.Text = ""
        '
        'txtHour7
        '
        Me.txtHour7.AcceptsReturn = True
        Me.txtHour7.AutoSize = False
        Me.txtHour7.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour7.Location = New System.Drawing.Point(112, 289)
        Me.txtHour7.MaxLength = 0
        Me.txtHour7.Name = "txtHour7"
        Me.txtHour7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour7.Size = New System.Drawing.Size(42, 28)
        Me.txtHour7.TabIndex = 23
        Me.txtHour7.Text = ""
        '
        'txtMinute7
        '
        Me.txtMinute7.AcceptsReturn = True
        Me.txtMinute7.AutoSize = False
        Me.txtMinute7.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute7.Location = New System.Drawing.Point(172, 289)
        Me.txtMinute7.MaxLength = 0
        Me.txtMinute7.Name = "txtMinute7"
        Me.txtMinute7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute7.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute7.TabIndex = 24
        Me.txtMinute7.Text = ""
        '
        'txtMinute6
        '
        Me.txtMinute6.AcceptsReturn = True
        Me.txtMinute6.AutoSize = False
        Me.txtMinute6.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute6.Location = New System.Drawing.Point(172, 261)
        Me.txtMinute6.MaxLength = 0
        Me.txtMinute6.Name = "txtMinute6"
        Me.txtMinute6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute6.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute6.TabIndex = 21
        Me.txtMinute6.Text = ""
        '
        'txtHour6
        '
        Me.txtHour6.AcceptsReturn = True
        Me.txtHour6.AutoSize = False
        Me.txtHour6.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour6.Location = New System.Drawing.Point(112, 261)
        Me.txtHour6.MaxLength = 0
        Me.txtHour6.Name = "txtHour6"
        Me.txtHour6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour6.Size = New System.Drawing.Size(42, 28)
        Me.txtHour6.TabIndex = 20
        Me.txtHour6.Text = ""
        '
        'txtHour5
        '
        Me.txtHour5.AcceptsReturn = True
        Me.txtHour5.AutoSize = False
        Me.txtHour5.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour5.Location = New System.Drawing.Point(112, 233)
        Me.txtHour5.MaxLength = 0
        Me.txtHour5.Name = "txtHour5"
        Me.txtHour5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour5.Size = New System.Drawing.Size(42, 28)
        Me.txtHour5.TabIndex = 17
        Me.txtHour5.Text = ""
        '
        'txtMinute5
        '
        Me.txtMinute5.AcceptsReturn = True
        Me.txtMinute5.AutoSize = False
        Me.txtMinute5.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute5.Location = New System.Drawing.Point(172, 233)
        Me.txtMinute5.MaxLength = 0
        Me.txtMinute5.Name = "txtMinute5"
        Me.txtMinute5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute5.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute5.TabIndex = 18
        Me.txtMinute5.Text = ""
        '
        'txtMinute4
        '
        Me.txtMinute4.AcceptsReturn = True
        Me.txtMinute4.AutoSize = False
        Me.txtMinute4.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute4.Location = New System.Drawing.Point(172, 205)
        Me.txtMinute4.MaxLength = 0
        Me.txtMinute4.Name = "txtMinute4"
        Me.txtMinute4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute4.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute4.TabIndex = 15
        Me.txtMinute4.Text = ""
        '
        'txtHour4
        '
        Me.txtHour4.AcceptsReturn = True
        Me.txtHour4.AutoSize = False
        Me.txtHour4.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour4.Location = New System.Drawing.Point(112, 205)
        Me.txtHour4.MaxLength = 0
        Me.txtHour4.Name = "txtHour4"
        Me.txtHour4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour4.Size = New System.Drawing.Size(42, 28)
        Me.txtHour4.TabIndex = 14
        Me.txtHour4.Text = ""
        '
        'txtHour3
        '
        Me.txtHour3.AcceptsReturn = True
        Me.txtHour3.AutoSize = False
        Me.txtHour3.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour3.Location = New System.Drawing.Point(112, 177)
        Me.txtHour3.MaxLength = 0
        Me.txtHour3.Name = "txtHour3"
        Me.txtHour3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour3.Size = New System.Drawing.Size(42, 28)
        Me.txtHour3.TabIndex = 11
        Me.txtHour3.Text = ""
        '
        'txtMinute3
        '
        Me.txtMinute3.AcceptsReturn = True
        Me.txtMinute3.AutoSize = False
        Me.txtMinute3.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute3.Location = New System.Drawing.Point(172, 177)
        Me.txtMinute3.MaxLength = 0
        Me.txtMinute3.Name = "txtMinute3"
        Me.txtMinute3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute3.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute3.TabIndex = 12
        Me.txtMinute3.Text = ""
        '
        'txtMinute2
        '
        Me.txtMinute2.AcceptsReturn = True
        Me.txtMinute2.AutoSize = False
        Me.txtMinute2.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute2.Location = New System.Drawing.Point(172, 150)
        Me.txtMinute2.MaxLength = 0
        Me.txtMinute2.Name = "txtMinute2"
        Me.txtMinute2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute2.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute2.TabIndex = 9
        Me.txtMinute2.Text = ""
        '
        'txtHour2
        '
        Me.txtHour2.AcceptsReturn = True
        Me.txtHour2.AutoSize = False
        Me.txtHour2.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour2.Location = New System.Drawing.Point(112, 150)
        Me.txtHour2.MaxLength = 0
        Me.txtHour2.Name = "txtHour2"
        Me.txtHour2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour2.Size = New System.Drawing.Size(42, 28)
        Me.txtHour2.TabIndex = 8
        Me.txtHour2.Text = ""
        '
        'txtHour1
        '
        Me.txtHour1.AcceptsReturn = True
        Me.txtHour1.AutoSize = False
        Me.txtHour1.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour1.Location = New System.Drawing.Point(112, 122)
        Me.txtHour1.MaxLength = 0
        Me.txtHour1.Name = "txtHour1"
        Me.txtHour1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour1.Size = New System.Drawing.Size(42, 28)
        Me.txtHour1.TabIndex = 5
        Me.txtHour1.Text = ""
        '
        'txtMinute1
        '
        Me.txtMinute1.AcceptsReturn = True
        Me.txtMinute1.AutoSize = False
        Me.txtMinute1.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute1.Location = New System.Drawing.Point(172, 122)
        Me.txtMinute1.MaxLength = 0
        Me.txtMinute1.Name = "txtMinute1"
        Me.txtMinute1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute1.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute1.TabIndex = 6
        Me.txtMinute1.Text = ""
        '
        'txtMinute0
        '
        Me.txtMinute0.AcceptsReturn = True
        Me.txtMinute0.AutoSize = False
        Me.txtMinute0.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute0.Location = New System.Drawing.Point(172, 94)
        Me.txtMinute0.MaxLength = 0
        Me.txtMinute0.Name = "txtMinute0"
        Me.txtMinute0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute0.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute0.TabIndex = 2
        Me.txtMinute0.Text = ""
        '
        'txtHour0
        '
        Me.txtHour0.AcceptsReturn = True
        Me.txtHour0.AutoSize = False
        Me.txtHour0.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour0.Location = New System.Drawing.Point(112, 94)
        Me.txtHour0.MaxLength = 0
        Me.txtHour0.Name = "txtHour0"
        Me.txtHour0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour0.Size = New System.Drawing.Size(42, 28)
        Me.txtHour0.TabIndex = 1
        Me.txtHour0.Text = ""
        '
        'chkValid7
        '
        Me.chkValid7.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid7.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid7.Location = New System.Drawing.Point(86, 292)
        Me.chkValid7.Name = "chkValid7"
        Me.chkValid7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid7.Size = New System.Drawing.Size(14, 20)
        Me.chkValid7.TabIndex = 22
        Me.chkValid7.Text = "Time1"
        '
        'chkValid6
        '
        Me.chkValid6.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid6.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid6.Location = New System.Drawing.Point(86, 264)
        Me.chkValid6.Name = "chkValid6"
        Me.chkValid6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid6.Size = New System.Drawing.Size(14, 20)
        Me.chkValid6.TabIndex = 19
        Me.chkValid6.Text = "Time1"
        '
        'chkValid5
        '
        Me.chkValid5.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid5.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid5.Location = New System.Drawing.Point(86, 236)
        Me.chkValid5.Name = "chkValid5"
        Me.chkValid5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid5.Size = New System.Drawing.Size(14, 20)
        Me.chkValid5.TabIndex = 16
        Me.chkValid5.Text = "Time1"
        '
        'chkValid4
        '
        Me.chkValid4.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid4.Location = New System.Drawing.Point(86, 208)
        Me.chkValid4.Name = "chkValid4"
        Me.chkValid4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid4.Size = New System.Drawing.Size(14, 20)
        Me.chkValid4.TabIndex = 13
        Me.chkValid4.Text = "Time1"
        '
        'chkValid3
        '
        Me.chkValid3.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid3.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid3.Location = New System.Drawing.Point(86, 180)
        Me.chkValid3.Name = "chkValid3"
        Me.chkValid3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid3.Size = New System.Drawing.Size(14, 20)
        Me.chkValid3.TabIndex = 10
        Me.chkValid3.Text = "Time1"
        '
        'chkValid2
        '
        Me.chkValid2.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid2.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid2.Location = New System.Drawing.Point(86, 153)
        Me.chkValid2.Name = "chkValid2"
        Me.chkValid2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid2.Size = New System.Drawing.Size(14, 20)
        Me.chkValid2.TabIndex = 7
        Me.chkValid2.Text = "Time1"
        '
        'chkValid1
        '
        Me.chkValid1.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid1.Location = New System.Drawing.Point(86, 125)
        Me.chkValid1.Name = "chkValid1"
        Me.chkValid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid1.Size = New System.Drawing.Size(14, 20)
        Me.chkValid1.TabIndex = 4
        Me.chkValid1.Text = "Time1"
        '
        'chkValid0
        '
        Me.chkValid0.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid0.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid0.Location = New System.Drawing.Point(86, 98)
        Me.chkValid0.Name = "chkValid0"
        Me.chkValid0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid0.Size = New System.Drawing.Size(14, 20)
        Me.chkValid0.TabIndex = 0
        Me.chkValid0.Text = "Time1"
        '
        'cmdWrite
        '
        Me.cmdWrite.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWrite.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWrite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWrite.Location = New System.Drawing.Point(560, 336)
        Me.cmdWrite.Name = "cmdWrite"
        Me.cmdWrite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWrite.Size = New System.Drawing.Size(99, 34)
        Me.cmdWrite.TabIndex = 1
        Me.cmdWrite.Text = "Write"
        '
        'cmdRead
        '
        Me.cmdRead.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRead.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRead.Location = New System.Drawing.Point(448, 336)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRead.Size = New System.Drawing.Size(99, 34)
        Me.cmdRead.TabIndex = 0
        Me.cmdRead.Text = "Read"
        '
        'Label2_8
        '
        Me.Label2_8.BackColor = System.Drawing.Color.Transparent
        Me.Label2_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_8.Location = New System.Drawing.Point(162, 98)
        Me.Label2_8.Name = "Label2_8"
        Me.Label2_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_8.Size = New System.Drawing.Size(6, 20)
        Me.Label2_8.TabIndex = 47
        Me.Label2_8.Text = ":"
        Me.Label2_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_15
        '
        Me.Label2_15.BackColor = System.Drawing.Color.Transparent
        Me.Label2_15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_15.Location = New System.Drawing.Point(162, 292)
        Me.Label2_15.Name = "Label2_15"
        Me.Label2_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_15.Size = New System.Drawing.Size(6, 20)
        Me.Label2_15.TabIndex = 46
        Me.Label2_15.Text = ":"
        Me.Label2_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_14
        '
        Me.Label2_14.BackColor = System.Drawing.Color.Transparent
        Me.Label2_14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_14.Location = New System.Drawing.Point(162, 264)
        Me.Label2_14.Name = "Label2_14"
        Me.Label2_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_14.Size = New System.Drawing.Size(6, 20)
        Me.Label2_14.TabIndex = 45
        Me.Label2_14.Text = ":"
        Me.Label2_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_13
        '
        Me.Label2_13.BackColor = System.Drawing.Color.Transparent
        Me.Label2_13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_13.Location = New System.Drawing.Point(162, 236)
        Me.Label2_13.Name = "Label2_13"
        Me.Label2_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_13.Size = New System.Drawing.Size(6, 20)
        Me.Label2_13.TabIndex = 44
        Me.Label2_13.Text = ":"
        Me.Label2_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_12
        '
        Me.Label2_12.BackColor = System.Drawing.Color.Transparent
        Me.Label2_12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_12.Location = New System.Drawing.Point(162, 208)
        Me.Label2_12.Name = "Label2_12"
        Me.Label2_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_12.Size = New System.Drawing.Size(6, 20)
        Me.Label2_12.TabIndex = 43
        Me.Label2_12.Text = ":"
        Me.Label2_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_11
        '
        Me.Label2_11.BackColor = System.Drawing.Color.Transparent
        Me.Label2_11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_11.Location = New System.Drawing.Point(162, 180)
        Me.Label2_11.Name = "Label2_11"
        Me.Label2_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_11.Size = New System.Drawing.Size(6, 20)
        Me.Label2_11.TabIndex = 42
        Me.Label2_11.Text = ":"
        Me.Label2_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_10
        '
        Me.Label2_10.BackColor = System.Drawing.Color.Transparent
        Me.Label2_10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_10.Location = New System.Drawing.Point(162, 153)
        Me.Label2_10.Name = "Label2_10"
        Me.Label2_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_10.Size = New System.Drawing.Size(6, 20)
        Me.Label2_10.TabIndex = 41
        Me.Label2_10.Text = ":"
        Me.Label2_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_9
        '
        Me.Label2_9.BackColor = System.Drawing.Color.Transparent
        Me.Label2_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_9.Location = New System.Drawing.Point(162, 125)
        Me.Label2_9.Name = "Label2_9"
        Me.Label2_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_9.Size = New System.Drawing.Size(6, 20)
        Me.Label2_9.TabIndex = 40
        Me.Label2_9.Text = ":"
        Me.Label2_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaption0
        '
        Me.lblCaption0.BackColor = System.Drawing.Color.Transparent
        Me.lblCaption0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCaption0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaption0.Location = New System.Drawing.Point(18, 68)
        Me.lblCaption0.Name = "lblCaption0"
        Me.lblCaption0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCaption0.Size = New System.Drawing.Size(202, 20)
        Me.lblCaption0.TabIndex = 39
        Me.lblCaption0.Text = "Point   UseFlag   Start Time"
        '
        'Label2_7
        '
        Me.Label2_7.BackColor = System.Drawing.Color.Transparent
        Me.Label2_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_7.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_7.Location = New System.Drawing.Point(16, 292)
        Me.Label2_7.Name = "Label2_7"
        Me.Label2_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_7.Size = New System.Drawing.Size(66, 20)
        Me.Label2_7.TabIndex = 36
        Me.Label2_7.Text = "Point 8:"
        '
        'Label2_6
        '
        Me.Label2_6.BackColor = System.Drawing.Color.Transparent
        Me.Label2_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_6.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_6.Location = New System.Drawing.Point(16, 264)
        Me.Label2_6.Name = "Label2_6"
        Me.Label2_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_6.Size = New System.Drawing.Size(66, 20)
        Me.Label2_6.TabIndex = 35
        Me.Label2_6.Text = "Point 7:"
        '
        'Label2_5
        '
        Me.Label2_5.BackColor = System.Drawing.Color.Transparent
        Me.Label2_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_5.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_5.Location = New System.Drawing.Point(16, 236)
        Me.Label2_5.Name = "Label2_5"
        Me.Label2_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_5.Size = New System.Drawing.Size(66, 20)
        Me.Label2_5.TabIndex = 34
        Me.Label2_5.Text = "Point 6:"
        '
        'Label2_4
        '
        Me.Label2_4.BackColor = System.Drawing.Color.Transparent
        Me.Label2_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_4.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_4.Location = New System.Drawing.Point(16, 208)
        Me.Label2_4.Name = "Label2_4"
        Me.Label2_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_4.Size = New System.Drawing.Size(66, 20)
        Me.Label2_4.TabIndex = 33
        Me.Label2_4.Text = "Point 5:"
        '
        'Label2_3
        '
        Me.Label2_3.BackColor = System.Drawing.Color.Transparent
        Me.Label2_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_3.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_3.Location = New System.Drawing.Point(16, 180)
        Me.Label2_3.Name = "Label2_3"
        Me.Label2_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_3.Size = New System.Drawing.Size(66, 20)
        Me.Label2_3.TabIndex = 32
        Me.Label2_3.Text = "Point 4:"
        '
        'Label2_2
        '
        Me.Label2_2.BackColor = System.Drawing.Color.Transparent
        Me.Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_2.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_2.Location = New System.Drawing.Point(16, 153)
        Me.Label2_2.Name = "Label2_2"
        Me.Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_2.Size = New System.Drawing.Size(66, 20)
        Me.Label2_2.TabIndex = 31
        Me.Label2_2.Text = "Point 3:"
        '
        'Label2_1
        '
        Me.Label2_1.BackColor = System.Drawing.Color.Transparent
        Me.Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_1.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_1.Location = New System.Drawing.Point(16, 125)
        Me.Label2_1.Name = "Label2_1"
        Me.Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_1.Size = New System.Drawing.Size(66, 20)
        Me.Label2_1.TabIndex = 30
        Me.Label2_1.Text = "Point 2:"
        '
        'Label2_0
        '
        Me.Label2_0.BackColor = System.Drawing.Color.Transparent
        Me.Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_0.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_0.Location = New System.Drawing.Point(16, 98)
        Me.Label2_0.Name = "Label2_0"
        Me.Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_0.Size = New System.Drawing.Size(66, 20)
        Me.Label2_0.TabIndex = 29
        Me.Label2_0.Text = "Point 1:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(247, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Bell Count :"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(21, 17)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(635, 28)
        Me.lblMessage.TabIndex = 26
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtHour15
        '
        Me.txtHour15.AcceptsReturn = True
        Me.txtHour15.AutoSize = False
        Me.txtHour15.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour15.Location = New System.Drawing.Point(332, 289)
        Me.txtHour15.MaxLength = 0
        Me.txtHour15.Name = "txtHour15"
        Me.txtHour15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour15.Size = New System.Drawing.Size(42, 28)
        Me.txtHour15.TabIndex = 70
        Me.txtHour15.Text = ""
        '
        'txtMinute15
        '
        Me.txtMinute15.AcceptsReturn = True
        Me.txtMinute15.AutoSize = False
        Me.txtMinute15.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute15.Location = New System.Drawing.Point(392, 289)
        Me.txtMinute15.MaxLength = 0
        Me.txtMinute15.Name = "txtMinute15"
        Me.txtMinute15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute15.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute15.TabIndex = 71
        Me.txtMinute15.Text = ""
        '
        'txtMinute14
        '
        Me.txtMinute14.AcceptsReturn = True
        Me.txtMinute14.AutoSize = False
        Me.txtMinute14.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute14.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute14.Location = New System.Drawing.Point(392, 261)
        Me.txtMinute14.MaxLength = 0
        Me.txtMinute14.Name = "txtMinute14"
        Me.txtMinute14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute14.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute14.TabIndex = 68
        Me.txtMinute14.Text = ""
        '
        'txtHour14
        '
        Me.txtHour14.AcceptsReturn = True
        Me.txtHour14.AutoSize = False
        Me.txtHour14.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour14.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour14.Location = New System.Drawing.Point(332, 261)
        Me.txtHour14.MaxLength = 0
        Me.txtHour14.Name = "txtHour14"
        Me.txtHour14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour14.Size = New System.Drawing.Size(42, 28)
        Me.txtHour14.TabIndex = 67
        Me.txtHour14.Text = ""
        '
        'txtHour13
        '
        Me.txtHour13.AcceptsReturn = True
        Me.txtHour13.AutoSize = False
        Me.txtHour13.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour13.Location = New System.Drawing.Point(332, 233)
        Me.txtHour13.MaxLength = 0
        Me.txtHour13.Name = "txtHour13"
        Me.txtHour13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour13.Size = New System.Drawing.Size(42, 28)
        Me.txtHour13.TabIndex = 64
        Me.txtHour13.Text = ""
        '
        'txtMinute13
        '
        Me.txtMinute13.AcceptsReturn = True
        Me.txtMinute13.AutoSize = False
        Me.txtMinute13.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute13.Location = New System.Drawing.Point(392, 233)
        Me.txtMinute13.MaxLength = 0
        Me.txtMinute13.Name = "txtMinute13"
        Me.txtMinute13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute13.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute13.TabIndex = 65
        Me.txtMinute13.Text = ""
        '
        'txtMinute12
        '
        Me.txtMinute12.AcceptsReturn = True
        Me.txtMinute12.AutoSize = False
        Me.txtMinute12.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute12.Location = New System.Drawing.Point(392, 205)
        Me.txtMinute12.MaxLength = 0
        Me.txtMinute12.Name = "txtMinute12"
        Me.txtMinute12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute12.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute12.TabIndex = 62
        Me.txtMinute12.Text = ""
        '
        'txtHour12
        '
        Me.txtHour12.AcceptsReturn = True
        Me.txtHour12.AutoSize = False
        Me.txtHour12.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour12.Location = New System.Drawing.Point(332, 205)
        Me.txtHour12.MaxLength = 0
        Me.txtHour12.Name = "txtHour12"
        Me.txtHour12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour12.Size = New System.Drawing.Size(42, 28)
        Me.txtHour12.TabIndex = 61
        Me.txtHour12.Text = ""
        '
        'txtHour11
        '
        Me.txtHour11.AcceptsReturn = True
        Me.txtHour11.AutoSize = False
        Me.txtHour11.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour11.Location = New System.Drawing.Point(332, 177)
        Me.txtHour11.MaxLength = 0
        Me.txtHour11.Name = "txtHour11"
        Me.txtHour11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour11.Size = New System.Drawing.Size(42, 28)
        Me.txtHour11.TabIndex = 58
        Me.txtHour11.Text = ""
        '
        'txtMinute11
        '
        Me.txtMinute11.AcceptsReturn = True
        Me.txtMinute11.AutoSize = False
        Me.txtMinute11.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute11.Location = New System.Drawing.Point(392, 177)
        Me.txtMinute11.MaxLength = 0
        Me.txtMinute11.Name = "txtMinute11"
        Me.txtMinute11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute11.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute11.TabIndex = 59
        Me.txtMinute11.Text = ""
        '
        'txtMinute10
        '
        Me.txtMinute10.AcceptsReturn = True
        Me.txtMinute10.AutoSize = False
        Me.txtMinute10.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute10.Location = New System.Drawing.Point(392, 150)
        Me.txtMinute10.MaxLength = 0
        Me.txtMinute10.Name = "txtMinute10"
        Me.txtMinute10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute10.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute10.TabIndex = 56
        Me.txtMinute10.Text = ""
        '
        'txtHour10
        '
        Me.txtHour10.AcceptsReturn = True
        Me.txtHour10.AutoSize = False
        Me.txtHour10.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour10.Location = New System.Drawing.Point(332, 150)
        Me.txtHour10.MaxLength = 0
        Me.txtHour10.Name = "txtHour10"
        Me.txtHour10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour10.Size = New System.Drawing.Size(42, 28)
        Me.txtHour10.TabIndex = 55
        Me.txtHour10.Text = ""
        '
        'txtHour9
        '
        Me.txtHour9.AcceptsReturn = True
        Me.txtHour9.AutoSize = False
        Me.txtHour9.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour9.Location = New System.Drawing.Point(332, 122)
        Me.txtHour9.MaxLength = 0
        Me.txtHour9.Name = "txtHour9"
        Me.txtHour9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour9.Size = New System.Drawing.Size(42, 28)
        Me.txtHour9.TabIndex = 52
        Me.txtHour9.Text = ""
        '
        'txtMinute9
        '
        Me.txtMinute9.AcceptsReturn = True
        Me.txtMinute9.AutoSize = False
        Me.txtMinute9.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute9.Location = New System.Drawing.Point(392, 122)
        Me.txtMinute9.MaxLength = 0
        Me.txtMinute9.Name = "txtMinute9"
        Me.txtMinute9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute9.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute9.TabIndex = 53
        Me.txtMinute9.Text = ""
        '
        'txtMinute8
        '
        Me.txtMinute8.AcceptsReturn = True
        Me.txtMinute8.AutoSize = False
        Me.txtMinute8.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute8.Location = New System.Drawing.Point(392, 94)
        Me.txtMinute8.MaxLength = 0
        Me.txtMinute8.Name = "txtMinute8"
        Me.txtMinute8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute8.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute8.TabIndex = 50
        Me.txtMinute8.Text = ""
        '
        'txtHour8
        '
        Me.txtHour8.AcceptsReturn = True
        Me.txtHour8.AutoSize = False
        Me.txtHour8.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour8.Location = New System.Drawing.Point(332, 94)
        Me.txtHour8.MaxLength = 0
        Me.txtHour8.Name = "txtHour8"
        Me.txtHour8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour8.Size = New System.Drawing.Size(42, 28)
        Me.txtHour8.TabIndex = 49
        Me.txtHour8.Text = ""
        '
        'chkValid15
        '
        Me.chkValid15.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid15.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid15.Location = New System.Drawing.Point(306, 292)
        Me.chkValid15.Name = "chkValid15"
        Me.chkValid15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid15.Size = New System.Drawing.Size(14, 20)
        Me.chkValid15.TabIndex = 69
        Me.chkValid15.Text = "Time1"
        '
        'chkValid14
        '
        Me.chkValid14.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid14.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid14.Location = New System.Drawing.Point(306, 264)
        Me.chkValid14.Name = "chkValid14"
        Me.chkValid14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid14.Size = New System.Drawing.Size(14, 20)
        Me.chkValid14.TabIndex = 66
        Me.chkValid14.Text = "Time1"
        '
        'chkValid13
        '
        Me.chkValid13.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid13.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid13.Location = New System.Drawing.Point(306, 236)
        Me.chkValid13.Name = "chkValid13"
        Me.chkValid13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid13.Size = New System.Drawing.Size(14, 20)
        Me.chkValid13.TabIndex = 63
        Me.chkValid13.Text = "Time1"
        '
        'chkValid12
        '
        Me.chkValid12.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid12.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid12.Location = New System.Drawing.Point(306, 208)
        Me.chkValid12.Name = "chkValid12"
        Me.chkValid12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid12.Size = New System.Drawing.Size(14, 20)
        Me.chkValid12.TabIndex = 60
        Me.chkValid12.Text = "Time1"
        '
        'chkValid11
        '
        Me.chkValid11.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid11.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid11.Location = New System.Drawing.Point(306, 180)
        Me.chkValid11.Name = "chkValid11"
        Me.chkValid11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid11.Size = New System.Drawing.Size(14, 20)
        Me.chkValid11.TabIndex = 57
        Me.chkValid11.Text = "Time1"
        '
        'chkValid10
        '
        Me.chkValid10.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid10.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid10.Location = New System.Drawing.Point(306, 153)
        Me.chkValid10.Name = "chkValid10"
        Me.chkValid10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid10.Size = New System.Drawing.Size(14, 20)
        Me.chkValid10.TabIndex = 54
        Me.chkValid10.Text = "Time1"
        '
        'chkValid9
        '
        Me.chkValid9.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid9.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid9.Location = New System.Drawing.Point(306, 125)
        Me.chkValid9.Name = "chkValid9"
        Me.chkValid9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid9.Size = New System.Drawing.Size(14, 20)
        Me.chkValid9.TabIndex = 51
        Me.chkValid9.Text = "Time1"
        '
        'chkValid8
        '
        Me.chkValid8.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid8.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid8.Location = New System.Drawing.Point(306, 98)
        Me.chkValid8.Name = "chkValid8"
        Me.chkValid8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid8.Size = New System.Drawing.Size(14, 20)
        Me.chkValid8.TabIndex = 48
        Me.chkValid8.Text = "Time1"
        '
        'Label2_24
        '
        Me.Label2_24.BackColor = System.Drawing.Color.Transparent
        Me.Label2_24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_24.Location = New System.Drawing.Point(382, 98)
        Me.Label2_24.Name = "Label2_24"
        Me.Label2_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_24.Size = New System.Drawing.Size(6, 20)
        Me.Label2_24.TabIndex = 87
        Me.Label2_24.Text = ":"
        Me.Label2_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_31
        '
        Me.Label2_31.BackColor = System.Drawing.Color.Transparent
        Me.Label2_31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_31.Location = New System.Drawing.Point(382, 292)
        Me.Label2_31.Name = "Label2_31"
        Me.Label2_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_31.Size = New System.Drawing.Size(6, 20)
        Me.Label2_31.TabIndex = 86
        Me.Label2_31.Text = ":"
        Me.Label2_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_30
        '
        Me.Label2_30.BackColor = System.Drawing.Color.Transparent
        Me.Label2_30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_30.Location = New System.Drawing.Point(382, 264)
        Me.Label2_30.Name = "Label2_30"
        Me.Label2_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_30.Size = New System.Drawing.Size(6, 20)
        Me.Label2_30.TabIndex = 85
        Me.Label2_30.Text = ":"
        Me.Label2_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_29
        '
        Me.Label2_29.BackColor = System.Drawing.Color.Transparent
        Me.Label2_29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_29.Location = New System.Drawing.Point(382, 236)
        Me.Label2_29.Name = "Label2_29"
        Me.Label2_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_29.Size = New System.Drawing.Size(6, 20)
        Me.Label2_29.TabIndex = 84
        Me.Label2_29.Text = ":"
        Me.Label2_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_28
        '
        Me.Label2_28.BackColor = System.Drawing.Color.Transparent
        Me.Label2_28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_28.Location = New System.Drawing.Point(382, 208)
        Me.Label2_28.Name = "Label2_28"
        Me.Label2_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_28.Size = New System.Drawing.Size(6, 20)
        Me.Label2_28.TabIndex = 83
        Me.Label2_28.Text = ":"
        Me.Label2_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_27
        '
        Me.Label2_27.BackColor = System.Drawing.Color.Transparent
        Me.Label2_27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_27.Location = New System.Drawing.Point(382, 180)
        Me.Label2_27.Name = "Label2_27"
        Me.Label2_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_27.Size = New System.Drawing.Size(6, 20)
        Me.Label2_27.TabIndex = 82
        Me.Label2_27.Text = ":"
        Me.Label2_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_26
        '
        Me.Label2_26.BackColor = System.Drawing.Color.Transparent
        Me.Label2_26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_26.Location = New System.Drawing.Point(382, 153)
        Me.Label2_26.Name = "Label2_26"
        Me.Label2_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_26.Size = New System.Drawing.Size(6, 20)
        Me.Label2_26.TabIndex = 81
        Me.Label2_26.Text = ":"
        Me.Label2_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_25
        '
        Me.Label2_25.BackColor = System.Drawing.Color.Transparent
        Me.Label2_25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_25.Location = New System.Drawing.Point(382, 125)
        Me.Label2_25.Name = "Label2_25"
        Me.Label2_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_25.Size = New System.Drawing.Size(6, 20)
        Me.Label2_25.TabIndex = 80
        Me.Label2_25.Text = ":"
        Me.Label2_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_23
        '
        Me.Label2_23.BackColor = System.Drawing.Color.Transparent
        Me.Label2_23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_23.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_23.Location = New System.Drawing.Point(236, 292)
        Me.Label2_23.Name = "Label2_23"
        Me.Label2_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_23.Size = New System.Drawing.Size(66, 20)
        Me.Label2_23.TabIndex = 79
        Me.Label2_23.Text = "Point 16:"
        '
        'Label2_22
        '
        Me.Label2_22.BackColor = System.Drawing.Color.Transparent
        Me.Label2_22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_22.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_22.Location = New System.Drawing.Point(236, 264)
        Me.Label2_22.Name = "Label2_22"
        Me.Label2_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_22.Size = New System.Drawing.Size(66, 20)
        Me.Label2_22.TabIndex = 78
        Me.Label2_22.Text = "Point 15:"
        '
        'Label2_21
        '
        Me.Label2_21.BackColor = System.Drawing.Color.Transparent
        Me.Label2_21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_21.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_21.Location = New System.Drawing.Point(236, 236)
        Me.Label2_21.Name = "Label2_21"
        Me.Label2_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_21.Size = New System.Drawing.Size(66, 20)
        Me.Label2_21.TabIndex = 77
        Me.Label2_21.Text = "Point 14:"
        '
        'Label2_20
        '
        Me.Label2_20.BackColor = System.Drawing.Color.Transparent
        Me.Label2_20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_20.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_20.Location = New System.Drawing.Point(236, 208)
        Me.Label2_20.Name = "Label2_20"
        Me.Label2_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_20.Size = New System.Drawing.Size(66, 20)
        Me.Label2_20.TabIndex = 76
        Me.Label2_20.Text = "Point 13:"
        '
        'Label2_19
        '
        Me.Label2_19.BackColor = System.Drawing.Color.Transparent
        Me.Label2_19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_19.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_19.Location = New System.Drawing.Point(236, 180)
        Me.Label2_19.Name = "Label2_19"
        Me.Label2_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_19.Size = New System.Drawing.Size(66, 20)
        Me.Label2_19.TabIndex = 75
        Me.Label2_19.Text = "Point 12:"
        '
        'Label2_18
        '
        Me.Label2_18.BackColor = System.Drawing.Color.Transparent
        Me.Label2_18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_18.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_18.Location = New System.Drawing.Point(236, 153)
        Me.Label2_18.Name = "Label2_18"
        Me.Label2_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_18.Size = New System.Drawing.Size(66, 20)
        Me.Label2_18.TabIndex = 74
        Me.Label2_18.Text = "Point 11:"
        '
        'Label2_17
        '
        Me.Label2_17.BackColor = System.Drawing.Color.Transparent
        Me.Label2_17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_17.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_17.Location = New System.Drawing.Point(236, 125)
        Me.Label2_17.Name = "Label2_17"
        Me.Label2_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_17.Size = New System.Drawing.Size(66, 20)
        Me.Label2_17.TabIndex = 73
        Me.Label2_17.Text = "Point 10:"
        '
        'Label2_16
        '
        Me.Label2_16.BackColor = System.Drawing.Color.Transparent
        Me.Label2_16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_16.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_16.Location = New System.Drawing.Point(236, 98)
        Me.Label2_16.Name = "Label2_16"
        Me.Label2_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_16.Size = New System.Drawing.Size(66, 20)
        Me.Label2_16.TabIndex = 72
        Me.Label2_16.Text = "Point 9:"
        '
        'txtHour23
        '
        Me.txtHour23.AcceptsReturn = True
        Me.txtHour23.AutoSize = False
        Me.txtHour23.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour23.Location = New System.Drawing.Point(552, 289)
        Me.txtHour23.MaxLength = 0
        Me.txtHour23.Name = "txtHour23"
        Me.txtHour23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour23.Size = New System.Drawing.Size(42, 28)
        Me.txtHour23.TabIndex = 110
        Me.txtHour23.Text = ""
        '
        'txtMinute23
        '
        Me.txtMinute23.AcceptsReturn = True
        Me.txtMinute23.AutoSize = False
        Me.txtMinute23.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute23.Location = New System.Drawing.Point(612, 289)
        Me.txtMinute23.MaxLength = 0
        Me.txtMinute23.Name = "txtMinute23"
        Me.txtMinute23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute23.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute23.TabIndex = 111
        Me.txtMinute23.Text = ""
        '
        'txtMinute22
        '
        Me.txtMinute22.AcceptsReturn = True
        Me.txtMinute22.AutoSize = False
        Me.txtMinute22.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute22.Location = New System.Drawing.Point(612, 261)
        Me.txtMinute22.MaxLength = 0
        Me.txtMinute22.Name = "txtMinute22"
        Me.txtMinute22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute22.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute22.TabIndex = 108
        Me.txtMinute22.Text = ""
        '
        'txtHour22
        '
        Me.txtHour22.AcceptsReturn = True
        Me.txtHour22.AutoSize = False
        Me.txtHour22.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour22.Location = New System.Drawing.Point(552, 261)
        Me.txtHour22.MaxLength = 0
        Me.txtHour22.Name = "txtHour22"
        Me.txtHour22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour22.Size = New System.Drawing.Size(42, 28)
        Me.txtHour22.TabIndex = 107
        Me.txtHour22.Text = ""
        '
        'txtHour21
        '
        Me.txtHour21.AcceptsReturn = True
        Me.txtHour21.AutoSize = False
        Me.txtHour21.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour21.Location = New System.Drawing.Point(552, 233)
        Me.txtHour21.MaxLength = 0
        Me.txtHour21.Name = "txtHour21"
        Me.txtHour21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour21.Size = New System.Drawing.Size(42, 28)
        Me.txtHour21.TabIndex = 104
        Me.txtHour21.Text = ""
        '
        'txtMinute21
        '
        Me.txtMinute21.AcceptsReturn = True
        Me.txtMinute21.AutoSize = False
        Me.txtMinute21.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute21.Location = New System.Drawing.Point(612, 233)
        Me.txtMinute21.MaxLength = 0
        Me.txtMinute21.Name = "txtMinute21"
        Me.txtMinute21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute21.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute21.TabIndex = 105
        Me.txtMinute21.Text = ""
        '
        'txtMinute20
        '
        Me.txtMinute20.AcceptsReturn = True
        Me.txtMinute20.AutoSize = False
        Me.txtMinute20.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute20.Location = New System.Drawing.Point(612, 205)
        Me.txtMinute20.MaxLength = 0
        Me.txtMinute20.Name = "txtMinute20"
        Me.txtMinute20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute20.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute20.TabIndex = 102
        Me.txtMinute20.Text = ""
        '
        'txtHour20
        '
        Me.txtHour20.AcceptsReturn = True
        Me.txtHour20.AutoSize = False
        Me.txtHour20.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour20.Location = New System.Drawing.Point(552, 205)
        Me.txtHour20.MaxLength = 0
        Me.txtHour20.Name = "txtHour20"
        Me.txtHour20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour20.Size = New System.Drawing.Size(42, 28)
        Me.txtHour20.TabIndex = 101
        Me.txtHour20.Text = ""
        '
        'txtHour19
        '
        Me.txtHour19.AcceptsReturn = True
        Me.txtHour19.AutoSize = False
        Me.txtHour19.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour19.Location = New System.Drawing.Point(552, 177)
        Me.txtHour19.MaxLength = 0
        Me.txtHour19.Name = "txtHour19"
        Me.txtHour19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour19.Size = New System.Drawing.Size(42, 28)
        Me.txtHour19.TabIndex = 98
        Me.txtHour19.Text = ""
        '
        'txtMinute19
        '
        Me.txtMinute19.AcceptsReturn = True
        Me.txtMinute19.AutoSize = False
        Me.txtMinute19.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute19.Location = New System.Drawing.Point(612, 177)
        Me.txtMinute19.MaxLength = 0
        Me.txtMinute19.Name = "txtMinute19"
        Me.txtMinute19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute19.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute19.TabIndex = 99
        Me.txtMinute19.Text = ""
        '
        'txtMinute18
        '
        Me.txtMinute18.AcceptsReturn = True
        Me.txtMinute18.AutoSize = False
        Me.txtMinute18.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute18.Location = New System.Drawing.Point(612, 150)
        Me.txtMinute18.MaxLength = 0
        Me.txtMinute18.Name = "txtMinute18"
        Me.txtMinute18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute18.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute18.TabIndex = 96
        Me.txtMinute18.Text = ""
        '
        'txtHour18
        '
        Me.txtHour18.AcceptsReturn = True
        Me.txtHour18.AutoSize = False
        Me.txtHour18.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour18.Location = New System.Drawing.Point(552, 150)
        Me.txtHour18.MaxLength = 0
        Me.txtHour18.Name = "txtHour18"
        Me.txtHour18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour18.Size = New System.Drawing.Size(42, 28)
        Me.txtHour18.TabIndex = 95
        Me.txtHour18.Text = ""
        '
        'txtHour17
        '
        Me.txtHour17.AcceptsReturn = True
        Me.txtHour17.AutoSize = False
        Me.txtHour17.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour17.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour17.Location = New System.Drawing.Point(552, 122)
        Me.txtHour17.MaxLength = 0
        Me.txtHour17.Name = "txtHour17"
        Me.txtHour17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour17.Size = New System.Drawing.Size(42, 28)
        Me.txtHour17.TabIndex = 92
        Me.txtHour17.Text = ""
        '
        'txtMinute17
        '
        Me.txtMinute17.AcceptsReturn = True
        Me.txtMinute17.AutoSize = False
        Me.txtMinute17.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute17.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute17.Location = New System.Drawing.Point(612, 122)
        Me.txtMinute17.MaxLength = 0
        Me.txtMinute17.Name = "txtMinute17"
        Me.txtMinute17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute17.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute17.TabIndex = 93
        Me.txtMinute17.Text = ""
        '
        'txtMinute16
        '
        Me.txtMinute16.AcceptsReturn = True
        Me.txtMinute16.AutoSize = False
        Me.txtMinute16.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinute16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinute16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinute16.Location = New System.Drawing.Point(612, 94)
        Me.txtMinute16.MaxLength = 0
        Me.txtMinute16.Name = "txtMinute16"
        Me.txtMinute16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinute16.Size = New System.Drawing.Size(42, 28)
        Me.txtMinute16.TabIndex = 90
        Me.txtMinute16.Text = ""
        '
        'txtHour16
        '
        Me.txtHour16.AcceptsReturn = True
        Me.txtHour16.AutoSize = False
        Me.txtHour16.BackColor = System.Drawing.SystemColors.Window
        Me.txtHour16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHour16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHour16.Location = New System.Drawing.Point(552, 94)
        Me.txtHour16.MaxLength = 0
        Me.txtHour16.Name = "txtHour16"
        Me.txtHour16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHour16.Size = New System.Drawing.Size(42, 28)
        Me.txtHour16.TabIndex = 89
        Me.txtHour16.Text = ""
        '
        'chkValid23
        '
        Me.chkValid23.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid23.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid23.Location = New System.Drawing.Point(526, 292)
        Me.chkValid23.Name = "chkValid23"
        Me.chkValid23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid23.Size = New System.Drawing.Size(14, 20)
        Me.chkValid23.TabIndex = 109
        Me.chkValid23.Text = "Time1"
        '
        'chkValid22
        '
        Me.chkValid22.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid22.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid22.Location = New System.Drawing.Point(526, 264)
        Me.chkValid22.Name = "chkValid22"
        Me.chkValid22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid22.Size = New System.Drawing.Size(14, 20)
        Me.chkValid22.TabIndex = 106
        Me.chkValid22.Text = "Time1"
        '
        'chkValid21
        '
        Me.chkValid21.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid21.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid21.Location = New System.Drawing.Point(526, 236)
        Me.chkValid21.Name = "chkValid21"
        Me.chkValid21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid21.Size = New System.Drawing.Size(14, 20)
        Me.chkValid21.TabIndex = 103
        Me.chkValid21.Text = "Time1"
        '
        'chkValid20
        '
        Me.chkValid20.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid20.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid20.Location = New System.Drawing.Point(526, 208)
        Me.chkValid20.Name = "chkValid20"
        Me.chkValid20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid20.Size = New System.Drawing.Size(14, 20)
        Me.chkValid20.TabIndex = 100
        Me.chkValid20.Text = "Time1"
        '
        'chkValid19
        '
        Me.chkValid19.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid19.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid19.Location = New System.Drawing.Point(526, 180)
        Me.chkValid19.Name = "chkValid19"
        Me.chkValid19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid19.Size = New System.Drawing.Size(14, 20)
        Me.chkValid19.TabIndex = 97
        Me.chkValid19.Text = "Time1"
        '
        'chkValid18
        '
        Me.chkValid18.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid18.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid18.Location = New System.Drawing.Point(526, 153)
        Me.chkValid18.Name = "chkValid18"
        Me.chkValid18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid18.Size = New System.Drawing.Size(14, 20)
        Me.chkValid18.TabIndex = 94
        Me.chkValid18.Text = "Time1"
        '
        'chkValid17
        '
        Me.chkValid17.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid17.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid17.Location = New System.Drawing.Point(526, 125)
        Me.chkValid17.Name = "chkValid17"
        Me.chkValid17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid17.Size = New System.Drawing.Size(14, 20)
        Me.chkValid17.TabIndex = 91
        Me.chkValid17.Text = "Time1"
        '
        'chkValid16
        '
        Me.chkValid16.BackColor = System.Drawing.SystemColors.Control
        Me.chkValid16.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkValid16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkValid16.Location = New System.Drawing.Point(526, 98)
        Me.chkValid16.Name = "chkValid16"
        Me.chkValid16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkValid16.Size = New System.Drawing.Size(14, 20)
        Me.chkValid16.TabIndex = 88
        Me.chkValid16.Text = "Time1"
        '
        'Label2_40
        '
        Me.Label2_40.BackColor = System.Drawing.Color.Transparent
        Me.Label2_40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_40.Location = New System.Drawing.Point(602, 98)
        Me.Label2_40.Name = "Label2_40"
        Me.Label2_40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_40.Size = New System.Drawing.Size(6, 20)
        Me.Label2_40.TabIndex = 127
        Me.Label2_40.Text = ":"
        Me.Label2_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_47
        '
        Me.Label2_47.BackColor = System.Drawing.Color.Transparent
        Me.Label2_47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_47.Location = New System.Drawing.Point(602, 292)
        Me.Label2_47.Name = "Label2_47"
        Me.Label2_47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_47.Size = New System.Drawing.Size(6, 20)
        Me.Label2_47.TabIndex = 126
        Me.Label2_47.Text = ":"
        Me.Label2_47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_46
        '
        Me.Label2_46.BackColor = System.Drawing.Color.Transparent
        Me.Label2_46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_46.Location = New System.Drawing.Point(602, 264)
        Me.Label2_46.Name = "Label2_46"
        Me.Label2_46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_46.Size = New System.Drawing.Size(6, 20)
        Me.Label2_46.TabIndex = 125
        Me.Label2_46.Text = ":"
        Me.Label2_46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_45
        '
        Me.Label2_45.BackColor = System.Drawing.Color.Transparent
        Me.Label2_45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_45.Location = New System.Drawing.Point(602, 236)
        Me.Label2_45.Name = "Label2_45"
        Me.Label2_45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_45.Size = New System.Drawing.Size(6, 20)
        Me.Label2_45.TabIndex = 124
        Me.Label2_45.Text = ":"
        Me.Label2_45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_44
        '
        Me.Label2_44.BackColor = System.Drawing.Color.Transparent
        Me.Label2_44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_44.Location = New System.Drawing.Point(602, 208)
        Me.Label2_44.Name = "Label2_44"
        Me.Label2_44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_44.Size = New System.Drawing.Size(6, 20)
        Me.Label2_44.TabIndex = 123
        Me.Label2_44.Text = ":"
        Me.Label2_44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_43
        '
        Me.Label2_43.BackColor = System.Drawing.Color.Transparent
        Me.Label2_43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_43.Location = New System.Drawing.Point(602, 180)
        Me.Label2_43.Name = "Label2_43"
        Me.Label2_43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_43.Size = New System.Drawing.Size(6, 20)
        Me.Label2_43.TabIndex = 122
        Me.Label2_43.Text = ":"
        Me.Label2_43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_42
        '
        Me.Label2_42.BackColor = System.Drawing.Color.Transparent
        Me.Label2_42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_42.Location = New System.Drawing.Point(602, 153)
        Me.Label2_42.Name = "Label2_42"
        Me.Label2_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_42.Size = New System.Drawing.Size(6, 20)
        Me.Label2_42.TabIndex = 121
        Me.Label2_42.Text = ":"
        Me.Label2_42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_41
        '
        Me.Label2_41.BackColor = System.Drawing.Color.Transparent
        Me.Label2_41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_41.Location = New System.Drawing.Point(602, 125)
        Me.Label2_41.Name = "Label2_41"
        Me.Label2_41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_41.Size = New System.Drawing.Size(6, 20)
        Me.Label2_41.TabIndex = 120
        Me.Label2_41.Text = ":"
        Me.Label2_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_39
        '
        Me.Label2_39.BackColor = System.Drawing.Color.Transparent
        Me.Label2_39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_39.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_39.Location = New System.Drawing.Point(456, 292)
        Me.Label2_39.Name = "Label2_39"
        Me.Label2_39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_39.Size = New System.Drawing.Size(66, 20)
        Me.Label2_39.TabIndex = 119
        Me.Label2_39.Text = "Point 24:"
        '
        'Label2_38
        '
        Me.Label2_38.BackColor = System.Drawing.Color.Transparent
        Me.Label2_38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_38.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_38.Location = New System.Drawing.Point(456, 264)
        Me.Label2_38.Name = "Label2_38"
        Me.Label2_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_38.Size = New System.Drawing.Size(66, 20)
        Me.Label2_38.TabIndex = 118
        Me.Label2_38.Text = "Point 23:"
        '
        'Label2_37
        '
        Me.Label2_37.BackColor = System.Drawing.Color.Transparent
        Me.Label2_37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_37.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_37.Location = New System.Drawing.Point(456, 236)
        Me.Label2_37.Name = "Label2_37"
        Me.Label2_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_37.Size = New System.Drawing.Size(66, 20)
        Me.Label2_37.TabIndex = 117
        Me.Label2_37.Text = "Point 22:"
        '
        'Label2_36
        '
        Me.Label2_36.BackColor = System.Drawing.Color.Transparent
        Me.Label2_36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_36.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_36.Location = New System.Drawing.Point(456, 208)
        Me.Label2_36.Name = "Label2_36"
        Me.Label2_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_36.Size = New System.Drawing.Size(66, 20)
        Me.Label2_36.TabIndex = 116
        Me.Label2_36.Text = "Point 21:"
        '
        'Label2_35
        '
        Me.Label2_35.BackColor = System.Drawing.Color.Transparent
        Me.Label2_35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_35.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_35.Location = New System.Drawing.Point(456, 180)
        Me.Label2_35.Name = "Label2_35"
        Me.Label2_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_35.Size = New System.Drawing.Size(66, 20)
        Me.Label2_35.TabIndex = 115
        Me.Label2_35.Text = "Point 20:"
        '
        'Label2_34
        '
        Me.Label2_34.BackColor = System.Drawing.Color.Transparent
        Me.Label2_34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_34.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_34.Location = New System.Drawing.Point(456, 153)
        Me.Label2_34.Name = "Label2_34"
        Me.Label2_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_34.Size = New System.Drawing.Size(66, 20)
        Me.Label2_34.TabIndex = 114
        Me.Label2_34.Text = "Point 19:"
        '
        'Label2_33
        '
        Me.Label2_33.BackColor = System.Drawing.Color.Transparent
        Me.Label2_33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_33.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_33.Location = New System.Drawing.Point(456, 125)
        Me.Label2_33.Name = "Label2_33"
        Me.Label2_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_33.Size = New System.Drawing.Size(66, 20)
        Me.Label2_33.TabIndex = 113
        Me.Label2_33.Text = "Point 18:"
        '
        'Label2_32
        '
        Me.Label2_32.BackColor = System.Drawing.Color.Transparent
        Me.Label2_32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2_32.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2_32.Location = New System.Drawing.Point(456, 98)
        Me.Label2_32.Name = "Label2_32"
        Me.Label2_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2_32.Size = New System.Drawing.Size(66, 20)
        Me.Label2_32.TabIndex = 112
        Me.Label2_32.Text = "Point 17:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(238, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(202, 20)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Point   UseFlag   Start Time"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(458, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(202, 20)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Point   UseFlag   Start Time"
        '
        'frmBellInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(666, 384)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label3, Me.txtHour23, Me.txtMinute23, Me.txtMinute22, Me.txtHour22, Me.txtHour21, Me.txtMinute21, Me.txtMinute20, Me.txtHour20, Me.txtHour19, Me.txtMinute19, Me.txtMinute18, Me.txtHour18, Me.txtHour17, Me.txtMinute17, Me.txtMinute16, Me.txtHour16, Me.chkValid23, Me.chkValid22, Me.chkValid21, Me.chkValid20, Me.chkValid19, Me.chkValid18, Me.chkValid17, Me.chkValid16, Me.Label2_40, Me.Label2_47, Me.Label2_46, Me.Label2_45, Me.Label2_44, Me.Label2_43, Me.Label2_42, Me.Label2_41, Me.Label2_39, Me.Label2_38, Me.Label2_37, Me.Label2_36, Me.Label2_35, Me.Label2_34, Me.Label2_33, Me.Label2_32, Me.txtHour15, Me.txtMinute15, Me.txtMinute14, Me.txtHour14, Me.txtHour13, Me.txtMinute13, Me.txtMinute12, Me.txtHour12, Me.txtHour11, Me.txtMinute11, Me.txtMinute10, Me.txtHour10, Me.txtHour9, Me.txtMinute9, Me.txtMinute8, Me.txtHour8, Me.chkValid15, Me.chkValid14, Me.chkValid13, Me.chkValid12, Me.chkValid11, Me.chkValid10, Me.chkValid9, Me.chkValid8, Me.Label2_24, Me.Label2_31, Me.Label2_30, Me.Label2_29, Me.Label2_28, Me.Label2_27, Me.Label2_26, Me.Label2_25, Me.Label2_23, Me.Label2_22, Me.Label2_21, Me.Label2_20, Me.Label2_19, Me.Label2_18, Me.Label2_17, Me.Label2_16, Me.txtBellCount, Me.txtHour7, Me.txtMinute7, Me.txtMinute6, Me.txtHour6, Me.txtHour5, Me.txtMinute5, Me.txtMinute4, Me.txtHour4, Me.txtHour3, Me.txtMinute3, Me.txtMinute2, Me.txtHour2, Me.txtHour1, Me.txtMinute1, Me.txtMinute0, Me.txtHour0, Me.chkValid7, Me.chkValid6, Me.chkValid5, Me.chkValid4, Me.chkValid3, Me.chkValid2, Me.chkValid1, Me.chkValid0, Me.cmdWrite, Me.cmdRead, Me.Label2_8, Me.Label2_15, Me.Label2_14, Me.Label2_13, Me.Label2_12, Me.Label2_11, Me.Label2_10, Me.Label2_9, Me.lblCaption0, Me.Label2_7, Me.Label2_6, Me.Label2_5, Me.Label2_4, Me.Label2_3, Me.Label2_2, Me.Label2_1, Me.Label2_0, Me.Label1, Me.lblMessage})
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBellInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Bell Time"
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private fnCommHandleIndex As Long
    Private mBellCount As Integer
    Private mBellInfo As BellInfo

    Private fchkValid(MAX_BELLCOUNT_DAY - 1) As CheckBox
    Private ftxtHour(MAX_BELLCOUNT_DAY - 1) As TextBox
    Private ftxtMinute(MAX_BELLCOUNT_DAY - 1) As TextBox

    Private Sub frmBellInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vnii As Integer
        Dim vnLen As Integer
        Dim vstrItem As String
        Dim vstrName As String
        Dim vtObject As Object

        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        mBellInfo.Initialize()

        For Each vtObject In Controls
            If Not IsNothing(vtObject) Then
                vstrName = vtObject.Name

                vstrItem = "chkValid"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    fchkValid(vnii) = vtObject
                    GoTo lp_loop
                End If

                vstrItem = "txtHour"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtHour(vnii) = vtObject
                    GoTo lp_loop
                End If

                vstrItem = "txtMinute"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtMinute(vnii) = vtObject
                    GoTo lp_loop
                End If
            End If
lp_loop:
        Next vtObject
        ShowValue()
    End Sub

    Private Sub cmdRead_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRead.Click
        Dim vstrBellInfo As String
        Dim vnResultCode As Integer

        cmdRead.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdRead.Enabled = True
            Exit Sub
        End If

        vstrBellInfo = Space(256)
        vnResultCode = FK_GetBellTimeWithString(fnCommHandleIndex, mBellCount, vstrBellInfo)
        lblMessage.Text = ReturnResultPrint(vnResultCode)
        If vnResultCode = RUN_SUCCESS Then
            mBellInfo = ConvertStringToMarshalStructure(vstrBellInfo, 1)
            ShowValue()
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdRead.Enabled = True
    End Sub

    Private Sub cmdWrite_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWrite.Click
        Dim vstrBellInfo As String
        Dim vnResultCode As Integer

        cmdWrite.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        GetValue()

        vstrBellInfo = ConvertMarshalStructureToString(mBellInfo)
        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdWrite.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_SetBellTimeWithString(fnCommHandleIndex, mBellCount, vstrBellInfo)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdWrite.Enabled = True
    End Sub

    Private Sub ShowValue()
        On Error Resume Next
        Dim vnii As Integer

        For vnii = 0 To MAX_BELLCOUNT_DAY - 1
            ftxtHour(vnii).Text = CStr(mBellInfo.mHour(vnii))
            ftxtMinute(vnii).Text = CStr(mBellInfo.mMinute(vnii))
            If mBellInfo.mValid(vnii) > 1 Then mBellInfo.mValid(vnii) = 0
            fchkValid(vnii).CheckState = mBellInfo.mValid(vnii)
        Next vnii
        txtBellCount.Text = CStr(mBellCount)
    End Sub

    Private Sub GetValue()
        On Error Resume Next
        Dim vnii As Integer

        For vnii = 0 To MAX_BELLCOUNT_DAY - 1
            mBellInfo.mHour(vnii) = CByte(ftxtHour(vnii).Text)
            mBellInfo.mMinute(vnii) = CByte(ftxtMinute(vnii).Text)
            mBellInfo.mValid(vnii) = fchkValid(vnii).CheckState
        Next vnii
        mBellCount = Val(txtBellCount.Text)
    End Sub

End Class