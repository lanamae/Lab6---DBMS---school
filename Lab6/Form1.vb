Public Class Form1
    Dim gender As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected Successfully!")
        con.Close()

    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `tbl_sample`(`FNAME`, `AGE`, `GENDER`, `BDAY`, `SECTION`) VALUES ('" & txtname.Text & "'," & txtage.Text & ",'" & gender & "','" & dtbday.Value.Date & "','" & cmbsection.SelectedItem & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Information Recorded!")
            con.Close()

            txtname.Clear()
            txtage.Clear()
            radMale.Checked = False
            radfemale.Checked = False
            cmbsection.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub
End Class
