using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SlotMassSumCalc.Models
{
	/// <summary>
	/// カウントデータ
	/// </summary>
	public class CountData : INotifyPropertyChanged
	{
		/// <summary>
		/// ゲーム数
		/// </summary>
		public int Games
		{
			get { return _Games; }
			private set
			{
				_Games = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Games)));
			}
		}
		private int _Games = 0;

		/// <summary>
		/// BIG回数
		/// </summary>
		public int Bigs
		{
			get { return _Bigs; }
			private set
			{
				_Bigs = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bigs)));
			}
		}
		private int _Bigs = 0;

		/// <summary>
		/// REG回数
		/// </summary>
		public int Regs
		{
			get { return _Regs; }
			private set
			{
				_Regs = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Regs)));
			}
		}
		private int _Regs = 0;

		/// <summary>
		/// プロパティ変更イベント
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged = delegate { };
	}
}
