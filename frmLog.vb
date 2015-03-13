Option Strict Off
Option Explicit On 
Imports System.IO.Directory

Public Class frmLog
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
    Public WithEvents chkReadMark As System.Windows.Forms.CheckBox
    Public WithEvents cmdGlogData As System.Windows.Forms.Button
    Public WithEvents cmdSLogData As System.Windows.Forms.Button
    Public WithEvents lblEnrollData As System.Windows.Forms.Label
    Public WithEvents lblTotal As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents gridLogView As System.Windows.Forms.ListView
    Public WithEvents cmdUsbSLog As System.Windows.Forms.Button
    Public WithEvents cmdUsbGlog As System.Windows.Forms.Button
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmdEmptySLogData As System.Windows.Forms.Button
    Public WithEvents cmdEmptyGLogData As System.Windows.Forms.Button
    Public WithEvents chkSave As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte)))}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte)))}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte)))}, -1)
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLog))
        Me.chkReadMark = New System.Windows.Forms.CheckBox()
        Me.cmdEmptyGLogData = New System.Windows.Forms.Button()
        Me.cmdEmptySLogData = New System.Windows.Forms.Button()
        Me.cmdGlogData = New System.Windows.Forms.Button()
        Me.cmdSLogData = New System.Windows.Forms.Button()
        Me.lblEnrollData = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.gridLogView = New System.Windows.Forms.ListView()
        Me.cmdUsbSLog = New System.Windows.Forms.Button()
        Me.cmdUsbGlog = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.chkSave = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkReadMark
        '
        Me.chkReadMark.BackColor = System.Drawing.SystemColors.Control
        Me.chkReadMark.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReadMark.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReadMark.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReadMark.Location = New System.Drawing.Point(558, 64)
        Me.chkReadMark.Name = "chkReadMark"
        Me.chkReadMark.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReadMark.Size = New System.Drawing.Size(96, 19)
        Me.chkReadMark.TabIndex = 6
        Me.chkReadMark.Text = "ReadMark"
        '
        'cmdEmptyGLogData
        '
        Me.cmdEmptyGLogData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmptyGLogData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmptyGLogData.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmptyGLogData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmptyGLogData.Location = New System.Drawing.Point(440, 424)
        Me.cmdEmptyGLogData.Name = "cmdEmptyGLogData"
        Me.cmdEmptyGLogData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmptyGLogData.Size = New System.Drawing.Size(106, 43)
        Me.cmdEmptyGLogData.TabIndex = 4
        Me.cmdEmptyGLogData.Text = "Empty GLogData"
        '
        'cmdEmptySLogData
        '
        Me.cmdEmptySLogData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmptySLogData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmptySLogData.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmptySLogData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmptySLogData.Location = New System.Drawing.Point(122, 424)
        Me.cmdEmptySLogData.Name = "cmdEmptySLogData"
        Me.cmdEmptySLogData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmptySLogData.Size = New System.Drawing.Size(106, 43)
        Me.cmdEmptySLogData.TabIndex = 1
        Me.cmdEmptySLogData.Text = "Empty SLogData"
        '
        'cmdGlogData
        '
        Me.cmdGlogData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGlogData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGlogData.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGlogData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGlogData.Location = New System.Drawing.Point(334, 424)
        Me.cmdGlogData.Name = "cmdGlogData"
        Me.cmdGlogData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGlogData.Size = New System.Drawing.Size(106, 43)
        Me.cmdGlogData.TabIndex = 3
        Me.cmdGlogData.Text = "Read GLogData"
        '
        'cmdSLogData
        '
        Me.cmdSLogData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSLogData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSLogData.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSLogData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSLogData.Location = New System.Drawing.Point(16, 424)
        Me.cmdSLogData.Name = "cmdSLogData"
        Me.cmdSLogData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSLogData.Size = New System.Drawing.Size(106, 43)
        Me.cmdSLogData.TabIndex = 0
        Me.cmdSLogData.Text = "Read SLogData"
        '
        'lblEnrollData
        '
        Me.lblEnrollData.AutoSize = True
        Me.lblEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.lblEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnrollData.Location = New System.Drawing.Point(16, 64)
        Me.lblEnrollData.Name = "lblEnrollData"
        Me.lblEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnrollData.Size = New System.Drawing.Size(76, 19)
        Me.lblEnrollData.TabIndex = 17
        Me.lblEnrollData.Text = "Log Data :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(126, 64)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(49, 19)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Total :"
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
        Me.lblMessage.Size = New System.Drawing.Size(644, 28)
        Me.lblMessage.TabIndex = 10
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gridLogView
        '
        Me.gridLogView.FullRowSelect = True
        Me.gridLogView.GridLines = True
        Me.gridLogView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.gridLogView.Location = New System.Drawing.Point(16, 88)
        Me.gridLogView.MultiSelect = False
        Me.gridLogView.Name = "gridLogView"
        Me.gridLogView.Size = New System.Drawing.Size(644, 328)
        Me.gridLogView.TabIndex = 19
        Me.gridLogView.View = System.Windows.Forms.View.Details
        '
        'cmdUsbSLog
        '
        Me.cmdUsbSLog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUsbSLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUsbSLog.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsbSLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUsbSLog.Location = New System.Drawing.Point(228, 424)
        Me.cmdUsbSLog.Name = "cmdUsbSLog"
        Me.cmdUsbSLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUsbSLog.Size = New System.Drawing.Size(106, 43)
        Me.cmdUsbSLog.TabIndex = 2
        Me.cmdUsbSLog.Text = "Read USB SLogData"
        '
        'cmdUsbGlog
        '
        Me.cmdUsbGlog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUsbGlog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUsbGlog.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsbGlog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUsbGlog.Location = New System.Drawing.Point(546, 424)
        Me.cmdUsbGlog.Name = "cmdUsbGlog"
        Me.cmdUsbGlog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUsbGlog.Size = New System.Drawing.Size(106, 43)
        Me.cmdUsbGlog.TabIndex = 5
        Me.cmdUsbGlog.Text = "Read USB GLogData"
        '
        'chkSave
        '
        Me.chkSave.BackColor = System.Drawing.SystemColors.Control
        Me.chkSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSave.Location = New System.Drawing.Point(448, 64)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSave.Size = New System.Drawing.Size(104, 19)
        Me.chkSave.TabIndex = 21
        Me.chkSave.Text = "Save to file"
        '
        'frmLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 480)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkSave, Me.cmdUsbGlog, Me.cmdUsbSLog, Me.gridLogView, Me.chkReadMark, Me.cmdEmptyGLogData, Me.cmdEmptySLogData, Me.cmdGlogData, Me.cmdSLogData, Me.lblEnrollData, Me.lblTotal, Me.lblMessage})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empty GLogData"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private fnCommHandleIndex As Long
    Private fnMachineNumber As Integer
    Const DEF_MAX_LOGCOUNT As Long = 200000     ' max log data count to support by device.
    Const DEF_MAX_DISPCOUNT As Long = 30000     ' max count to show on a grid.
    Const DEF_MUL_TWIPS As Short = 15

    Private fnGridHeight As Integer
    Private fngrdIndex As Integer
    Private fgrdLogView() As ListView

    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vnii As Integer
        Dim vngrdNumber As Integer

        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        chkReadMark.CheckState = CheckState.Checked
        chkSave.CheckState = CheckState.Unchecked
        fnGridHeight = gridLogView.Height
        vngrdNumber = DEF_MAX_LOGCOUNT / DEF_MAX_DISPCOUNT
        If vngrdNumber * DEF_MAX_DISPCOUNT < DEF_MAX_LOGCOUNT Then vngrdNumber = vngrdNumber + 1
        If vngrdNumber < 1 Then vngrdNumber = 1

        frmLog_Closed(sender, e)
        ReDim fgrdLogView(vngrdNumber)
        fgrdLogView(1) = gridLogView
        If vngrdNumber > 1 Then
            For vnii = 2 To vngrdNumber
                fgrdLogView(vnii) = New ListView()
                With fgrdLogView(vnii)
                    .Name = "gridListView" & vnii
                    .Left = gridLogView.Left
                    .Top = gridLogView.Top
                    .Width = gridLogView.Width
                    .Height = 0
                    .HeaderStyle = ColumnHeaderStyle.None
                    .View = gridLogView.View
                    .GridLines = gridLogView.GridLines
                    .Visible = False
                End With
                Controls.Add(fgrdLogView(vnii))
            Next
        End If
        OwnerEnableButtons(True)
    End Sub

    Private Sub frmLog_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim vtObject As ListView

        If IsNothing(fgrdLogView) Then Exit Sub
        If UBound(fgrdLogView) <= 0 Then Exit Sub
        For Each vtObject In fgrdLogView
            If Not IsNothing(vtObject) Then
                If vtObject.Name <> gridLogView.Name Then
                    Controls.Remove(vtObject)
                    vtObject.Dispose()
                    vtObject = Nothing
                End If
            End If
        Next vtObject
    End Sub

    Private Sub funcGetSuperLogData(Optional ByVal abUSBFlag As Boolean = False)
        Dim vSEnrollNumber As Integer
        Dim vGEnrollNumber As Integer
        Dim vManipulation As Integer
        Dim vBackupNumber As Integer
        Dim vdwDate As Date
        Dim vnii As Integer
        Dim vtObject As Object
        Dim vstrLogItem() As String
        Dim vstrFileName As String
        Dim vnReadMark As Integer
        Dim vnResultCode As Integer
        Dim vstrTmp As String
        Dim vtColumnHeader As ColumnHeader
        Dim vtItem As ListViewItem

        vstrFileName = ""
        vstrTmp = ""
        lblMessage.Text = "Waiting..."
        lblTotal.Text = "Total : 0"
        Application.DoEvents()

        vstrLogItem = New String() {"", "SEnrollNo", "GEnrollNo", "Manipulation", "BackupNo", "DateTime"}
        With fgrdLogView(1)
            .Height = fnGridHeight
            .Items.Clear()
            .Columns.Clear()
            For Each vstrTmp In vstrLogItem
                .Columns.Add(vstrTmp, 80, HorizontalAlignment.Center)
            Next vstrTmp
            .Columns(0).Width = 48
            .Columns(0).TextAlign = HorizontalAlignment.Right
            .Columns(3).Width = 140
            .Columns(3).TextAlign = HorizontalAlignment.Left
            .Columns(5).Width = 140
            Application.DoEvents()
        End With

        For vnii = 2 To UBound(fgrdLogView)
            If Not IsNothing(fgrdLogView(vnii)) Then
                With fgrdLogView(vnii)
                    .Visible = False
                    .Height = 0
                    .Items.Clear()
                    .Columns.Clear()
                    For Each vtColumnHeader In fgrdLogView(1).Columns
                        .Columns.Add("", vtColumnHeader.Width, vtColumnHeader.TextAlign)
                    Next vtColumnHeader
                End With
            End If
        Next vnii

        If abUSBFlag = True Then
            dlgOpen.InitialDirectory = GetCurrentDirectory()
            dlgOpen.Filter = "SLog Files (*.txt)|*.txt|All Files (*.*)|*.*"
            dlgOpen.FilterIndex = 1
            If dlgOpen.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
            vstrFileName = dlgOpen.FileName
            dlgOpen.FileName = CStr(Nothing)
            If vstrFileName = "" Then Exit Sub
        Else
            vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
            If vnResultCode <> RUN_SUCCESS Then
                lblMessage.Text = gstrNoDevice
                Exit Sub
            End If
        End If

        Cursor = Cursors.WaitCursor
        Application.DoEvents()
        If abUSBFlag = True Then
            vnResultCode = FK_USBLoadSuperLogDataFromFile(fnCommHandleIndex, vstrFileName)
        Else
            If chkReadMark.CheckState = CheckState.Checked Then
                vnReadMark = 1
            Else
                vnReadMark = 0
            End If
            vnResultCode = FK_LoadSuperLogData(fnCommHandleIndex, vnReadMark)
        End If

        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        Else
            lblMessage.Text = "Getting..."
            Application.DoEvents()
            vnii = 1
            Do
                vnResultCode = FK_GetSuperLogData(fnCommHandleIndex, vSEnrollNumber, vGEnrollNumber, vManipulation, vBackupNumber, vdwDate)
                If vnResultCode <> RUN_SUCCESS Then
                    If vnResultCode = RUNERR_DATAARRAY_END Then
                        vnResultCode = RUN_SUCCESS
                    End If
                    Exit Do
                End If
                vtItem = New ListViewItem()
                vtItem.Text = Trim(Str((vnii)))
                vtItem.SubItems.Add(Trim(Str(vSEnrollNumber)))
                vtItem.SubItems.Add(Trim(Str(vGEnrollNumber)))

                Select Case vManipulation
                    Case LOG_ENROLL_USER
                        vstrTmp = "Enroll User"
                    Case LOG_ENROLL_MANAGER
                        vstrTmp = "Enroll Manager"
                    Case LOG_ENROLL_DELFP
                        vstrTmp = "Delete Fp Data"
                    Case LOG_ENROLL_DELPASS
                        vstrTmp = "Delete Password"
                    Case LOG_ENROLL_DELCARD
                        vstrTmp = "Delete Card Data"
                    Case LOG_LOG_ALLDEL
                        vstrTmp = "Delete All LogData"
                    Case LOG_SETUP_SYS
                        vstrTmp = "Modify System Info"
                    Case LOG_SETUP_TIME
                        vstrTmp = "Modify System Time"
                    Case LOG_SETUP_LOG
                        vstrTmp = "Modify Log Setting"
                    Case LOG_SETUP_COMM
                        vstrTmp = "Modify Comm Setting"
                    Case LOG_PASSTIME
                        vstrTmp = "Pass Time Set"
                    Case LOG_SETUP_DOOR
                        vstrTmp = "Door Set Log"
                    Case Else
                        vstrTmp = "--"
                End Select
                vtItem.SubItems.Add(vstrTmp)

                If vBackupNumber = BACKUP_PSW Then
                    vstrTmp = "Password"
                ElseIf vBackupNumber = BACKUP_CARD Then
                    vstrTmp = "Card"
                ElseIf vBackupNumber < BACKUP_PSW Then
                    vstrTmp = "Fp-" & Trim(Str((vBackupNumber)))
                Else
                    vstrTmp = ""
                End If
                vtItem.SubItems.Add(vstrTmp)

                vstrTmp = Trim(Str(Year(vdwDate))) & "/" & Format(Month(vdwDate), "0#") & "/" & Format(Microsoft.VisualBasic.Day(vdwDate), "0#") _
                                    & " " & Format(Hour(vdwDate), "0#") & ":" & Format(Minute(vdwDate), "0#") & ":" & Format(Second(vdwDate), "0#")
                vtItem.SubItems.Add(vstrTmp)
                fgrdLogView(1).Items.Add(vtItem)
                vtItem = Nothing

                lblTotal.Text = "Total : " & vnii
                Application.DoEvents()
                vnii = vnii + 1
            Loop

            If vnResultCode = RUN_SUCCESS Then
                If abUSBFlag = True Then
                    lblMessage.Text = "USBReadSuperLogDataFromFile OK"
                Else
                    lblMessage.Text = "ReadAllSuperLogData OK"
                End If
            Else
                lblMessage.Text = ReturnResultPrint(vnResultCode)
            End If
        End If

        Cursor = Cursors.Default
        If abUSBFlag = False Then
            FK_EnableDevice(fnCommHandleIndex, 1)
        End If
    End Sub

    Private Sub cmdSLogData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSLogData.Click
        OwnerEnableButtons(False)
        funcGetSuperLogData()
        OwnerEnableButtons(True)
    End Sub

    Private Sub cmdUsbSLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsbSLog.Click
        OwnerEnableButtons(False)
        funcGetSuperLogData(True)
        OwnerEnableButtons(True)
    End Sub

    Private Sub cmdEmptySLogData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmptySLogData.Click
        Dim vnResultCode As Integer

        cmdEmptySLogData.Enabled = False
        lblMessage.Text = "Working..."
        System.Windows.Forms.Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdEmptySLogData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_EmptySuperLogData(fnCommHandleIndex)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdEmptySLogData.Enabled = True
    End Sub

    Private Sub funcGeneralLogDataGridFormat()
        Dim vnii As Integer
        Dim vstrLogItem() As String
        Dim vstrTmp As String
        Dim vtColumnHeader As ColumnHeader

        vstrLogItem = New String() {"", "EnrollNo", "VerifyMode", "InOutMode", "DateTime"}
        With fgrdLogView(1)
            .Height = fnGridHeight
            .Items.Clear()
            .Columns.Clear()
            For Each vstrTmp In vstrLogItem
                .Columns.Add(vstrTmp, 80, HorizontalAlignment.Center)
            Next vstrTmp
            .Columns(0).Width = 48
            .Columns(0).TextAlign = HorizontalAlignment.Right
            .Columns(2).Width = 120
            .Columns(4).Width = 140
            Application.DoEvents()
        End With

        For vnii = 2 To UBound(fgrdLogView)
            If Not IsNothing(fgrdLogView(vnii)) Then
                With fgrdLogView(vnii)
                    .Visible = False
                    .Left = fgrdLogView(1).Left
                    .Top = fgrdLogView(1).Top
                    .Width = fgrdLogView(1).Width
                    .Height = 0
                    .Items.Clear()
                    .Columns.Clear()
                    For Each vtColumnHeader In fgrdLogView(1).Columns
                        .Columns.Add("", vtColumnHeader.Width, vtColumnHeader.TextAlign)
                    Next vtColumnHeader
                End With
            End If
        Next vnii
        Application.DoEvents()
    End Sub

    Private Function funcShowGeneralLogDataToGrid(ByVal anCount As Integer, ByVal aSEnrollNumber As Integer, _
                    ByVal aVerifyMode As Integer, ByVal aInOutMode As Integer, ByVal adwDate As Date) As Boolean

        Dim vnkk As Integer
        Dim vnTop, vnAllHeight As Integer
        Dim vstrTmp As String
        Dim vtItem As ListViewItem

        funcShowGeneralLogDataToGrid = True
        If anCount <= 1 Then
            fngrdIndex = 1
        Else
            If fngrdIndex * DEF_MAX_DISPCOUNT < anCount Then
                fngrdIndex = fngrdIndex + 1
                If fngrdIndex > UBound(fgrdLogView) Then
                    funcShowGeneralLogDataToGrid = False
                    Exit Function
                End If
                vnAllHeight = fnGridHeight
                vnTop = fgrdLogView(1).Top
                For vnkk = 1 To fngrdIndex
                    fgrdLogView(vnkk).Top = vnTop + (vnkk - 1) * (vnAllHeight / fngrdIndex)
                    fgrdLogView(vnkk).Height = vnAllHeight / fngrdIndex
                Next vnkk
                fgrdLogView(fngrdIndex).Visible = True
            End If
        End If

        With fgrdLogView(fngrdIndex)
            vtItem = New ListViewItem()
            vtItem.Text = Trim(Str((anCount)))
            vtItem.SubItems.Add(Trim(Str(aSEnrollNumber)))

            Select Case aVerifyMode Mod LOG_OPEN_DOOR
                Case LOG_FPVERIFY           '1
                    vstrTmp = "Fp"
                Case LOG_PASSVERIFY         '2
                    vstrTmp = "Password"
                Case LOG_CARDVERIFY         '3
                    vstrTmp = "Card"
                Case LOG_FPPASS_VERIFY      '4
                    vstrTmp = "Fp+Password"
                Case LOG_FPCARD_VERIFY      '5
                    vstrTmp = "Fp+Card"
                Case LOG_PASSFP_VERIFY      '6
                    vstrTmp = "Password+Fp"
                Case LOG_CARDFP_VERIFY      '7
                    vstrTmp = "Card+Fp"
                Case LOG_JOB_NO_VERIFY      '8
                    vstrTmp = "Job No"
                Case LOG_CARDPASS_VERIFY    '9
                    vstrTmp = "Card+Pass"
                Case LOG_CLOSE_DOOR         '10
                    vstrTmp = "Close Door"
                Case LOG_OPEN_HAND          '11
                    vstrTmp = "Hand Open"
                Case LOG_PROG_OPEN          '12
                    vstrTmp = "Prog Open"
                Case LOG_PROG_CLOSE         '13
                    vstrTmp = "PC Close"
                Case LOG_OPEN_IREGAL        '14
                    vstrTmp = "Iregal Open"
                Case LOG_CLOSE_IREGAL       '15
                    vstrTmp = "Iregal Close"
                Case LOG_OPEN_COVER         '16
                    vstrTmp = "Cover Open"
                Case LOG_CLOSE_COVER        '17
                    vstrTmp = "Cover Close"
                Case Else
                    vstrTmp = "--"
            End Select
            If aVerifyMode \ LOG_OPEN_THREAT = 1 Then
                vstrTmp = vstrTmp + " & Open Door as Threat"
            ElseIf aVerifyMode \ LOG_OPEN_DOOR = 1 Then
                vstrTmp = vstrTmp + " & Open Door"
            Else
                vstrTmp = vstrTmp
            End If
            vtItem.SubItems.Add(vstrTmp)

            Select Case aInOutMode
                Case LOG_IOMODE_IN
                    vstrTmp = "IN"
                Case LOG_IOMODE_OUT
                    vstrTmp = "OUT"
                Case LOG_IOMODE_OVER_IN
                    vstrTmp = "Over IN"
                Case LOG_IOMODE_OVER_OUT
                    vstrTmp = "Over OUT"
                Case Else
                    vstrTmp = "--"
            End Select
            vtItem.SubItems.Add(vstrTmp)

            vstrTmp = Trim(Str(Year(adwDate))) & "/" & Format(Month(adwDate), "0#") & "/" & Format(Microsoft.VisualBasic.Day(adwDate), "0#") & _
                                " " & Format(Hour(adwDate), "0#") & ":" & Format(Minute(adwDate), "0#") & ":" & Format(Second(adwDate), "0#")
            vtItem.SubItems.Add(vstrTmp)
            .Items.Add(vtItem)
            vtItem = Nothing
            lblTotal.Text = "Total : " & anCount
        End With
        Application.DoEvents()
    End Function

    Private Sub funcGetGeneralLogData(Optional ByVal abUSBFlag As Boolean = False)
        Dim vSEnrollNumber As Integer
        Dim vVerifyMode As Integer
        Dim vInOutMode As Integer
        Dim vdwDate As Date
        Dim vnCount As Integer
        Dim vnResultCode As Long ' Update 2008/12/18 by CCH
        Dim vstrFileName As String
        Dim vdBeginDate As Date
        Dim vdEndDate As Date
        Dim vstrTmp As String
        Dim vnFileNum As Integer
        Dim vstrFileData As String
        Dim vnReadMark As Integer

        vstrFileName = ""
        lblMessage.Text = "Waiting..."
        lblTotal.Text = "Total : 0"
        Application.DoEvents()
        funcGeneralLogDataGridFormat()

        If abUSBFlag = True Then
            dlgOpen.InitialDirectory = GetCurrentDirectory()
            dlgOpen.Filter = "GLog Files (*.txt)|*.txt|All Files (*.*)|*.*"
            dlgOpen.FilterIndex = 1
            If dlgOpen.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
            vstrFileName = dlgOpen.FileName
            dlgOpen.FileName = CStr(Nothing)
        Else
            vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
            If vnResultCode = False Then
                lblMessage.Text = gstrNoDevice
                Exit Sub
            End If
        End If

        Cursor = Cursors.WaitCursor
        Application.DoEvents()
        If abUSBFlag = True Then
            vnResultCode = FK_USBLoadGeneralLogDataFromFile(fnCommHandleIndex, vstrFileName)
        Else
            If chkReadMark.CheckState = System.Windows.Forms.CheckState.Checked Then
                vnReadMark = 1
            Else
                vnReadMark = 0
            End If

            'open file for save
            If chkSave.CheckState = CheckState.Checked Then
                vnFileNum = FreeFile()
                If vnReadMark = 0 Then
                    vstrFileName = GetCurrentDirectory() & "\AllLog.txt"
                Else
                    vstrFileName = GetCurrentDirectory() & "\Log.txt"
                End If
                If Dir(vstrFileName) <> "" Then Kill(vstrFileName)
                vstrFileData = "No." & vbTab & "EnrNo" & vbTab & "Verify" & vbTab & "InOut" & vbTab & "DateTime" + vbCrLf
                FileOpen(vnFileNum, vstrFileName, OpenMode.Binary)
                FilePut(vnFileNum, vstrFileData)
            End If

            vnResultCode = FK_LoadGeneralLogData(fnCommHandleIndex, vnReadMark)
        End If

        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        Else
            lblMessage.Text = "Getting..."
            Application.DoEvents()

            vnCount = 1
            Do
                vnResultCode = FK_GetGeneralLogData(fnCommHandleIndex, vSEnrollNumber, vVerifyMode, vInOutMode, vdwDate)
                If vnResultCode <> RUN_SUCCESS Then
                    If vnResultCode = RUNERR_DATAARRAY_END Then
                        vnResultCode = RUN_SUCCESS
                    End If
                    Exit Do
                End If
                If abUSBFlag = False And chkSave.CheckState = CheckState.Checked Then
                    vstrFileData = funcMakeGeneralLogFileData(vnCount, vSEnrollNumber, _
                                            vVerifyMode, vInOutMode, vdwDate)
                    FilePut(vnFileNum, vstrFileData)
                End If
                vnResultCode = funcShowGeneralLogDataToGrid(vnCount, vSEnrollNumber, vVerifyMode, vInOutMode, vdwDate)
                If vnResultCode = 0 Then Exit Do
                vnCount = vnCount + 1
            Loop

            If abUSBFlag = False And chkSave.CheckState = CheckState.Checked Then
                FileClose(vnFileNum)
            End If

            If vnResultCode = RUN_SUCCESS Then
                If abUSBFlag = True Then
                    lblMessage.Text = "USBReadGeneralLogDataFromFile OK"
                Else
                    lblMessage.Text = "ReadGeneralLogData OK"
                End If
            Else
                lblMessage.Text = ReturnResultPrint(vnResultCode)
            End If
        End If

        Cursor = Cursors.Default
        If abUSBFlag = False Then
            FK_EnableDevice(fnCommHandleIndex, 1)
        End If
    End Sub

    Private Sub cmdGlogData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGlogData.Click
        OwnerEnableButtons(False)
        funcGetGeneralLogData()
        OwnerEnableButtons(True)
    End Sub

    Private Sub cmdUsbGlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsbGlog.Click
        OwnerEnableButtons(False)
        funcGetGeneralLogData(True)
        OwnerEnableButtons(True)
    End Sub

    Private Sub cmdEmptyGLogData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmptyGLogData.Click
        Dim vnResultCode As Integer

        cmdEmptyGLogData.Enabled = False
        lblMessage.Text = "Working..."
        System.Windows.Forms.Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdEmptyGLogData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_EmptyGeneralLogData(fnCommHandleIndex)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdEmptyGLogData.Enabled = True
    End Sub

    Private Sub OwnerEnableButtons(ByRef abEnableFlag As Boolean)
        Dim vbFrmOpenFlag As Boolean

        vbFrmOpenFlag = gfrmMain.gbOpenFlag
        cmdSLogData.Enabled = vbFrmOpenFlag And abEnableFlag
        cmdEmptySLogData.Enabled = vbFrmOpenFlag And abEnableFlag
        cmdUsbSLog.Enabled = abEnableFlag
        cmdGlogData.Enabled = vbFrmOpenFlag And abEnableFlag
        cmdEmptyGLogData.Enabled = vbFrmOpenFlag And abEnableFlag
        cmdUsbGlog.Enabled = abEnableFlag
        Application.DoEvents()
    End Sub

    Private Function funcMakeGeneralLogFileData(ByVal anCount As Long, ByVal aSEnrollNumber As Long, _
    ByVal aVerifyMode As Long, ByVal aInOutMode As Long, ByVal adwDate As Date) As String
        Dim vstrData As String
        Dim vstrDTime As String

        vstrData = CStr(anCount) & vbTab & CStr(aSEnrollNumber) & vbTab & CStr(aVerifyMode) & vbTab & CStr(aInOutMode) & vbTab

        vstrDTime = Trim(Str(Year(adwDate))) & "/" & Format(Month(adwDate), "0#") & "/" & Format(Microsoft.VisualBasic.Day(adwDate), "0#") & _
                            " " & Format(Hour(adwDate), "0#") & ":" & Format(Minute(adwDate), "0#") & ":" & Format(Second(adwDate), "0#")
        funcMakeGeneralLogFileData = vstrData & vstrDTime & vbCrLf
    End Function
End Class
