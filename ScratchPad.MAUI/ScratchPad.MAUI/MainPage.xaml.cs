namespace ScratchPad.MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

        picker.ItemsSource = new List<TestItem>() { new TestItem("hello"), new TestItem("world") };
    }
}

class TestItem
{
    public string Name { get; set; }

    public TestItem(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return this.Name.ToString();
    }
}

