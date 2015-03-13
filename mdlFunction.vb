Option Strict Off
Option Explicit On
Imports System.Runtime.InteropServices

Module mdlPublic

    Public gfrmMain As frmMain
    Public Const gstrNoDevice As String = "No Device"
    '/******************************************************************/
    '/*                            Function                            */
    '/******************************************************************/
    ' ========== FingerKeeper Interface Functions =========='
    Public Declare Function FK_ConnectComm Lib "FKAttend" (ByVal nMachineNo As Int32, ByVal nComPort As Int32, ByVal nBaudRate As Int32, ByVal pstrTelNumber As String, ByVal nWaitDialTime As Int32, ByVal nLicense As Int32) As Int32
    Public Declare Function FK_ConnectNet Lib "FKAttend" (ByVal nMachineNo As Int32, ByVal strIpAddress As String, ByVal nNetPort As Int32, ByVal nTimeOut As Int32, ByVal nProtocolType As Int32, ByVal nNetPassword As Int32, ByVal nLicense As Int32) As Int32
    Public Declare Function FK_ConnectUSB Lib "FKAttend" (ByVal nMachineNo As Int32, ByVal nLicense As Int32) As Int32
    Public Declare Sub FK_DisConnect Lib "FKAttend" (ByVal nHandleIndex As Int32)
    Public Declare Function FK_EnableDevice Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnableFlag As Byte) As Int32
    Public Declare Sub FK_PowerOnAllDevice Lib "FKAttend" (ByVal nHandleIndex As Int32)
    Public Declare Function FK_PowerOffDevice Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_GetDeviceStatus Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nStatusIndex As Int32, ByRef pnValue As Int32) As Int32
    Public Declare Function FK_GetDeviceTime Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef pnDateTime As Date) As Int32
    Public Declare Function FK_SetDeviceTime Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nDateTime As Date) As Int32
    Public Declare Function FK_GetDeviceInfo Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nInfoIndex As Int32, ByRef pnValue As Int32) As Int32
    Public Declare Function FK_SetDeviceInfo Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nInfoIndex As Int32, ByVal nValue As Int32) As Int32
    Public Declare Function FK_GetProductData Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nDataIndex As Int32, ByVal pstrValue As String) As Int32
    Public Declare Function FK_LoadSuperLogData Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nReadMark As Int32) As Int32
    Public Declare Function FK_USBLoadSuperLogDataFromFile Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal astrFilePath As String) As Int32
    Public Declare Function FK_GetSuperLogData Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef pnSEnrollNumber As Int32, ByRef pnGEnrollNumber As Int32, ByRef nManipulation As Int32, ByRef pnBackupNumber As Int32, ByRef pnDateTime As Date) As Int32
    Public Declare Function FK_EmptySuperLogData Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_LoadGeneralLogData Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nReadMark As Int32) As Int32
    Public Declare Function FK_USBLoadGeneralLogDataFromFile Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal astrFilePath As String) As Int32
    Public Declare Function FK_GetGeneralLogData Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef pnEnrollNumber As Int32, ByRef pnVerifyMode As Int32, ByRef pnInOutMode As Int32, ByRef pnDateTime As Date) As Int32
    Public Declare Function FK_EmptyGeneralLogData Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_GetBellTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef pnBellCount As Int32, ByRef apstrBellInfo As String) As Int32
    Public Declare Function FK_SetBellTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nBellCount As Int32, ByVal apstrBellInfo As String) As Int32
    Public Declare Function FK_GetEnrollDataWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nBackupNumber As Int32, ByRef pnMachinePrivilege As Int32, ByRef pnEnrollData As String) As Int32
    Public Declare Function FK_PutEnrollDataWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nBackupNumber As Int32, ByVal nMachinePrivilege As Int32, ByVal pnEnrollData As String) As Int32
    Public Declare Function FK_SaveEnrollData Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_DeleteEnrollData Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nBackupNumber As Int32) As Int32
    Public Declare Function FK_USBReadAllEnrollDataFromFile Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal pstrFilePath As String) As Int32
    Public Declare Function FK_USBReadAllEnrollDataCount Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal pnValue As Int32) As Int32
    Public Declare Function FK_USBGetOneEnrollDataWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef pnEnrollNumber As Int32, ByRef pnBackupNumber As Int32, ByRef pnMachinePrivilege As Int32, ByRef apstrEnrollData As String, ByRef pnEnableFlag As Int32, ByRef pnEnrollName As String) As Int32
    Public Declare Function FK_USBSetOneEnrollDataWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nBackupNumber As Int32, ByVal nMachinePrivilege As Int32, ByVal apstrEnrollData As String, ByVal nEnableFlag As Int32, ByVal pnEnrollName As String) As Int32
    Public Declare Function FK_USBWriteAllEnrollDataToFile Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal pstrFilePath As String) As Int32
    Public Declare Function FK_EnableUser Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nBackupNumber As Int32, ByVal nEnableFlag As Int32) As Int32
    Public Declare Function FK_ModifyPrivilege Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nBackupNumber As Int32, ByVal nMachinePrivilege As Int32) As Int32
    Public Declare Function FK_ReadAllUserID Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_GetAllUserID Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef pnEnrollNumber As Int32, ByRef pnBackupNumber As Int32, ByRef pnMachinePrivilege As Int32, ByRef pnEnable As Int32) As Int32
    Public Declare Function FK_EmptyEnrollData Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_ClearKeeperData Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_GetUserName Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByRef pstrUserName As String) As Int32
    Public Declare Function FK_SetUserName Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal pstrUserName As String) As Int32
    Public Declare Function FK_GetNewsMessage Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nNewsId As Int32, ByRef pstrNews As String) As Int32
    Public Declare Function FK_SetNewsMessage Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nNewsId As Int32, ByVal pstrNews As String) As Int32
    Public Declare Function FK_GetUserNewsID Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByRef pnNewsId As Int32) As Int32
    Public Declare Function FK_SetUserNewsID Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal nEnrollNumber As Int32, ByVal nNewsId As Int32) As Int32
    Public Declare Function FK_GetDoorStatus Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef apnStatusVal As Int32) As Int32
    Public Declare Function FK_SetDoorStatus Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anStatusVal As Int32) As Int32
    Public Declare Function FK_GetPassTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anPassTimeID As Int32, ByRef apstrPassTime As String) As Int32
    Public Declare Function FK_SetPassTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anPassTimeID As Int32, ByVal apstrPassTime As String) As Int32
    Public Declare Function FK_GetUserPassTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anEnrollNumber As Int32, ByRef apnGroupID As Int32, ByRef apstrPassTimeID As String) As Int32
    Public Declare Function FK_SetUserPassTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anEnrollNumber As Int32, ByVal anGroupID As Int32, ByVal apstrPassTimeID As String) As Int32
    Public Declare Function FK_GetGroupPassTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anGroupID As Int32, ByRef apstrPassTimeID As String) As Int32
    Public Declare Function FK_SetGroupPassTimeWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal anGroupID As Int32, ByVal apstrPassTimeID As String) As Int32
    Public Declare Function FK_GetGroupMatchWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByRef apstrGroupMatch As String) As Int32
    Public Declare Function FK_SetGroupMatchWithString Lib "FKAttend" (ByVal nHandleIndex As Int32, ByVal apstrGroupMatch As String) As Int32
    Public Declare Function FK_BenumbAllManager Lib "FKAttend" (ByVal nHandleIndex As Int32) As Int32
    Public Declare Function FK_ConnectGetIP Lib "FKAttend" (ByRef apnComName As String) As Long
    Public Declare Function FK_GetAdjustInfo Lib "FKAttend" (ByVal nHandleIndex As Long, ByRef dwAdjustedState As Long, ByRef dwAdjustedMonth As Long, ByRef dwAdjustedDay As Long, ByRef dwAdjustedHour As Long, ByRef dwAdjustedMinute As Long, ByRef dwRestoredState As Long, ByRef dwRestoredMonth As Long, ByRef dwRestoredDay As Long, ByRef dwRestoredHour As Long, ByRef dwRestoredMinte As Long)
    Public Declare Function FK_SetAdjustInfo Lib "FKAttend" (ByVal nHandleIndex As Long, ByVal dwAdjustedState As Long, ByVal dwAdjustedMonth As Long, ByVal dwAdjustedDay As Long, ByVal dwAdjustedHour As Long, ByVal dwAdjustedMinute As Long, ByVal dwRestoredState As Long, ByVal dwRestoredMonth As Long, ByVal dwRestoredDay As Long, ByVal dwRestoredHour As Long, ByVal dwRestoredMinte As Long)
    '/******************************************************************/
    '/*                            Structure                           */
    '/******************************************************************/
    Public Const MAX_BELLCOUNT_DAY As Short = 24
    Structure BELLINFO
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_BELLCOUNT_DAY)> Dim mValid() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_BELLCOUNT_DAY)> Dim mHour() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_BELLCOUNT_DAY)> Dim mMinute() As Byte

        Public Sub Initialize()
            ReDim mValid(MAX_BELLCOUNT_DAY - 1)
            ReDim mHour(MAX_BELLCOUNT_DAY - 1)
            ReDim mMinute(MAX_BELLCOUNT_DAY - 1)
        End Sub
    End Structure '72byte

    Public Const MAX_PASSCTRLGROUP_COUNT As Short = 50
    Public Const MAX_PASSCTRL_COUNT As Short = 7
    '--- Pass Control Time ---
    Structure PASSTIME
        Dim StartHour As Byte
        Dim StartMinute As Byte
        Dim EndHour As Byte
        Dim EndMinute As Byte
        Public Sub Initialize()
            StartHour = 0
            StartMinute = 0
            EndHour = 0
            EndMinute = 0
        End Sub
    End Structure '4byte

    '--- Pass Control Time Infomation ---
    Structure PASSCTRLTIME
        <VBFixedArray(MAX_PASSCTRL_COUNT - 1)> Dim mPassCtrlTime() As PASSTIME

        Public Sub Initialize()
            ReDim mPassCtrlTime(MAX_PASSCTRL_COUNT - 1)
            Dim vnii As Integer

            For vnii = 0 To MAX_PASSCTRL_COUNT - 1
                mPassCtrlTime(vnii).Initialize()
            Next
        End Sub
    End Structure '28byte

    Public Const MAX_USERPASSINFO_COUNT As Short = 3
    Structure USERPASSINFO
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_USERPASSINFO_COUNT)> Dim UserPassID() As Byte

        Public Sub Initialize()
            ReDim UserPassID(MAX_USERPASSINFO_COUNT - 1)
        End Sub
    End Structure '3byte

    Public Const MAX_GROUPPASSKIND_COUNT As Short = 5
    Public Const MAX_GROUPPASSINFO_COUNT As Short = 3
    Structure GROUPPASSINFO
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_GROUPPASSINFO_COUNT)> Dim GroupPassID() As Byte

        Public Sub Initialize()
            ReDim GroupPassID(MAX_GROUPPASSINFO_COUNT - 1)
        End Sub
    End Structure '3byte

    Public Const MAX_GROUPMATCHINFO_COUNT As Short = 10
    Structure GROUPMATCHINFO
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_GROUPMATCHINFO_COUNT)> Dim GroupMatch() As Short

        Public Sub Initialize()
            ReDim GroupMatch(MAX_GROUPMATCHINFO_COUNT - 1)
        End Sub
    End Structure '20byte

    '/******************************************************************/
    '/*                            Constant                            */
    '/******************************************************************/
    '//=============== Protocol Type ===============//
    Public Const PROTOCOL_TCPIP As Integer = 0                ' TCP/IP
    Public Const PROTOCOL_UDP As Integer = 1                  ' UDP

    '//=============== Backup Number Constant ===============//
    Public Const BACKUP_FP_0 As Integer = 0                   ' Finger 0
    Public Const BACKUP_FP_1 As Integer = 1                   ' Finger 1
    Public Const BACKUP_FP_2 As Integer = 2                   ' Finger 2
    Public Const BACKUP_FP_3 As Integer = 3                   ' Finger 3
    Public Const BACKUP_FP_4 As Integer = 4                   ' Finger 4
    Public Const BACKUP_FP_5 As Integer = 5                   ' Finger 5
    Public Const BACKUP_FP_6 As Integer = 6                   ' Finger 6
    Public Const BACKUP_FP_7 As Integer = 7                   ' Finger 7
    Public Const BACKUP_FP_8 As Integer = 8                   ' Finger 8
    Public Const BACKUP_FP_9 As Integer = 9                   ' Finger 9
    Public Const BACKUP_PSW As Integer = 10                   ' Password
    Public Const BACKUP_CARD As Integer = 11                  ' Card

    '//=============== Manipulation of SuperLogData ===============//
    Public Const LOG_ENROLL_USER As Integer = 3               ' Enroll-User
    Public Const LOG_ENROLL_MANAGER As Integer = 4            ' Enroll-Manager
    Public Const LOG_ENROLL_DELFP As Integer = 5              ' FP Delete
    Public Const LOG_ENROLL_DELPASS As Integer = 6            ' Pass Delete
    Public Const LOG_ENROLL_DELCARD As Integer = 7            ' Card Delete
    Public Const LOG_LOG_ALLDEL As Integer = 8                ' LogAll Delete
    Public Const LOG_SETUP_SYS As Integer = 9                 ' Setup Sys
    Public Const LOG_SETUP_TIME As Integer = 10               ' Setup Time
    Public Const LOG_SETUP_LOG As Integer = 11                ' Setup Log
    Public Const LOG_SETUP_COMM As Integer = 12               ' Setup Comm
    Public Const LOG_PASSTIME As Integer = 13                 ' Pass Time Set
    Public Const LOG_SETUP_DOOR As Integer = 14               ' Door Set Log
    
    '//=============== VerifyMode of GeneralLogData ===============//
    Public Const LOG_FPVERIFY = 1                 ' Fp Verify
    Public Const LOG_PASSVERIFY = 2               ' Pass Verify
    Public Const LOG_CARDVERIFY = 3               ' Card Verify
    Public Const LOG_FPPASS_VERIFY = 4            ' Pass+Fp Verify
    Public Const LOG_FPCARD_VERIFY = 5            ' Card+Fp Verify
    Public Const LOG_PASSFP_VERIFY = 6            ' Pass+Fp Verify
    Public Const LOG_CARDFP_VERIFY = 7            ' Card+Fp Verify
    Public Const LOG_JOB_NO_VERIFY = 8            ' Job number Verify
    Public Const LOG_CARDPASS_VERIFY = 9          ' Card+Pass Verify
    Public Const LOG_CLOSE_DOOR = 10              ' Door Close
    Public Const LOG_OPEN_HAND = 11               ' Hand Open
    Public Const LOG_PROG_OPEN = 12               ' Open by PC
    Public Const LOG_PROG_CLOSE = 13              ' Close by PC
    Public Const LOG_OPEN_IREGAL = 14             ' Iregal Open
    Public Const LOG_CLOSE_IREGAL = 15            ' Iregal Close
    Public Const LOG_OPEN_COVER = 16              ' Cover Open
    Public Const LOG_CLOSE_COVER = 17             ' Cover Close

    Public Const LOG_OPEN_DOOR = 32               ' Door Open
    Public Const LOG_OPEN_THREAT = 48             ' Door Open as threat

    '//=============== IOMode of GeneralLogData ===============//
    Public Const LOG_IOMODE_IN As Integer = 0
    Public Const LOG_IOMODE_OUT As Integer = 1
    Public Const LOG_IOMODE_OVER_IN As Integer = 2    ' = LOG_IOMODE_IO
    Public Const LOG_IOMODE_OVER_OUT As Integer = 3

    '//=============== Machine Privilege ===============//
    Public Const MP_NONE As Integer = 0                       ' General user
    Public Const MP_ALL As Integer = 1                        ' Manager

    '//=============== Index of  GetDeviceStatus ===============//
    Public Const GET_MANAGERS As Integer = 1
    Public Const GET_USERS As Integer = 2
    Public Const GET_FPS As Integer = 3
    Public Const GET_PSWS As Integer = 4
    Public Const GET_SLOGS As Integer = 5
    Public Const GET_GLOGS As Integer = 6
    Public Const GET_ASLOGS As Integer = 7
    Public Const GET_AGLOGS As Integer = 8
    Public Const GET_CARDS As Integer = 9

    '//=============== Index of  GetDeviceInfo ===============//
    Public Const DI_MANAGERS As Integer = 1                   ' Numbers of Manager
    Public Const DI_MACHINENUM As Integer = 2                 ' Device ID
    Public Const DI_LANGAUGE As Integer = 3                   ' Language
    Public Const DI_POWEROFF_TIME As Integer = 4              ' Auto-PowerOff Time
    Public Const DI_LOCK_CTRL As Integer = 5                  ' Lock Control
    Public Const DI_GLOG_WARNING As Integer = 6               ' General-Log Warning
    Public Const DI_SLOG_WARNING As Integer = 7               ' Super-Log Warning
    Public Const DI_VERIFY_INTERVALS As Integer = 8           ' Verify Interval Time
    Public Const DI_RSCOM_BPS As Integer = 9                  ' Comm Buadrate
    Public Const DI_DATE_SEPARATE As Integer = 10             ' Date Separate Symbol
    Public Const DI_VERIFY_KIND As Integer = 24               ' Verify Kind Symbol
    '//=============== Baudrate = value of DI_RSCOM_BPS ===============//
    Public Const BPS_9600 As Integer = 3
    Public Const BPS_19200 As Integer = 4
    Public Const BPS_38400 As Integer = 5
    Public Const BPS_57600 As Integer = 6
    Public Const BPS_115200 As Integer = 7

    '//=============== Product Data Index ===============//
    Public Const PRODUCT_SERIALNUMBER As Short = 1     ' Serial Number
    Public Const PRODUCT_BACKUPNUMBER As Short = 2     ' Backup Number
    Public Const PRODUCT_CODE As Short = 3             ' Product code
    Public Const PRODUCT_NAME As Short = 4             ' Product name
    Public Const PRODUCT_WEB As Short = 5              ' Product web
    Public Const PRODUCT_DATE As Short = 6             ' Product date
    Public Const PRODUCT_SENDTO As Short = 7           ' Product sendto

    '//=============== Door Status ===============//
    Public Const DOOR_CONROLRESET As Integer = 0
    Public Const DOOR_OPEND As Integer = 1
    Public Const DOOR_CLOSED As Integer = 2
    Public Const DOOR_COMMNAD As Integer = 3

    '//=============== Error code ===============//
    Public Const RUN_SUCCESS As Integer = 1
    Public Const RUNERR_NOSUPPORT As Integer = 0
    Public Const RUNERR_UNKNOWNERROR As Integer = -1
    Public Const RUNERR_NO_OPEN_COMM As Integer = -2
    Public Const RUNERR_WRITE_FAIL As Integer = -3
    Public Const RUNERR_READ_FAIL As Integer = -4
    Public Const RUNERR_INVALID_PARAM As Integer = -5
    Public Const RUNERR_NON_CARRYOUT As Integer = -6
    Public Const RUNERR_DATAARRAY_END As Integer = -7
    Public Const RUNERR_DATAARRAY_NONE As Integer = -8
    Public Const RUNERR_MEMORY As Integer = -9
    Public Const RUNERR_MIS_PASSWORD As Integer = -10
    Public Const RUNERR_MEMORYOVER As Integer = -11
    Public Const RUNERR_DATADOUBLE As Integer = -12
    Public Const RUNERR_MANAGEROVER As Integer = -14
    Public Const RUNERR_FPDATAVERSION As Integer = -15

    Public Function ReturnResultPrint(ByRef anResultCode As Integer) As String
        Select Case anResultCode
            Case RUN_SUCCESS
                ReturnResultPrint = "Successful!"
            Case RUNERR_NOSUPPORT
                ReturnResultPrint = "No support"
            Case RUNERR_UNKNOWNERROR
                ReturnResultPrint = "Unknown error"
            Case RUNERR_NO_OPEN_COMM
                ReturnResultPrint = "No Open Comm"
            Case RUNERR_WRITE_FAIL
                ReturnResultPrint = "Write Error"
            Case RUNERR_READ_FAIL
                ReturnResultPrint = "Read Error"
            Case RUNERR_INVALID_PARAM
                ReturnResultPrint = "Parameter Error"
            Case RUNERR_NON_CARRYOUT
                ReturnResultPrint = "execution of command failed"
            Case RUNERR_DATAARRAY_END
                ReturnResultPrint = "End of data"
            Case RUNERR_DATAARRAY_NONE
                ReturnResultPrint = "Nonexistence data"
            Case RUNERR_MEMORY
                ReturnResultPrint = "Memory Allocating Error"
            Case RUNERR_MIS_PASSWORD
                ReturnResultPrint = "License Error"
            Case RUNERR_MEMORYOVER
                ReturnResultPrint = "full enrolldata & can`t put enrolldata"
            Case RUNERR_DATADOUBLE
                ReturnResultPrint = "this ID is already  existed."
            Case RUNERR_MANAGEROVER
                ReturnResultPrint = "full manager & can`t put manager."
            Case RUNERR_FPDATAVERSION
                ReturnResultPrint = "mistake fp data version."
            Case Else
                ReturnResultPrint = "Unknown error"
        End Select
    End Function

    Public Function ConvertStringToMarshalStructure(ByVal astrBuff As String, ByVal anTypeNumber As Integer) As Object
        Dim vnii As Long
        Dim vnSize As Long
        Dim vpPtr As IntPtr
        Dim vnVal() As Byte

        vnSize = astrBuff.Length / 3 + 1
        ReDim vnVal(vnSize)
        For vnii = 1 To astrBuff.Length Step 3
            vnVal((vnii - 1) / 3) = Val("&H" & Mid(astrBuff, vnii, 2))
        Next
        vpPtr = Marshal.AllocCoTaskMem(vnSize)
        Marshal.Copy(vnVal, 0, vpPtr, vnSize)
        Select Case anTypeNumber
            Case 1
                ConvertStringToMarshalStructure = CType(Marshal.PtrToStructure(vpPtr, GetType(BELLINFO)), BELLINFO)
            Case 2
                ConvertStringToMarshalStructure = CType(Marshal.PtrToStructure(vpPtr, GetType(GROUPMATCHINFO)), GROUPMATCHINFO)
            Case 3
                ConvertStringToMarshalStructure = CType(Marshal.PtrToStructure(vpPtr, GetType(GROUPPASSINFO)), GROUPPASSINFO)
            Case 4
                ConvertStringToMarshalStructure = CType(Marshal.PtrToStructure(vpPtr, GetType(USERPASSINFO)), USERPASSINFO)
            Case 5
                ConvertStringToMarshalStructure = CType(Marshal.PtrToStructure(vpPtr, GetType(PASSTIME)), PASSTIME)
            Case Else
                ConvertStringToMarshalStructure = Nothing
        End Select
        Marshal.FreeCoTaskMem(vpPtr)
    End Function

    Public Function ConvertMarshalStructureToString(ByVal aptrVal As Object) As String
        Dim vnii As Long
        Dim vpPtr As IntPtr
        Dim vnSize As Long
        Dim vstrTmp As String
        Dim vstrData As String
        Dim vnVal() As Byte

        vnSize = Marshal.SizeOf(aptrVal)
        vpPtr = Marshal.AllocCoTaskMem(vnSize)
        Marshal.StructureToPtr(aptrVal, vpPtr, False)
        ReDim vnVal(vnSize)
        Marshal.Copy(vpPtr, vnVal, 0, vnSize)
        Marshal.FreeCoTaskMem(vpPtr)

        vstrData = ""
        For vnii = 0 To vnSize - 1
            vstrTmp = Format(vnVal(vnii), "X")
            If vstrTmp.Length = 1 Then vstrTmp = "0" & vstrTmp
            vstrData = vstrData & vstrTmp & " "
        Next
        ConvertMarshalStructureToString = Trim(vstrData)
    End Function
End Module