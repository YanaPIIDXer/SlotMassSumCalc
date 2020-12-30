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
		/// 値が更新された
		/// </summary>
		public Action OnUpdateValue { set; private get; }

		/// <summary>
		/// 消去された
		/// </summary>
		public Action<CalcListItem> OnRemove { set; private get; }

		/// <summary>
		/// データ
		/// </summary>
		protected CountData Data { get; } = new CountData();

		/// <summary>
		/// 複製したデータを生成して取得
		/// </summary>
		/// <returns>複製したデータ</returns>
		public CountData MakeDataClone()
		{
			return Data.Clone();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalcListItem()
		{
			InitializeComponent();
			GamesEntry.BindingContext = Data;
			BigsEntry.BindingContext = Data;
			RegsEntry.BindingContext = Data;
			ProbView.SetData(Data);
			Data.PropertyChanged += (sender, e) =>
			{
				switch(e.PropertyName)
				{
					case "Games":
					case "Bigs":
					case "Regs":
						OnUpdateValue.Invoke();
						break;
				}
			};
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			OnRemove.Invoke(this);
		}
	}
}