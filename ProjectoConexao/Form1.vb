
'Primeiro realizar a importacao do MySqlClient no Form da aplicacao'
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String
    Private dt As New DataTable

    'o metodo fillTable vai preencher a DataGridView sempre que for chamado'
    Private Sub fillTable()
        Try
            'criando a conexao com a base de dados'
            'Server - nome do servidor; Database - nome da base de dados'
            'uid - nome do utilizador ; pwd - password; '
            Conexao = New MySqlConnection("Server=localhost;Database=conexao;uid=root;pwd=;")
            strSQL = "SELECT * FROM clinete"

            da = New MySqlDataAdapter(strSQL, Conexao)
            da.Fill(dt)
            dtv_clientes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexao.Close()
            Conexao = Nothing
            comando = Nothing
        Finally
        End Try

    End Sub

    'preencher a tabela logo que o formulario for carregado'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillTable()
    End Sub




    'Adicionar novo registo na base de dados'
    Private Sub btnregistar_Click(sender As Object, e As EventArgs) Handles btnregistar.Click
        Try
            Conexao = New MySqlConnection("Server=localhost;Database=conexao;uid=root;pwd=;")
            strSQL = "INSERT INTO clinete(nome,	apelido, telefone) VALUES(@nome, @apelido, @telefone)"

            comando = New MySqlCommand(strSQL, Conexao)
            comando.Parameters.AddWithValue("@nome", txtnome.Text)
            comando.Parameters.AddWithValue("@apelido", txtapelido.Text)
            comando.Parameters.AddWithValue("@telefone", txttelefone.Text)
            Conexao.Open()
            comando.ExecuteNonQuery()
            fillTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conexao.Close()
            Conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    'Procurar um registo atraveis do ID'
    Private Sub btnprocurar_Click(sender As Object, e As EventArgs) Handles btnprocurar.Click
        Try
            Conexao = New MySqlConnection("Server=localhost;Database=conexao;uid=root;pwd=;")
            strSQL = "SELECT * FROM clinete where id = @id"

            comando = New MySqlCommand(strSQL, Conexao)
            comando.Parameters.AddWithValue("@id", txtprocurar.Text)
            Conexao.Open()
            dr = comando.ExecuteReader()
            Do While dr.Read
                txtnome.Text = dr("nome")
                txtapelido.Text = dr("apelido")
                txttelefone.Text = dr("telefone")
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conexao.Close()
            Conexao = Nothing
            comando = Nothing
        End Try
    End Sub

End Class
