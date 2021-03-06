using System;
using MonoTouch.UIKit;

namespace styling
{
	public static class Resources
	{

		public static UIImage KickstarterIcon = UIImage.FromBundle("images/icons/kickstarter.png");
		public static UIImage ActivityIcon = UIImage.FromBundle("images/icons/activity.png");
		public static UIImage ProfileIcon = UIImage.FromBundle("images/icons/profile.png");

		public static UIImage NavBarBackground = UIImage.FromBundle("images/navbar.png");
		public static UIImage ProjectBackground = UIImage.FromBundle("images/projectbackground.png").CreateResizableImage(new UIEdgeInsets(20,20,20,20));

		public static UIImage ProgressImageGrey = UIImage.FromBundle("images/progress-background.png").CreateResizableImage(new UIEdgeInsets(0,4,0,4));
		public static UIImage ProgressImageGreen = UIImage.FromBundle("images/progress-foreground.png").CreateResizableImage(new UIEdgeInsets(0,4,0,4));

		public static UIImage KickstarterLogo = UIImage.FromBundle("images/logo.png");
		public static UIImage ActivityBackground = UIImage.FromBundle("images/activity-background.png").CreateResizableImage(new UIEdgeInsets(52,5,5,5));

		public static UIImage PlayButton = UIImage.FromBundle("images/play-image.png");

		public static UIImage CellBackgroundTop = UIImage.FromBundle("images/cell_top.png").CreateResizableImage(new UIEdgeInsets(5,5,2,5));
		public static UIImage CellBackgroundMiddle = UIImage.FromBundle("images/cell_middle.png").CreateResizableImage(new UIEdgeInsets(2,5,2,5));
		public static UIImage CellBackgroundBottom = UIImage.FromBundle("images/cell_bottom.png").CreateResizableImage(new UIEdgeInsets(0,5,5,5));
		public static UIImage CellBackgroundFull = UIImage.FromBundle("images/cell_full.png").CreateResizableImage(new UIEdgeInsets(5,5,5,5));
		public static UIImage CellBackgroundTopActive = UIImage.FromBundle("images/cell_top_active.png").CreateResizableImage(new UIEdgeInsets(5,5,2,5));
		public static UIImage CellBackgroundMiddleActive = UIImage.FromBundle("images/cell_middle_active.png").CreateResizableImage(new UIEdgeInsets(2,5,2,5));
		public static UIImage CellBackgroundBottomActive = UIImage.FromBundle("images/cell_bottom_active.png").CreateResizableImage(new UIEdgeInsets(0,5,5,5));
		public static UIImage CellBackgroundFullActive = UIImage.FromBundle("images/cell_full_active.png").CreateResizableImage(new UIEdgeInsets(5,5,5,5));
		public static UIImage CellBackgroundFullActivePlain = UIImage.FromBundle("images/cell_full_active_plain.png").CreateResizableImage(new UIEdgeInsets(5,5,5,5));

	}

	public static class Colors
	{
		public static UIColor ProjectGrey = "979797".ToUIColor();
		public static UIColor TableBackgroundGrey = "e5e8e3".ToUIColor();
		public static UIColor SecondaryTextColor = UIColor.LightGray;
		public static UIColor PrimaryTextColor = UIColor.Black;
	}

	public static class Fonts 
	{
		public static UIFont PrimaryFont(float size)
		{
			return UIFont.SystemFontOfSize(size);
		}

		public static UIFont BoldPrimaryFont(float size)
		{
			return UIFont.BoldSystemFontOfSize(size);
		}
	}
}

