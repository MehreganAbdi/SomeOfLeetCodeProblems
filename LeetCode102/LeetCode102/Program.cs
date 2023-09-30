namespace LeetCode102
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}
		public static IList<IList<int>> LevelOrder(TreeNode root)
		{
			IList<IList<int>> result = new List<IList<int>>();
			if (root == null) return result;
			var q = new Queue<TreeNode>();
			q.Enqueue(root);

			while (true)
			{
				var levelCounts = q.Count;
				if (levelCounts == 0) break;

				var eachLevel = new List<int>();
				while (levelCounts > 0)
				{
					var curVal = q.Dequeue();
					if (curVal != null)
					{
						eachLevel.Add(curVal.val);
					}
					if (curVal.left != null)
					{
						q.Enqueue(curVal.left);
					}
					if(curVal.right!= null)
					{
						q.Enqueue(curVal.right);
					}
					levelCounts--;

				}
				result.Add(eachLevel);
			}

			
			return result;
		}
	}
}