using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace PictureResize
{
	public partial class MainWindow : Window
	{
		private double PictureWidth;
		private double PictureHeight;
		private double dW;
		private double dH;
		private TimeSpan ts;

		public MainWindow()
		{
			InitializeComponent();
			PictureWidth = imImage.Width;
			PictureHeight = imImage.Height;
			dW = 40;
			dH = 30;	
			ts = TimeSpan.FromMilliseconds(500);
		}

		
		private void imImage_MouseEnter(object sender, MouseEventArgs e)
		{
			DoubleAnimation da = new DoubleAnimation();
			da.From = PictureWidth;
			da.To = PictureWidth + dW;
			da.Duration = new Duration(ts);
			DoubleAnimation db = new DoubleAnimation();
			db.From = PictureHeight;
			db.To = PictureHeight + dH;
			db.Duration = new Duration(ts);
			imImage.BeginAnimation(WidthProperty, da);
			imImage.BeginAnimation(HeightProperty, db);
		}

		
		private void imImage_MouseLeave(object sender, MouseEventArgs e)
		{
			DoubleAnimation da = new DoubleAnimation();
			da.From = PictureWidth + dW;
			da.To = PictureWidth;
			da.Duration = new Duration(ts);
			
			DoubleAnimation db = new DoubleAnimation();
			db.From = PictureHeight + dH;
			db.To = PictureHeight;
			db.Duration = new Duration(ts);
			imImage.BeginAnimation(WidthProperty, da);
			imImage.BeginAnimation(HeightProperty, db);
		}
	}

}
