using System;

namespace Blazor.ECharts.Options
{
	/// <summary>
	/// Chart加载UI选项
	/// </summary>
	public class LoadingOption
	{
		/// <summary>
		/// 显示文字
		/// </summary>
		public string Text { get; set; } = "loading";

		/// <summary>
		/// 旋转环颜色
		/// </summary>
		public string Color { get; set; } = "#c23531";

		/// <summary>
		/// 文字颜色
		/// </summary>
		public string TextColor { get; set; } = "#000";

		/// <summary>
		/// 遮罩层颜色
		/// </summary>
		public string MaskColor { get; set; } = "rgba(255, 255, 255, 0.8)";

		/// <summary>
		/// 文字尺寸
		/// </summary>
		public int FontSize { get; set; } = 12;

		/// <summary>
		/// 是否显示旋转环
		/// </summary>
		public bool ShowSpinner { get; set; } = true;

		/// <summary>
		/// 旋转环半径
		/// </summary>
		public int SpinnerRadius { get; set; } = 10;

		/// <summary>
		/// 旋转环线条宽度
		/// </summary>
		public int LineWidth { get; set;} = 5;

		/// <summary>
		/// 字体磅重
		/// </summary>
		public string FontWeight { get; set; } = "normal";

		/// <summary>
		/// 字体风格
		/// </summary>
		public string FontStyle { get; set; } = "normal";

		/// <summary>
		/// 字体名称
		/// </summary>
		public string FontFamily { get; set; } = "sans-serif";

		/// <summary>
		/// 转化为JSON字符串
		/// </summary>
		/// <returns>JSON字符串</returns>
		public override string ToString()
		{
			return EChartsOptionSerializer.Default.Serialize(this);
		}
	}
}
