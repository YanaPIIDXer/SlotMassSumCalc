using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SlotMassSumCalc.Models;

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
		/// データ
		/// </summary>
		private CountData Data = new CountData();

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalcListItem()
		{
			InitializeComponent();
			GamesEntry.BindingContext = Data;
			BigsEntry.BindingContext = Data;
			RegsEntry.BindingContext = Data;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			OnRemove.Invoke(this);
		}
	}
}