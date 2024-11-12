using System.Windows.Forms;

public class HistoryObserver : ITensionObserver
{
    private ListBox historyListBox;

    public HistoryObserver(ListBox listBox)
    {
        historyListBox = listBox;
    }

    public void Update(int tension)
    {
        string timestamp = DateTime.Now.ToString("HH:mm:ss");
        historyListBox.Items.Add($"{timestamp}: Натяг тросу - {tension}");
    }
}
