namespace BinaryTree
{

    class Comparer
    {
        public static int Compare(object a, object b)
        {
            if (Convert.ToDouble(a) == Convert.ToDouble(b)) { return 0; }
            if (Convert.ToDouble(a) > Convert.ToDouble(b)) { return 1; }
            else { return -1; }
        }

    }
}