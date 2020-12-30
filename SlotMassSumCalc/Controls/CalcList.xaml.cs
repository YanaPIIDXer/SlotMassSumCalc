using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlotMassSumCalc.Controls
{
	/// <summary>
	/// 計算用リスト
	/// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalcList : ContentView
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalcList()
		{
			InitializeComponent();
		}

		private void AddButton_Clicked(object sender, EventArgs e)
		{
			ListBody.Children.Add(new CalcListItem());
		}
	}
}
