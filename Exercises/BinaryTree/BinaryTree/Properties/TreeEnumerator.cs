using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Properties
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        public TreeEnumerator(Tree<TItem> data)
        {
            this.currentData = data; // initializes 
        }
        private Tree<TItem> currentData = null;
        private TItem currentItem = default(TItem); //implements a queue 
        private Queue<TItem> enumData = null;
        TItem IEnumerator<TItem>.Current
        {
            get
            {
                if (this.enumData == null)
                {
                    throw new InvalidOperationException("Use MoveNext before calling Current");
                }
                return this.currentItem;
            }
        }
        object IEnumerator.Current => throw new NotImplementedException();

        private void populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if (tree.LeftTree != null)
            {
                populate(enumQueue, tree.LeftTree); //if lefttree  not null it calls itself 
            }
            enumQueue.Enqueue(tree.NodeData);
            if (tree.RightTree != null)
            {
                populate(enumQueue, tree.RightTree);
            }
        }

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()  // this is a boolean method 
        {
            if (this.enumData == null)
            {
                this.enumData = new Queue<TItem>(); //instantiates A new queue data 
                populate(this.enumData, this.currentData);
            }
            if (this.enumData.Count > 0)
            {
                this.currentItem = this.enumData.Dequeue();
                return true;
            }
            return false;
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
