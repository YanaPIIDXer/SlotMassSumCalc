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
	/// 計算用リスト
	/// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalcList : ContentView
	{
		CountData TotalData = new CountData();

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalcList()
		{
			InitializeComponent();
			MassSumProb.SetData(TotalData);
		}

		private void AddButton_Clicked(object sender, EventArgs e)
		{
			var Item = new CalcListItem();
			Item.OnUpdateValue = Recalc;
			Item.OnRemove = (Removed) =>
			{
				ListBody.Children.Remove(Removed);
				Recalc();
			};
			ListBody.Children.Add(Item);
		}

		/// <summary>
		/// シマ合算の再計算
		/// </summary>
		private void Recalc()
		{
			int TotalGames = 0;
			int TotalBigs = 0;
			int TotalRegs = 0;
			foreach (CalcListItem Child in ListBody.Children)
			{
				var Data = Child.MakeDataClone();
				TotalGames += Data.Games;
				TotalBigs += Data.Bigs;
				TotalRegs += Data.Regs;
			}
			TotalData.Games = TotalGames;
			TotalData.Bigs = TotalBigs;
			TotalData.Regs = TotalRegs;
		}
	}
}
