<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCCTravelTours
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radDestBahamas = New System.Windows.Forms.RadioButton()
        Me.radDestCostaRica = New System.Windows.Forms.RadioButton()
        Me.radDestBeliz = New System.Windows.Forms.RadioButton()
        Me.radDestJamaica = New System.Windows.Forms.RadioButton()
        Me.radDestBarbados = New System.Windows.Forms.RadioButton()
        Me.radAMDepart = New System.Windows.Forms.RadioButton()
        Me.radPayAtBar = New System.Windows.Forms.RadioButton()
        Me.radPrePayBar = New System.Windows.Forms.RadioButton()
        Me.radStandardCabin = New System.Windows.Forms.RadioButton()
        Me.radLuxuryCabin = New System.Windows.Forms.RadioButton()
        Me.chkSightseeing = New System.Windows.Forms.CheckBox()
        Me.chkSnorkeling = New System.Windows.Forms.CheckBox()
        Me.chkSkiing = New System.Windows.Forms.CheckBox()
        Me.chkCanoeing = New System.Windows.Forms.CheckBox()
        Me.chkFishing = New System.Windows.Forms.CheckBox()
        Me.grpDestination = New System.Windows.Forms.GroupBox()
        Me.radPMDepart = New System.Windows.Forms.RadioButton()
        Me.grpDeparture = New System.Windows.Forms.GroupBox()
        Me.grpAccomodation = New System.Windows.Forms.GroupBox()
        Me.grpBar = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDinner = New System.Windows.Forms.GroupBox()
        Me.chkDinner = New System.Windows.Forms.CheckBox()
        Me.chkLunch = New System.Windows.Forms.CheckBox()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.btnReservation_List = New System.Windows.Forms.Button()
        Me.grpDestination.SuspendLayout()
        Me.grpDeparture.SuspendLayout()
        Me.grpAccomodation.SuspendLayout()
        Me.grpBar.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.grpDinner.SuspendLayout()
        Me.SuspendLayout()
        '
        'radDestBahamas
        '
        Me.radDestBahamas.AutoSize = True
        Me.radDestBahamas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDestBahamas.Location = New System.Drawing.Point(6, 30)
        Me.radDestBahamas.Name = "radDestBahamas"
        Me.radDestBahamas.Size = New System.Drawing.Size(95, 24)
        Me.radDestBahamas.TabIndex = 1
        Me.radDestBahamas.TabStop = True
        Me.radDestBahamas.Text = "Bahamas"
        Me.radDestBahamas.UseVisualStyleBackColor = True
        '
        'radDestCostaRica
        '
        Me.radDestCostaRica.AutoSize = True
        Me.radDestCostaRica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDestCostaRica.Location = New System.Drawing.Point(6, 53)
        Me.radDestCostaRica.Name = "radDestCostaRica"
        Me.radDestCostaRica.Size = New System.Drawing.Size(105, 24)
        Me.radDestCostaRica.TabIndex = 2
        Me.radDestCostaRica.TabStop = True
        Me.radDestCostaRica.Text = "Costa Rica"
        Me.radDestCostaRica.UseVisualStyleBackColor = True
        '
        'radDestBeliz
        '
        Me.radDestBeliz.AutoSize = True
        Me.radDestBeliz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDestBeliz.Location = New System.Drawing.Point(6, 76)
        Me.radDestBeliz.Name = "radDestBeliz"
        Me.radDestBeliz.Size = New System.Drawing.Size(61, 24)
        Me.radDestBeliz.TabIndex = 3
        Me.radDestBeliz.TabStop = True
        Me.radDestBeliz.Text = "Beliz"
        Me.radDestBeliz.UseVisualStyleBackColor = True
        '
        'radDestJamaica
        '
        Me.radDestJamaica.AutoSize = True
        Me.radDestJamaica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDestJamaica.Location = New System.Drawing.Point(6, 99)
        Me.radDestJamaica.Name = "radDestJamaica"
        Me.radDestJamaica.Size = New System.Drawing.Size(86, 24)
        Me.radDestJamaica.TabIndex = 4
        Me.radDestJamaica.TabStop = True
        Me.radDestJamaica.Text = "Jamaica"
        Me.radDestJamaica.UseVisualStyleBackColor = True
        '
        'radDestBarbados
        '
        Me.radDestBarbados.AutoSize = True
        Me.radDestBarbados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDestBarbados.Location = New System.Drawing.Point(6, 122)
        Me.radDestBarbados.Name = "radDestBarbados"
        Me.radDestBarbados.Size = New System.Drawing.Size(96, 24)
        Me.radDestBarbados.TabIndex = 0
        Me.radDestBarbados.TabStop = True
        Me.radDestBarbados.Text = "Barbados"
        Me.radDestBarbados.UseVisualStyleBackColor = True
        '
        'radAMDepart
        '
        Me.radAMDepart.AutoSize = True
        Me.radAMDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAMDepart.Location = New System.Drawing.Point(10, 30)
        Me.radAMDepart.Name = "radAMDepart"
        Me.radAMDepart.Size = New System.Drawing.Size(127, 24)
        Me.radAMDepart.TabIndex = 0
        Me.radAMDepart.TabStop = True
        Me.radAMDepart.Text = "AM Departure"
        Me.radAMDepart.UseVisualStyleBackColor = True
        '
        'radPayAtBar
        '
        Me.radPayAtBar.AutoSize = True
        Me.radPayAtBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPayAtBar.Location = New System.Drawing.Point(8, 53)
        Me.radPayAtBar.Name = "radPayAtBar"
        Me.radPayAtBar.Size = New System.Drawing.Size(102, 24)
        Me.radPayAtBar.TabIndex = 1
        Me.radPayAtBar.TabStop = True
        Me.radPayAtBar.Text = "Pay At Bar"
        Me.radPayAtBar.UseVisualStyleBackColor = True
        '
        'radPrePayBar
        '
        Me.radPrePayBar.AutoSize = True
        Me.radPrePayBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePayBar.Location = New System.Drawing.Point(8, 30)
        Me.radPrePayBar.Name = "radPrePayBar"
        Me.radPrePayBar.Size = New System.Drawing.Size(106, 24)
        Me.radPrePayBar.TabIndex = 0
        Me.radPrePayBar.TabStop = True
        Me.radPrePayBar.Text = "PrePay Bar"
        Me.radPrePayBar.UseVisualStyleBackColor = True
        '
        'radStandardCabin
        '
        Me.radStandardCabin.AutoSize = True
        Me.radStandardCabin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandardCabin.Location = New System.Drawing.Point(9, 47)
        Me.radStandardCabin.Name = "radStandardCabin"
        Me.radStandardCabin.Size = New System.Drawing.Size(138, 24)
        Me.radStandardCabin.TabIndex = 0
        Me.radStandardCabin.TabStop = True
        Me.radStandardCabin.Text = "Standard Cabin"
        Me.radStandardCabin.UseVisualStyleBackColor = True
        '
        'radLuxuryCabin
        '
        Me.radLuxuryCabin.AutoSize = True
        Me.radLuxuryCabin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLuxuryCabin.Location = New System.Drawing.Point(9, 71)
        Me.radLuxuryCabin.Name = "radLuxuryCabin"
        Me.radLuxuryCabin.Size = New System.Drawing.Size(118, 24)
        Me.radLuxuryCabin.TabIndex = 1
        Me.radLuxuryCabin.TabStop = True
        Me.radLuxuryCabin.Text = "Luxury Cabin"
        Me.radLuxuryCabin.UseVisualStyleBackColor = True
        '
        'chkSightseeing
        '
        Me.chkSightseeing.AutoSize = True
        Me.chkSightseeing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSightseeing.Location = New System.Drawing.Point(16, 30)
        Me.chkSightseeing.Name = "chkSightseeing"
        Me.chkSightseeing.Size = New System.Drawing.Size(112, 24)
        Me.chkSightseeing.TabIndex = 0
        Me.chkSightseeing.Text = "Sightseeing"
        Me.chkSightseeing.UseVisualStyleBackColor = True
        '
        'chkSnorkeling
        '
        Me.chkSnorkeling.AutoSize = True
        Me.chkSnorkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSnorkeling.Location = New System.Drawing.Point(16, 53)
        Me.chkSnorkeling.Name = "chkSnorkeling"
        Me.chkSnorkeling.Size = New System.Drawing.Size(103, 24)
        Me.chkSnorkeling.TabIndex = 1
        Me.chkSnorkeling.Text = "Snorkeling"
        Me.chkSnorkeling.UseVisualStyleBackColor = True
        '
        'chkSkiing
        '
        Me.chkSkiing.AutoSize = True
        Me.chkSkiing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSkiing.Location = New System.Drawing.Point(16, 76)
        Me.chkSkiing.Name = "chkSkiing"
        Me.chkSkiing.Size = New System.Drawing.Size(71, 24)
        Me.chkSkiing.TabIndex = 2
        Me.chkSkiing.Text = "Skiing"
        Me.chkSkiing.UseVisualStyleBackColor = True
        '
        'chkCanoeing
        '
        Me.chkCanoeing.AutoSize = True
        Me.chkCanoeing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCanoeing.Location = New System.Drawing.Point(16, 99)
        Me.chkCanoeing.Name = "chkCanoeing"
        Me.chkCanoeing.Size = New System.Drawing.Size(96, 24)
        Me.chkCanoeing.TabIndex = 3
        Me.chkCanoeing.Text = "Canoeing"
        Me.chkCanoeing.UseVisualStyleBackColor = True
        '
        'chkFishing
        '
        Me.chkFishing.AutoSize = True
        Me.chkFishing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFishing.Location = New System.Drawing.Point(16, 122)
        Me.chkFishing.Name = "chkFishing"
        Me.chkFishing.Size = New System.Drawing.Size(79, 24)
        Me.chkFishing.TabIndex = 4
        Me.chkFishing.Text = "Fishing"
        Me.chkFishing.UseVisualStyleBackColor = True
        '
        'grpDestination
        '
        Me.grpDestination.Controls.Add(Me.radDestBarbados)
        Me.grpDestination.Controls.Add(Me.radDestJamaica)
        Me.grpDestination.Controls.Add(Me.radDestBeliz)
        Me.grpDestination.Controls.Add(Me.radDestCostaRica)
        Me.grpDestination.Controls.Add(Me.radDestBahamas)
        Me.grpDestination.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDestination.Location = New System.Drawing.Point(87, 198)
        Me.grpDestination.Name = "grpDestination"
        Me.grpDestination.Size = New System.Drawing.Size(125, 164)
        Me.grpDestination.TabIndex = 2
        Me.grpDestination.TabStop = False
        Me.grpDestination.Text = "Destinations"
        '
        'radPMDepart
        '
        Me.radPMDepart.AutoSize = True
        Me.radPMDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPMDepart.Location = New System.Drawing.Point(10, 53)
        Me.radPMDepart.Name = "radPMDepart"
        Me.radPMDepart.Size = New System.Drawing.Size(126, 24)
        Me.radPMDepart.TabIndex = 1
        Me.radPMDepart.TabStop = True
        Me.radPMDepart.Text = "PM Departure"
        Me.radPMDepart.UseVisualStyleBackColor = True
        '
        'grpDeparture
        '
        Me.grpDeparture.Controls.Add(Me.radAMDepart)
        Me.grpDeparture.Controls.Add(Me.radPMDepart)
        Me.grpDeparture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeparture.Location = New System.Drawing.Point(238, 198)
        Me.grpDeparture.Name = "grpDeparture"
        Me.grpDeparture.Size = New System.Drawing.Size(166, 98)
        Me.grpDeparture.TabIndex = 3
        Me.grpDeparture.TabStop = False
        Me.grpDeparture.Text = "Departure"
        '
        'grpAccomodation
        '
        Me.grpAccomodation.Controls.Add(Me.radLuxuryCabin)
        Me.grpAccomodation.Controls.Add(Me.radStandardCabin)
        Me.grpAccomodation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccomodation.Location = New System.Drawing.Point(239, 302)
        Me.grpAccomodation.Name = "grpAccomodation"
        Me.grpAccomodation.Size = New System.Drawing.Size(179, 101)
        Me.grpAccomodation.TabIndex = 4
        Me.grpAccomodation.TabStop = False
        Me.grpAccomodation.Text = "Room Accommodations"
        '
        'grpBar
        '
        Me.grpBar.Controls.Add(Me.radPrePayBar)
        Me.grpBar.Controls.Add(Me.radPayAtBar)
        Me.grpBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBar.Location = New System.Drawing.Point(421, 198)
        Me.grpBar.Name = "grpBar"
        Me.grpBar.Size = New System.Drawing.Size(154, 98)
        Me.grpBar.TabIndex = 5
        Me.grpBar.TabStop = False
        Me.grpBar.Text = "Bar"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkFishing)
        Me.GroupBox6.Controls.Add(Me.chkCanoeing)
        Me.GroupBox6.Controls.Add(Me.chkSkiing)
        Me.GroupBox6.Controls.Add(Me.chkSnorkeling)
        Me.GroupBox6.Controls.Add(Me.chkSightseeing)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(601, 198)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(170, 165)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Leisure Activities"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Customer:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 43)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "QCC Travel Tours"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 46)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Reservations"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReservation
        '
        Me.btnReservation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(102, 469)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(149, 40)
        Me.btnReservation.TabIndex = 8
        Me.btnReservation.Text = "&Make Reservation"
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(272, 469)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(149, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(442, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 40)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpDinner
        '
        Me.grpDinner.Controls.Add(Me.chkDinner)
        Me.grpDinner.Controls.Add(Me.chkLunch)
        Me.grpDinner.Controls.Add(Me.chkBreakfast)
        Me.grpDinner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDinner.Location = New System.Drawing.Point(425, 302)
        Me.grpDinner.Name = "grpDinner"
        Me.grpDinner.Size = New System.Drawing.Size(170, 129)
        Me.grpDinner.TabIndex = 7
        Me.grpDinner.TabStop = False
        Me.grpDinner.Text = "Dining Accommodations"
        '
        'chkDinner
        '
        Me.chkDinner.AutoSize = True
        Me.chkDinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDinner.Location = New System.Drawing.Point(13, 94)
        Me.chkDinner.Name = "chkDinner"
        Me.chkDinner.Size = New System.Drawing.Size(75, 24)
        Me.chkDinner.TabIndex = 2
        Me.chkDinner.Text = "Dinner"
        Me.chkDinner.UseVisualStyleBackColor = True
        '
        'chkLunch
        '
        Me.chkLunch.AutoSize = True
        Me.chkLunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLunch.Location = New System.Drawing.Point(13, 71)
        Me.chkLunch.Name = "chkLunch"
        Me.chkLunch.Size = New System.Drawing.Size(72, 24)
        Me.chkLunch.TabIndex = 1
        Me.chkLunch.Text = "Lunch"
        Me.chkLunch.UseVisualStyleBackColor = True
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBreakfast.Location = New System.Drawing.Point(13, 48)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(97, 24)
        Me.chkBreakfast.TabIndex = 0
        Me.chkBreakfast.Text = "Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'txtCustomer
        '
        Me.txtCustomer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(93, 150)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(251, 29)
        Me.txtCustomer.TabIndex = 1
        '
        'btnReservation_List
        '
        Me.btnReservation_List.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation_List.Location = New System.Drawing.Point(608, 469)
        Me.btnReservation_List.Name = "btnReservation_List"
        Me.btnReservation_List.Size = New System.Drawing.Size(149, 40)
        Me.btnReservation_List.TabIndex = 30
        Me.btnReservation_List.Text = "Reservations"
        Me.btnReservation_List.UseVisualStyleBackColor = True
        '
        'frmQCCTravelTours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 599)
        Me.Controls.Add(Me.btnReservation_List)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.grpDinner)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.grpBar)
        Me.Controls.Add(Me.grpAccomodation)
        Me.Controls.Add(Me.grpDeparture)
        Me.Controls.Add(Me.grpDestination)
        Me.Name = "frmQCCTravelTours"
        Me.Text = "QCC Travel Tours - Reservations"
        Me.grpDestination.ResumeLayout(False)
        Me.grpDestination.PerformLayout()
        Me.grpDeparture.ResumeLayout(False)
        Me.grpDeparture.PerformLayout()
        Me.grpAccomodation.ResumeLayout(False)
        Me.grpAccomodation.PerformLayout()
        Me.grpBar.ResumeLayout(False)
        Me.grpBar.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.grpDinner.ResumeLayout(False)
        Me.grpDinner.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radDestBahamas As System.Windows.Forms.RadioButton
    Friend WithEvents radDestCostaRica As System.Windows.Forms.RadioButton
    Friend WithEvents radDestBeliz As System.Windows.Forms.RadioButton
    Friend WithEvents radDestJamaica As System.Windows.Forms.RadioButton
    Friend WithEvents radDestBarbados As System.Windows.Forms.RadioButton
    Friend WithEvents radAMDepart As System.Windows.Forms.RadioButton
    Friend WithEvents radPayAtBar As System.Windows.Forms.RadioButton
    Friend WithEvents radPrePayBar As System.Windows.Forms.RadioButton
    Friend WithEvents radStandardCabin As System.Windows.Forms.RadioButton
    Friend WithEvents radLuxuryCabin As System.Windows.Forms.RadioButton
    Friend WithEvents chkSightseeing As System.Windows.Forms.CheckBox
    Friend WithEvents chkSnorkeling As System.Windows.Forms.CheckBox
    Friend WithEvents chkSkiing As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanoeing As System.Windows.Forms.CheckBox
    Friend WithEvents chkFishing As System.Windows.Forms.CheckBox
    Friend WithEvents grpDestination As GroupBox
    Friend WithEvents radPMDepart As RadioButton
    Friend WithEvents grpDeparture As GroupBox
    Friend WithEvents grpAccomodation As GroupBox
    Friend WithEvents grpBar As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReservation As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpDinner As GroupBox
    Friend WithEvents chkDinner As CheckBox
    Friend WithEvents chkLunch As CheckBox
    Friend WithEvents chkBreakfast As CheckBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents btnReservation_List As Button
End Class
