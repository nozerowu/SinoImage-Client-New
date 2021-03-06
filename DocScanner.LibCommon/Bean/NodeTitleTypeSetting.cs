using DocScanner.LibCommon;
using System;

namespace DocScanner.Bean
{
    public class NodeTitleTypeSetting
	{
		public static ENFileNodeTitleType FileNodeTitleType
		{
			get
			{
				string configParamValue = AppContext.GetInstance().Config.GetConfigParamValue("LeftPaneSetting", "FileNodeTitleType");
				ENFileNodeTitleType result;
				if (string.IsNullOrEmpty(configParamValue))
                {
					result = ENFileNodeTitleType.FileName;
				}
				else
				{
					object obj = Enum.Parse(typeof(ENFileNodeTitleType), configParamValue);
					result = (ENFileNodeTitleType)obj;
				}
				return result;
			}
			set
			{
				AppContext.GetInstance().Config.SetConfigParamValue("LeftPaneSetting", "FileNodeTitleType", value.ToString());
			}
		}
	}
}
