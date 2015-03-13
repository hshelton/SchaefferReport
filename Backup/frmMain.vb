Option Strict Off
Option Explicit On 

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Public gnCommHandleIndex As Long

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
    Public WithEvents cmdEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdSystemInfo As System.Windows.Forms.Button
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmbCommBaudRate As System.Windows.Forms.ComboBox
    Public WithEvents cmbComPort As System.Windows.Forms.ComboBox
    Public WithEvents lblComBaudRate As System.Windows.Forms.Label
    Public WithEvents lblComPort As System.Windows.Forms.Label
    Public WithEvents cmdOpenComm As System.Windows.Forms.Button
    Public WithEvents cmdUserInfo As System.Windows.Forms.Button
    Public WithEvents cmdBellInfo As System.Windows.Forms.Button
    Public WithEvents optSerialDevice As System.Windows.Forms.RadioButton
    Public WithEvents optNetworkDevice As System.Windows.Forms.RadioButton
    Public WithEvents txtMachineNumber As System.Windows.Forms.TextBox
    Public WithEvents cmdCloseComm As System.Windows.Forms.Button
    Public WithEvents cmdProuctData As System.Windows.Forms.Button
    Public WithEvents lblVer As System.Windows.Forms.Label
    Public WithEvents lblMachineNumber As System.Windows.Forms.Label
    Public WithEvents cmdLogData As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents txtPortNo As System.Windows.Forms.TextBox
    Public WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Public WithEvents lblPassword As System.Windows.Forms.Label
    Public WithEvents lblPortNo As System.Windows.Forms.Label
    Public WithEvents lblIPAddress As System.Windows.Forms.Label
    Public WithEvents lbSubject As System.Windows.Forms.Label
    Public WithEvents txtLicense As System.Windows.Forms.TextBox
    Public WithEvents lblComLicense As System.Windows.Forms.Label
    Public WithEvents cmdSetPassTime As System.Windows.Forms.Button
    Public WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Public WithEvents lblTimeOut As System.Windows.Forms.Label
    Public WithEvents lblTimeOutT As System.Windows.Forms.Label
    Friend WithEvents chkUDPFlag As System.Windows.Forms.CheckBox
    Public WithEvents optUSBDevice As System.Windows.Forms.RadioButton
    Public WithEvents txtTelNumber As System.Windows.Forms.TextBox
    Public WithEvents txtWaitDialTime As System.Windows.Forms.TextBox
    Public WithEvents chkUsingModem As System.Windows.Forms.CheckBox
    Public WithEvents lblTelphon As System.Windows.Forms.Label
    Public WithEvents lblWaitTime As System.Windows.Forms.Label
    Public WithEvents lblS As System.Windows.Forms.Label
    Public WithEvents txtDeviceName As System.Windows.Forms.TextBox
    Public WithEvents lblDeviceName As System.Windows.Forms.Label
    Friend WithEvents cmdGetIP As System.Windows.Forms.Button
    Public WithEvents cmdSetAdjust As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.cmdEnrollData = New System.Windows.Forms.Button
        Me.cmdSystemInfo = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.txtTelNumber = New System.Windows.Forms.TextBox
        Me.txtWaitDialTime = New System.Windows.Forms.TextBox
        Me.chkUsingModem = New System.Windows.Forms.CheckBox
        Me.lblTelphon = New System.Windows.Forms.Label
        Me.lblWaitTime = New System.Windows.Forms.Label
        Me.lblS = New System.Windows.Forms.Label
        Me.cmbCommBaudRate = New System.Windows.Forms.ComboBox
        Me.cmbComPort = New System.Windows.Forms.ComboBox
        Me.lblComBaudRate = New System.Windows.Forms.Label
        Me.lblComPort = New System.Windows.Forms.Label
        Me.cmdOpenComm = New System.Windows.Forms.Button
        Me.cmdUserInfo = New System.Windows.Forms.Button
        Me.cmdBellInfo = New System.Windows.Forms.Button
        Me.optSerialDevice = New System.Windows.Forms.RadioButton
        Me.optNetworkDevice = New System.Windows.Forms.RadioButton
        Me.txtMachineNumber = New System.Windows.Forms.TextBox
        Me.cmdCloseComm = New System.Windows.Forms.Button
        Me.cmdProuctData = New System.Windows.Forms.Button
        Me.lblVer = New System.Windows.Forms.Label
        Me.lblMachineNumber = New System.Windows.Forms.Label
        Me.cmdLogData = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cmdGetIP = New System.Windows.Forms.Button
        Me.txtDeviceName = New System.Windows.Forms.TextBox
        Me.lblDeviceName = New System.Windows.Forms.Label
        Me.chkUDPFlag = New System.Windows.Forms.CheckBox
        Me.lblTimeOutT = New System.Windows.Forms.Label
        Me.txtTimeOut = New System.Windows.Forms.TextBox
        Me.lblTimeOut = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtPortNo = New System.Windows.Forms.TextBox
        Me.txtIPAddress = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblPortNo = New System.Windows.Forms.Label
        Me.lblIPAddress = New System.Windows.Forms.Label
        Me.lbSubject = New System.Windows.Forms.Label
        Me.txtLicense = New System.Windows.Forms.TextBox
        Me.lblComLicense = New System.Windows.Forms.Label
        Me.cmdSetPassTime = New System.Windows.Forms.Button
        Me.optUSBDevice = New System.Windows.Forms.RadioButton
        Me.cmdSetAdjust = New System.Windows.Forms.Button
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEnrollData
        '
        Me.cmdEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnrollData.Location = New System.Drawing.Point(346, 194)
        Me.cmdEnrollData.Name = "cmdEnrollData"
        Me.cmdEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnrollData.Size = New System.Drawing.Size(273, 39)
        Me.cmdEnrollData.TabIndex = 28
        Me.cmdEnrollData.Text = "Enroll Data Management"
        '
        'cmdSystemInfo
        '
        Me.cmdSystemInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSystemInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSystemInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystemInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSystemInfo.Location = New System.Drawing.Point(346, 297)
        Me.cmdSystemInfo.Name = "cmdSystemInfo"
        Me.cmdSystemInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSystemInfo.Size = New System.Drawing.Size(273, 39)
        Me.cmdSystemInfo.TabIndex = 30
        Me.cmdSystemInfo.Text = "System Info Management"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.Frame3.Controls.Add(Me.txtTelNumber)
        Me.Frame3.Controls.Add(Me.txtWaitDialTime)
        Me.Frame3.Controls.Add(Me.chkUsingModem)
        Me.Frame3.Controls.Add(Me.lblTelphon)
        Me.Frame3.Controls.Add(Me.lblWaitTime)
        Me.Frame3.Controls.Add(Me.lblS)
        Me.Frame3.Controls.Add(Me.cmbCommBaudRate)
        Me.Frame3.Controls.Add(Me.cmbComPort)
        Me.Frame3.Controls.Add(Me.lblComBaudRate)
        Me.Frame3.Controls.Add(Me.lblComPort)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(26, 174)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(312, 168)
        Me.Frame3.TabIndex = 40
        Me.Frame3.TabStop = False
        '
        'txtTelNumber
        '
        Me.txtTelNumber.AcceptsReturn = True
        Me.txtTelNumber.AutoSize = False
        Me.txtTelNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelNumber.Location = New System.Drawing.Point(228, 99)
        Me.txtTelNumber.MaxLength = 0
        Me.txtTelNumber.Name = "txtTelNumber"
        Me.txtTelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelNumber.Size = New System.Drawing.Size(74, 27)
        Me.txtTelNumber.TabIndex = 45
        Me.txtTelNumber.Text = "801"
        '
        'txtWaitDialTime
        '
        Me.txtWaitDialTime.AcceptsReturn = True
        Me.txtWaitDialTime.AutoSize = False
        Me.txtWaitDialTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtWaitDialTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWaitDialTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaitDialTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWaitDialTime.Location = New System.Drawing.Point(228, 134)
        Me.txtWaitDialTime.MaxLength = 0
        Me.txtWaitDialTime.Name = "txtWaitDialTime"
        Me.txtWaitDialTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWaitDialTime.Size = New System.Drawing.Size(49, 26)
        Me.txtWaitDialTime.TabIndex = 42
        Me.txtWaitDialTime.Text = "20"
        '
        'chkUsingModem
        '
        Me.chkUsingModem.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.chkUsingModem.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUsingModem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsingModem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUsingModem.Location = New System.Drawing.Point(12, 101)
        Me.chkUsingModem.Name = "chkUsingModem"
        Me.chkUsingModem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUsingModem.Size = New System.Drawing.Size(151, 26)
        Me.chkUsingModem.TabIndex = 41
        Me.chkUsingModem.Text = "Using Modem"
        '
        'lblTelphon
        '
        Me.lblTelphon.BackColor = System.Drawing.Color.Transparent
        Me.lblTelphon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTelphon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelphon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTelphon.Location = New System.Drawing.Point(166, 101)
        Me.lblTelphon.Name = "lblTelphon"
        Me.lblTelphon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTelphon.Size = New System.Drawing.Size(67, 22)
        Me.lblTelphon.TabIndex = 46
        Me.lblTelphon.Text = "Tel No."
        '
        'lblWaitTime
        '
        Me.lblWaitTime.BackColor = System.Drawing.Color.Transparent
        Me.lblWaitTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWaitTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaitTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWaitTime.Location = New System.Drawing.Point(36, 136)
        Me.lblWaitTime.Name = "lblWaitTime"
        Me.lblWaitTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWaitTime.Size = New System.Drawing.Size(194, 21)
        Me.lblWaitTime.TabIndex = 44
        Me.lblWaitTime.Text = "Wait Time For Dialing"
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.Transparent
        Me.lblS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblS.Location = New System.Drawing.Point(278, 136)
        Me.lblS.Name = "lblS"
        Me.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblS.Size = New System.Drawing.Size(15, 21)
        Me.lblS.TabIndex = 43
        Me.lblS.Text = "S"
        '
        'cmbCommBaudRate
        '
        Me.cmbCommBaudRate.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCommBaudRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCommBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCommBaudRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCommBaudRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCommBaudRate.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200"})
        Me.cmbCommBaudRate.Location = New System.Drawing.Point(139, 60)
        Me.cmbCommBaudRate.Name = "cmbCommBaudRate"
        Me.cmbCommBaudRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCommBaudRate.Size = New System.Drawing.Size(126, 27)
        Me.cmbCommBaudRate.TabIndex = 24
        '
        'cmbComPort
        '
        Me.cmbComPort.BackColor = System.Drawing.SystemColors.Window
        Me.cmbComPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComPort.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbComPort.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbComPort.Location = New System.Drawing.Point(139, 26)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbComPort.Size = New System.Drawing.Size(126, 27)
        Me.cmbComPort.TabIndex = 22
        '
        'lblComBaudRate
        '
        Me.lblComBaudRate.AutoSize = True
        Me.lblComBaudRate.BackColor = System.Drawing.Color.Transparent
        Me.lblComBaudRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComBaudRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComBaudRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComBaudRate.Location = New System.Drawing.Point(24, 65)
        Me.lblComBaudRate.Name = "lblComBaudRate"
        Me.lblComBaudRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComBaudRate.Size = New System.Drawing.Size(85, 22)
        Me.lblComBaudRate.TabIndex = 25
        Me.lblComBaudRate.Text = "Baudrate : "
        Me.lblComBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.BackColor = System.Drawing.Color.Transparent
        Me.lblComPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComPort.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComPort.Location = New System.Drawing.Point(24, 30)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComPort.Size = New System.Drawing.Size(85, 22)
        Me.lblComPort.TabIndex = 23
        Me.lblComPort.Text = "ComPort : "
        Me.lblComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdOpenComm
        '
        Me.cmdOpenComm.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpenComm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpenComm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenComm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpenComm.Location = New System.Drawing.Point(346, 142)
        Me.cmdOpenComm.Name = "cmdOpenComm"
        Me.cmdOpenComm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpenComm.Size = New System.Drawing.Size(132, 39)
        Me.cmdOpenComm.TabIndex = 35
        Me.cmdOpenComm.Text = "Open Comm"
        '
        'cmdUserInfo
        '
        Me.cmdUserInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUserInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUserInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUserInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUserInfo.Location = New System.Drawing.Point(346, 452)
        Me.cmdUserInfo.Name = "cmdUserInfo"
        Me.cmdUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUserInfo.Size = New System.Drawing.Size(273, 39)
        Me.cmdUserInfo.TabIndex = 34
        Me.cmdUserInfo.Text = "Set UserInfo"
        '
        'cmdBellInfo
        '
        Me.cmdBellInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBellInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBellInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBellInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBellInfo.Location = New System.Drawing.Point(346, 401)
        Me.cmdBellInfo.Name = "cmdBellInfo"
        Me.cmdBellInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBellInfo.Size = New System.Drawing.Size(273, 38)
        Me.cmdBellInfo.TabIndex = 33
        Me.cmdBellInfo.Text = "Bell Time"
        '
        'optSerialDevice
        '
        Me.optSerialDevice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.optSerialDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSerialDevice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSerialDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSerialDevice.Location = New System.Drawing.Point(38, 172)
        Me.optSerialDevice.Name = "optSerialDevice"
        Me.optSerialDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSerialDevice.Size = New System.Drawing.Size(178, 22)
        Me.optSerialDevice.TabIndex = 39
        Me.optSerialDevice.TabStop = True
        Me.optSerialDevice.Text = "Serial Device"
        '
        'optNetworkDevice
        '
        Me.optNetworkDevice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.optNetworkDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.optNetworkDevice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNetworkDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optNetworkDevice.Location = New System.Drawing.Point(38, 351)
        Me.optNetworkDevice.Name = "optNetworkDevice"
        Me.optNetworkDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optNetworkDevice.Size = New System.Drawing.Size(178, 22)
        Me.optNetworkDevice.TabIndex = 37
        Me.optNetworkDevice.TabStop = True
        Me.optNetworkDevice.Text = "Network Device"
        '
        'txtMachineNumber
        '
        Me.txtMachineNumber.AcceptsReturn = True
        Me.txtMachineNumber.AutoSize = False
        Me.txtMachineNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtMachineNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMachineNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMachineNumber.Location = New System.Drawing.Point(250, 103)
        Me.txtMachineNumber.MaxLength = 0
        Me.txtMachineNumber.Name = "txtMachineNumber"
        Me.txtMachineNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMachineNumber.Size = New System.Drawing.Size(50, 26)
        Me.txtMachineNumber.TabIndex = 42
        Me.txtMachineNumber.Text = "1"
        Me.txtMachineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCloseComm
        '
        Me.cmdCloseComm.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCloseComm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCloseComm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseComm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCloseComm.Location = New System.Drawing.Point(487, 142)
        Me.cmdCloseComm.Name = "cmdCloseComm"
        Me.cmdCloseComm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCloseComm.Size = New System.Drawing.Size(132, 39)
        Me.cmdCloseComm.TabIndex = 36
        Me.cmdCloseComm.Text = "Close Comm"
        '
        'cmdProuctData
        '
        Me.cmdProuctData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProuctData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProuctData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProuctData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProuctData.Location = New System.Drawing.Point(346, 349)
        Me.cmdProuctData.Name = "cmdProuctData"
        Me.cmdProuctData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProuctData.Size = New System.Drawing.Size(273, 39)
        Me.cmdProuctData.TabIndex = 31
        Me.cmdProuctData.Text = "Get Product Data"
        '
        'lblVer
        '
        Me.lblVer.BackColor = System.Drawing.Color.Transparent
        Me.lblVer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVer.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.lblVer.Location = New System.Drawing.Point(0, 58)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVer.Size = New System.Drawing.Size(643, 24)
        Me.lblVer.TabIndex = 32
        Me.lblVer.Text = "FKAttend.dll (Ver 2.611)"
        Me.lblVer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMachineNumber
        '
        Me.lblMachineNumber.AutoSize = True
        Me.lblMachineNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblMachineNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMachineNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachineNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMachineNumber.Location = New System.Drawing.Point(106, 106)
        Me.lblMachineNumber.Name = "lblMachineNumber"
        Me.lblMachineNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMachineNumber.Size = New System.Drawing.Size(130, 22)
        Me.lblMachineNumber.TabIndex = 41
        Me.lblMachineNumber.Text = "Machine Number :"
        '
        'cmdLogData
        '
        Me.cmdLogData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLogData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLogData.Location = New System.Drawing.Point(346, 246)
        Me.cmdLogData.Name = "cmdLogData"
        Me.cmdLogData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLogData.Size = New System.Drawing.Size(273, 38)
        Me.cmdLogData.TabIndex = 29
        Me.cmdLogData.Text = "Log Data Management"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.Frame2.Controls.Add(Me.cmdGetIP)
        Me.Frame2.Controls.Add(Me.txtDeviceName)
        Me.Frame2.Controls.Add(Me.lblDeviceName)
        Me.Frame2.Controls.Add(Me.chkUDPFlag)
        Me.Frame2.Controls.Add(Me.lblTimeOutT)
        Me.Frame2.Controls.Add(Me.txtTimeOut)
        Me.Frame2.Controls.Add(Me.lblTimeOut)
        Me.Frame2.Controls.Add(Me.txtPassword)
        Me.Frame2.Controls.Add(Me.txtPortNo)
        Me.Frame2.Controls.Add(Me.txtIPAddress)
        Me.Frame2.Controls.Add(Me.lblPassword)
        Me.Frame2.Controls.Add(Me.lblPortNo)
        Me.Frame2.Controls.Add(Me.lblIPAddress)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(26, 353)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(312, 247)
        Me.Frame2.TabIndex = 38
        Me.Frame2.TabStop = False
        '
        'cmdGetIP
        '
        Me.cmdGetIP.Location = New System.Drawing.Point(248, 96)
        Me.cmdGetIP.Name = "cmdGetIP"
        Me.cmdGetIP.Size = New System.Drawing.Size(40, 32)
        Me.cmdGetIP.TabIndex = 27
        Me.cmdGetIP.Text = "..."
        '
        'txtDeviceName
        '
        Me.txtDeviceName.AcceptsReturn = True
        Me.txtDeviceName.AutoSize = False
        Me.txtDeviceName.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeviceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeviceName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeviceName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeviceName.Location = New System.Drawing.Point(144, 64)
        Me.txtDeviceName.MaxLength = 0
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeviceName.Size = New System.Drawing.Size(146, 29)
        Me.txtDeviceName.TabIndex = 25
        Me.txtDeviceName.Text = "FingerKeeper"
        '
        'lblDeviceName
        '
        Me.lblDeviceName.BackColor = System.Drawing.Color.Transparent
        Me.lblDeviceName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDeviceName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviceName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDeviceName.Location = New System.Drawing.Point(12, 72)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDeviceName.Size = New System.Drawing.Size(132, 21)
        Me.lblDeviceName.TabIndex = 26
        Me.lblDeviceName.Text = "Device Name :"
        Me.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkUDPFlag
        '
        Me.chkUDPFlag.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUDPFlag.Location = New System.Drawing.Point(144, 216)
        Me.chkUDPFlag.Name = "chkUDPFlag"
        Me.chkUDPFlag.Size = New System.Drawing.Size(77, 20)
        Me.chkUDPFlag.TabIndex = 24
        Me.chkUDPFlag.Text = "UDP"
        '
        'lblTimeOutT
        '
        Me.lblTimeOutT.AutoSize = True
        Me.lblTimeOutT.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOutT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTimeOutT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOutT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTimeOutT.Location = New System.Drawing.Point(221, 184)
        Me.lblTimeOutT.Name = "lblTimeOutT"
        Me.lblTimeOutT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTimeOutT.Size = New System.Drawing.Size(37, 22)
        Me.lblTimeOutT.TabIndex = 23
        Me.lblTimeOutT.Text = "(ms)"
        Me.lblTimeOutT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTimeOut
        '
        Me.txtTimeOut.AcceptsReturn = True
        Me.txtTimeOut.AutoSize = False
        Me.txtTimeOut.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeOut.Location = New System.Drawing.Point(144, 184)
        Me.txtTimeOut.MaxLength = 0
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeOut.Size = New System.Drawing.Size(68, 29)
        Me.txtTimeOut.TabIndex = 22
        Me.txtTimeOut.Text = "5000"
        '
        'lblTimeOut
        '
        Me.lblTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTimeOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTimeOut.Location = New System.Drawing.Point(12, 192)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTimeOut.Size = New System.Drawing.Size(132, 21)
        Me.lblTimeOut.TabIndex = 21
        Me.lblTimeOut.Text = "TimeOut :"
        Me.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.AutoSize = False
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(144, 144)
        Me.txtPassword.MaxLength = 0
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(68, 29)
        Me.txtPassword.TabIndex = 20
        Me.txtPassword.Text = "0"
        '
        'txtPortNo
        '
        Me.txtPortNo.AcceptsReturn = True
        Me.txtPortNo.AutoSize = False
        Me.txtPortNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPortNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPortNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPortNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPortNo.Location = New System.Drawing.Point(144, 104)
        Me.txtPortNo.MaxLength = 0
        Me.txtPortNo.Name = "txtPortNo"
        Me.txtPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPortNo.Size = New System.Drawing.Size(68, 29)
        Me.txtPortNo.TabIndex = 13
        Me.txtPortNo.Text = "5005"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.AcceptsReturn = True
        Me.txtIPAddress.AutoSize = False
        Me.txtIPAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIPAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIPAddress.Location = New System.Drawing.Point(144, 28)
        Me.txtIPAddress.MaxLength = 0
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIPAddress.Size = New System.Drawing.Size(146, 29)
        Me.txtIPAddress.TabIndex = 12
        Me.txtIPAddress.Text = "192.168.0.9"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPassword.Location = New System.Drawing.Point(12, 152)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(132, 20)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Password :"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPortNo
        '
        Me.lblPortNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPortNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPortNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPortNo.Location = New System.Drawing.Point(12, 112)
        Me.lblPortNo.Name = "lblPortNo"
        Me.lblPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPortNo.Size = New System.Drawing.Size(132, 20)
        Me.lblPortNo.TabIndex = 15
        Me.lblPortNo.Text = "Port Number :"
        Me.lblPortNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIPAddress
        '
        Me.lblIPAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblIPAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIPAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIPAddress.Location = New System.Drawing.Point(12, 32)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIPAddress.Size = New System.Drawing.Size(132, 21)
        Me.lblIPAddress.TabIndex = 14
        Me.lblIPAddress.Text = "IP Address :"
        Me.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSubject
        '
        Me.lbSubject.BackColor = System.Drawing.Color.Transparent
        Me.lbSubject.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbSubject.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubject.ForeColor = System.Drawing.Color.Red
        Me.lbSubject.Location = New System.Drawing.Point(0, 13)
        Me.lbSubject.Name = "lbSubject"
        Me.lbSubject.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbSubject.Size = New System.Drawing.Size(643, 34)
        Me.lbSubject.TabIndex = 27
        Me.lbSubject.Text = "FingerKeeper Sample(VB.NET)"
        Me.lbSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLicense
        '
        Me.txtLicense.AcceptsReturn = True
        Me.txtLicense.AutoSize = False
        Me.txtLicense.BackColor = System.Drawing.SystemColors.Window
        Me.txtLicense.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLicense.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicense.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLicense.Location = New System.Drawing.Point(461, 103)
        Me.txtLicense.MaxLength = 0
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLicense.Size = New System.Drawing.Size(65, 26)
        Me.txtLicense.TabIndex = 46
        Me.txtLicense.Text = "0"
        Me.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblComLicense
        '
        Me.lblComLicense.AutoSize = True
        Me.lblComLicense.BackColor = System.Drawing.Color.Transparent
        Me.lblComLicense.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComLicense.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComLicense.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComLicense.Location = New System.Drawing.Point(384, 106)
        Me.lblComLicense.Name = "lblComLicense"
        Me.lblComLicense.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComLicense.Size = New System.Drawing.Size(66, 22)
        Me.lblComLicense.TabIndex = 45
        Me.lblComLicense.Text = "License :"
        '
        'cmdSetPassTime
        '
        Me.cmdSetPassTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetPassTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetPassTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetPassTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetPassTime.Location = New System.Drawing.Point(346, 504)
        Me.cmdSetPassTime.Name = "cmdSetPassTime"
        Me.cmdSetPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetPassTime.Size = New System.Drawing.Size(273, 39)
        Me.cmdSetPassTime.TabIndex = 47
        Me.cmdSetPassTime.Text = "Set PassTime"
        '
        'optUSBDevice
        '
        Me.optUSBDevice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.optUSBDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.optUSBDevice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUSBDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optUSBDevice.Location = New System.Drawing.Point(38, 146)
        Me.optUSBDevice.Name = "optUSBDevice"
        Me.optUSBDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optUSBDevice.Size = New System.Drawing.Size(178, 22)
        Me.optUSBDevice.TabIndex = 49
        Me.optUSBDevice.TabStop = True
        Me.optUSBDevice.Text = "USB Device"
        '
        'cmdSetAdjust
        '
        Me.cmdSetAdjust.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetAdjust.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetAdjust.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetAdjust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetAdjust.Location = New System.Drawing.Point(346, 555)
        Me.cmdSetAdjust.Name = "cmdSetAdjust"
        Me.cmdSetAdjust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetAdjust.Size = New System.Drawing.Size(273, 39)
        Me.cmdSetAdjust.TabIndex = 50
        Me.cmdSetAdjust.Text = "Set AdjustInfo"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(640, 608)
        Me.Controls.Add(Me.cmdSetAdjust)
        Me.Controls.Add(Me.optUSBDevice)
        Me.Controls.Add(Me.cmdSetPassTime)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.lblComLicense)
        Me.Controls.Add(Me.cmdEnrollData)
        Me.Controls.Add(Me.cmdSystemInfo)
        Me.Controls.Add(Me.cmdOpenComm)
        Me.Controls.Add(Me.cmdUserInfo)
        Me.Controls.Add(Me.cmdBellInfo)
        Me.Controls.Add(Me.optSerialDevice)
        Me.Controls.Add(Me.optNetworkDevice)
        Me.Controls.Add(Me.txtMachineNumber)
        Me.Controls.Add(Me.cmdCloseComm)
        Me.Controls.Add(Me.cmdProuctData)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.cmdLogData)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.lbSubject)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.lblMachineNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu(VB.NET Sample)"
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gbOpenFlag As Boolean

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gfrmMain = Me
        gnCommHandleIndex = 0
        optSerialDevice.Checked = False
        optNetworkDevice.Checked = True
        optUSBDevice.Checked = False
        optNetworkDevice_CheckedChanged(optNetworkDevice, e)
        OwnerEnableButtons(False)

        gbOpenFlag = False
        txtMachineNumber.Text = "1"
        cmbComPort.SelectedIndex = 0
        cmbCommBaudRate.SelectedIndex = 2
    End Sub

    Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        cmdCloseComm_Click(cmdCloseComm, New System.EventArgs())
    End Sub

    Private Sub chkUsingModem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUsingModem.CheckedChanged
        If optSerialDevice.Checked Then
            OwnerEnableItems(1)
        End If
    End Sub

    Private Sub optSerialDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSerialDevice.CheckedChanged
        If sender.Checked Then
            OwnerEnableItems(1)
        End If
    End Sub

    Private Sub optNetworkDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNetworkDevice.CheckedChanged
        If sender.Checked Then
            OwnerEnableItems(2)
        End If
    End Sub

    Private Sub optUSBDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optUSBDevice.CheckedChanged
        If sender.Checked Then
            OwnerEnableItems(3)
        End If
    End Sub

    Private Sub cmdOpenComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenComm.Click
        Dim vnMachineNumber As Integer
        Dim vnCommPort As Integer
        Dim vnCommBaudrate As Integer
        Dim vstrTelNumber As String
        Dim vnWaitDialTime As Long
        Dim vnLicense As Long
        Dim vpszIPAddress As String
        Dim vpszNetPort As Integer
        Dim vpszNetPassword As Integer
        Dim vnTimeOut As Long
        Dim vnProtocolType As Long
        Dim vnResultCode As Long

        cmdOpenComm.Enabled = False
        vnMachineNumber = Val(txtMachineNumber.Text)
        vnLicense = Val(txtLicense.Text)
        If optSerialDevice.Checked = True Then

            If chkUsingModem.Checked = True Then
                vstrTelNumber = Trim(txtTelNumber.Text)
                vnWaitDialTime = Val(Trim(txtWaitDialTime.Text))
                If vnWaitDialTime < 10 And vnWaitDialTime > 60 Then
                    vnWaitDialTime = 10
                    txtWaitDialTime.Text = "10"
                End If
            Else
                vstrTelNumber = ""
                vnWaitDialTime = 0
            End If

            vnCommPort = Val(Trim(cmbComPort.Text))
            vnCommBaudrate = Val(Trim(cmbCommBaudRate.Text))
            gnCommHandleIndex = FK_ConnectComm(vnMachineNumber, vnCommPort, vnCommBaudrate, vstrTelNumber, vnWaitDialTime, vnLicense)
        ElseIf optNetworkDevice.Checked = True Then
            vpszIPAddress = Trim(txtIPAddress.Text)
            vpszNetPort = CInt(txtPortNo.Text)
            vpszNetPassword = CInt(txtPassword.Text)
            vnTimeOut = CLng(txtTimeOut.Text)
            If chkUDPFlag.Checked = False Then
                vnProtocolType = PROTOCOL_TCPIP
            Else
                vnProtocolType = PROTOCOL_UDP
            End If
            gnCommHandleIndex = FK_ConnectNet(vnMachineNumber, vpszIPAddress, vpszNetPort, vnTimeOut, vnProtocolType, vpszNetPassword, vnLicense)
        ElseIf optUSBDevice.Checked = True Then
            gnCommHandleIndex = FK_ConnectUSB(vnMachineNumber, vnLicense)
        End If

        If gnCommHandleIndex > 0 Then
            gbOpenFlag = True
            OwnerEnableButtons(True)
        Else
            vnResultCode = gnCommHandleIndex
            MsgBox(ReturnResultPrint(vnResultCode), vbOKOnly, "error")
            cmdOpenComm.Enabled = True
        End If
    End Sub

    Private Sub cmdCloseComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseComm.Click
        If gbOpenFlag = True Then
            FK_DisConnect(gnCommHandleIndex)
            gbOpenFlag = False
            OwnerEnableButtons(False)
        End If
    End Sub

    Private Sub cmdEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnrollData.Click
        funcCallChildForm(New frmEnroll())
    End Sub

    Private Sub cmdLogData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogData.Click
        funcCallChildForm(New frmLog())
    End Sub

    Private Sub cmdSystemInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSystemInfo.Click
        funcCallChildForm(New frmSystemInfo())
    End Sub
    Private Sub cmdProuctData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProuctData.Click
        funcCallChildForm(New frmProductData())
    End Sub

    Private Sub cmdBellInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBellInfo.Click
        funcCallChildForm(New frmBellInfo())
    End Sub

    Private Sub cmdUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUserInfo.Click
        funcCallChildForm(New frmUserInfo())
    End Sub

    Private Sub cmdSetPassTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetPassTime.Click
        funcCallChildForm(New frmPasstimeInfo())
    End Sub

    Private Sub cmdSetAdjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetAdjust.Click
        funcCallChildForm(New frmAdjust)
    End Sub

    Private Sub OwnerEnableButtons(ByRef abEnableFlag As Boolean)
        cmdOpenComm.Enabled = Not abEnableFlag
        cmdCloseComm.Enabled = abEnableFlag
        cmdSystemInfo.Enabled = abEnableFlag
        cmdProuctData.Enabled = abEnableFlag
        cmdBellInfo.Enabled = abEnableFlag
        cmdUserInfo.Enabled = abEnableFlag
        cmdSetPassTime.Enabled = abEnableFlag
        cmdSetAdjust.Enabled = abEnableFlag
        optSerialDevice.Enabled = Not abEnableFlag
        optNetworkDevice.Enabled = Not abEnableFlag
        optUSBDevice.Enabled = Not abEnableFlag
    End Sub

    Private Sub OwnerEnableItems(ByVal anEnableFlag As Long)
        lblComPort.Enabled = False
        cmbComPort.Enabled = False
        lblComBaudRate.Enabled = False
        cmbCommBaudRate.Enabled = False
        chkUsingModem.Enabled = False
        lblTelphon.Enabled = False
        txtTelNumber.Enabled = False
        lblWaitTime.Enabled = False
        txtWaitDialTime.Enabled = False
        lblS.Enabled = False

        lblIPAddress.Enabled = False
        txtIPAddress.Enabled = False
        lblDeviceName.Enabled = False
        txtDeviceName.Enabled = False
        lblPortNo.Enabled = False
        txtPortNo.Enabled = False
        lblPassword.Enabled = False
        txtPassword.Enabled = False
        lblTimeOut.Enabled = False
        txtTimeOut.Enabled = False
        lblTimeOutT.Enabled = False
        chkUDPFlag.Enabled = False

        Select Case anEnableFlag
            Case 1
                lblComPort.Enabled = True
                cmbComPort.Enabled = True
                lblComBaudRate.Enabled = True
                cmbCommBaudRate.Enabled = True
                chkUsingModem.Enabled = True
                If chkUsingModem.Checked = True Then
                    lblTelphon.Enabled = True
                    txtTelNumber.Enabled = True
                    lblWaitTime.Enabled = True
                    txtWaitDialTime.Enabled = True
                    lblS.Enabled = True
                End If

            Case 2
                lblIPAddress.Enabled = True
                txtIPAddress.Enabled = True
                lblDeviceName.Enabled = True
                txtDeviceName.Enabled = True
                lblPortNo.Enabled = True
                txtPortNo.Enabled = True
                lblPassword.Enabled = True
                txtPassword.Enabled = True
                lblTimeOut.Enabled = True
                txtTimeOut.Enabled = True
                lblTimeOutT.Enabled = True
                chkUDPFlag.Enabled = True
        End Select
    End Sub

    Private Sub funcCallChildForm(ByVal afrmChild As Form)
        If Not IsNothing(afrmChild) Then
            Me.Hide()
            afrmChild.Owner = Me
            afrmChild.ShowDialog()
            afrmChild.Dispose()
            Me.Show()
        End If
    End Sub

    Private Sub cmdGetIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetIP.Click
        Dim m_DeviceName As String
        m_DeviceName = txtDeviceName.Text
        Trim(m_DeviceName)
        FK_ConnectGetIP(m_DeviceName)
        txtIPAddress.Text = m_DeviceName
    End Sub
End Class