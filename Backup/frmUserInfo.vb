Option Strict Off
Option Explicit On 

Friend Class frmUserInfo
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
    Public WithEvents cmdDeleteCompanyName As System.Windows.Forms.Button
    Public WithEvents cmdSetCompanyName As System.Windows.Forms.Button
    Public WithEvents cmdDeleteNewsID As System.Windows.Forms.Button
    Public WithEvents cmdClearNewsID As System.Windows.Forms.Button
    Public WithEvents cmdClearNews As System.Windows.Forms.Button
    Public WithEvents txtMessageID As System.Windows.Forms.TextBox
    Public WithEvents cmdSetUserNews As System.Windows.Forms.Button
    Public WithEvents cmdGetUserNews As System.Windows.Forms.Button
    Public WithEvents cmdSetNewsMessage As System.Windows.Forms.Button
    Public WithEvents cmdGetNewsMessage As System.Windows.Forms.Button
    Public WithEvents txtUserMessage As System.Windows.Forms.TextBox
    Public WithEvents txtEnrollNumber As System.Windows.Forms.TextBox
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Public WithEvents cmdGetUserName As System.Windows.Forms.Button
    Public WithEvents cmdSetUserName As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    Public WithEvents lblEnrollNum As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents cmdSetAllUserNews As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserInfo))
        Me.cmdGetUserName = New System.Windows.Forms.Button()
        Me.cmdSetUserName = New System.Windows.Forms.Button()
        Me.cmdDeleteCompanyName = New System.Windows.Forms.Button()
        Me.cmdSetCompanyName = New System.Windows.Forms.Button()
        Me.cmdDeleteNewsID = New System.Windows.Forms.Button()
        Me.cmdClearNewsID = New System.Windows.Forms.Button()
        Me.cmdClearNews = New System.Windows.Forms.Button()
        Me.txtMessageID = New System.Windows.Forms.TextBox()
        Me.cmdSetUserNews = New System.Windows.Forms.Button()
        Me.cmdGetUserNews = New System.Windows.Forms.Button()
        Me.cmdSetNewsMessage = New System.Windows.Forms.Button()
        Me.cmdGetNewsMessage = New System.Windows.Forms.Button()
        Me.txtUserMessage = New System.Windows.Forms.TextBox()
        Me.txtEnrollNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblEnrollNum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSetAllUserNews = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdGetUserName
        '
        Me.cmdGetUserName.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetUserName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetUserName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetUserName.Location = New System.Drawing.Point(288, 96)
        Me.cmdGetUserName.Name = "cmdGetUserName"
        Me.cmdGetUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetUserName.Size = New System.Drawing.Size(137, 25)
        Me.cmdGetUserName.TabIndex = 1
        Me.cmdGetUserName.Text = "Get User Name"
        '
        'cmdSetUserName
        '
        Me.cmdSetUserName.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetUserName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetUserName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetUserName.Location = New System.Drawing.Point(288, 64)
        Me.cmdSetUserName.Name = "cmdSetUserName"
        Me.cmdSetUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetUserName.Size = New System.Drawing.Size(137, 25)
        Me.cmdSetUserName.TabIndex = 0
        Me.cmdSetUserName.Text = "Set User Name"
        '
        'cmdDeleteCompanyName
        '
        Me.cmdDeleteCompanyName.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteCompanyName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteCompanyName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteCompanyName.Location = New System.Drawing.Point(233, 296)
        Me.cmdDeleteCompanyName.Name = "cmdDeleteCompanyName"
        Me.cmdDeleteCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteCompanyName.Size = New System.Drawing.Size(209, 25)
        Me.cmdDeleteCompanyName.TabIndex = 10
        Me.cmdDeleteCompanyName.Text = "Delete Company Name"
        '
        'cmdSetCompanyName
        '
        Me.cmdSetCompanyName.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetCompanyName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetCompanyName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetCompanyName.Location = New System.Drawing.Point(16, 296)
        Me.cmdSetCompanyName.Name = "cmdSetCompanyName"
        Me.cmdSetCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetCompanyName.Size = New System.Drawing.Size(209, 25)
        Me.cmdSetCompanyName.TabIndex = 9
        Me.cmdSetCompanyName.Text = "Set Company Name"
        '
        'cmdDeleteNewsID
        '
        Me.cmdDeleteNewsID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteNewsID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteNewsID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteNewsID.Location = New System.Drawing.Point(322, 256)
        Me.cmdDeleteNewsID.Name = "cmdDeleteNewsID"
        Me.cmdDeleteNewsID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteNewsID.Size = New System.Drawing.Size(120, 25)
        Me.cmdDeleteNewsID.TabIndex = 8
        Me.cmdDeleteNewsID.Text = "Delete News ID"
        '
        'cmdClearNewsID
        '
        Me.cmdClearNewsID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearNewsID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearNewsID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearNewsID.Location = New System.Drawing.Point(208, 256)
        Me.cmdClearNewsID.Name = "cmdClearNewsID"
        Me.cmdClearNewsID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearNewsID.Size = New System.Drawing.Size(114, 25)
        Me.cmdClearNewsID.TabIndex = 7
        Me.cmdClearNewsID.Text = "Clear News ID"
        '
        'cmdClearNews
        '
        Me.cmdClearNews.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearNews.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearNews.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearNews.Location = New System.Drawing.Point(112, 256)
        Me.cmdClearNews.Name = "cmdClearNews"
        Me.cmdClearNews.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearNews.Size = New System.Drawing.Size(96, 25)
        Me.cmdClearNews.TabIndex = 6
        Me.cmdClearNews.Text = "Clear News"
        '
        'txtMessageID
        '
        Me.txtMessageID.AcceptsReturn = True
        Me.txtMessageID.AutoSize = False
        Me.txtMessageID.BackColor = System.Drawing.SystemColors.Window
        Me.txtMessageID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessageID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMessageID.Location = New System.Drawing.Point(120, 144)
        Me.txtMessageID.MaxLength = 0
        Me.txtMessageID.Name = "txtMessageID"
        Me.txtMessageID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMessageID.Size = New System.Drawing.Size(57, 25)
        Me.txtMessageID.TabIndex = 13
        Me.txtMessageID.Text = ""
        '
        'cmdSetUserNews
        '
        Me.cmdSetUserNews.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetUserNews.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetUserNews.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetUserNews.Location = New System.Drawing.Point(208, 216)
        Me.cmdSetUserNews.Name = "cmdSetUserNews"
        Me.cmdSetUserNews.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetUserNews.Size = New System.Drawing.Size(114, 25)
        Me.cmdSetUserNews.TabIndex = 4
        Me.cmdSetUserNews.Text = "Set News ID"
        '
        'cmdGetUserNews
        '
        Me.cmdGetUserNews.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetUserNews.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetUserNews.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetUserNews.Location = New System.Drawing.Point(322, 216)
        Me.cmdGetUserNews.Name = "cmdGetUserNews"
        Me.cmdGetUserNews.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetUserNews.Size = New System.Drawing.Size(120, 25)
        Me.cmdGetUserNews.TabIndex = 5
        Me.cmdGetUserNews.Text = "Get  News ID "
        '
        'cmdSetNewsMessage
        '
        Me.cmdSetNewsMessage.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetNewsMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetNewsMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetNewsMessage.Location = New System.Drawing.Point(16, 216)
        Me.cmdSetNewsMessage.Name = "cmdSetNewsMessage"
        Me.cmdSetNewsMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetNewsMessage.Size = New System.Drawing.Size(96, 25)
        Me.cmdSetNewsMessage.TabIndex = 2
        Me.cmdSetNewsMessage.Text = "Set News"
        '
        'cmdGetNewsMessage
        '
        Me.cmdGetNewsMessage.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetNewsMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetNewsMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetNewsMessage.Location = New System.Drawing.Point(112, 216)
        Me.cmdGetNewsMessage.Name = "cmdGetNewsMessage"
        Me.cmdGetNewsMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetNewsMessage.Size = New System.Drawing.Size(96, 25)
        Me.cmdGetNewsMessage.TabIndex = 3
        Me.cmdGetNewsMessage.Text = "Get News"
        '
        'txtUserMessage
        '
        Me.txtUserMessage.AcceptsReturn = True
        Me.txtUserMessage.AutoSize = False
        Me.txtUserMessage.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserMessage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserMessage.Location = New System.Drawing.Point(120, 176)
        Me.txtUserMessage.MaxLength = 0
        Me.txtUserMessage.Name = "txtUserMessage"
        Me.txtUserMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserMessage.Size = New System.Drawing.Size(320, 32)
        Me.txtUserMessage.TabIndex = 7
        Me.txtUserMessage.Text = ""
        '
        'txtEnrollNumber
        '
        Me.txtEnrollNumber.AcceptsReturn = True
        Me.txtEnrollNumber.AutoSize = False
        Me.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnrollNumber.Location = New System.Drawing.Point(120, 104)
        Me.txtEnrollNumber.MaxLength = 8
        Me.txtEnrollNumber.Name = "txtEnrollNumber"
        Me.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnrollNumber.Size = New System.Drawing.Size(96, 27)
        Me.txtEnrollNumber.TabIndex = 3
        Me.txtEnrollNumber.Text = ""
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(120, 64)
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(97, 27)
        Me.txtName.TabIndex = 11
        Me.txtName.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(192, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(257, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "( 1-50 User message count )"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(10, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "News  ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Message :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.lblMessage.Size = New System.Drawing.Size(426, 33)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnrollNum
        '
        Me.lblEnrollNum.AutoSize = True
        Me.lblEnrollNum.BackColor = System.Drawing.SystemColors.Control
        Me.lblEnrollNum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnrollNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnrollNum.Location = New System.Drawing.Point(10, 108)
        Me.lblEnrollNum.Name = "lblEnrollNum"
        Me.lblEnrollNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnrollNum.Size = New System.Drawing.Size(114, 19)
        Me.lblEnrollNum.TabIndex = 5
        Me.lblEnrollNum.Text = "Enroll Number :"
        Me.lblEnrollNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSetAllUserNews
        '
        Me.cmdSetAllUserNews.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetAllUserNews.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetAllUserNews.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetAllUserNews.Location = New System.Drawing.Point(16, 256)
        Me.cmdSetAllUserNews.Name = "cmdSetAllUserNews"
        Me.cmdSetAllUserNews.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetAllUserNews.Size = New System.Drawing.Size(96, 25)
        Me.cmdSetAllUserNews.TabIndex = 17
        Me.cmdSetAllUserNews.Text = "Set All News"
        '
        'frmUserInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.ClientSize = New System.Drawing.Size(458, 335)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSetAllUserNews, Me.cmdDeleteCompanyName, Me.cmdSetCompanyName, Me.cmdDeleteNewsID, Me.cmdClearNewsID, Me.cmdClearNews, Me.txtMessageID, Me.cmdSetUserNews, Me.cmdGetUserNews, Me.cmdSetNewsMessage, Me.cmdGetNewsMessage, Me.txtUserMessage, Me.txtEnrollNumber, Me.txtName, Me.cmdGetUserName, Me.cmdSetUserName, Me.Label4, Me.Label2, Me.Label1, Me.lblMessage, Me.lblEnrollNum, Me.Label3})
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(2, 28)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.ResumeLayout(False)

    End Sub
#End Region 
    Const NAMESIZE As Short = 400

    Private fnCommHandleIndex As Long
    Private gGetState As Boolean
    Private glngUserName(NAMESIZE) As Integer

    Private Sub frmUserInfo_Load(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        txtEnrollNumber.Text = "1"
        txtMessageID.Text = "1"
        txtUserMessage.Text = "Thank you"
    End Sub

    Private Sub cmdClearNews_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearNews.Click
        Dim vnResultCode As Integer

        cmdClearNews.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdClearNews.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_SetNewsMessage(fnCommHandleIndex, 255, CStr(glngUserName(0)))
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Clear All New Message OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdClearNews.Enabled = True
    End Sub

    Private Sub cmdClearNewsID_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearNewsID.Click
        Dim vEnrollNumber As Integer
        Dim vMessageNumber As Integer
        Dim vnResultCode As Integer

        cmdClearNewsID.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdClearNewsID.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = 0
        vMessageNumber = 255
        vnResultCode = FK_SetUserNewsID(fnCommHandleIndex, vEnrollNumber, vMessageNumber)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Clear User News OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdClearNewsID.Enabled = True
    End Sub

    Private Sub cmdDeleteCompanyName_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteCompanyName.Click
        Dim vnResultCode As Integer

        cmdDeleteCompanyName.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdDeleteCompanyName.Enabled = True
            Exit Sub
        End If

        txtUserMessage.Text = CStr(Nothing)
        vnResultCode = FK_SetNewsMessage(fnCommHandleIndex, 0, txtUserMessage.Text)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Delete Company Name OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdDeleteCompanyName.Enabled = True
    End Sub

    Private Sub cmdDeleteNewsID_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteNewsID.Click
        Dim vEnrollNumber As Integer
        Dim vMessageNumber As Integer
        Dim vnResultCode As Integer

        cmdDeleteNewsID.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdDeleteNewsID.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vMessageNumber = 255
        vnResultCode = FK_SetUserNewsID(fnCommHandleIndex, vEnrollNumber, vMessageNumber)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Set User News OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdDeleteNewsID.Enabled = True
    End Sub

    Private Sub cmdGetNewsMessage_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetNewsMessage.Click
        Dim vMessageNumber As Integer
        Dim vNews As String
        Dim vnResultCode As Integer

        cmdGetNewsMessage.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetNewsMessage.Enabled = True
            Exit Sub
        End If

        vMessageNumber = Val(txtMessageID.Text)
        vNews = Space(256)
        vnResultCode = FK_GetNewsMessage(fnCommHandleIndex, vMessageNumber, vNews)
        If vnResultCode = RUN_SUCCESS Then
            txtUserMessage.Text = vNews
            lblMessage.Text = "Get News Message OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetNewsMessage.Enabled = True
    End Sub

    Private Sub cmdGetUserName_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetUserName.Click
        Dim vEnrollNumber As Integer
        Dim vName As String
        Dim vnResultCode As Integer

        cmdGetUserName.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetUserName.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vName = Space(256)
        vnResultCode = FK_GetUserName(fnCommHandleIndex, vEnrollNumber, vName)
        If vnResultCode = RUN_SUCCESS Then
            txtName.Text = vName
            lblMessage.Text = "GetUserName OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetUserName.Enabled = True
    End Sub

    Private Sub cmdGetUserNews_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetUserNews.Click
        Dim vEnrollNumber As Integer
        Dim vMessageNumber As Integer
        Dim vnResultCode As Integer

        cmdGetUserNews.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetUserNews.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vnResultCode = FK_GetUserNewsID(fnCommHandleIndex, vEnrollNumber, vMessageNumber)
        If vnResultCode = RUN_SUCCESS Then
            txtMessageID.Text = CStr(vMessageNumber)
            lblMessage.Text = "Get User News ID OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetUserNews.Enabled = True
    End Sub

    Private Sub cmdSetCompanyName_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetCompanyName.Click
        Dim vnResultCode As Integer

        cmdSetCompanyName.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetCompanyName.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_SetNewsMessage(fnCommHandleIndex, 0, Trim(txtUserMessage.Text))
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Set Company Name OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetCompanyName.Enabled = True
    End Sub

    Private Sub cmdSetNewsMessage_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetNewsMessage.Click
        Dim vMessageNumber As Integer
        Dim vnResultCode As Integer

        cmdSetNewsMessage.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetNewsMessage.Enabled = True
            Exit Sub
        End If

        vMessageNumber = Val(txtMessageID.Text)
        vnResultCode = FK_SetNewsMessage(fnCommHandleIndex, vMessageNumber, Trim(txtUserMessage.Text))
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Set New Message OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetNewsMessage.Enabled = True
    End Sub

    Private Sub cmdSetUserName_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetUserName.Click
        Dim vEnrollNumber As Integer
        Dim vnResultCode As Integer

        cmdSetUserName.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetUserName.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vnResultCode = FK_SetUserName(fnCommHandleIndex, vEnrollNumber, Trim(txtName.Text))
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "SetUserName OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetUserName.Enabled = True
    End Sub

    Private Sub cmdSetUserNews_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetUserNews.Click
        Dim vEnrollNumber As Integer
        Dim vMessageNumber As Integer
        Dim vnResultCode As Integer

        cmdSetUserNews.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetUserNews.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vMessageNumber = Val(txtMessageID.Text)
        vnResultCode = FK_SetUserNewsID(fnCommHandleIndex, vEnrollNumber, vMessageNumber)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Set User News  OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetUserNews.Enabled = True
    End Sub

    Private Sub cmdSetAllUserNews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetAllUserNews.Click
        Dim vEnrollNumber As Integer
        Dim vMessageNumber As Integer
        Dim vnResultCode As Integer

        cmdSetAllUserNews.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetAllUserNews.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = 0
        vMessageNumber = Val(txtMessageID.Text)
        vnResultCode = FK_SetUserNewsID(fnCommHandleIndex, vEnrollNumber, vMessageNumber)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Set All User News OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetAllUserNews.Enabled = True
    End Sub
End Class