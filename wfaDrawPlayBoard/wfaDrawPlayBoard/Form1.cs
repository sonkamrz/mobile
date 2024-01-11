
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDrawPlayBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // ������� �����, ����������� ��������� ������� �����
        public abstract class Board
        {
            protected int BoardSize { get; set; } // ������ ����������� ��� ������ ������

            public Board(int boardSize)
            {
                BoardSize = boardSize;
            }

            // �����, ����������� ��������� �����
            public abstract void DrawBoard(Graphics g);
        }

        // ����������� �����, ����������� ��������� ��������� �����
        public class ChessBoard : Board
        {
            private int NumCells { get; set; } // ���������� �����

            public ChessBoard(int boardSize, int numCells) : base(boardSize)
            {
                NumCells = numCells;
            }

            public override void DrawBoard(Graphics g)
            {
                Brush[] cellColors = { Brushes.White, Brushes.Gray }; // ����� �����

                int cellSize = BoardSize / NumCells; // ������ ������

                // ��������� ����� ��������� �����
                for (int i = 0; i < NumCells; i++)
                {
                    for (int j = 0; j < NumCells; j++)
                    {
                        int colorIndex = (i + j) % 2; // ����� ����� ������

                        Brush brush = cellColors[colorIndex];

                        g.FillRectangle(brush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        // ������ ������������� �������
        class Program
        {
            static void Main()
            {
                int boardSize = 400;
                int numCells = 8;

                Bitmap bitmap = new Bitmap(boardSize, boardSize);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    Board chessBoard = new ChessBoard(boardSize, numCells);
                    chessBoard.DrawBoard(g);
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Image = bitmap;

                Form form = new Form();
                form.Controls.Add(pictureBox);

                Application.Run(form);
            }
        }
    }
}
