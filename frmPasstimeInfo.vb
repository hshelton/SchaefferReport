Option Strict Off
Option Explicit On 

Public Class frmPasstimeInfo
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents lblMidSep6 As System.Windows.Forms.Label
    Public WithEvents txtEndHour0 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute0 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute0 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour0 As System.Windows.Forms.TextBox
    Public WithEvents txtEndHour4 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute4 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute3 As System.Windows.Forms.TextBox
    Public WithEvents txtEndHour3 As System.Windows.Forms.TextBox
    Public WithEvents txtEndHour2 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute2 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute1 As System.Windows.Forms.TextBox
    Public WithEvents txtEndHour1 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute4 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour4 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour3 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute3 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute2 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour2 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour1 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute1 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour5 As System.Windows.Forms.TextBox
    Public WithEvents txtStartHour6 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute5 As System.Windows.Forms.TextBox
    Public WithEvents txtStartMinute6 As System.Windows.Forms.TextBox
    Public WithEvents txtEndHour5 As System.Windows.Forms.TextBox
    Public WithEvents txtEndHour6 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute5 As System.Windows.Forms.TextBox
    Public WithEvents txtEndMinute6 As System.Windows.Forms.TextBox
    Public WithEvents lblStartSep6 As System.Windows.Forms.Label
    Public WithEvents lblEndSep6 As System.Windows.Forms.Label
    Public WithEvents lblEndSep5 As System.Windows.Forms.Label
    Public WithEvents lblEndSep4 As System.Windows.Forms.Label
    Public WithEvents lblEndSep3 As System.Windows.Forms.Label
    Public WithEvents lblEndSep2 As System.Windows.Forms.Label
    Public WithEvents lblEndSep1 As System.Windows.Forms.Label
    Public WithEvents lblEndSep0 As System.Windows.Forms.Label
    Public WithEvents lblStartSep5 As System.Windows.Forms.Label
    Public WithEvents lblStartSep4 As System.Windows.Forms.Label
    Public WithEvents lblStartSep3 As System.Windows.Forms.Label
    Public WithEvents lblStartSep2 As System.Windows.Forms.Label
    Public WithEvents lblStartSep1 As System.Windows.Forms.Label
    Public WithEvents lblMidSep5 As System.Windows.Forms.Label
    Public WithEvents lblMidSep4 As System.Windows.Forms.Label
    Public WithEvents lblMidSep0 As System.Windows.Forms.Label
    Public WithEvents lblStartSep0 As System.Windows.Forms.Label
    Public WithEvents lblMidSep3 As System.Windows.Forms.Label
    Public WithEvents lblMidSep2 As System.Windows.Forms.Label
    Public WithEvents lblMidSep1 As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    Public WithEvents lblStartTime As System.Windows.Forms.Label
    Public WithEvents lblEndTime As System.Windows.Forms.Label
    Public WithEvents txtPassTimeID As System.Windows.Forms.TextBox
    Public WithEvents lblLabel8 As System.Windows.Forms.Label
    Public WithEvents lblWeek0 As System.Windows.Forms.Label
    Public WithEvents lblWeek6 As System.Windows.Forms.Label
    Public WithEvents lblWeek5 As System.Windows.Forms.Label
    Public WithEvents lblWeek4 As System.Windows.Forms.Label
    Public WithEvents lblWeek3 As System.Windows.Forms.Label
    Public WithEvents lblWeek2 As System.Windows.Forms.Label
    Public WithEvents lblWeek1 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtUserPassTime2 As System.Windows.Forms.TextBox
    Public WithEvents txtUserPassTime1 As System.Windows.Forms.TextBox
    Public WithEvents txtUserPassTime0 As System.Windows.Forms.TextBox
    Public WithEvents txtUserID As System.Windows.Forms.TextBox
    Public WithEvents txtGroupID As System.Windows.Forms.TextBox
    Public WithEvents cmdGetUserPasstime As System.Windows.Forms.Button
    Public WithEvents cmdSetUserPassTime As System.Windows.Forms.Button
    Public WithEvents lblLabel3 As System.Windows.Forms.Label
    Public WithEvents lblLabel2 As System.Windows.Forms.Label
    Public WithEvents lblLabel1 As System.Windows.Forms.Label
    Public WithEvents lblLabel0 As System.Windows.Forms.Label
    Public WithEvents lblUserID As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents txtGroupNum As System.Windows.Forms.TextBox
    Public WithEvents txtGroupPassTime2 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupPassTime1 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupPassTime0 As System.Windows.Forms.TextBox
    Public WithEvents cmdGetGroupPassTime As System.Windows.Forms.Button
    Public WithEvents cmdSetGroupPassTime As System.Windows.Forms.Button
    Public WithEvents _lblLabel_7 As System.Windows.Forms.Label
    Public WithEvents lblLabel6 As System.Windows.Forms.Label
    Public WithEvents lblLabel5 As System.Windows.Forms.Label
    Public WithEvents lblLabel4 As System.Windows.Forms.Label
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents txtGroupMatch9 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch8 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch7 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch6 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch5 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch4 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch3 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch2 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch1 As System.Windows.Forms.TextBox
    Public WithEvents txtGroupMatch0 As System.Windows.Forms.TextBox
    Public WithEvents cmdSetGroupMatch As System.Windows.Forms.Button
    Public WithEvents cmdGetGroupMatch As System.Windows.Forms.Button
    Public WithEvents _lblLabel_10 As System.Windows.Forms.Label
    Public WithEvents lblLabel9 As System.Windows.Forms.Label
    Public WithEvents cmdWrite As System.Windows.Forms.Button
    Public WithEvents cmdRead As System.Windows.Forms.Button
    Public WithEvents cmdGetDoorState As System.Windows.Forms.Button
    Public WithEvents cmdSetDoorState As System.Windows.Forms.Button
    Public WithEvents cmbDoorState As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPasstimeInfo))
        Me.cmdGetDoorState = New System.Windows.Forms.Button()
        Me.cmdSetDoorState = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdWrite = New System.Windows.Forms.Button()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.txtPassTimeID = New System.Windows.Forms.TextBox()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblWeek0 = New System.Windows.Forms.Label()
        Me.lblWeek6 = New System.Windows.Forms.Label()
        Me.lblWeek5 = New System.Windows.Forms.Label()
        Me.lblWeek4 = New System.Windows.Forms.Label()
        Me.lblWeek3 = New System.Windows.Forms.Label()
        Me.lblWeek2 = New System.Windows.Forms.Label()
        Me.lblWeek1 = New System.Windows.Forms.Label()
        Me.lblMidSep6 = New System.Windows.Forms.Label()
        Me.txtEndHour0 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute0 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute0 = New System.Windows.Forms.TextBox()
        Me.txtStartHour0 = New System.Windows.Forms.TextBox()
        Me.txtEndHour4 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute4 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute3 = New System.Windows.Forms.TextBox()
        Me.txtEndHour3 = New System.Windows.Forms.TextBox()
        Me.txtEndHour2 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute2 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute1 = New System.Windows.Forms.TextBox()
        Me.txtEndHour1 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute4 = New System.Windows.Forms.TextBox()
        Me.txtStartHour4 = New System.Windows.Forms.TextBox()
        Me.txtStartHour3 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute3 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute2 = New System.Windows.Forms.TextBox()
        Me.txtStartHour2 = New System.Windows.Forms.TextBox()
        Me.txtStartHour1 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute1 = New System.Windows.Forms.TextBox()
        Me.txtStartHour5 = New System.Windows.Forms.TextBox()
        Me.txtStartHour6 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute5 = New System.Windows.Forms.TextBox()
        Me.txtStartMinute6 = New System.Windows.Forms.TextBox()
        Me.txtEndHour5 = New System.Windows.Forms.TextBox()
        Me.txtEndHour6 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute5 = New System.Windows.Forms.TextBox()
        Me.txtEndMinute6 = New System.Windows.Forms.TextBox()
        Me.lblStartSep6 = New System.Windows.Forms.Label()
        Me.lblEndSep6 = New System.Windows.Forms.Label()
        Me.lblEndSep5 = New System.Windows.Forms.Label()
        Me.lblEndSep4 = New System.Windows.Forms.Label()
        Me.lblEndSep3 = New System.Windows.Forms.Label()
        Me.lblEndSep2 = New System.Windows.Forms.Label()
        Me.lblEndSep1 = New System.Windows.Forms.Label()
        Me.lblEndSep0 = New System.Windows.Forms.Label()
        Me.lblStartSep5 = New System.Windows.Forms.Label()
        Me.lblStartSep4 = New System.Windows.Forms.Label()
        Me.lblStartSep3 = New System.Windows.Forms.Label()
        Me.lblStartSep2 = New System.Windows.Forms.Label()
        Me.lblStartSep1 = New System.Windows.Forms.Label()
        Me.lblMidSep5 = New System.Windows.Forms.Label()
        Me.lblMidSep4 = New System.Windows.Forms.Label()
        Me.lblMidSep0 = New System.Windows.Forms.Label()
        Me.lblStartSep0 = New System.Windows.Forms.Label()
        Me.lblMidSep3 = New System.Windows.Forms.Label()
        Me.lblMidSep2 = New System.Windows.Forms.Label()
        Me.lblMidSep1 = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtUserPassTime2 = New System.Windows.Forms.TextBox()
        Me.txtUserPassTime1 = New System.Windows.Forms.TextBox()
        Me.txtUserPassTime0 = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtGroupID = New System.Windows.Forms.TextBox()
        Me.cmdGetUserPasstime = New System.Windows.Forms.Button()
        Me.cmdSetUserPassTime = New System.Windows.Forms.Button()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtGroupNum = New System.Windows.Forms.TextBox()
        Me.txtGroupPassTime2 = New System.Windows.Forms.TextBox()
        Me.txtGroupPassTime1 = New System.Windows.Forms.TextBox()
        Me.txtGroupPassTime0 = New System.Windows.Forms.TextBox()
        Me.cmdGetGroupPassTime = New System.Windows.Forms.Button()
        Me.cmdSetGroupPassTime = New System.Windows.Forms.Button()
        Me._lblLabel_7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.txtGroupMatch9 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch8 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch7 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch6 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch5 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch4 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch3 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch2 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch1 = New System.Windows.Forms.TextBox()
        Me.txtGroupMatch0 = New System.Windows.Forms.TextBox()
        Me.cmdSetGroupMatch = New System.Windows.Forms.Button()
        Me.cmdGetGroupMatch = New System.Windows.Forms.Button()
        Me._lblLabel_10 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.cmbDoorState = New System.Windows.Forms.ComboBox()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGetDoorState
        '
        Me.cmdGetDoorState.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetDoorState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDoorState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDoorState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetDoorState.Location = New System.Drawing.Point(232, 408)
        Me.cmdGetDoorState.Name = "cmdGetDoorState"
        Me.cmdGetDoorState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDoorState.Size = New System.Drawing.Size(120, 32)
        Me.cmdGetDoorState.TabIndex = 5
        Me.cmdGetDoorState.Text = "Get Door State"
        '
        'cmdSetDoorState
        '
        Me.cmdSetDoorState.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetDoorState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetDoorState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDoorState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetDoorState.Location = New System.Drawing.Point(112, 408)
        Me.cmdSetDoorState.Name = "cmdSetDoorState"
        Me.cmdSetDoorState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetDoorState.Size = New System.Drawing.Size(120, 32)
        Me.cmdSetDoorState.TabIndex = 4
        Me.cmdSetDoorState.Text = "Set Door State"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdWrite, Me.cmdRead, Me.txtPassTimeID, Me.lblLabel8, Me.lblWeek0, Me.lblWeek6, Me.lblWeek5, Me.lblWeek4, Me.lblWeek3, Me.lblWeek2, Me.lblWeek1, Me.lblMidSep6, Me.txtEndHour0, Me.txtEndMinute0, Me.txtStartMinute0, Me.txtStartHour0, Me.txtEndHour4, Me.txtEndMinute4, Me.txtEndMinute3, Me.txtEndHour3, Me.txtEndHour2, Me.txtEndMinute2, Me.txtEndMinute1, Me.txtEndHour1, Me.txtStartMinute4, Me.txtStartHour4, Me.txtStartHour3, Me.txtStartMinute3, Me.txtStartMinute2, Me.txtStartHour2, Me.txtStartHour1, Me.txtStartMinute1, Me.txtStartHour5, Me.txtStartHour6, Me.txtStartMinute5, Me.txtStartMinute6, Me.txtEndHour5, Me.txtEndHour6, Me.txtEndMinute5, Me.txtEndMinute6, Me.lblStartSep6, Me.lblEndSep6, Me.lblEndSep5, Me.lblEndSep4, Me.lblEndSep3, Me.lblEndSep2, Me.lblEndSep1, Me.lblEndSep0, Me.lblStartSep5, Me.lblStartSep4, Me.lblStartSep3, Me.lblStartSep2, Me.lblStartSep1, Me.lblMidSep5, Me.lblMidSep4, Me.lblMidSep0, Me.lblStartSep0, Me.lblMidSep3, Me.lblMidSep2, Me.lblMidSep1, Me.lblStartTime, Me.lblEndTime})
        Me.Frame1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 64)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(336, 320)
        Me.Frame1.TabIndex = 88
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "PassTime Info"
        '
        'cmdWrite
        '
        Me.cmdWrite.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWrite.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWrite.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWrite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWrite.Location = New System.Drawing.Point(248, 272)
        Me.cmdWrite.Name = "cmdWrite"
        Me.cmdWrite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWrite.Size = New System.Drawing.Size(75, 33)
        Me.cmdWrite.TabIndex = 116
        Me.cmdWrite.Text = "Write"
        '
        'cmdRead
        '
        Me.cmdRead.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRead.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRead.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRead.Location = New System.Drawing.Point(152, 272)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRead.Size = New System.Drawing.Size(83, 33)
        Me.cmdRead.TabIndex = 115
        Me.cmdRead.Text = "Read"
        '
        'txtPassTimeID
        '
        Me.txtPassTimeID.AcceptsReturn = True
        Me.txtPassTimeID.AutoSize = False
        Me.txtPassTimeID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassTimeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassTimeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassTimeID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassTimeID.Location = New System.Drawing.Point(72, 272)
        Me.txtPassTimeID.MaxLength = 0
        Me.txtPassTimeID.Name = "txtPassTimeID"
        Me.txtPassTimeID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassTimeID.Size = New System.Drawing.Size(58, 27)
        Me.txtPassTimeID.TabIndex = 113
        Me.txtPassTimeID.Text = "1"
        Me.txtPassTimeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLabel8
        '
        Me.lblLabel8.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel8.Location = New System.Drawing.Point(8, 264)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel8.Size = New System.Drawing.Size(56, 40)
        Me.lblLabel8.TabIndex = 114
        Me.lblLabel8.Text = "   TZ (1~50)"
        '
        'lblWeek0
        '
        Me.lblWeek0.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek0.Location = New System.Drawing.Point(8, 56)
        Me.lblWeek0.Name = "lblWeek0"
        Me.lblWeek0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek0.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek0.TabIndex = 112
        Me.lblWeek0.Text = "Sun"
        '
        'lblWeek6
        '
        Me.lblWeek6.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek6.Location = New System.Drawing.Point(8, 224)
        Me.lblWeek6.Name = "lblWeek6"
        Me.lblWeek6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek6.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek6.TabIndex = 111
        Me.lblWeek6.Text = "Sat"
        '
        'lblWeek5
        '
        Me.lblWeek5.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek5.Location = New System.Drawing.Point(8, 196)
        Me.lblWeek5.Name = "lblWeek5"
        Me.lblWeek5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek5.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek5.TabIndex = 110
        Me.lblWeek5.Text = "Fri"
        '
        'lblWeek4
        '
        Me.lblWeek4.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek4.Location = New System.Drawing.Point(8, 168)
        Me.lblWeek4.Name = "lblWeek4"
        Me.lblWeek4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek4.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek4.TabIndex = 109
        Me.lblWeek4.Text = "Thu"
        '
        'lblWeek3
        '
        Me.lblWeek3.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek3.Location = New System.Drawing.Point(8, 140)
        Me.lblWeek3.Name = "lblWeek3"
        Me.lblWeek3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek3.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek3.TabIndex = 108
        Me.lblWeek3.Text = "Wen"
        '
        'lblWeek2
        '
        Me.lblWeek2.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek2.Location = New System.Drawing.Point(8, 112)
        Me.lblWeek2.Name = "lblWeek2"
        Me.lblWeek2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek2.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek2.TabIndex = 107
        Me.lblWeek2.Text = "Tue"
        '
        'lblWeek1
        '
        Me.lblWeek1.BackColor = System.Drawing.Color.Transparent
        Me.lblWeek1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeek1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeek1.Location = New System.Drawing.Point(8, 84)
        Me.lblWeek1.Name = "lblWeek1"
        Me.lblWeek1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeek1.Size = New System.Drawing.Size(40, 20)
        Me.lblWeek1.TabIndex = 106
        Me.lblWeek1.Text = "Mon"
        '
        'lblMidSep6
        '
        Me.lblMidSep6.AutoSize = True
        Me.lblMidSep6.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep6.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep6.Location = New System.Drawing.Point(168, 216)
        Me.lblMidSep6.Name = "lblMidSep6"
        Me.lblMidSep6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep6.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep6.TabIndex = 56
        Me.lblMidSep6.Text = "~"
        '
        'txtEndHour0
        '
        Me.txtEndHour0.AcceptsReturn = True
        Me.txtEndHour0.AutoSize = False
        Me.txtEndHour0.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour0.Location = New System.Drawing.Point(216, 56)
        Me.txtEndHour0.MaxLength = 2
        Me.txtEndHour0.Name = "txtEndHour0"
        Me.txtEndHour0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour0.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour0.TabIndex = 28
        Me.txtEndHour0.Text = "0"
        Me.txtEndHour0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute0
        '
        Me.txtEndMinute0.AcceptsReturn = True
        Me.txtEndMinute0.AutoSize = False
        Me.txtEndMinute0.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute0.Location = New System.Drawing.Point(280, 56)
        Me.txtEndMinute0.MaxLength = 2
        Me.txtEndMinute0.Name = "txtEndMinute0"
        Me.txtEndMinute0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute0.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute0.TabIndex = 27
        Me.txtEndMinute0.Text = "0"
        Me.txtEndMinute0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute0
        '
        Me.txtStartMinute0.AcceptsReturn = True
        Me.txtStartMinute0.AutoSize = False
        Me.txtStartMinute0.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute0.Location = New System.Drawing.Point(112, 56)
        Me.txtStartMinute0.MaxLength = 2
        Me.txtStartMinute0.Name = "txtStartMinute0"
        Me.txtStartMinute0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute0.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute0.TabIndex = 26
        Me.txtStartMinute0.Text = "0"
        Me.txtStartMinute0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour0
        '
        Me.txtStartHour0.AcceptsReturn = True
        Me.txtStartHour0.AutoSize = False
        Me.txtStartHour0.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour0.Location = New System.Drawing.Point(48, 56)
        Me.txtStartHour0.MaxLength = 2
        Me.txtStartHour0.Name = "txtStartHour0"
        Me.txtStartHour0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour0.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour0.TabIndex = 25
        Me.txtStartHour0.Text = "0"
        Me.txtStartHour0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndHour4
        '
        Me.txtEndHour4.AcceptsReturn = True
        Me.txtEndHour4.AutoSize = False
        Me.txtEndHour4.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour4.Location = New System.Drawing.Point(216, 168)
        Me.txtEndHour4.MaxLength = 2
        Me.txtEndHour4.Name = "txtEndHour4"
        Me.txtEndHour4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour4.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour4.TabIndex = 24
        Me.txtEndHour4.Text = "0"
        Me.txtEndHour4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute4
        '
        Me.txtEndMinute4.AcceptsReturn = True
        Me.txtEndMinute4.AutoSize = False
        Me.txtEndMinute4.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute4.Location = New System.Drawing.Point(280, 168)
        Me.txtEndMinute4.MaxLength = 2
        Me.txtEndMinute4.Name = "txtEndMinute4"
        Me.txtEndMinute4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute4.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute4.TabIndex = 23
        Me.txtEndMinute4.Text = "0"
        Me.txtEndMinute4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute3
        '
        Me.txtEndMinute3.AcceptsReturn = True
        Me.txtEndMinute3.AutoSize = False
        Me.txtEndMinute3.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute3.Location = New System.Drawing.Point(280, 140)
        Me.txtEndMinute3.MaxLength = 2
        Me.txtEndMinute3.Name = "txtEndMinute3"
        Me.txtEndMinute3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute3.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute3.TabIndex = 22
        Me.txtEndMinute3.Text = "0"
        Me.txtEndMinute3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndHour3
        '
        Me.txtEndHour3.AcceptsReturn = True
        Me.txtEndHour3.AutoSize = False
        Me.txtEndHour3.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour3.Location = New System.Drawing.Point(216, 140)
        Me.txtEndHour3.MaxLength = 2
        Me.txtEndHour3.Name = "txtEndHour3"
        Me.txtEndHour3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour3.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour3.TabIndex = 21
        Me.txtEndHour3.Text = "0"
        Me.txtEndHour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndHour2
        '
        Me.txtEndHour2.AcceptsReturn = True
        Me.txtEndHour2.AutoSize = False
        Me.txtEndHour2.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour2.Location = New System.Drawing.Point(216, 112)
        Me.txtEndHour2.MaxLength = 2
        Me.txtEndHour2.Name = "txtEndHour2"
        Me.txtEndHour2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour2.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour2.TabIndex = 20
        Me.txtEndHour2.Text = "0"
        Me.txtEndHour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute2
        '
        Me.txtEndMinute2.AcceptsReturn = True
        Me.txtEndMinute2.AutoSize = False
        Me.txtEndMinute2.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute2.Location = New System.Drawing.Point(280, 112)
        Me.txtEndMinute2.MaxLength = 2
        Me.txtEndMinute2.Name = "txtEndMinute2"
        Me.txtEndMinute2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute2.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute2.TabIndex = 19
        Me.txtEndMinute2.Text = "0"
        Me.txtEndMinute2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute1
        '
        Me.txtEndMinute1.AcceptsReturn = True
        Me.txtEndMinute1.AutoSize = False
        Me.txtEndMinute1.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute1.Location = New System.Drawing.Point(280, 84)
        Me.txtEndMinute1.MaxLength = 2
        Me.txtEndMinute1.Name = "txtEndMinute1"
        Me.txtEndMinute1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute1.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute1.TabIndex = 18
        Me.txtEndMinute1.Text = "0"
        Me.txtEndMinute1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndHour1
        '
        Me.txtEndHour1.AcceptsReturn = True
        Me.txtEndHour1.AutoSize = False
        Me.txtEndHour1.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour1.Location = New System.Drawing.Point(216, 84)
        Me.txtEndHour1.MaxLength = 2
        Me.txtEndHour1.Name = "txtEndHour1"
        Me.txtEndHour1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour1.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour1.TabIndex = 17
        Me.txtEndHour1.Text = "0"
        Me.txtEndHour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute4
        '
        Me.txtStartMinute4.AcceptsReturn = True
        Me.txtStartMinute4.AutoSize = False
        Me.txtStartMinute4.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute4.Location = New System.Drawing.Point(112, 168)
        Me.txtStartMinute4.MaxLength = 2
        Me.txtStartMinute4.Name = "txtStartMinute4"
        Me.txtStartMinute4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute4.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute4.TabIndex = 16
        Me.txtStartMinute4.Text = "0"
        Me.txtStartMinute4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour4
        '
        Me.txtStartHour4.AcceptsReturn = True
        Me.txtStartHour4.AutoSize = False
        Me.txtStartHour4.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour4.Location = New System.Drawing.Point(48, 168)
        Me.txtStartHour4.MaxLength = 2
        Me.txtStartHour4.Name = "txtStartHour4"
        Me.txtStartHour4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour4.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour4.TabIndex = 15
        Me.txtStartHour4.Text = "0"
        Me.txtStartHour4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour3
        '
        Me.txtStartHour3.AcceptsReturn = True
        Me.txtStartHour3.AutoSize = False
        Me.txtStartHour3.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour3.Location = New System.Drawing.Point(48, 140)
        Me.txtStartHour3.MaxLength = 2
        Me.txtStartHour3.Name = "txtStartHour3"
        Me.txtStartHour3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour3.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour3.TabIndex = 14
        Me.txtStartHour3.Text = "0"
        Me.txtStartHour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute3
        '
        Me.txtStartMinute3.AcceptsReturn = True
        Me.txtStartMinute3.AutoSize = False
        Me.txtStartMinute3.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute3.Location = New System.Drawing.Point(112, 140)
        Me.txtStartMinute3.MaxLength = 2
        Me.txtStartMinute3.Name = "txtStartMinute3"
        Me.txtStartMinute3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute3.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute3.TabIndex = 13
        Me.txtStartMinute3.Text = "0"
        Me.txtStartMinute3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute2
        '
        Me.txtStartMinute2.AcceptsReturn = True
        Me.txtStartMinute2.AutoSize = False
        Me.txtStartMinute2.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute2.Location = New System.Drawing.Point(112, 112)
        Me.txtStartMinute2.MaxLength = 2
        Me.txtStartMinute2.Name = "txtStartMinute2"
        Me.txtStartMinute2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute2.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute2.TabIndex = 12
        Me.txtStartMinute2.Text = "0"
        Me.txtStartMinute2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour2
        '
        Me.txtStartHour2.AcceptsReturn = True
        Me.txtStartHour2.AutoSize = False
        Me.txtStartHour2.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour2.Location = New System.Drawing.Point(48, 112)
        Me.txtStartHour2.MaxLength = 2
        Me.txtStartHour2.Name = "txtStartHour2"
        Me.txtStartHour2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour2.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour2.TabIndex = 11
        Me.txtStartHour2.Text = "0"
        Me.txtStartHour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour1
        '
        Me.txtStartHour1.AcceptsReturn = True
        Me.txtStartHour1.AutoSize = False
        Me.txtStartHour1.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour1.Location = New System.Drawing.Point(48, 84)
        Me.txtStartHour1.MaxLength = 2
        Me.txtStartHour1.Name = "txtStartHour1"
        Me.txtStartHour1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour1.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour1.TabIndex = 10
        Me.txtStartHour1.Text = "0"
        Me.txtStartHour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute1
        '
        Me.txtStartMinute1.AcceptsReturn = True
        Me.txtStartMinute1.AutoSize = False
        Me.txtStartMinute1.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute1.Location = New System.Drawing.Point(112, 84)
        Me.txtStartMinute1.MaxLength = 2
        Me.txtStartMinute1.Name = "txtStartMinute1"
        Me.txtStartMinute1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute1.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute1.TabIndex = 9
        Me.txtStartMinute1.Text = "0"
        Me.txtStartMinute1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour5
        '
        Me.txtStartHour5.AcceptsReturn = True
        Me.txtStartHour5.AutoSize = False
        Me.txtStartHour5.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour5.Location = New System.Drawing.Point(48, 196)
        Me.txtStartHour5.MaxLength = 2
        Me.txtStartHour5.Name = "txtStartHour5"
        Me.txtStartHour5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour5.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour5.TabIndex = 8
        Me.txtStartHour5.Text = "0"
        Me.txtStartHour5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartHour6
        '
        Me.txtStartHour6.AcceptsReturn = True
        Me.txtStartHour6.AutoSize = False
        Me.txtStartHour6.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartHour6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartHour6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartHour6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartHour6.Location = New System.Drawing.Point(48, 224)
        Me.txtStartHour6.MaxLength = 2
        Me.txtStartHour6.Name = "txtStartHour6"
        Me.txtStartHour6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartHour6.Size = New System.Drawing.Size(42, 26)
        Me.txtStartHour6.TabIndex = 7
        Me.txtStartHour6.Text = "0"
        Me.txtStartHour6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute5
        '
        Me.txtStartMinute5.AcceptsReturn = True
        Me.txtStartMinute5.AutoSize = False
        Me.txtStartMinute5.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute5.Location = New System.Drawing.Point(112, 196)
        Me.txtStartMinute5.MaxLength = 2
        Me.txtStartMinute5.Name = "txtStartMinute5"
        Me.txtStartMinute5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute5.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute5.TabIndex = 6
        Me.txtStartMinute5.Text = "0"
        Me.txtStartMinute5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMinute6
        '
        Me.txtStartMinute6.AcceptsReturn = True
        Me.txtStartMinute6.AutoSize = False
        Me.txtStartMinute6.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartMinute6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMinute6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMinute6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartMinute6.Location = New System.Drawing.Point(112, 224)
        Me.txtStartMinute6.MaxLength = 2
        Me.txtStartMinute6.Name = "txtStartMinute6"
        Me.txtStartMinute6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMinute6.Size = New System.Drawing.Size(42, 26)
        Me.txtStartMinute6.TabIndex = 5
        Me.txtStartMinute6.Text = "0"
        Me.txtStartMinute6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndHour5
        '
        Me.txtEndHour5.AcceptsReturn = True
        Me.txtEndHour5.AutoSize = False
        Me.txtEndHour5.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour5.Location = New System.Drawing.Point(216, 196)
        Me.txtEndHour5.MaxLength = 2
        Me.txtEndHour5.Name = "txtEndHour5"
        Me.txtEndHour5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour5.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour5.TabIndex = 4
        Me.txtEndHour5.Text = "0"
        Me.txtEndHour5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndHour6
        '
        Me.txtEndHour6.AcceptsReturn = True
        Me.txtEndHour6.AutoSize = False
        Me.txtEndHour6.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndHour6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndHour6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHour6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndHour6.Location = New System.Drawing.Point(216, 224)
        Me.txtEndHour6.MaxLength = 2
        Me.txtEndHour6.Name = "txtEndHour6"
        Me.txtEndHour6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndHour6.Size = New System.Drawing.Size(42, 26)
        Me.txtEndHour6.TabIndex = 3
        Me.txtEndHour6.Text = "0"
        Me.txtEndHour6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute5
        '
        Me.txtEndMinute5.AcceptsReturn = True
        Me.txtEndMinute5.AutoSize = False
        Me.txtEndMinute5.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute5.Location = New System.Drawing.Point(280, 196)
        Me.txtEndMinute5.MaxLength = 2
        Me.txtEndMinute5.Name = "txtEndMinute5"
        Me.txtEndMinute5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute5.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute5.TabIndex = 2
        Me.txtEndMinute5.Text = "0"
        Me.txtEndMinute5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndMinute6
        '
        Me.txtEndMinute6.AcceptsReturn = True
        Me.txtEndMinute6.AutoSize = False
        Me.txtEndMinute6.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndMinute6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndMinute6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMinute6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndMinute6.Location = New System.Drawing.Point(280, 224)
        Me.txtEndMinute6.MaxLength = 2
        Me.txtEndMinute6.Name = "txtEndMinute6"
        Me.txtEndMinute6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndMinute6.Size = New System.Drawing.Size(42, 26)
        Me.txtEndMinute6.TabIndex = 1
        Me.txtEndMinute6.Text = "0"
        Me.txtEndMinute6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStartSep6
        '
        Me.lblStartSep6.AutoSize = True
        Me.lblStartSep6.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep6.Location = New System.Drawing.Point(96, 228)
        Me.lblStartSep6.Name = "lblStartSep6"
        Me.lblStartSep6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep6.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep6.TabIndex = 55
        Me.lblStartSep6.Text = ":"
        '
        'lblEndSep6
        '
        Me.lblEndSep6.AutoSize = True
        Me.lblEndSep6.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep6.Location = New System.Drawing.Point(264, 228)
        Me.lblEndSep6.Name = "lblEndSep6"
        Me.lblEndSep6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep6.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep6.TabIndex = 54
        Me.lblEndSep6.Text = ":"
        '
        'lblEndSep5
        '
        Me.lblEndSep5.AutoSize = True
        Me.lblEndSep5.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep5.Location = New System.Drawing.Point(264, 200)
        Me.lblEndSep5.Name = "lblEndSep5"
        Me.lblEndSep5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep5.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep5.TabIndex = 53
        Me.lblEndSep5.Text = ":"
        '
        'lblEndSep4
        '
        Me.lblEndSep4.AutoSize = True
        Me.lblEndSep4.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep4.Location = New System.Drawing.Point(264, 172)
        Me.lblEndSep4.Name = "lblEndSep4"
        Me.lblEndSep4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep4.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep4.TabIndex = 52
        Me.lblEndSep4.Text = ":"
        '
        'lblEndSep3
        '
        Me.lblEndSep3.AutoSize = True
        Me.lblEndSep3.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep3.Location = New System.Drawing.Point(264, 144)
        Me.lblEndSep3.Name = "lblEndSep3"
        Me.lblEndSep3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep3.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep3.TabIndex = 51
        Me.lblEndSep3.Text = ":"
        '
        'lblEndSep2
        '
        Me.lblEndSep2.AutoSize = True
        Me.lblEndSep2.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep2.Location = New System.Drawing.Point(264, 116)
        Me.lblEndSep2.Name = "lblEndSep2"
        Me.lblEndSep2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep2.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep2.TabIndex = 50
        Me.lblEndSep2.Text = ":"
        '
        'lblEndSep1
        '
        Me.lblEndSep1.AutoSize = True
        Me.lblEndSep1.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep1.Location = New System.Drawing.Point(264, 88)
        Me.lblEndSep1.Name = "lblEndSep1"
        Me.lblEndSep1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep1.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep1.TabIndex = 49
        Me.lblEndSep1.Text = ":"
        '
        'lblEndSep0
        '
        Me.lblEndSep0.AutoSize = True
        Me.lblEndSep0.BackColor = System.Drawing.Color.Transparent
        Me.lblEndSep0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndSep0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSep0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndSep0.Location = New System.Drawing.Point(264, 60)
        Me.lblEndSep0.Name = "lblEndSep0"
        Me.lblEndSep0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndSep0.Size = New System.Drawing.Size(11, 19)
        Me.lblEndSep0.TabIndex = 48
        Me.lblEndSep0.Text = ":"
        '
        'lblStartSep5
        '
        Me.lblStartSep5.AutoSize = True
        Me.lblStartSep5.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep5.Location = New System.Drawing.Point(96, 200)
        Me.lblStartSep5.Name = "lblStartSep5"
        Me.lblStartSep5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep5.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep5.TabIndex = 47
        Me.lblStartSep5.Text = ":"
        '
        'lblStartSep4
        '
        Me.lblStartSep4.AutoSize = True
        Me.lblStartSep4.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep4.Location = New System.Drawing.Point(96, 172)
        Me.lblStartSep4.Name = "lblStartSep4"
        Me.lblStartSep4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep4.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep4.TabIndex = 46
        Me.lblStartSep4.Text = ":"
        '
        'lblStartSep3
        '
        Me.lblStartSep3.AutoSize = True
        Me.lblStartSep3.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep3.Location = New System.Drawing.Point(96, 144)
        Me.lblStartSep3.Name = "lblStartSep3"
        Me.lblStartSep3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep3.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep3.TabIndex = 45
        Me.lblStartSep3.Text = ":"
        '
        'lblStartSep2
        '
        Me.lblStartSep2.AutoSize = True
        Me.lblStartSep2.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep2.Location = New System.Drawing.Point(96, 116)
        Me.lblStartSep2.Name = "lblStartSep2"
        Me.lblStartSep2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep2.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep2.TabIndex = 44
        Me.lblStartSep2.Text = ":"
        '
        'lblStartSep1
        '
        Me.lblStartSep1.AutoSize = True
        Me.lblStartSep1.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep1.Location = New System.Drawing.Point(96, 88)
        Me.lblStartSep1.Name = "lblStartSep1"
        Me.lblStartSep1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep1.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep1.TabIndex = 43
        Me.lblStartSep1.Text = ":"
        '
        'lblMidSep5
        '
        Me.lblMidSep5.AutoSize = True
        Me.lblMidSep5.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep5.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep5.Location = New System.Drawing.Point(168, 188)
        Me.lblMidSep5.Name = "lblMidSep5"
        Me.lblMidSep5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep5.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep5.TabIndex = 42
        Me.lblMidSep5.Text = "~"
        '
        'lblMidSep4
        '
        Me.lblMidSep4.AutoSize = True
        Me.lblMidSep4.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep4.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep4.Location = New System.Drawing.Point(168, 160)
        Me.lblMidSep4.Name = "lblMidSep4"
        Me.lblMidSep4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep4.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep4.TabIndex = 41
        Me.lblMidSep4.Text = "~"
        '
        'lblMidSep0
        '
        Me.lblMidSep0.AutoSize = True
        Me.lblMidSep0.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep0.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep0.Location = New System.Drawing.Point(168, 48)
        Me.lblMidSep0.Name = "lblMidSep0"
        Me.lblMidSep0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep0.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep0.TabIndex = 36
        Me.lblMidSep0.Text = "~"
        '
        'lblStartSep0
        '
        Me.lblStartSep0.AutoSize = True
        Me.lblStartSep0.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSep0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartSep0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSep0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSep0.Location = New System.Drawing.Point(96, 60)
        Me.lblStartSep0.Name = "lblStartSep0"
        Me.lblStartSep0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartSep0.Size = New System.Drawing.Size(11, 19)
        Me.lblStartSep0.TabIndex = 35
        Me.lblStartSep0.Text = ":"
        '
        'lblMidSep3
        '
        Me.lblMidSep3.AutoSize = True
        Me.lblMidSep3.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep3.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep3.Location = New System.Drawing.Point(168, 132)
        Me.lblMidSep3.Name = "lblMidSep3"
        Me.lblMidSep3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep3.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep3.TabIndex = 34
        Me.lblMidSep3.Text = "~"
        '
        'lblMidSep2
        '
        Me.lblMidSep2.AutoSize = True
        Me.lblMidSep2.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep2.Location = New System.Drawing.Point(168, 104)
        Me.lblMidSep2.Name = "lblMidSep2"
        Me.lblMidSep2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep2.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep2.TabIndex = 32
        Me.lblMidSep2.Text = "~"
        '
        'lblMidSep1
        '
        Me.lblMidSep1.AutoSize = True
        Me.lblMidSep1.BackColor = System.Drawing.Color.Transparent
        Me.lblMidSep1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMidSep1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidSep1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMidSep1.Location = New System.Drawing.Point(168, 76)
        Me.lblMidSep1.Name = "lblMidSep1"
        Me.lblMidSep1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMidSep1.Size = New System.Drawing.Size(33, 43)
        Me.lblMidSep1.TabIndex = 31
        Me.lblMidSep1.Text = "~"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.BackColor = System.Drawing.Color.Transparent
        Me.lblStartTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStartTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartTime.Location = New System.Drawing.Point(64, 32)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStartTime.Size = New System.Drawing.Size(82, 19)
        Me.lblStartTime.TabIndex = 30
        Me.lblStartTime.Text = "Start Time"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.BackColor = System.Drawing.Color.Transparent
        Me.lblEndTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndTime.Location = New System.Drawing.Point(232, 32)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndTime.Size = New System.Drawing.Size(76, 19)
        Me.lblEndTime.TabIndex = 29
        Me.lblEndTime.Text = "End Time"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(16, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(336, 28)
        Me.lblMessage.TabIndex = 91
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtUserPassTime2, Me.txtUserPassTime1, Me.txtUserPassTime0, Me.txtUserID, Me.txtGroupID, Me.cmdGetUserPasstime, Me.cmdSetUserPassTime, Me.lblLabel3, Me.lblLabel2, Me.lblLabel1, Me.lblLabel0, Me.lblUserID})
        Me.Frame2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(360, 0)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(280, 146)
        Me.Frame2.TabIndex = 106
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "User Access"
        '
        'txtUserPassTime2
        '
        Me.txtUserPassTime2.AcceptsReturn = True
        Me.txtUserPassTime2.AutoSize = False
        Me.txtUserPassTime2.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserPassTime2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassTime2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassTime2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserPassTime2.Location = New System.Drawing.Point(240, 64)
        Me.txtUserPassTime2.MaxLength = 0
        Me.txtUserPassTime2.Name = "txtUserPassTime2"
        Me.txtUserPassTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserPassTime2.Size = New System.Drawing.Size(26, 28)
        Me.txtUserPassTime2.TabIndex = 70
        Me.txtUserPassTime2.Text = "0"
        Me.txtUserPassTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserPassTime1
        '
        Me.txtUserPassTime1.AcceptsReturn = True
        Me.txtUserPassTime1.AutoSize = False
        Me.txtUserPassTime1.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserPassTime1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassTime1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassTime1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserPassTime1.Location = New System.Drawing.Point(180, 64)
        Me.txtUserPassTime1.MaxLength = 0
        Me.txtUserPassTime1.Name = "txtUserPassTime1"
        Me.txtUserPassTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserPassTime1.Size = New System.Drawing.Size(26, 28)
        Me.txtUserPassTime1.TabIndex = 69
        Me.txtUserPassTime1.Text = "0"
        Me.txtUserPassTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserPassTime0
        '
        Me.txtUserPassTime0.AcceptsReturn = True
        Me.txtUserPassTime0.AutoSize = False
        Me.txtUserPassTime0.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserPassTime0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassTime0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassTime0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserPassTime0.Location = New System.Drawing.Point(120, 64)
        Me.txtUserPassTime0.MaxLength = 0
        Me.txtUserPassTime0.Name = "txtUserPassTime0"
        Me.txtUserPassTime0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserPassTime0.Size = New System.Drawing.Size(26, 28)
        Me.txtUserPassTime0.TabIndex = 68
        Me.txtUserPassTime0.Text = "0"
        Me.txtUserPassTime0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserID
        '
        Me.txtUserID.AcceptsReturn = True
        Me.txtUserID.AutoSize = False
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserID.Location = New System.Drawing.Point(128, 24)
        Me.txtUserID.MaxLength = 0
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserID.Size = New System.Drawing.Size(58, 27)
        Me.txtUserID.TabIndex = 67
        Me.txtUserID.Text = "1"
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupID
        '
        Me.txtGroupID.AcceptsReturn = True
        Me.txtGroupID.AutoSize = False
        Me.txtGroupID.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupID.Location = New System.Drawing.Point(57, 64)
        Me.txtGroupID.MaxLength = 0
        Me.txtGroupID.Name = "txtGroupID"
        Me.txtGroupID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupID.Size = New System.Drawing.Size(33, 28)
        Me.txtGroupID.TabIndex = 66
        Me.txtGroupID.Text = "1"
        '
        'cmdGetUserPasstime
        '
        Me.cmdGetUserPasstime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetUserPasstime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetUserPasstime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetUserPasstime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetUserPasstime.Location = New System.Drawing.Point(16, 104)
        Me.cmdGetUserPasstime.Name = "cmdGetUserPasstime"
        Me.cmdGetUserPasstime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetUserPasstime.Size = New System.Drawing.Size(120, 31)
        Me.cmdGetUserPasstime.TabIndex = 65
        Me.cmdGetUserPasstime.Text = "Get User"
        '
        'cmdSetUserPassTime
        '
        Me.cmdSetUserPassTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetUserPassTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetUserPassTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetUserPassTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetUserPassTime.Location = New System.Drawing.Point(144, 104)
        Me.cmdSetUserPassTime.Name = "cmdSetUserPassTime"
        Me.cmdSetUserPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetUserPassTime.Size = New System.Drawing.Size(120, 31)
        Me.cmdSetUserPassTime.TabIndex = 64
        Me.cmdSetUserPassTime.Text = "Set User "
        '
        'lblLabel3
        '
        Me.lblLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel3.Location = New System.Drawing.Point(210, 67)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel3.Size = New System.Drawing.Size(34, 24)
        Me.lblLabel3.TabIndex = 91
        Me.lblLabel3.Text = "TZ3"
        '
        'lblLabel2
        '
        Me.lblLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel2.Location = New System.Drawing.Point(150, 67)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel2.Size = New System.Drawing.Size(34, 24)
        Me.lblLabel2.TabIndex = 90
        Me.lblLabel2.Text = "TZ2"
        '
        'lblLabel1
        '
        Me.lblLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel1.Location = New System.Drawing.Point(90, 67)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel1.Size = New System.Drawing.Size(34, 24)
        Me.lblLabel1.TabIndex = 89
        Me.lblLabel1.Text = "TZ1"
        '
        'lblLabel0
        '
        Me.lblLabel0.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel0.Location = New System.Drawing.Point(8, 59)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel0.Size = New System.Drawing.Size(48, 40)
        Me.lblLabel0.TabIndex = 88
        Me.lblLabel0.Text = "Group (1~5)"
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUserID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUserID.Location = New System.Drawing.Point(56, 28)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserID.Size = New System.Drawing.Size(72, 25)
        Me.lblUserID.TabIndex = 71
        Me.lblUserID.Text = "User ID"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtGroupNum, Me.txtGroupPassTime2, Me.txtGroupPassTime1, Me.txtGroupPassTime0, Me.cmdGetGroupPassTime, Me.cmdSetGroupPassTime, Me._lblLabel_7, Me.lblLabel6, Me.lblLabel5, Me.lblLabel4})
        Me.Frame3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(360, 150)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(280, 146)
        Me.Frame3.TabIndex = 107
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Group Access"
        '
        'txtGroupNum
        '
        Me.txtGroupNum.AcceptsReturn = True
        Me.txtGroupNum.AutoSize = False
        Me.txtGroupNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupNum.Location = New System.Drawing.Point(141, 24)
        Me.txtGroupNum.MaxLength = 0
        Me.txtGroupNum.Name = "txtGroupNum"
        Me.txtGroupNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupNum.Size = New System.Drawing.Size(34, 27)
        Me.txtGroupNum.TabIndex = 98
        Me.txtGroupNum.Text = "1"
        Me.txtGroupNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupPassTime2
        '
        Me.txtGroupPassTime2.AcceptsReturn = True
        Me.txtGroupPassTime2.AutoSize = False
        Me.txtGroupPassTime2.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupPassTime2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupPassTime2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupPassTime2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupPassTime2.Location = New System.Drawing.Point(222, 64)
        Me.txtGroupPassTime2.MaxLength = 0
        Me.txtGroupPassTime2.Name = "txtGroupPassTime2"
        Me.txtGroupPassTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupPassTime2.Size = New System.Drawing.Size(26, 28)
        Me.txtGroupPassTime2.TabIndex = 94
        Me.txtGroupPassTime2.Text = "0"
        Me.txtGroupPassTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupPassTime1
        '
        Me.txtGroupPassTime1.AcceptsReturn = True
        Me.txtGroupPassTime1.AutoSize = False
        Me.txtGroupPassTime1.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupPassTime1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupPassTime1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupPassTime1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupPassTime1.Location = New System.Drawing.Point(141, 64)
        Me.txtGroupPassTime1.MaxLength = 0
        Me.txtGroupPassTime1.Name = "txtGroupPassTime1"
        Me.txtGroupPassTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupPassTime1.Size = New System.Drawing.Size(26, 28)
        Me.txtGroupPassTime1.TabIndex = 93
        Me.txtGroupPassTime1.Text = "0"
        Me.txtGroupPassTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupPassTime0
        '
        Me.txtGroupPassTime0.AcceptsReturn = True
        Me.txtGroupPassTime0.AutoSize = False
        Me.txtGroupPassTime0.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupPassTime0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupPassTime0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupPassTime0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupPassTime0.Location = New System.Drawing.Point(60, 64)
        Me.txtGroupPassTime0.MaxLength = 0
        Me.txtGroupPassTime0.Name = "txtGroupPassTime0"
        Me.txtGroupPassTime0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupPassTime0.Size = New System.Drawing.Size(26, 28)
        Me.txtGroupPassTime0.TabIndex = 92
        Me.txtGroupPassTime0.Text = "0"
        Me.txtGroupPassTime0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdGetGroupPassTime
        '
        Me.cmdGetGroupPassTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetGroupPassTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetGroupPassTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetGroupPassTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetGroupPassTime.Location = New System.Drawing.Point(16, 104)
        Me.cmdGetGroupPassTime.Name = "cmdGetGroupPassTime"
        Me.cmdGetGroupPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetGroupPassTime.Size = New System.Drawing.Size(120, 31)
        Me.cmdGetGroupPassTime.TabIndex = 74
        Me.cmdGetGroupPassTime.Text = "Get Group"
        '
        'cmdSetGroupPassTime
        '
        Me.cmdSetGroupPassTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetGroupPassTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetGroupPassTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetGroupPassTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetGroupPassTime.Location = New System.Drawing.Point(144, 104)
        Me.cmdSetGroupPassTime.Name = "cmdSetGroupPassTime"
        Me.cmdSetGroupPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetGroupPassTime.Size = New System.Drawing.Size(120, 31)
        Me.cmdSetGroupPassTime.TabIndex = 73
        Me.cmdSetGroupPassTime.Text = "Set Group"
        '
        '_lblLabel_7
        '
        Me._lblLabel_7.BackColor = System.Drawing.SystemColors.Control
        Me._lblLabel_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabel_7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabel_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblLabel_7.Location = New System.Drawing.Point(80, 16)
        Me._lblLabel_7.Name = "_lblLabel_7"
        Me._lblLabel_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabel_7.Size = New System.Drawing.Size(56, 40)
        Me._lblLabel_7.TabIndex = 104
        Me._lblLabel_7.Text = "Group (1~5)"
        '
        'lblLabel6
        '
        Me.lblLabel6.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel6.Location = New System.Drawing.Point(191, 67)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel6.Size = New System.Drawing.Size(41, 24)
        Me.lblLabel6.TabIndex = 97
        Me.lblLabel6.Text = "TZ3"
        '
        'lblLabel5
        '
        Me.lblLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel5.Location = New System.Drawing.Point(110, 67)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel5.Size = New System.Drawing.Size(42, 24)
        Me.lblLabel5.TabIndex = 96
        Me.lblLabel5.Text = "TZ2"
        '
        'lblLabel4
        '
        Me.lblLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel4.Location = New System.Drawing.Point(30, 67)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel4.Size = New System.Drawing.Size(42, 24)
        Me.lblLabel4.TabIndex = 95
        Me.lblLabel4.Text = "TZ1"
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtGroupMatch9, Me.txtGroupMatch8, Me.txtGroupMatch7, Me.txtGroupMatch6, Me.txtGroupMatch5, Me.txtGroupMatch4, Me.txtGroupMatch3, Me.txtGroupMatch2, Me.txtGroupMatch1, Me.txtGroupMatch0, Me.cmdSetGroupMatch, Me.cmdGetGroupMatch, Me._lblLabel_10, Me.lblLabel9})
        Me.Frame4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(360, 300)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(280, 146)
        Me.Frame4.TabIndex = 108
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Unlock Group"
        '
        'txtGroupMatch9
        '
        Me.txtGroupMatch9.AcceptsReturn = True
        Me.txtGroupMatch9.AutoSize = False
        Me.txtGroupMatch9.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch9.Location = New System.Drawing.Point(216, 72)
        Me.txtGroupMatch9.MaxLength = 0
        Me.txtGroupMatch9.Name = "txtGroupMatch9"
        Me.txtGroupMatch9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch9.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch9.TabIndex = 87
        Me.txtGroupMatch9.Text = "0"
        Me.txtGroupMatch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch8
        '
        Me.txtGroupMatch8.AcceptsReturn = True
        Me.txtGroupMatch8.AutoSize = False
        Me.txtGroupMatch8.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch8.Location = New System.Drawing.Point(168, 72)
        Me.txtGroupMatch8.MaxLength = 0
        Me.txtGroupMatch8.Name = "txtGroupMatch8"
        Me.txtGroupMatch8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch8.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch8.TabIndex = 86
        Me.txtGroupMatch8.Text = "0"
        Me.txtGroupMatch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch7
        '
        Me.txtGroupMatch7.AcceptsReturn = True
        Me.txtGroupMatch7.AutoSize = False
        Me.txtGroupMatch7.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch7.Location = New System.Drawing.Point(120, 72)
        Me.txtGroupMatch7.MaxLength = 0
        Me.txtGroupMatch7.Name = "txtGroupMatch7"
        Me.txtGroupMatch7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch7.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch7.TabIndex = 85
        Me.txtGroupMatch7.Text = "0"
        Me.txtGroupMatch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch6
        '
        Me.txtGroupMatch6.AcceptsReturn = True
        Me.txtGroupMatch6.AutoSize = False
        Me.txtGroupMatch6.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch6.Location = New System.Drawing.Point(72, 72)
        Me.txtGroupMatch6.MaxLength = 0
        Me.txtGroupMatch6.Name = "txtGroupMatch6"
        Me.txtGroupMatch6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch6.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch6.TabIndex = 84
        Me.txtGroupMatch6.Text = "0"
        Me.txtGroupMatch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch5
        '
        Me.txtGroupMatch5.AcceptsReturn = True
        Me.txtGroupMatch5.AutoSize = False
        Me.txtGroupMatch5.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch5.Location = New System.Drawing.Point(24, 72)
        Me.txtGroupMatch5.MaxLength = 0
        Me.txtGroupMatch5.Name = "txtGroupMatch5"
        Me.txtGroupMatch5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch5.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch5.TabIndex = 83
        Me.txtGroupMatch5.Text = "0"
        Me.txtGroupMatch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch4
        '
        Me.txtGroupMatch4.AcceptsReturn = True
        Me.txtGroupMatch4.AutoSize = False
        Me.txtGroupMatch4.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch4.Location = New System.Drawing.Point(216, 32)
        Me.txtGroupMatch4.MaxLength = 0
        Me.txtGroupMatch4.Name = "txtGroupMatch4"
        Me.txtGroupMatch4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch4.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch4.TabIndex = 82
        Me.txtGroupMatch4.Text = "0"
        Me.txtGroupMatch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch3
        '
        Me.txtGroupMatch3.AcceptsReturn = True
        Me.txtGroupMatch3.AutoSize = False
        Me.txtGroupMatch3.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch3.Location = New System.Drawing.Point(168, 32)
        Me.txtGroupMatch3.MaxLength = 0
        Me.txtGroupMatch3.Name = "txtGroupMatch3"
        Me.txtGroupMatch3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch3.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch3.TabIndex = 81
        Me.txtGroupMatch3.Text = "0"
        Me.txtGroupMatch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch2
        '
        Me.txtGroupMatch2.AcceptsReturn = True
        Me.txtGroupMatch2.AutoSize = False
        Me.txtGroupMatch2.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch2.Location = New System.Drawing.Point(120, 32)
        Me.txtGroupMatch2.MaxLength = 0
        Me.txtGroupMatch2.Name = "txtGroupMatch2"
        Me.txtGroupMatch2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch2.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch2.TabIndex = 80
        Me.txtGroupMatch2.Text = "0"
        Me.txtGroupMatch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch1
        '
        Me.txtGroupMatch1.AcceptsReturn = True
        Me.txtGroupMatch1.AutoSize = False
        Me.txtGroupMatch1.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch1.Location = New System.Drawing.Point(72, 32)
        Me.txtGroupMatch1.MaxLength = 0
        Me.txtGroupMatch1.Name = "txtGroupMatch1"
        Me.txtGroupMatch1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch1.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch1.TabIndex = 79
        Me.txtGroupMatch1.Text = "0"
        Me.txtGroupMatch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroupMatch0
        '
        Me.txtGroupMatch0.AcceptsReturn = True
        Me.txtGroupMatch0.AutoSize = False
        Me.txtGroupMatch0.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupMatch0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroupMatch0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupMatch0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroupMatch0.Location = New System.Drawing.Point(24, 32)
        Me.txtGroupMatch0.MaxLength = 0
        Me.txtGroupMatch0.Name = "txtGroupMatch0"
        Me.txtGroupMatch0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroupMatch0.Size = New System.Drawing.Size(41, 25)
        Me.txtGroupMatch0.TabIndex = 78
        Me.txtGroupMatch0.Text = "0"
        Me.txtGroupMatch0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSetGroupMatch
        '
        Me.cmdSetGroupMatch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetGroupMatch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetGroupMatch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetGroupMatch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetGroupMatch.Location = New System.Drawing.Point(144, 104)
        Me.cmdSetGroupMatch.Name = "cmdSetGroupMatch"
        Me.cmdSetGroupMatch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetGroupMatch.Size = New System.Drawing.Size(120, 31)
        Me.cmdSetGroupMatch.TabIndex = 77
        Me.cmdSetGroupMatch.Text = "Set Match"
        '
        'cmdGetGroupMatch
        '
        Me.cmdGetGroupMatch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetGroupMatch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetGroupMatch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetGroupMatch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetGroupMatch.Location = New System.Drawing.Point(16, 104)
        Me.cmdGetGroupMatch.Name = "cmdGetGroupMatch"
        Me.cmdGetGroupMatch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetGroupMatch.Size = New System.Drawing.Size(120, 31)
        Me.cmdGetGroupMatch.TabIndex = 76
        Me.cmdGetGroupMatch.Text = "Get Match"
        '
        '_lblLabel_10
        '
        Me._lblLabel_10.BackColor = System.Drawing.SystemColors.Control
        Me._lblLabel_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabel_10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabel_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblLabel_10.Location = New System.Drawing.Point(24, 58)
        Me._lblLabel_10.Name = "_lblLabel_10"
        Me._lblLabel_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabel_10.Size = New System.Drawing.Size(234, 14)
        Me._lblLabel_10.TabIndex = 100
        Me._lblLabel_10.Text = "    6          7           8          9         10"
        '
        'lblLabel9
        '
        Me.lblLabel9.BackColor = System.Drawing.SystemColors.Control
        Me.lblLabel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel9.Location = New System.Drawing.Point(24, 18)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel9.Size = New System.Drawing.Size(234, 14)
        Me.lblLabel9.TabIndex = 99
        Me.lblLabel9.Text = "    1          2           3          4          5"
        '
        'cmbDoorState
        '
        Me.cmbDoorState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDoorState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDoorState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoorState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoorState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDoorState.Items.AddRange(New Object() {"Reset", "Open", "Close", "Open...Close"})
        Me.cmbDoorState.Location = New System.Drawing.Point(16, 408)
        Me.cmbDoorState.Name = "cmbDoorState"
        Me.cmbDoorState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDoorState.Size = New System.Drawing.Size(96, 27)
        Me.cmbDoorState.TabIndex = 109
        '
        'frmPasstimeInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(650, 456)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbDoorState, Me.Frame4, Me.Frame3, Me.Frame2, Me.cmdGetDoorState, Me.cmdSetDoorState, Me.Frame1, Me.lblMessage})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPasstimeInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pass Time Info"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private fnCommHandleIndex As Long
    Private mPassCtrlInfo As PASSCTRLTIME
    Private mUserPassInfo As USERPASSINFO
    Private mGroupPassInfo As GROUPPASSINFO
    Private mGroupMatchInfo As GROUPMATCHINFO

    Private ftxtStartHour(MAX_PASSCTRL_COUNT - 1) As TextBox
    Private ftxtStartMinute(MAX_PASSCTRL_COUNT - 1) As TextBox
    Private ftxtEndHour(MAX_PASSCTRL_COUNT - 1) As TextBox
    Private ftxtEndMinute(MAX_PASSCTRL_COUNT - 1) As TextBox

    Private ftxtUserPassTime(MAX_USERPASSINFO_COUNT - 1) As TextBox
    Private ftxtGroupPassTime(MAX_GROUPPASSINFO_COUNT - 1) As TextBox
    Private ftxtGroupMatch(MAX_GROUPMATCHINFO_COUNT - 1) As TextBox

    Private Sub frmPasstimeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vnii As Integer
        Dim vnLen As Integer
        Dim vstrItem As String
        Dim vstrName As String
        Dim vtObject As Object

        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        mPassCtrlInfo.Initialize()
        mUserPassInfo.Initialize()
        mGroupPassInfo.Initialize()
        mGroupMatchInfo.Initialize()

        For Each vtObject In Frame1.Controls
            If Not IsNothing(vtObject) Then
                vstrName = vtObject.Name

                vstrItem = "txtStartHour"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtStartHour(vnii) = vtObject
                    GoTo lp_loop
                End If

                vstrItem = "txtStartMinute"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtStartMinute(vnii) = vtObject
                    GoTo lp_loop
                End If

                vstrItem = "txtEndHour"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtEndHour(vnii) = vtObject
                    GoTo lp_loop
                End If

                vstrItem = "txtEndMinute"
                vnLen = Len(vstrItem)
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtEndMinute(vnii) = vtObject
                    GoTo lp_loop
                End If
            End If
lp_loop:
        Next vtObject

        vstrItem = "txtUserPassTime"
        vnLen = Len(vstrItem)
        For Each vtObject In Frame2.Controls
            If Not IsNothing(vtObject) Then
                vstrName = vtObject.Name

                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtUserPassTime(vnii) = vtObject
                End If
            End If
        Next vtObject

        vstrItem = "txtGroupPassTime"
        vnLen = Len(vstrItem)
        For Each vtObject In Frame3.Controls
            If Not IsNothing(vtObject) Then
                vstrName = vtObject.Name
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtGroupPassTime(vnii) = vtObject
                End If
            End If
        Next vtObject

        vstrItem = "txtGroupMatch"
        vnLen = Len(vstrItem)
        For Each vtObject In Frame4.Controls
            If Not IsNothing(vtObject) Then
                vstrName = vtObject.Name
                If Microsoft.VisualBasic.Left(vstrName, vnLen) = vstrItem Then
                    vnii = Val(Microsoft.VisualBasic.Right(vstrName, Len(vstrName) - vnLen))
                    ftxtGroupMatch(vnii) = vtObject
                End If
            End If
        Next vtObject

        ShowValue()
    End Sub

    Private Sub cmdSetDoorState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetDoorState.Click
        Dim vnResultCode As Integer
        Dim vnState As Long = -1

        cmdSetDoorState.Enabled = False
        lblMessage.Text = "Setting Door ..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetDoorState.Enabled = True
            Exit Sub
        End If

        Select Case cmbDoorState.SelectedIndex
            Case 0
                vnState = DOOR_CONROLRESET
            Case 1
                vnState = DOOR_OPEND
            Case 2
                vnState = DOOR_CLOSED
            Case 3
                vnState = DOOR_COMMNAD
        End Select
        vnResultCode = FK_SetDoorStatus(fnCommHandleIndex, vnState)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetDoorState.Enabled = True
    End Sub

    Private Sub cmdGetDoorState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDoorState.Click
        Dim vnResultCode As Integer
        Dim vnState As Integer

        cmdGetDoorState.Enabled = False
        lblMessage.Text = "Getting Door State..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetDoorState.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_GetDoorStatus(fnCommHandleIndex, vnState)
        If vnResultCode = RUN_SUCCESS Then
            If vnState = DOOR_CONROLRESET Then
                lblMessage.Text = "State Reset!"
            ElseIf vnState = DOOR_OPEND Then
                lblMessage.Text = "Door Open!"
            ElseIf vnState = DOOR_CLOSED Then
                lblMessage.Text = "Door Close!"
            ElseIf vnState = DOOR_COMMNAD Then
                lblMessage.Text = "Command Open... Door Close!"
            Else
                lblMessage.Text = "Door - Unknown!"
            End If
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetDoorState.Enabled = True
    End Sub

    Private Sub cmdGetGroupMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetGroupMatch.Click
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdGetGroupMatch.Enabled = False
        lblMessage.Text = "Getting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetGroupMatch.Enabled = True
            Exit Sub
        End If

        vstrTmp = Space(256)
        vnResultCode = FK_GetGroupMatchWithString(fnCommHandleIndex, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
            mGroupMatchInfo = ConvertStringToMarshalStructure(vstrTmp, 2)
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetGroupMatch.Enabled = True
    End Sub

    Private Sub cmdGetGroupPassTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetGroupPassTime.Click
        Dim vGroupID As Integer
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdGetGroupPassTime.Enabled = False
        lblMessage.Text = "Getting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetGroupPassTime.Enabled = True
            Exit Sub
        End If

        vGroupID = Val(txtGroupNum.Text)
        vstrTmp = Space(256)
        vnResultCode = FK_GetGroupPassTimeWithString(fnCommHandleIndex, vGroupID, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
            mGroupPassInfo = ConvertStringToMarshalStructure(vstrTmp, 3)
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetGroupPassTime.Enabled = True
    End Sub

    Private Sub cmdGetUserPasstime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetUserPasstime.Click
        Dim vEnrollNumber As Integer
        Dim vGroupID As Integer
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdGetUserPasstime.Enabled = False
        lblMessage.Text = "Getting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetUserPasstime.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtUserID.Text)
        vstrTmp = Space(256)
        vnResultCode = FK_GetUserPassTimeWithString(fnCommHandleIndex, vEnrollNumber, vGroupID, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            txtGroupID.Text = CStr(vGroupID)
            lblMessage.Text = "Success!"
            mUserPassInfo = ConvertStringToMarshalStructure(vstrTmp, 4)
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetUserPasstime.Enabled = True
    End Sub

    Private Sub cmdRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRead.Click
        Dim vnPassTimeID As Integer
        Dim vnii As Integer
        Dim vnSubSize As Integer
        Dim vstrTmp As String
        Dim vstrSubTmp As String
        Dim vnResultCode As Integer

        cmdRead.Enabled = False
        lblMessage.Text = ""
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdRead.Enabled = True
            Exit Sub
        End If

        vnPassTimeID = 1
        If IsNumeric(txtPassTimeID.Text) Then
            vnPassTimeID = Val(txtPassTimeID.Text)
        End If
        If vnPassTimeID < 1 Or vnPassTimeID > 50 Then
            vnPassTimeID = 1
        End If
        txtPassTimeID.Text = Trim(Str(vnPassTimeID))
        vstrTmp = Space(256)
        vnResultCode = FK_GetPassTimeWithString(fnCommHandleIndex, vnPassTimeID, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
            vnSubSize = (vstrTmp.Length + 1) / MAX_PASSCTRL_COUNT
            For vnii = 0 To MAX_PASSCTRL_COUNT - 1
                vstrSubTmp = Mid(vstrTmp, vnii * vnSubSize + 1, vnSubSize)
                mPassCtrlInfo.mPassCtrlTime(vnii) = ConvertStringToMarshalStructure(vstrSubTmp, 5)
            Next vnii
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdRead.Enabled = True
    End Sub

    Private Sub cmdSetGroupMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetGroupMatch.Click
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdSetGroupMatch.Enabled = False
        lblMessage.Text = "Setting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetGroupMatch.Enabled = True
            Exit Sub
        End If

        GetValue()
        vstrTmp = ConvertMarshalStructureToString(mGroupMatchInfo)

        vnResultCode = FK_SetGroupMatchWithString(fnCommHandleIndex, vstrTmp)

        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetGroupMatch.Enabled = True
    End Sub

    Private Sub cmdSetGroupPassTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetGroupPassTime.Click
        Dim vGroupID As Integer
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdSetGroupPassTime.Enabled = False
        lblMessage.Text = "Setting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetGroupPassTime.Enabled = True
            Exit Sub
        End If

        GetValue()
        vstrTmp = ConvertMarshalStructureToString(mGroupPassInfo)

        vGroupID = Val(txtGroupNum.Text)
        vnResultCode = FK_SetGroupPassTimeWithString(fnCommHandleIndex, vGroupID, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetGroupPassTime.Enabled = True
    End Sub

    Private Sub cmdSetUserPassTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetUserPassTime.Click
        Dim vEnrollNumber As Integer
        Dim vGroupID As Integer
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdSetUserPassTime.Enabled = False
        lblMessage.Text = "Setting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetUserPassTime.Enabled = True
            Exit Sub
        End If

        GetValue()
        vstrTmp = ConvertMarshalStructureToString(mUserPassInfo)

        vEnrollNumber = Val(txtUserID.Text)
        vGroupID = Val(txtGroupID.Text)
        vnResultCode = FK_SetUserPassTimeWithString(fnCommHandleIndex, vEnrollNumber, vGroupID, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
            ShowValue()
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetUserPassTime.Enabled = True
    End Sub

    Private Sub cmdWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWrite.Click
        Dim vnPassTimeID As Integer
        Dim vnii As Integer
        Dim vstrTmp As String
        Dim vnResultCode As Integer

        cmdWrite.Enabled = False
        lblMessage.Text = ""
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdWrite.Enabled = True
            Exit Sub
        End If

        GetValue()
        vstrTmp = Space(256)
        For vnii = 0 To MAX_PASSCTRL_COUNT - 1
            vstrTmp = vstrTmp & ConvertMarshalStructureToString(mPassCtrlInfo.mPassCtrlTime(vnii)) & " "
        Next vnii
        vstrTmp = Trim(vstrTmp)

        vnPassTimeID = 1
        If IsNumeric(txtPassTimeID.Text) Then
            vnPassTimeID = Val(txtPassTimeID.Text)
        End If
        If vnPassTimeID < 1 Or vnPassTimeID > 50 Then
            vnPassTimeID = 1
        End If
        txtPassTimeID.Text = Trim(Str(vnPassTimeID))
        vnResultCode = FK_SetPassTimeWithString(fnCommHandleIndex, vnPassTimeID, vstrTmp)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Success!"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdWrite.Enabled = True
    End Sub

    Private Sub ShowValue()
        Dim vnii As Integer

        For vnii = 0 To MAX_PASSCTRL_COUNT - 1
            ftxtStartHour(vnii).Text = CStr(mPassCtrlInfo.mPassCtrlTime(vnii).StartHour)
            ftxtStartMinute(vnii).Text = CStr(mPassCtrlInfo.mPassCtrlTime(vnii).StartMinute)
            ftxtEndHour(vnii).Text = CStr(mPassCtrlInfo.mPassCtrlTime(vnii).EndHour)
            ftxtEndMinute(vnii).Text = CStr(mPassCtrlInfo.mPassCtrlTime(vnii).EndMinute)
        Next vnii

        For vnii = 0 To MAX_USERPASSINFO_COUNT - 1
            ftxtUserPassTime(vnii).Text = CStr(mUserPassInfo.UserPassID(vnii))
        Next vnii

        For vnii = 0 To MAX_GROUPPASSINFO_COUNT - 1
            ftxtGroupPassTime(vnii).Text = CStr(mGroupPassInfo.GroupPassID(vnii))
        Next vnii

        For vnii = 0 To MAX_GROUPMATCHINFO_COUNT - 1
            ftxtGroupMatch(vnii).Text = CStr(mGroupMatchInfo.GroupMatch(vnii))
        Next vnii

    End Sub

    Private Sub GetValue()
        Dim vnii As Integer

        For vnii = 0 To MAX_PASSCTRL_COUNT - 1
            mPassCtrlInfo.mPassCtrlTime(vnii).StartHour = CByte(ftxtStartHour(vnii).Text)
            mPassCtrlInfo.mPassCtrlTime(vnii).StartMinute = CByte(ftxtStartMinute(vnii).Text)
            mPassCtrlInfo.mPassCtrlTime(vnii).EndHour = CByte(ftxtEndHour(vnii).Text)
            mPassCtrlInfo.mPassCtrlTime(vnii).EndMinute = CByte(ftxtEndMinute(vnii).Text)
        Next vnii

        For vnii = 0 To MAX_USERPASSINFO_COUNT - 1
            mUserPassInfo.UserPassID(vnii) = CByte(ftxtUserPassTime(vnii).Text)
        Next vnii

        For vnii = 0 To MAX_GROUPPASSINFO_COUNT - 1
            mGroupPassInfo.GroupPassID(vnii) = CByte(ftxtGroupPassTime(vnii).Text)
        Next vnii

        For vnii = 0 To MAX_GROUPMATCHINFO_COUNT - 1
            mGroupMatchInfo.GroupMatch(vnii) = CInt(ftxtGroupMatch(vnii).Text)
        Next vnii
    End Sub
End Class
