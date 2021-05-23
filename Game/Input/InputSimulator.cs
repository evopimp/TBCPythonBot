﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using GregsStack.InputSimulatorStandard;
using GregsStack.InputSimulatorStandard.Native;
using WinAPI;

namespace Game
{
    public class InputSimulator : IInput
    {
        private const int MAX_DELAY = 200;
        private const int MAX_MOUSE_DELAY = 75;

        private readonly Random random = new Random();
        private readonly GregsStack.InputSimulatorStandard.InputSimulator simulator;
        private readonly Process process;

        public InputSimulator(Process process)
        {
            this.process = process;
            simulator = new GregsStack.InputSimulatorStandard.InputSimulator();
        }

        private async Task Delay(int milliseconds)
        {
            await Task.Delay(milliseconds + random.Next(1, MAX_DELAY));
        }

        public void KeyDown(int key)
        {
            if(NativeMethods.GetForegroundWindow() != process.MainWindowHandle)
                NativeMethods.SetForegroundWindow(process.MainWindowHandle);

            simulator.Keyboard.KeyDown((VirtualKeyCode)key);
        }

        public void KeyUp(int key)
        {
            if (NativeMethods.GetForegroundWindow() != process.MainWindowHandle)
                NativeMethods.SetForegroundWindow(process.MainWindowHandle);

            simulator.Keyboard.KeyUp((VirtualKeyCode)key);
        }

        public async Task KeyPress(int key, int milliseconds)
        {
            simulator.Keyboard.KeyDown((VirtualKeyCode)key);
            await Delay(milliseconds);
            simulator.Keyboard.KeyUp((VirtualKeyCode)key);
        }

        public void KeyPressSleep(int key, int milliseconds)
        {
            simulator.Keyboard.KeyDown((VirtualKeyCode)key);
            Thread.Sleep(milliseconds);
            simulator.Keyboard.KeyUp((VirtualKeyCode)key);
        }

        public async Task LeftClickMouse(Point p)
        {
            SetCursorPosition(p);
            await Delay(MAX_MOUSE_DELAY);
            simulator.Mouse.LeftButtonDown();
            await Delay(MAX_MOUSE_DELAY);
            simulator.Mouse.LeftButtonUp();
            await Delay(MAX_MOUSE_DELAY);
        }

        public async Task RightClickMouse(Point p)
        {
            SetCursorPosition(p);
            simulator.Mouse.RightButtonDown();
            await Delay(MAX_MOUSE_DELAY);
            simulator.Mouse.RightButtonUp();
        }

        public void SetCursorPosition(Point p)
        {
            NativeMethods.GetWindowRect(process.MainWindowHandle, out var rect);
            p.X = p.X * 65535 / rect.Width;
            p.Y = p.Y * 65535 / rect.Height;
            simulator.Mouse.MoveMouseTo(Convert.ToDouble(p.X), Convert.ToDouble(p.Y));
        }

        public async Task SendText(string text)
        {
            if (NativeMethods.GetForegroundWindow() != process.MainWindowHandle)
                NativeMethods.SetForegroundWindow(process.MainWindowHandle);

            simulator.Keyboard.TextEntry(text);
            await Task.Delay(25);
        }

        public void PasteFromClipboard()
        {
            simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.VK_V);
        }
    }
}
