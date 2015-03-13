Imports System.Threading

Public Class TimeCardReport



    Private Sub TimeCardReport_Load(ByVal sender As System.Object, _
                    ByVal e As System.EventArgs) Handles MyBase.Load

        'bind the data grid to the binding sourse
        DataGridView1.DataSource = BindingSource1

        'Initialize the columns in the data table'
        Dim table As DataTable = New DataTable
        table.Columns.Add("Employee/Name/Title", Type.GetType("System.String"))
        table.Columns.Add("Date", Type.GetType("System.String"))
        table.Columns.Add("Sched Time", Type.GetType("System.String"))
        table.Columns.Add("Act Time", Type.GetType("System.String"))
        table.Columns.Add("Pay Time", Type.GetType("System.String"))
        table.Columns.Add("OT Hours", Type.GetType("System.String"))
        table.Columns.Add("D-Hours", Type.GetType("System.String"))
        table.Columns.Add("Total Hours", Type.GetType("System.String"))
        table.Columns.Add("Comments", Type.GetType("System.String"))

        BindingSource1.DataSource = table


        GetDataTable()

        'ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf GetTableData))




    End Sub

    'Build table data for the user'
    'TODO' run on seperate thread
    Private Sub GetDataTable()
        Dim UserKey As String = frmMain.SelectedUser

        'TODO: make some api call to grab info for user'
        Dim CurrentTable As DataTable = BindingSource1.DataSource


        CurrentTable.Rows.Add("string 0", "string 1", "string 2", "string 3", "string 4", "string 5", "string 6", "string 7", "string 8")


    End Sub

End Class