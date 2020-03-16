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
            CreateListOfTimetableByHalls(); // распределяем листы по залам
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

        private void CreateListOfTimetableByHalls()
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

                        if ((int)Math.Floor((double)(i / root.Films.Count)) < root.Films.Count) 
                        {
                            temp.Add(listOfTimetableByHalls[i % root.Films.Count][(int)Math.Floor((double)(i / root.Films.Count))]);
                        }
                        else
                        {
                            temp.Add(listOfTimetableByHalls[i % root.Films.Count][root.Films.Count-1]);
                        }
                    }
                }
                listOfTimetableByHalls.Add(temp);
            }
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
                #region byAll
                //for (int i = 0; i < listOfAllTimatable.Count - templistOfTimatable.Count; i++)
                //{
                //    templistOfTimatable[0] = listOfAllTimatable[i];
                //    for (int j = i + 1; j < listOfAllTimatable.Count - templistOfTimatable.Count + 1; j++)
                //    {
                //        templistOfTimatable[1] = listOfAllTimatable[j];
                //        if (templistOfTimatable.Count > 2)
                //        {
                //            for (int k = i + 2; k < listOfAllTimatable.Count - templistOfTimatable.Count + 2; k++)
                //            {
                //                templistOfTimatable[2] = listOfAllTimatable[k];
                //                if (FilmIsMeet(templistOfTimatable))
                //                {
                //                    optimalTimetable = templistOfTimatable;
                //                    return;
                //                }
                //            }
                //        }
                //        if (FilmIsMeet(templistOfTimatable))
                //        {
                //            optimalTimetable = templistOfTimatable;
                //            return;
                //        }
                //    }
                //}
                #endregion

                for (int i = 0; i < listOfTimetableByHalls[0].Count; i++)
                {
                    templistOfTimatable[0] = listOfTimetableByHalls[0][i];
                    for (int j = 0; j < listOfTimetableByHalls[1].Count; j++)
                    {
                        templistOfTimatable[1] = listOfTimetableByHalls[1][j];
                        if (templistOfTimatable.Count > 2)
                        {
                            for (int k = 0; k < listOfTimetableByHalls[2].Count; k++)
                            {
                                templistOfTimatable[2] = listOfTimetableByHalls[2][k];
                                if (FilmIsMeet(templistOfTimatable))
                                {
                                    optimalTimetable = templistOfTimatable;
                                    return;
                                }
                            }
                        }
                        if (FilmIsMeet(templistOfTimatable))
                        {
                            optimalTimetable = templistOfTimatable;
                            return;
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
    }
}
