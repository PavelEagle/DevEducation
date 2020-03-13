using Cinema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grafs
{
    public class GraphTree
    {
        Node root, temp;
        int minTimeLeft = 840, minFilmDuration = 840, countOfHalls, numberOfHall;

        public GraphTree(Node node, int countOfHalls)
        {
            root = node;
            this.countOfHalls = countOfHalls;
            numberOfHall = 1;
            temp = new Node();
        }
        public void Create()
        {
            CreateNode(root);
        }
        public void DisplayTimeTable()
        {
            SearchMinTime(root);
            PrintTimeTable(root);  
        }


        private void CreateNode(Node node)
        {
            for (int i = 0; i < node.films.Count; i++) //перебираем сеансы
            {

                if ((node.films[i].filmDuration <= node.timeLeft)) // если осталось время
                {

                    Node newNode; //создаётся новая нода

                    //заполнение времени начала и конца сеанса фильма
                    List<Seans> seanses = new List<Seans> (node.Seanses);
                    if (node.Seanses.Count == 0)
                    {
                        seanses.Add(new Seans($"{node.films[i].fileName}", new DateTime(2020, 1, 1, 8, 0, 0), 
                                          new DateTime(2020, 1, 1, 8, 0, 0).AddMinutes(node.films[i].filmDuration) ));
                    }
                    else
                    {
                        seanses.Add(new Seans($"{node.films[i].fileName}", node.Seanses[node.Seanses.Count - 1].filmEnd, 
                                        node.Seanses[node.Seanses.Count-1].filmEnd.AddMinutes(node.films[i].filmDuration)));
                    }

                    newNode = new Node(node.timeLeft - node.films[i].filmDuration, node.films, seanses, node.list);

                    node.Children.Add(newNode); //список дочерних элементов 

                    CreateNode(newNode); //рекурсия, пока не закончится время
                }
            }
        }

        private bool NodeCompare(Node node1, Node node2)
        {
            if (node1.Seanses.Count != node2.Seanses.Count) return false;
            else 
            {
                for (int i = 0; i < node1.Seanses.Count; i++)
                {
                    if (node1.Seanses[i].filmName != node2.Seanses[i].filmName)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void SearchMinTime(Node node)
        {
            if (node.Children.Count != 0)
            {
                foreach (Node i in node.Children)
                {
                    if (node.timeLeft < root.timeLeft && node.timeLeft < minTimeLeft)
                    {
                        minTimeLeft = node.timeLeft;
                    }
                    SearchMinTime(i);
                } 
            }
            foreach (Film i in root.films) 
            {
                if (i.filmDuration < minFilmDuration)
                {
                    minFilmDuration = i.filmDuration;
                }
            }
        } 

        private void PrintTimeTable(Node node)
        {
            if (node.Children.Count != 0)
            {
                foreach (Node i in node.Children)
                {
                    PrintTimeTable(i);
                }
            }
            else
            {
                while (numberOfHall <= countOfHalls)
                {
                    if (node.timeLeft == minTimeLeft - minFilmDuration && !NodeCompare(temp, node))
                    {
                        temp = node;
                        Console.WriteLine($"Расписание в зале № {numberOfHall}:");
                        for (int i = 0; i < node.Seanses.Count; i++)
                        {
                            Console.WriteLine($"{node.Seanses[i].filmStart.ToShortTimeString()} - {node.Seanses[i].filmEnd.ToShortTimeString()} : {node.Seanses[i].filmName}");
                        }
                        Console.WriteLine($"свободное оставшееся время: {node.timeLeft} минут \n");
                        numberOfHall++;
                    }
                    if (numberOfHall == countOfHalls)
                    {
                        return;
                    }
                   
                }
                
            }
        }

    }
}
