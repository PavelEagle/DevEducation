using System;
using System.Collections.Generic;
using System.Text;

namespace Grafs
{
    public class GraphTree
    {
        Node root;
        bool allowReiteration;

        public GraphTree(Node node, bool allowReiteration = true)
        {
            root = node;
            this.allowReiteration = allowReiteration;

        }
        public void CreateShedules()
        {
            if (allowReiteration == true) Create(root);
            else CreateWithNoReiteration(root);
        }
        public void DisplayAnswer()
        {
            MakeAnswer(root);
        }


        private void CreateWithNoReiteration(Node node)
        {
            for (int i = 0; i < node.films.Count; i++) //перебираем сеансы
            {

                if (node.films[i].filmDuration <= node.Value /*&& !node.list.Contains(node.filmNames[i])*/) //если в рабочем дне осталось время для сеанса
                {

                    Node newNode; //создаётся новая нода

                    newNode = new Node(node.Value - node.films[i].filmDuration, node.films, node.variantOfShedule + node.films[i].fileNmae + "\n", node.list);
                    newNode.list.Add(node.films[i].fileNmae); //в её лист
                    node.Children.Add(newNode); //она добавляется в лист некстов

                    Create(newNode); //и мы спускаемся глубже по ветке, пока не закончится время
                }
            }
        }
        private void Create(Node node)
        {
            for (int i = 0; i < node.films.Count; i++) //перебираем сеансы
            {

                if ((node.films[i].filmDuration <= node.Value)) //если в рабочем дне осталось время для сеанса
                {

                    Node newNode; //создаётся новая нода

                    newNode = new Node(node.Value - node.films[i].filmDuration, node.films, node.variantOfShedule + node.films[i].fileNmae + "\n", node.list);

                    node.Children.Add(newNode); //она добавляется в лист некстов

                    Create(newNode); //и мы спускаемся глубже по ветке, пока не закончится время
                }
            }
        }
        private void MakeAnswer(Node node)
        {

            if (node.films.Count != 0)
            {
                foreach (Node i in node.Children)
                {
                    MakeAnswer(i);
                    //Console.WriteLine($"свободное оставшееся время {i.films.fileNmae} \n");
                }
            }
            else
            {
                Console.WriteLine(node.variantOfShedule);
                Console.WriteLine($"свободное оставшееся время {node.Value} \n");
            }
        }

    }
}
