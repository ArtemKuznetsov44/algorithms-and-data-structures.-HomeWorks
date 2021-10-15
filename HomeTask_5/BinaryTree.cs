using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    // Данный класс служит для описание бинарного дерева и его методов.
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

        #region // Заполение дерева некторыми элементами.
        public void Create()
        {
            AddNode(14);
            AddNode(7);
            AddNode(23);
            AddNode(5);
            AddNode(9);
            AddNode(1);
            AddNode(19);
            AddNode(35);
            AddNode(17); 
        }
        #endregion

        #region // Обходы и поиск элемента.
        public void BFS(int value) // Поиск элемента и обход дерева в ширину.
        {
            bool flag = false; // Для отображения результата поиска.
            Queue<Node> nodesQueue = new Queue<Node>(); // Создание очереди тип Node - содержит структуру элемента бинарного дерева.
            Node tmp = root; // Создание копии корня нашего дерева.
            nodesQueue.Enqueue(tmp); // Её добавление в конец очереди.
            int step = 1; // Счетчик шагов для алгоритма.
            while(nodesQueue.Count != 0) // Пока очередь не пуста...
            {
                Node currentElement = nodesQueue.Dequeue(); // Извлекаем наш элемент из очереди.
                if (currentElement.Data == value) // Сравнение значений элемента и искомого значения.
                { 
                    flag = true; 
                    Console.WriteLine($"Step {step}: element {currentElement.Data}"); 
                    break; // Если нашли, то цикл завершается.
                }
                else
                    Console.WriteLine($"Step {step}: element {currentElement.Data}"); // В противном случаее поиск продолжается.

                if (currentElement.Left != null) // Если у извлеченного из очереди элемента ссылка на его левого потомка не равна нулю, то
                    nodesQueue.Enqueue(currentElement.Left); // пороизводим запись в эчередь этого левого потомка текущего элемента.
                if(currentElement.Right != null) // Все по аналогии...
                    nodesQueue.Enqueue(currentElement.Right); 

                step++; // Увелечение счетчика.
            }
            PrintResult(flag); // Вызов фукнции для отоборажения результата поиска.
        }
        public void DFS(int value) // Поиск элемента и обход дерева в глубину.
        {
            bool flag = false;  // Для отображения резульата поиска.
            Stack<Node> nodesQueue = new Stack<Node>(); // Создание стека тип Node - содержит структуру элемента бинарного дерева.
            Node tmp = root; // Создание копии от корня дерева.
            nodesQueue.Push(tmp); // Её добавление в стек.
            int step = 1; // Счетчик шагов для цикла.
            while (nodesQueue.Count != 0) // Пока стек не пустой...
            {
                Node currentElement = nodesQueue.Pop(); // Извлекаем последний элемент из стека.
                if (currentElement.Data == value) // Сравниваем значения извлеченного элемента и искомого значения.
                {
                    flag = true; 
                    Console.WriteLine($"Step {step}: element {currentElement.Data}");
                    break; // Если совпало, то завершаем цикл.
                }
                else
                    Console.WriteLine($"Step {step}: element {currentElement.Data}"); // В противном случае, продолжаем поиск.
                 
                if (currentElement.Right != null) // Если у извлеченного с вершины стека элемента ссылка на его правого потомка не равна null, то
                    nodesQueue.Push(currentElement.Right); // добавляем этого потомка на вершину стека.
                if (currentElement.Left != null) // Все также, как и с правым потомком...
                    nodesQueue.Push(currentElement.Left);

                step++; // Увелечение счетчика.
            }
            PrintResult(flag); // Вызов фукнции для отоборажения результата поиска.
        }
        public void PrintResult(bool flag)
        {
            if (flag)
                Console.WriteLine("Element was found in Tree!");
            else
                Console.WriteLine("Element was not found in Tree!"); 
        }
    }
    #endregion
}