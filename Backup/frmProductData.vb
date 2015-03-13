Option Strict Off
Option Explicit On 

Public Class frmProductData
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
    Public WithEvents txtProductCode As System.Windows.Forms.TextBox
    Public WithEvents cmdGetData As System.Windows.Forms.Button
    Public WithEvents txtBackupNo As System.Windows.Forms.TextBox
    Public WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Public WithEvents lblBackuplNo As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblSerialNo As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProductData))
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.cmdGetData = New System.Windows.Forms.Button()
        Me.txtBackupNo = New System.Windows.Forms.TextBox()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.lblBackuplNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtProductCode
        '
        Me.txtProductCode.AcceptsReturn = True
        Me.txtProductCode.AutoSize = False
        Me.txtProductCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProductCode.Location = New System.Drawing.Point(173, 136)
        Me.txtProductCode.MaxLength = 32
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProductCode.Size = New System.Drawing.Size(214, 27)
        Me.txtProductCode.TabIndex = 11
        Me.txtProductCode.Text = ""
        '
        'cmdGetData
        '
        Me.cmdGetData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetData.Location = New System.Drawing.Point(267, 176)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetData.Size = New System.Drawing.Size(121, 45)
        Me.cmdGetData.TabIndex = 10
        Me.cmdGetData.Text = "Get"
        '
        'txtBackupNo
        '
        Me.txtBackupNo.AcceptsReturn = True
        Me.txtBackupNo.AutoSize = False
        Me.txtBackupNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtBackupNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackupNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBackupNo.Location = New System.Drawing.Point(173, 96)
        Me.txtBackupNo.MaxLength = 32
        Me.txtBackupNo.Name = "txtBackupNo"
        Me.txtBackupNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBackupNo.Size = New System.Drawing.Size(214, 27)
        Me.txtBackupNo.TabIndex = 9
        Me.txtBackupNo.Text = ""
        '
        'txtSerialNo
        '
        Me.txtSerialNo.AcceptsReturn = True
        Me.txtSerialNo.AutoSize = False
        Me.txtSerialNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerialNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerialNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSerialNo.Location = New System.Drawing.Point(173, 56)
        Me.txtSerialNo.MaxLength = 32
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerialNo.Size = New System.Drawing.Size(214, 27)
        Me.txtSerialNo.TabIndex = 8
        Me.txtSerialNo.Text = ""
        '
        'lblBackuplNo
        '
        Me.lblBackuplNo.AutoSize = True
        Me.lblBackuplNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblBackuplNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBackuplNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackuplNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBackuplNo.Location = New System.Drawing.Point(37, 104)
        Me.lblBackuplNo.Name = "lblBackuplNo"
        Me.lblBackuplNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBackuplNo.Size = New System.Drawing.Size(132, 19)
        Me.lblBackuplNo.TabIndex = 15
        Me.lblBackuplNo.Text = "Backup Number :"
        Me.lblBackuplNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(37, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Product Code :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSerialNo
        '
        Me.lblSerialNo.AutoSize = True
        Me.lblSerialNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblSerialNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSerialNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSerialNo.Location = New System.Drawing.Point(37, 64)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSerialNo.Size = New System.Drawing.Size(119, 19)
        Me.lblSerialNo.TabIndex = 13
        Me.lblSerialNo.Text = "Serial Number :"
        Me.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(21, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(367, 28)
        Me.lblMessage.TabIndex = 12
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmProductData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(410, 232)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtProductCode, Me.cmdGetData, Me.txtBackupNo, Me.txtSerialNo, Me.lblBackuplNo, Me.Label1, Me.lblSerialNo, Me.lblMessage})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Information"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private fnCommHandleIndex As Long

    Private Sub frmProductData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnCommHandleIndex = gfrmMain.gnCommHandleIndex
    End Sub

    Private Sub cmdGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetData.Click
        Dim vstrData As String
        Dim vnResultCode As Long

        cmdGetData.Enabled = False
        txtSerialNo.Text = ""
        txtBackupNo.Text = ""
        txtProductCode.Text = ""
        lblMessage.Text = "Waiting..."
        Application.DoEvents()

        vnResultCode = FK_EnableDevice(fnCommHandleIndex, 0)
        If vnResultCode <> RUN_SUCCESS Then
            lblMessage.Text = gstrNoDevice
            cmdGetData.Enabled = True
            Exit Sub
        End If

        vnResultCode = FuncGetProductData(PRODUCT_SERIALNUMBER, vstrData)
        If vnResultCode = RUN_SUCCESS Then
            txtSerialNo.Text = vstrData

            vnResultCode = FuncGetProductData(PRODUCT_BACKUPNUMBER, vstrData)
            If vnResultCode = RUN_SUCCESS Then
                txtBackupNo.Text = vstrData

                vnResultCode = FuncGetProductData(PRODUCT_CODE, vstrData)
                If vnResultCode = RUN_SUCCESS Then
                    txtProductCode.Text = vstrData
                End If
            End If
        End If

        If vnResultCode = RUN_SUCCESS Then
            lblMessage.Text = "GetProductData OK"
        End If

        FK_EnableDevice(fnCommHandleIndex, 1)
        cmdGetData.Enabled = True
    End Sub

    Private Function FuncGetProductData(ByVal anIndex As Long, ByRef astrItem As String) As Long
        Dim vstrData As String

        vstrData = Space(256)
        FuncGetProductData = FK_GetProductData(fnCommHandleIndex, anIndex, vstrData)
        If FuncGetProductData <> RUN_SUCCESS Then
            lblMessage.Text = ReturnResultPrint(FuncGetProductData)
            Exit Function
        End If
        astrItem = Trim(vstrData)
    End Function
End Class
