```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class TrainerCore
{
    private Process gameProcess;
    private const string PROCESS_NAME = "valorant"; // Update this with the actual process name
    private const int BASE_ADDRESS = 0x12345678; // Placeholder for the game base address
    private const int PLAYER_SPEED_OFFSET = 0x00AABBCC; // Placeholder for player speed offset
    private const int FOV_OFFSET = 0x00DDEEFF; // Placeholder for FOV offset
    private const int UNCAP_VALUE = 999; // Value for FPS uncap

    public bool AttachToProcess()
    {
        try
        {
            gameProcess = Process.GetProcessesByName(PROCESS_NAME)[0];
            return true;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Game not running.");
            return false;
        }
    }

    public bool IsGameRunning()
    {
        return gameProcess != null && !gameProcess.HasExited;
    }

    public float ReadFloat(int address)
    {
        int bytesRead;
        byte[] buffer = new byte[4];
        NativeMethods.ReadProcessMemory(gameProcess.Handle, (IntPtr)address, buffer, buffer.Length, out bytesRead);
        return BitConverter.ToSingle(buffer, 0);
    }

    public void WriteFloat(int address, float value)
    {
        byte[] buffer = BitConverter.GetBytes(value);
        NativeMethods.WriteProcessMemory(gameProcess.Handle, (IntPtr)address, buffer, buffer.Length, out _);
    }

    public int ReadInt(int address)
    {
        int bytesRead;
        byte[] buffer = new byte[4];
        NativeMethods.ReadProcessMemory(gameProcess.Handle, (IntPtr)address, buffer, buffer.Length, out bytesRead);
        return BitConverter.ToInt32(buffer, 0);
    }

    public void WriteInt(int address, int value)
    {
        byte[] buffer = BitConverter.GetBytes(value);
        NativeMethods.WriteProcessMemory(gameProcess.Handle, (IntPtr)address, buffer, buffer.Length, out _);
    }

    public void UncapFPS()
    {
        if (!IsGameRunning()) return;

        // Setting 'UNCAP' values
        WriteFloat(BASE_ADDRESS + FOV_OFFSET, UNCAP_VALUE);
        // Additional game logic for uncap can be implemented here
    }

    private static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            byte[] lpBuffer, int dwSize, out int