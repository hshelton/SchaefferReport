Option Strict Off
Option Explicit On 

Public Class frmSystemInfo
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
    Public WithEvents cmdSetDeviceTime As System.Windows.Forms.Button
    Public WithEvents cmdGetDeviceTime As System.Windows.Forms.Button
    Public WithEvents cmdGetDeviceInfo As System.Windows.Forms.Button
    Public WithEvents cmdPowerOn As System.Windows.Forms.Button
    Public WithEvents PowerOffDevice As System.Windows.Forms.Button
    Public WithEvents cmdSetDeviceInfo As System.Windows.Forms.Button
    Public WithEvents cmbSatus As System.Windows.Forms.ComboBox
    Public WithEvents txtSetDevInfo As System.Windows.Forms.TextBox
    Public WithEvents cmdGetDeviceStaus As System.Windows.Forms.Button
    Public WithEvents chkEnableDevice As System.Windows.Forms.CheckBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblStatus As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSystemInfo))
        Me.cmdSetDeviceTime = New System.Windows.Forms.Button()
        Me.cmdGetDeviceTime = New System.Windows.Forms.Button()
        Me.cmdGetDeviceInfo = New System.Windows.Forms.Button()
        Me.cmdPowerOn = New System.Windows.Forms.Button()
        Me.PowerOffDevice = New System.Windows.Forms.Button()
        Me.cmdSetDeviceInfo = New System.Windows.Forms.Button()
        Me.cmbSatus = New System.Windows.Forms.ComboBox()
        Me.txtSetDevInfo = New System.Windows.Forms.TextBox()
        Me.cmdGetDeviceStaus = New System.Windows.Forms.Button()
        Me.chkEnableDevice = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSetDeviceTime
        '
        Me.cmdSetDeviceTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetDeviceTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetDeviceTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDeviceTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetDeviceTime.Location = New System.Drawing.Point(16, 112)
        Me.cmdSetDeviceTime.Name = "cmdSetDeviceTime"
        Me.cmdSetDeviceTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetDeviceTime.Size = New System.Drawing.Size(130, 32)
        Me.cmdSetDeviceTime.TabIndex = 3
        Me.cmdSetDeviceTime.Text = "SetDeviceTime"
        '
        'cmdGetDeviceTime
        '
        Me.cmdGetDeviceTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetDeviceTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDeviceTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDeviceTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetDeviceTime.Location = New System.Drawing.Point(16, 72)
        Me.cmdGetDeviceTime.Name = "cmdGetDeviceTime"
        Me.cmdGetDeviceTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDeviceTime.Size = New System.Drawing.Size(130, 32)
        Me.cmdGetDeviceTime.TabIndex = 0
        Me.cmdGetDeviceTime.Text = "GetDeviceTime"
        '
        'cmdGetDeviceInfo
        '
        Me.cmdGetDeviceInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetDeviceInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDeviceInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDeviceInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetDeviceInfo.Location = New System.Drawing.Point(16, 224)
        Me.cmdGetDeviceInfo.Name = "cmdGetDeviceInfo"
        Me.cmdGetDeviceInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDeviceInfo.Size = New System.Drawing.Size(130, 32)
        Me.cmdGetDeviceInfo.TabIndex = 5
        Me.cmdGetDeviceInfo.Text = "GetDeviceInfo"
        '
        'cmdPowerOn
        '
        Me.cmdPowerOn.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPowerOn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPowerOn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPowerOn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPowerOn.Location = New System.Drawing.Point(154, 72)
        Me.cmdPowerOn.Name = "cmdPowerOn"
        Me.cmdPowerOn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPowerOn.Size = New System.Drawing.Size(130, 32)
        Me.cmdPowerOn.TabIndex = 1
        Me.cmdPowerOn.Text = "PowerOnDevice"
        '
        'PowerOffDevice
        '
        Me.PowerOffDevice.BackColor = System.Drawing.SystemColors.Control
        Me.PowerOffDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.PowerOffDevice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerOffDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PowerOffDevice.Location = New System.Drawing.Point(154, 112)
        Me.PowerOffDevice.Name = "PowerOffDevice"
        Me.PowerOffDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PowerOffDevice.Size = New System.Drawing.Size(130, 32)
        Me.PowerOffDevice.TabIndex = 4
        Me.PowerOffDevice.Text = "PowerOffDevice"
        '
        'cmdSetDeviceInfo
        '
        Me.cmdSetDeviceInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetDeviceInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetDeviceInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDeviceInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetDeviceInfo.Location = New System.Drawing.Point(154, 224)
        Me.cmdSetDeviceInfo.Name = "cmdSetDeviceInfo"
        Me.cmdSetDeviceInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetDeviceInfo.Size = New System.Drawing.Size(130, 32)
        Me.cmdSetDeviceInfo.TabIndex = 6
        Me.cmdSetDeviceInfo.Text = "SetDeviceInfo"
        '
        'cmbSatus
        '
        Me.cmbSatus.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSatus.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbSatus.Location = New System.Drawing.Point(146, 181)
        Me.cmbSatus.Name = "cmbSatus"
        Me.cmbSatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSatus.Size = New System.Drawing.Size(88, 27)
        Me.cmbSatus.TabIndex = 19
        '
        'txtSetDevInfo
        '
        Me.txtSetDevInfo.AcceptsReturn = True
        Me.txtSetDevInfo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSetDevInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSetDevInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetDevInfo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSetDevInfo.Location = New System.Drawing.Point(362, 181)
        Me.txtSetDevInfo.MaxLength = 0
        Me.txtSetDevInfo.Name = "txtSetDevInfo"
        Me.txtSetDevInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSetDevInfo.Size = New System.Drawing.Size(59, 26)
        Me.txtSetDevInfo.TabIndex = 8
        Me.txtSetDevInfo.Text = ""
        '
        'cmdGetDeviceStaus
        '
        Me.cmdGetDeviceStaus.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetDeviceStaus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDeviceStaus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDeviceStaus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetDeviceStaus.Location = New System.Drawing.Point(292, 224)
        Me.cmdGetDeviceStaus.Name = "cmdGetDeviceStaus"
        Me.cmdGetDeviceStaus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDeviceStaus.Size = New System.Drawing.Size(130, 32)
        Me.cmdGetDeviceStaus.TabIndex = 7
        Me.cmdGetDeviceStaus.Text = "GetDeviceStatus"
        '
        'chkEnableDevice
        '
        Me.chkEnableDevice.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEnableDevice.BackColor = System.Drawing.SystemColors.Control
        Me.chkEnableDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkEnableDevice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnableDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkEnableDevice.Location = New System.Drawing.Point(290, 72)
        Me.chkEnableDevice.Name = "chkEnableDevice"
        Me.chkEnableDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkEnableDevice.Size = New System.Drawing.Size(130, 32)
        Me.chkEnableDevice.TabIndex = 2
        Me.chkEnableDevice.Text = "DisableDevice"
        Me.chkEnableDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(296, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Status Value:"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(42, 186)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(88, 23)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Paramerter:"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(13, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(414, 28)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmSystemInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 272)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdGetDeviceTime, Me.cmdGetDeviceInfo, Me.cmdPowerOn, Me.PowerOffDevice, Me.cmdSetDeviceInfo, Me.cmbSatus, Me.txtSetDevInfo, Me.cmdGetDeviceStaus, Me.chkEnableDevice, Me.Label1, Me.lblStatus, Me.lblMessage, Me.cmdSetDeviceTime})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystemInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage System Info"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private fnCommHandleIndex As Long

    Private Sub frmSytemInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        cmbSatus.SelectedIndex = 0
    End Sub

    Private Sub chkEnableDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnableDevice.CheckedChanged
        Dim vnFlag As Integer
        Dim vnResultCode As Integer

        lblMessage.Text = "Working..."
        Application.DoEvents()

        If chkEnableDevice.CheckState = CheckState.Unchecked Then
            vnFlag = 1
        Else
            vnFlag = 0
        End If

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, vnFlag)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        If chkEnableDevice.CheckState = CheckState.Unchecked Then
            chkEnableDevice.Text = "DisableDevice"
        Else
            chkEnableDevice.Text = "EnableDevice"
        End If
    End Sub

    Private Sub cmdPowerOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPowerOn.Click
        FK_PowerOnAllDevice(fnCommHandleIndex)
    End Sub

    Private Sub PowerOffDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerOffDevice.Click
        Dim vnResultCode As Integer

        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_PowerOffDevice(fnCommHandleIndex)
        lblMessage.Text = ReturnResultPrint(vnResultCode)
    End Sub

    Private Sub cmdGetDeviceTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDeviceTime.Click
        Dim vdwDate As Date
        Dim strDataTime As String
        Dim vnResultCode As Integer

        cmdGetDeviceTime.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetDeviceTime.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_GetDeviceTime(fnCommHandleIndex, vdwDate)
        If vnResultCode = RUN_SUCCESS Then
            strDataTime = "Date = " & Format(vdwDate, "Long Date") & ", Time = " & Format(vdwDate, "Long Time")
            lblMessage.Text = strDataTime
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetDeviceTime.Enabled = True
    End Sub

    Private Sub cmdSetDeviceTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetDeviceTime.Click
        Dim vdwDate As Date
        Dim strDataTime As String
        Dim vnResultCode As Integer

        cmdSetDeviceTime.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetDeviceTime.Enabled = True
            Exit Sub
        End If

        vdwDate = Now
        vnResultCode = FK_SetDeviceTime(fnCommHandleIndex, vdwDate)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetDeviceTime.Enabled = True
    End Sub

    Private Sub cmdGetDeviceStaus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDeviceStaus.Click
        Dim vnStatusIndex As Integer
        Dim vnValue As Integer
        Dim vnResultCode As Integer

        cmdGetDeviceStaus.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetDeviceStaus.Enabled = True
            Exit Sub
        End If

        vnStatusIndex = cmbSatus.SelectedIndex + 1
        vnResultCode = FK_GetDeviceStatus(fnCommHandleIndex, vnStatusIndex, vnValue)
        If vnResultCode = RUN_SUCCESS Then
            Select Case vnStatusIndex
                Case GET_MANAGERS : lblMessage.Text = "Manager count = " & vnValue
                Case GET_USERS : lblMessage.Text = "User count = " & vnValue
                Case GET_FPS : lblMessage.Text = "Fp count = " & vnValue
                Case GET_PSWS : lblMessage.Text = "Password count = " & vnValue
                Case GET_SLOGS : lblMessage.Text = "SLog count = " & vnValue
                Case GET_GLOGS : lblMessage.Text = "GLog count = " & vnValue
                Case GET_ASLOGS : lblMessage.Text = "All SLog count = " & vnValue
                Case GET_AGLOGS : lblMessage.Text = "All GLog count = " & vnValue
                Case GET_CARDS : lblMessage.Text = "Card count = " & vnValue
                Case Else : lblMessage.Text = "--"
            End Select
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetDeviceStaus.Enabled = True
    End Sub

    Private Sub cmdGetDeviceInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDeviceInfo.Click
        Dim vnInfoIndex As Integer
        Dim vnValue As Integer
        Dim vnResultCode As Integer

        cmdGetDeviceInfo.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetDeviceInfo.Enabled = True
            Exit Sub
        End If

        vnInfoIndex = cmbSatus.SelectedIndex + 1
        If vnInfoIndex = 11 Then
            vnInfoIndex = 24
        End If
        vnResultCode = FK_GetDeviceInfo(fnCommHandleIndex, vnInfoIndex, vnValue)
        If vnResultCode = RUN_SUCCESS Then
            Select Case vnInfoIndex
                Case DI_MANAGERS : lblMessage.Text = "ManagerCount = " & vnValue
                Case DI_MACHINENUM : lblMessage.Text = "Machine Num = " & vnValue
                Case DI_LANGAUGE : lblMessage.Text = "Language = " & vnValue
                Case DI_POWEROFF_TIME : lblMessage.Text = "PowerOffTime = " & vnValue
                Case DI_LOCK_CTRL : lblMessage.Text = "LockOperate = " & vnValue
                Case DI_GLOG_WARNING : lblMessage.Text = "GLogWarning = " & vnValue
                Case DI_SLOG_WARNING : lblMessage.Text = "SLogWarning = " & vnValue
                Case DI_VERIFY_INTERVALS : lblMessage.Text = "ReVerifyTime = " & vnValue
                Case DI_RSCOM_BPS : lblMessage.Text = "Baudrate(" & vnValue & ") : "
                    If vnValue = BPS_9600 Then
                        lblMessage.Text = lblMessage.Text & "9600"
                    ElseIf vnValue = BPS_19200 Then
                        lblMessage.Text = lblMessage.Text & "19200"
                    ElseIf vnValue = BPS_38400 Then
                        lblMessage.Text = lblMessage.Text & "38400"
                    ElseIf vnValue = BPS_57600 Then
                        lblMessage.Text = lblMessage.Text & "57600"
                    ElseIf vnValue = BPS_115200 Then
                        lblMessage.Text = lblMessage.Text & "115200"
                    Else
                        lblMessage.Text = lblMessage.Text & "--"
                    End If
                Case DI_VERIFY_KIND : lblMessage.Text = "VerifyKind = "
                    If vnValue = 0 Then
                        lblMessage.Text = lblMessage.Text & "F / P / C"
                    ElseIf vnValue = 1 Then
                        lblMessage.Text = lblMessage.Text & "F + P"
                    ElseIf vnValue = 2 Then
                        lblMessage.Text = lblMessage.Text & "F + C"
                    ElseIf vnValue = 3 Then
                        lblMessage.Text = lblMessage.Text & "C"
                    End If
                Case DI_DATE_SEPARATE : lblMessage.Text = "DateSeperate = " & vnValue
                Case Else : lblMessage.Text = "--"
            End Select
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetDeviceInfo.Enabled = True
    End Sub

    Private Sub cmdSetDeviceInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetDeviceInfo.Click
        Dim vnInfoIndex As Integer
        Dim vnValue As Integer
        Dim vnResultCode As Integer

        cmdSetDeviceInfo.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetDeviceInfo.Enabled = True
            Exit Sub
        End If

        vnInfoIndex = cmbSatus.SelectedIndex + 1
        vnValue = Val(txtSetDevInfo.Text)
        If vnInfoIndex = 11 Then
            vnInfoIndex = 24
        End If
        vnResultCode = FK_SetDeviceInfo(fnCommHandleIndex, vnInfoIndex, vnValue)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetDeviceInfo.Enabled = True
    End Sub
End Class