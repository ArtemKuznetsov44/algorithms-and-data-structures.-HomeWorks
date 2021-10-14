using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_4___2_
{
    class BinaryTree
    {
        public Node root; // Корень дерева.
        public BinaryTree() { root = null; } // Создание экземпляра класса BinaryTree, где "главный" корень изначально равен null.

        #region // Операции по добавления новго элемента в бинарное дерево.
        public void AddNode(int value) // Добавление нового элемента в бинарное дерево.
        {
            Node newNode = new Node(value); // Создание новового элемента с соответвующими полями.
            if (root == null)
                root = newNode;
            else if (root.Data > newNode.Data) // Если значение корня больше заначения новго элемента, то...
            {
                if (root.Left == null) // Если левый еще ничем не занят, то...
                    root.Left = newNode;
                else
                    AddElementWithRecursion(root.Left, newNode); // Если левый элемент занят, идем в рекурсию.
            }
            else // Eсли значение нового элемента равно или больше значения корня, то...
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    AddElementWithRecursion(root.Right, newNode);
            }
        }
        void AddElementWithRecursion(Node root, Node newNode)
        {
            if (root.Data > newNode.Data) // Прогон по левой ветке бинарного дерева.
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    AddElementWithRecursion(root.Left, newNode);
            }
            else // Прогон по правой ветке бинарного дерева. То есть если значение новго элемента равно или больше значения корня.
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    AddElementWithRecursion(root.Right, newNode);
            }
        }
        #endregion

        #region // Операции по удалению элемента из бинарного дерева.
        public void Remove(int val)
        {
            Node temp;
            if (root == null) // Если корень пуст, то и удалять нечего.
                return;
            if (root.Data.Equals(val)) // Если значение удаляемого элемента равно значению корня.
            {
                if (root.Left != null) // Если есть левый элемент.
                {
                    if (root.Left.Right == null)
                    {
                        // Левый элемент заменяет корень.
                        root.Left.Right = root.Right;
                        root = root.Left;
                    }
                    else // Если у узла больше 1 дочернего элемента.
                    {
                        temp = root.Left.Right;
                        root.Left.Right = root.Right;
                        root = root.Left; // Левый элемент заменяет корень. 
                        RebuildTree(temp); // пересобираем всю левую ветку.
                    }
                }
                else // Если есть только правый элемент.
                {
                    root = root.Right; // Заменяем корень на правый элемент.
                }
                return;

            }
            if (val < root.Data) // Если значение меньше корня.
            {
                if (root.Left == null) // Если левая ветка пустая, то удаляемого значения не сущевтвует в дереве.
                    return;
                root.Left = RemoveRecurse(root.Left, val); // Если левая ветка не пустая, то запускаем рекурсивное удаление.
            }
            else // Всё то же самое, что и с левой.
            {
                if (root.Right == null)
                    return;
                root.Right = RemoveRecurse(root.Right, val);
            }
        }
        void RebuildTree(Node temp)
        {
            if (temp == null)
                return;
            // Пересобирается левая ветка дерева.
            // На место удалённого встаёт наибольший элемент с левой ветки
            // С помощью метода AddNode сохраняется правильная последовательность элементов
            AddNode(temp.Data);
            RebuildTree(temp.Left);
            RebuildTree(temp.Right);
        }
        Node RemoveRecurse(Node root, int val)
        {
            Node temp;
            if (root.Data.Equals(val)) // Всё так же как в первом методе
            {
                if (root.Left != null)
                {
                    if (root.Left.Right == null) // Если есть только левый элемент,
                    {
                        root.Left.Right = root.Right;
                        root = root.Left; // то присваиваем корню левый элемент.
                    }
                    else // Если есть 2 дочерних элемента.
                    {
                        temp = root.Left.Right;
                        root.Left.Right = root.Right;
                        root = root.Left;
                        RebuildTree(temp); // Пересобираем левую ветку дерева.
                    }
                }
                else // Если есть только правый элемент. 
                    root = root.Right; // Присваиваем корню правый элемент.
                return root; // Возвращаем новый узел с удаленным элементом.

            }
            if (val < root.Data) // Если значение меньше корня, то идём в левую ветку и запускаем рекурсию пока не найдём значение.
            {                    // Когда нашли значение, то выполняем алгоритм выше.
                if (root.Left == null)
                    return root;
                root.Left = RemoveRecurse(root.Left, val);
            }
            else // Так же как с левой веткой, только ищем в правой.
            {
                if (root.Right == null)
                    return root;
                root.Right = RemoveRecurse(root.Right, val);
            }
            return root;
        }
        #endregion

        //public bool FindElement(int value)
        //{
        //    if (root == null)
        //        return false;
        //    else if (root.Data == value)
        //        return true; 
        //    else if(root.Data > value)
        //    {
        //        if (root.Left.Data == value)
        //            return true;
        //        else
        //            FindRecursiv(root.Left, value); 
        //    }
        //}
        //public void FindRecursiv(Node root, int value)
        //{

        //    if (root != null)
        //    {
        //        if(root.Data == value)
        //        {
        //            return true;
        //        }
        //        FindRecursiv(root.Left);
        //        FindRecursiv(root.Right);
        //    }
        //}
        public void PrintLKP()
        {
            if (root == null)
                return;
            PrintLKPRecurse(root); 
        }
        void PrintLKPRecurse(Node current)
        {
            if (current.Left != null)
                PrintLKPRecurse(current.Left);
            Console.Write(current.Data + " ");
            if (current.Right != null)
                PrintLKPRecurse(current.Right);
        }
    }
}
