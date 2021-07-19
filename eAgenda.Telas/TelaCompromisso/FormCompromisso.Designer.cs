
namespace WindowsFormsApp2
{
    partial class FormCompromisso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVPassados = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGVFuturos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBoxLocal = new System.Windows.Forms.MaskedTextBox();
            this.cbContatos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPickerData = new System.Windows.Forms.DateTimePicker();
            this.textBoxAssunto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.MaskedTextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dtPassados = new System.Data.DataTable();
            this.dtFuturos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTerminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTerminoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickerTermino = new System.Windows.Forms.DateTimePicker();
            this.pickerInicio = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPassados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuturos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPassados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuturos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(101, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 308);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVPassados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos Passados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGVPassados
            // 
            this.dGVPassados.AutoGenerateColumns = false;
            this.dGVPassados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPassados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVPassados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVPassados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPassados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaTerminoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dGVPassados.DataMember = "dtPassados";
            this.dGVPassados.DataSource = this.dataSet1;
            this.dGVPassados.Location = new System.Drawing.Point(0, 0);
            this.dGVPassados.Name = "dGVPassados";
            this.dGVPassados.ReadOnly = true;
            this.dGVPassados.Size = new System.Drawing.Size(672, 279);
            this.dGVPassados.TabIndex = 0;
            this.dGVPassados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPassados_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGVFuturos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos Futuros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGVFuturos
            // 
            this.dGVFuturos.AutoGenerateColumns = false;
            this.dGVFuturos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVFuturos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVFuturos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVFuturos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFuturos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.assuntoDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1,
            this.horaInicioDataGridViewTextBoxColumn1,
            this.horaTerminoDataGridViewTextBoxColumn1,
            this.localDataGridViewTextBoxColumn1,
            this.linkDataGridViewTextBoxColumn1,
            this.contatoDataGridViewTextBoxColumn1});
            this.dGVFuturos.DataMember = "dtFuturos";
            this.dGVFuturos.DataSource = this.dataSet1;
            this.dGVFuturos.Location = new System.Drawing.Point(0, 0);
            this.dGVFuturos.Name = "dGVFuturos";
            this.dGVFuturos.ReadOnly = true;
            this.dGVFuturos.Size = new System.Drawing.Size(672, 282);
            this.dGVFuturos.TabIndex = 1;
            this.dGVFuturos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVFuturos_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(20, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 201);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(20, 160);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(557, 29);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocal.TabIndex = 22;
            // 
            // cbContatos
            // 
            this.cbContatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatos.FormattingEnabled = true;
            this.cbContatos.Location = new System.Drawing.Point(105, 67);
            this.cbContatos.Name = "cbContatos";
            this.cbContatos.Size = new System.Drawing.Size(121, 21);
            this.cbContatos.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data";
            // 
            // dataPickerData
            // 
            this.dataPickerData.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dataPickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPickerData.Location = new System.Drawing.Point(215, 29);
            this.dataPickerData.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dataPickerData.Name = "dataPickerData";
            this.dataPickerData.Size = new System.Drawing.Size(103, 20);
            this.dataPickerData.TabIndex = 17;
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(105, 29);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(100, 20);
            this.textBoxAssunto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Assunto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hora de Início";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hora de Término";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Local";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Link";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(663, 29);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(100, 20);
            this.textBoxLink.TabIndex = 33;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPassados,
            this.dtFuturos});
            // 
            // dtPassados
            // 
            this.dtPassados.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtPassados.TableName = "dtPassados";
            // 
            // dtFuturos
            // 
            this.dtFuturos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.dtFuturos.TableName = "dtFuturos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Data";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "HoraInicio";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "HoraTermino";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Local";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Link";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Contato";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Id";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Assunto";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Data";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "HoraInicio";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "HoraTermino";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Local";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Link";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Contato";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaTerminoDataGridViewTextBoxColumn
            // 
            this.horaTerminoDataGridViewTextBoxColumn.DataPropertyName = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn.HeaderText = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn.Name = "horaTerminoDataGridViewTextBoxColumn";
            this.horaTerminoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // assuntoDataGridViewTextBoxColumn1
            // 
            this.assuntoDataGridViewTextBoxColumn1.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn1.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn1.Name = "assuntoDataGridViewTextBoxColumn1";
            this.assuntoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn1
            // 
            this.horaInicioDataGridViewTextBoxColumn1.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn1.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn1.Name = "horaInicioDataGridViewTextBoxColumn1";
            this.horaInicioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // horaTerminoDataGridViewTextBoxColumn1
            // 
            this.horaTerminoDataGridViewTextBoxColumn1.DataPropertyName = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn1.HeaderText = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn1.Name = "horaTerminoDataGridViewTextBoxColumn1";
            this.horaTerminoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn1
            // 
            this.localDataGridViewTextBoxColumn1.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn1.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn1.Name = "localDataGridViewTextBoxColumn1";
            this.localDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn1
            // 
            this.linkDataGridViewTextBoxColumn1.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn1.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn1.Name = "linkDataGridViewTextBoxColumn1";
            this.linkDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // contatoDataGridViewTextBoxColumn1
            // 
            this.contatoDataGridViewTextBoxColumn1.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn1.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn1.Name = "contatoDataGridViewTextBoxColumn1";
            this.contatoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pickerTermino
            // 
            this.pickerTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerTermino.Location = new System.Drawing.Point(451, 29);
            this.pickerTermino.Name = "pickerTermino";
            this.pickerTermino.ShowUpDown = true;
            this.pickerTermino.Size = new System.Drawing.Size(100, 20);
            this.pickerTermino.TabIndex = 35;
            this.pickerTermino.Value = new System.DateTime(2021, 7, 19, 15, 0, 0, 0);
            // 
            // pickerInicio
            // 
            this.pickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerInicio.Location = new System.Drawing.Point(335, 29);
            this.pickerInicio.Name = "pickerInicio";
            this.pickerInicio.ShowUpDown = true;
            this.pickerInicio.Size = new System.Drawing.Size(100, 20);
            this.pickerInicio.TabIndex = 36;
            this.pickerInicio.Value = new System.DateTime(2021, 7, 19, 10, 0, 0, 0);
            // 
            // FormCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pickerInicio);
            this.Controls.Add(this.pickerTermino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbContatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPickerData);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.label1);
            this.Name = "FormCompromisso";
            this.Text = "FormCompromisso";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPassados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuturos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPassados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuturos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVPassados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox textBoxLocal;
        private System.Windows.Forms.ComboBox cbContatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataPickerData;
        private System.Windows.Forms.MaskedTextBox textBoxAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGVFuturos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textBoxLink;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtPassados;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataTable dtFuturos;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTerminoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DateTimePicker pickerTermino;
        private System.Windows.Forms.DateTimePicker pickerInicio;
    }
}