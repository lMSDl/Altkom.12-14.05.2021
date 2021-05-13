using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Adapter.I
{
    public class SquareAdapter : ICircle
    {
        private Square square;

        public SquareAdapter(Square square)
        {
            this.square = square;
        }

        public float Radius => square.Width * (float)Math.Sqrt(2) / 2f;
    }
}
