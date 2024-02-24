namespace _02._03
{
	public partial class Form1 : Form
	{
		private TextBox textBox;
		private Button button;
		public Form1()
		{
			InitializeComponent();

			textBox = new TextBox();
			textBox.Location = new Point(this.Size.Width/3, this.Size.Height/3);
			textBox.Multiline = true;
			textBox.Size = new Size(240, 100);
			textBox.Font = new Font("Roboto", 16);
			textBox.TextChanged += TextBoxChanged;

			button = new Button();
			button.Location = new Point(this.Size.Width/3, 280);
			button.Size = new Size(240, 50);
			button.AllowDrop = true;
			button.Font = new Font("Roboto", 14);
			button.Text = "Click";
			button.Enabled = false;
			button.MouseClick += ButtonClick;

			Controls.Add(textBox);
			Controls.Add(button);
		}

		private void TextBoxChanged(object sender, EventArgs e)
		{
			button.Enabled = textBox.Text.Trim().Length > 0;
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show(textBox.Text);
		}

	}
}
