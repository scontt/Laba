namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.connection = new MySql.Data.MySqlClient.MySqlConnection();
            this.dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.command = new MySql.Data.MySqlClient.MySqlCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.cancelFilterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.animalNameTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.animalTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avgLifeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flyingAbilitiesTextBox = new System.Windows.Forms.TextBox();
            this.deleteCurrentRowButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.updateRowButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.changeCurrentRowButton = new System.Windows.Forms.Button();
            this.relation1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openEmpButton = new System.Windows.Forms.Button();
            this.redDateFilter = new System.Windows.Forms.Button();
            this.empCountFilter = new System.Windows.Forms.Button();
            this.empSalaryFilter = new System.Windows.Forms.Button();
            this.cancelQueryFilterButton = new System.Windows.Forms.Button();
            this.redDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.selectAnimalTypeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.selectRedDateTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.selectAvgLifeTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelSelectButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.csvImportButton = new System.Windows.Forms.Button();
            this.csvExportButton = new System.Windows.Forms.Button();
            this.xmlImportButton = new System.Windows.Forms.Button();
            this.xmlExportButton = new System.Windows.Forms.Button();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataTable1 = new System.Data.DataTable();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(789, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Table1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataAdapter
            // 
            this.dataAdapter.DeleteCommand = null;
            this.dataAdapter.InsertCommand = null;
            this.dataAdapter.SelectCommand = this.command;
            this.dataAdapter.UpdateCommand = this.command;
            // 
            // command
            // 
            this.command.CacheAge = 0;
            this.command.Connection = null;
            this.command.EnableCaching = false;
            this.command.Transaction = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 305);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(574, 650);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(203, 38);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(574, 694);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(9, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(184, 18);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите название животного";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(9, 63);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 38);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelSearchButton.Location = new System.Drawing.Point(103, 63);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(90, 38);
            this.cancelSearchButton.TabIndex = 9;
            this.cancelSearchButton.Text = "Отмена";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите класс животного";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterTextBox.Location = new System.Drawing.Point(7, 124);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(186, 18);
            this.filterTextBox.TabIndex = 10;
            this.filterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterTextBox_KeyPress);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(7, 151);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(90, 38);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Фильтрация";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // cancelFilterButton
            // 
            this.cancelFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelFilterButton.Location = new System.Drawing.Point(103, 151);
            this.cancelFilterButton.Name = "cancelFilterButton";
            this.cancelFilterButton.Size = new System.Drawing.Size(90, 38);
            this.cancelFilterButton.TabIndex = 13;
            this.cancelFilterButton.Text = "Отмена";
            this.cancelFilterButton.UseVisualStyleBackColor = true;
            this.cancelFilterButton.Click += new System.EventHandler(this.cancelFilterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Название";
            // 
            // animalNameTextBox
            // 
            this.animalNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalNameTextBox.Location = new System.Drawing.Point(9, 80);
            this.animalNameTextBox.Name = "animalNameTextBox";
            this.animalNameTextBox.Size = new System.Drawing.Size(159, 18);
            this.animalNameTextBox.TabIndex = 14;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertButton.Location = new System.Drawing.Point(9, 195);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(324, 30);
            this.insertButton.TabIndex = 16;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Класс";
            // 
            // animalTypeTextBox
            // 
            this.animalTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalTypeTextBox.Location = new System.Drawing.Point(9, 124);
            this.animalTypeTextBox.Name = "animalTypeTextBox";
            this.animalTypeTextBox.Size = new System.Drawing.Size(159, 18);
            this.animalTypeTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Максимальный вес";
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxWeightTextBox.Location = new System.Drawing.Point(9, 168);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(159, 18);
            this.maxWeightTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(172, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Цвет";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTextBox.Location = new System.Drawing.Point(174, 80);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(159, 18);
            this.colorTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(171, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "Дата занесения в Красную книгу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(171, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "Средняя продолжительность жизни";
            // 
            // avgLifeTextBox
            // 
            this.avgLifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgLifeTextBox.Location = new System.Drawing.Point(174, 168);
            this.avgLifeTextBox.Name = "avgLifeTextBox";
            this.avgLifeTextBox.Size = new System.Drawing.Size(159, 18);
            this.avgLifeTextBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(171, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "Летательные способности";
            // 
            // flyingAbilitiesTextBox
            // 
            this.flyingAbilitiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flyingAbilitiesTextBox.Location = new System.Drawing.Point(174, 36);
            this.flyingAbilitiesTextBox.Name = "flyingAbilitiesTextBox";
            this.flyingAbilitiesTextBox.Size = new System.Drawing.Size(159, 18);
            this.flyingAbilitiesTextBox.TabIndex = 27;
            // 
            // deleteCurrentRowButton
            // 
            this.deleteCurrentRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCurrentRowButton.Location = new System.Drawing.Point(11, 357);
            this.deleteCurrentRowButton.Name = "deleteCurrentRowButton";
            this.deleteCurrentRowButton.Size = new System.Drawing.Size(322, 30);
            this.deleteCurrentRowButton.TabIndex = 29;
            this.deleteCurrentRowButton.Text = "Удалить текущую запись";
            this.deleteCurrentRowButton.UseVisualStyleBackColor = true;
            this.deleteCurrentRowButton.Click += new System.EventHandler(this.deleteCurrentRowButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "Введите ID животного";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(9, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(159, 18);
            this.idTextBox.TabIndex = 30;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // updateRowButton
            // 
            this.updateRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateRowButton.Location = new System.Drawing.Point(11, 249);
            this.updateRowButton.Name = "updateRowButton";
            this.updateRowButton.Size = new System.Drawing.Size(322, 30);
            this.updateRowButton.TabIndex = 32;
            this.updateRowButton.Text = "Изменить запись по критерию";
            this.updateRowButton.UseVisualStyleBackColor = true;
            this.updateRowButton.Click += new System.EventHandler(this.updateRowButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRowButton.Location = new System.Drawing.Point(11, 321);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(322, 30);
            this.deleteRowButton.TabIndex = 33;
            this.deleteRowButton.Text = "Удалить запись по критерию";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // changeCurrentRowButton
            // 
            this.changeCurrentRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCurrentRowButton.Location = new System.Drawing.Point(11, 285);
            this.changeCurrentRowButton.Name = "changeCurrentRowButton";
            this.changeCurrentRowButton.Size = new System.Drawing.Size(322, 30);
            this.changeCurrentRowButton.TabIndex = 34;
            this.changeCurrentRowButton.Text = "Изменить текущую запись";
            this.changeCurrentRowButton.UseVisualStyleBackColor = true;
            this.changeCurrentRowButton.Click += new System.EventHandler(this.changeCurrentRowButton_Click);
            // 
            // relation1BindingSource
            // 
            this.relation1BindingSource.DataSource = this.bindingSource;
            // 
            // openEmpButton
            // 
            this.openEmpButton.Location = new System.Drawing.Point(272, 2);
            this.openEmpButton.Name = "openEmpButton";
            this.openEmpButton.Size = new System.Drawing.Size(75, 23);
            this.openEmpButton.TabIndex = 35;
            this.openEmpButton.Text = "Сотрудники";
            this.openEmpButton.UseVisualStyleBackColor = true;
            this.openEmpButton.Click += new System.EventHandler(this.openEmpButton_Click);
            // 
            // redDateFilter
            // 
            this.redDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redDateFilter.Location = new System.Drawing.Point(6, 19);
            this.redDateFilter.Name = "redDateFilter";
            this.redDateFilter.Size = new System.Drawing.Size(193, 38);
            this.redDateFilter.TabIndex = 36;
            this.redDateFilter.Text = "Фильтрация по Красной книге";
            this.redDateFilter.UseVisualStyleBackColor = true;
            this.redDateFilter.Click += new System.EventHandler(this.redDateFilter_Click);
            // 
            // empCountFilter
            // 
            this.empCountFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empCountFilter.Location = new System.Drawing.Point(6, 107);
            this.empCountFilter.Name = "empCountFilter";
            this.empCountFilter.Size = new System.Drawing.Size(193, 38);
            this.empCountFilter.TabIndex = 37;
            this.empCountFilter.Text = "Фильтрация по количеству ухаживающих";
            this.empCountFilter.UseVisualStyleBackColor = true;
            this.empCountFilter.Click += new System.EventHandler(this.empCountFilter_Click);
            // 
            // empSalaryFilter
            // 
            this.empSalaryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empSalaryFilter.Location = new System.Drawing.Point(6, 63);
            this.empSalaryFilter.Name = "empSalaryFilter";
            this.empSalaryFilter.Size = new System.Drawing.Size(193, 38);
            this.empSalaryFilter.TabIndex = 38;
            this.empSalaryFilter.Text = "Фильтрация по зарплате персонала";
            this.empSalaryFilter.UseVisualStyleBackColor = true;
            this.empSalaryFilter.Click += new System.EventHandler(this.empSalaryFilter_Click);
            // 
            // cancelQueryFilterButton
            // 
            this.cancelQueryFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelQueryFilterButton.Location = new System.Drawing.Point(6, 151);
            this.cancelQueryFilterButton.Name = "cancelQueryFilterButton";
            this.cancelQueryFilterButton.Size = new System.Drawing.Size(193, 38);
            this.cancelQueryFilterButton.TabIndex = 39;
            this.cancelQueryFilterButton.Text = "Отмена фильтрации";
            this.cancelQueryFilterButton.UseVisualStyleBackColor = true;
            this.cancelQueryFilterButton.Click += new System.EventHandler(this.cancelQueryFilterButton_Click);
            // 
            // redDateTextBox
            // 
            this.redDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redDateTextBox.Location = new System.Drawing.Point(174, 124);
            this.redDateTextBox.Name = "redDateTextBox";
            this.redDateTextBox.Size = new System.Drawing.Size(159, 18);
            this.redDateTextBox.TabIndex = 40;
            // 
            // selectAnimalTypeTextBox
            // 
            this.selectAnimalTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectAnimalTypeTextBox.Location = new System.Drawing.Point(6, 36);
            this.selectAnimalTypeTextBox.Name = "selectAnimalTypeTextBox";
            this.selectAnimalTypeTextBox.Size = new System.Drawing.Size(193, 18);
            this.selectAnimalTypeTextBox.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "Класс животного";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "Дата занесения в Красную книгу";
            // 
            // selectRedDateTextBox
            // 
            this.selectRedDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectRedDateTextBox.Location = new System.Drawing.Point(6, 80);
            this.selectRedDateTextBox.Name = "selectRedDateTextBox";
            this.selectRedDateTextBox.Size = new System.Drawing.Size(193, 18);
            this.selectRedDateTextBox.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 12);
            this.label13.TabIndex = 46;
            this.label13.Text = "Средняя продолжительность жизни";
            // 
            // selectAvgLifeTextBox
            // 
            this.selectAvgLifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectAvgLifeTextBox.Location = new System.Drawing.Point(6, 124);
            this.selectAvgLifeTextBox.Name = "selectAvgLifeTextBox";
            this.selectAvgLifeTextBox.Size = new System.Drawing.Size(193, 18);
            this.selectAvgLifeTextBox.TabIndex = 45;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectButton.Location = new System.Drawing.Point(6, 148);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(90, 38);
            this.selectButton.TabIndex = 47;
            this.selectButton.Text = "Выбрать данные";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelSelectButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.selectAnimalTypeTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.selectRedDateTextBox);
            this.groupBox1.Controls.Add(this.selectAvgLifeTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(362, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 192);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка данных";
            // 
            // cancelSelectButton
            // 
            this.cancelSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelSelectButton.Location = new System.Drawing.Point(109, 148);
            this.cancelSelectButton.Name = "cancelSelectButton";
            this.cancelSelectButton.Size = new System.Drawing.Size(90, 38);
            this.cancelSelectButton.TabIndex = 48;
            this.cancelSelectButton.Text = "Отмена";
            this.cancelSelectButton.UseVisualStyleBackColor = true;
            this.cancelSelectButton.Click += new System.EventHandler(this.cancelSelectButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.redDateTextBox);
            this.groupBox2.Controls.Add(this.animalNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.insertButton);
            this.groupBox2.Controls.Add(this.animalTypeTextBox);
            this.groupBox2.Controls.Add(this.changeCurrentRowButton);
            this.groupBox2.Controls.Add(this.deleteRowButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateRowButton);
            this.groupBox2.Controls.Add(this.maxWeightTextBox);
            this.groupBox2.Controls.Add(this.deleteCurrentRowButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.colorTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.idTextBox);
            this.groupBox2.Controls.Add(this.avgLifeTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.flyingAbilitiesTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 390);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление данных";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.redDateFilter);
            this.groupBox3.Controls.Add(this.empCountFilter);
            this.groupBox3.Controls.Add(this.empSalaryFilter);
            this.groupBox3.Controls.Add(this.cancelQueryFilterButton);
            this.groupBox3.Location = new System.Drawing.Point(362, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 192);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтрация по критериям";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.searchTextBox);
            this.groupBox4.Controls.Add(this.searchButton);
            this.groupBox4.Controls.Add(this.cancelSearchButton);
            this.groupBox4.Controls.Add(this.filterTextBox);
            this.groupBox4.Controls.Add(this.cancelFilterButton);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.filterButton);
            this.groupBox4.Location = new System.Drawing.Point(574, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 192);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск и фильтрация";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.csvImportButton);
            this.groupBox5.Controls.Add(this.csvExportButton);
            this.groupBox5.Controls.Add(this.xmlImportButton);
            this.groupBox5.Controls.Add(this.xmlExportButton);
            this.groupBox5.Location = new System.Drawing.Point(574, 543);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 101);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Экспорт\\импорт";
            // 
            // csvImportButton
            // 
            this.csvImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csvImportButton.Location = new System.Drawing.Point(103, 60);
            this.csvImportButton.Name = "csvImportButton";
            this.csvImportButton.Size = new System.Drawing.Size(90, 23);
            this.csvImportButton.TabIndex = 3;
            this.csvImportButton.Text = "Импорт из csv";
            this.csvImportButton.UseVisualStyleBackColor = true;
            this.csvImportButton.Click += new System.EventHandler(this.csvImportButton_Click);
            // 
            // csvExportButton
            // 
            this.csvExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csvExportButton.Location = new System.Drawing.Point(7, 60);
            this.csvExportButton.Name = "csvExportButton";
            this.csvExportButton.Size = new System.Drawing.Size(90, 23);
            this.csvExportButton.TabIndex = 2;
            this.csvExportButton.Text = "Экспорт в csv";
            this.csvExportButton.UseVisualStyleBackColor = true;
            this.csvExportButton.Click += new System.EventHandler(this.csvExportButton_Click);
            // 
            // xmlImportButton
            // 
            this.xmlImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlImportButton.Location = new System.Drawing.Point(103, 31);
            this.xmlImportButton.Name = "xmlImportButton";
            this.xmlImportButton.Size = new System.Drawing.Size(90, 23);
            this.xmlImportButton.TabIndex = 1;
            this.xmlImportButton.Text = "Импорт из xml";
            this.xmlImportButton.UseVisualStyleBackColor = true;
            this.xmlImportButton.Click += new System.EventHandler(this.xmlImportButton_Click);
            // 
            // xmlExportButton
            // 
            this.xmlExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlExportButton.Location = new System.Drawing.Point(7, 31);
            this.xmlExportButton.Name = "xmlExportButton";
            this.xmlExportButton.Size = new System.Drawing.Size(90, 23);
            this.xmlExportButton.TabIndex = 0;
            this.xmlExportButton.Text = "Экспорт в xml";
            this.xmlExportButton.UseVisualStyleBackColor = true;
            this.xmlExportButton.Click += new System.EventHandler(this.xmlExportButton_Click);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "applyYear";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "name";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "empID";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "animalName";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "ID";
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21});
            this.dataTable3.TableName = "FilterEmp";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "flyingAbilities";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "avgLife";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "redDate";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "color";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "maxWeight";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "animalType";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "animalName";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "ID";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.dataTable2.TableName = "Filter";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Летательные способности";
            this.dataColumn8.ColumnName = "flyingAbilities";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Средняя продолжительность жизни";
            this.dataColumn7.ColumnName = "avgLife";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Дата занесения в Красную книгу";
            this.dataColumn6.ColumnName = "redDate";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Цвет";
            this.dataColumn5.ColumnName = "color";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Максимальный вес";
            this.dataColumn4.ColumnName = "maxWeight";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Класс";
            this.dataColumn3.ColumnName = "animalType";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Название";
            this.dataColumn2.ColumnName = "animalName";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ID";
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "Table1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 743);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openEmpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form1";
            this.Text = "Лаба 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private MySql.Data.MySqlClient.MySqlDataAdapter dataAdapter;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private MySql.Data.MySqlClient.MySqlCommand command;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button cancelFilterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox animalNameTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox animalTypeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox avgLifeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox flyingAbilitiesTextBox;
        private System.Windows.Forms.Button deleteCurrentRowButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button updateRowButton;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button changeCurrentRowButton;
        private System.Windows.Forms.BindingSource relation1BindingSource;
        private System.Windows.Forms.Button openEmpButton;
        private System.Windows.Forms.Button redDateFilter;
        private System.Windows.Forms.Button empCountFilter;
        private System.Windows.Forms.Button empSalaryFilter;
        private System.Windows.Forms.Button cancelQueryFilterButton;
        private System.Windows.Forms.MaskedTextBox redDateTextBox;
        private System.Windows.Forms.TextBox selectAnimalTypeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox selectRedDateTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox selectAvgLifeTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button xmlExportButton;
        private System.Windows.Forms.Button csvImportButton;
        private System.Windows.Forms.Button csvExportButton;
        private System.Windows.Forms.Button xmlImportButton;
        private System.Windows.Forms.Button cancelSelectButton;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataTable dataTable1;
    }
}

