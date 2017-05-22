﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    public class FileToNode
    {
        private string _path;

        public FileToNode(string path)
        {
            _path = path;
        }

        public Node[][] ReadFile()
        {
            string[] contents = File.ReadAllLines(_path);
            string dimensionsLine = contents[0];
            int widthOfMaze = int.Parse(dimensionsLine.Substring(0, dimensionsLine.IndexOf(" ")));
            int heightOfMaze = int.Parse(dimensionsLine.Substring(dimensionsLine.IndexOf(" ")));

            string startLine = contents[1];
            int startX = int.Parse(startLine.Substring(0, startLine.IndexOf(" ")));
            int startY = int.Parse(startLine.Substring(startLine.IndexOf(" ")));

            string endLine = contents[2];
            int endX = int.Parse(endLine.Substring(0, endLine.IndexOf(" ")));
            int endY = int.Parse(endLine.Substring(endLine.IndexOf(" ")));

            Node[][] nodeArr = new Node[heightOfMaze][];
            int lineCount = 3;

            for (int i = 0; i < heightOfMaze; ++i)
            {
                string[] line = contents[3].Split(' ');
                var n = new List<Node>();
                foreach (var l in line)
                {
                    n.Add(new Node())
                }

                nodeArr[i];
            }

            return null;
        }
    }
}