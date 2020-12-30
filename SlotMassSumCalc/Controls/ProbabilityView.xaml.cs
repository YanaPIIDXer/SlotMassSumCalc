using SlotMassSumCalc.Models;
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
	/// 各種確率表示用コントロール
	/// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProbabilityView : ContentView
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ProbabilityView()
		{
			InitializeComponent();
		}

		/// <summary>
		/// データをセット
		/// </summary>
		/// <param name="Data">データ</param>
		public void SetData(CountData Data)
		{
			BigProb.BindingContext = Data;
			RegProb.BindingContext = Data;
			TotalProb.BindingContext = Data;
		}
	}
}