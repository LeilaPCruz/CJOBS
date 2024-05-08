<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ck_lembrar = New System.Windows.Forms.CheckBox()
        Me.btn_cadastrarcaminho = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_fechar2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 101)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ck_lembrar)
        Me.Panel1.Controls.Add(Me.btn_cadastrarcaminho)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(453, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 351)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(186, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Esqueceu sua senha?"
        '
        'ck_lembrar
        '
        Me.ck_lembrar.AutoSize = True
        Me.ck_lembrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ck_lembrar.ForeColor = System.Drawing.Color.DimGray
        Me.ck_lembrar.Location = New System.Drawing.Point(27, 193)
        Me.ck_lembrar.Name = "ck_lembrar"
        Me.ck_lembrar.Size = New System.Drawing.Size(114, 19)
        Me.ck_lembrar.TabIndex = 7
        Me.ck_lembrar.Text = "Lembrar de mim"
        Me.ck_lembrar.UseVisualStyleBackColor = True
        '
        'btn_cadastrarcaminho
        '
        Me.btn_cadastrarcaminho.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_cadastrarcaminho.FlatAppearance.BorderSize = 0
        Me.btn_cadastrarcaminho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrarcaminho.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrarcaminho.Location = New System.Drawing.Point(63, 296)
        Me.btn_cadastrarcaminho.Name = "btn_cadastrarcaminho"
        Me.btn_cadastrarcaminho.Size = New System.Drawing.Size(192, 32)
        Me.btn_cadastrarcaminho.TabIndex = 6
        Me.btn_cadastrarcaminho.Text = "CADASTRE-SE"
        Me.btn_cadastrarcaminho.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(94, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ainda não tem uma conta?"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(63, 233)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(192, 32)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "FAZER LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(22, 140)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(275, 29)
        Me.txt_senha.TabIndex = 3
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(22, 58)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(275, 29)
        Me.txt_email.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SENHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMAIL"
        '
        'btn_fechar2
        '
        Me.btn_fechar2.AutoSize = True
        Me.btn_fechar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_fechar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar2.ForeColor = System.Drawing.Color.White
        Me.btn_fechar2.Location = New System.Drawing.Point(807, 9)
        Me.btn_fechar2.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_fechar2.Name = "btn_fechar2"
        Me.btn_fechar2.Size = New System.Drawing.Size(20, 21)
        Me.btn_fechar2.TabIndex = 3
        Me.btn_fechar2.Text = "X"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 447)
        Me.Controls.Add(Me.btn_fechar2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cadastrarcaminho As Button
    Friend WithEvents ck_lembrar As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_fechar2 As Label
End Class
