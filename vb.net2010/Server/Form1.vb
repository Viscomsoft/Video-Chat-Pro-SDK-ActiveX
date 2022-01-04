Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.textPort.Text = "" Then
            MessageBox.Show("Plesase input Port No")
            Exit Sub
        End If
        Me.AxVideoChatServer1.InitServer(Convert.ToInt16(textPort.Text), 300)
        If Me.CheckBox1.Checked = True Then
            Me.AxVideoChatServer1.UseRandomNumber = True
        Else
            Me.AxVideoChatServer1.UseRandomNumber = False
        End If
        Me.textConference.Text = Me.AxVideoChatServer1.CreateConference
        Me.listUserID.Items.Clear()
        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.AxVideoChatServer1.UnInitServer()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim userID As Integer
        userID = Me.AxVideoChatServer1.AddUser(Me.textConference.Text)
        If userID <> 0 Then
            Me.listUserID.Items.Add(userID)
        Else
            MessageBox.Show("Max is 12 user per Room")
        End If

    End Sub

    Private Sub listUserID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listUserID.Click
        Me.textSelectedUserID.Text = Me.listUserID.Text
    End Sub

    Private Sub listUserID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listUserID.SelectedIndexChanged

    End Sub

   

    Private Sub AxVideoChatServer1_ClientConnected(ByVal sender As Object, ByVal e As AxVideoChatServerLib._DVideoChatServerEvents_ClientConnectedEvent) Handles AxVideoChatServer1.ClientConnected
        Dim iCount As Short
        Dim strUserID As String
        Dim strListID As String


        iCount = Me.listUserID.Items.Count - 1
        strUserID = e.iUserID.ToString
        For i = 0 To iCount
            strListID = Me.listUserID.Items(i)

            If Trim(strListID) = Trim(strUserID) Then
                Me.listUserID.Items.RemoveAt(i)
                Me.listUserID.Items.Insert(i, strUserID + "***")
                'Me.listUserID.Items(i) = Me.listUserID.Items.Item(i).ToString + "***"
            End If

        Next

        Me.listUserID.Refresh()
    End Sub

    Private Sub AxVideoChatServer1_ClientDisconnected(ByVal sender As Object, ByVal e As AxVideoChatServerLib._DVideoChatServerEvents_ClientDisconnectedEvent) Handles AxVideoChatServer1.ClientDisconnected
        Dim iCount As Short
        Dim strUserID As String
        Dim strListID As String
        iCount = Me.listUserID.Items.Count - 1
        strUserID = e.iUserID.ToString
        For i = 0 To iCount
            strListID = Me.listUserID.Items(i)

            If strListID = (strUserID + "***") Then
                Me.listUserID.Items.RemoveAt(i)
                Me.listUserID.Items.Insert(i, strUserID)
            End If

        Next
        Me.listUserID.Refresh()
    End Sub
End Class


