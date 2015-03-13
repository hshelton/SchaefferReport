Option Strict Off
Option Explicit On 
Imports System.IO.Directory

Public Class frmEnroll
    Inherits System.Windows.Forms.Form
    Const DATASIZE = (459 * 4 * 4 + 10)

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
    Public WithEvents txtEnrollNumber As System.Windows.Forms.TextBox
    Public WithEvents cmdGetEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdDisableUser As System.Windows.Forms.Button
    Public WithEvents cmbBackupNumber As System.Windows.Forms.ComboBox
    Public WithEvents cmbPrivilege As System.Windows.Forms.ComboBox
    Public WithEvents cmdDel As System.Windows.Forms.Button
    Public WithEvents cmdClearData As System.Windows.Forms.Button
    Public WithEvents cmdSetEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdDeleteEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdModifyPrivilege As System.Windows.Forms.Button
    Public WithEvents cmdEnableUser As System.Windows.Forms.Button
    Public WithEvents cmdSetAllEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdGetAllEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdGetEnrollInfo As System.Windows.Forms.Button
    Public WithEvents lstEnrollData As System.Windows.Forms.ListBox
    Public WithEvents lblEnrollNum As System.Windows.Forms.Label
    Public WithEvents lblTotal As System.Windows.Forms.Label
    Public WithEvents lblPrivilege As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    Public WithEvents lblEnrollData As System.Windows.Forms.Label
    Public WithEvents lblBackupNumber As System.Windows.Forms.Label
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblDBCount As System.Windows.Forms.Label
    Friend WithEvents scbAdoScroll As System.Windows.Forms.HScrollBar
    Public WithEvents cmdUSBGetAllData As System.Windows.Forms.Button
    Public WithEvents cmdUSBSetAllData As System.Windows.Forms.Button
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents cmdEmptyEnrollData As System.Windows.Forms.Button
    Public WithEvents cmdBenumbManager As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtEnrollNumber = New System.Windows.Forms.TextBox()
        Me.cmdGetEnrollData = New System.Windows.Forms.Button()
        Me.cmdEmptyEnrollData = New System.Windows.Forms.Button()
        Me.cmdDisableUser = New System.Windows.Forms.Button()
        Me.cmbBackupNumber = New System.Windows.Forms.ComboBox()
        Me.cmbPrivilege = New System.Windows.Forms.ComboBox()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdClearData = New System.Windows.Forms.Button()
        Me.cmdSetEnrollData = New System.Windows.Forms.Button()
        Me.cmdDeleteEnrollData = New System.Windows.Forms.Button()
        Me.cmdModifyPrivilege = New System.Windows.Forms.Button()
        Me.cmdEnableUser = New System.Windows.Forms.Button()
        Me.cmdSetAllEnrollData = New System.Windows.Forms.Button()
        Me.cmdGetAllEnrollData = New System.Windows.Forms.Button()
        Me.cmdGetEnrollInfo = New System.Windows.Forms.Button()
        Me.lstEnrollData = New System.Windows.Forms.ListBox()
        Me.lblEnrollNum = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrivilege = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblEnrollData = New System.Windows.Forms.Label()
        Me.lblBackupNumber = New System.Windows.Forms.Label()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.lblDBCount = New System.Windows.Forms.Label()
        Me.scbAdoScroll = New System.Windows.Forms.HScrollBar()
        Me.cmdUSBGetAllData = New System.Windows.Forms.Button()
        Me.cmdUSBSetAllData = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmdBenumbManager = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEnrollNumber
        '
        Me.txtEnrollNumber.AcceptsReturn = True
        Me.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnrollNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnrollNumber.Location = New System.Drawing.Point(152, 80)
        Me.txtEnrollNumber.MaxLength = 8
        Me.txtEnrollNumber.Name = "txtEnrollNumber"
        Me.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnrollNumber.Size = New System.Drawing.Size(81, 26)
        Me.txtEnrollNumber.TabIndex = 14
        Me.txtEnrollNumber.Text = ""
        '
        'cmdGetEnrollData
        '
        Me.cmdGetEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetEnrollData.Location = New System.Drawing.Point(256, 80)
        Me.cmdGetEnrollData.Name = "cmdGetEnrollData"
        Me.cmdGetEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetEnrollData.Size = New System.Drawing.Size(216, 36)
        Me.cmdGetEnrollData.TabIndex = 1
        Me.cmdGetEnrollData.Text = "Get Enroll Data"
        '
        'cmdEmptyEnrollData
        '
        Me.cmdEmptyEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmptyEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmptyEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmptyEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmptyEnrollData.Location = New System.Drawing.Point(256, 512)
        Me.cmdEmptyEnrollData.Name = "cmdEmptyEnrollData"
        Me.cmdEmptyEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmptyEnrollData.Size = New System.Drawing.Size(216, 36)
        Me.cmdEmptyEnrollData.TabIndex = 12
        Me.cmdEmptyEnrollData.Text = "Empty Enroll Data"
        '
        'cmdDisableUser
        '
        Me.cmdDisableUser.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDisableUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDisableUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisableUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDisableUser.Location = New System.Drawing.Point(364, 404)
        Me.cmdDisableUser.Name = "cmdDisableUser"
        Me.cmdDisableUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDisableUser.Size = New System.Drawing.Size(108, 36)
        Me.cmdDisableUser.TabIndex = 10
        Me.cmdDisableUser.Text = "Disable User"
        '
        'cmbBackupNumber
        '
        Me.cmbBackupNumber.BackColor = System.Drawing.SystemColors.Window
        Me.cmbBackupNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBackupNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBackupNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBackupNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBackupNumber.Location = New System.Drawing.Point(152, 120)
        Me.cmbBackupNumber.Name = "cmbBackupNumber"
        Me.cmbBackupNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbBackupNumber.Size = New System.Drawing.Size(81, 27)
        Me.cmbBackupNumber.TabIndex = 44
        '
        'cmbPrivilege
        '
        Me.cmbPrivilege.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPrivilege.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrivilege.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrivilege.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPrivilege.Location = New System.Drawing.Point(152, 152)
        Me.cmbPrivilege.Name = "cmbPrivilege"
        Me.cmbPrivilege.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPrivilege.Size = New System.Drawing.Size(81, 27)
        Me.cmbPrivilege.TabIndex = 43
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDel.Location = New System.Drawing.Point(376, 48)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDel.Size = New System.Drawing.Size(96, 30)
        Me.cmdDel.TabIndex = 0
        Me.cmdDel.Text = "Delete DB"
        '
        'cmdClearData
        '
        Me.cmdClearData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearData.Location = New System.Drawing.Point(256, 548)
        Me.cmdClearData.Name = "cmdClearData"
        Me.cmdClearData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearData.Size = New System.Drawing.Size(216, 36)
        Me.cmdClearData.TabIndex = 13
        Me.cmdClearData.Text = "Clear All Data(E,GL,SL) "
        '
        'cmdSetEnrollData
        '
        Me.cmdSetEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetEnrollData.Location = New System.Drawing.Point(256, 116)
        Me.cmdSetEnrollData.Name = "cmdSetEnrollData"
        Me.cmdSetEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetEnrollData.Size = New System.Drawing.Size(216, 36)
        Me.cmdSetEnrollData.TabIndex = 2
        Me.cmdSetEnrollData.Text = "Set Enroll Data"
        '
        'cmdDeleteEnrollData
        '
        Me.cmdDeleteEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteEnrollData.Location = New System.Drawing.Point(256, 152)
        Me.cmdDeleteEnrollData.Name = "cmdDeleteEnrollData"
        Me.cmdDeleteEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteEnrollData.Size = New System.Drawing.Size(216, 36)
        Me.cmdDeleteEnrollData.TabIndex = 3
        Me.cmdDeleteEnrollData.Text = "Delete Enroll Data"
        '
        'cmdModifyPrivilege
        '
        Me.cmdModifyPrivilege.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModifyPrivilege.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModifyPrivilege.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifyPrivilege.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModifyPrivilege.Location = New System.Drawing.Point(256, 440)
        Me.cmdModifyPrivilege.Name = "cmdModifyPrivilege"
        Me.cmdModifyPrivilege.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModifyPrivilege.Size = New System.Drawing.Size(216, 36)
        Me.cmdModifyPrivilege.TabIndex = 11
        Me.cmdModifyPrivilege.Text = "ModifyPrivilege"
        '
        'cmdEnableUser
        '
        Me.cmdEnableUser.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnableUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnableUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnableUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnableUser.Location = New System.Drawing.Point(256, 404)
        Me.cmdEnableUser.Name = "cmdEnableUser"
        Me.cmdEnableUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnableUser.Size = New System.Drawing.Size(108, 36)
        Me.cmdEnableUser.TabIndex = 9
        Me.cmdEnableUser.Text = "Enable User"
        '
        'cmdSetAllEnrollData
        '
        Me.cmdSetAllEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetAllEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetAllEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetAllEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetAllEnrollData.Location = New System.Drawing.Point(256, 236)
        Me.cmdSetAllEnrollData.Name = "cmdSetAllEnrollData"
        Me.cmdSetAllEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetAllEnrollData.Size = New System.Drawing.Size(216, 36)
        Me.cmdSetAllEnrollData.TabIndex = 5
        Me.cmdSetAllEnrollData.Text = "Set All Enroll Data"
        '
        'cmdGetAllEnrollData
        '
        Me.cmdGetAllEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetAllEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetAllEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetAllEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetAllEnrollData.Location = New System.Drawing.Point(256, 200)
        Me.cmdGetAllEnrollData.Name = "cmdGetAllEnrollData"
        Me.cmdGetAllEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetAllEnrollData.Size = New System.Drawing.Size(216, 36)
        Me.cmdGetAllEnrollData.TabIndex = 4
        Me.cmdGetAllEnrollData.Text = "Get All Enroll Data"
        '
        'cmdGetEnrollInfo
        '
        Me.cmdGetEnrollInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetEnrollInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetEnrollInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetEnrollInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetEnrollInfo.Location = New System.Drawing.Point(256, 368)
        Me.cmdGetEnrollInfo.Name = "cmdGetEnrollInfo"
        Me.cmdGetEnrollInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetEnrollInfo.Size = New System.Drawing.Size(216, 36)
        Me.cmdGetEnrollInfo.TabIndex = 8
        Me.cmdGetEnrollInfo.Text = "Get Enroll Info"
        '
        'lstEnrollData
        '
        Me.lstEnrollData.BackColor = System.Drawing.SystemColors.Window
        Me.lstEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstEnrollData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEnrollData.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstEnrollData.Location = New System.Drawing.Point(16, 226)
        Me.lstEnrollData.Name = "lstEnrollData"
        Me.lstEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstEnrollData.Size = New System.Drawing.Size(220, 355)
        Me.lstEnrollData.TabIndex = 28
        '
        'lblEnrollNum
        '
        Me.lblEnrollNum.AutoSize = True
        Me.lblEnrollNum.BackColor = System.Drawing.SystemColors.Control
        Me.lblEnrollNum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnrollNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnrollNum.Location = New System.Drawing.Point(16, 88)
        Me.lblEnrollNum.Name = "lblEnrollNum"
        Me.lblEnrollNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnrollNum.Size = New System.Drawing.Size(114, 19)
        Me.lblEnrollNum.TabIndex = 52
        Me.lblEnrollNum.Text = "Enroll Number :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(144, 198)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(53, 19)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = "Total : "
        '
        'lblPrivilege
        '
        Me.lblPrivilege.AutoSize = True
        Me.lblPrivilege.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrivilege.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrivilege.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrivilege.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrivilege.Location = New System.Drawing.Point(16, 160)
        Me.lblPrivilege.Name = "lblPrivilege"
        Me.lblPrivilege.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrivilege.Size = New System.Drawing.Size(74, 19)
        Me.lblPrivilege.TabIndex = 31
        Me.lblPrivilege.Text = "Privilege :"
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
        Me.lblMessage.Size = New System.Drawing.Size(456, 29)
        Me.lblMessage.TabIndex = 30
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEnrollData
        '
        Me.lblEnrollData.AutoSize = True
        Me.lblEnrollData.BackColor = System.Drawing.SystemColors.Control
        Me.lblEnrollData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnrollData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnrollData.Location = New System.Drawing.Point(16, 198)
        Me.lblEnrollData.Name = "lblEnrollData"
        Me.lblEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnrollData.Size = New System.Drawing.Size(106, 19)
        Me.lblEnrollData.TabIndex = 29
        Me.lblEnrollData.Text = "Enrolled Data :"
        '
        'lblBackupNumber
        '
        Me.lblBackupNumber.AutoSize = True
        Me.lblBackupNumber.BackColor = System.Drawing.SystemColors.Control
        Me.lblBackupNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBackupNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackupNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBackupNumber.Location = New System.Drawing.Point(16, 120)
        Me.lblBackupNumber.Name = "lblBackupNumber"
        Me.lblBackupNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBackupNumber.Size = New System.Drawing.Size(123, 19)
        Me.lblBackupNumber.TabIndex = 27
        Me.lblBackupNumber.Text = "Backup Number :"
        '
        'lblDBCount
        '
        Me.lblDBCount.BackColor = System.Drawing.Color.White
        Me.lblDBCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDBCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBCount.ForeColor = System.Drawing.Color.Blue
        Me.lblDBCount.Location = New System.Drawing.Point(272, 49)
        Me.lblDBCount.Name = "lblDBCount"
        Me.lblDBCount.Size = New System.Drawing.Size(85, 28)
        Me.lblDBCount.TabIndex = 54
        Me.lblDBCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scbAdoScroll
        '
        Me.scbAdoScroll.LargeChange = 2
        Me.scbAdoScroll.Location = New System.Drawing.Point(256, 48)
        Me.scbAdoScroll.Maximum = 1
        Me.scbAdoScroll.Name = "scbAdoScroll"
        Me.scbAdoScroll.Size = New System.Drawing.Size(120, 30)
        Me.scbAdoScroll.TabIndex = 55
        '
        'cmdUSBGetAllData
        '
        Me.cmdUSBGetAllData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUSBGetAllData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUSBGetAllData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUSBGetAllData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUSBGetAllData.Location = New System.Drawing.Point(256, 288)
        Me.cmdUSBGetAllData.Name = "cmdUSBGetAllData"
        Me.cmdUSBGetAllData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUSBGetAllData.Size = New System.Drawing.Size(216, 36)
        Me.cmdUSBGetAllData.TabIndex = 6
        Me.cmdUSBGetAllData.Text = "Get All Enroll Data(USB)"
        '
        'cmdUSBSetAllData
        '
        Me.cmdUSBSetAllData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUSBSetAllData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUSBSetAllData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUSBSetAllData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUSBSetAllData.Location = New System.Drawing.Point(256, 324)
        Me.cmdUSBSetAllData.Name = "cmdUSBSetAllData"
        Me.cmdUSBSetAllData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUSBSetAllData.Size = New System.Drawing.Size(216, 36)
        Me.cmdUSBSetAllData.TabIndex = 7
        Me.cmdUSBSetAllData.Text = "Set All Enroll Data(USB)"
        '
        'cmdBenumbManager
        '
        Me.cmdBenumbManager.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBenumbManager.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBenumbManager.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBenumbManager.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBenumbManager.Location = New System.Drawing.Point(256, 476)
        Me.cmdBenumbManager.Name = "cmdBenumbManager"
        Me.cmdBenumbManager.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBenumbManager.Size = New System.Drawing.Size(216, 36)
        Me.cmdBenumbManager.TabIndex = 57
        Me.cmdBenumbManager.Text = "Benumb All Managers"
        '
        'frmEnroll
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 600)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdBenumbManager, Me.cmdUSBSetAllData, Me.cmdUSBGetAllData, Me.lblDBCount, Me.txtEnrollNumber, Me.cmdGetEnrollData, Me.cmdEmptyEnrollData, Me.cmdDisableUser, Me.cmbBackupNumber, Me.cmbPrivilege, Me.cmdDel, Me.cmdClearData, Me.cmdSetEnrollData, Me.cmdDeleteEnrollData, Me.cmdModifyPrivilege, Me.cmdEnableUser, Me.cmdSetAllEnrollData, Me.cmdGetAllEnrollData, Me.cmdGetEnrollInfo, Me.lstEnrollData, Me.lblEnrollNum, Me.lblTotal, Me.lblPrivilege, Me.lblEnrollData, Me.lblBackupNumber, Me.lblMessage, Me.scbAdoScroll})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEnroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Enroll Data"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private fnCommHandleIndex As Long
    Private fbGetState As Boolean
    Private fstrEnrollData As String
    Private fadoEnrollCnnt As New ADODB.Connection()
    Private fadoEnrollRST As New ADODB.Recordset()
    Private fadoTmpRST As New ADODB.Recordset()
    Private ftBackupNumber() As Object
    Private Const fcstrCnn40 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source="

    Private Sub frmEnroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vstrDBPath As String
        Dim vnii As Integer

        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
        fbGetState = False
        ftBackupNumber = New Object() {BACKUP_FP_0, "Fp-0", _
                            BACKUP_FP_1, "Fp-1", _
                            BACKUP_FP_2, "Fp-2", _
                            BACKUP_FP_3, "Fp-3", _
                            BACKUP_FP_4, "Fp-4", _
                            BACKUP_FP_5, "Fp-5", _
                            BACKUP_FP_6, "Fp-6", _
                            BACKUP_FP_7, "Fp-7", _
                            BACKUP_FP_8, "Fp-8", _
                            BACKUP_FP_9, "Fp-9", _
                            BACKUP_PSW, "Pass", _
                            BACKUP_CARD, "Card"}

        lblMessage.Text = ""
        txtEnrollNumber.Text = "1"
        cmbBackupNumber.Items.Clear()
        For vnii = 1 To UBound(ftBackupNumber) Step 2
            cmbBackupNumber.Items.Add(ftBackupNumber(vnii))
        Next vnii
        cmbBackupNumber.SelectedIndex = 0
        cmbPrivilege.Items.Clear()
        cmbPrivilege.Items.Add("User")
        cmbPrivilege.Items.Add("Manager")
        cmbPrivilege.SelectedIndex = 0
        lstEnrollData.Items.Clear()

        fstrEnrollData = ""

        On Error GoTo lp_end
        DBWithItemEnable(False)

        vstrDBPath = GetCurrentDirectory() & "\datEnrollDatNet.mdb"
        If Dir(vstrDBPath) = "" Then
            dlgOpen.InitialDirectory = GetCurrentDirectory()
            dlgOpen.Filter = "DB Files (*.mdb)|*.mdb|All Files (*.*)|*.*"
            dlgOpen.FilterIndex = 1
            If dlgOpen.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                GoTo lp_end
            End If
            vstrDBPath = dlgOpen.FileName
            dlgOpen.FileName = CStr(Nothing)
        End If

        frmEnroll_Closed(sender, e)
        With fadoEnrollCnnt
            .CommandTimeout = 300
            .ConnectionTimeout = 300                            ' Set the time out.
            .ConnectionString = fcstrCnn40 & vstrDBPath
            .Open()
            If .State <> ADODB.ObjectStateEnum.adStateOpen Then GoTo lp_end
        End With

        With fadoEnrollRST
            .CacheSize = 1000
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open("select * from tblEnroll", fadoEnrollCnnt, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            If .State = ADODB.ObjectStateEnum.adStateOpen Then
                If Not .BOF Then .MoveFirst()
            End If
            AdoEnroll_MoveComplete()
        End With
        With fadoTmpRST
            .CacheSize = 1000
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        End With

        DBWithItemEnable(True)
lp_end:
        If gfrmMain.gbOpenFlag = False Then
            DisableButtons()
        End If
    End Sub

    Private Sub frmEnroll_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If fadoEnrollRST.State = ADODB.ObjectStateEnum.adStateOpen Then
            fadoEnrollRST.Close()
        End If
        If fadoEnrollCnnt.State = ADODB.ObjectStateEnum.adStateOpen Then
            fadoEnrollCnnt.Close()
        End If
    End Sub

    Private Sub scbAdoScroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scbAdoScroll.Scroll
        With fadoEnrollRST
            If .RecordCount > 0 Then
                Select Case e.Type
                    Case ScrollEventType.SmallDecrement
                        If Not .BOF Then
                            .MovePrevious()
                            If .BOF Then .MoveFirst()
                        End If
                    Case ScrollEventType.SmallIncrement
                        If Not .EOF Then
                            .MoveNext()
                            If .EOF Then .MoveLast()
                        End If
                    Case Else
                        Exit Sub
                End Select
            End If
        End With
        AdoEnroll_MoveComplete()
    End Sub

    Private Sub AdoEnroll_MoveComplete()
        Dim vnPos As Integer
        Dim vEnrollNumber As Integer
        Dim vEnrollName As String
        Dim vBackupNumber As Integer
        Dim vPrivilege As Integer

        If fbGetState = True Then Exit Sub
        With fadoEnrollRST
            vnPos = CInt(.AbsolutePosition)
            If vnPos < 0 Then vnPos = 0
            lblDBCount.Text = "  " & vnPos & "/" & .RecordCount
            If .RecordCount > 0 Then FuncReadFromToDB(vEnrollNumber, vBackupNumber, vPrivilege, vEnrollName)
        End With
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        cmdDel.Enabled = False
        Application.DoEvents()
        With fadoTmpRST
            If .State = ADODB.ObjectStateEnum.adStateOpen Then .Close()
            fadoTmpRST.Open("Delete From tblEnroll", fadoEnrollCnnt, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        End With
        fadoEnrollRST.Requery()
        AdoEnroll_MoveComplete()
        cmdDel.Enabled = True
    End Sub

    Private Sub cmdGetEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetEnrollData.Click
        Dim vEnrollNumber As Integer
        Dim vBackupNumber As Integer
        Dim vPrivilege As Integer
        Dim vnResultCode As Integer

        cmdGetEnrollData.Enabled = False
        lstEnrollData.Items.Clear()
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetEnrollData.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vBackupNumber = FuncGetBackupNumberFromItem()

        fstrEnrollData = Space(DATASIZE)
        vnResultCode = FK_GetEnrollDataWithString(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, fstrEnrollData)
        If vnResultCode = RUN_SUCCESS Then
            If vPrivilege = MP_ALL Then
                cmbPrivilege.SelectedIndex = 1
            Else
                cmbPrivilege.SelectedIndex = 0
            End If
            FuncDispToListBox(vBackupNumber)
            lblMessage.Text = "GetEnrollData OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetEnrollData.Enabled = True
    End Sub

    Private Sub cmdSetEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetEnrollData.Click
        Dim vEnrollNumber As Integer
        Dim vBackupNumber As Integer
        Dim vPrivilege As Integer
        Dim vnResultCode As Integer

        cmdSetEnrollData.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vBackupNumber = FuncGetBackupNumberFromItem()
        If cmbPrivilege.SelectedIndex = 1 Then
            vPrivilege = MP_ALL
        Else
            vPrivilege = MP_NONE
        End If

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetEnrollData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_PutEnrollDataWithString(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, fstrEnrollData)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Saving..."
            Application.DoEvents()
            vnResultCode = FK_SaveEnrollData(fnCommHandleIndex)
            If vnResultCode = RUN_SUCCESS Then
                lblMessage.Text = "SetEnrollData OK"
            End If
        End If

        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetEnrollData.Enabled = True
    End Sub

    Private Sub cmdDeleteEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteEnrollData.Click
        Dim vEnrollNumber As Integer
        Dim vBackupNumber As Integer
        Dim vnResultCode As Integer

        cmdDeleteEnrollData.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdDeleteEnrollData.Enabled = True
            Exit Sub
        End If

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vBackupNumber = FuncGetBackupNumberFromItem()
        vnResultCode = FK_DeleteEnrollData(fnCommHandleIndex, vEnrollNumber, vBackupNumber)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "DeleteEnrollData OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdDeleteEnrollData.Enabled = True
    End Sub

    Private Sub cmdGetAllEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetAllEnrollData.Click
        Dim vEnrollNumber As Integer
        Dim vEnrollName As String
        Dim vBackupNumber As Integer
        Dim vPrivilege As Integer
        Dim vnEnableFlag As Integer
        Dim vnMessRet As Integer
        Dim vTitle As String
        Dim vnResultCode As Integer

        cmdGetAllEnrollData.Enabled = False
        lstEnrollData.Items.Clear()
        vTitle = Me.Text
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetAllEnrollData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_ReadAllUserID(fnCommHandleIndex)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(vnResultCode)
            FK_EnableDevice(fnCommHandleIndex, 1)
            cmdGetAllEnrollData.Enabled = True
            Exit Sub
        End If

        '---- Get Enroll data and save into database -------------
        Cursor = Cursors.WaitCursor
        With fadoEnrollRST
            fbGetState = True
            Do
FFF:
                vnResultCode = FK_GetAllUserID(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, vnEnableFlag)
                If vnResultCode <> RUN_SUCCESS Then
                    If vnResultCode = RUNERR_DATAARRAY_END Then
                        vnResultCode = RUN_SUCCESS
                    End If
                    Exit Do
                End If
EEE:
                fstrEnrollData = Space(DATASIZE)
                vnResultCode = FK_GetEnrollDataWithString(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, fstrEnrollData)

                If vnResultCode <> RUN_SUCCESS Then
                    vnMessRet = MsgBox(ReturnResultPrint(vnResultCode) & ": Continue ?", MsgBoxStyle.YesNoCancel, "GetEnrollData")
                    If vnMessRet = MsgBoxResult.Yes Then
                        GoTo EEE
                    ElseIf vnMessRet = MsgBoxResult.Cancel Then
                        Exit Do
                    Else
                        GoTo FFF
                    End If
                End If

                FuncSaveToDB(vEnrollNumber, vBackupNumber, vPrivilege, vEnrollName)
                Me.Text = Format(vEnrollNumber, "0000#")
                Application.DoEvents()
            Loop
            fbGetState = False
            Application.DoEvents()
            If .RecordCount > 1 Then
                .MoveFirst()
                .MoveLast()
            End If
        End With
        Me.Text = vTitle
        Cursor = Cursors.Default

        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "GetAllEnrollData OK"
        Else
            lblMessage.Text = "GetAllEnrollData Error : " & ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetAllEnrollData.Enabled = True
    End Sub

    Private Sub cmdSetAllEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetAllEnrollData.Click
        Dim vEnrollNumber As Integer
        Dim vEnrollName As String
        Dim vBackupNumber As Integer
        Dim vPrivilege As Integer
        Dim vnMessRet As Integer
        Dim vStr As String
        Dim vTitle As String
        Dim vnResultCode As Integer
        Dim vbRet As Boolean

        cmdSetAllEnrollData.Enabled = False
        lstEnrollData.Items.Clear()
        vTitle = Me.Text
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdSetAllEnrollData.Enabled = True
            Exit Sub
        End If

        fbGetState = True
        Cursor = Cursors.WaitCursor
        With fadoEnrollRST
            If .RecordCount > 0 Then
                .MoveLast()
                .MoveFirst()
                Do While .EOF = False
FFF:
                    vbRet = FuncReadFromToDB(vEnrollNumber, vBackupNumber, vPrivilege, vEnrollName, False)
                    If vbRet <> True Then
                        vStr = "SetAllEnrollData Error"
                        Exit Do
                    End If
                    vnResultCode = FK_PutEnrollDataWithString(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, fstrEnrollData)
                    If vnResultCode <> RUN_SUCCESS Then
                        vStr = "SetAllEnrollData Error"
                        vnMessRet = MsgBox(ReturnResultPrint(vnResultCode) & ": Continue ?", MsgBoxStyle.YesNoCancel, "SetEnrollData")
                        If vnMessRet = MsgBoxResult.Yes Then GoTo FFF
                        If vnMessRet = MsgBoxResult.Cancel Then Exit Do
                    End If
                    lblMessage.Text = "ID = " & Format(vEnrollNumber, "000#") & ", FpNo = " & vBackupNumber & ", Count = " & .AbsolutePosition

                    Me.Text = Trim(Str((.AbsolutePosition)))
                    Application.DoEvents()
                    .MoveNext()
                Loop
            End If
        End With
        Me.Text = vTitle
        Cursor = Cursors.Default
        fbGetState = False

        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "Saving..."
            Application.DoEvents()
            vnResultCode = FK_SaveEnrollData(fnCommHandleIndex)
            If vnResultCode = RUN_SUCCESS Then
                lblMessage.Text = "SetAllEnrollData OK"
            Else
                lblMessage.Text = ReturnResultPrint(vnResultCode)
            End If
        Else
            lblMessage.Text = vStr & " : " & ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdSetAllEnrollData.Enabled = True
    End Sub

    Private Sub cmdUSBGetAllData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUSBGetAllData.Click
        Dim vEnrollNumber As Long
        Dim vEnrollName As String
        Dim vBackupNumber As Long
        Dim vPrivilege As Long
        Dim vnEnableFlag As Long
        Dim vTitle As String
        Dim vstrFileName As String
        Dim vnResultCode As Integer

        dlgOpen.InitialDirectory = GetCurrentDirectory()
        dlgOpen.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*"
        dlgOpen.FilterIndex = 1
        If dlgOpen.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        vstrFileName = dlgOpen.FileName
        dlgOpen.FileName = CStr(Nothing)

        cmdUSBGetAllData.Enabled = False
        lstEnrollData.Items.Clear()
        vTitle = Me.Text
        lblMessage.Text = "Working..."
        Application.DoEvents()
        vEnrollName = Space(256)
        vnResultCode = FK_USBReadAllEnrollDataFromFile(fnCommHandleIndex, vstrFileName)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(vnResultCode)
            cmdUSBGetAllData.Enabled = True
            Exit Sub
        End If

        '---- Get Enroll data and save into database -------------
        Cursor = Cursors.WaitCursor
        With fadoEnrollRST
            fbGetState = True
            Do
                fstrEnrollData = Space(DATASIZE)
                vnResultCode = FK_USBGetOneEnrollDataWithString(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, fstrEnrollData, vnEnableFlag, vEnrollName)
                If vnResultCode <> RUN_SUCCESS Then
                    If vnResultCode = RUNERR_DATAARRAY_END Then
                        vnResultCode = RUN_SUCCESS
                    End If
                    Exit Do
                End If

                FuncSaveToDB(vEnrollNumber, vBackupNumber, vPrivilege, vEnrollName)
                Me.Text = Format(vEnrollNumber, "0000#")
                Application.DoEvents()
            Loop
            fbGetState = False
            Application.DoEvents()
            If .RecordCount > 1 Then
                .MoveFirst()
                .MoveLast()
            End If
        End With
        Me.Text = vTitle
        Cursor = Cursors.Default

        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "GetAllEnrollData(USB) OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If
        cmdUSBGetAllData.Enabled = True
    End Sub

    Private Sub cmdUSBSetAllData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUSBSetAllData.Click
        Dim vEnrollNumber As Long
        Dim vEnrollName As String
        Dim vBackupNumber As Long
        Dim vPrivilege As Long
        Dim vnMessRet As Long
        Dim vstrMess As String
        Dim vTitle As String
        Dim vstrFileName As String
        Dim vnEnableFlag As Long
        Dim vnResultCode As Integer
        Dim vbRet As Boolean

        lstEnrollData.Items.Clear()

        vstrMess = ""
        dlgSave.InitialDirectory = GetCurrentDirectory()
        dlgSave.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*"
        dlgSave.FilterIndex = 1
        If dlgSave.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        vstrFileName = dlgSave.FileName
        dlgSave.FileName = CStr(Nothing)

        cmdUSBSetAllData.Enabled = False
        vTitle = Me.Text
        lblMessage.Text = "Working..."
        Application.DoEvents()

        fbGetState = True
        Cursor = Cursors.WaitCursor
        With fadoEnrollRST
            If .RecordCount > 0 Then
                .MoveLast()
                .MoveFirst()
                Do While .EOF = False
FFF:
                    vbRet = FuncReadFromToDB(vEnrollNumber, vBackupNumber, vPrivilege, vEnrollName, False)
                    If vbRet <> True Then
                        vstrMess = "SetAllEnrollData(USB) Error"
                        Exit Do
                    End If

                    vnEnableFlag = 1
                    vnResultCode = FK_USBSetOneEnrollDataWithString(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, fstrEnrollData, vnEnableFlag, vEnrollName)
                    If vnResultCode <> RUN_SUCCESS Then
                        vstrMess = "USBSetOneEnrollData Error"
                        vnMessRet = MsgBox(ReturnResultPrint(vnResultCode) & ": Continue ?", MsgBoxStyle.YesNoCancel, vstrMess)
                        If vnMessRet = MsgBoxResult.Yes Then GoTo FFF
                        If vnMessRet = MsgBoxResult.Cancel Then Exit Do
                    End If

                    lblMessage.Text = "ID = " & Format(vEnrollNumber, "000#") & ", FpNo = " & vBackupNumber _
                                        & ", Count = " & .AbsolutePosition

                    Me.Text = Trim(Str((.AbsolutePosition)))
                    Application.DoEvents()
                    .MoveNext()
                Loop
            End If
        End With

        Me.Text = vTitle
        Cursor = Cursors.Default
        fbGetState = False

        If vnResultCode = RUN_SUCCESS Then
            vnResultCode = FK_USBWriteAllEnrollDataToFile(fnCommHandleIndex, vstrFileName)
            If vnResultCode = RUN_SUCCESS Then
                lblMessage.Text = "USBWriteAllEnrollDataToFile OK"
            Else
                lblMessage.Text = ReturnResultPrint(vnResultCode)
            End If
        Else
            lblMessage.Text = vstrMess
        End If
        cmdUSBSetAllData.Enabled = True
    End Sub

    Private Sub cmdGetEnrollInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetEnrollInfo.Click
        Dim vEnrollNumber As Integer
        Dim vBackupNumber As Integer
        Dim vstrBackupNumber As String
        Dim vPrivilege As Integer
        Dim vstrPrivilege As String
        Dim vnEnableFlag As Integer
        Dim vstrEnableFlag As String
        Dim vnii As Integer
        Dim vnResultCode As Integer

        cmdGetEnrollInfo.Enabled = False
        lblEnrollData.Text = "User IDs"
        lstEnrollData.Items.Clear()
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetEnrollInfo.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_ReadAllUserID(fnCommHandleIndex)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(vnResultCode)
            FK_EnableDevice(fnCommHandleIndex, 1)
            cmdGetEnrollInfo.Enabled = True
            Exit Sub
        End If

        '------ Show all enroll information ----------
        vnii = 0
        lstEnrollData.Items.Add(" No.         EnNo           Fp        Priv   Enable")
        Do
            vnResultCode = FK_GetAllUserID(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege, vnEnableFlag)
            If vnResultCode <> RUN_SUCCESS Then
                If vnResultCode = RUNERR_DATAARRAY_END Then
                    vnResultCode = RUN_SUCCESS
                End If
                Exit Do
            End If

            If vPrivilege = MP_ALL Then
                vstrPrivilege = "Man"
            Else
                vstrPrivilege = "User"
            End If

            vstrBackupNumber = FuncStringFromBackupNumber(vBackupNumber)

            If vnEnableFlag = 1 Then
                vstrEnableFlag = "E"
            Else
                vstrEnableFlag = "D"
            End If

            lstEnrollData.Items.Add(Format(vnii, "000#") & "    " & _
                                   Format(vEnrollNumber, "0000000#") & "      " & _
                                   vstrBackupNumber & "     " & _
                                   vstrPrivilege & "       " & _
                                   vstrEnableFlag)

            vnii = vnii + 1
            lblTotal.Text = "Total : " & vnii
            Application.DoEvents()
        Loop

        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "GetEnrollInfo OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetEnrollInfo.Enabled = True
    End Sub

    Private Sub FuncSetUserEnableStatus(ByRef abEnableFlag As Boolean)
        Dim vEnrollNumber As Integer
        Dim vBackupNumber As Integer
        Dim vnResultCode As Integer

        lblMessage.Text = "Working..."
        Application.DoEvents()

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vBackupNumber = FuncGetBackupNumberFromItem()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            Exit Sub
        End If

        vnResultCode = FK_EnableUser(fnCommHandleIndex, vEnrollNumber, vBackupNumber, abEnableFlag)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
    End Sub

    Private Sub cmdEnableUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnableUser.Click
        cmdEnableUser.Enabled = False
        FuncSetUserEnableStatus(True)
        cmdEnableUser.Enabled = True
    End Sub

    Private Sub cmdDisableUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisableUser.Click
        cmdDisableUser.Enabled = False
        FuncSetUserEnableStatus(False)
        cmdDisableUser.Enabled = True
    End Sub

    Private Sub cmdModifyPrivilege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModifyPrivilege.Click
        Dim vEnrollNumber As Integer
        Dim vBackupNumber As Integer
        Dim vPrivilege As Integer
        Dim vnResultCode As Integer

        cmdModifyPrivilege.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vEnrollNumber = Val(txtEnrollNumber.Text)
        vBackupNumber = FuncGetBackupNumberFromItem()
        If cmbPrivilege.SelectedIndex = 1 Then
            vPrivilege = MP_ALL
        Else
            vPrivilege = MP_NONE
        End If

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdModifyPrivilege.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_ModifyPrivilege(fnCommHandleIndex, vEnrollNumber, vBackupNumber, vPrivilege)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdModifyPrivilege.Enabled = True
    End Sub

    Private Sub cmdBenumbManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBenumbManager.Click
        Dim vnResultCode As Long

        cmdBenumbManager.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdBenumbManager.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_BenumbAllManager(fnCommHandleIndex)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdBenumbManager.Enabled = True
    End Sub

    Private Sub cmdEmptyEnrollData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmptyEnrollData.Click
        Dim vnResultCode As Integer

        cmdEmptyEnrollData.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdEmptyEnrollData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_EmptyEnrollData(fnCommHandleIndex)
        lblMessage.Text = ReturnResultPrint(vnResultCode)

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdEmptyEnrollData.Enabled = True
    End Sub

    Private Sub cmdClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearData.Click
        Dim vnResultCode As Integer

        cmdClearData.Enabled = False
        lblMessage.Text = "Working..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdClearData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FK_ClearKeeperData(fnCommHandleIndex)
        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "ClearKeeperData OK"
        Else
            lblMessage.Text = ReturnResultPrint(vnResultCode)
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdClearData.Enabled = True
    End Sub

    Private Sub DBWithItemEnable(ByRef abEnableFlag As Boolean)
        scbAdoScroll.Enabled = abEnableFlag
        lblDBCount.Enabled = abEnableFlag
        cmdDel.Enabled = abEnableFlag
        cmdGetAllEnrollData.Enabled = abEnableFlag
        cmdSetAllEnrollData.Enabled = abEnableFlag
        cmdUSBGetAllData.Enabled = abEnableFlag
        cmdUSBSetAllData.Enabled = abEnableFlag
    End Sub

    Private Sub DisableButtons()
        cmdGetEnrollData.Enabled = False
        cmdSetEnrollData.Enabled = False
        cmdDeleteEnrollData.Enabled = False
        cmdGetAllEnrollData.Enabled = False
        cmdSetAllEnrollData.Enabled = False
        cmdGetEnrollInfo.Enabled = False
        cmdEnableUser.Enabled = False
        cmdDisableUser.Enabled = False
        cmdModifyPrivilege.Enabled = False
        cmdBenumbManager.Enabled = False
        cmdClearData.Enabled = False
        cmdEmptyEnrollData.Enabled = False
    End Sub

    Private Sub FuncDispToListBox(ByVal anBackupNumber As Integer)
        Dim vnii As Integer
        Dim vnLen As Integer

        lstEnrollData.Items.Clear()
        lblEnrollData.Text = "Enrolled Data :"
        lblTotal.Text = ""

        If anBackupNumber = BACKUP_PSW Then
            lstEnrollData.Items.Add(fstrEnrollData)
        ElseIf anBackupNumber = BACKUP_CARD Then
            lstEnrollData.Items.Add(fstrEnrollData)
        ElseIf anBackupNumber < BACKUP_PSW Then
            vnLen = Len(fstrEnrollData)
            For vnii = 0 To vnLen / 24 - 1
                lstEnrollData.Items.Add(Mid(fstrEnrollData, vnii * 24 + 1, 24))
            Next
        End If
    End Sub

    Private Sub FuncSaveToDB(ByRef anEnrollNumber As Integer, ByRef anBackupNumber As Integer, ByRef anPrivilege As Integer, ByRef anEnrollName As String)
        Dim vstrFind As String, vnCount As Long

        vstrFind = "select count(*) from tblEnroll where EnrollNumber=" & CStr(anEnrollNumber) & " and FingerNumber=" & CStr(anBackupNumber)
        With fadoTmpRST
            If .State = ADODB.ObjectStateEnum.adStateOpen Then .Close()
            fadoTmpRST.Open(vstrFind, fadoEnrollCnnt, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            vnCount = .Fields(0).Value
            .Close()
            If vnCount > 0 Then
                lblMessage.Text = "Double ID : " & Format(anEnrollNumber, "0000#") & "-" & anBackupNumber
                lstEnrollData.Items.Add(lblMessage.Text)
                Exit Sub
            End If
        End With

        With fadoEnrollRST
            .AddNew()
            .Fields("EnrollNumber").Value = anEnrollNumber
            .Fields("FingerNumber").Value = anBackupNumber
            .Fields("Privilige").Value = anPrivilege
            .Fields("EnrollName").Value = Trim(anEnrollName)

            If anBackupNumber = BACKUP_PSW Then
                .Fields("Password").Value = fstrEnrollData
            ElseIf anBackupNumber = BACKUP_CARD Then
                .Fields("Password").Value = fstrEnrollData
            Else
                .Fields("FPdata").Value = fstrEnrollData
            End If
            .Update()
            .UpdateBatch()
            AdoEnroll_MoveComplete()
            lblMessage.Text = Format(anEnrollNumber, "0000#") & "-" & anBackupNumber
            txtEnrollNumber.Text = Trim(Str(anEnrollNumber))
            cmbBackupNumber.SelectedIndex = FuncItemIndexFromBackupNumber(anBackupNumber)
            If anPrivilege = MP_ALL Then
                cmbPrivilege.SelectedIndex = 1
            Else
                cmbPrivilege.SelectedIndex = 0
            End If
        End With

        Application.DoEvents()
    End Sub

    Private Function FuncReadFromToDB(ByRef anEnrollNumber As Integer, ByRef anBackupNumber As Integer, ByRef anPrivilege As Integer, ByRef anEnrollName As String, Optional ByVal abdispFlag As Boolean = True) As Boolean
        FuncReadFromToDB = False
        With fadoEnrollRST
            If .RecordCount <= 0 Then Exit Function
            If .AbsolutePosition <= 0 Then Exit Function
            If .Fields("EnrollNumber").Value <= 0 Then Exit Function
            anEnrollNumber = .Fields("EnrollNumber").Value
            txtEnrollNumber.Text = Trim(Str(anEnrollNumber))
            anBackupNumber = .Fields("FingerNumber").Value
            cmbBackupNumber.SelectedIndex = FuncItemIndexFromBackupNumber(anBackupNumber)
            anPrivilege = .Fields("Privilige").Value
            anEnrollName = .Fields("EnrollName").Value
            If anPrivilege = MP_ALL Then
                cmbPrivilege.SelectedIndex = 1
            Else
                cmbPrivilege.SelectedIndex = 0
            End If
            If anBackupNumber < BACKUP_PSW Then
                fstrEnrollData = .Fields("FPdata").Value
            Else
                If IsDBNull(.Fields("Password").Value) Then
                    fstrEnrollData = 0
                Else
                    fstrEnrollData = .Fields("Password").Value
                End If
            End If
            If abdispFlag = True Then
                FuncDispToListBox(anBackupNumber)
            End If
            FuncReadFromToDB = True
        End With
    End Function

    Private Function FuncGetBackupNumberFromItem() As Integer
        Dim vnIndex As Integer

        vnIndex = cmbBackupNumber.SelectedIndex
        If vnIndex < 0 Then vnIndex = 0
        FuncGetBackupNumberFromItem = ftBackupNumber(vnIndex * 2)
    End Function

    Private Function FuncItemIndexFromBackupNumber(ByVal anBackupNumber As Integer) As Integer
        Dim vnii As Integer

        FuncItemIndexFromBackupNumber = -1
        For vnii = 0 To UBound(ftBackupNumber) Step 2
            If ftBackupNumber(vnii) = anBackupNumber Then
                FuncItemIndexFromBackupNumber = vnii / 2
                Exit For
            End If
        Next vnii
    End Function

    Private Function FuncStringFromBackupNumber(ByVal anBackupNumber As Integer) As String
        Dim vnii As Integer

        FuncStringFromBackupNumber = "        "
        For vnii = 0 To UBound(ftBackupNumber) Step 2
            If ftBackupNumber(vnii) = anBackupNumber Then
                FuncStringFromBackupNumber = ftBackupNumber(vnii + 1)
                If anBackupNumber <> BACKUP_PSW And anBackupNumber <> BACKUP_CARD Then
                    FuncStringFromBackupNumber = FuncStringFromBackupNumber & " "
                End If
                Exit For
            End If
        Next vnii
    End Function
End Class
