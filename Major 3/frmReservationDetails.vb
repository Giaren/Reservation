Public Class frmReservationDetails
    Private Sub frmReservationDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listboxZoneConfig = "{0,-14} {1,-14} {2,-13} {3,-10} {4,-14} {5,-12} {6,-10} {7,-14} {8,-13} {9,-8} {10,-9} {11,-12} {12,-8} {13,-12} {14,-12} {15,-12} "
        lstReservations.Items.Add(String.Format(listboxZoneConfig, "Customer", "Destination", "Destination", "Departure", "Accomodations", "Accomodations", "Lunch", "Dinner", "Breakfast", " Bar", "Fishing", "Canoeing", "Sking", "Snorkeling", "Sightseeing", "Grand"))
        lstReservations.Items.Add(String.Format(listboxZoneConfig, "        ", "           ", "  price", "          ", "             ", "     Price", "      ", "      ", "        ", "price", "        ", "        ", "     ", "            ", "        ", "total"))
    End Sub

    Private Sub lstReservations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReservations.SelectedIndexChanged

    End Sub

    Private Sub btnNewReservation_Click(sender As Object, e As EventArgs) Handles btnNewReservation.Click
        Me.Hide()
        frmQCCTravelTours.Show()
        frmQCCTravelTours.txtCustomer.Text = String.Empty
        frmQCCTravelTours.radAMDepart.Checked = False
        frmQCCTravelTours.radPMDepart.Checked = False
        frmQCCTravelTours.radLuxuryCabin.Checked = False
        frmQCCTravelTours.radStandardCabin.Checked = False
        frmQCCTravelTours.radDestCostaRica.Checked = False
        frmQCCTravelTours.radDestBahamas.Checked = False
        frmQCCTravelTours.radDestBarbados.Checked = False
        frmQCCTravelTours.radDestBeliz.Checked = False
        frmQCCTravelTours.radDestJamaica.Checked = False
        frmQCCTravelTours.radPayAtBar.Checked = False
        frmQCCTravelTours.radPrePayBar.Checked = False
        frmQCCTravelTours.chkDinner.Checked = False
        frmQCCTravelTours.chkLunch.Checked = False
        frmQCCTravelTours.chkBreakfast.Checked = False
        frmQCCTravelTours.chkCanoeing.Checked = False
        frmQCCTravelTours.chkFishing.Checked = False
        frmQCCTravelTours.chkSightseeing.Checked = False
        frmQCCTravelTours.chkSkiing.Checked = False
        frmQCCTravelTours.chkSnorkeling.Checked = False
    End Sub

    Private Sub btnConfirmReservation_Click(sender As Object, e As EventArgs) Handles btnConfirmReservation.Click
        lstReservations.Items.Add(String.Format(listboxZoneConfig, lblCustomer.Text, lblDestination.Text, lblDestinationPrice.Text, lblDeparture.Text, lblRoom.Text, lblRoomPrice.Text, lblLunchPrice.Text, lblDinnerPrice.Text, lblBreakfastPrice.Text, lblBarPrice.Text, lblFishingPrice.Text, lblCanoeingPrice.Text, lblSkingPrice.Text, lblSnorkelingPrice.Text, lblSightseeingPrice.Text, lblReservationTotal.Text))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmQCCTravelTours.Show()
    End Sub

    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click
        'clear listbox
        lstReservations.Items.Clear()

        'reset listbox headings
        lstReservations.Items.Add(String.Format(listboxZoneConfig, "Customer", "Destination", "Destination", "Departure", "Accomodations", "Accomodations Price", "Lunch", "Dinner", "Breakfast", "Bar", "Bar price", "Fishing", "Canoeing", "   Sking", "Snorkeling", "Sightseeing", "Grand"))
        lstReservations.Items.Add(String.Format(listboxZoneConfig, "        ", "           ", "  price", "          ", "             ", "        Price", "      ", "      ", "        ", "         ", "    price", "        ", "        ", "     ", "            ", "          ", "  Total"))
        lblCustomer.Text = String.Empty
        lblReservationTotal.Text = String.Empty
        lblBar.Text = String.Empty
        lblBarPrice.Text = String.Empty
        lblBreakfast.Text = String.Empty
        lblBreakfastPrice.Text = String.Empty
        lblLunch.Text = String.Empty
        lblLunchPrice.Text = String.Empty
        lblDinner.Text = String.Empty
        lblDinnerPrice.Text = String.Empty
        lblCanoeing.Text = String.Empty
        lblCanoeingPrice.Text = String.Empty
        lblSking.Text = String.Empty
        lblSkingPrice.Text = String.Empty
        lblSightseeing.Text = String.Empty
        lblSightseeingPrice.Text = String.Empty
        lblSnorkeling.Text = String.Empty
        lblSnorkelingPrice.Text = String.Empty
        lblFishing.Text = String.Empty
        lblFishingPrice.Text = String.Empty
        lblRoom.Text = String.Empty
        lblRoomPrice.Text = String.Empty
        lblDeparture.Text = String.Empty
        lblDestination.Text = String.Empty
        lblDestinationPrice.Text = String.Empty

    End Sub
End Class