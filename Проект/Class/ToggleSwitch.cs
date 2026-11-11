using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer; // Защита от конфликта имен

namespace Проект.Class
{
    public class ToggleSwitch : Control
    {
        private Timer animTimer;
        private int animationValue = 0; // 0 = выключен, 100 = включен
        private bool isChecked = false;

        // Размеры тумблера
        private int trackWidth = 46;
        private int trackHeight = 24;
        private int thumbSize = 20;

        public event EventHandler CheckedChanged;

        public bool Checked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    StartAnimation();
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public ToggleSwitch()
        {
            this.Size = new Size(trackWidth + 4, trackHeight + 4); // Чуть больше для отступов
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true; // Убирает мерцание

            animTimer = new Timer { Interval = 15 };
            animTimer.Tick += AnimTimer_Tick;

            this.Click += (s, e) => Checked = !Checked;
        }

        private void StartAnimation()
        {
            animTimer.Start();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            int speed = 15; // Скорость анимации

            if (isChecked)
            {
                animationValue += speed;
                if (animationValue >= 100)
                {
                    animationValue = 100;
                    animTimer.Stop();
                }
            }
            else
            {
                animationValue -= speed;
                if (animationValue <= 0)
                {
                    animationValue = 0;
                    animTimer.Stop();
                }
            }

            this.Invalidate(); // Перерисовываем тумблер
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Рисуем фон (дорожку)
            // Выключен: Светло-сиреневый (237, 228, 255). Включен: Ярко-фиолетовый (124, 77, 255)
            Color trackColor = Color.FromArgb(
                237 + (124 - 237) * animationValue / 100,
                228 + (77 - 228) * animationValue / 100,
                255 + (255 - 255) * animationValue / 100
            );

            using (var path = new GraphicsPath())
            {
                int radius = trackHeight / 2;
                path.AddArc(2, 2, radius * 2, radius * 2, 90, 180);
                path.AddArc(2 + trackWidth - radius * 2, 2, radius * 2, radius * 2, 270, 180);
                path.CloseFigure();

                using (var brush = new SolidBrush(trackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            // 2. Рисуем белый кружок (thumb)
            int thumbX = 2 + (trackWidth - thumbSize - 4) * animationValue / 100;
            using (var brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, thumbX, 2 + (trackHeight - thumbSize) / 2, thumbSize, thumbSize);
            }
        }
    }
}