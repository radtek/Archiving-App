using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FluentFTP;
using System.Net;
using System.Net.Sockets;

namespace PrototypeApp
{
    class AnimationFunc
    {
        public void AddAnimation(Button button, string title, int initialWidth, int endWidth)
        {
            var expandTimer = new Timer();
            var contractTimer = new Timer();

            expandTimer.Interval = 1;//can adjust to determine the refresh rate
            contractTimer.Interval = 1;

            DateTime animationStarted = DateTime.Now;

            //TODO update as appropriate or make it a parameter
            TimeSpan animationDuration = TimeSpan.FromMilliseconds(250);

            button.MouseHover += (_, args) =>
            {
                button.Text = title;
                contractTimer.Stop();
                expandTimer.Start();
                animationStarted = DateTime.Now;
                if (button.BackColor == Color.FromArgb(229, 229, 229))
                    button.BackColor = Color.Transparent;
            };

            button.MouseLeave += (_, args) =>
            {
                button.Text = "";
                expandTimer.Stop();
                contractTimer.Start();
                animationStarted = DateTime.Now;
                button.BackColor = Color.FromArgb(229, 229, 229);
            };

            expandTimer.Tick += (_, args) =>
            {
                double percentComplete = (DateTime.Now - animationStarted).Ticks
                    / (double)animationDuration.Ticks;

                if (percentComplete >= 1)
                {
                    button.Width = endWidth;
                    expandTimer.Stop();
                }
                else
                {
                    button.Width = (int)(initialWidth +
                        (endWidth - initialWidth) * percentComplete);
                }
            };

            contractTimer.Tick += (_, args) =>
            {
                double percentComplete = (DateTime.Now - animationStarted).Ticks
                    / (double)animationDuration.Ticks;

                if (percentComplete >= 1)
                {
                    button.Width = initialWidth;
                    button.BackColor = Color.Transparent;
                    contractTimer.Stop();
                }
                else
                {
                    button.Width = (int)(endWidth -
                        (endWidth - initialWidth) * percentComplete);
                }
            };
        }
    }
}
