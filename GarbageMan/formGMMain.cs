using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GarbageMan
{
    public partial class formGMMain : Form
    {
        [DllImport("Shell32.dll")]

        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        enum RecycleFlag : int

        {

            SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying

            SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin

            SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete

        }

        public formGMMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void openRecycleBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "shell:RecycleBinFolder");
        }

        private void emptyRecycleBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, 0x0000000);
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void silentlyWithoutConfirmationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
        }

        private void iconGMTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "shell:RecycleBinFolder");
        }
    }
}
