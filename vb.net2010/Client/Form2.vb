Public Class Form2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New Form1
        If Me.textIPAddress.Text = "" Then
            MessageBox.Show("Please input IP Address")
            Exit Sub
        End If

        If RadioButton1.Checked Then
            If Me.txtListenIP.Text = "" Or Me.txtListenIP.Text = "0" Then
                MessageBox.Show("Please input Listen IP Address")
                Exit Sub
            End If
        End If



        If Me.textPortNo.Text = "" Then
            MessageBox.Show("Please input Port No")
            Exit Sub
        End If
        If Me.textConferenceNo.Text = "" Then
            MessageBox.Show("Please input Conference Number")
            Exit Sub
        End If
        If Me.textUserID.Text = "" Then
            MessageBox.Show("Please input User ID")
            Exit Sub
        End If
        Me.Hide()
        frm.txtconnectIP.Text = Me.textIPAddress.Text
        frm.txtPeertoPeerListenIP.Text = txtListenIP.Text
        frm.txtConnectPortNo.Text = Me.textPortNo.Text
        frm.textConferenceNO.Text = Me.textConferenceNo.Text
        frm.textUserID.Text = Me.textUserID.Text
        frm.ShowDialog()

    End Sub

    Private Sub textUserID_TextChanged(sender As System.Object, e As System.EventArgs) Handles textUserID.TextChanged

    End Sub


    Private Sub RadioButton2_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton2.Click
        Label1.Text = "IP address of Video Chat Pro server"
        textConferenceNo.Text = "5000"
        textUserID.Text = "10000"
        textConferenceNo.Enabled = True
        textUserID.Enabled = True

        txtListenIP.Enabled = False
        txtListenIP.Text = 0

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton1.Click
        Label1.Text = "Stream to IP address"
        textConferenceNo.Text = "0"
        textUserID.Text = "0"
        textConferenceNo.Enabled = False
        textUserID.Enabled = False
        txtListenIP.Enabled = True

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class