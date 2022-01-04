Public Class Form1
    Dim bClickChangeVideoFormat As Boolean
    Dim clrTranColor As Color
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        AxVideoChatSender1.OverlayType = cboeffecttype.SelectedIndex
        AxVideoChatSender1.ChatBannerDirection(Me.cbochatdir.SelectedIndex)

        AxVideoChatSender1.VideoDevice = cbovideodevice.SelectedIndex
        AxVideoChatSender1.AudioDevice = cboaudiodevice.SelectedIndex
        AxVideoChatSender1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoChatSender1.FrameRate = txtframerate.Text
        AxVideoChatSender1.VideoBitrate = Convert.ToInt32(txtVideobitrate.Text)
        AxVideoChatSender1.AudioComplexity = cboaudiocomplex.SelectedIndex
        AxVideoChatSender1.AudioQuality = cboaudioquality.SelectedIndex
        AxVideoChatSender1.SendAudioStream = chksendaudio.Checked
        AxVideoChatSender1.SendVideoStream = chksendvideo.Checked

        AxVideoChatSender1.ConferenceNumber = Me.textConferenceNO.Text
        AxVideoChatSender1.ConferenceUserID = Me.textUserID.Text

        If chkshowmousehighlight.Checked Then
            AxVideoChatSender1.VirtualScreenShowMouseHighlight(True)
        Else
            AxVideoChatSender1.VirtualScreenShowMouseHighlight(False)
        End If

        If chkvfullscreen.Checked Then
            AxVideoChatSender1.VirtualScreenCaptureFullScreen(True)

        Else
            AxVideoChatSender1.VirtualScreenCaptureFullScreen(False)
            AxVideoChatSender1.VirtualScreenCaptureArea(txtvleft.Text, txtvtop.Text, txtvwidth.Text, txtvheight.Text)
        End If

        AxVideoChatSender1.OverlayType = cboeffecttype.SelectedIndex

        Dim iresult As Integer
        iresult = AxVideoChatSender1.Connect(txtconnectIP.Text, Convert.ToInt32(txtConnectPortNo.Text))

        If cboeffecttype.SelectedIndex = 2 Then
            Me.ChatBannerControlEnable(True)
            ChatBannerAddMessage()

        End If

    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AxVideoChatSender1.Disconnect()
        AxVideoChatReceiver1.Disconnect()

        Form2.Close()
    End Sub
    Private Sub OverlayControlEnable(ByVal bEnable As Boolean)
        chkinvertcolor.Enabled = bEnable
        cborotate.Enabled = bEnable
        btnlightnessdefault.Enabled = bEnable
        chkgrayscale.Enabled = bEnable
        chklightness.Enabled = bEnable
        txtlightnessr.Enabled = bEnable
        txtlightnessg.Enabled = bEnable
        txtlightnessb.Enabled = bEnable
        btnlightnesschange.Enabled = bEnable
        btnoverlayimagedraw.Enabled = bEnable
        btnoverlayimagetranscolor.Enabled = bEnable
        txtoverlayimage.Enabled = bEnable
        txtoverlayimagealpha.Enabled = bEnable
        txtoverlayimagex.Enabled = bEnable
        txtoverlayimagey.Enabled = bEnable
        btnseloverlayimage.Enabled = bEnable
    End Sub
    Private Sub ChatBannerControlEnable(ByVal bEnable As Boolean)
        txtchat.Enabled = bEnable
        btnchatsend.Enabled = bEnable
        cbochatfont.Enabled = bEnable
        cbochatfontsize.Enabled = bEnable
        cbochatfontstyle.Enabled = bEnable
        cbochatstate.Enabled = bEnable
        chkchatfillbg.Enabled = bEnable
        cbochatdir.Enabled = Not bEnable
        txtchattextalpha.Enabled = bEnable
        btnfonttextcolor.Enabled = bEnable
        txtchatbgalpha.Enabled = bEnable
        btnfontbgcolor.Enabled = bEnable
        txtchatposx.Enabled = bEnable
        txtchatposy.Enabled = bEnable
        btnpos.Enabled = bEnable
        txtchatfadein.Enabled = bEnable
        txtchatfadeout.Enabled = bEnable
        btnfadetime.Enabled = bEnable
        txtchatspeed.Enabled = bEnable
        btnspeed.Enabled = bEnable
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iVideoCount As Integer
        Dim iAudioCount As Integer
        Dim i As Integer
        Dim strApp As String
        Dim iFindIndex As Integer

        Me.clrTranColor = Color.Black

        cboeffecttype.Items.Add("No Effects")
        cboeffecttype.Items.Add("Overlay Effects")
        cboeffecttype.Items.Add("Chat Banner Plugin")
        cboeffecttype.SelectedIndex = 0

        cbochatfont.Items.Add("Arial")
        cbochatfont.Items.Add("Impact")
        cbochatfont.Items.Add("Comic Sans MS")
        cbochatfont.Items.Add("Courier New")
        cbochatfont.SelectedIndex = 0

        For i = 8 To 80 Step 2
            cbochatfontsize.Items.Add(Trim(Str(i)))

        Next
        cbochatfontsize.SelectedIndex = 30

        cbochatfontstyle.Items.Add("Regular")
        cbochatfontstyle.Items.Add("Bold")
        cbochatfontstyle.Items.Add("Italic")
        cbochatfontstyle.SelectedIndex = 0

        cbochatstate.Items.Add("Scrolling Banner")
        cbochatstate.Items.Add("Stay")
        cbochatstate.Items.Add("Hide")
        cbochatstate.SelectedIndex = 0

        cbochatdir.Items.Add("Up")
        cbochatdir.Items.Add("Down")
        cbochatdir.Items.Add("Left")
        cbochatdir.Items.Add("Right")
        cbochatdir.SelectedIndex = 2


        cborotate.Items.Add("No Rotation")
        cborotate.Items.Add("90-degree rotation without flipping")
        cborotate.Items.Add("180-degree rotation without flipping")
        cborotate.Items.Add("270-degree rotation without flipping")
        cborotate.Items.Add("no rotation and a horizontal flip")
        cborotate.Items.Add("90-degree rotation followed by a horizontal flip")
        cborotate.Items.Add("180-degree rotation followed by a horizontal flip")
        cborotate.Items.Add("270-degree rotation followed by a horizontal flip")
        cborotate.Items.Add("no rotation and a vertical flip")
        cborotate.Items.Add("90-degree rotation followed by a vertical flip")
        cborotate.Items.Add("180-degree rotation followed by a vertical flip")
        cborotate.Items.Add("270-degree rotation followed by a vertical flip")
        cborotate.SelectedIndex = 0


        bClickChangeVideoFormat = False

        strApp = Application.ExecutablePath

        iFindIndex = strApp.IndexOf("Examples")

        If iFindIndex <> -1 Then
            strApp = strApp.Substring(0, iFindIndex) + "novideo.bmp"
            txtoverlayimage.Text = strApp.Substring(0, iFindIndex) + "image.bmp"
        End If

        TextBox1.Text = strApp

        iVideoCount = AxVideoChatSender1.GetVideoDeviceCount

        For i = 0 To iVideoCount - 1
            cbovideodevice.Items.Add(AxVideoChatSender1.GetVideoDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If

        iAudioCount = AxVideoChatSender1.GetAudioDeviceCount

        For i = 0 To iAudioCount - 1
            cboaudiodevice.Items.Add(AxVideoChatSender1.GetAudioDeviceName(i))
        Next

        If cboaudiodevice.Items.Count > 0 Then
            cboaudiodevice.SelectedIndex = 0
        End If

        cbovideoformat.Items.Add("160x120")
        cbovideoformat.Items.Add("176x144")
        cbovideoformat.Items.Add("320x240")
        cbovideoformat.Items.Add("352x288")
        cbovideoformat.Items.Add("640x480")
        cbovideoformat.Items.Add("1280x720")
        cbovideoformat.Items.Add("1920x1080")
        cbovideoformat.Items.Add("1920x1280")


        cbovideoformat.SelectedIndex = 4



        cboaudiocomplex.Items.Add("0")
        cboaudiocomplex.Items.Add("1")
        cboaudiocomplex.Items.Add("2")
        cboaudiocomplex.Items.Add("3")
        cboaudiocomplex.SelectedIndex = 0


        For i = 0 To 10
            cboaudioquality.Items.Add(i.ToString())

        Next


        cboaudioquality.SelectedIndex = 8




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxVideoChatSender1.Disconnect()
        ChatBannerControlEnable(False)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim bResult As Boolean
        If CheckBox2.Checked Then
            AxVideoChatReceiver1.VideoWindowAutoMax = True
        Else
            AxVideoChatReceiver1.VideoWindowAutoMax = False
        End If

        If RadioAspectRatio1.Checked Then
            AxVideoChatReceiver1.VideoWindowAspectRatio = 0
        ElseIf RadioAspectRatio2.Checked Then

            AxVideoChatReceiver1.VideoWindowAspectRatio = 1
        ElseIf RadioAspectRatio3.Checked Then
            AxVideoChatReceiver1.VideoWindowAspectRatio = 2
        End If


        If RadioButton1.Checked Then

            AxVideoChatReceiver1.CaptureFileType = 0
        Else
            AxVideoChatReceiver1.CaptureFileType = 1

        End If
        If ChkCaptureToFile.Checked Then
            If Me.FolderBrowserDialog1.ShowDialog() Then
                AxVideoChatReceiver1.CaptureMode = True
                AxVideoChatReceiver1.CaptureOutputFolder = Me.FolderBrowserDialog1.SelectedPath
            End If

            AxVideoChatReceiver1.CaptureMode = True

        Else
            AxVideoChatReceiver1.CaptureMode = False
        End If

        AxVideoChatReceiver1.MP4Width = Convert.ToInt32(txtmp4width.Text)
        AxVideoChatReceiver1.MP4Height = Convert.ToInt32(txtmp4height.Text)
        AxVideoChatReceiver1.MP4AudioSamplerate = Convert.ToInt32(txtmp4audiosamplerate.Text)
        AxVideoChatReceiver1.MP4Videobitrate = Convert.ToInt32(txtmp4videobitrate.Text)
        AxVideoChatReceiver1.MP4Audiobitrate = Convert.ToInt32(txtmp4audiobitrate.Text)
        AxVideoChatReceiver1.MP4FrameRate = Convert.ToInt32(txtmp4framerate.Text)
        AxVideoChatReceiver1.MP4Audiochannel = Convert.ToInt32(txtaudiochannels.Text)

        AxVideoChatReceiver1.ReceiveAudioStream = chkreceivevideo.Checked
        AxVideoChatReceiver1.ReceiveVideoStream = chkreceivevideo.Checked
        AxVideoChatReceiver1.ReceiverVideoNoVideoImage(TextBox1.Text)

        AxVideoChatReceiver1.ConferenceNumber = Me.textConferenceNO.Text
        AxVideoChatReceiver1.ConferenceUserID = Me.textUserID.Text

        If txtPeertoPeerListenIP.Text <> "0" Then
            bResult = AxVideoChatReceiver1.Listen(txtPeertoPeerListenIP.Text, Convert.ToInt32(txtConnectPortNo.Text, 10))
        Else
            bResult = AxVideoChatReceiver1.Listen(txtconnectIP.Text, Convert.ToInt32(txtConnectPortNo.Text, 10))
        End If



        Me.Button3.Enabled = False
        Me.Button4.Enabled = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxVideoChatReceiver1.Disconnect()

        Me.Button3.Enabled = True
        Me.Button4.Enabled = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MessageBox.Show(AxVideoChatReceiver1.GetIPAddress().ToString())

    End Sub

    Private Sub AxVideoChatSender1_SendStream(ByVal sender As System.Object, ByVal e As AxVideoChatSenderLib._DvideochatEvents_SendStreamEvent) Handles AxVideoChatSender1.SendStream
        lblvideobitrate.Text = e.fVideoBitrate
        lblaudiobitrate.Text = e.fAudioBitrate
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        SaveFileDialog1.Filter = "JPG File (*.jpg)|*.jpg"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            AxVideoChatReceiver1.SnapShot(txtvideoindex.Text, SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub txtframerate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtframerate.TextChanged

    End Sub


    Private Sub cmdchangevirtualscreen_Click(sender As System.Object, e As System.EventArgs) Handles cmdchangevirtualscreen.Click

    End Sub



    Private Sub chkvfullscreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkvfullscreen.CheckedChanged
        If chkvfullscreen.Checked Then

            txtvleft.Enabled = False
            txtvtop.Enabled = False
            txtvwidth.Enabled = False
            txtvheight.Enabled = False

        Else
            txtvleft.Enabled = True
            txtvtop.Enabled = True
            txtvwidth.Enabled = True
            txtvheight.Enabled = True



        End If
    End Sub

    Private Sub chkvfullscreen_Click(sender As Object, e As System.EventArgs) Handles chkvfullscreen.Click

    End Sub



    Private Sub cbovideodevice_Click(sender As Object, e As System.EventArgs) Handles cbovideodevice.Click


    End Sub


    Private Sub cbovideodevice_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged
        If cbovideodevice.Text = "Viscomsoft Virtual Screen Capture" Then
            cmdchangevirtualscreen.Enabled = True
            chkvfullscreen.Enabled = True

        Else
            cmdchangevirtualscreen.Enabled = False
            chkvfullscreen.Enabled = False
        End If
    End Sub

    Private Sub ChkCaptureToFile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkCaptureToFile.CheckedChanged

    End Sub

    Private Sub ChkCaptureToFile_Click(sender As Object, e As System.EventArgs) Handles ChkCaptureToFile.Click

        If ChkCaptureToFile.Checked Then
            txtmp4width.Enabled = True
            txtmp4height.Enabled = True
            txtmp4audiosamplerate.Enabled = True
            txtmp4videobitrate.Enabled = True
            txtmp4audiobitrate.Enabled = True
            txtmp4framerate.Enabled = True
            txtaudiochannels.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True


        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False

            txtmp4width.Enabled = False
            txtmp4height.Enabled = False
            txtmp4audiosamplerate.Enabled = False
            txtmp4videobitrate.Enabled = False
            txtmp4audiobitrate.Enabled = False
            txtmp4framerate.Enabled = False
            txtaudiochannels.Enabled = False



        End If
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        AxVideoChatReceiver1.ShowOneToOneMode(txtvideoindex.Text)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        AxVideoChatReceiver1.CloseOneToOneMode()
    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub cborotate_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cborotate.SelectedIndexChanged
        If cborotate.SelectedIndex = 1 Or cborotate.SelectedIndex = 3 Or cborotate.SelectedIndex = 5 Or cborotate.SelectedIndex = 7 Or cborotate.SelectedIndex = 11 Then
            If chkinvertcolor.Checked Then
                MessageBox.Show("You selected rotate value cannot support invert color")
            End If

            If chkgrayscale.Checked Then
                MessageBox.Show("You selected rotate value cannot support grayscale")
            End If

        End If
        AxVideoChatSender1.Rotate(cborotate.SelectedIndex)
    End Sub

    Private Sub chkinvertcolor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkinvertcolor.CheckedChanged
        If chkinvertcolor.Checked Then
            AxVideoChatSender1.InvertColor(True)
        Else
            AxVideoChatSender1.InvertColor(False)
        End If
    End Sub

    Private Sub chkgrayscale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkgrayscale.CheckedChanged
        If chkgrayscale.Checked Then
            AxVideoChatSender1.GrayScale(True)
        Else
            AxVideoChatSender1.GrayScale(False)
        End If
    End Sub



    Private Sub btnlightnesschange_Click(sender As System.Object, e As System.EventArgs) Handles btnlightnesschange.Click
        AxVideoChatSender1.Lightness(txtlightnessr.Text, txtlightnessg.Text, txtlightnessb.Text)

    End Sub



    Private Sub btnlightnessdefault_Click(sender As System.Object, e As System.EventArgs) Handles btnlightnessdefault.Click
        AxVideoChatSender1.Lightness(-1, -1, -1)
        txtlightnessr.Text = -1
        txtlightnessg.Text = -1
        txtlightnessb.Text = -1
    End Sub



    Private Sub chklightness_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chklightness.CheckedChanged
        If chklightness.Checked Then

            txtlightnessr.Enabled = True
            txtlightnessg.Enabled = True
            txtlightnessb.Enabled = True
        Else
            txtlightnessr.Enabled = False
            txtlightnessg.Enabled = False
            txtlightnessb.Enabled = False

            AxVideoChatSender1.Lightness(-1, -1, -1)

            txtlightnessr.Text = -1
            txtlightnessg.Text = -1
            txtlightnessb.Text = -1

        End If
    End Sub

    Private Sub chkshowmousehighlight_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkshowmousehighlight.CheckedChanged

    End Sub
    Private Sub ChatBannerAddMessage()
        ChatBannerFillBG()

        ChatBannerState()
        AxVideoChatSender1.ChatBannerAddText(txtchat.Text)
    End Sub

    Private Sub btnchatsend_Click(sender As System.Object, e As System.EventArgs) Handles btnchatsend.Click


        ChatBannerAddMessage()
    End Sub



    Private Sub UpdateChatBannerFont()


        AxVideoChatSender1.ChatBannerSetFont(cbochatfont.Text, Val(cbochatfontsize.SelectedItem), cbochatfontstyle.SelectedIndex)

    End Sub



    Private Sub cbochatfont_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbochatfont.SelectedIndexChanged
        UpdateChatBannerFont()
    End Sub

    Private Sub cbochatfontsize_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbochatfontsize.SelectedIndexChanged
        UpdateChatBannerFont()
    End Sub

    Private Sub cbochatfontstyle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbochatfontstyle.SelectedIndexChanged
        UpdateChatBannerFont()
    End Sub

    Private Sub ChatBannerState()
        AxVideoChatSender1.ChatBannerState(Me.cbochatstate.SelectedIndex)
    End Sub
    Private Sub cbochatstate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbochatstate.SelectedIndexChanged
        ChatBannerState()

    End Sub

    Private Sub ChatBannerFillBG()
        If chkchatfillbg.Checked Then
            AxVideoChatSender1.ChatBannerFillBgColor(True)
        Else
            AxVideoChatSender1.ChatBannerFillBgColor(False)

        End If
    End Sub
    Private Sub chkchatfillbg_Click(sender As System.Object, e As System.EventArgs) Handles chkchatfillbg.Click
        ChatBannerFillBG()
    End Sub

    Private Sub btnpos_Click(sender As System.Object, e As System.EventArgs) Handles btnpos.Click
        AxVideoChatSender1.ChatBannerPos(txtchatposx.Text, txtchatposy.Text)
    End Sub

    Private Sub btnfonttextcolor_Click(sender As System.Object, e As System.EventArgs) Handles btnfonttextcolor.Click
        Using cd As New ColorDialog
            If cd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                AxVideoChatSender1.ChatBannerTextColor(cd.Color.R, cd.Color.G, cd.Color.B, txtchattextalpha.Text)
            End If
        End Using
    End Sub

    Private Sub btnfontbgcolor_Click(sender As System.Object, e As System.EventArgs) Handles btnfontbgcolor.Click
        Using cd As New ColorDialog
            If cd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                AxVideoChatSender1.ChatBannerBgColor(cd.Color.R, cd.Color.G, cd.Color.B, txtchatbgalpha.Text)
            End If
        End Using
    End Sub

    Private Sub btnfadetime_Click(sender As System.Object, e As System.EventArgs) Handles btnfadetime.Click
        AxVideoChatSender1.ChatBannerFadeEdge(txtchatfadein.Text, txtchatfadeout.Text)
    End Sub

    Private Sub btnspeed_Click(sender As System.Object, e As System.EventArgs) Handles btnspeed.Click
        AxVideoChatSender1.ChatBannerSpeed(txtchatspeed.Text)
    End Sub

    Private Sub cboeffecttype_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboeffecttype.SelectedIndexChanged

        If cboeffecttype.SelectedIndex = 0 Then
            OverlayControlEnable(False)
            ChatBannerControlEnable(False)
        End If

        If cboeffecttype.SelectedIndex = 1 Then
            OverlayControlEnable(True)
            ChatBannerControlEnable(False)
        End If


        If cboeffecttype.SelectedIndex = 2 Then
            OverlayControlEnable(False)
            ChatBannerControlEnable(True)
        End If
    End Sub

    Private Sub chkchatfillbg_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkchatfillbg.CheckedChanged

    End Sub

    Private Sub cbochatstate_Click(sender As System.Object, e As System.EventArgs) Handles cbochatstate.Click
        AxVideoChatSender1.ChatBannerState(Me.cbochatstate.SelectedIndex)
    End Sub

    Private Sub btnseloverlayimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseloverlayimage.Click
        OpenFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG File (*.jpg)|*.jpg|TIFF File (*.tif)|*.tif|PNG File (*.png)|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtoverlayimage.Text = OpenFileDialog1.FileName
            AxVideoChatSender1.SetOverlayImage(txtoverlayimage.Text)
            AxVideoChatSender1.SetOverlayImagePos(txtoverlayimagex.Text, txtoverlayimagey.Text)
        End If
    End Sub

    Private Sub btnoverlayimagetranscolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoverlayimagetranscolor.Click
        Using cd As New ColorDialog
            If cd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                clrTranColor = cd.Color
                AxVideoChatSender1.SetOverlayImageTransColor(cd.Color.R, cd.Color.G, cd.Color.B, txtoverlayimagealpha.Text)
            End If
        End Using

    End Sub

    Private Sub btnoverlayimagedraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoverlayimagedraw.Click
            AxVideoChatSender1.SetOverlayImage(txtoverlayimage.Text)
            AxVideoChatSender1.SetOverlayImagePos(txtoverlayimagex.Text, txtoverlayimagey.Text)
        AxVideoChatSender1.SetOverlayImageTransColor(clrTranColor.R, clrTranColor.G, clrTranColor.B, txtoverlayimagealpha.Text)

    End Sub
End Class
