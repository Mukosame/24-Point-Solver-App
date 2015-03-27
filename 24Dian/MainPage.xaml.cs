﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace _24Dian
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Here are the functions used in calculation
        //int treat(float a, float b, float c, float d);
        //float myF(int flag, float m, float n);
        //void myPrint(int type, int i, int j, int k, float a, float b, float c, float d);
        int num1, num2, num3, num4;
        int i=0, j=0, k=0, t=0;
        int res;
        int temp=0;
        int flag;
        //new float num[4];
        float[] num = new float[] { 0, 0, 0, 0 };
        String SelectedText;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        //judge if is int 1~13
        /*
        protected bool isNumeric(string message)
        {
            System.Text.RegularExpressions.Regex rex =
                    new System.Text.RegularExpressions.Regex(@"^\d+$");
            result = -1;
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                return true;
            }
            else
                return false;
        }
         * */

        //get number
        //text changed
        //1
        private void t1changed(object sender,TextChangedEventArgs e)
        {
            int result = -1;
            bool done=false;
            String message = textbox1.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");            
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done==true)
            {
                num1 = result;
                check1.Text = "✔";
            }
            else
            { check1.Text = "⛔"; }
        }
        //2
        private void t2changed(object sender, TextChangedEventArgs e)
        {
            int result = -1;
            bool done = false;
            String message = textbox2.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num2 = result;
                check2.Text = "✔";
            }
            else
            { check2.Text = "⛔"; }
        }
        //3
        private void t3changed(object sender, TextChangedEventArgs e)
        {
            int result = -1;
            bool done = false;
            String message = textbox3.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num3 = result;
                check3.Text = "✔";
            }
            else
            { check3.Text = "⛔"; }
        }

                //4
        private void t4changed(object sender, TextChangedEventArgs e)
        {
            int result = -1;
            bool done = false;
            String message = textbox4.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num4 = result;
                check4.Text = "✔";
            }
            else
            { check4.Text = "⛔"; }
        }

        //Text Selected
        //1
        private void s1changed(object sender, RoutedEventArgs e)
        {
            SelectedText = textbox1.SelectedText;
        }

        //2
        private void s2changed(object sender, RoutedEventArgs e)
        {
            SelectedText = textbox2.SelectedText;
        }

        //3
        private void s3changed(object sender, RoutedEventArgs e)
        {
            SelectedText = textbox3.SelectedText;
        }

        //4
        private void s4changed(object sender, RoutedEventArgs e)
        {
            SelectedText = textbox4.SelectedText;
        }

        //Text paste
        //1
        private void p1paste(object sender, TextControlPasteEventArgs e)
        {
            SelectedText = textbox1.SelectedText;
            int result = -1;
            bool done = false;
            String message = textbox1.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num1 = result;
                check1.Text = "✔";
            }
            else
            { check1.Text = "⛔"; }
        }

        //2
        private void p2paste(object sender, TextControlPasteEventArgs e)
        {
            SelectedText = textbox2.SelectedText;
            int result = -1;
            bool done = false;
            String message = textbox2.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num2 = result;
                check2.Text = "✔";
            }
            else
            { check2.Text = "⛔"; }
        }

        //3
        private void p3paste(object sender, TextControlPasteEventArgs e)
        {
            SelectedText = textbox3.SelectedText;
            int result = -1;
            bool done = false;
            String message = textbox3.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num3 = result;
                check3.Text = "✔";
            }
            else
            { check3.Text = "⛔"; }
        }

        //4
        private void p4paste(object sender, TextControlPasteEventArgs e)
        {
            SelectedText = textbox4.SelectedText;
            int result = -1;
            bool done = false;
            String message = textbox4.Text;
            System.Text.RegularExpressions.Regex rex =
        new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { done = true; }
            }
            else
                done = false;
            //judgement finished
            if (done == true)
            {
                num4 = result;
                check4.Text = "✔";
            }
            else
            { check4.Text = "⛔"; }
        }
        //Begin to calculate
        private void ok(object sender, RoutedEventArgs e)
        {
            int y = num1 * num2 * num3 * num4;
            if (y != 0)
            {
                //float = int
                num[1] = num1;
                num[2] = num2;
                num[3] = num3;
                num[4] = num4;
                calculate();
            }
            else
                output.Text = "输入数值有误，请按照提示重新输入";
        }

        private void calculate()
        {
            for (i=0;i<4;i++)
			for (j=0;j<4;j++)
				if (j!=i)
					for (k=0;k<4;k++)
						if (k!=j && k!=i)
							for (t=0;t<4;t++)
								if (t!=i && t!=j && t!=k)
								{
									res=treat(num[i],num[j],num[k],num[t]);
								}
	if (res==0)
		output.Text = "抱歉，无解";
	else ;
        }

        int treat(float a, float b, float c, float d)
        {
            int i, j, k;
            float sum1, sum2, sum3;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 6; j++)
                    for (k = 0; k < 6; k++)
                    {
                        if ((!(i == 3 && b == 0)) && (!(j == 3 && c == 0)) && (!(k == 3 && d == 0)))
                        {
                            sum1 = myF(i, a, b);
                            sum2 = myF(j, sum1, c);
                            sum3 = myF(k, sum2, d);
                            if (Math.Abs(sum3 - 24) < 0.1)
                            {
                                temp++;
                                myPrint(1, i, j, k, a, b, c, d);
                                //	printf ("sum1:myF(%d,%2.0f,%2.0f)  sum1=%f\n",i,a,b,sum1);
                                //	printf ("sum2:myF(%d,%2.0f,%2.0f)  sum2=%f\n",j,c,d,sum2);
                                //	printf ("1:myF(%d,myF(%d,myF(%d,%2.0f,%2.0f),%2.0f),%2.0f)   sum3=%f\n\n",k,j,i,a,b,c,d,sum3);
                            }
                        }
                        if (k == 2)
                        {
                            sum1 = myF(i, a, b);
                            sum2 = myF(j, c, d);
                            sum3 = sum1 * sum2;
                            if (Math.Abs(sum3 - 24) < 0.1)
                            {
                                temp++;
                                myPrint(2, i, j, k, a, b, c, d);
                                //	printf ("sum1:myF(%d,%2.0f,%2.0f)  sum1=%f\n",i,a,b,sum1);
                                //	printf ("sum2:myF(%d,%2.0f,%2.0f)  sum2=%f\n",j,c,d,sum2);
                                //	printf ("2:myF(%d,myF(%d,%2.0f,%2.0f),myF(%d,%2.0f,%2.0f))   sum3=%f\n\n",k,i,a,b,j,c,d,sum3);
                            }
                        }

                        if (k == 3)
                        {
                            sum1 = myF(i, a, b);
                            sum2 = myF(j, c, d);
                            if (sum2 != 0)
                            {
                                sum3 = sum1 / sum2;
                                if (Math.Abs(sum3 - 24) < 0.1)
                                {
                                    temp++;
                                    myPrint(3, i, j, k, a, b, c, d);
                                    //	printf ("sum1:myF(%d,%2.0f,%2.0f)  sum1=%f\n",i,a,b,sum1);
                                    //	printf ("sum2:myF(%d,%2.0f,%2.0f)  sum2=%f\n",j,c,d,sum2);
                                    //	printf ("3:myF(%d,myF(%d,%2.0f,%2.0f),myF(%d,%2.0f,%2.0f))   sum3=%f\n\n",k,i,a,b,j,c,d,sum3);
                                }
                            }
                        }
                    }
            if (temp == 0)
                return 0;
            else
                return 1;
        }

        float myF(int flag, float m, float n)
        {
            //	time++;
            if (flag == 0)
                return (m + n);
            if (flag == 1)
                return (m - n);
            if (flag == 2)
                return (m * n);
            if (flag == 3)
                if (n == 0)
                    return 30000;
                else
                    return (m / n);
            if (flag == 4)
                return (n - m);
            if (flag == 5)
                if (m == 0)
                    return 30000;
                else
                    return (n / m);
            return 0;
        }

        void myPrint(int type,int i,int j,int k,float a,float b,float c,float d)
{
            char[] sigle = new char[6];
	//char sigle[6];
		sigle[0]='+';
		sigle[1]='-';
		sigle[2]='*';
		sigle[3]='/';
		sigle[4]='-';
		sigle[5]='/';
	if (type==1){
		if(j==4 || j==5)
		{
			if (k==4 || k==5)
				output.Text= ("%2.0f %c (%2.0f %c (%2.0f %c %2.0f)) =24\n",d,sigle[k],c,sigle[j],a,sigle[i],b);
			else
				printf("(%2.0f %c (%2.0f %c %2.0f)) %c %2.0f =24\n",c,sigle[j],a,sigle[i],b,sigle[k],d);
		}
		else if (k==4 || k==5)
		{
			printf("%2.0f %c ((%2.0f %c %2.0f) %c %2.0f) =24\n",d,sigle[k],a,sigle[i],b,sigle[j],c);
		}
		else
			printf("((%2.0f %c %2.0f) %c %2.0f) %c %2.0f =24\n",a,sigle[i],b,sigle[j],c,sigle[k],d);
	}
	if (type==2 || type==3)
	{
	//	if (k==4 || k==5)
	//		printf("(%2.0f %c %2.0f) %c (%2.0f %c %2.0f)=24\n",c,sigle[j],d,sigle[k],a,sigle[i],b);
	//	else
			printf("(%2.0f %c %2.0f) %c (%2.0f %c %2.0f) =24\n",a,sigle[i],b,sigle[k],c,sigle[j],d);
	}
}					

        //Info Page
        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new Uri("/Info_Page.xaml", UriKind.Relative));
            Frame.Navigate(typeof(Info));
        }


        //
        //IF YOU WANT Add something here
        //
    }
}