Public Class Form1
    Dim dtViaturas As DataTable

    Private Function buscaDados(query As String) As DataTable
        Dim obj As DataBasesAccess = New DataBasesAccess()
        Dim sc As String = obj.ConnectionString()

        Return obj.BuscaDados(sc, query)

    End Function
    Private Sub atualizaGrid()
        Try

            Dim codViatura = dtViaturas.Rows(ComboBox1.SelectedIndex)("id")
            Dim queryViatura = "id=" + Convert.ToString(codViatura)

            If codViatura < 0 Then
                queryViatura = "1=1"
            End If


            DataGridView1.DataSource = buscaDados("select * from viatura where" + queryViatura + ";")


        Catch ex As Exception

        End Try

    End Sub


    Private Sub BtnCopiaBD_Click(sender As Object, e As EventArgs) Handles BtnCopiaBD.Click

        atualizaGrid()

    End Sub

    Private Sub BtnInserirNaBd_Click(sender As Object, e As EventArgs) Handles BtnInserirNaBd.Click

        buscaDados("insert into viatura (marca_viatura, dia_semana, quilometros) values( '" + TxtMarcaViatura.Text + "' , '" + TxtDiaSemana.Text + "' , '" + TxtQuilometragem.Text + "')")

        atualizaGrid()


    End Sub

    Private Sub BtnDeletaBD_Click(sender As Object, e As EventArgs) Handles BtnDeletaBD.Click

        buscaDados("delete from viatura where 1=1;")
        atualizaGrid()

    End Sub

    Private Sub BtnLimpaGrid_Click(sender As Object, e As EventArgs) Handles BtnLimpaGrid.Click


        For index = 0 To DataGridView1.Rows.Count - 2
            DataGridView1.Rows.RemoveAt(0)
        Next

        atualizaGrid()

    End Sub

    Private Sub BtnSomaKm_Click(sender As Object, e As EventArgs) Handles BtnSomaKm.Click

        'select SUM(quilometros) as total from viatura where marca_viatura= 'Fiat';

        Dim contagem = buscaDados("select SUM(quilometros) as total from viatura where marca_viatura='" + TxtSoma1.Text + "'").Rows(0)("total")

        TxtSoma2.Text = Convert.ToString(contagem)


    End Sub

    Private Sub BtnListBoxKm_Click(sender As Object, e As EventArgs) Handles BtnListBoxKm.Click

        'select marca_viatura from viatura where quilometros=(select MAX(quilometros) from viatura);
        Dim maxKm As DataTable

        maxKm = buscaDados("select marca_viatura from viatura where quilometros=(select MAX(quilometros) from viatura);")

        ListBox1.Items.Add(maxKm(0)(0))



    End Sub

    Private Sub BtnModificaRegisto_Click(sender As Object, e As EventArgs) Handles BtnModificaRegisto.Click
        ' buscaDados("update viatura set nome= '" + )


    End Sub

    Private Sub BtnContaViagens_Click(sender As Object, e As EventArgs) Handles BtnContaViagens.Click

        Dim contagem As Integer


        For index = 0 To DataGridView1.Rows.Count - 2

            Dim row = DataGridView1.Rows(index)


            If row.Cells("marca_viatura").Value = TxtViatura.Text And row.Cells("dia_semana").Value = 2 Then


                contagem = contagem + 1

            End If

        Next

        TxtTotalViagens.Text = contagem

    End Sub

    Private Sub BtnRemoverViagem_Click(sender As Object, e As EventArgs) Handles BtnRemoverViagem.Click

        buscaDados("delete from viatura where id=" + TxtEliminaViagem.Text)
        atualizaGrid()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try

            dtViaturas = buscaDados("select * from viatura")
            ComboBox1.DataSource = dtViaturas
            ComboBox1.DisplayMember = "marca_viatura"
            ComboBox1.ValueMember = "id"

            'adicionar todos

            Dim dr As DataRow = dtViaturas.NewRow()

            dr("marca_viatura") = "Todos"
            dr("id") = -1

            dtViaturas.Rows.Add(dr)

            DataGridView1.DataSource = buscaDados("select * from viatura")
            ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1


        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        atualizaGrid()

    End Sub
End Class
