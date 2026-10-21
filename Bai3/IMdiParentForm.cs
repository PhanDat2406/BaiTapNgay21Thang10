namespace Bai3
{
    public interface IMdiParentForm
    {
        void UpdateStatusMessage(string message);
        void UpdateProgress(int percent);
        void ResetProgress();
    }
}
