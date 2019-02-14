using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Arithmetic_Operations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText input1, input2, op;
        Button plus, minus, product, divide;
        


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            input1 = FindViewById<EditText>(Resource.Id.editText1);
            input2 = FindViewById<EditText>(Resource.Id.editText2);
            op = FindViewById<EditText>(Resource.Id.editText3);
            plus = FindViewById<Button>(Resource.Id.button1);
            minus = FindViewById<Button>(Resource.Id.button2);
            product = FindViewById<Button>(Resource.Id.button3);
            divide = FindViewById<Button>(Resource.Id.button4);
            
            
                plus.Click += delegate
                {
                    if (input1.Text != "" && input2.Text != "")
                    {
                        double a = Convert.ToDouble(input1.Text);
                        double b = Convert.ToDouble(input2.Text);
                        op.Text = input1.Text + " + " + input2.Text + " = " + Convert.ToString((Convert.ToDouble(input1.Text)) + (Convert.ToDouble(input2.Text)));
                    }
                    else
                    {
                        Toast.MakeText(this, "Enter values first", ToastLength.Long).Show();
                        if (op.Text == "")
                        {

                        }
                        else if (op.Text != "")
                        {
                            op.Text = "";
                        }
                    }

                };

            minus.Click += delegate
            {
                if (input1.Text != "" && input2.Text != "")
                {
                    double a = Convert.ToDouble(input1.Text);
                    double b = Convert.ToDouble(input2.Text);
                    op.Text = input1.Text + " - " + input2.Text + " = " + Convert.ToString((Convert.ToDouble(input1.Text)) - (Convert.ToDouble(input2.Text)));
                }
                else
                {
                    give_error();
                }

            };

            product.Click += delegate
            {
                if (input1.Text != "" && input2.Text != "")
                {
                    double a = Convert.ToDouble(input1.Text);
                    double b = Convert.ToDouble(input2.Text);
                    op.Text = input1.Text + " * " + input2.Text + " = " + Convert.ToString((Convert.ToDouble(input1.Text)) * (Convert.ToDouble(input2.Text)));
                }
                else
                {
                    give_error();
                }

            };

            divide.Click += delegate
            {
                if (input1.Text != "" && input2.Text != "")
                {
                    double a = Convert.ToDouble(input1.Text);
                    double b = Convert.ToDouble(input2.Text);
                    op.Text = input1.Text+" / "+input2.Text+" = "+Convert.ToString((Convert.ToDouble(input1.Text)) / (Convert.ToDouble(input2.Text)));
                }
                else
                {
                    give_error();
                }

            };
        }
        public void give_error()
        {
            Toast.MakeText(this, "Enter values first", ToastLength.Long).Show();
            if (op.Text == "")
            {

            }
            else if (op.Text != "")
            {
                op.Text = "";
            }
        }

        

       

        
	}
}

