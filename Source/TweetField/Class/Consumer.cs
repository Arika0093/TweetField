using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TweetField
{
	class ConsumerValue
	{
		// Consumer Name
		public String	Name;
		// Consumer Key
		public String	Key;
		// Consumer Secret
		public String	Secret;
		// is Hidden
		public bool		HiddenItem;
	}

	class ConsumerList
	{
		// Constructor
		static ConsumerList(){
			ConsLists		= new List<ConsumerValue>();
			// This
			ConsLists.Add(new ConsumerValue{
				Name		= "TwiField",
				Key			= "iP9Fy2KPJCCdL0RdykFsg",
				Secret		= "OAphTSn77RXQ1CgrJTs6JukmOeJYYIqNamjd9F09s",
				HiddenItem	= false,
			});
			// Android
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for Android",
				Key			= "3nVuSoBZnx6U4vzUxf5w",
				Secret		= "Bcs59EFbbsdF6Sl9Ng71smgStWEGwXXKSjYvPVt7qys",
				HiddenItem	= true,
			});
			// Windows
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for Windows",
				Key			= "TgHNMa7WZE7Cxi1JbkAMQ",
				Secret		= "SHy9mBMBPNj3Y17et9BF4g5XeqS4y3vkeW24PttDcY",
				HiddenItem	= true,
			});
			// Windows Phone
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for Windows Phone",
				Key			= "yN3DUNVO0Me63IAQdhTfCA",
				Secret		= "c768oTKdzAjIYCmpSNIdZbGaG0t6rOhSFQP0S5uC79g",
				HiddenItem	= true,
			});
			// iPhone
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for iPhone",
				Key			= "IQKbtAYlXLripLGPWd0HUA",
				Secret		= "GgDYlkSvaPxGxC4X8liwpUoqKwwr3lCADbz8A7ADU",
				HiddenItem	= true,
			});
			// iPad
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for iPad",
				Key			= "CjulERsDeqhhjSme66ECg",
				Secret		= "IQWdVyqFxghAtURHGeGiWAsmCAGmdW3WmbEx6Hck",
				HiddenItem	= true,
			});
			// Mac
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for Mac",
				Key			= "3rJOl1ODzm9yZy63FACdg",
				Secret		= "5jPoQ5kQvMJFDYRNE8bQ4rHuds4xJqhvgNJM4awaE8",
				HiddenItem	= true,
			});
			// Google TV
			ConsLists.Add(new ConsumerValue{
				Name		= "Twitter for Google TV",
				Key			= "iAtYJ4HpUVfIUoNnif1DA",
				Secret		= "172fOpzuZoYzNYaU3mMYvE8m8MEyLbztOdbrUolU",
				HiddenItem	= true,
			});
			// Free Select
			ConsLists.Add(new ConsumerValue{
				Name		= "ユーザー指定",
				Key			= "",
				Secret		= "",
				HiddenItem	= false,
			});
		}
		// Consumer List
		public static List<ConsumerValue>
						ConsLists;
	}
}
