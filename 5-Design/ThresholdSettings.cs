public class ThresholdSettings
{
    public int LowerThreshold { get; set; }
    public int UpperThreshold { get; set; }

    public ThresholdSettings(int lower, int upper)
    {
        LowerThreshold = lower;
        UpperThreshold = upper;
    }
}
