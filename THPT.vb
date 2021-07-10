Imports System.IO
Public Class THPT


    Private Sub QLTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database4DataSet.TT_HS_chưa_đóng_học_phí_chính_1' table. You can move, or remove it, as needed.
        Me.TT_HS_chưa_đóng_học_phí_chính_1TableAdapter.Fill(Me.Database4DataSet.TT_HS_chưa_đóng_học_phí_chính_1)
        'TODO: This line of code loads data into the 'Database4DataSet.Thông_tin_đóng_học_phí' table. You can move, or remove it, as needed.
        Me.Thông_tin_đóng_học_phíTableAdapter.Fill(Me.Database4DataSet.Thông_tin_đóng_học_phí)
        'TODO: This line of code loads data into the 'Database4DataSet.TT__HS_đã_đóng_học_phí_chính' table. You can move, or remove it, as needed.
        Me.TT__HS_đã_đóng_học_phí_chínhTableAdapter.Fill(Me.Database4DataSet.TT__HS_đã_đóng_học_phí_chính)
        'TODO: This line of code loads data into the 'Database4DataSet.Điểm_TB_học_kỳ_2' table. You can move, or remove it, as needed.
        Me.Điểm_TB_học_kỳ_2TableAdapter.Fill(Me.Database4DataSet.Điểm_TB_học_kỳ_2)
        'TODO: This line of code loads data into the 'Database4DataSet.Điểm_TB_học_kỳ_1' table. You can move, or remove it, as needed.
        Me.Điểm_TB_học_kỳ_1TableAdapter.Fill(Me.Database4DataSet.Điểm_TB_học_kỳ_1)
        'TODO: This line of code loads data into the 'Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_2' table. You can move, or remove it, as needed.
        Me.Kết_quả_điểm_tổng_kết_môn_học_kỳ_2TableAdapter.Fill(Me.Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_2)
        'TODO: This line of code loads data into the 'Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_1' table. You can move, or remove it, as needed.
        Me.Kết_quả_điểm_tổng_kết_môn_học_kỳ_1TableAdapter.Fill(Me.Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_1)
        'TODO: This line of code loads data into the 'Database4DataSet.Thông_tin_phụ_huynh' table. You can move, or remove it, as needed.
        Me.Thông_tin_phụ_huynhTableAdapter.Fill(Me.Database4DataSet.Thông_tin_phụ_huynh)
        'TODO: This line of code loads data into the 'Database4DataSet.Thông_tin_học_sinh' table. You can move, or remove it, as needed.
        Me.Thông_tin_học_sinhTableAdapter.Fill(Me.Database4DataSet.Thông_tin_học_sinh)
        'TODO: This line of code loads data into the 'DatabaseDataSet.XU_LY_VI_PHAM' table. You can move, or remove it, as needed.

    End Sub

    '=============================================================================================================================='
    'Command_Thông tin học sinh' 'Done'
    'Thêm dòng'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ThôngTinHọcSinhBindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ThôngTinHọcSinhBindingSource.EndEdit()
        Thông_tin_học_sinhTableAdapter.Update(Database4DataSet.Thông_tin_học_sinh)
        MessageBox.Show("Thành công!", "Thông tin sách", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Tìm kiếm'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (RadioButton1.Checked = True) Then 'Mã học sinh'
            Try
                Dim cnt0 = ThôngTinHọcSinhBindingSource.Count
                Me.Thông_tin_học_sinhTableAdapter.Search(Me.Database4DataSet.Thông_tin_học_sinh, TextBox6.Text)
                If cnt0 = 0 Then
                    MessageBox.Show("Không tìm thấy mã học sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt0 = 1 Then
                    MessageBox.Show("Tìm thấy mã học sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy mã học sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf (RadioButton2.Checked = True) Then 'Tên học sinh'
            Try
                Dim cnt1 = ThôngTinHọcSinhBindingSource.Count
                Me.Thông_tin_học_sinhTableAdapter.SearchTENHS(Me.Database4DataSet.Thông_tin_học_sinh, TextBox6.Text)
                If cnt1 = 0 Then
                    MessageBox.Show("Không tìm thấy tên học sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt1 = 1 Then
                    MessageBox.Show("Tìm thấy tên học sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy tên học sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf (RadioButton3.Checked = True) Then 'Mã lớp'
            Try
                Dim cnt2 = ThôngTinHọcSinhBindingSource.Count
                Me.Thông_tin_học_sinhTableAdapter.SearchMALOP(Me.Database4DataSet.Thông_tin_học_sinh, TextBox6.Text)
                If cnt2 = 0 Then
                    MessageBox.Show("Không tìm thấy mã lớp " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt2 = 1 Then
                    MessageBox.Show("Tìm thấy mã lớp " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy mã lớp " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf (RadioButton4.Checked = True) Then 'Nơi sinh'
            Try
                Dim cnt3 = ThôngTinHọcSinhBindingSource.Count
                Me.Thông_tin_học_sinhTableAdapter.SearchNOISINH(Me.Database4DataSet.Thông_tin_học_sinh, TextBox6.Text)
                If cnt3 = 0 Then
                    MessageBox.Show("Không tìm thấy nơi sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt3 = 1 Then
                    MessageBox.Show("Tìm thấy nơi sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy nơi sinh " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else 'chưa chọn loại tìm kiếm'
            MessageBox.Show("Phải chọn loại tìm kiếm!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    'Xoá'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ThôngTinHọcSinhBindingSource.RemoveCurrent()

    End Sub
    'Trước'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ThôngTinHọcSinhBindingSource.MovePrevious()
    End Sub
    'Tiếp'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ThôngTinHọcSinhBindingSource.MoveNext()
    End Sub
    'Đầu'
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ThôngTinHọcSinhBindingSource.MoveFirst()
    End Sub
    'Cuối'
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ThôngTinHọcSinhBindingSource.MoveLast()
    End Sub

    '=============================================================================================================================='
    'Edit -> Copy'
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
        TextBox10.Copy()
        TextBox11.Copy()
        TextBox11.Copy()
        TextBox12.Copy()
        TextBox13.Copy()
        TextBox14.Copy()
        TextBox15.Copy()
        TextBox16.Copy()
        TextBox17.Copy()
        TextBox18.Copy()
        TextBox19.Copy()
        TextBox2.Copy()
        TextBox20.Copy()
        TextBox21.Copy()
        TextBox22.Copy()
        TextBox23.Copy()
        TextBox24.Copy()
        TextBox25.Copy()
        TextBox26.Copy()
        TextBox27.Copy()
        TextBox28.Copy()
        TextBox29.Copy()
        TextBox3.Copy()
        TextBox30.Copy()
        TextBox31.Copy()
        TextBox32.Copy()
        TextBox33.Copy()
        TextBox34.Copy()
        TextBox35.Copy()
        TextBox36.Copy()
        TextBox37.Copy()
        TextBox38.Copy()
        TextBox39.Copy()
        TextBox4.Copy()
        TextBox40.Copy()
        TextBox41.Copy()
        TextBox42.Copy()
        TextBox43.Copy()
        TextBox44.Copy()
        TextBox45.Copy()
        TextBox46.Copy()
        TextBox47.Copy()
        TextBox48.Copy()
        TextBox49.Copy()
        TextBox5.Copy()
        TextBox50.Copy()
        TextBox51.Copy()
        TextBox6.Copy()
        TextBox7.Copy()
        TextBox8.Copy()
        TextBox9.Copy()
    End Sub

    '=============================================================================================================================='
    'Edit -> Paste'
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
        TextBox10.Paste()
        TextBox11.Paste()
        TextBox11.Paste()
        TextBox12.Paste()
        TextBox13.Paste()
        TextBox14.Paste()
        TextBox15.Paste()
        TextBox16.Paste()
        TextBox17.Paste()
        TextBox18.Paste()
        TextBox19.Paste()
        TextBox2.Paste()
        TextBox20.Paste()
        TextBox21.Paste()
        TextBox22.Paste()
        TextBox23.Paste()
        TextBox24.Paste()
        TextBox25.Paste()
        TextBox26.Paste()
        TextBox27.Paste()
        TextBox28.Paste()
        TextBox29.Paste()
        TextBox3.Paste()
        TextBox30.Paste()
        TextBox31.Paste()
        TextBox32.Paste()
        TextBox33.Paste()
        TextBox34.Paste()
        TextBox35.Paste()
        TextBox36.Paste()
        TextBox37.Paste()
        TextBox38.Paste()
        TextBox39.Paste()
        TextBox4.Paste()
        TextBox40.Paste()
        TextBox41.Paste()
        TextBox42.Paste()
        TextBox43.Paste()
        TextBox44.Paste()
        TextBox45.Paste()
        TextBox46.Paste()
        TextBox47.Paste()
        TextBox48.Paste()
        TextBox49.Paste()
        TextBox5.Paste()
        TextBox50.Paste()
        TextBox51.Paste()
        TextBox6.Paste()
        TextBox7.Paste()
        TextBox8.Paste()
        TextBox9.Paste()

    End Sub

    '=============================================================================================================================='
    'Edit -> Cut'
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
        TextBox10.Cut()
        TextBox11.Cut()
        TextBox11.Cut()
        TextBox12.Cut()
        TextBox13.Cut()
        TextBox14.Cut()
        TextBox15.Cut()
        TextBox16.Cut()
        TextBox17.Cut()
        TextBox18.Cut()
        TextBox19.Cut()
        TextBox2.Cut()
        TextBox20.Cut()
        TextBox21.Cut()
        TextBox22.Cut()
        TextBox23.Cut()
        TextBox24.Cut()
        TextBox25.Cut()
        TextBox26.Cut()
        TextBox27.Cut()
        TextBox28.Cut()
        TextBox29.Cut()
        TextBox3.Cut()
        TextBox30.Cut()
        TextBox31.Cut()
        TextBox32.Cut()
        TextBox33.Cut()
        TextBox34.Cut()
        TextBox35.Cut()
        TextBox36.Cut()
        TextBox37.Cut()
        TextBox38.Cut()
        TextBox39.Cut()
        TextBox4.Cut()
        TextBox40.Cut()
        TextBox41.Cut()
        TextBox42.Cut()
        TextBox43.Cut()
        TextBox44.Cut()
        TextBox45.Cut()
        TextBox46.Cut()
        TextBox47.Cut()
        TextBox48.Cut()
        TextBox49.Cut()
        TextBox5.Cut()
        TextBox50.Cut()
        TextBox51.Cut()
        TextBox6.Cut()
        TextBox7.Cut()
        TextBox8.Cut()
        TextBox9.Cut()


    End Sub

    '=============================================================================================================================='
    'Edit -> Undo'
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click

        TextBox1.Undo()
        TextBox10.Undo()
        TextBox11.Undo()
        TextBox11.Undo()
        TextBox12.Undo()
        TextBox13.Undo()
        TextBox14.Undo()
        TextBox15.Undo()
        TextBox16.Undo()
        TextBox17.Undo()
        TextBox18.Undo()
        TextBox19.Undo()
        TextBox2.Undo()
        TextBox20.Undo()
        TextBox21.Undo()
        TextBox22.Undo()
        TextBox23.Undo()
        TextBox24.Undo()
        TextBox25.Undo()
        TextBox26.Undo()
        TextBox27.Undo()
        TextBox28.Undo()
        TextBox29.Undo()
        TextBox3.Undo()
        TextBox30.Undo()
        TextBox31.Undo()
        TextBox32.Undo()
        TextBox33.Undo()
        TextBox34.Undo()
        TextBox35.Undo()
        TextBox36.Undo()
        TextBox37.Undo()
        TextBox38.Undo()
        TextBox39.Undo()
        TextBox4.Undo()
        TextBox40.Undo()
        TextBox41.Undo()
        TextBox42.Undo()
        TextBox43.Undo()
        TextBox44.Undo()
        TextBox45.Undo()
        TextBox46.Undo()
        TextBox47.Undo()
        TextBox48.Undo()
        TextBox49.Undo()
        TextBox5.Undo()
        TextBox50.Undo()
        TextBox51.Undo()
        TextBox6.Undo()
        TextBox7.Undo()
        TextBox8.Undo()
        TextBox9.Undo()


    End Sub

    '=============================================================================================================================='
    'Command_Thông tin phụ huynh' 'Done'
    'Tìm kiếm'
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (RadioButton5.Checked = True) Then 'Tên phụ huynh'
            Try
                Dim cnt4 = ThôngTinPhụHuynhBindingSource.Count
                Me.Thông_tin_phụ_huynhTableAdapter.Search1(Me.Database4DataSet.Thông_tin_phụ_huynh, TextBox12.Text)
                If cnt4 = 0 Then
                    MessageBox.Show("Không tìm thấy phụ huynh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt4 = 1 Then
                    MessageBox.Show("Tìm thấy phụ huynh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy phụ huynh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf (RadioButton6.Checked = True) Then 'Tên học sinh'
            Try
                Dim cnt5 = ThôngTinPhụHuynhBindingSource.Count
                Me.Thông_tin_phụ_huynhTableAdapter.SearchTENHS(Me.Database4DataSet.Thông_tin_phụ_huynh, TextBox12.Text)
                If cnt5 = 0 Then
                    MessageBox.Show("Không tìm thấy học sinh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt5 = 1 Then
                    MessageBox.Show("Tìm thấy học sinh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy học sinh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf (RadioButton7.Checked = True) Then 'Nghề nghiệp'
            Try
                Dim cnt6 = ThôngTinPhụHuynhBindingSource.Count
                Me.Thông_tin_phụ_huynhTableAdapter.SearchNGHE(Me.Database4DataSet.Thông_tin_phụ_huynh, TextBox12.Text)
                If cnt6 = 0 Then
                    MessageBox.Show("Không tìm thấy học sinh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cnt6 = 1 Then
                    MessageBox.Show("Tìm thấy học sinh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tìm thấy học sinh " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else 'chưa chọn loại tìm kiếm'
            MessageBox.Show("Phải chọn loại tìm kiếm!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'Thêm dòng'
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ThôngTinPhụHuynhBindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ThôngTinPhụHuynhBindingSource.EndEdit()
        Thông_tin_phụ_huynhTableAdapter.Update(Database4DataSet.Thông_tin_phụ_huynh)
        MessageBox.Show("Thành công!", "Thông tin độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Xoá'
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ThôngTinPhụHuynhBindingSource.RemoveCurrent()
    End Sub
    'Trước'
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ThôngTinPhụHuynhBindingSource.MovePrevious()
    End Sub
    'Tiếp'
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ThôngTinPhụHuynhBindingSource.MoveNext()
    End Sub
    'Đầu'
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ThôngTinPhụHuynhBindingSource.MoveFirst()
    End Sub
    'Cuối'
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ThôngTinPhụHuynhBindingSource.MoveLast()
    End Sub

    'Điểm học kỳ I'
    'Thêm'
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.AddNew()

    End Sub
    'Lưu'
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.EndEdit()
        Kết_quả_điểm_tổng_kết_môn_học_kỳ_1TableAdapter.Update(Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_1)
        MessageBox.Show("Thành công!", "Thông tin độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    'Xoá'
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.RemoveCurrent()

    End Sub
    'Đầu'
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.MoveFirst()

    End Sub
    'Cuối'
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.MoveLast()

    End Sub
    'Trước'
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.MovePrevious()

    End Sub
    'Tiếp theo'
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.MoveNext()

    End Sub
    'Tìm kiếm'
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            Dim cnt7 = KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.Count
            Me.Kết_quả_điểm_tổng_kết_môn_học_kỳ_1TableAdapter.Search2(Me.Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_1, TextBox14.Text)
            If cnt7 = 0 Then
                MessageBox.Show("Không tìm thấy mã học sinh " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt7 = 1 Then
                MessageBox.Show("Tìm thấy mã học sinh " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã học sinh " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Điểm học kỳ II'
    'Thêm'
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.AddNew()

    End Sub
    'Lưu'
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.EndEdit()
        Kết_quả_điểm_tổng_kết_môn_học_kỳ_2TableAdapter.Update(Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_2)
        MessageBox.Show("Thành công!", "Thông tin độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Xoá'
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ1BindingSource.RemoveCurrent()

    End Sub
    'Đầu'
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.MoveFirst()

    End Sub
    'Cuối'
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.MoveLast()

    End Sub
    'Trước'
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.MovePrevious()

    End Sub
    'Tiếp'
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.MoveNext()

    End Sub
    'Tìm kiếm'
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Try
            Dim cnt3 = KếtQuảĐiểmTổngKếtMônHọcKỳ2BindingSource.Count
            Me.Kết_quả_điểm_tổng_kết_môn_học_kỳ_2TableAdapter.Search3(Me.Database4DataSet.Kết_quả_điểm_tổng_kết_môn_học_kỳ_2, TextBox22.Text)
            If cnt3 = 0 Then
                MessageBox.Show("Không tìm thấy mã học sinh " & TextBox22.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cnt3 = 1 Then
                MessageBox.Show("Tìm thấy mã học sinh " & TextBox22.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã học sinh " & TextBox22.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '======================================================================================================='
    'Học phí'
    'Thêm'
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Thông_tin_đóng_học_phíBindingSource.AddNew()

    End Sub
    'Lưu'
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Thông_tin_đóng_học_phíBindingSource.EndEdit()
        Thông_tin_đóng_học_phíTableAdapter.Update(Database4DataSet.Thông_tin_đóng_học_phí)
        MessageBox.Show("Thành công!", "Thông tin độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Xoá'
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Thông_tin_đóng_học_phíBindingSource.RemoveCurrent()

    End Sub
    'Đầu'
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Thông_tin_đóng_học_phíBindingSource.MoveFirst()

    End Sub
    'Cuối'
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Thông_tin_đóng_học_phíBindingSource.MoveLast()

    End Sub
    'Trước'
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Thông_tin_đóng_học_phíBindingSource.MovePrevious()

    End Sub
    'Tiếp theo'
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Thông_tin_đóng_học_phíBindingSource.MoveNext()

    End Sub
    'Tìm kiếm'
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Dim cnt8 = Thông_tin_đóng_học_phíBindingSource.Count
            Me.Thông_tin_đóng_học_phíTableAdapter.Search5(Me.Database4DataSet.Thông_tin_đóng_học_phí, TextBox13.Text)
            If cnt8 = 0 Then
                MessageBox.Show("Không tìm thấy mã học sinh " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cnt8 = 1 Then
                MessageBox.Show("Tìm thấy mã học sinh " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã học sinh " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Nút thoát'
    Private Sub THPT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub
    'Sao lưu'
    Private Sub SaoLưuPhụcHồiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaoLưuPhụcHồiToolStripMenuItem.Click
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog = vbOK Then
                File.Copy(Application.StartupPath & "\Database4.accdb", fbd.SelectedPath & "\Backup-" & Format(Now(), "dd-M-yyyy H-m-s") & ".accdb")
                MessageBox.Show("Sao lưu thành công!", "Sao lưu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Phụ hồi'
    Private Sub PhụHồiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhụHồiToolStripMenuItem.Click
        Try

            Dim restorefile As String = Application.StartupPath & "\Database4.accdb"

            Dim msgText As String

            OpenFileDialog1.Filter = "Access | *.accdb"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then

                msgText = "Bạn chắc chắn muốn phục hồi CSDL? Chương trình sẽ ghi đè lên dữ liệu đang có."

                If MessageBox.Show(msgText, "Restore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                    FileCopy(OpenFileDialog1.FileName, restorefile)
                    MessageBox.Show("Phục hồi thành công!", "Phục hồi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Thoát'
    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub LàmMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LàmMớiToolStripMenuItem.Click
        QLTV_Load(Me, New System.EventArgs)

    End Sub


End Class
