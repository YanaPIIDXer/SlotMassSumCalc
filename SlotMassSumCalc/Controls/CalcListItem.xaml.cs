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
	/// リストの要素コントロール
	/// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalcListItem : ContentView
	{
		/// <summary>
		/// 消去された
		/// </summary>
		public Action<CalcListItem> OnRemove { set; private get; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalcListItem()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			OnRemove.Invoke(this);
		}
	}
}