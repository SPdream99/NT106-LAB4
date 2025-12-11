namespace Lab04_Bai01;

internal static class Program
{
    /// <summary>
    ///     Điểm bắt đầu của chương trình.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new Form1());
    }
}