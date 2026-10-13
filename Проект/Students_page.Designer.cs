namespace Проект
{
    partial class Students_page
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlToolbar;
        private Button btnAdd;
        private TextBox txtSearch;

        private Panel pnlGrid;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colFio;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colNotes;

        private Panel pnlBottom;
        private Button btnEdit;
        private Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            btnBack = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlToolbar = new Panel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            pnlGrid = new Panel();
            dgvStudents = new DataGridView();
            colFio = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            pnlBottom = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            pnlTop.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblSubtitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1000, 120);
            pnlTop.TabIndex = 3;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(124, 77, 255);
            btnBack.Location = new Point(40, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 32);
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            btnBack.Text = "←  Назад";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblSubtitle.Location = new Point(180, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(267, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "— добавляйте, редактируйте и удаляйте";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblTitle.Location = new Point(40, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Ученики";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(245, 240, 255);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnAdd);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 120);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(40, 15, 40, 15);
            pnlToolbar.Size = new Size(1000, 70);
            pnlToolbar.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(94, 53, 177);
            txtSearch.Location = new Point(260, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по ФИО…";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(124, 77, 255);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(40, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+  Добавить ученика";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 240, 255);
            pnlGrid.Controls.Add(dgvStudents);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 190);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(40, 10, 40, 10);
            pnlGrid.Size = new Size(1000, 360);
            pnlGrid.TabIndex = 0;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 228, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(94, 53, 177);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeight = 40;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colFio, colPhone, colSubject, colGrade, colNotes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 40, 100);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 198, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 40, 100);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.Font = new Font("Segoe UI", 10F);
            dgvStudents.GridColor = Color.FromArgb(237, 228, 255);
            dgvStudents.Location = new Point(40, 10);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowTemplate.Height = 36;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(920, 340);
            dgvStudents.TabIndex = 0;
            // 
            // colFio
            // 
            colFio.HeaderText = "ФИО";
            colFio.Name = "colFio";
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Телефон";
            colPhone.Name = "colPhone";
            // 
            // colSubject
            // 
            colSubject.HeaderText = "Предмет";
            colSubject.Name = "colSubject";
            // 
            // colGrade
            // 
            colGrade.HeaderText = "Класс / уровень";
            colGrade.Name = "colGrade";
            // 
            // colNotes
            // 
            colNotes.HeaderText = "Заметки";
            colNotes.Name = "colNotes";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnDelete);
            pnlBottom.Controls.Add(btnEdit);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 550);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(40, 15, 40, 15);
            pnlBottom.Size = new Size(1000, 70);
            pnlBottom.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(94, 53, 177);
            btnDelete.Location = new Point(230, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(94, 53, 177);
            btnEdit.Location = new Point(40, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // Students_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 620);
            Controls.Add(pnlGrid);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlTop);
            MinimumSize = new Size(900, 560);
            Name = "Students_page";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ученики";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Градиент верхней панели
        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                pnlTop.ClientRectangle,
                System.Drawing.Color.White,
                System.Drawing.Color.FromArgb(237, 228, 255),
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlTop.ClientRectangle);
            }
        }
    }
}