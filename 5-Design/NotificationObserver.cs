using System;
using System.Windows.Forms;

public class NotificationObserver : ITensionObserver
{
    private int lowerThreshold;
    private int upperThreshold;

    public NotificationObserver(int lower, int upper)
    {
        lowerThreshold = lower;
        upperThreshold = upper;
    }

    public void Update(int tension)
    {
        if (tension < lowerThreshold || tension > upperThreshold)
        {
            MessageBox.Show($"Попередження! Натяг тросу вийшов за межі: {tension}");
        }
    }
}
