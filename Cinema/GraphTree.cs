using Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grafs
{
    public class GraphTree
    {
        Node root;
        int countOfHalls, numberOfHall;
        List<Node> listOfAllTimatable, optimalTimetable, templistOfTimatable;
        List<List<Node>> listOfTimetableByHalls;

        public GraphTree(Node node, int countOfHalls)
        {
            root = node;
            this.countOfHalls = countOfHalls;
            numberOfHall = 1;
            listOfAllTimatable = new List<Node>();
            listOfTimetableByHalls = new List<List<Node>>();
        }
        public void Create()
        {
            CreateNode(root);
        }
        public void DisplayTimeTable()
        {
            CreateListOfTimeTable(root); // создаем список всех возможных вариантов
            CreateListOfHalls(); // распределяем листы по залам
            CreateTempList(); // создаем первый вариант расписания
            OptimalTimetable(templistOfTimatable); // ищем оптимальное расписание
            Print(optimalTimetable); // выводим его
        }


        private void CreateNode(Node node)
        {
            for (int i = 0; i < node.Films.Count; i++) //перебираем сеансы 
            {

                if ((node.Films[i].FilmDuration <= node.TimeLeft)) // если осталось время
                {

                    Node newNode; //создаётся новая нода

                    //заполнение времени начала и конца сеанса фильма
                    List<Seans> seanses = new List<Seans> (node.Seanses);
                    if (node.Seanses.Count == 0)
                    {
                        seanses.Add(new Seans($"{node.Films[i].FileName}", new DateTime(2020, 1, 1, 8, 0, 0), 
                                          new DateTime(2020, 1, 1, 8, 0, 0).AddMinutes(node.Films[i].FilmDuration) ));
                    }
                    else
                    {
                        seanses.Add(new Seans($"{node.Films[i].FileName}", node.Seanses[node.Seanses.Count - 1].FilmEnd, 
                                        node.Seanses[node.Seanses.Count-1].FilmEnd.AddMinutes(node.Films[i].FilmDuration)));
                    }

                    newNode = new Node(node.TimeLeft - node.Films[i].FilmDuration, node.Films, seanses, node.List);
                    //newNode.Films[i].IsMeet = true;

                    node.Children.Add(newNode); //список дочерних элементов 

                    CreateNode(newNode); //рекурсия, пока не закончится время
                }
            }
        }


        private void CreateListOfTimeTable(Node node)
        {
            if (node.Children.Count != 0)
            {
                foreach (Node i in node.Children)
                {
                    CreateListOfTimeTable(i);
                }
            }
            else
            {
                listOfAllTimatable.Add(node);
            }
            listOfAllTimatable = listOfAllTimatable.OrderBy(u => u.TimeLeft).ToList<Node>();
        }

        private void CreateListOfHalls()
        {
            for (int i = 0; i < countOfHalls; i++)
            {
                List<Node> temp = new List<Node>();
                foreach (Node node in listOfAllTimatable)
                {
                    if (i < root.Films.Count)
                    {
                        if (node.Seanses[0].FilmName == root.Films[i].FileName)
                        {
                            temp.Add(node);
                        }
                    }
                    else
                    {
                        if (root.Films.Count == 1)
                        {
                            break;
                        }
                        temp.Add(listOfTimetableByHalls[i % root.Films.Count][(int)Math.Floor((double)(i / root.Films.Count))]);
                    }
                }
                listOfTimetableByHalls.Add(temp);
            }
        }

        private bool FilmIsMeet(List<Node> list)
        {
            bool isOk = true;
            bool[] filmsIsMet = new bool[root.Films.Count];

            for (int i = 0; i < root.Films.Count; i++)
            {
                foreach (Node nod in list)
                {
                    for (int j = 0; j < nod.Seanses.Count; j++)
                    {
                        if (nod.Seanses[j].FilmName == root.Films[i].FileName)
                        {
                            filmsIsMet[i] = true;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < filmsIsMet.Count(); i++)
            {
                isOk = isOk && filmsIsMet[i];
            }
            return isOk;
        }

        private void CreateTempList()
        {
            templistOfTimatable = new List<Node>();
            for (int i = 0; i < countOfHalls; i++)
            {
                templistOfTimatable.Add(listOfTimetableByHalls[i][0]);
            }
        }

        private void OptimalTimetable (List<Node> templistOfTimatable)
        {
            if (FilmIsMeet(templistOfTimatable))
            {
                optimalTimetable = templistOfTimatable;
                return;
            } 
            else
            {
                for (int k = 0; k < templistOfTimatable.Count; k++)
                {
                    for (int i = 0; i < listOfAllTimatable.Count - 1; i++)
                    {
                        templistOfTimatable[k] = listOfAllTimatable[i];
                        for (int j = i + 1; j < listOfAllTimatable.Count; j++)
                        {
                            templistOfTimatable.RemoveAt(templistOfTimatable.Count - 1);
                            templistOfTimatable.Add(listOfAllTimatable[j]);
                            if (FilmIsMeet(templistOfTimatable))
                            {
                                optimalTimetable = templistOfTimatable;
                                return;
                            }
                        }
                    }
                }
              
            }
            optimalTimetable = new List<Node>();
        }
        private void Print(List<Node> optimalTimetable)
        {
            if (optimalTimetable.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("nope");
                return;
            }
            else
            {
                for (int i = 0; i < optimalTimetable.Count; i++)
                {
                    Console.WriteLine($"Расписание в зале № {numberOfHall}:");
                    int TimeLeft = optimalTimetable[i].TimeLeft;
                    foreach (Seans seans in optimalTimetable[i].Seanses)
                    {
                        Console.WriteLine($"{seans.FilmStart.ToShortTimeString()} - {seans.FilmEnd.ToShortTimeString()} : {seans.FilmName}");
                    }
                    Console.WriteLine($"свободное оставшееся время: {TimeLeft} минут \n");
                    numberOfHall++;

                    if (numberOfHall > countOfHalls)
                    {
                        return;
                    }
                }     
            }       

        }      
    }
}
