using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees_practice1
{
    internal class Program
    {
        public class AVLNode
        {
            public int Key; //Добавляем ключ и узлы
            public int Height;
            public AVLNode Left;
            public AVLNode Right;

            public AVLNode(int key)
            {
                Key = key;
                Height = 1;
            }
        }
        public class AVLTree
        {
            private AVLNode root;
            private int GetHeight(AVLNode node) // Получаем высоту
            {
                return node == null ? 0 : node.Height;
            }
            private int GetBalance(AVLNode node)
            {
                return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
            }
            private AVLNode RightRotate(AVLNode y)
            {
                AVLNode x = y.Left;
                AVLNode T2 = x.Right;
                x.Right = y;
                y.Left = T2;
                x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right));
                y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right));
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
