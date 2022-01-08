'Giancarlo Rengifo , CIS 152, Major 3 
Public Class frmQCCTravelTours
    Private bln_Exit As Boolean = True
    Private blnReservation As Boolean = True

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click

        Dim dblSnorkeling As Double
        Dim dblSkiing As Double
        Dim dblSightseeing As Double
        Dim dblFishing As Double
        Dim dblcanoeing As Double
        Dim dblDinnerPrice As Double
        Dim dblLunchPrice As Double
        Dim dblbreakfastPrice As Double
        Dim dblticket_price As Double
        Dim dblroom_accomodations As Double
        Dim dblprepayBarFee As Double
        Dim dblDinningAccomodations As Double
        Dim dblLeisureActivities As Double
        Dim dblReservationTotal As Double


        If radDestBahamas.Checked Then
            dblticket_price = 650
            strDestinationOUT = "Bahamas"
        ElseIf radDestBarbados.Checked Then
            dblticket_price = 950
            strDestinationOUT = "Barbaros"
        ElseIf radDestCostaRica.Checked Then
            dblticket_price = 800
            strDestinationOUT = "Costa Rica"
        ElseIf radDestJamaica.Checked Then
            dblticket_price = 900
            strDestinationOUT = "Jamaica"
        ElseIf radDestBeliz.Checked Then
            dblticket_price = 700
            strDestinationOUT = "Beliz"
        End If

        If radAMDepart.Checked Then
            strDepartureOut = "Am"
        ElseIf radPMDepart.Checked Then
            strDepartureOut = "Pm"
        End If

        Select Case True
            Case radStandardCabin.Checked
                strRoomNameOUT = "Standard Cabin"
                dblroom_accomodations = 200
            Case radLuxuryCabin.Checked
                strRoomNameOUT = "Luxury Cabin"
                dblroom_accomodations = 300
        End Select

        Select Case True
            Case radPrePayBar.Checked
                dblprepayBarFee = 250
                strBarAccomodationOUT = "Pre Pay Bar"
            Case radPayAtBar.Checked
                dblprepayBarFee = 0
                strBarAccomodationOUT = "Pay at Bar"

        End Select

        dblDinnerPrice = 0
        dblDinningAccomodations = 0
        If chkDinner.Checked Then
            dblDinnerPrice = 200
            dblDinningAccomodations = dblDinningAccomodations + dblDinnerPrice
        End If
        dblbreakfastPrice = 0
        If chkBreakfast.Checked Then
            dblbreakfastPrice = 75
            dblDinningAccomodations = dblDinningAccomodations + dblbreakfastPrice
        End If
        dblLunchPrice = 0
        If chkLunch.Checked Then
            dblLunchPrice = 125
            dblDinningAccomodations = dblDinningAccomodations + dblLunchPrice
        End If

        dblcanoeing = 0
        dblLeisureActivities = 0
        If chkCanoeing.Checked Then
            dblcanoeing = 50
            dblLeisureActivities = dblLeisureActivities + dblcanoeing
        End If
        dblFishing = 0
        If chkFishing.Checked Then
            dblFishing = 20
            dblLeisureActivities = dblLeisureActivities + dblFishing
        End If
        dblSightseeing = 0
        If chkSightseeing.Checked Then
            dblSightseeing = 40
            dblLeisureActivities = dblLeisureActivities + dblSightseeing
        End If
        dblSkiing = 0
        If chkSkiing.Checked Then

            dblSkiing = 30
            dblLeisureActivities = dblLeisureActivities + dblSkiing
        End If
        dblSnorkeling = 0
        If chkSnorkeling.Checked Then
            dblSnorkeling = 25
            dblLeisureActivities = dblLeisureActivities + dblSnorkeling
        End If

        dblReservationTotal = dblticket_price + dblroom_accomodations + dblprepayBarFee + dblDinningAccomodations + dblLeisureActivities


        strTicket_PriceOUT = dblticket_price.ToString("c2")
        strroom_accomodationsOUT = dblroom_accomodations.ToString("c2")
        strDinningAccomodationsOUT = dblDinningAccomodations.ToString("c2")
        strLeisureActivitiesOUT = dblLeisureActivities.ToString("c2")
        strPrePayBarFeeOUT = dblprepayBarFee.ToString("c2")
        strDinnerPriceOUT = dblDinnerPrice.ToString("c2")
        strLunchPriceOUT = dblLunchPrice.ToString("c2")
        strBreakFastPriceOUT = dblbreakfastPrice.ToString("c2")
        strSnorkelingOUT = dblSnorkeling.ToString("c2")
        strFishingOUT = dblFishing.ToString("c2")
        strSightseeingOUT = dblSightseeing.ToString("c2")
        strSkiingOUT = dblSkiing.ToString("c2")
        strcanoeingOUT = dblcanoeing.ToString("c2")
        strReservationTotalOUT = dblReservationTotal.ToString("c2")
        strCustomerName = txtCustomer.Text

        'Copy Output to reservation

        frmReservationDetails.lblCustomer.Text = strCustomerName
        frmReservationDetails.lblDeparture.Text = strDepartureOut
        frmReservationDetails.lblBreakfastPrice.Text = strBreakFastPriceOUT
        frmReservationDetails.lblDinnerPrice.Text = strDinnerPriceOUT
        frmReservationDetails.lblLunchPrice.Text = strLunchPriceOUT
        frmReservationDetails.lblRoom.Text = strRoomNameOUT
        frmReservationDetails.lblRoomPrice.Text = strroom_accomodationsOUT
        frmReservationDetails.lblSightseeingPrice.Text = strSightseeingOUT
        frmReservationDetails.lblCanoeingPrice.Text = strcanoeingOUT
        frmReservationDetails.lblFishingPrice.Text = strFishingOUT
        frmReservationDetails.lblSkingPrice.Text = strSkiingOUT
        frmReservationDetails.lblSnorkelingPrice.Text = strSnorkelingOUT
        frmReservationDetails.lblReservationTotal.Text = strReservationTotalOUT
        frmReservationDetails.lblBar.Text = strBarAccomodationOUT
        frmReservationDetails.lblBarPrice.Text = strPrePayBarFeeOUT
        frmReservationDetails.lblDestination.Text = strDestinationOUT
        frmReservationDetails.lblDestinationPrice.Text = strTicket_PriceOUT

        MsgBox("Reservation Saved, click Reservations Button to comfirm your reservation")

    End Sub

    Private Sub frmQCCTravelTours_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If radDestBahamas.Checked = True Then
            btnReservation.Enabled = True
        End If
    End Sub

    Private Sub btnReservation_List_Click(sender As Object, e As EventArgs) Handles btnReservation_List.Click
        Me.Hide()
        frmReservationDetails.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustomer.Text = String.Empty
        radAMDepart.Checked = False
        radPMDepart.Checked = False
        radLuxuryCabin.Checked = False
        radStandardCabin.Checked = False
        radDestCostaRica.Checked = False
        radDestBahamas.Checked = False
        radDestBarbados.Checked = False
        radDestBeliz.Checked = False
        radDestJamaica.Checked = False
        radPayAtBar.Checked = False
        radPrePayBar.Checked = False
        chkDinner.Checked = False
        chkLunch.Checked = False
        chkBreakfast.Checked = False
        chkCanoeing.Checked = False
        chkFishing.Checked = False
        chkSightseeing.Checked = False
        chkSkiing.Checked = False
        chkSnorkeling.Checked = False
    End Sub

    Private Sub txtCustomer_Enter(sender As Object, e As EventArgs) Handles txtCustomer.Enter

        txtCustomer.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        bln_Exit = True
        Me.Close()

    End Sub
    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter

        bln_Exit = False
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave

        bln_Exit = True
    End Sub

    Private Sub btnReservations_MouseEnter(sender As Object, e As EventArgs) Handles btnReservation.MouseEnter

        blnReservation = False
    End Sub

    Private Sub btnReservations_MouseLeave(sender As Object, e As EventArgs) Handles btnReservation.MouseLeave
        blnReservation = True
    End Sub
    Private Sub txtCustomer_Leave(sender As Object, e As EventArgs) Handles txtCustomer.Leave
        'customer Validation
        If bln_Exit = True AndAlso blnReservation = True Then
            If txtCustomer.Text = String.Empty Then
                MessageBox.Show("The customer name cannot be blank")
                txtCustomer.Focus()
            End If
        End If
    End Sub


    Private Sub txtCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomer.KeyPress
        ' suppress all characters that are not letters or blank space
        If (e.KeyChar < "A" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(32) Then
            e.Handled = True
            MessageBox.Show("Invalid Character; Name May Contain Only Letters And Space(s); Invalid Data Entry")
        End If
    End Sub
End Class

