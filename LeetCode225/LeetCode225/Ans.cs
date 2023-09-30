

namespace LeetCode225
{

    public class MyStack
    {

        private Queue<int> stack = new Queue<int>();
        public MyStack()
        {
        }

        public void Push(int x)
        {
            stack.Enqueue(x);
        }

        public int Pop()
        {
            var arr = stack.ToArray();
            var x = arr[arr.Length - 1];
            stack.Clear();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                stack.Enqueue(arr[i]);
            }
            return x;
        }


        public int Top()
        {
            return stack.ToArray()[stack.Count-1];
        }

        public bool Empty()
        {

            return stack.Count == 0;
        }
    }
}
