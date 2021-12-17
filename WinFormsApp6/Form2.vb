Public Class Form2

    Function Printreceipt()
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        '------------------------------'
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If (TextBox1.Text > 0) Then
            e.Graphics.DrawString(NumericUpDown1.Value, NumericUpDown1.Font, Brushes.Blue, 100, 100)
            e.Graphics.DrawString("*", TextBox1.Font, Brushes.Blue, 100, 100)
            e.Graphics.DrawString(Label2.Text, Label2.Font, Brushes.Blue, 100, 100)
        End If

    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        TextBox8.Text = CInt(NumericUpDown8.Value) * 65
    End Sub
    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        TextBox7.Text = CInt(NumericUpDown7.Value) * 40
    End Sub
    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        TextBox6.Text = CInt(NumericUpDown6.Value) * 43
    End Sub
    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        TextBox5.Text = CInt(NumericUpDown5.Value) * 30
    End Sub
    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        TextBox4.Text = CInt(NumericUpDown4.Value) * 50
    End Sub
    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        TextBox3.Text = CInt(NumericUpDown3.Value) * 35
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        TextBox2.Text = CInt(NumericUpDown2.Value) * 70
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        TextBox1.Text = CInt(NumericUpDown1.Value) * 45
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Printreceipt()
    End Sub


End Class