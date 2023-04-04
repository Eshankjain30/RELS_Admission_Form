Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\RELS_Admission_Form\RELS_Admission_Form\Database.mdf;Integrated Security=True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim todayDate As Date = Today
        Label23.Text = todayDate.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Formn_No As Integer = txtForm.Text
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

        Dim stmt As String = "Insert into FormData(form no, first name, middle name, last name, dob, gender, aadhar no, father name, mother name, father occupation, mother occupation, father contact no, mother contact no, own contact, extra contact, address, area, admission in, course, school name, previous tuition, previous result 1, previous result 2, fees, mode, with form, remark) values ('" & Formn_No & "','" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & DOB & "','" & Gender & "','" & Aadhar_no & "','" & Father_Name & "','" & Mother_Name & "','" & Father_Occupation & "','" & Mother_Occupation & "','" & Father_Contact & "','" & Mother_Contact & "','" & Student_Contact & "','" & Extra_Contact & "','" & Address & "','" & Area & "','" & Admission & "','" & Course & "','" & School_Name & "','" & Previous_Tuition & "','" & PreviousYearResult1 & "','" & PreviousYearResult2 & "','" & Fees & "','" & Mode & "','" & With_Form & "','" & Remark & "';)"
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand(stmt, con)
        cmd.ExecuteNonQuery()
        MsgBox("Success")
        'MsgBox(Formn_No & vbNewLine & First_Name & vbNewLine & Middle_Name & vbNewLine & Last_Name & vbNewLine & DOB & vbNewLine & Gender & vbNewLine & Aadhar_no & vbNewLine & Father_Name & vbNewLine & Mother_Name & vbNewLine & Father_Occupation & vbNewLine & Mother_Occupation & vbNewLine & Father_Contact & vbNewLine & Mother_Contact & vbNewLine & Student_Contact & vbNewLine & Extra_Contact & vbNewLine & Address & vbNewLine & Area & vbNewLine & Admission & vbNewLine & Course & vbNewLine & School_Name & vbNewLine & Previous_Tuition & vbNewLine & PreviousYearResult1 & vbNewLine & PreviousYearResult2 & vbNewLine & Fees & vbNewLine & Mode & vbNewLine & With_Form & vbNewLine & Remark)
    End Sub
End Class
