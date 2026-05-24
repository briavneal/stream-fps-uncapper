```csharp
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantFPSUncapper
{
    public partial class MainForm : Form
    {
        private const string ProcessName = "valorant"; // Replace with the actual process name
        private const int DesiredFPS = 240;
        private Timer processCheckTimer;
        private bool isRunning;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            processCheckTimer = new Timer();
            processCheckTimer.Interval = 1000; // Check every second
            processCheckTimer.Tick += ProcessCheckTimer_Tick;

            Button startButton = new Button
            {
                Text = "Start Uncapper",
                Location = new System.Drawing.Point(30, 30),
                Size = new System.Drawing.Size(120, 30)
            };
            startButton.Click += StartButton_Click;

            Button stopButton = new Button
            {
                Text = "Stop Uncapper",
                Location = new System.Drawing.Point(160, 30),
                Size = new System.Drawing.Size(120, 30)
            };
            stopButton.Click += StopButton_Click;

            Controls.Add(startButton);
            Controls.Add(stopButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                processCheckTimer.Start();
                MessageBox.Show("FPS Uncapper started. Monitoring for game process.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                processCheckTimer.Stop();
                MessageBox.Show("FPS Uncapper stopped.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProcessCheckTimer_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName(ProcessName);
            if (processes.Any())
            {
                // Insert logic to uncap FPS here, e.g., modify registry or use DLL injection
                // Placeholder for FPS uncap logic
                UncapFPS(processes.First());
            }
        }

        private void UncapFPS(Process process)
        {
            // The logic to manipulate the game's FPS goes here
            // For instance, using memory manipulation, external libraries, or commands
            Console.WriteLine($"Uncapping FPS for {process.ProcessName}");
        }
    }
}
```