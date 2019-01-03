using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Board board = new Board();
            int depth = 4; //could definitely be higher but should be at least 4
            double alpha = int.MinValue; //or -1.0. however we want to implement it
            double beta = int.MaxValue; //or 1.0. however we want to implement it 
            bool player = true; //initialize to true which is max/computer 

            //whenever we end up calling alpabeta: 
            AlphaBeta.AlphaBetaSearch(board, depth, alpha, beta, player);
        }
    }
}
