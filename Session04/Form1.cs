using Session04.UI;

namespace Session04
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 17, 19 };

        //Function First Class 
        //var i = 42

        private void Filter(Func<int, bool> cond)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (cond(numbers[i]))
                {
                    listBox1.Items.Add(numbers[i]);
                }
            }
        }
        private void buttonLambda_Click(object sender, EventArgs e)
        {
            /*
            //listBox1.Items.Clear();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        listBox1.Items.Add(numbers[i]);
            //    }
            //}
            */

            //Lambda Expression
            //Ananymous Function
            //Arraow(=>) Functiopn 

            //Map( (x) => {
            //    return x % 2 == 0;
            //});

            //Map(x => {
            //    return x % 2 == 0;
            //});

            var my = (int x) => x % 2 == 0;
            
            Filter(x => x % 2 == 0);
            Filter(x => x % 2 != 0);
            Filter(x => x <= 5 );


            //listBox1.Items.Clear();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        listBox1.Items.Add(numbers[i]);
            //    }
            //}


            //listBox1.Items.Clear();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        listBox1.Items.Add(numbers[i] * numbers[i]);
            //    }
            //}

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            var frm = new FormUser();
            frm.ShowDialog();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            var frm = new FormProduct();
            frm.ShowDialog();
        }

        
    }
}
