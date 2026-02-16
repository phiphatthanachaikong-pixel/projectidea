namespace projectidea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Subscribe to ADD button click
            ADD.Click += ADD_Click;
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            // Validate required fields: ideaid and ideatitle
            if (string.IsNullOrWhiteSpace(ideaid.Text) || string.IsNullOrWhiteSpace(ideatitle.Text))
            {
                System.Windows.Forms.MessageBox.Show("กรุณากรอกข้อมูลในช่อง IDEA_ID และ IDEA_TITLE", "แจ้งเตือน", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            // Prepare summary
            string cat = category.SelectedItem?.ToString() ?? string.Empty;
            string stat = status.SelectedItem?.ToString() ?? string.Empty;

            string message = $"สรุปไอเดีย:\nรหัสไอเดีย: {ideaid.Text}\nหัวข้อ: {ideatitle.Text}\nหมวด: {cat}\nสถานะ: {stat}";

            System.Windows.Forms.MessageBox.Show(message, "สรุปไอเดีย", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
