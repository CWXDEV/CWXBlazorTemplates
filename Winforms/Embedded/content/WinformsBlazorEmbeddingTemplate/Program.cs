using System.Windows.Forms;

namespace WinformsBlazorEmbeddingTemplate;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Main());
    }
}