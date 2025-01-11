using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewooo
{
    internal class BST
    {
        private NodeT root;

        public void Add(int liczba)
        {
            if (root == null)
            {
                root = new NodeT(liczba);
            }
            else
            {
                AddRecursive(root, liczba);
            }
        }

        private void AddRecursive(NodeT current, int liczba)
        {
            if (liczba < current.data)
            {
                if (current.lewe == null)
                {
                    current.lewe = new NodeT(liczba) { rodzic = current };
                }
                else
                {
                    AddRecursive(current.lewe, liczba);
                }
            }
            else
            {
                if (current.prawe == null)
                {
                    current.prawe = new NodeT(liczba) { rodzic = current };
                }
                else
                {
                    AddRecursive(current.prawe, liczba);
                }
            }
        }

        public void Remove(int liczba)
        {
            root = RemoveRecursive(root, liczba);
        }

        private NodeT RemoveRecursive(NodeT current, int liczba)
        {
            if (current == null) return null;

            if (liczba < current.data)
            {
                current.lewe = RemoveRecursive(current.lewe, liczba);
            }
            else if (liczba > current.data)
            {
                current.prawe = RemoveRecursive(current.prawe, liczba);
            }
            else
            {
                if (current.lewe == null)
                {
                    return current.prawe;
                }
                else if (current.prawe == null)
                {
                    return current.lewe;
                }

                current.data = FindMin(current.prawe).data;
                current.prawe = RemoveRecursive(current.prawe, current.data);
            }
            return current;
        }

        private NodeT FindMin(NodeT node)
        {
            while (node.lewe != null)
            {
                node = node.lewe;
            }
            return node;
        }
        public void Clear()
        {
            root = null;
        }

        public void DisplayTree(TreeView treeView)
        {
            treeView.Nodes.Clear();
            if (root != null)
            {
                treeView.Nodes.Add(CreateTreeNode(root));
            }
        }

        private TreeNode CreateTreeNode(NodeT node)
        {
            TreeNode treeNode = new TreeNode(node.data.ToString());
            if (node.lewe != null)
            {
                treeNode.Nodes.Add(CreateTreeNode(node.lewe));
            }
            if (node.prawe != null)
            {
                treeNode.Nodes.Add(CreateTreeNode(node.prawe));
            }
            return treeNode;
        }
    }
}
