Imports Microsoft.Office.interop.excel

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oXL As Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim oRng As Excel.Range


        'On Error GoTo Err_Handler

        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet

        ' Add table headers going cell by cell.
        oSheet.Cells(1, 1).Value = "First Name"
        oSheet.Cells(1, 2).Value = "Last Name"
        oSheet.Cells(1, 3).Value = "Full Name"
        oSheet.Cells(1, 4).Value = "Salary"

        ' Fill C2:C6 with a relative formula (=A2 & " " & B2).
        oRng = oSheet.Range("C2", "C6")
        oRng.Formula = "=A2 & "" "" & B2"

        ' Fill D2:D6 with a formula(=RAND()*100000) and apply format.
        oRng = oSheet.Range("D2", "D6")
        oRng.Formula = "=RAND()*100000"
        oRng.NumberFormat = "$0.00"

        ' AutoFit columns A:D.
        oRng = oSheet.Range("A1", "D1")
        oRng.EntireColumn.AutoFit()

        ' Make sure Excel is visible and give the user control
        ' of Microsoft Excel's lifetime.
        oXL.Visible = True
        oXL.UserControl = True

        ' Make sure you release object references.
        oRng = Nothing
        oSheet = Nothing
        oWB = Nothing
        oXL = Nothing

        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
    End Sub
End Class
