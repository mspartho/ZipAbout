using ZIPABOUT;

namespace Sprint3
{
    public partial class Booked : Form
    {
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private GroupBox groupBox1;

        public Booked()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(626, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Available";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(426, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Book Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(66, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Booked Vehicles";
            // 
            // Booked
            // 
            this.ClientSize = new System.Drawing.Size(805, 485);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Booked";
            this.Text = "Booked";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void AddGroupBoxes()
        {
            int y = 30;
            for (int i = 0; i < VehicleManager.vehicles.Count; i++)
            {
                y = i*130;
                Vehicle vehicle = VehicleManager.vehicles[i]; 

                if (!vehicle.isBooked())
                {
                    continue;
                }

                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.label7 = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                this.groupBox1.SuspendLayout();
                this.SuspendLayout();
                // 
                // groupBox1
                // 
                this.groupBox1.Controls.Add(this.label8);
                this.groupBox1.Controls.Add(this.label7);
                this.groupBox1.Controls.Add(this.label6);
                this.groupBox1.Controls.Add(this.label5);
                this.groupBox1.Controls.Add(this.label4);
                this.groupBox1.Controls.Add(this.label3);
                this.groupBox1.Controls.Add(this.label2);
                this.groupBox1.Controls.Add(this.label1);
                this.groupBox1.Location = new System.Drawing.Point(60, y+94);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(717, 130);
                this.groupBox1.TabIndex = 0;
                this.groupBox1.TabStop = false;
                this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(6, 27);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(84, 25);
                this.label1.TabIndex = 0;
                this.label1.Text = "VehicleID";
                this.label1.Click += new System.EventHandler(this.label1_Click_1);
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(133, 27);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(84, 25);
                this.label2.TabIndex = 2;
                this.label2.Text = vehicle.getVehicleId();
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(6, 61);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(121, 25);
                this.label3.TabIndex = 3;
                this.label3.Text = "Vehicle Type: ";
                this.label3.Click += new System.EventHandler(this.label3_Click);
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(133, 61);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(84, 25);
                this.label4.TabIndex = 4;
                this.label4.Text = vehicle.GetType().Name;
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(258, 27);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(102, 25);
                this.label5.TabIndex = 5;
                this.label5.Text = "ModelNum";
                this.label5.Click += new System.EventHandler(this.label5_Click);
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(366, 27);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(84, 25);
                this.label6.TabIndex = 6;
                this.label6.Text = vehicle.getModelNumber();
                this.label6.Click += new System.EventHandler(this.label6_Click);
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Location = new System.Drawing.Point(514, 27);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(107, 25);
                this.label7.TabIndex = 7;
                this.label7.Text = "rentPerHour";
                this.label7.Click += new System.EventHandler(this.label7_Click);
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Location = new System.Drawing.Point(627, 27);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(84, 25);
                this.label8.TabIndex = 8;
                this.label8.Text = vehicle.getRent().ToString();

                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                this.Controls.Add(this.groupBox1);

            }

            this.ClientSize = new System.Drawing.Size(805, 485);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main= new Main();
            main.AddGroupBoxes();
            main.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}