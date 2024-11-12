using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private TensionData tensionData;
    private HistoryObserver historyObserver;
    private NotificationObserver notificationObserver;

    public MainForm()
    {
        InitializeComponent();

        tensionData = new TensionData();
        historyObserver = new HistoryObserver(historyListBox);

        var thresholdSettings = new ThresholdSettings(60, 120);
        notificationObserver = new NotificationObserver(thresholdSettings.LowerThreshold, thresholdSettings.UpperThreshold);

        tensionData.AddObserver(historyObserver);
        tensionData.AddObserver(notificationObserver);
    }

    private void btnGenerateTension_Click(object sender, EventArgs e)
    {
        int randomTension = new Random().Next(50, 150);
        tensionData.SetTension(randomTension);
    }
}
