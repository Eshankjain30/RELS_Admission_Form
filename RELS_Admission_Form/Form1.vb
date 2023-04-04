Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\RELS_Admission_Form\RELS_Admission_Form\Database.mdf;Integrated Security=True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        'Dim todayDate As Date = Today
        Label23.Text = todaysdate.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Form_No As String = txtForm.Text
        Dim First_Name As String = txtFirstName.Text
        Dim Middle_Name As String = txtMiddleName.Text
        Dim Last_Name As String = txtLastName.Text
        Dim DOB As String = dtDOB.Text
        Dim Gender As String = cbGender.Text
        Dim Aadhar_no As String = txtAadhar.Text
        Dim Father_Name As String = txtFatherName.Text
        Dim Mother_Name As String = txtMotherName.Text
        Dim Father_Occupation As String = txtFatherOccupation.Text
        Dim Mother_Occupation As String = txtMotherOccupation.Text
        Dim Father_Contact As String = txtFatherContact.Text
        Dim Mother_Contact As String = txtMotherContact.Text
        Dim Student_Contact As String = txtStudentContact.Text
        Dim Extra_Contact As String = txtExtraContact.Text
        Dim Address As String = txtAddress.Text
        Dim Area As String = txtArea.Text
        Dim Admission As String = txtAdmission.Text
        Dim Course As String = cbCourse.Text
        Dim School_Name As String = txtSchool.Text
        Dim Previous_Tuition As String = txtPreviousTuition.Text
        Dim PreviousYearResult1 As String = txtPreviousResult1.Text
        Dim PreviousYearResult2 As String = txtPreviousResult2.Text
        Dim Fees As String = txtFees.Text
        Dim Mode As String = cbMode.Text
        Dim With_Form As String = txtWithForm.Text
        Dim Remark As String = txtRemrk.Text

        If Form_No = "" Or First_Name = "" Or Middle_Name = "" Or Last_Name = "" Or DOB = "" Or Gender = "" Or Aadhar_no = "" Or Father_Name = "" Or Mother_Name = "" Or Father_Occupation = "" Or Mother_Occupation = "" Or Father_Contact = "" Or Mother_Contact = "" Or Student_Contact = "" Or Address = "" Or Area = "" Or Admission = "" Or Course = "" Or School_Name = "" Or Previous_Tuition = "" Or Fees = "" Or Mode = "" Or With_Form = "" Then
            MsgBox("Enter all the fields")
        Else
            'Try
            con.Open()
            Dim stmt As String = "Insert into FormData(form_no, first_name, middle_name, last_name, dob, gender, aadhar_no, father_name, mother_name, father_occupation, mother_occupation, father_contact_no, mother_contact_no, own_contact, extra_contact, address, area, admission_in, course, school_name, previous_tuition, previous_result_1, previous_result_2, fees, mode, with_form, remark) values ('" & Form_No & "','" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & DOB & "','" & Gender & "','" & Aadhar_no & "','" & Father_Name & "','" & Mother_Name & "','" & Father_Occupation & "','" & Mother_Occupation & "','" & Father_Contact & "','" & Mother_Contact & "','" & Student_Contact & "','" & Extra_Contact & "','" & Address & "','" & Area & "','" & Admission & "','" & Course & "','" & School_Name & "','" & Previous_Tuition & "','" & PreviousYearResult1 & "','" & PreviousYearResult2 & "','" & Fees & "','" & Mode & "','" & With_Form & "','" & Remark & "')"
            Dim cmd As SqlCommand
                cmd = New SqlCommand(stmt, con)
                cmd.ExecuteNonQuery()
                MsgBox("Success")
            'Catch ex As Exception
            MsgBox("Error")
            'Finally
            con.Close()
            'End Try
        End If


        'MsgBox(Formn_No & vbNewLine & First_Name & vbNewLine & Middle_Name & vbNewLine & Last_Name & vbNewLine & DOB & vbNewLine & Gender & vbNewLine & Aadhar_no & vbNewLine & Father_Name & vbNewLine & Mother_Name & vbNewLine & Father_Occupation & vbNewLine & Mother_Occupation & vbNewLine & Father_Contact & vbNewLine & Mother_Contact & vbNewLine & Student_Contact & vbNewLine & Extra_Contact & vbNewLine & Address & vbNewLine & Area & vbNewLine & Admission & vbNewLine & Course & vbNewLine & School_Name & vbNewLine & Previous_Tuition & vbNewLine & PreviousYearResult1 & vbNewLine & PreviousYearResult2 & vbNewLine & Fees & vbNewLine & Mode & vbNewLine & With_Form & vbNewLine & Remark)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtSearch.Text
        If search = "" Then
            MsgBox("Enter a value to be search")
        Else
            Try
                con.Open()
                Dim stmt As String = "SELECT * FROM FormData WHERE form_no = '" & search & "';"
                Dim cmd As SqlCommand
                Dim reader As SqlDataReader
                cmd = New SqlCommand(stmt, con)
                reader = cmd.ExecuteReader()
                While reader.Read
                    txtForm.Text = reader.GetValue(0)
                    txtFirstName.Text = reader.GetValue(1)
                    txtMiddleName.Text = reader.GetValue(2)
                    txtLastName.Text = reader.GetValue(3)
                    dtDOB.Text = reader.GetValue(4)
                    cbGender.Text = reader.GetValue(5)
                    txtAadhar.Text = reader.GetValue(6)
                    txtFatherName.Text = reader.GetValue(7)
                    txtMotherName.Text = reader.GetValue(8)
                    txtFatherOccupation.Text = reader.GetValue(9)
                    txtMotherOccupation.Text = reader.GetValue(10)
                    txtFatherContact.Text = reader.GetValue(11)
                    txtMotherContact.Text = reader.GetValue(12)
                    txtStudentContact.Text = reader.GetValue(13)
                    txtExtraContact.Text = reader.GetValue(14)
                    txtAddress.Text = reader.GetValue(15)
                    txtArea.Text = reader.GetValue(16)
                    txtAdmission.Text = reader.GetValue(17)
                    cbCourse.Text = reader.GetValue(18)
                    txtSchool.Text = reader.GetValue(19)
                    txtPreviousTuition.Text = reader.GetValue(20)
                    txtPreviousResult1.Text = reader.GetValue(21)
                    txtPreviousResult2.Text = reader.GetValue(22)
                    txtFees.Text = reader.GetValue(23)
                    cbMode.Text = reader.GetValue(24)
                    txtWithForm.Text = reader.GetValue(25)
                    txtRemrk.Text = reader.GetValue(26)
                End While
                MsgBox("Success")
            Catch ex As Exception
                MsgBox("Error")
            Finally
                con.Close()
            End Try

        End If
    End Sub
End Class
