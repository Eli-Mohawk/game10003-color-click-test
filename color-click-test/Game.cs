// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Color rectangleColor = Color.Green;
        int clicks = 0;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Color Click");
            Window.SetSize(600, 600);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;

            // this happens when you left click
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                clicks += 1;
                if (rectangleColor == Color.Green)
                {
                    rectangleColor = Color.Red;
                }
                else
                {
                    rectangleColor = Color.Green;
                }

            }

            Text.Draw($"{clicks}", new Vector2(10, 10));
            if (clicks >= 50)
            {
                Text.Draw("WOW", new Vector2(100, 10));
            }

            Draw.FillColor = rectangleColor;

            Draw.Rectangle(new Vector2(150, 150), new Vector2(300, 300));
        }
    }

}