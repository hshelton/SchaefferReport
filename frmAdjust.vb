Public Class frmAdjust
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
    Public WithEvents cmbRestoredState As System.Windows.Forms.ComboBox
    Public WithEvents txtRestoredHour As System.Windows.Forms.TextBox
    Public WithEvents txtAdjustedHour As System.Windows.Forms.TextBox
    Public WithEvents txtRestoredMinute As System.Windows.Forms.TextBox
    Public WithEvents txtAdjustedMinute As System.Windows.Forms.TextBox
    Public WithEvents cmdSetAdjustInfo As System.Windows.Forms.Button
    Public WithEvents cmdGetAdjustInfo As System.Windows.Forms.Button
    Public WithEvents txtAdjustedDay As System.Windows.Forms.TextBox
    Public WithEvents txtRestoredDay As System.Windows.Forms.TextBox
    Public WithEvents txtAdjustedMonth As System.Windows.Forms.TextBox
    Public WithEvents txtRestoredMonth As System.Windows.Forms.TextBox
    Public WithEvents cmbAdjustedState As System.Windows.Forms.ComboBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblChangeFlag As System.Windows.Forms.Label
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdjust))
        Me.cmbRestoredState = New System.Windows.Forms.ComboBox()
        Me.txtRestoredHour = New System.Windows.Forms.TextBox()
        Me.txtAdjustedHour = New System.Windows.Forms.TextBox()
        Me.txtRestoredMinute = New System.Windows.Forms.TextBox()
        Me.txtAdjustedMinute = New System.Windows.Forms.TextBox()
        Me.cmdSetAdjustInfo = New System.Windows.Forms.Button()
        Me.cmdGetAdjustInfo = New System.Windows.Forms.Button()
        Me.txtAdjustedDay = New System.Windows.Forms.TextBox()
        Me.txtRestoredDay = New System.Windows.Forms.TextBox()
        Me.txtAdjustedMonth = New System.Windows.Forms.TextBox()
        Me.txtRestoredMonth = New System.Windows.Forms.TextBox()
        Me.cmbAdjustedState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChangeFlag = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbRestoredState
        '
        Me.cmbRestoredState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRestoredState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRestoredState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRestoredState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRestoredState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRestoredState.Items.AddRange(New Object() {"None", "-1", "+1"})
        Me.cmbRestoredState.Location = New System.Drawing.Point(296, 128)
        Me.cmbRestoredState.Name = "cmbRestoredState"
        Me.cmbRestoredState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbRestoredState.Size = New System.Drawing.Size(83, 27)
        Me.cmbRestoredState.TabIndex = 31
        '
        'txtRestoredHour
        '
        Me.txtRestoredHour.AcceptsReturn = True
        Me.txtRestoredHour.AutoSize = False
        Me.txtRestoredHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtRestoredHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRestoredHour.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestoredHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRestoredHour.Location = New System.Drawing.Point(200, 128)
        Me.txtRestoredHour.MaxLength = 32
        Me.txtRestoredHour.Name = "txtRestoredHour"
        Me.txtRestoredHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRestoredHour.Size = New System.Drawing.Size(33, 27)
        Me.txtRestoredHour.TabIndex = 29
        Me.txtRestoredHour.Text = ""
        '
        'txtAdjustedHour
        '
        Me.txtAdjustedHour.AcceptsReturn = True
        Me.txtAdjustedHour.AutoSize = False
        Me.txtAdjustedHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdjustedHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdjustedHour.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustedHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdjustedHour.Location = New System.Drawing.Point(200, 88)
        Me.txtAdjustedHour.MaxLength = 32
        Me.txtAdjustedHour.Name = "txtAdjustedHour"
        Me.txtAdjustedHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdjustedHour.Size = New System.Drawing.Size(34, 27)
        Me.txtAdjustedHour.TabIndex = 24
        Me.txtAdjustedHour.Text = ""
        '
        'txtRestoredMinute
        '
        Me.txtRestoredMinute.AcceptsReturn = True
        Me.txtRestoredMinute.AutoSize = False
        Me.txtRestoredMinute.BackColor = System.Drawing.SystemColors.Window
        Me.txtRestoredMinute.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRestoredMinute.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestoredMinute.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRestoredMinute.Location = New System.Drawing.Point(248, 128)
        Me.txtRestoredMinute.MaxLength = 32
        Me.txtRestoredMinute.Name = "txtRestoredMinute"
        Me.txtRestoredMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRestoredMinute.Size = New System.Drawing.Size(33, 27)
        Me.txtRestoredMinute.TabIndex = 30
        Me.txtRestoredMinute.Text = ""
        '
        'txtAdjustedMinute
        '
        Me.txtAdjustedMinute.AcceptsReturn = True
        Me.txtAdjustedMinute.AutoSize = False
        Me.txtAdjustedMinute.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdjustedMinute.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdjustedMinute.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustedMinute.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdjustedMinute.Location = New System.Drawing.Point(248, 88)
        Me.txtAdjustedMinute.MaxLength = 32
        Me.txtAdjustedMinute.Name = "txtAdjustedMinute"
        Me.txtAdjustedMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdjustedMinute.Size = New System.Drawing.Size(34, 27)
        Me.txtAdjustedMinute.TabIndex = 25
        Me.txtAdjustedMinute.Text = ""
        '
        'cmdSetAdjustInfo
        '
        Me.cmdSetAdjustInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetAdjustInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetAdjustInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetAdjustInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetAdjustInfo.Location = New System.Drawing.Point(264, 176)
        Me.cmdSetAdjustInfo.Name = "cmdSetAdjustInfo"
        Me.cmdSetAdjustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetAdjustInfo.Size = New System.Drawing.Size(115, 29)
        Me.cmdSetAdjustInfo.TabIndex = 33
        Me.cmdSetAdjustInfo.Text = "Set"
        '
        'cmdGetAdjustInfo
        '
        Me.cmdGetAdjustInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetAdjustInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetAdjustInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetAdjustInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetAdjustInfo.Location = New System.Drawing.Point(144, 176)
        Me.cmdGetAdjustInfo.Name = "cmdGetAdjustInfo"
        Me.cmdGetAdjustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetAdjustInfo.Size = New System.Drawing.Size(115, 29)
        Me.cmdGetAdjustInfo.TabIndex = 32
        Me.cmdGetAdjustInfo.Text = "Get"
        '
        'txtAdjustedDay
        '
        Me.txtAdjustedDay.AcceptsReturn = True
        Me.txtAdjustedDay.AutoSize = False
        Me.txtAdjustedDay.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdjustedDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdjustedDay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustedDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdjustedDay.Location = New System.Drawing.Point(160, 88)
        Me.txtAdjustedDay.MaxLength = 32
        Me.txtAdjustedDay.Name = "txtAdjustedDay"
        Me.txtAdjustedDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdjustedDay.Size = New System.Drawing.Size(34, 27)
        Me.txtAdjustedDay.TabIndex = 23
        Me.txtAdjustedDay.Text = ""
        '
        'txtRestoredDay
        '
        Me.txtRestoredDay.AcceptsReturn = True
        Me.txtRestoredDay.AutoSize = False
        Me.txtRestoredDay.BackColor = System.Drawing.SystemColors.Window
        Me.txtRestoredDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRestoredDay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestoredDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRestoredDay.Location = New System.Drawing.Point(160, 128)
        Me.txtRestoredDay.MaxLength = 32
        Me.txtRestoredDay.Name = "txtRestoredDay"
        Me.txtRestoredDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRestoredDay.Size = New System.Drawing.Size(33, 27)
        Me.txtRestoredDay.TabIndex = 28
        Me.txtRestoredDay.Text = ""
        '
        'txtAdjustedMonth
        '
        Me.txtAdjustedMonth.AcceptsReturn = True
        Me.txtAdjustedMonth.AutoSize = False
        Me.txtAdjustedMonth.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdjustedMonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdjustedMonth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustedMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdjustedMonth.Location = New System.Drawing.Point(112, 88)
        Me.txtAdjustedMonth.MaxLength = 32
        Me.txtAdjustedMonth.Name = "txtAdjustedMonth"
        Me.txtAdjustedMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdjustedMonth.Size = New System.Drawing.Size(34, 27)
        Me.txtAdjustedMonth.TabIndex = 22
        Me.txtAdjustedMonth.Text = ""
        '
        'txtRestoredMonth
        '
        Me.txtRestoredMonth.AcceptsReturn = True
        Me.txtRestoredMonth.AutoSize = False
        Me.txtRestoredMonth.BackColor = System.Drawing.SystemColors.Window
        Me.txtRestoredMonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRestoredMonth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestoredMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRestoredMonth.Location = New System.Drawing.Point(112, 128)
        Me.txtRestoredMonth.MaxLength = 32
        Me.txtRestoredMonth.Name = "txtRestoredMonth"
        Me.txtRestoredMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRestoredMonth.Size = New System.Drawing.Size(33, 27)
        Me.txtRestoredMonth.TabIndex = 27
        Me.txtRestoredMonth.Text = ""
        '
        'cmbAdjustedState
        '
        Me.cmbAdjustedState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAdjustedState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAdjustedState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdjustedState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAdjustedState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAdjustedState.Items.AddRange(New Object() {"None", "-1", "+1"})
        Me.cmbAdjustedState.Location = New System.Drawing.Point(296, 88)
        Me.cmbAdjustedState.Name = "cmbAdjustedState"
        Me.cmbAdjustedState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbAdjustedState.Size = New System.Drawing.Size(83, 27)
        Me.cmbAdjustedState.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(232, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(19, 32)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(232, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(19, 32)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(144, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(19, 32)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(144, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(19, 32)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "-"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(208, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "HH:MM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(120, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "MM-DD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblChangeFlag
        '
        Me.lblChangeFlag.AutoSize = True
        Me.lblChangeFlag.BackColor = System.Drawing.SystemColors.Control
        Me.lblChangeFlag.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChangeFlag.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeFlag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChangeFlag.Location = New System.Drawing.Point(288, 64)
        Me.lblChangeFlag.Name = "lblChangeFlag"
        Me.lblChangeFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChangeFlag.TabIndex = 36
        Me.lblChangeFlag.Text = "Change State"
        Me.lblChangeFlag.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(24, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(91, 19)
        Me.Label42.TabIndex = 35
        Me.Label42.Text = "Adjusted on"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(24, 136)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(90, 19)
        Me.Label43.TabIndex = 34
        Me.Label43.Text = "Restored on"
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
        Me.lblMessage.Size = New System.Drawing.Size(361, 28)
        Me.lblMessage.TabIndex = 37
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAdjust
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 216)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRestoredHour, Me.txtAdjustedHour, Me.txtRestoredMinute, Me.txtAdjustedMinute, Me.cmdSetAdjustInfo, Me.cmdGetAdjustInfo, Me.txtAdjustedDay, Me.txtRestoredDay, Me.txtAdjustedMonth, Me.txtRestoredMonth, Me.cmbAdjustedState, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.lblChangeFlag, Me.Label42, Me.Label43, Me.lblMessage, Me.cmbRestoredState})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjuste/Restore Info"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private fnMachineNumber As Integer
    Private fnCommHandleIndex As Long

    Private Sub frmAdjust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        fnMachineNumber = Val(Trim(gfrmMain.txtMachineNumber.Text))
    End Sub

    Private Sub cmbAdjustedState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdjustedState.SelectedIndexChanged
        If cmbAdjustedState.SelectedIndex = 0 Then cmbRestoredState.SelectedIndex = 0
        If cmbAdjustedState.SelectedIndex = 1 Then cmbRestoredState.SelectedIndex = 2
        If cmbAdjustedState.SelectedIndex = 2 Then cmbRestoredState.SelectedIndex = 1
    End Sub

    Private Sub cmdGetAdjustInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetAdjustInfo.Click
        Dim vAdjustedState As Integer
        Dim vAdjustedHour, vAdjustedMonth, vAdjustedDay, vAdjustedMinute As Integer
        Dim vRestoredState As Integer
        Dim vRestoredHour, vRestoredMonth, vRestoredDay, vRestoredMinute As Integer
        Dim vbRet As Boolean
        Dim vErrorCode As Integer

        lblMessage.Text = ""
        Application.DoEvents()

        vbRet = FK_EnableDevice(fnCommHandleIndex, False)
        If vbRet = False Then
            lblMessage.Text = gstrNoDevice
            Exit Sub
        End If

        vbRet = FK_GetAdjustInfo(fnMachineNumber, vAdjustedState, vAdjustedMonth, vAdjustedDay, vAdjustedHour, vAdjustedMinute, vRestoredState, vRestoredMonth, vRestoredDay, vRestoredHour, vRestoredMinute)
        If vbRet = True Then
            If vAdjustedState < 3 Then
                cmbAdjustedState.SelectedIndex = vAdjustedState
            Else
                cmbAdjustedState.SelectedIndex = 0
            End If
            txtAdjustedMonth.Text = CStr(vAdjustedMonth)
            txtAdjustedDay.Text = CStr(vAdjustedDay)
            txtAdjustedHour.Text = CStr(vAdjustedHour)
            txtAdjustedMinute.Text = CStr(vAdjustedMinute)

            If vRestoredState < 3 Then
                cmbRestoredState.SelectedIndex = vRestoredState
            Else
                cmbRestoredState.SelectedIndex = 0
            End If
            txtRestoredMonth.Text = CStr(vRestoredMonth)
            txtRestoredDay.Text = CStr(vRestoredDay)
            txtRestoredHour.Text = CStr(vRestoredHour)
            txtRestoredMinute.Text = CStr(vRestoredMinute)
            lblMessage.Text = "Success!"
        Else
            lblMessage.Text = "Faile!"
        End If

        FK_EnableDevice(fnCommHandleIndex, True)
    End Sub

    Private Sub cmdSetAdjustInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetAdjustInfo.Click
        Dim vAdjustedState As Integer
        Dim vAdjustedHour, vAdjustedMonth, vAdjustedDay, vAdjustedMinute As Integer
        Dim vRestoredState As Integer
        Dim vRestoredHour, vRestoredMonth, vRestoredDay, vRestoredMinute As Integer
        Dim vbRet As Boolean
        Dim vErrorCode As Integer

        lblMessage.Text = ""
        Application.DoEvents()

        vbRet = FK_EnableDevice(fnCommHandleIndex, False)
        If vbRet = False Then
            lblMessage.Text = gstrNoDevice
            Exit Sub
        End If

        vAdjustedState = cmbAdjustedState.SelectedIndex
        vAdjustedMonth = CInt(txtAdjustedMonth.Text)
        vAdjustedDay = CInt(txtAdjustedDay.Text)
        vAdjustedHour = CInt(txtAdjustedHour.Text)
        vAdjustedMinute = CInt(txtAdjustedMinute.Text)

        vRestoredState = cmbRestoredState.SelectedIndex
        vRestoredMonth = CInt(txtRestoredMonth.Text)
        vRestoredDay = CInt(txtRestoredDay.Text)
        vRestoredHour = CInt(txtRestoredHour.Text)
        vRestoredMinute = CInt(txtRestoredMinute.Text)

        vbRet = FK_SetAdjustInfo(fnMachineNumber, vAdjustedState, vAdjustedMonth, vAdjustedDay, vAdjustedHour, vAdjustedMinute, vRestoredState, vRestoredMonth, vRestoredDay, vRestoredHour, vRestoredMinute)
        If vbRet = True Then
            lblMessage.Text = "Success!"
        Else
            lblMessage.Text = "Faile!"
        End If

        FK_EnableDevice(fnMachineNumber, True)
    End Sub
End Class
