using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //этот класс расширяет circle и скрывает унаследовнный метод draw().
    class ThreeDCircle:Circle
    {
        // Скрыть поле ShapeName,определенное выше в иерархии
        protected new string shapeName;
        //скрыть любую реализацию draw(), находящуюся выше в иерархии
        public void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
