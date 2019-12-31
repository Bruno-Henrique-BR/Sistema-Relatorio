namespace App20_ProjetoFinal
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Sobrenome = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lv_Relatorio = new System.Windows.Forms.ListView();
            this.cl_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NovoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Anotacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Valor = new System.Windows.Forms.MaskedTextBox();
            this.gb_NovoCliente = new System.Windows.Forms.GroupBox();
            this.rb_Nao = new System.Windows.Forms.RadioButton();
            this.rb_Sim = new System.Windows.Forms.RadioButton();
            this.fb_Anotacao = new System.Windows.Forms.GroupBox();
            this.cb_AvisoPrevio = new System.Windows.Forms.CheckBox();
            this.cb_Condominio = new System.Windows.Forms.CheckBox();
            this.cb_HComercial = new System.Windows.Forms.CheckBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.gb_NovoCliente.SuspendLayout();
            this.fb_Anotacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label1.Location = new System.Drawing.Point(232, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Vendas BH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label2.Location = new System.Drawing.Point(123, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label3.Location = new System.Drawing.Point(536, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label4.Location = new System.Drawing.Point(55, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label5.Location = new System.Drawing.Point(55, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label6.Location = new System.Drawing.Point(55, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sobrenome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label7.Location = new System.Drawing.Point(55, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label8.Location = new System.Drawing.Point(55, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label9.Location = new System.Drawing.Point(474, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label10.Location = new System.Drawing.Point(474, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Anotações";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label11.Location = new System.Drawing.Point(474, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label12.Location = new System.Drawing.Point(474, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Novo Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label13.Location = new System.Drawing.Point(474, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Status:";
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.Indigo;
            this.tb_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ID.Location = new System.Drawing.Point(179, 120);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(114, 23);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPressiona_ID);
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.Color.Indigo;
            this.tb_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Nome.Location = new System.Drawing.Point(179, 150);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(114, 23);
            this.tb_Nome.TabIndex = 1;
            // 
            // tb_Sobrenome
            // 
            this.tb_Sobrenome.BackColor = System.Drawing.Color.Indigo;
            this.tb_Sobrenome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Sobrenome.Location = new System.Drawing.Point(179, 180);
            this.tb_Sobrenome.Name = "tb_Sobrenome";
            this.tb_Sobrenome.Size = new System.Drawing.Size(114, 23);
            this.tb_Sobrenome.TabIndex = 2;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Indigo;
            this.btn_Adicionar.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.btn_Adicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Adicionar.Location = new System.Drawing.Point(278, 313);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(225, 50);
            this.btn_Adicionar.TabIndex = 23;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.BotaoAdicionar);
            // 
            // lv_Relatorio
            // 
            this.lv_Relatorio.BackColor = System.Drawing.Color.Indigo;
            this.lv_Relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ID,
            this.cl_Nome,
            this.cl_Sobrenome,
            this.cl_Telefone,
            this.cl_CEP,
            this.cl_Status,
            this.cl_NovoCliente,
            this.cl_Valor,
            this.cl_Data,
            this.cl_Anotacao});
            this.lv_Relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_Relatorio.GridLines = true;
            this.lv_Relatorio.HideSelection = false;
            this.lv_Relatorio.Location = new System.Drawing.Point(7, 378);
            this.lv_Relatorio.Name = "lv_Relatorio";
            this.lv_Relatorio.Size = new System.Drawing.Size(767, 275);
            this.lv_Relatorio.TabIndex = 24;
            this.lv_Relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_Relatorio.View = System.Windows.Forms.View.Details;
            // 
            // cl_ID
            // 
            this.cl_ID.Text = "ID";
            this.cl_ID.Width = 44;
            // 
            // cl_Nome
            // 
            this.cl_Nome.Text = "Nome";
            this.cl_Nome.Width = 68;
            // 
            // cl_Sobrenome
            // 
            this.cl_Sobrenome.Text = "Sobrenome";
            this.cl_Sobrenome.Width = 79;
            // 
            // cl_Telefone
            // 
            this.cl_Telefone.Text = "Telefone";
            // 
            // cl_CEP
            // 
            this.cl_CEP.Text = "CEP";
            this.cl_CEP.Width = 57;
            // 
            // cl_Status
            // 
            this.cl_Status.Text = "Status";
            // 
            // cl_NovoCliente
            // 
            this.cl_NovoCliente.Text = "Novo Cliente";
            this.cl_NovoCliente.Width = 81;
            // 
            // cl_Valor
            // 
            this.cl_Valor.Text = "Valor";
            this.cl_Valor.Width = 64;
            // 
            // cl_Data
            // 
            this.cl_Data.Text = "Data";
            this.cl_Data.Width = 58;
            // 
            // cl_Anotacao
            // 
            this.cl_Anotacao.Text = "Anotações";
            this.cl_Anotacao.Width = 97;
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.BackColor = System.Drawing.Color.Indigo;
            this.mtb_Telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Telefone.Location = new System.Drawing.Point(179, 210);
            this.mtb_Telefone.Mask = "(00) 00000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(114, 23);
            this.mtb_Telefone.TabIndex = 3;
            // 
            // mtb_CEP
            // 
            this.mtb_CEP.BackColor = System.Drawing.Color.Indigo;
            this.mtb_CEP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_CEP.Location = new System.Drawing.Point(179, 240);
            this.mtb_CEP.Mask = "00000-000";
            this.mtb_CEP.Name = "mtb_CEP";
            this.mtb_CEP.Size = new System.Drawing.Size(114, 23);
            this.mtb_CEP.TabIndex = 4;
            // 
            // mtb_Valor
            // 
            this.mtb_Valor.BackColor = System.Drawing.Color.Indigo;
            this.mtb_Valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Valor.Location = new System.Drawing.Point(619, 180);
            this.mtb_Valor.Mask = "$ 00.00";
            this.mtb_Valor.Name = "mtb_Valor";
            this.mtb_Valor.Size = new System.Drawing.Size(114, 23);
            this.mtb_Valor.TabIndex = 7;
            // 
            // gb_NovoCliente
            // 
            this.gb_NovoCliente.Controls.Add(this.rb_Nao);
            this.gb_NovoCliente.Controls.Add(this.rb_Sim);
            this.gb_NovoCliente.Location = new System.Drawing.Point(619, 142);
            this.gb_NovoCliente.Name = "gb_NovoCliente";
            this.gb_NovoCliente.Size = new System.Drawing.Size(114, 33);
            this.gb_NovoCliente.TabIndex = 28;
            this.gb_NovoCliente.TabStop = false;
            // 
            // rb_Nao
            // 
            this.rb_Nao.AutoSize = true;
            this.rb_Nao.Location = new System.Drawing.Point(51, 10);
            this.rb_Nao.Name = "rb_Nao";
            this.rb_Nao.Size = new System.Drawing.Size(51, 19);
            this.rb_Nao.TabIndex = 6;
            this.rb_Nao.Text = "Não";
            this.rb_Nao.UseVisualStyleBackColor = true;
            // 
            // rb_Sim
            // 
            this.rb_Sim.AutoSize = true;
            this.rb_Sim.Checked = true;
            this.rb_Sim.Location = new System.Drawing.Point(8, 10);
            this.rb_Sim.Name = "rb_Sim";
            this.rb_Sim.Size = new System.Drawing.Size(50, 19);
            this.rb_Sim.TabIndex = 6;
            this.rb_Sim.TabStop = true;
            this.rb_Sim.Text = "Sim";
            this.rb_Sim.UseVisualStyleBackColor = true;
            // 
            // fb_Anotacao
            // 
            this.fb_Anotacao.Controls.Add(this.cb_AvisoPrevio);
            this.fb_Anotacao.Controls.Add(this.cb_Condominio);
            this.fb_Anotacao.Controls.Add(this.cb_HComercial);
            this.fb_Anotacao.Location = new System.Drawing.Point(619, 238);
            this.fb_Anotacao.Name = "fb_Anotacao";
            this.fb_Anotacao.Size = new System.Drawing.Size(114, 65);
            this.fb_Anotacao.TabIndex = 29;
            this.fb_Anotacao.TabStop = false;
            // 
            // cb_AvisoPrevio
            // 
            this.cb_AvisoPrevio.AutoSize = true;
            this.cb_AvisoPrevio.Location = new System.Drawing.Point(6, 44);
            this.cb_AvisoPrevio.Name = "cb_AvisoPrevio";
            this.cb_AvisoPrevio.Size = new System.Drawing.Size(106, 19);
            this.cb_AvisoPrevio.TabIndex = 11;
            this.cb_AvisoPrevio.Text = "Aviso Prévio";
            this.cb_AvisoPrevio.UseVisualStyleBackColor = true;
            // 
            // cb_Condominio
            // 
            this.cb_Condominio.AutoSize = true;
            this.cb_Condominio.Location = new System.Drawing.Point(6, 27);
            this.cb_Condominio.Name = "cb_Condominio";
            this.cb_Condominio.Size = new System.Drawing.Size(104, 19);
            this.cb_Condominio.TabIndex = 10;
            this.cb_Condominio.Text = "Condomínio";
            this.cb_Condominio.UseVisualStyleBackColor = true;
            // 
            // cb_HComercial
            // 
            this.cb_HComercial.AutoSize = true;
            this.cb_HComercial.Location = new System.Drawing.Point(3, 10);
            this.cb_HComercial.Name = "cb_HComercial";
            this.cb_HComercial.Size = new System.Drawing.Size(111, 19);
            this.cb_HComercial.TabIndex = 9;
            this.cb_HComercial.Text = "H. Comercial";
            this.cb_HComercial.UseVisualStyleBackColor = true;
            // 
            // cb_Status
            // 
            this.cb_Status.BackColor = System.Drawing.Color.Indigo;
            this.cb_Status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ag. Pagamento",
            "Pago",
            "Ag. Envio",
            "Enviado",
            "Finalizado"});
            this.cb_Status.Location = new System.Drawing.Point(619, 121);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(114, 23);
            this.cb_Status.TabIndex = 5;
            // 
            // dtp_Data
            // 
            this.dtp_Data.CalendarTrailingForeColor = System.Drawing.Color.Indigo;
            this.dtp_Data.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(619, 212);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(114, 22);
            this.dtp_Data.TabIndex = 8;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(782, 702);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.fb_Anotacao);
            this.Controls.Add(this.gb_NovoCliente);
            this.Controls.Add(this.mtb_Valor);
            this.Controls.Add(this.mtb_CEP);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.lv_Relatorio);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_Sobrenome);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaPrincipal";
            this.Text = "Relatório Básico de Vendas";
            this.Load += new System.EventHandler(this.JanelaPrincipal_Load);
            this.gb_NovoCliente.ResumeLayout(false);
            this.gb_NovoCliente.PerformLayout();
            this.fb_Anotacao.ResumeLayout(false);
            this.fb_Anotacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Sobrenome;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ListView lv_Relatorio;
        private System.Windows.Forms.ColumnHeader cl_ID;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Sobrenome;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_CEP;
        private System.Windows.Forms.ColumnHeader cl_Status;
        private System.Windows.Forms.ColumnHeader cl_NovoCliente;
        private System.Windows.Forms.ColumnHeader cl_Valor;
        private System.Windows.Forms.ColumnHeader cl_Data;
        private System.Windows.Forms.ColumnHeader cl_Anotacao;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.MaskedTextBox mtb_CEP;
        private System.Windows.Forms.MaskedTextBox mtb_Valor;
        private System.Windows.Forms.GroupBox gb_NovoCliente;
        private System.Windows.Forms.RadioButton rb_Nao;
        private System.Windows.Forms.RadioButton rb_Sim;
        private System.Windows.Forms.GroupBox fb_Anotacao;
        private System.Windows.Forms.CheckBox cb_AvisoPrevio;
        private System.Windows.Forms.CheckBox cb_Condominio;
        private System.Windows.Forms.CheckBox cb_HComercial;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}

