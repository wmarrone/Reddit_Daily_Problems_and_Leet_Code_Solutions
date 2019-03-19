using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeBinaryTrees
{
    class MergeBinaryTrees
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if(t1 == null) { return t2; }
            if(t2 == null) { return t1; }
            t1.val += t2.val;
            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);
            return t1;
        }
        static void Main(string[] args)
        {
            TreeNode n = new TreeNode(1);
            n.left = new TreeNode(3);
            n.right = new TreeNode(2);

            TreeNode n2 = new TreeNode(2);
            n2.left = new TreeNode(1);
            n2.right = new TreeNode(3);

            MergeBinaryTrees solution = new MergeBinaryTrees();
            Console.WriteLine(solution.MergeTrees(n, n2));
            Console.ReadKey();
        }
    }
}
