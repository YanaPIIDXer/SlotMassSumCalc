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
		/// ゲーム数
		/// </summary>
		public int Games { get; private set; } = 0;

		/// <summary>
		/// BIG回数
		/// </summary>
		public int Bigs { get; private set; } = 0;

		/// <summary>
		/// REG回数
		/// </summary>
		public int Regs { get; private set; } = 0;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalcListItem()
		{
			InitializeComponent();
			GamesEntry.BindingContext = this;
			BigsEntry.BindingContext = this;
			RegsEntry.BindingContext = this;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			OnRemove.Invoke(this);
		}
	}
}