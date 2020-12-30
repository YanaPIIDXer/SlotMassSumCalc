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
			set
			{
				_Games = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Games)));
				UpdateProbs();
			}
		}
		private int _Games = 0;

		/// <summary>
		/// BIG回数
		/// </summary>
		public int Bigs
		{
			get { return _Bigs; }
			set
			{
				_Bigs = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bigs)));
				UpdateProbs();
			}
		}
		private int _Bigs = 0;

		/// <summary>
		/// REG回数
		/// </summary>
		public int Regs
		{
			get { return _Regs; }
			set
			{
				_Regs = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Regs)));
				UpdateProbs();
			}
		}
		private int _Regs = 0;

		/// <summary>
		/// BIG確率
		/// </summary>
		public float BigProb
		{
			get
			{
				return _BigProb;
			}
			set
			{
				_BigProb = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BigProb)));
			}
		}
		private float _BigProb = 0.0f;

		/// <summary>
		/// REG確率
		/// </summary>
		public float RegProb
		{
			get
			{
				return _RegProb;
			}
			set
			{
				_RegProb = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RegProb)));
			}
		}
		private float _RegProb = 0.0f;

		/// <summary>
		/// 合算
		/// </summary>
		public float TotalProb
		{
			get
			{
				return _TotalProb;
			}
			set
			{
				_TotalProb = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalProb)));

			}
		}
		private float _TotalProb = 0.0f;

		/// <summary>
		/// プロパティ変更イベント
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		/// <summary>
		/// デフォルトコンストラクタ
		/// </summary>
		public CountData() { }

		/// <summary>
		/// フルコンストラクタ
		/// </summary>
		/// <param name="Games">ゲーム数</param>
		/// <param name="Bigs">BIG回数</param>
		/// <param name="Regs">REG回数</param>
		public CountData(int Games, int Bigs, int Regs)
		{
			this.Games = Games;
			this.Bigs = Bigs;
			this.Regs = Regs;
			UpdateProbs();
		}

		/// <summary>
		/// 複製
		/// </summary>
		/// <returns>複製したデータ</returns>
		public CountData Clone()
		{
			return new CountData(Games, Bigs, Regs);
		}

		/// <summary>
		/// 各種確率の更新
		/// </summary>
		private void UpdateProbs()
		{
			BigProb = (Bigs != 0) ? (float)Games / Bigs : 0.0f;
			RegProb = (Regs != 0) ? (float)Games / Regs : 0.0f;
			if (BigProb == 0.0f || RegProb == 0.0f) TotalProb = Math.Max(BigProb, RegProb);
			else TotalProb = (BigProb * RegProb) / (BigProb + RegProb);
		}
	}
}
