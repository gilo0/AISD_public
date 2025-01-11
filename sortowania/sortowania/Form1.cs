using System.Net.Mail;

namespace sortowania
{
    public partial class Form1 : Form
    {

        int[] tab = new int[0];

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_bubble_Click(object sender, EventArgs e)
        {
            sorted.Text = string.Join(", ", BubbleSort(tab));
        }

        static void Swap(int[] tab, int i, int j)
        {
            int temp;
            temp = tab[i];
            tab[i] = tab[j];
            tab[j] = temp;
        }

        int[] BubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {

                    if (tab[i] < tab[j])
                    {
                        Swap(tab, i, j);
                    }

                }
            }
            return tab;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int[] newTab = new int[tab.Length + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                newTab[i] = tab[i];
            }
            newTab[tab.Length] = (int)addBox.Value;
            tab = newTab;
            list.Text = string.Join(", ", tab);
        }

        //int[] InsertSort(int[] tab)
        //{
        //    int temp;
        //    for (int i = 1; i < tab.Length; i++)
        //    {
        //        int flag = 0;
        //        for (int j = (i - 1); j >= 0 && flag != 1;)
        //        {
        //            if (tab[i] < tab[j])
        //            {
        //                temp = tab[i];
        //                tab[i] = tab[j];
        //                tab[j] = temp;
        //                i--; j--;
        //            }
        //            else
        //            {
        //                flag = 1;
        //            }
        //        }
        //    }
        //    return tab;
        // }

        static void InsertSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int flag = 0;
                for (int j = (i - 1); j >= 0 && flag == 0;)
                {
                    if (tab[i] < tab[j])
                    {
                        Swap(tab, i, j);
                        i--; j--;
                    }
                    else flag = 1;
                }
            }
        }


        private void button_insert_Click(object sender, EventArgs e)
        {
            InsertSort(tab);
            sorted.Text = string.Join(", ", tab);
        }

        static int Partition(int[] tab, int low, int high)
        {
            int pivot = tab[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;
                    Swap(tab, i, j);
                }
            }
            Swap(tab, i + 1, high);
            return i + 1;
        }

        static int Partition2(int[] tab, int low, int high)
        {
            int pivot = tab[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;
                    Swap(tab, i, j);
                }
            }
            Swap(tab, i + 1, high);
            return i + 1;
        }

        static void QuickSort(int[] tab, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition2(tab, low, high);

                QuickSort(tab, low, pi - 1);
                QuickSort(tab, pi + 1, high);
            }

        }

        private void button_quick_Click(object sender, EventArgs e)
        {
            QuickSort(tab, 0, tab.Length - 1);
            sorted.Text = string.Join(", ", tab);
        }

        private void clearArray_Click(object sender, EventArgs e)
        {
            int[] newtab = new int[0];
            tab = newtab;
            list.Clear();
            sorted.Clear();
        }

        static void CountingSort(int[] tab)
        {
            int max = tab.Max();
            int min = tab.Min();
            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                count[tab[i] - min]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = tab.Length - 1; i >= 0; i--)
            {
                output[count[tab[i] - min] - 1] = tab[i];
                count[tab[i] - min]--;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = output[i];
            }
        }

        private void button_counting_Click(object sender, EventArgs e)
        {
            CountingSort(tab);
            sorted.Text = string.Join(", ", tab);
        }

        private void MergeSort(int[] tablica, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(tablica, left, middle);
                MergeSort(tablica, middle + 1, right);

                Merge(tablica, left, middle, right);
            }
        }

        private void Merge(int[] tablica, int left, int middle, int right)
        {
            int[] leftArray = tablica.ToList().GetRange(left, middle - left + 1).ToArray();
            int[] rightArray = tablica.ToList().GetRange(middle + 1, right - middle).ToArray();

            int i = 0, j = 0, k = left;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    tablica[k++] = leftArray[i++];
                }
                else
                {
                    tablica[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length)
            {
                tablica[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                tablica[k++] = rightArray[j++];
            }
        }

        private void button_merge_Click(object sender, EventArgs e)
        {
            MergeSort(tab, 0, tab.Length-1);
            sorted.Text = string.Join(", ", tab);
        }
    }
}
