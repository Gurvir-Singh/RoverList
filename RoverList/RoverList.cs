using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here

        Node RootNode = null;

        public RoverList() { }

        public RoverList (T DataForRootNode)
        {
            RootNode = new RoverListBase<T>.Node(DataForRootNode);
        }

        public override int Count => GetCount();

        //done
        public override void Add(T data)
        {
            if (RootNode == null)
            {
                RootNode = new RoverListBase<T>.Node(data);
                
            }
            else
            {
                Node LastNode = GetNode(this.GetCount() - 1);
                LastNode.Next = new RoverListBase<T>.Node(data);
                
            }
        }

        //done
        public override void Add(T data, int Position)
        {
            Node NewNode = new RoverListBase<T>.Node(data);
            
            if (Position == 0)
            {
                NewNode.Next = RootNode;
                RootNode = NewNode;
            }
            else
            {

                Node LeftNode = GetNode(Position-1);
                Node RightNode = GetNode(Position);
                LeftNode.Next = NewNode;
                NewNode.Next = RightNode;
                
            }
        }
        //done
        public override void Clear()
        {
            for (int i = this.GetCount()-1; i > 0; i--)
            {
                this.GetNode(i).Next = null;
            }
            RootNode = null;
        }

        public override T ElementAt(int Position)
        {
            return this.GetNode(Position).Data;
        }

        //done
        public override void ListNodes()
        {
            for (int i = 0; i < this.GetCount(); i++)
            {
                Console.WriteLine("[{0}]: {1}", i, this.GetNode(i).Data);
            }
        }

        //done
        public override bool RemoveAt(int Position)
        {
            if (Position == 0)
            {
                RootNode = RootNode.Next;
                return true;
            }
            else
            {
                if (Position > this.Count-1)
                {
                    return false;
                }
                Node CurrentNode = this.GetNode(Position - 1);
                CurrentNode.Next = CurrentNode.Next.Next;
                return true;
            }
        }

        
        public int GetCount()
        {
            if (RootNode == null)
            {
                return 0;
            }
            int count = 0;
            Node currentPos = RootNode;
            while (currentPos != null)
            {
                count++;
                currentPos = currentPos.Next;
            }
            return count;
        }

        public Node GetNode(int position)
        {
            if (position > this.GetCount() - 1)
            {
                return null;
            }
            Node result = RootNode;
            int i = 0;
            while (i != position)
            {
                result = result.Next;
                i++;
            }
            return result;
        }
    }
}
