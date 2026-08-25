using System;
using System.Collections.Generic;
using System.Drawing;

namespace Guess_The_Card
{
    public class SpriteSheetLoader
    {
        private readonly Bitmap spriteSheet;
        private readonly int rows;
        private readonly int columns;
        private readonly int cardWidth;
        private readonly int cardHeight;

        private readonly Dictionary<string, Bitmap> cardImages;

        public SpriteSheetLoader(string filePath, int rows, int columns)
        {
            spriteSheet = new Bitmap(filePath);
            this.rows = rows;
            this.columns = columns;

            cardWidth = spriteSheet.Width / columns;
            cardHeight = spriteSheet.Height / rows;

            cardImages = new Dictionary<string, Bitmap>();

            SliceSpriteSheet();
        }

        private void SliceSpriteSheet()
        {
            // Suits match your FormStart.cs logic
            string[] suits = { "Diamonds", "Hearts", "Spades", "Clubs" };

            // Ranks match your FormStart.cs logic
            string[] ranks =
            {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "J", "Q", "K", "Back1", "Back2"
            };

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Rectangle cropArea = new Rectangle(
                        col * cardWidth,
                        row * cardHeight,
                        cardWidth,
                        cardHeight
                    );

                    Bitmap card = spriteSheet.Clone(cropArea, spriteSheet.PixelFormat);

                    string rank = ranks[col];
                    string suit = suits[row];

                    string key = rank + "_of_" + suit;

                    if (!cardImages.ContainsKey(key))
                    {
                        cardImages.Add(key, card);
                    }
                }
            }
        }

        public Bitmap GetCard(string rank, string suit)
        {
            string key = rank + "_of_" + suit;

            if (cardImages.ContainsKey(key))
            {
                return cardImages[key];
            }

            return null;
        }

        public Bitmap GetCardBack(int backIndex = 1)
        {
            string rank = backIndex == 2 ? "Back2" : "Back1";
            string key = rank + "_of_Diamonds"; // Back images stored in first row

            if (cardImages.ContainsKey(key))
            {
                return cardImages[key];
            }

            return null;
        }
    }
}
