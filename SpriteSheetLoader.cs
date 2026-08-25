using System;
using System.Collections.Generic;
using System.Drawing;

namespace GuessTheCard
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
            string[] suits = { "Diamonds", "Hearts", "Spades", "Clubs" };
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "Back1", "Back2" };

            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Rectangle cropArea = new Rectangle(col * cardWidth, row * cardHeight, cardWidth, cardHeight);
                    Bitmap card = spriteSheet.Clone(cropArea, spriteSheet.PixelFormat);

                    string key = $"{ranks[col]}_of_{suits[row]}";
                    cardImages[key] = card;

                    index++;
                }
            }
        }

        public Bitmap GetCard(string rank, string suit)
        {
            string key = $"{rank}_of_{suit}";
            return cardImages.ContainsKey(key) ? cardImages[key] : null;
        }

        public Bitmap GetCardBack(int backIndex = 1)
        {
            string key = backIndex == 2 ? "Back2_of_Diamonds" : "Back1_of_Diamonds";
            return cardImages.ContainsKey(key) ? cardImages[key] : null;
        }
    }
}
